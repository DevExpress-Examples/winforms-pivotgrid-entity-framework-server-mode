<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/196593472/22.1.2%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/T828608)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
[![](https://img.shields.io/badge/💬_Leave_Feedback-feecdd?style=flat-square)](#does-this-example-address-your-development-requirementsobjectives)
<!-- default badges end -->
# Pivot Grid for WinForms - a Server Mode Example (Entity Framework)

This example demonstrates a Pivot Grid that is bound to the Entity Framework data source and operates in server mode.


## Example Overview

The application contains two data sources bound to the Microsoft SQL database file:

* [EntityServerModeSource](https://docs.devexpress.com/CoreLibraries/DevExpress.Data.Linq.EntityServerModeSource)
* [BindingSource](https://docs.microsoft.com/en-us/dotnet/api/system.windows.forms.bindingsource)

Toggle the button to the _Server Mode_ position to bind the Pivot Grid to the `EntityServerModeSource` instance.

![screenshot](/images/screenshot.png)

You can see the generated SQL statements in the Visual Studio Output window.

## Files to Review

[Form1.cs](./CS/EntityFrameworkServerModeExample/Form1.cs) ([Form1.vb](./VB/EntityFrameworkServerModeExample/Form1.vb))

## Documentation
- [Entity Framework Documentation](https://docs.microsoft.com/ef/)
- [Server Mode](https://docs.devexpress.com/WindowsForms/17856/controls-and-libraries/pivot-grid/binding-to-data/database-server-mode)

## More Examples

- [PivotGridControl and LINQ to SQL - a Server Mode Example](https://github.com/DevExpress-Examples/winforms-pivotgrid-linq-to-sql-server-mode)


<!-- feedback -->
## Does this example address your development requirements/objectives?

[<img src="https://www.devexpress.com/support/examples/i/yes-button.svg"/>](https://www.devexpress.com/support/examples/survey.xml?utm_source=github&utm_campaign=winforms-pivotgrid-entity-framework-server-mode&~~~was_helpful=yes) [<img src="https://www.devexpress.com/support/examples/i/no-button.svg"/>](https://www.devexpress.com/support/examples/survey.xml?utm_source=github&utm_campaign=winforms-pivotgrid-entity-framework-server-mode&~~~was_helpful=no)

(you will be redirected to DevExpress.com to submit your response)
<!-- feedback end -->
