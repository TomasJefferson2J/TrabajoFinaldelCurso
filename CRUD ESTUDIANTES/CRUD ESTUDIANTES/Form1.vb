Imports System.Diagnostics.Eventing.Reader
Imports System.Windows.Markup
Imports MySql.Data.MySqlClient
Public Class Form1
#Region "Variables"
    Private cmb As MySqlCommandBuilder
    Dim conexion1 As New MySqlConnection
    Dim datos As New DataSet
    Dim adaptador As New MySqlDataAdapter
    Dim lista As Byte

#End Region

#Region "Base de datos"
    Public Sub Conectar()
        Try
            conexion1.ConnectionString = "server=localhost;user=root;password=12345;database=estudiantes"
            conexion1.Open()
            Dim consulta As String
            consulta = "SELECT * FROM alumno"
            adaptador = New MySqlDataAdapter(consulta, conexion1)
            datos = New DataSet
            adaptador.Fill(datos, "alumno")
            Dgvestudiantes.DataSource = datos
            Dgvestudiantes.DataMember = "alumno"
            MsgBox("conectado correctamente")
        Catch ex As Exception
            MsgBox("no conectado" + ex.ToString)
            Me.Close()
        End Try
    End Sub

#End Region

#Region "Load"

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Conectar()
    End Sub

#End Region

#Region "Agregar dato"
    Private Sub BtnIngresar_Click(sender As Object, e As EventArgs) Handles BtnIngresar.Click
        If (Txtid.Text = "") Or (Txtnombres.Text = "") Or (Txtapellidos.Text = "") Or (Txtnacimiento.Text = "") Or (Txtcelular.Text = "") Then
            MsgBox("error campos vacios", MsgBoxStyle.Information, "confirmar")
        Else
            Try
                Dim consulta5 As String = "Select + FROM alumno WHERE ID='" & Txtid.Text & "'"
                Dim ADAPTADORC As New MySqlDataAdapter(consulta5, conexion1)
                Dim datos As New DataSet
                ADAPTADORC.Fill(datos, "alumno")
                lista = datos.Tables("alumno").Rows.Count

                If lista <> 0 Then
                    MsgBox("ya existe esa persona en la base de datos", MsgBoxStyle.Information, "confirmar")
                    BorrarCampos()
                    MostrarDatos()
                Else
                    Dim ENTRADA As String = "INSERT INTO alumno (ID, nombres, apellidos, fecha_de_nacimiento, celular)
                    VALUES ('" + Txtid.Text + "','" + Txtnombres.Text + "','" + Txtapellidos.Text + "','" + Txtnacimiento.Text + "','" + Txtcelular.Text + "')"

                    Dim DT As New DataTable
                    Dim ADAPTADOR As New MySqlDataAdapter(ENTRADA, conexion1)

                    ADAPTADOR.Fill(DT)
                    conexion1.Close()
                    MsgBox("Insertado correctamente", MsgBoxStyle.Information, "confirmar")
                    BorrarCampos()
                    MostrarDatos()
                End If
            Catch ex As Exception
                MsgBox("Error critico, no se inserto el dato", MsgBoxStyle.Critical, "Error" + ex.Message)
            Finally
                conexion1.Dispose()
            End Try
        End If
    End Sub

#End Region


#Region "Modificar dato"
    Private Sub BtnModificar_Click(sender As Object, e As EventArgs) Handles BtnModificar.Click
        If conexion1.State = ConnectionState.Closed Then
            conexion1.Open()
        End If
        If (Txtid.Text = "") Or (Txtnombres.Text = "") Or (Txtapellidos.Text = "") Or (Txtnacimiento.Text = "") Or (Txtcelular.Text = "") Then
            MsgBox("No se puede modificar porque no se ha seleaccionado nada", MsgBoxStyle.Information, "confirmar")

        Else
            Dim comando As New MySqlCommand("UPDATE alumno Set  ',nombres='" & Txtnombres.Text & "',apellidos='" & Txtapellidos.Text & "',fecha_de_nacimiento='" & Txtnacimiento.Text & "',celular='" & Txtcelular.Text & "' WHERE ID='" & Conversion.Int(Txtid.Text) & "", conexion1)

            comando.ExecuteNonQuery()
            MsgBox("datos actualizados", MsgBoxStyle.Information, "confirmar")
            BorrarCampos()
            MostrarDatos()
            BtnIngresar.Enabled = True


            If conexion1.State = ConnectionState.Open Then
                conexion1.Close()
            End If
        End If
    End Sub

#End Region


#Region "Eliminar datos"
    Private Sub BtnEliminar_Click(sender As Object, e As EventArgs) Handles BtnEliminar.Click
        If conexion1.State = ConnectionState.Closed Then
            conexion1.Open()
        End If

        If (Txtid.Text = "") Or (Txtnombres.Text = "") Or (Txtapellidos.Text = "") Or (Txtnacimiento.Text = "") Or (Txtcelular.Text = "") Then

            MsgBox("No se puede eliminar porque no se ha seleccionado nada", MsgBoxStyle.Information, "confirmar")


        Else
            Dim comando As New MySqlCommand("DELETE FROM alumno WHERE ID=" & Conversion.Int(Txtid.Text) & "", conexion1)
            comando.ExecuteNonQuery()
            MsgBox("datos eliminados correctamente", MsgBoxStyle.Information, "confirmar")
            BorrarCampos()
            MostrarDatos()

            BtnIngresar.Enabled = True

            If conexion1.State = ConnectionState.Open Then
                conexion1.Close()
            End If
        End If
    End Sub

#End Region


#Region "Borrar Campos"
    Public Sub BorrarCampos()
        Txtid.Text = ""
        Txtnombres.Text = ""
        Txtapellidos.Text = ""
        Txtnacimiento.Text = ""
        Txtcelular.Text = ""
    End Sub
#End Region

#Region "Mostrar Datos"
    Public Sub consulta(ByVal sql As String, ByVal tabla As String)
        datos.Tables.Clear()
        adaptador = New MySqlDataAdapter(sql, conexion1)
        cmb = New MySqlCommandBuilder(adaptador)
        adaptador.Fill(datos, tabla)

    End Sub

    Public Sub MostrarDatos()
        consulta("SELECT * FROM alumno", "alumno")
        Dgvestudiantes.DataSource = datos.Tables("alumno")
    End Sub



#End Region

#Region "Datos hacia los txt"
    Private Sub Dgvestudiantes_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles Dgvestudiantes.CellClick
        Dim i As Integer = Dgvestudiantes.CurrentRow.Index

        Txtid.Text = Dgvestudiantes(0, 1).Value
        Txtnombres.Text = Dgvestudiantes(2, 1).Value
        Txtapellidos.Text = Dgvestudiantes(3, 1).Value
        Txtnacimiento.Text = Dgvestudiantes(4, 1).Value
        Txtcelular.Text = Dgvestudiantes(5, 1).Value
        BtnIngresar.Enabled = False

    End Sub



#End Region


#Region "Boton Nuevo"
    Private Sub BtnNuevo_Click(sender As Object, e As EventArgs) Handles BtnNuevo.Click
        BorrarCampos()
        BtnIngresar.Enabled = True
    End Sub


#End Region

End Class