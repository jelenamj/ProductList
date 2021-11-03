Pre requerments:
1. PostgreSQL

Query for table creation:

CREATE TABLE Product (
	Id SERIAL PRIMARY KEY,
	Name TEXT,
	Description TEXT,
	Category TEXT,
	Manufacturer TEXT,
	Supplier TEXT,
	Price DECIMAL
);

Two lines have to be changed to run the app:
1. Connection String in the line 13, file DatabaseUtilisation.cs (ProductList\Data)
2. Path to the JSON file line 14, file JSONUtilisation.cs (ProductList\Data)
