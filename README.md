# restackio.net
A .Net wrapper for the RESTACK API - https://restack.io

Add RestackIO.Net to your project using NuGet: <br/>
PM> Install-Package restackio.net 

-----------------------------------------------------------------------------------------
Status (Method: GET) - Example Usage

string response = RestackServiceStatus.GetStatus();


-----------------------------------------------------------------------------------------
Data (Method: Post) - Example Usage Single Value

Restack restack = new Restack(UUID, token); <br/>
string response = restack.PostData("temperature", "16");


-----------------------------------------------------------------------------------------
Data (Method: Post) - Example Usage Multiple Values

Restack restack = new Restack(UUID, token); <br/>

NameValueCollection nvc = new NameValueCollection(); <br/>
nvc.Add("Temperature", "19"); <br/>
nvc.Add("Humidity", "58"); <br/>

string response = restack.PostData(nvc);

-----------------------------------------------------------------------------------------



