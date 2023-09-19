Imports System.ComponentModel
Imports System.Drawing
Imports DevExpress.Utils.Drawing
Imports DevExpress.XtraEditors.Drawing
Imports DevExpress.XtraEditors.ViewInfo
Imports DevExpress.XtraEditors.Repository

Namespace WindowsApplication1

    Public Module DrawEditorHelper

        Public Sub DrawEdit(ByVal g As Graphics, ByVal edit As RepositoryItem, ByVal r As Rectangle, ByVal value As Object)
            Dim info As BaseEditViewInfo = TryCast(edit.CreateViewInfo(), BaseEditViewInfo)
            Dim painter As BaseEditPainter = edit.CreatePainter()
            info.EditValue = value
            info.Bounds = r
            info.CalcViewInfo(g)
            Dim args As ControlGraphicsInfoArgs = New ControlGraphicsInfoArgs(info, New GraphicsCache(g), r)
            painter.Draw(args)
            args.Cache.Dispose()
        End Sub
    End Module
End Namespace
