# QR Code Application

Windows Forms application for generating rollformer QR codes for wall, floor, ceiling, corner, and tee panels.

## Project structure

```text
QR Code Application/
  Forms/
    MainForm.vb                 Main menu and QR image lookup
    QrStringEditorForm.vb       QR string editor and preview
    Panels/
      WallPanelForm.vb
      FloorPanelForm.vb
      CeilingPanelForm.vb
      CornerPanelForm.vb
      TeePanelForm.vb
    Dialogs/
      FoamDateDialog.vb         Required foam-date selection
  Services/
    QrCodeService.vb            QR generation and Excel record writing
    StorageConfiguration.vb    Local configuration loading and validation
  My Project/                  Application startup, settings, and resources
```

Each designer-based form keeps its `.Designer.vb` and `.resx` beside its source. Visual Studio nests these files under the form in Solution Explorer. Edit layouts through the Windows Forms designer.

## Build and run

Open `QR Code Application.sln` in Visual Studio with the .NET desktop development workload and .NET 6 targeting support. Restore NuGet packages, then build and run. The startup screen is `MainForm`.

## Main workflows

- Select a panel type and open its editor to generate a QR code.
- Soft Part is selected by default. Soft parts require a foam date and write to `SoftParts`; hard parts skip the date and write to `HardParts`.
- Preview Only generates an image without saving the JPG or Excel record.
- Find an existing QR code by part number using the Find QR Code button or Enter in the part-number box.

## Shared files

Network locations are read from `appsettings.json` beside the executable. QR image lookup uses `PrimaryQrFolder`.

The application updates `QR Code Strings.xltm` directly. Keep the worksheet names `HardParts` and `SoftParts` unchanged. Hard-part records use column A for the image link, B for the part number, and C onward for QR fields. Soft-part records use A for the link, B for the foam date, C for the part number, and D onward for QR fields.

Opening a workbook copy from the template allows viewing without keeping the master open for editing. Directly editing the master template can still prevent the application from saving.
## Local configuration

The real `appsettings.json` contains company storage paths and is excluded from Git. A GitHub clone includes only `appsettings.example.json`; it does not include operational server paths. Git history cleanup is a separate step: older commits may still contain paths.

1. In the project folder (`QR Code Application`), copy `appsettings.example.json` to `appsettings.json`.
2. Replace all three placeholders inside `Storage`:
   - `WorkbookPath`: full path to the master `.xltm` workbook.
   - `PrimaryQrFolder`: folder for the primary JPG output and image finder.
   - `SecondaryQrFolder`: folder for the second JPG output.
3. Use absolute local or UNC paths. JSON requires each backslash to be doubled. For example, a fictitious UNC folder is written as `"\\\\SERVER\\Share\\QR Codes"`.
4. Build or publish. Visual Studio copies your real settings beside the executable automatically when the file exists. The example is also copied for setup assistance.

Missing, malformed, or incomplete settings display a configuration message. The application remains open; correct the file and retry. Paths are reloaded for each save or lookup, with no rebuild required. Validation checks the settings format; network connectivity, permissions, and workbook locks are checked when files are actually accessed.

## Shared-drive deployment

Copy the complete build or publish output to the shared application folder, including `appsettings.json`, the executable, DLLs, and runtime files. Keep shortcuts pointed at the executable. Settings are resolved relative to that executable, so a shortcut's working directory does not matter.

Keep a backup of the real configuration outside Git. When updating an installation with different paths, preserve or restore its existing configuration instead of overwriting it with your development settings. People with read access to the application folder can read this file; it is not encrypted and should not contain passwords. Do not force-add it to Git or attach deployment output to GitHub releases with company settings included.

Confirm exclusion with `git check-ignore "QR Code Application/appsettings.json"`. The example file is safe to commit because it contains only placeholders.
