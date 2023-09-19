Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Drawing
Imports System.Windows.Forms
Imports DevExpress.XtraEditors
Imports DevExpress.XtraTab.Registrator
Imports DevExpress.XtraTab.Drawing
Imports DevExpress.XtraTab
Imports DevExpress.Utils

Namespace WindowsApplication1

    Public Partial Class Form1
        Inherits XtraForm

        Private _CheckedPages As Dictionary(Of XtraTabPage, Boolean) = New Dictionary(Of XtraTabPage, Boolean)()

        Public Sub New()
            InitializeComponent()
            Call PaintStyleCollection.DefaultPaintStyles.Add(New MyRegistrator())
            xtraTabControl1.PaintStyleName = "MyStyle"
            xtraTabControl1.Tag = _CheckedPages
        End Sub

        Private Sub xtraTabControl1_MouseDown(ByVal sender As Object, ByVal e As MouseEventArgs)
            Dim hi As ViewInfo.XtraTabHitInfo = xtraTabControl1.CalcHitInfo(e.Location)
            If hi.Page Is Nothing Then Return
            Dim inCheck As Boolean = CType(hi.Page.Tag, Rectangle).Contains(e.Location)
            If inCheck Then
                Dim value As Boolean = False
                _CheckedPages.TryGetValue(hi.Page, value)
                _CheckedPages(hi.Page) = Not value
            End If

            xtraTabControl1.Refresh()
        End Sub
    End Class
End Namespace
