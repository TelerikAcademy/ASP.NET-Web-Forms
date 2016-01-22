# ASP.NET AJAX Homework

1. Create an AJAX-enabled Web site which shows `Employees` and their `Orders` in two `GridView` controls (use the `Northwind` database and Entity Framework). Put the `GridView` for the orders inside an update panel. Add `UpdateProgress` which shows an image while loading (simulate slow loading with `Thread.Sleep()`).
    * When the user selects a row in employees `GridView`, the `UpdateProgress` must be activated and the panel must be updated with the orders of the selected `Employee`.   

2. Using `Timer` and `UpdatePanel` implement very simple Web-based chat application. Use a single database table `Messages` holding all chat messages. All users should see in a `ListView` the last 100 lines of the `Messages` table. Users can send new messages at any time and should see the messages posted by the others at interval of 500 milliseconds.
    * Using the AJAX Control Toolkit create a Web photo album showing a list of images (stored in the file system). Clicking an image should show it with bigger size in a modal popup window. The album should look like the Windows Photo Viewer.
