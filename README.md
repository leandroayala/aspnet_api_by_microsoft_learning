Project created based on Microsoft Learning official page
Link: https://learn.microsoft.com/en-us/training/modules/build-web-api-aspnet-core/

The aim this project is learn more about .NET works when building API


To Execute:
1. have installed the .net
2. open this project on visual studio code or other
3. in terminal run: dotnet build
4. in terminal run: dotnet run
5. wiil be shown in the terminal the url api: "Now listening on: http://localhost:5262"
6. to teste, in your web browser type: http://localhost:5262/pizza
7. To other teststu use a Api platafrm like "insonmia" https://insomnia.rest/
8. in insomnia create the requisitions:

Get All Pizzas

GET: http://localhost:5262/pizza 

Get By ID

GET: http://localhost:5262/pizza/1

Post (create new pizza)

POST: http://localhost:5262/pizza

Json body:
{
	"name": "muzzarela",
	"IsGlutenFree": true
}

put (update pizza)

PUT: http://localhost:5262/pizza/1

Json body:
{
	"id": 1,
	"name": "portuguesa",
	"IsGlutenFree": true
}

Delete Pizza
DELETE: http://localhost:5262/pizza/3
