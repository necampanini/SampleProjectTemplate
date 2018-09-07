# SampleProjectTemplate

## Things to note:

Have SQL Server Express installed. The commented out connection string in the Web.Config file will point at a SQL Server instances instead of the localdb.

As of 09/07/2018, this solution has 2 projects: The web project named simple 'SampleProject', and a Database Project named: 'SampleProjectDb'.

Database projects will be important, as it's effectively source control for the database contents the application will care about (i.e. schemas, tables, stored procedures, views, etcetc)

You will want to publish from the database project to your SQL Server instance. In the case you do not yet have a database on your SQL server instance, publishing from the database project will create it for you.

To accomplish this: 

1. Right click the database project in the solution
2. Hit Publish
3. Goto Edit for the Target database connection
4. Click the Browse tab
5. Open the 'Local' drop down
6. Select your SQL server instances. This will vary by machine name and whatever you named your SQL server instance.
  a. If you left the defaults on for the SQL server installation, it should simply be 'MACHINENAME\SQLEXPRESS' 
7. Hit OK
8. Hit Publish

Open up SSMS and connect to your SQL Server instance. Browse to your new database, verify it has a new table.

Build and run the web app portion of the project and try to register a user. 

We'll cover more of this at a later date but this is a good starting point to build the rest of the application off of.
