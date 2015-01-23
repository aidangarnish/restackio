# restackio
A .Net wrapper for the RESTACK API - https://restack.io

Add RestackIO.Net to your project using NuGet:
PM> Install-Package restackio.net 

-----------------------------------------------------------------------------------------
Status (Method: GET) - Example Usage

string response = RestackServiceStatus.GetStatus();


-----------------------------------------------------------------------------------------
Data (Method: Post) - Example Usage Single Value

Restack restack = new Restack(UUID, token);
string response = restack.PostData("temperature", "16");


-----------------------------------------------------------------------------------------
Date (Method: Post) - Example Usage Multiple Values

Restack restack = new Restack(UUID, token);

NameValueCollection nvc = new NameValueCollection();
nvc.Add("Temperature", "19");
nvc.Add("Humidity", "58");

string response = restack.PostData(nvc);

-----------------------------------------------------------------------------------------



