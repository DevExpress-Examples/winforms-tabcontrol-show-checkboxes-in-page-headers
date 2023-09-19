Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Drawing
Imports DevExpress.XtraTab.Drawing
Imports DevExpress.XtraTab
Imports DevExpress.XtraTab.ViewInfo
Imports DevExpress.XtraEditors.Repository

Namespace WindowsApplication1

    Public Class MySkinTabPainter
        Inherits SkinTabPainter

        Public Shared HeaderEdit As RepositoryItemCheckEdit = New RepositoryItemCheckEdit()

        Public Sub New(ByVal tabControl As IXtraTab)
            MyBase.New(tabControl)
        End Sub

        Protected Overrides Sub DrawHeaderPageImage(ByVal e As TabDrawArgs, ByVal pInfo As BaseTabPageViewInfo)
            Dim page As XtraTabPage = TryCast(pInfo.Page, XtraTabPage)
            page.Tag = pInfo.Image
            Dim value As Boolean = False
            TryCast(page.TabControl.Tag, Dictionary(Of XtraTabPage, Boolean)).TryGetValue(page, value)
            DrawEdit(e.Graphics, HeaderEdit, pInfo.Image, value)
        End Sub
    End Class
End Namespace
