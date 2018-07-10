Wisej usualy uses 3 main startup files
- Default.html
- Default.json
- Program.cs

This example uses a very unusual setup:
- ChangedNames.html and Alias.html
- Default.json
- Startup.cs

Wisej can use the HTML file name or the JSON file name.

When you type
http://servername/Default
all Wisej cares is about finding a Default.json file.

When you type
http://servername/ChangedNames.html or http://servername/Alias.html 
provided the HTML file exists, Wisej tries to find a matching JSON file,
that is a file with the same name but with a json extension.
If Wisej can not find the json file, it uses the configuration in "Default.json" file.

The Default.json file on this projects looks like this:
{
  "url": "ChangedNames.html",
  "startup": "ChangedNames.Startup.Main, ChangedNames"
}

Now Wisej knows it must show ChangedNames.html. This is very important, since browsers need an HTML file and Wisej needs the browser to load and execute wisej.wx

The second piece of information Wisej gets from the json file is the startup method, in this case
- method ChangedNames.Startup.Main
- assembly ChangedNames
Please note that the "startup" setting in the json file is optional, you can use the "mainWindow" setting instead.

Try the following URLs:

1) http://localhost:57877/Default.html
HTTP Error 404.0 - Not Found
There is no Default.html file so Wisej will not proceed to handle Default.json

2) http://localhost:57877/ChangedNames
HTTP Error 404.0 - Not Found
There is no ChangedNames.json file.

3) http://localhost:57877/ChangedNames.html or http://localhost:57877/Alias.html 
You get your application just like when you use the URL http://localhost:57877/Default
Wisej finds and uses the Default.json file.

