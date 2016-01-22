# ASP.NET Data Source Controls Homework
1. **Countries**
    - Create a database holding continents, countries and town. Countries have name, language, population and continent. Towns have name, population and country. Implement an ASP.NET Web application that shows the continents in a `ListBox`, countries in a `GridView` and the towns in a `ListView` and allows master-detail navigation. Use Entity Framework and `EntityDataSource`. Provide paging and sorting for the long lists. Use HTML escaping when needed.
    - Implement add / edit / delete for the continents, countries, towns and languages. Handle the possible errors accordingly. Ensure HTML special characters handled correctly (correctly escape the HTML).
    - Add a flag for each country which should be a PNG image, stored in the database, displayed along with the country data. Implement "change flag" functionality by uploading a PNG image.
1. **TODO List**
    - Write a "`TODO List`" application in ASP.NET. It should be able to list / create / edit / delete TODOs. Each TODO has title, body (rich text) and date of last change. The TODOs are in categories. Categories should also be editable (implement CRUD).
1. **Tweets aggregator**
    - Write ASP.NET Web Forms application to display in a `GridView` all tweets from given Twitter user. Load the tweet though the Twitter API. Bind the tweets to the `GridView` thorugh `ObjectDataSource`.