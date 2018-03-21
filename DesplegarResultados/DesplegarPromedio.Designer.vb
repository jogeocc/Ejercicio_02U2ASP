<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DesplegarPromedio
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
        Me.BtnDesplegar = New System.Windows.Forms.Button()
        Me.BtnRegresar = New System.Windows.Forms.Button()
        Me.TxtPromProms = New System.Windows.Forms.TextBox()
        Me.LblProm = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'BtnDesplegar
        '
        Me.BtnDesplegar.Location = New System.Drawing.Point(56, 175)
        Me.BtnDesplegar.Name = "BtnDesplegar"
        Me.BtnDesplegar.Size = New System.Drawing.Size(126, 45)
        Me.BtnDesplegar.TabIndex = 7
        Me.BtnDesplegar.Text = "Desplegar"
        Me.BtnDesplegar.UseVisualStyleBackColor = True
        '
        'BtnRegresar
        '
        Me.BtnRegresar.Location = New System.Drawing.Point(260, 175)
        Me.BtnRegresar.Name = "BtnRegresar"
        Me.BtnRegresar.Size = New System.Drawing.Size(155, 45)
        Me.BtnRegresar.TabIndex = 6
        Me.BtnRegresar.Text = "Salir"
        Me.BtnRegresar.UseVisualStyleBackColor = True
        '
        'TxtPromProms
        '
        Me.TxtPromProms.Enabled = False
        Me.TxtPromProms.Location = New System.Drawing.Point(315, 62)
        Me.TxtPromProms.Name = "TxtPromProms"
        Me.TxtPromProms.Size = New System.Drawing.Size(100, 20)
        Me.TxtPromProms.TabIndex = 5
        '
        'LblProm
        '
        Me.LblProm.AutoSize = True
        Me.LblProm.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblProm.Location = New System.Drawing.Point(33, 57)
        Me.LblProm.Name = "LblProm"
        Me.LblProm.Size = New System.Drawing.Size(239, 25)
        Me.LblProm.TabIndex = 4
        Me.LblProm.Text = "Promedio de promedios"
        '
        'DesplegarPromedio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(494, 261)
        Me.Controls.Add(Me.BtnDesplegar)
        Me.Controls.Add(Me.BtnRegresar)
        Me.Controls.Add(Me.TxtPromProms)
        Me.Controls.Add(Me.LblProm)
        Me.Name = "DesplegarPromedio"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private WithEvents BtnDesplegar As Button
    Private WithEvents BtnRegresar As Button
    Private WithEvents TxtPromProms As TextBox
    Private WithEvents LblProm As Label
End Class
