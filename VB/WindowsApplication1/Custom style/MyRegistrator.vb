Imports System.ComponentModel
Imports System.Drawing
Imports DevExpress.XtraTab.Registrator
Imports DevExpress.XtraTab.Drawing
Imports DevExpress.XtraTab.ViewInfo
Imports DevExpress.XtraTab

Namespace WindowsApplication1

    Public Class MyRegistrator
        Inherits SkinViewInfoRegistrator

        Public Sub New()
        End Sub

        Public Overrides ReadOnly Property ViewName As String
            Get
                Return "MyStyle"
            End Get
        End Property

        Public Overrides Function CreatePainter(ByVal tabControl As IXtraTab) As DevExpress.XtraTab.Drawing.BaseTabPainter
            Return New MySkinTabPainter(tabControl)
        End Function

        Public Overrides Function CreateHeaderViewInfo(ByVal viewInfo As BaseTabControlViewInfo) As BaseTabHeaderViewInfo
            Return New MySkinTabHeaderViewInfo(viewInfo)
        End Function
    End Class
End Namespace
