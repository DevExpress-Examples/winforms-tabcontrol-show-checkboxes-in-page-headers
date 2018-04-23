Imports System
Imports System.Drawing
Imports DevExpress.XtraTab.ViewInfo

Namespace WindowsApplication1
    Public Class MyBaseTabPageViewInfo
        Inherits BaseTabPageViewInfo

        Public Sub New(ByVal page As DevExpress.XtraTab.IXtraTabPage)
            MyBase.New(page)
        End Sub

        Public Overrides ReadOnly Property HasImage() As Boolean
            Get
                Return True
            End Get
        End Property

        Public Overrides ReadOnly Property ImageSize() As Size
            Get
                Return New Size(16, 16)
            End Get
        End Property
    End Class
End Namespace
