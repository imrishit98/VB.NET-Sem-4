<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Simple_Calculator
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
        Me.plus = New System.Windows.Forms.Button()
        Me.minus = New System.Windows.Forms.Button()
        Me.multiplication = New System.Windows.Forms.Button()
        Me.division = New System.Windows.Forms.Button()
        Me.expo = New System.Windows.Forms.Button()
        Me.btn_clear = New System.Windows.Forms.Button()
        Me.val1 = New System.Windows.Forms.TextBox()
        Me.val2 = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.lbl_oprand = New System.Windows.Forms.Label()
        Me.lbl_answer = New System.Windows.Forms.Label()
        Me.choose_tan = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.angle_val = New System.Windows.Forms.TextBox()
        Me.lbl_tan_ans = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'plus
        '
        Me.plus.Font = New System.Drawing.Font("Cambria", 28.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.plus.Location = New System.Drawing.Point(22, 36)
        Me.plus.Margin = New System.Windows.Forms.Padding(2)
        Me.plus.Name = "plus"
        Me.plus.Size = New System.Drawing.Size(61, 61)
        Me.plus.TabIndex = 0
        Me.plus.Text = "+"
        Me.plus.UseVisualStyleBackColor = True
        '
        'minus
        '
        Me.minus.Font = New System.Drawing.Font("Cambria", 28.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.minus.Location = New System.Drawing.Point(109, 36)
        Me.minus.Margin = New System.Windows.Forms.Padding(2)
        Me.minus.Name = "minus"
        Me.minus.Size = New System.Drawing.Size(61, 61)
        Me.minus.TabIndex = 1
        Me.minus.Text = "-"
        Me.minus.UseVisualStyleBackColor = True
        '
        'multiplication
        '
        Me.multiplication.Font = New System.Drawing.Font("Cambria", 28.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.multiplication.Location = New System.Drawing.Point(198, 36)
        Me.multiplication.Margin = New System.Windows.Forms.Padding(2)
        Me.multiplication.Name = "multiplication"
        Me.multiplication.Size = New System.Drawing.Size(61, 61)
        Me.multiplication.TabIndex = 2
        Me.multiplication.Text = "*"
        Me.multiplication.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.multiplication.UseVisualStyleBackColor = True
        '
        'division
        '
        Me.division.Font = New System.Drawing.Font("Cambria", 28.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.division.Location = New System.Drawing.Point(22, 125)
        Me.division.Margin = New System.Windows.Forms.Padding(2)
        Me.division.Name = "division"
        Me.division.Size = New System.Drawing.Size(61, 61)
        Me.division.TabIndex = 3
        Me.division.Text = "/"
        Me.division.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.division.UseVisualStyleBackColor = True
        '
        'expo
        '
        Me.expo.Font = New System.Drawing.Font("Cambria", 28.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.expo.Location = New System.Drawing.Point(109, 125)
        Me.expo.Margin = New System.Windows.Forms.Padding(2)
        Me.expo.Name = "expo"
        Me.expo.Size = New System.Drawing.Size(61, 61)
        Me.expo.TabIndex = 4
        Me.expo.Text = "^"
        Me.expo.UseVisualStyleBackColor = True
        '
        'btn_clear
        '
        Me.btn_clear.Font = New System.Drawing.Font("Consolas", 29.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_clear.Location = New System.Drawing.Point(198, 125)
        Me.btn_clear.Margin = New System.Windows.Forms.Padding(2)
        Me.btn_clear.Name = "btn_clear"
        Me.btn_clear.Size = New System.Drawing.Size(61, 61)
        Me.btn_clear.TabIndex = 5
        Me.btn_clear.Text = "c"
        Me.btn_clear.UseVisualStyleBackColor = True
        '
        'val1
        '
        Me.val1.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.val1.Location = New System.Drawing.Point(303, 36)
        Me.val1.Name = "val1"
        Me.val1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.val1.Size = New System.Drawing.Size(269, 39)
        Me.val1.TabIndex = 6
        '
        'val2
        '
        Me.val2.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.val2.Location = New System.Drawing.Point(303, 147)
        Me.val2.Name = "val2"
        Me.val2.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.val2.Size = New System.Drawing.Size(269, 39)
        Me.val2.TabIndex = 7
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Consolas", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Button1.Location = New System.Drawing.Point(303, 217)
        Me.Button1.Margin = New System.Windows.Forms.Padding(2)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(269, 42)
        Me.Button1.TabIndex = 8
        Me.Button1.Text = "="
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Button1.UseVisualStyleBackColor = True
        '
        'lbl_oprand
        '
        Me.lbl_oprand.AutoSize = True
        Me.lbl_oprand.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_oprand.Location = New System.Drawing.Point(409, 83)
        Me.lbl_oprand.Name = "lbl_oprand"
        Me.lbl_oprand.Size = New System.Drawing.Size(52, 55)
        Me.lbl_oprand.TabIndex = 9
        Me.lbl_oprand.Text = "+"
        Me.lbl_oprand.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbl_answer
        '
        Me.lbl_answer.AutoSize = True
        Me.lbl_answer.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_answer.Location = New System.Drawing.Point(296, 284)
        Me.lbl_answer.MaximumSize = New System.Drawing.Size(311, 0)
        Me.lbl_answer.Name = "lbl_answer"
        Me.lbl_answer.Size = New System.Drawing.Size(124, 37)
        Me.lbl_answer.TabIndex = 11
        Me.lbl_answer.Text = "Answer"
        '
        'choose_tan
        '
        Me.choose_tan.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.choose_tan.FormattingEnabled = True
        Me.choose_tan.Items.AddRange(New Object() {"sin", "cos", "tan"})
        Me.choose_tan.Location = New System.Drawing.Point(22, 234)
        Me.choose_tan.Name = "choose_tan"
        Me.choose_tan.Size = New System.Drawing.Size(76, 26)
        Me.choose_tan.TabIndex = 12
        Me.choose_tan.Text = "Choose"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(46, 199)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(181, 20)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "Find sin, tan, cos values:"
        '
        'angle_val
        '
        Me.angle_val.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.angle_val.Location = New System.Drawing.Point(109, 234)
        Me.angle_val.Name = "angle_val"
        Me.angle_val.Size = New System.Drawing.Size(150, 24)
        Me.angle_val.TabIndex = 14
        '
        'lbl_tan_ans
        '
        Me.lbl_tan_ans.AutoSize = True
        Me.lbl_tan_ans.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_tan_ans.Location = New System.Drawing.Point(21, 275)
        Me.lbl_tan_ans.MaximumSize = New System.Drawing.Size(251, 0)
        Me.lbl_tan_ans.Name = "lbl_tan_ans"
        Me.lbl_tan_ans.Size = New System.Drawing.Size(102, 24)
        Me.lbl_tan_ans.TabIndex = 15
        Me.lbl_tan_ans.Text = "sin __ is __"
        '
        'Simple_Calculator
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(655, 330)
        Me.Controls.Add(Me.lbl_tan_ans)
        Me.Controls.Add(Me.angle_val)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.choose_tan)
        Me.Controls.Add(Me.lbl_answer)
        Me.Controls.Add(Me.lbl_oprand)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.val2)
        Me.Controls.Add(Me.val1)
        Me.Controls.Add(Me.btn_clear)
        Me.Controls.Add(Me.expo)
        Me.Controls.Add(Me.division)
        Me.Controls.Add(Me.multiplication)
        Me.Controls.Add(Me.minus)
        Me.Controls.Add(Me.plus)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "Simple_Calculator"
        Me.Text = "Simple Calculator"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents plus As Button
    Friend WithEvents minus As Button
    Friend WithEvents multiplication As Button
    Friend WithEvents division As Button
    Friend WithEvents expo As Button
    Friend WithEvents btn_clear As Button
    Friend WithEvents val1 As TextBox
    Friend WithEvents val2 As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents lbl_oprand As Label
    Friend WithEvents lbl_answer As Label
    Friend WithEvents choose_tan As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents angle_val As TextBox
    Friend WithEvents lbl_tan_ans As Label
End Class
