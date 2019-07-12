Imports DevExpress.Data.Linq
Imports DevExpress.XtraEditors
Imports System

Namespace EntityFrameworkServerModeExample
	Partial Public Class Form1
		Inherits XtraForm

		Private entityServerModeSource As EntityServerModeSource
		Private serverMode As Boolean = False
		Public Sub New()
			InitializeComponent()
			entityServerModeSource = New EntityServerModeSource With {.ElementType = GetType(EntityInvoice), .KeyExpression = "OrderId"}
			Dim context As New NWEntities()
            context.Database.Log = AddressOf Console.Write
            entityServerModeSource.QueryableSource = context.EntityInvoices
		End Sub

		Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Load
			' TODO: This line of code loads data into the 'nWDataSet.Invoices' table. You can move, or remove it, as needed.
			Me.invoicesTableAdapter.Fill(Me.nWDataSet.Invoices)
			SetPivotGridDataSource()
		End Sub

		Private Sub toggleSwitch1_Toggled(ByVal sender As Object, ByVal e As EventArgs) Handles toggleSwitch1.Toggled
			serverMode = DirectCast(sender, ToggleSwitch).IsOn
			SetPivotGridDataSource()
		End Sub

		Private Sub SetPivotGridDataSource()
			If serverMode Then
				pivotGridControl1.DataSource = entityServerModeSource
			Else
				pivotGridControl1.DataSource = invoicesBindingSource
			End If
		End Sub
	End Class
End Namespace
