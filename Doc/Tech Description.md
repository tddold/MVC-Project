Описание
Проектът е разработен в ASP.NET в C #.

Project areas
Публична 	част
Списък с детайли на началната стараница - HomeController - Index view,
 _Projects partial view - CategoryHomeView 
Част с оторизация
ProfileController,
 UsertController
 UserViewModel
AdminController
Анонимни потребители

General Requirements Covered
15 controllers
30 actions
Razor view engine 
~18 Editor and Display templates
Entity framework 6 with SQL Server DB
Repository pattern with data services
3 area user (Admin, User, and worker)
All data visualization is based on JSON requests with server side paging/sorting
Bootstrap/Kendo vizualization
Notifications used
ASP Identity system used, 3 different roles predifined
Data caching used for home page and internal server logic
Used Autofac dependency injector for MVC5
Automapper for model mappings
Site completely protected against XSS, XSRF, Parameter Tampering, HTML sanitizer used
Server and client validation implemented on all pages (error messages localized)
Used GitHub as a source repository
15 Unit Tests (Routes and Services)
MD User and techical documentation
1 StyleCop warnings
