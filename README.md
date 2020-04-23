How to create .net core webapi 

How to create .net core webapi 

dotnet new webapi -o <projectName> / 

dotnet add package Microsoft.EntityFramework.SqlServer / 

dotnet add package Microsoft.EntityFrameworkCore.InMemory / if you want use a mock database 

dotnet add package Pomelo.EntityFrameworkCore.MySql / if you want to connect to MySQL 

 dotnet add package Microsoft.VisualStudio.Web.CodeGeneration.Design

dotnet add package Microsoft.EntityFrameworkCore.Design

dotnet tool install --global dotnet-aspnet-codegenerator / Install globally on your machine 

dotnet aspnet-codegenerator controller -name <ProductController> -async -api -m <ProductItem> -dc <StoreContext> -outDir Controllers 
