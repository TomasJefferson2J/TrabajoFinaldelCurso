<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Txtid = New System.Windows.Forms.TextBox()
        Me.Txtnombres = New System.Windows.Forms.TextBox()
        Me.Txtapellidos = New System.Windows.Forms.TextBox()
        Me.Txtnacimiento = New System.Windows.Forms.TextBox()
        Me.Txtcelular = New System.Windows.Forms.TextBox()
        Me.BtnNuevo = New System.Windows.Forms.Button()
        Me.BtnIngresar = New System.Windows.Forms.Button()
        Me.BtnModificar = New System.Windows.Forms.Button()
        Me.BtnEliminar = New System.Windows.Forms.Button()
        Me.Dgvestudiantes = New System.Windows.Forms.DataGridView()
        CType(Me.Dgvestudiantes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(67, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(17, 15)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "id"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(67, 73)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(54, 15)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "nombres"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(67, 116)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(54, 15)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "apellidos"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(67, 168)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(115, 15)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "fecha de nacimiento"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(67, 215)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(42, 15)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "celular"
        '
        'Txtid
        '
        Me.Txtid.Location = New System.Drawing.Point(198, 25)
        Me.Txtid.Name = "Txtid"
        Me.Txtid.Size = New System.Drawing.Size(100, 23)
        Me.Txtid.TabIndex = 5
        '
        'Txtnombres
        '
        Me.Txtnombres.Location = New System.Drawing.Point(198, 73)
        Me.Txtnombres.Name = "Txtnombres"
        Me.Txtnombres.Size = New System.Drawing.Size(228, 23)
        Me.Txtnombres.TabIndex = 6
        '
        'Txtapellidos
        '
        Me.Txtapellidos.Location = New System.Drawing.Point(198, 116)
        Me.Txtapellidos.Name = "Txtapellidos"
        Me.Txtapellidos.Size = New System.Drawing.Size(228, 23)
        Me.Txtapellidos.TabIndex = 7
        '
        'Txtnacimiento
        '
        Me.Txtnacimiento.Location = New System.Drawing.Point(198, 168)
        Me.Txtnacimiento.Name = "Txtnacimiento"
        Me.Txtnacimiento.Size = New System.Drawing.Size(165, 23)
        Me.Txtnacimiento.TabIndex = 8
        '
        'Txtcelular
        '
        Me.Txtcelular.Location = New System.Drawing.Point(198, 212)
        Me.Txtcelular.Name = "Txtcelular"
        Me.Txtcelular.Size = New System.Drawing.Size(100, 23)
        Me.Txtcelular.TabIndex = 9
        '
        'BtnNuevo
        '
        Me.BtnNuevo.Location = New System.Drawing.Point(597, 39)
        Me.BtnNuevo.Name = "BtnNuevo"
        Me.BtnNuevo.Size = New System.Drawing.Size(75, 23)
        Me.BtnNuevo.TabIndex = 10
        Me.BtnNuevo.Text = "Nuevo"
        Me.BtnNuevo.UseVisualStyleBackColor = True
        '
        'BtnIngresar
        '
        Me.BtnIngresar.Location = New System.Drawing.Point(597, 91)
        Me.BtnIngresar.Name = "BtnIngresar"
        Me.BtnIngresar.Size = New System.Drawing.Size(75, 23)
        Me.BtnIngresar.TabIndex = 11
        Me.BtnIngresar.Text = "Ingresar"
        Me.BtnIngresar.UseVisualStyleBackColor = True
        '
        'BtnModificar
        '
        Me.BtnModificar.Location = New System.Drawing.Point(597, 151)
        Me.BtnModificar.Name = "BtnModificar"
        Me.BtnModificar.Size = New System.Drawing.Size(75, 23)
        Me.BtnModificar.TabIndex = 12
        Me.BtnModificar.Text = "Modificar"
        Me.BtnModificar.UseVisualStyleBackColor = True
        '
        'BtnEliminar
        '
        Me.BtnEliminar.Location = New System.Drawing.Point(597, 207)
        Me.BtnEliminar.Name = "BtnEliminar"
        Me.BtnEliminar.Size = New System.Drawing.Size(75, 23)
        Me.BtnEliminar.TabIndex = 13
        Me.BtnEliminar.Text = "Eliminar"
        Me.BtnEliminar.UseVisualStyleBackColor = True
        '
        'Dgvestudiantes
        '
        Me.Dgvestudiantes.AllowUserToAddRows = False
        Me.Dgvestudiantes.AllowUserToDeleteRows = False
        Me.Dgvestudiantes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Dgvestudiantes.Location = New System.Drawing.Point(12, 282)
        Me.Dgvestudiantes.Name = "Dgvestudiantes"
        Me.Dgvestudiantes.ReadOnly = True
        Me.Dgvestudiantes.RowTemplate.Height = 25
        Me.Dgvestudiantes.Size = New System.Drawing.Size(810, 207)
        Me.Dgvestudiantes.TabIndex = 14
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(845, 501)
        Me.Controls.Add(Me.Dgvestudiantes)
        Me.Controls.Add(Me.BtnEliminar)
        Me.Controls.Add(Me.BtnModificar)
        Me.Controls.Add(Me.BtnIngresar)
        Me.Controls.Add(Me.BtnNuevo)
        Me.Controls.Add(Me.Txtcelular)
        Me.Controls.Add(Me.Txtnacimiento)
        Me.Controls.Add(Me.Txtapellidos)
        Me.Controls.Add(Me.Txtnombres)
        Me.Controls.Add(Me.Txtid)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.Dgvestudiantes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Txtid As TextBox
    Friend WithEvents Txtnombres As TextBox
    Friend WithEvents Txtapellidos As TextBox
    Friend WithEvents Txtnacimiento As TextBox
    Friend WithEvents Txtcelular As TextBox
    Friend WithEvents BtnNuevo As Button
    Friend WithEvents BtnIngresar As Button
    Friend WithEvents BtnModificar As Button
    Friend WithEvents BtnEliminar As Button
    Friend WithEvents Dgvestudiantes As DataGridView
End Class
