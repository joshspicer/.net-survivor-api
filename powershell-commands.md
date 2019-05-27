  -- -----------
   1 $params = @{"color"="light-blue"}
   2 $params
   3 Invoke-WebRequest -Uri localhost:55548/api/tribes/2 -Method PUT -Body $params
   4 Invoke-WebRequest -Uri http://localhost:55548/api/tribes/2 -Method PUT -Body $params
   5 Invoke-WebRequest -Uri http://localhost:55548/api/tribes/2 -Method PUT -Body $params -ContentType "application/json"
   6 $params = @{"color"="lightBlue"}
   7 Invoke-WebRequest -Uri http://localhost:55548/api/tribes/2 -Method PUT -Body $params -ContentType "application/json"
   8 Invoke-WebRequest -Uri https://localhost:55548/api/tribes/2 -Method PUT -Body $params -ContentType "application/json"
   9 Invoke-WebRequest -Uri http://localhost:55548/api/tribes/2 -Method PUT -Body $params -ContentType "application/json"
  10 Invoke-WebRequest -Uri http://localhost:55548/api/tribes/2 -Method GET
  11 Invoke-WebRequest
  12 Invoke-WebRequest -Uri http://localhost:55548/api/tribes/2 -Method GET
  13 Invoke-WebRequest -Uri http://localhost:55548/api/tribes/2 -Method PUT -Body $params -ContentType "application/json"
  14 Invoke-WebRequest -Uri http://localhost:55548/api/tribes/2 -Method PUT -Body {"color": "blueblue"} -ContentType "application/json"
  15 Invoke-WebRequest -Uri http://localhost:55548/api/tribes/2 -Method PUT -Body '{"color": "blueblue"}' -ContentType "application/json"
  16 Invoke-WebRequest -Uri http://localhost:55548/api/tribes/2 -Method PUT -Body '{name:"AZURE", "color": "blueblue"}' -ContentType "appl...
  17 Invoke-WebRequest -Uri http://localhost:55548/api/tribes/2 -Method PUT -Body '{"name":"AZURE", "color": "blueblue"}' -ContentType "ap...
  18 Invoke-WebRequest -Uri http://localhost:55548/api/tribes/2 -Method PUT -Body '{"Name":"AZURE", "Color": "blueblue"}' -ContentType "ap...
  19 Invoke-WebRequest -Uri http://localhost:55548/api/tribes/2 -Method PUT -Body '{"Name":"AZURE}' -ContentType "application/json"
  20 Invoke-WebRequest -Uri http://localhost:55548/api/tribes/2 -Method PUT -Body '{"Name":"AZURE"}' -ContentType "application/json"
  21 Invoke-WebRequest -Uri http://localhost:55548/api/tribes/2 -Method POST -Body '{"Name":"AZURE"}' -ContentType "application/json"
  22 Invoke-WebRequest -Uri http://localhost:55548/api/tribes/3 -Method DELETE -Body '{"Name":"AZURE"}' -ContentType "application/json"
