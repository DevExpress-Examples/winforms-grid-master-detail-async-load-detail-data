Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Linq
Imports System.Text
Imports System.Windows.Forms
Imports DevExpress.Xpo
Imports DevExpress.XtraGrid
Imports DevExpress.XtraGrid.Views.Grid.ViewInfo
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraGrid.Views.Base
Imports DevExpress.Data.Filtering
Imports DevExpress.XtraGrid.Columns
Imports System.Reflection
Imports System.Threading

Namespace WindowsFormsSample
	Partial Public Class Form1
		Inherits Form
		Public Sub New()
			InitializeComponent()
		End Sub
		Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
			For i As Integer = 0 To 4
				Dim parent As New Parent()
				parent.Name = i.ToString()
				parentBindingSource.Add(parent)
			Next i
		End Sub

		Private Sub gridView1_MasterRowGetRelationCount(ByVal sender As Object, ByVal e As MasterRowGetRelationCountEventArgs) Handles gridView1.MasterRowGetRelationCount
			e.RelationCount = 1
		End Sub

		Private Sub gridView1_MasterRowEmpty(ByVal sender As Object, ByVal e As MasterRowEmptyEventArgs) Handles gridView1.MasterRowEmpty
			e.IsEmpty = False
		End Sub

		Private Sub gridView1_MasterRowGetRelationName(ByVal sender As Object, ByVal e As MasterRowGetRelationNameEventArgs) Handles gridView1.MasterRowGetRelationName
			e.RelationName = "Children"
		End Sub

		Private Sub gridView1_MasterRowGetChildList(ByVal sender As Object, ByVal e As MasterRowGetChildListEventArgs) Handles gridView1.MasterRowGetChildList
			Dim details As New BindingList(Of Child)()
			e.ChildList = details
			Dim worker As New BackgroundWorker()
			AddHandler worker.DoWork, AddressOf worker_DoWork
			worker.RunWorkerAsync(details)
		End Sub

		Private Sub worker_DoWork(ByVal sender As Object, ByVal e As DoWorkEventArgs)
			Dim details As BindingList(Of Child) = CType(e.Argument, BindingList(Of Child))
			For i As Integer = 0 To 99
				BeginInvoke(New MethodInvoker(Function() AnonymousMethod1(i, details)))
				Thread.Sleep(1000)
			Next i
		End Sub
		
		Private Function AnonymousMethod1(ByVal i As Integer, ByVal details As BindingList(Of Child)) As Boolean
			Dim child As New Child()
			child.Name = i.ToString()
			details.Add(child)
			Return True
		End Function
	End Class
	Public Class Parent
		Private _Name As String
		Public Property Name() As String
			Get
				Return _Name
			End Get
			Set(ByVal value As String)
				_Name = value
			End Set
		End Property
	End Class
	Public Class Child
		Private _Name As String
		Public Property Name() As String
			Get
				Return _Name
			End Get
			Set(ByVal value As String)
				_Name = value
			End Set
		End Property
	End Class
End Namespace
