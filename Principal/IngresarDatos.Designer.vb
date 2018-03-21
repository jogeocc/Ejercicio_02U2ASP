<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class IngresarDatos
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
        Me.btnDesplegar = New System.Windows.Forms.Button()
        Me.lblPromGen = New System.Windows.Forms.Label()
        Me.lblMensaje = New System.Windows.Forms.Label()
        Me.txtCuantos = New System.Windows.Forms.TextBox()
        Me.cuantos = New System.Windows.Forms.Label()
        Me.LbProm = New System.Windows.Forms.Label()
        Me.label5 = New System.Windows.Forms.Label()
        Me.button1 = New System.Windows.Forms.Button()
        Me.TxbC = New System.Windows.Forms.TextBox()
        Me.TxbB = New System.Windows.Forms.TextBox()
        Me.TxbA = New System.Windows.Forms.TextBox()
        Me.label4 = New System.Windows.Forms.Label()
        Me.label3 = New System.Windows.Forms.Label()
        Me.label2 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnDesplegar
        '
        Me.btnDesplegar.Location = New System.Drawing.Point(491, 202)
        Me.btnDesplegar.Name = "btnDesplegar"
        Me.btnDesplegar.Size = New System.Drawing.Size(75, 53)
        Me.btnDesplegar.TabIndex = 5
        Me.btnDesplegar.Text = "Ir a desplegar"
        Me.btnDesplegar.UseVisualStyleBackColor = True
        '
        'lblPromGen
        '
        Me.lblPromGen.AutoSize = True
        Me.lblPromGen.Location = New System.Drawing.Point(389, 32)
        Me.lblPromGen.Name = "lblPromGen"
        Me.lblPromGen.Size = New System.Drawing.Size(121, 13)
        Me.lblPromGen.TabIndex = 27
        Me.lblPromGen.Text = "El promedio general: 0.0"
        '
        'lblMensaje
        '
        Me.lblMensaje.AutoSize = True
        Me.lblMensaje.Location = New System.Drawing.Point(395, 271)
        Me.lblMensaje.Name = "lblMensaje"
        Me.lblMensaje.Size = New System.Drawing.Size(0, 13)
        Me.lblMensaje.TabIndex = 26
        '
        'txtCuantos
        '
        Me.txtCuantos.Location = New System.Drawing.Point(101, 13)
        Me.txtCuantos.Name = "txtCuantos"
        Me.txtCuantos.Size = New System.Drawing.Size(100, 20)
        Me.txtCuantos.TabIndex = 0
        '
        'cuantos
        '
        Me.cuantos.AutoSize = True
        Me.cuantos.Location = New System.Drawing.Point(27, 20)
        Me.cuantos.Name = "cuantos"
        Me.cuantos.Size = New System.Drawing.Size(52, 13)
        Me.cuantos.TabIndex = 24
        Me.cuantos.Text = "Cuantos?"
        '
        'LbProm
        '
        Me.LbProm.AutoSize = True
        Me.LbProm.Location = New System.Drawing.Point(272, 242)
        Me.LbProm.Name = "LbProm"
        Me.LbProm.Size = New System.Drawing.Size(22, 13)
        Me.LbProm.TabIndex = 23
        Me.LbProm.Text = "0.0"
        '
        'label5
        '
        Me.label5.AutoSize = True
        Me.label5.Location = New System.Drawing.Point(173, 242)
        Me.label5.Name = "label5"
        Me.label5.Size = New System.Drawing.Size(82, 13)
        Me.label5.TabIndex = 22
        Me.label5.Text = "El promedio es: "
        '
        'button1
        '
        Me.button1.Location = New System.Drawing.Point(491, 100)
        Me.button1.Name = "button1"
        Me.button1.Size = New System.Drawing.Size(75, 23)
        Me.button1.TabIndex = 4
        Me.button1.Text = "Promediar"
        Me.button1.UseVisualStyleBackColor = True
        '
        'TxbC
        '
        Me.TxbC.Location = New System.Drawing.Point(210, 172)
        Me.TxbC.Name = "TxbC"
        Me.TxbC.Size = New System.Drawing.Size(100, 20)
        Me.TxbC.TabIndex = 3
        Me.TxbC.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TxbB
        '
        Me.TxbB.Location = New System.Drawing.Point(210, 110)
        Me.TxbB.Name = "TxbB"
        Me.TxbB.Size = New System.Drawing.Size(100, 20)
        Me.TxbB.TabIndex = 2
        Me.TxbB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TxbA
        '
        Me.TxbA.Location = New System.Drawing.Point(208, 55)
        Me.TxbA.Name = "TxbA"
        Me.TxbA.Size = New System.Drawing.Size(100, 20)
        Me.TxbA.TabIndex = 1
        Me.TxbA.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'label4
        '
        Me.label4.AutoSize = True
        Me.label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label4.Location = New System.Drawing.Point(3, 44)
        Me.label4.Name = "label4"
        Me.label4.Size = New System.Drawing.Size(191, 31)
        Me.label4.TabIndex = 17
        Me.label4.Text = "Dar valor de a:"
        '
        'label3
        '
        Me.label3.AutoSize = True
        Me.label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label3.Location = New System.Drawing.Point(4, 161)
        Me.label3.Name = "label3"
        Me.label3.Size = New System.Drawing.Size(190, 31)
        Me.label3.TabIndex = 16
        Me.label3.Text = "Dar valor de c:"
        '
        'label2
        '
        Me.label2.AutoSize = True
        Me.label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label2.Location = New System.Drawing.Point(3, 100)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(198, 31)
        Me.label2.TabIndex = 15
        Me.label2.Text = "Dar valor de  b:"
        '
        'IngresarDatos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(635, 291)
        Me.Controls.Add(Me.btnDesplegar)
        Me.Controls.Add(Me.lblPromGen)
        Me.Controls.Add(Me.lblMensaje)
        Me.Controls.Add(Me.txtCuantos)
        Me.Controls.Add(Me.cuantos)
        Me.Controls.Add(Me.LbProm)
        Me.Controls.Add(Me.label5)
        Me.Controls.Add(Me.button1)
        Me.Controls.Add(Me.TxbC)
        Me.Controls.Add(Me.TxbB)
        Me.Controls.Add(Me.TxbA)
        Me.Controls.Add(Me.label4)
        Me.Controls.Add(Me.label3)
        Me.Controls.Add(Me.label2)
        Me.Name = "IngresarDatos"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private WithEvents btnDesplegar As Button
    Private WithEvents lblPromGen As Label
    Private WithEvents lblMensaje As Label
    Private WithEvents txtCuantos As TextBox
    Private WithEvents cuantos As Label
    Private WithEvents LbProm As Label
    Private WithEvents label5 As Label
    Private WithEvents button1 As Button
    Private WithEvents TxbC As TextBox
    Private WithEvents TxbB As TextBox
    Private WithEvents TxbA As TextBox
    Private WithEvents label4 As Label
    Private WithEvents label3 As Label
    Private WithEvents label2 As Label
End Class
