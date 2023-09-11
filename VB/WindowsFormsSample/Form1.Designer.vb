Namespace WindowsFormsSample

    Partial Class Form1

        ''' <summary>
        ''' Required designer variable.
        ''' </summary>
        Private components As System.ComponentModel.IContainer = Nothing

        ''' <summary>
        ''' Clean up any resources being used.
        ''' </summary>
        ''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing AndAlso (Me.components IsNot Nothing) Then
                Me.components.Dispose()
            End If

            MyBase.Dispose(disposing)
        End Sub

#Region "Windows Form Designer generated code"
        ''' <summary>
        ''' Required method for Designer support - do not modify
        ''' the contents of this method with the code editor.
        ''' </summary>
        Private Sub InitializeComponent()
            Me.components = New System.ComponentModel.Container()
            Me.gridView2 = New DevExpress.XtraGrid.Views.Grid.GridView()
            Me.gridControl1 = New DevExpress.XtraGrid.GridControl()
            Me.parentBindingSource = New System.Windows.Forms.BindingSource(Me.components)
            Me.gridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
            Me.colName = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.gridView3 = New DevExpress.XtraGrid.Views.Grid.GridView()
            CType((Me.gridView2), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.gridControl1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.parentBindingSource), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.gridView1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.gridView3), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            ' 
            ' gridView2
            ' 
            Me.gridView2.GridControl = Me.gridControl1
            Me.gridView2.Name = "gridView2"
            ' 
            ' gridControl1
            ' 
            Me.gridControl1.DataSource = Me.parentBindingSource
            Me.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.gridControl1.Location = New System.Drawing.Point(0, 0)
            Me.gridControl1.MainView = Me.gridView1
            Me.gridControl1.Name = "gridControl1"
            Me.gridControl1.Size = New System.Drawing.Size(485, 477)
            Me.gridControl1.TabIndex = 0
            Me.gridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gridView1, Me.gridView3, Me.gridView2})
            ' 
            ' parentBindingSource
            ' 
            Me.parentBindingSource.DataSource = GetType(WindowsFormsSample.Parent)
            ' 
            ' gridView1
            ' 
            Me.gridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colName})
            Me.gridView1.GridControl = Me.gridControl1
            Me.gridView1.Name = "gridView1"
            Me.gridView1.OptionsDetail.AllowExpandEmptyDetails = True
            Me.gridView1.MasterRowGetRelationName += New DevExpress.XtraGrid.Views.Grid.MasterRowGetRelationNameEventHandler(AddressOf Me.gridView1_MasterRowGetRelationName)
            Me.gridView1.MasterRowGetChildList += New DevExpress.XtraGrid.Views.Grid.MasterRowGetChildListEventHandler(AddressOf Me.gridView1_MasterRowGetChildList)
            Me.gridView1.MasterRowEmpty += New DevExpress.XtraGrid.Views.Grid.MasterRowEmptyEventHandler(AddressOf Me.gridView1_MasterRowEmpty)
            Me.gridView1.MasterRowGetRelationCount += New DevExpress.XtraGrid.Views.Grid.MasterRowGetRelationCountEventHandler(AddressOf Me.gridView1_MasterRowGetRelationCount)
            ' 
            ' colName
            ' 
            Me.colName.FieldName = "Name"
            Me.colName.Name = "colName"
            Me.colName.Visible = True
            Me.colName.VisibleIndex = 0
            ' 
            ' gridView3
            ' 
            Me.gridView3.GridControl = Me.gridControl1
            Me.gridView3.Name = "gridView3"
            ' 
            ' Form1
            ' 
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(485, 477)
            Me.Controls.Add(Me.gridControl1)
            Me.Name = "Form1"
            Me.Text = "Form1"
            Me.Load += New System.EventHandler(AddressOf Me.Form1_Load)
            CType((Me.gridView2), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.gridControl1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.parentBindingSource), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.gridView1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.gridView3), System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
        End Sub

#End Region
        Private gridControl1 As DevExpress.XtraGrid.GridControl

        Private gridView1 As DevExpress.XtraGrid.Views.Grid.GridView

        Private parentBindingSource As System.Windows.Forms.BindingSource

        Private colName As DevExpress.XtraGrid.Columns.GridColumn

        Private gridView2 As DevExpress.XtraGrid.Views.Grid.GridView

        Private gridView3 As DevExpress.XtraGrid.Views.Grid.GridView
    End Class
End Namespace
