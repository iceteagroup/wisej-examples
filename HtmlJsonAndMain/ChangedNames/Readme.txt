Wisej usualy uses 3 main startup files
- Default.html
- Default.json
- Program.cs

This example uses a very unusual setup:
- ChangedNames.html
- Default.json
- Startup.cs

When you type
http://servername/Default
all Wisej cares is about finding a Default.json file.

When you type
http://servername/ChangedNames.html or http://servername/folder/ChangedNames.html
provided the HTML file exists, Wisej tries to find a matching JSON file,
respectively <ProjectRoot>/ChangedNames.json or <ProjectRoot>/folder/ChangedNames.json
If Wisej can not find the json file, the wisej.wx script reloads the same page, although the browser shows the address you typed.

In this example, look at the URL label in the top right corner, to find out what Wisej used to load the Page.

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
There is no Default.html file so Wisej will not proceed to load and handle Default.json

2) http://localhost:57877/ChangedNames
HTTP Error 404.0 - Not Found
There is no ChangedNames.json file.

2) http://localhost:57877/ChangedNames.html
The wisej.wx script reloads the same page.
Look at the URL label to see what Wisej really loaded.

Please refer to https://github.com/iceteagroup/wisej-examples/blob/master/HtmlJsonAndMain/README.md
