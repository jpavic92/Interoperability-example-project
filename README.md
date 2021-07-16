# Interoperability-example-project
REST API, SOAP API, XML validation against XSD or RNG

## XML-RPC server application
Written in Java.
Application fetches weather data by weather station name from https://vrijeme.hr/hrvatska_n.xml and serves it to clients.
ShazamClient consumes the service.

## REST and SOAP server application
Written in C#. Offers simple search and xml validaton against xml or rng for a client.
ShazamClient consumes the service.

## ShazamClient
Written in C#, Windows form app.
Consumes above services.
Consumes services from Shazam api avaliable at https://rapidapi.com/apidojo/api/shazam/



