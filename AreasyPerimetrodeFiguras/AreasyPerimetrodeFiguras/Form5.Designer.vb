<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmCirculo
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
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.BtnArea = New System.Windows.Forms.Button()
        Me.BtnPerimetro = New System.Windows.Forms.Button()
        Me.LblResultadoA = New System.Windows.Forms.Label()
        Me.LblResultadoP = New System.Windows.Forms.Label()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(50, 31)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(294, 24)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "Área y perímetro de un círculo"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(17, 91)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(122, 13)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "Ingrese el valor del radio"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(158, 88)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(117, 20)
        Me.TextBox1.TabIndex = 12
        '
        'BtnArea
        '
        Me.BtnArea.Location = New System.Drawing.Point(304, 67)
        Me.BtnArea.Name = "BtnArea"
        Me.BtnArea.Size = New System.Drawing.Size(75, 23)
        Me.BtnArea.TabIndex = 13
        Me.BtnArea.Text = "Área"
        Me.BtnArea.UseVisualStyleBackColor = True
        '
        'BtnPerimetro
        '
        Me.BtnPerimetro.Location = New System.Drawing.Point(304, 109)
        Me.BtnPerimetro.Name = "BtnPerimetro"
        Me.BtnPerimetro.Size = New System.Drawing.Size(75, 23)
        Me.BtnPerimetro.TabIndex = 14
        Me.BtnPerimetro.Text = "Perímetro"
        Me.BtnPerimetro.UseVisualStyleBackColor = True
        '
        'LblResultadoA
        '
        Me.LblResultadoA.AutoSize = True
        Me.LblResultadoA.Location = New System.Drawing.Point(88, 129)
        Me.LblResultadoA.Name = "LblResultadoA"
        Me.LblResultadoA.Size = New System.Drawing.Size(0, 13)
        Me.LblResultadoA.TabIndex = 15
        '
        'LblResultadoP
        '
        Me.LblResultadoP.AutoSize = True
        Me.LblResultadoP.Location = New System.Drawing.Point(122, 165)
        Me.LblResultadoP.Name = "LblResultadoP"
        Me.LblResultadoP.Size = New System.Drawing.Size(0, 13)
        Me.LblResultadoP.TabIndex = 16
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(311, 165)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 23)
        Me.Button3.TabIndex = 17
        Me.Button3.Text = "Salir"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(17, 129)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(54, 13)
        Me.Label2.TabIndex = 18
        Me.Label2.Text = "El área es"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(135, 129)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(27, 13)
        Me.Label4.TabIndex = 19
        Me.Label4.Text = "cm2"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(17, 165)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(78, 13)
        Me.Label5.TabIndex = 20
        Me.Label5.Text = "El perímetro es"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(174, 165)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(21, 13)
        Me.Label6.TabIndex = 21
        Me.Label6.Text = "cm"
        '
        'FrmCirculo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(398, 200)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.LblResultadoP)
        Me.Controls.Add(Me.LblResultadoA)
        Me.Controls.Add(Me.BtnPerimetro)
        Me.Controls.Add(Me.BtnArea)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label3)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmCirculo"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Circulo"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label3 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents BtnArea As Button
    Friend WithEvents BtnPerimetro As Button
    Friend WithEvents LblResultadoA As Label
    Friend WithEvents LblResultadoP As Label
    Friend WithEvents Button3 As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
End Class
