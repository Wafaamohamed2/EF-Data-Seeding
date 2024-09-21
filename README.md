## Project Overview

This project is focused on **data seeding** using Entity Framework Core in a .NET application. 
Data seeding allows for automatic population of default data into a database during its creation or migration process. 

##The data seeding logic is implemented in the ApplicationDbContext.cs file and also in Program.cs.

1-in the ApplicationDbContext.cs file
   During the migration process, the database will be populated with initial data. 
   To view or modify the seeded data, check the OnModelCreating method in ApplicationDbContext.

2- in Program.cs file
   The SeedData method is used to populate the database with initial data. 
   This method is typically called within the Main method of the Program class.
