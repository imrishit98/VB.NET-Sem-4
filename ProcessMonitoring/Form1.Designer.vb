<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.theExeList = New System.Windows.Forms.ListBox()
        Me.fbd = New System.Windows.Forms.FolderBrowserDialog()
        Me.filePathTB = New System.Windows.Forms.TextBox()
        Me.browseBtn = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'theExeList
        '
        Me.theExeList.FormattingEnabled = True
        Me.theExeList.ItemHeight = 16
        Me.theExeList.Location = New System.Drawing.Point(12, 62)
        Me.theExeList.Name = "theExeList"
        Me.theExeList.ScrollAlwaysVisible = True
        Me.theExeList.Size = New System.Drawing.Size(762, 308)
        Me.theExeList.TabIndex = 0
        '
        'filePathTB
        '
        Me.filePathTB.Location = New System.Drawing.Point(12, 21)
        Me.filePathTB.Name = "filePathTB"
        Me.filePathTB.Size = New System.Drawing.Size(399, 22)
        Me.filePathTB.TabIndex = 1
        '
        'browseBtn
        '
        Me.browseBtn.Location = New System.Drawing.Point(426, 20)
        Me.browseBtn.Name = "browseBtn"
        Me.browseBtn.Size = New System.Drawing.Size(75, 23)
        Me.browseBtn.TabIndex = 2
        Me.browseBtn.Text = "Browse"
        Me.browseBtn.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.browseBtn)
        Me.Controls.Add(Me.filePathTB)
        Me.Controls.Add(Me.theExeList)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents theExeList As ListBox
    Friend WithEvents fbd As FolderBrowserDialog
    Friend WithEvents filePathTB As TextBox
    Friend WithEvents browseBtn As Button
End Class
