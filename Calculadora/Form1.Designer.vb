<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.ButtonEqual = New System.Windows.Forms.Button()
        Me.Num0 = New System.Windows.Forms.Button()
        Me.ButtonMult = New System.Windows.Forms.Button()
        Me.ButtonDiv = New System.Windows.Forms.Button()
        Me.Num3 = New System.Windows.Forms.Button()
        Me.Num2 = New System.Windows.Forms.Button()
        Me.ButtonMen = New System.Windows.Forms.Button()
        Me.Num1 = New System.Windows.Forms.Button()
        Me.inputCalc = New System.Windows.Forms.TextBox()
        Me.Buttonmas = New System.Windows.Forms.Button()
        Me.negativ = New System.Windows.Forms.Button()
        Me.Buttoncoma = New System.Windows.Forms.Button()
        Me.ButtonAC = New System.Windows.Forms.Button()
        Me.Num9 = New System.Windows.Forms.Button()
        Me.Num8 = New System.Windows.Forms.Button()
        Me.Num7 = New System.Windows.Forms.Button()
        Me.Num6 = New System.Windows.Forms.Button()
        Me.Num5 = New System.Windows.Forms.Button()
        Me.Num4 = New System.Windows.Forms.Button()
        Me.oper = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'ButtonEqual
        '
        Me.ButtonEqual.Location = New System.Drawing.Point(93, 311)
        Me.ButtonEqual.Name = "ButtonEqual"
        Me.ButtonEqual.Size = New System.Drawing.Size(151, 35)
        Me.ButtonEqual.TabIndex = 0
        Me.ButtonEqual.Text = "="
        Me.ButtonEqual.UseVisualStyleBackColor = True
        '
        'Num0
        '
        Me.Num0.Location = New System.Drawing.Point(39, 311)
        Me.Num0.Name = "Num0"
        Me.Num0.Size = New System.Drawing.Size(39, 35)
        Me.Num0.TabIndex = 17
        Me.Num0.TabStop = False
        Me.Num0.Text = "0"
        Me.Num0.UseVisualStyleBackColor = True
        '
        'ButtonMult
        '
        Me.ButtonMult.Location = New System.Drawing.Point(205, 205)
        Me.ButtonMult.Name = "ButtonMult"
        Me.ButtonMult.Size = New System.Drawing.Size(39, 35)
        Me.ButtonMult.TabIndex = 12
        Me.ButtonMult.TabStop = False
        Me.ButtonMult.Text = "*"
        Me.ButtonMult.UseVisualStyleBackColor = True
        '
        'ButtonDiv
        '
        Me.ButtonDiv.Location = New System.Drawing.Point(205, 262)
        Me.ButtonDiv.Name = "ButtonDiv"
        Me.ButtonDiv.Size = New System.Drawing.Size(39, 35)
        Me.ButtonDiv.TabIndex = 16
        Me.ButtonDiv.TabStop = False
        Me.ButtonDiv.Text = "/"
        Me.ButtonDiv.UseVisualStyleBackColor = True
        '
        'Num3
        '
        Me.Num3.Location = New System.Drawing.Point(151, 262)
        Me.Num3.Name = "Num3"
        Me.Num3.Size = New System.Drawing.Size(39, 35)
        Me.Num3.TabIndex = 15
        Me.Num3.TabStop = False
        Me.Num3.Text = "3"
        Me.Num3.UseVisualStyleBackColor = True
        '
        'Num2
        '
        Me.Num2.Location = New System.Drawing.Point(93, 262)
        Me.Num2.Name = "Num2"
        Me.Num2.Size = New System.Drawing.Size(39, 35)
        Me.Num2.TabIndex = 14
        Me.Num2.TabStop = False
        Me.Num2.Text = "2"
        Me.Num2.UseVisualStyleBackColor = True
        '
        'ButtonMen
        '
        Me.ButtonMen.Location = New System.Drawing.Point(205, 148)
        Me.ButtonMen.Name = "ButtonMen"
        Me.ButtonMen.Size = New System.Drawing.Size(39, 35)
        Me.ButtonMen.TabIndex = 8
        Me.ButtonMen.TabStop = False
        Me.ButtonMen.Text = "-"
        Me.ButtonMen.UseVisualStyleBackColor = True
        '
        'Num1
        '
        Me.Num1.Location = New System.Drawing.Point(39, 262)
        Me.Num1.Name = "Num1"
        Me.Num1.Size = New System.Drawing.Size(39, 35)
        Me.Num1.TabIndex = 13
        Me.Num1.TabStop = False
        Me.Num1.Text = "1"
        Me.Num1.UseVisualStyleBackColor = True
        '
        'inputCalc
        '
        Me.inputCalc.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.inputCalc.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.inputCalc.Enabled = False
        Me.inputCalc.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.inputCalc.Location = New System.Drawing.Point(39, 40)
        Me.inputCalc.Name = "inputCalc"
        Me.inputCalc.ReadOnly = True
        Me.inputCalc.Size = New System.Drawing.Size(205, 19)
        Me.inputCalc.TabIndex = 3
        Me.inputCalc.TabStop = False
        Me.inputCalc.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Buttonmas
        '
        Me.Buttonmas.Location = New System.Drawing.Point(205, 96)
        Me.Buttonmas.Name = "Buttonmas"
        Me.Buttonmas.Size = New System.Drawing.Size(39, 35)
        Me.Buttonmas.TabIndex = 4
        Me.Buttonmas.TabStop = False
        Me.Buttonmas.Text = "+"
        Me.Buttonmas.UseVisualStyleBackColor = True
        '
        'negativ
        '
        Me.negativ.Location = New System.Drawing.Point(151, 96)
        Me.negativ.Name = "negativ"
        Me.negativ.Size = New System.Drawing.Size(39, 35)
        Me.negativ.TabIndex = 3
        Me.negativ.TabStop = False
        Me.negativ.Text = "+/-"
        Me.negativ.UseVisualStyleBackColor = True
        '
        'Buttoncoma
        '
        Me.Buttoncoma.Location = New System.Drawing.Point(93, 96)
        Me.Buttoncoma.Name = "Buttoncoma"
        Me.Buttoncoma.Size = New System.Drawing.Size(39, 35)
        Me.Buttoncoma.TabIndex = 2
        Me.Buttoncoma.TabStop = False
        Me.Buttoncoma.Text = ","
        Me.Buttoncoma.UseVisualStyleBackColor = True
        '
        'ButtonAC
        '
        Me.ButtonAC.Location = New System.Drawing.Point(39, 96)
        Me.ButtonAC.Name = "ButtonAC"
        Me.ButtonAC.Size = New System.Drawing.Size(39, 35)
        Me.ButtonAC.TabIndex = 1
        Me.ButtonAC.TabStop = False
        Me.ButtonAC.Text = "AC"
        Me.ButtonAC.UseVisualStyleBackColor = True
        '
        'Num9
        '
        Me.Num9.Location = New System.Drawing.Point(151, 148)
        Me.Num9.Name = "Num9"
        Me.Num9.Size = New System.Drawing.Size(39, 35)
        Me.Num9.TabIndex = 7
        Me.Num9.TabStop = False
        Me.Num9.Text = "9"
        Me.Num9.UseVisualStyleBackColor = True
        '
        'Num8
        '
        Me.Num8.Location = New System.Drawing.Point(93, 148)
        Me.Num8.Name = "Num8"
        Me.Num8.Size = New System.Drawing.Size(39, 35)
        Me.Num8.TabIndex = 6
        Me.Num8.TabStop = False
        Me.Num8.Text = "8"
        Me.Num8.UseVisualStyleBackColor = True
        '
        'Num7
        '
        Me.Num7.Location = New System.Drawing.Point(39, 148)
        Me.Num7.Name = "Num7"
        Me.Num7.Size = New System.Drawing.Size(39, 35)
        Me.Num7.TabIndex = 5
        Me.Num7.TabStop = False
        Me.Num7.Text = "7"
        Me.Num7.UseVisualStyleBackColor = True
        '
        'Num6
        '
        Me.Num6.Location = New System.Drawing.Point(151, 205)
        Me.Num6.Name = "Num6"
        Me.Num6.Size = New System.Drawing.Size(39, 35)
        Me.Num6.TabIndex = 11
        Me.Num6.TabStop = False
        Me.Num6.Text = "6"
        Me.Num6.UseVisualStyleBackColor = True
        '
        'Num5
        '
        Me.Num5.Location = New System.Drawing.Point(93, 205)
        Me.Num5.Name = "Num5"
        Me.Num5.Size = New System.Drawing.Size(39, 35)
        Me.Num5.TabIndex = 10
        Me.Num5.TabStop = False
        Me.Num5.Text = "5"
        Me.Num5.UseVisualStyleBackColor = True
        '
        'Num4
        '
        Me.Num4.Location = New System.Drawing.Point(39, 205)
        Me.Num4.Name = "Num4"
        Me.Num4.Size = New System.Drawing.Size(39, 35)
        Me.Num4.TabIndex = 9
        Me.Num4.TabStop = False
        Me.Num4.Text = "4"
        Me.Num4.UseVisualStyleBackColor = True
        '
        'oper
        '
        Me.oper.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.oper.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.oper.Enabled = False
        Me.oper.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.oper.Location = New System.Drawing.Point(39, 25)
        Me.oper.Name = "oper"
        Me.oper.ReadOnly = True
        Me.oper.Size = New System.Drawing.Size(205, 15)
        Me.oper.TabIndex = 3
        Me.oper.TabStop = False
        Me.oper.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Form1
        '
        Me.AcceptButton = Me.ButtonEqual
        Me.AccessibleRole = System.Windows.Forms.AccessibleRole.Window
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.AutoValidate = System.Windows.Forms.AutoValidate.Disable
        Me.ClientSize = New System.Drawing.Size(293, 378)
        Me.Controls.Add(Me.Num6)
        Me.Controls.Add(Me.Num5)
        Me.Controls.Add(Me.Num4)
        Me.Controls.Add(Me.Num9)
        Me.Controls.Add(Me.Num8)
        Me.Controls.Add(Me.Num7)
        Me.Controls.Add(Me.Buttonmas)
        Me.Controls.Add(Me.negativ)
        Me.Controls.Add(Me.Buttoncoma)
        Me.Controls.Add(Me.ButtonAC)
        Me.Controls.Add(Me.ButtonEqual)
        Me.Controls.Add(Me.Num0)
        Me.Controls.Add(Me.ButtonMult)
        Me.Controls.Add(Me.ButtonDiv)
        Me.Controls.Add(Me.Num3)
        Me.Controls.Add(Me.Num2)
        Me.Controls.Add(Me.ButtonMen)
        Me.Controls.Add(Me.Num1)
        Me.Controls.Add(Me.oper)
        Me.Controls.Add(Me.inputCalc)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.Text = "Calculadora"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ButtonEqual As Button
    Friend WithEvents Num0 As Button
    Friend WithEvents ButtonMult As Button
    Friend WithEvents ButtonDiv As Button
    Friend WithEvents Num3 As Button
    Friend WithEvents Num2 As Button
    Friend WithEvents ButtonMen As Button
    Friend WithEvents Num1 As Button
    Friend WithEvents inputCalc As TextBox
    Friend WithEvents Buttonmas As Button
    Friend WithEvents negativ As Button
    Friend WithEvents Buttoncoma As Button
    Friend WithEvents ButtonAC As Button
    Friend WithEvents Num9 As Button
    Friend WithEvents Num8 As Button
    Friend WithEvents Num7 As Button
    Friend WithEvents Num6 As Button
    Friend WithEvents Num5 As Button
    Friend WithEvents Num4 As Button
    Friend WithEvents oper As TextBox
End Class
