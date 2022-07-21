# Creditinfo

Endpoints: 

search/{id} -> to search individual
search/detail/{id} -> to get individual details

POST: /api/sql/individual -> to create a new individual
- requestBody:
{
    "firstname":"elizabeth",
    "lastname":"olsen",
    "dateofbirth":"02162011",
    "gender":"female"
}


POST: /api/sql/contract -> to create a new contract
requestBody: 
{
    "individualnationalid":1,
    "roleofcustomer":"manager",
    "phaseofcontract":"dump",
    "originalamountvalue":"1200",
    "originalamountcurrency":"usd",
    "installmentamountvalue":"1090",
    "installmentamountcurrency":"usd"
}

In order to create database chhange credentials ConnectionString in appsettings.json file in SearchAPI project and run command Update-Database by switching 
Default project to DAL-DB in package manager console.
