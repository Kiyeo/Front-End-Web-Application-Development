# Front-End-Web-Application-Development

Front-end project for the University Museum using sample RESTful endpoints with BASIC authentication files
from the University. The project involved separation of data from the UI, and how such data can be consumed
and used in the end-user application. Explored Pen-Testing as a Network User and a Co-Located User. E.g.
CSRF with Reflective SQL/HTML/JavaScript Injection, Directory Traversal & Decoded Base64 using HTTP
Requests.

IIS Express is required for this application.

Using PowerShell to run the following services:

1. `& "C:\Program Files\IIS Express\IISExpress.exe" /port:8188 /path:C:\Dev\Museum-Front-End\MuseumSvc`

2. `& "C:\Program Files\IIS Express\IISExpress.exe" /port:8189 /path:C:\Dev\Museum-Front-End\MuseumShopSvc`

In the MusemSvc and MuseumShopSvc folders, the web.config file Data Root value may need to be changed to the corresponding MuseumData folder location.

`<add key="DataRoot" value="C:\Dev\Museum-Front-End\MuseumData" />`

The view the application on the browser, type/copy in the following into the browser:

* `http://localhost:8189/lkeo821.html` 
