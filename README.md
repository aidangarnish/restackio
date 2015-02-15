# restackio.net
A .Net wrapper for the RESTACK API - https://restack.io

Add RestackIO.Net to your project using NuGet: <br/>
PM> Install-Package restackio.net 

-----------------------------------------------------------------------------------------
Create Device (Method: POST) - Example Usage

 Restack restack = new Restack(acctKey);

 string name = "Test device";<br/>
 string description = "Description of test device";<br/>
 string response = restack.CreateDevice(name, description, false);


-----------------------------------------------------------------------------------------
View Device (Method: Get) - Example Usage 

Restack restack = new Restack(acctKey);<br/>
string deviceId = "c031d8bd7bdc48d8992cf58ff39fc43f";<br/>
Device device = restack.GetDevice(deviceId);


-----------------------------------------------------------------------------------------
My Devices (Method: Get) - Example Usage

Restack restack = new Restack(acctKey);<br/>
List<Device> devices = restack.GetDevices();

-----------------------------------------------------------------------------------------



