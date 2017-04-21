set IL_MERGE="D:\Program Files (x86)\Microsoft\ILMerge\ilmerge.exe"
set TARGET_PLATFORM=C:\Windows\Microsoft.NET\Framework64\v4.0.30319
set OUTPUT_EXE=Download\Gw2MumbleLink.exe
set INPUT_EXE=Gw2MumbleLink\bin\Release\Gw2MumbleLink.exe
set INPUT_DLL1=Gw2MumbleLink\bin\Release\Newtonsoft.Json.dll
set INPUT_DLL2=Gw2MumbleLink\bin\Release\MumbleLink-CSharp.dll
set INPUT_DLL3=Gw2MumbleLink\bin\Release\MumbleLink-CSharp-GW2.dll

%IL_MERGE% /targetplatform:v4,%TARGET_PLATFORM% /out:%OUTPUT_EXE% %INPUT_EXE% %INPUT_DLL1% %INPUT_DLL2% %INPUT_DLL3%
pause