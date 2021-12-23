<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/196593472/19.1.3%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/T828608)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->
# PivotGridControl and Entity Framework - a Server Mode Example

This example demonstrates the PivotGridControl that is bound to the Entity Framework data source and operates in Server mode.

## Files to Look At

[Form1.cs](./CS/EntityFrameworkServerModeExample/Form1.cs) ([Form1.vb](./VB/EntityFrameworkServerModeExample/Form1.vb))

## Example Overview

The application contains two data sources bound to the Microsoft SQL database file:

* [EntityServerModeSource](https://docs.devexpress.com/CoreLibraries/DevExpress.Data.Linq.EntityServerModeSource)
* [BindingSource](https://docs.microsoft.com/en-us/dotnet/api/system.windows.forms.bindingsource)

Toggle the button to the _Server Mode_ position to bind the PivotGridControl to the EntityServerModeSource instance.

![screenshot](/images/screenshot.png)

> SQL queries are logged to the Output window in Visual Studio IDE, so you can see what is going on behind the scene.

## Documentation
- [Entity Framework Documentation](https://docs.microsoft.com/ef/)
- [Server Mode](https://docs.devexpress.com/WindowsForms/17856/controls-and-libraries/pivot-grid/binding-to-data/database-server-mode)

## More Examples

- [PivotGridControl and LINQ to SQL - a Server Mode Example](https://github.com/DevExpress-Examples/winforms-pivotgrid-linq-to-sql-server-mode)


