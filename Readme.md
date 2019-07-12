# PivotGridControl and Entity Framework - a Server Mode Example

This example demonstrates the PivotGridControl that is bound to the Entity Framework data source and operates in Server mode.

The application contains two data sources bound to the Microsoft SQL database file:

* [EntityServerModeSource](https://docs.devexpress.com/CoreLibraries/DevExpress.Data.Linq.EntityServerModeSource)
* [BindingSource](https://docs.microsoft.com/en-us/dotnet/api/system.windows.forms.bindingsource)

Toggle the button to the _Server Mode_ position to bind the PivotGridControl to the EntityServerModeSource instance.

![screenshot](/images/screenshot.png)

> SQL queries are logged to the Output window in Visual Studio IDE, so you can see what is going on behind the scene.


See also:

* [Entity Framework Documentation](https://docs.microsoft.com/ef/)
* [Server Mode](https://docs.devexpress.com/WindowsForms/17856)
