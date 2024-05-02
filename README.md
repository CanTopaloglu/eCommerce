# eCommerce Application

A project for a eCommerce website using Angular 17 & .NET 8

In order to correctly run the backend, please adjust the connection string of Database connection accordingly to your own SqlConnection.

Add a new migration and update the Database.


## Run Locally

Clone the project

```bash
  git clone https://github.com/CanTopaloglu/eCommerce.git
```

Go to the project directory

```bash
  cd eCommerce
```

Install dependencies

```bash
  npm install
```

Start the server

```bash
  ng serve
```
## Csharp
```Csharp
protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer("write your sql connection string");
    }
```
 ## Database Connection
```Csharp - Package Manager Console
    add-migration yourmigrationname

    update-database
```


