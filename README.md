### Branch 
- *master* is output to console
- *dev* is output to json file

### How to run?
- config csc to computer environment
- get code to your computer
- enter the directory named VehicleProject in the source code directory
- execute command below in Powershell or cmd termianl 
```
csc /out:Program.exe Program.cs Vehicle.cs IVehicle.cs Car.cs Plane.cs Boat.cs
```
- u will get an exe file named Program.exe 
- double click the exe file and watch the output of console

### Output with json file
- get code whose branch is *dev*
- compile to get exe file
- execute exe file to get json file int the same directory as Program.exe