## Context

The most common Wisej applications (in the broad sense) have only a single application (in the strict sense). To keep things simple, we will use "sub-application" to refer to an application in the strict sense.

Wisej __sub-applications__ are different entry points in your application, independent URL you can use for whatever purpose you decide.

## About the startup files and their use

On a brand new project, by default Wisej creates 3 startup files:
* Default.html
* Default.json
* Program.cs

Note - The filename __Program.cs__ is used because that’s the name we are used to in WinForms.

#### Create new sub-applications

To create a new sub-application, follow the steps:
1) Right click on the project, _Select __Add => New Item__;
2) On the __Add New Item__ form, select __Wisej__ on the left side and click on __Application__ in the object list.
3) Set the application __Name__ and click __Add__.

Supposing you set the Name to __Admin__, Wisej creates 3 startup files, all with the same name:
* Admin.html
* Admin.json
* Admin.cs

Note you can create a sub-application in a folder.

## How Wisej looks for the json file

1) If you type an URL that ends with __.html__, if the file exists, Wisej tries to find the matching __.json__ file (a file with the same name, but with a json extension instead of html) and uses it. If Wisej can not find a matching json file, the __wisej.wx__ script reloads the same page.

2) If you type an URL that ends with "/" like "folder/", Wisej uses "folder/Default.json".

3) if you type an URL that does __not__ end with __.html__ like __Customer__, Wisej tries to solve the URL in two steps:
* Wisej appends __.json__ to __Customer__ and use as the json file, in this case uses __Customer.json__.
* If __Customer.json__ doesn't exist, Wisej presumes __Customer__ is a folder name and tries to use __Customer/Default.json__ (this beahaviour was introduced in release 1.5.4).
 