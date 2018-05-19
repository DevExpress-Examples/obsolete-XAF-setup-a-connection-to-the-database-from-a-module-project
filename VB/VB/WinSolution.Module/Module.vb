Imports Microsoft.VisualBasic
Imports System
Imports System.Data.SqlClient
Imports DevExpress.ExpressApp

Namespace WinSolution.Module
	Public NotInheritable Partial Class WinSolutionModule
		Inherits ModuleBase
		Public Sub New()
			InitializeComponent()
		End Sub
		Public Overrides Overloads Sub Setup(ByVal application As XafApplication)
			AddHandler application.CreateCustomObjectSpaceProvider, AddressOf application_CreateCustomObjectSpaceProvider
			MyBase.Setup(application)
		End Sub
		Private Sub application_CreateCustomObjectSpaceProvider(ByVal sender As Object, ByVal e As CreateCustomObjectSpaceProviderEventArgs)
			Dim application As XafApplication = CType(sender, XafApplication)
			RemoveHandler application.CreateCustomObjectSpaceProvider, AddressOf application_CreateCustomObjectSpaceProvider
			Dim connectionString As String = "Integrated Security=SSPI;Pooling=false;Data Source=(local);Initial Catalog=E1708"
			Dim connection As New SqlConnection(connectionString)
			e.ObjectSpaceProvider = New ObjectSpaceProvider(New ConnectionDataStoreProvider(connection))
		End Sub
	End Class
End Namespace