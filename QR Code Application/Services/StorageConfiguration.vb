Imports System.IO
Imports System.Text.Json

Public Class StorageConfigurationException
    Inherits Exception

    Public Sub New(message As String)
        MyBase.New(message)
    End Sub
End Class

Public Class StorageConfiguration
    Public Property WorkbookPath As String
    Public Property PrimaryQrFolder As String
    Public Property SecondaryQrFolder As String

    ' Resolve beside the executable, regardless of the shortcut's Start In folder.
    ' Reload for each operation so corrected settings do not require a rebuild.
    Public Shared Function Load(Optional configurationPath As String = Nothing) As StorageConfiguration
        Dim filePath = If(configurationPath, Path.Combine(AppContext.BaseDirectory, "appsettings.json"))
        Try
            Using document = JsonDocument.Parse(File.ReadAllText(filePath))
                Dim storage As JsonElement
                If document.RootElement.ValueKind <> JsonValueKind.Object OrElse
                   Not document.RootElement.TryGetProperty("Storage", storage) OrElse
                   storage.ValueKind <> JsonValueKind.Object Then
                    Throw New StorageConfigurationException("appsettings.json must contain a Storage object. Use appsettings.example.json as a guide.")
                End If
                Return New StorageConfiguration With {
                    .WorkbookPath = ReadPath(storage, "WorkbookPath"),
                    .PrimaryQrFolder = ReadPath(storage, "PrimaryQrFolder"),
                    .SecondaryQrFolder = ReadPath(storage, "SecondaryQrFolder")
                }
            End Using
        Catch ex As StorageConfigurationException
            Throw
        Catch ex As FileNotFoundException
            Throw New StorageConfigurationException("appsettings.json is missing from the application folder. Copy appsettings.example.json to appsettings.json and enter your storage paths.")
        Catch ex As JsonException
            Throw New StorageConfigurationException("appsettings.json contains invalid JSON. Check quotes, commas, and escaped backslashes using appsettings.example.json as a guide.")
        Catch ex As UnauthorizedAccessException
            Throw New StorageConfigurationException("The application cannot read appsettings.json. Check its file permissions.")
        Catch ex As IOException
            Throw New StorageConfigurationException("The application could not read appsettings.json. Check that the configuration file is accessible.")
        End Try
    End Function

    Private Shared Function ReadPath(storage As JsonElement, name As String) As String
        Dim value As JsonElement
        If Not storage.TryGetProperty(name, value) OrElse value.ValueKind <> JsonValueKind.String Then
            Throw New StorageConfigurationException("Set Storage." & name & " in appsettings.json to a full file or folder path.")
        End If
        Dim result = value.GetString().Trim()
        If String.IsNullOrWhiteSpace(result) OrElse result.IndexOfAny(Path.GetInvalidPathChars()) >= 0 OrElse
           Not Path.IsPathFullyQualified(result) Then
            Throw New StorageConfigurationException("Storage." & name & " in appsettings.json must be a full path, not a placeholder or relative path.")
        End If
        Return result
    End Function
End Class
