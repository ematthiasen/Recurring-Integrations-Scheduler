#define MyAppName "Recurring Integrations Scheduler - solution for file-based integrations with Dynamics 365 for Finance and Supply Chain Management, Enterprise Edition"
#define MyAppShortName "Recurring Integrations Scheduler"
#define MyAppVersion GetFileVersion("..\Output\Debug\RecurringIntegrationsScheduler.exe")
                                                                                      
[Setup]
; NOTE: The value of AppId uniquely identifies this application.
; Do not use the same AppId value in installers for other applications.
; (To generate a new GUID, click Tools | Generate GUID inside the IDE.)
AppId={{0746B957-721B-4245-A6B9-01D5DBF187F6}}
AppName={#MyAppName}
AppVersion={#MyAppVersion}
AppVerName={#MyAppName} {#MyAppVersion}
VersionInfoVersion={#MyAppVersion}
DefaultDirName={commonpf}\{#MyAppShortName}
DefaultGroupName={#MyAppShortName}
AllowNoIcons=yes
OutputBaseFilename=Recurring Integrations Scheduler Setup
OutputDir=..\
SetupIconFile=.\Recurring Integrations Scheduler.ico
Compression=lzma
SolidCompression=yes
LicenseFile=..\LICENSE.txt

[Languages]
Name: "english"; MessagesFile: "compiler:Default.isl"

[Types]
Name: "full"; Description: "Full installation (Recurring Integrations Scheduler)"
Name: "app"; Description: "Recurring Integrations Scheduler App"
Name: "scheduler"; Description: "Recurring Integrations Scheduler Service"

[Components]
Name: App; Description: Recurring Integrations Scheduler App; Types: full app; Flags: fixed
Name: Scheduler; Description: Recurring Integrations Scheduler Service; Types: full scheduler; Flags: fixed

[Files]
; Quartz
Source: "..\Output\Debug\Quartz.dll"; DestDir: "{app}"; Flags: ignoreversion; Components: App Scheduler
Source: "..\Output\Debug\log4net.dll"; DestDir: "{app}"; Flags: ignoreversion; Components: App Scheduler
Source: "..\Output\Debug\Quartz.Plugins.dll"; DestDir: "{app}"; Flags: ignoreversion; Components: App Scheduler
Source: "..\Output\Debug\Quartz.Jobs.dll"; DestDir: "{app}"; Flags: ignoreversion; Components: App Scheduler
Source: "..\Output\Debug\Quartz.Serialization.Json.dll"; DestDir: "{app}"; Flags: ignoreversion; Components: App Scheduler
Source: "..\Output\Debug\Topshelf.dll"; DestDir: "{app}"; Flags: ignoreversion; Components: Scheduler
Source: "..\Output\Debug\RecurringIntegrationsScheduler.Server.exe"; DestDir: "{app}"; Flags: ignoreversion; Components: Scheduler
; Common
Source: "..\Output\Debug\RecurringIntegrationsScheduler.Common.dll"; DestDir: "{app}"; Flags: ignoreversion; Components: App Scheduler
; Jobs
Source: "..\Output\Debug\RecurringIntegrationsScheduler.Job.Upload.dll"; DestDir: "{app}"; Flags: ignoreversion; Components: App Scheduler
Source: "..\Output\Debug\RecurringIntegrationsScheduler.Job.ProcessingMonitor.dll"; DestDir: "{app}"; Flags: ignoreversion; Components: App Scheduler
Source: "..\Output\Debug\RecurringIntegrationsScheduler.Job.Download.dll"; DestDir: "{app}"; Flags: ignoreversion; Components: App Scheduler
Source: "..\Output\Debug\RecurringIntegrationsScheduler.Job.Import.dll"; DestDir: "{app}"; Flags: ignoreversion; Components: App Scheduler
Source: "..\Output\Debug\RecurringIntegrationsScheduler.Job.Export.dll"; DestDir: "{app}"; Flags: ignoreversion; Components: App Scheduler
Source: "..\Output\Debug\RecurringIntegrationsScheduler.Job.ExecutionMonitor.dll"; DestDir: "{app}"; Flags: ignoreversion; Components: App Scheduler
; References
Source: "..\Output\Debug\Microsoft.Extensions.Logging.Abstractions.dll"; DestDir: "{app}"; Flags: ignoreversion; Components: App Scheduler
Source: "..\Output\Debug\Microsoft.Identity.Client.dll"; DestDir: "{app}"; Flags: ignoreversion; Components: App Scheduler
Source: "..\Output\Debug\Microsoft.IdentityModel.Clients.ActiveDirectory.dll"; DestDir: "{app}"; Flags: ignoreversion; Components: App Scheduler
Source: "..\Output\Debug\Newtonsoft.Json.dll"; DestDir: "{app}"; Flags: ignoreversion; Components: App Scheduler
Source: "..\Output\Debug\Polly.dll"; DestDir: "{app}"; Flags: ignoreversion; Components: App Scheduler
Source: "..\Output\Debug\PortableSettingsProvider.dll"; DestDir: "{app}"; Flags: ignoreversion; Components: App Scheduler
Source: "..\Output\Debug\System.Buffers.dll"; DestDir: "{app}"; Flags: ignoreversion; Components: App Scheduler
Source: "..\Output\Debug\System.Diagnostics.DiagnosticSource.dll"; DestDir: "{app}"; Flags: ignoreversion; Components: App Scheduler
Source: "..\Output\Debug\System.Linq.Dynamic.Core.dll"; DestDir: "{app}"; Flags: ignoreversion; Components: App Scheduler
Source: "..\Output\Debug\System.Memory.dll"; DestDir: "{app}"; Flags: ignoreversion; Components: App Scheduler
Source: "..\Output\Debug\System.Numerics.Vectors.dll"; DestDir: "{app}"; Flags: ignoreversion; Components: App Scheduler
Source: "..\Output\Debug\System.Runtime.CompilerServices.Unsafe.dll"; DestDir: "{app}"; Flags: ignoreversion; Components: App Scheduler
Source: "..\Output\Debug\UrlCombineLib.dll"; DestDir: "{app}"; Flags: ignoreversion; Components: App Scheduler

; App
Source: "..\Output\Debug\RecurringIntegrationsScheduler.exe"; DestDir: "{app}"; Flags: ignoreversion; Components: App
Source: "..\Output\Debug\RecurringIntegrationsScheduler.exe.config"; DestDir: "{app}"; Flags: ignoreversion; Components: App

; Configuration files
Source: "..\Output\Debug\Schedule.xml"; DestDir: "{app}"; Flags: onlyifdoesntexist uninsneveruninstall; Components: Scheduler
Source: "..\Output\Debug\RecurringIntegrationsScheduler.Server.exe.config"; DestDir: "{app}"; Flags: onlyifdoesntexist; Components: Scheduler
; ReadMe
Source: "..\README.MD"; DestDir: "{app}"; Flags: ignoreversion; Components: App Scheduler
; License
Source: "..\LICENSE.txt"; DestDir: "{app}"; Flags: ignoreversion; Components: App Scheduler
Source: "..\Third Party Notices.txt"; DestDir: "{app}"; Flags: ignoreversion; Components: App Scheduler

[Registry]
Root: HKLM; Subkey: "System\CurrentControlSet\Services\EventLog\Recurring Integrations Scheduler\Recurring Integrations Scheduler App"; ValueType: expandsz; ValueName: "EventMessageFile"; ValueData: "C:\Windows\Microsoft.NET\Framework64\v4.0.30319\EventLogMessages.dll"; Flags: uninsdeletekey; Components: App
[Icons]
Name: "{group}\{cm:UninstallProgram,{#MyAppName}}"; Filename: "{uninstallexe}"
Name: "{group}\Recurring Integrations Scheduler App"; Filename: "{app}\RecurringIntegrationsScheduler.exe"; WorkingDir: "{app}"

[Run]
Filename: "{app}\RecurringIntegrationsScheduler.Server.exe"; Parameters: "install"; Flags: runhidden; Components: Scheduler
Filename: {sys}\sc.exe; Parameters: "start RecurringIntegrationsScheduler" ; Flags: runhidden

[UninstallRun]
Filename: {sys}\sc.exe; Parameters: "stop RecurringIntegrationsScheduler" ; Flags: runhidden ; RunOnceId: "DelService"
Filename: "{app}\RecurringIntegrationsScheduler.Server.exe"; Parameters: "uninstall"; Flags: runhidden; Components: Scheduler ; RunOnceId: "DelServerExecutable"
