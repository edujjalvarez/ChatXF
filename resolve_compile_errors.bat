REM ARTILLERY SCRIPT
REM delete bin and obj folders
for /d /r . %d in (obj) do @if exist "%d" rd /s /q "%d"
for /d /r . %d in (bin) do @if exist "%d" rd /s /q "%d"

REM delete packages folder
rd /s /q packages

REM delete Xamarin.Android packages from NuGet cache
for /d %d in ("%UserProfile%\.nuget\packages\Xamarin.Android.*") do @if exist "%d" rd /s /q "%d"

REM delete Xamarin.Android packages from Xamarin cache
for /d %d in ("%UserProfile%\AppData\Local\Xamarin\Xamarin.Android.*") do @if exist "%d" rd /s /q "%d"

REM delete broken downloads
rd /s /q "%UserProfile%\AppData\Local\Xamarin\zips"