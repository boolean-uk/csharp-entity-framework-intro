# C# Entity Framework Intro

## Completed
Completed everything but super extensions. To run the project, make sure to
update / create an appsettings.json with a connection string. E.g.

<code>
"ConnectionStrings": {
        "DefaultConnectionString": "Host=your; Database=values; Username=goes; Password=here;"
}
</code>

Then run migrations and update the database. Test the endpoints in scalar or swagger.
(I recommend scalar)

1. `add-migration init`
1. `update-database init`
1. Start the project
## Setup



- Note the .gitignore file in the root of the project which prevents the build directories being uploaded:
```
*/**/bin/Debug   
*/**/bin/Release   
*/**/obj/Debug   
*/Migrations
*/**/obj/Release   
/workshop.wwwapi/appsettings.json
/workshop.wwwapi/appsettings.Development.json
```


## Dependencies 

Some of these have already been installed:

- Install-Package Scalar.AspNetCore
    - provides a /scalar endpoint 
- Install-Package Swashbuckle.AspNetCore
    - provides a /swagger endpoint
    
- Install-Package Microsoft.EntityFrameworkCore
- Install-Package Microsoft.EntityFrameworkCore.Design
- Install-Package Microsoft.EntityFrameworkCore.InMemory

## Core and Extension are combined into the following requirements

The overall objective is to complete the BookAPI CRUD operations, using DTO objects to return nicely formatted json without any cyclical serialization errors.

As guidelines we suggest:

- implement the GET book and GET all books. When you return the books objects, use an appropriate DTO to return the book + author (but no nested books inside author). Make sure to include the authors when you load the data in the repository.
- implement the UPDATE boook where you can change the author via id (you may skip updating other properties like title, etc); make sure to return the Book + Author once the update is done
- implement the DELETE book
- implement the CREATE book - it should return NotFound when author id is not valid and BadRequest when book object not valid

- implement the author API (interested in just the GET, GET all) -> the author should return the list of books, use its own author response DTO


Extensions (each one is one extension, implement at least one):

- Add a publisher model and add that as an additional relation to the book, where a book has one publisher; make sure to update the seeder and to create a publisher API Endpoints with the GET and GET all endpoints. Getting a Publisher should return all books that have that publisher + the author for each book. Update the author endpoint to return the Book + Publisher; Updaate the book endpoint to return the Book + Author + Publisher.
- Update the model to have many to many relation between Book and Author, where a Book can have 1 or more authors. Update all the endpoints to return the Book + Authors list.
- Add endpoints for assigning / removing an author from a Book
- Users of the library want to be able to checkout books for a period of time. Add a model to capture which books have been checked out. Include the checkout date and expected return date. Create a checkout api where you can try to checkout a book. You cannot check out books that are currently already borrowed. Add api routes for displaying books that are currently checked out, books that are overdue (should have been returned but are not returned). When you checkout a book, return the expected date for the return (2 weeks). To achieve this, you may want to look at query parameters for the filtering of the checked out books `?filter=someValue`.
- Swap out he InMemory db for another Postgres instance such as [neon](https://neon.tech/). Make sure you have ```appsettings.json``` AND ```appsettings.Development.json``` files in the root of the workshop.wwwapi project which contains suitable credentials. You may modify the seeding process if you need to.
```json
{
  "Logging": {
    "LogLevel": {
      "Default": "Information",
      "Microsoft.AspNetCore": "Warning"
    }
  },
  "AllowedHosts": "*",

  "ConnectionStrings": {
    "DefaultConnectionString": "Host=HOST; Database=DATABASE; Username=USERNAME; Password=PASSWORD;"

  }
} 

```

Super Extensions (for the brave!)

- Introduce the ability for Users to submit Book Reviews, which consist of a 5 star rating and comment on their view of the book.  Users can submit these reviews anonymously or leave their email address.
- Implement both a generic IRepository<T> AND Repository<T>. Before you commit to this ensure that you understand the implications of the DbSet Include method on the generic repository! 


