# Week by Week guide to learn Microsoft .NET #

## Database ##
All content will reference the AdventureWorks Database found over at https://github.com/microsoft/sql-server-samples/tree/master/samples/databases/adventure-works


## Week 1 ##
Starting with simple console applications, learn and explore Linq

https://ef.readthedocs.io/en/staging/platforms/full-dotnet/existing-db.html

https://www.tutorialsteacher.com/linq/sample-linq-queries

https://code.msdn.microsoft.com/101-LINQ-Samples-3fb9811b


## Week 2 ##
Integrating a DB backend using Linq to a front-end
After importing AdventureWorks DB into a local instance of SQL Server

1. Connect the DB to the Console App using EntityFramework
2. Select all records from the People table using EF
3. Output all the first names from the People table
4. Read user input from console and then use it to filter based on middlename (where middlename.contains('userinput')
5. Use the group by feature to display the number of unique firstname and the count of occurance within the filtered dataset in \#4
6. Read user input from console and then use it to filter the email field, i.e at this point you will be filtering based on 2 inputs, one for middlename and another for emailaddress
7. Change from listing the firstnames to listing the entire people record. To simplify, list it in JSON format

## Week 3 ##
1. Finish up last week HW (aka output in JSON), plagiarism is allowed, but i want all of you to understand what is the cause. The feature that cause this problem is both good and bad for you

2. Time to learn about the System.IO namespace. Continue to use the console app and do this
2.1 Download https://github.com/microsoft/sql-server-samples/blob/master/samples/databases/adventure-works/oltp-install-script/CurrencyRate.csv
2.2 Read the file via your console app and display it as is line by line
2.3 Cast each line to a class and store it in a list e.g List<CurrencyRate>
2.4 Print SourceCurrency, DestinationCurrency, Conversation rate
2.5 Read user input and filter by DestinationCurrency
2.6 Group by DestinationCurrency and then display the average, low and highest exchange rate in the data set
2.7 PLOT USD-CAD exchange rate over time i.e X is Time, Y is exchange rate
