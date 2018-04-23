Namespace WindowsApplication1
    Partial Public Class Form1
        ''' <summary>
        ''' Required designer variable.
        ''' </summary>
        Private components As System.ComponentModel.IContainer = Nothing

        ''' <summary>
        ''' Clean up any resources being used.
        ''' </summary>
        ''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing AndAlso (components IsNot Nothing) Then
                components.Dispose()
            End If
            MyBase.Dispose(disposing)
        End Sub

        #Region "Windows Form Designer generated code"

        ''' <summary>
        ''' Required method for Designer support - do not modify
        ''' the contents of this method with the code editor.
        ''' </summary>
        Private Sub InitializeComponent()
            Me.xtraTabControl1 = New DevExpress.XtraTab.XtraTabControl()
            Me.xtraTabPage1 = New DevExpress.XtraTab.XtraTabPage()
            Me.groupControl1 = New DevExpress.XtraEditors.GroupControl()
            Me.xtraTabPage2 = New DevExpress.XtraTab.XtraTabPage()
            Me.simpleButton2 = New DevExpress.XtraEditors.SimpleButton()
            Me.xtraTabPage3 = New DevExpress.XtraTab.XtraTabPage()
            Me.xtraTabPage4 = New DevExpress.XtraTab.XtraTabPage()
            Me.xtraTabPage5 = New DevExpress.XtraTab.XtraTabPage()
            Me.xtraTabPage6 = New DevExpress.XtraTab.XtraTabPage()
            CType(Me.xtraTabControl1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.xtraTabControl1.SuspendLayout()
            Me.xtraTabPage1.SuspendLayout()
            CType(Me.groupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.xtraTabPage2.SuspendLayout()
            Me.SuspendLayout()
            ' 
            ' xtraTabControl1
            ' 
            Me.xtraTabControl1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.xtraTabControl1.Location = New System.Drawing.Point(0, 0)
            Me.xtraTabControl1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
            Me.xtraTabControl1.Name = "xtraTabControl1"
            Me.xtraTabControl1.SelectedTabPage = Me.xtraTabPage1
            Me.xtraTabControl1.Size = New System.Drawing.Size(389, 259)
            Me.xtraTabControl1.TabIndex = 0
            Me.xtraTabControl1.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() { Me.xtraTabPage1, Me.xtraTabPage2, Me.xtraTabPage3, Me.xtraTabPage4, Me.xtraTabPage5, Me.xtraTabPage6})
            ' 
            ' xtraTabPage1
            ' 
            Me.xtraTabPage1.Controls.Add(Me.groupControl1)
            Me.xtraTabPage1.ImageIndex = 0
            Me.xtraTabPage1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
            Me.xtraTabPage1.Name = "xtraTabPage1"
            Me.xtraTabPage1.Size = New System.Drawing.Size(383, 230)
            Me.xtraTabPage1.Text = "Protection status"
            ' 
            ' groupControl1
            ' 
            Me.groupControl1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.groupControl1.Location = New System.Drawing.Point(0, 0)
            Me.groupControl1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
            Me.groupControl1.Name = "groupControl1"
            Me.groupControl1.Size = New System.Drawing.Size(383, 230)
            Me.groupControl1.TabIndex = 0
            Me.groupControl1.Text = "groupControl1"
            ' 
            ' xtraTabPage2
            ' 
            Me.xtraTabPage2.Controls.Add(Me.simpleButton2)
            Me.xtraTabPage2.ImageIndex = 8
            Me.xtraTabPage2.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
            Me.xtraTabPage2.Name = "xtraTabPage2"
            Me.xtraTabPage2.Size = New System.Drawing.Size(383, 230)
            Me.xtraTabPage2.Text = "Computer scan"
            ' 
            ' simpleButton2
            ' 
            Me.simpleButton2.Location = New System.Drawing.Point(283, 192)
            Me.simpleButton2.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
            Me.simpleButton2.Name = "simpleButton2"
            Me.simpleButton2.Size = New System.Drawing.Size(87, 28)
            Me.simpleButton2.TabIndex = 1
            Me.simpleButton2.Text = "simpleButton2"
            ' 
            ' xtraTabPage3
            ' 
            Me.xtraTabPage3.ImageIndex = 9
            Me.xtraTabPage3.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
            Me.xtraTabPage3.Name = "xtraTabPage3"
            Me.xtraTabPage3.Size = New System.Drawing.Size(383, 230)
            Me.xtraTabPage3.Text = "Update"
            ' 
            ' xtraTabPage4
            ' 
            Me.xtraTabPage4.ImageIndex = 2
            Me.xtraTabPage4.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
            Me.xtraTabPage4.Name = "xtraTabPage4"
            Me.xtraTabPage4.Size = New System.Drawing.Size(383, 230)
            Me.xtraTabPage4.Text = "Setup"
            ' 
            ' xtraTabPage5
            ' 
            Me.xtraTabPage5.ImageIndex = 3
            Me.xtraTabPage5.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
            Me.xtraTabPage5.Name = "xtraTabPage5"
            Me.xtraTabPage5.Size = New System.Drawing.Size(383, 230)
            Me.xtraTabPage5.Text = "Tools"
            ' 
            ' xtraTabPage6
            ' 
            Me.xtraTabPage6.ImageIndex = 4
            Me.xtraTabPage6.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
            Me.xtraTabPage6.Name = "xtraTabPage6"
            Me.xtraTabPage6.Size = New System.Drawing.Size(383, 230)
            Me.xtraTabPage6.Text = "Help"
            ' 
            ' Form1
            ' 
            Me.AutoScaleDimensions = New System.Drawing.SizeF(7F, 16F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(389, 259)
            Me.Controls.Add(Me.xtraTabControl1)
            Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
            Me.Name = "Form1"
            Me.Text = "Form1"
            CType(Me.xtraTabControl1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.xtraTabControl1.ResumeLayout(False)
            Me.xtraTabPage1.ResumeLayout(False)
            CType(Me.groupControl1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.xtraTabPage2.ResumeLayout(False)
            Me.ResumeLayout(False)

        End Sub

        #End Region

        Private WithEvents xtraTabControl1 As DevExpress.XtraTab.XtraTabControl
        Private xtraTabPage1 As DevExpress.XtraTab.XtraTabPage
        Private xtraTabPage2 As DevExpress.XtraTab.XtraTabPage
        Private groupControl1 As DevExpress.XtraEditors.GroupControl
        Private simpleButton2 As DevExpress.XtraEditors.SimpleButton
        Private xtraTabPage3 As DevExpress.XtraTab.XtraTabPage
        Private xtraTabPage4 As DevExpress.XtraTab.XtraTabPage
        Private xtraTabPage5 As DevExpress.XtraTab.XtraTabPage
        Private xtraTabPage6 As DevExpress.XtraTab.XtraTabPage

    End Class
End Namespace

