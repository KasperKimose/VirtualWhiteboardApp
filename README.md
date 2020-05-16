# README #

Role: 

Backend


Chosen technology:

I’ve chosen ASP.NET Core for my backend solution as I’m family with this framework, and I think it is a good tool to use when you have to get an api up and running quickly. As, it gives you a lot of help with for example Entity Framework for storage with migrations making it easy to alter your models easy. Furthermore, with Azure it is also easy to deploy the application and have it running online, and setting app services and sql servers up in azure just takes a couple of minutes.

Another approach could have been to use SpringBoot with java, but as I’m not as familiar with this framework, I felt it was a bit risky to implement the solution with this. 


Configuration
This project can only be run on windows computers as it is using sql server

To run this project  locally on a computer the migrations has to be run first therfore,

run the command 'Update-Database' in the package manger console, this will create a dev database locally on the computer.
Hereafter it should be possible to run the solution which will open the swagger page, where the endpoints for this api can be found


Test:
There is a online version of this API it can be found on, https://virtualwhiteboard-dev.azurewebsites.net/ 
