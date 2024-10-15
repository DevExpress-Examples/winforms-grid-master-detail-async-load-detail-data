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

    Public Partial Class Form1
        Inherits Form

        Public Sub New()
            InitializeComponent()
        End Sub

        Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs)
            For i As Integer = 0 To 5 - 1
                Dim parent As Parent = New Parent()
                parent.Name = i.ToString()
                parentBindingSource.Add(parent)
            Next
        End Sub

        Private Sub gridView1_MasterRowGetRelationCount(ByVal sender As Object, ByVal e As MasterRowGetRelationCountEventArgs)
            e.RelationCount = 1
        End Sub

        Private Sub gridView1_MasterRowEmpty(ByVal sender As Object, ByVal e As MasterRowEmptyEventArgs)
            e.IsEmpty = False
        End Sub

        Private Sub gridView1_MasterRowGetRelationName(ByVal sender As Object, ByVal e As MasterRowGetRelationNameEventArgs)
            e.RelationName = "Children"
        End Sub

        Private Sub gridView1_MasterRowGetChildList(ByVal sender As Object, ByVal e As MasterRowGetChildListEventArgs)
            Dim details As BindingList(Of Child) = New BindingList(Of Child)()
            e.ChildList = details
            Dim worker As BackgroundWorker = New BackgroundWorker()
            worker.DoWork += New DoWorkEventHandler(AddressOf worker_DoWork)
            worker.RunWorkerAsync(details)
        End Sub

        Private Sub worker_DoWork(ByVal sender As Object, ByVal e As DoWorkEventArgs)
            Dim details As BindingList(Of Child) = CType(e.Argument, BindingList(Of Child))
            For i As Integer = 0 To 100 - 1
                BeginInvoke(New MethodInvoker(Function()
                    Dim child As Child = New Child()
                    child.Name = i.ToString()
                    details.Add(child)
                End Function))
                Thread.Sleep(1000)
            Next
        End Sub
    End Class

    Public Class Parent

        Private _Name As String

        Public Property Name As String
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

        Public Property Name As String
            Get
                Return _Name
            End Get

            Set(ByVal value As String)
                _Name = value
            End Set
        End Property
    End Class
End Namespace
