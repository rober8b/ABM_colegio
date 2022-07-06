Imports System
Imports System.Data
Imports System.Data.OleDb

Public Class Form1
    Dim con As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\rober\Desktop\tablas-colegio.accdb")
    Dim adaptador As New OleDbDataAdapter
    Dim registros As New DataSet
    Dim cmd As New OleDbCommand
    Dim consulta As String


    Private Sub Form1_Load_1(sender As Object, e As EventArgs) Handles MyBase.Load
        'se verfica la conexiones
        Try
            con.Open()
            MsgBox("Conexion exitosa", vbInformation, "Conexion segura")
        Catch ex As Exception
            MsgBox("Error al conectar la base de datos", vbCritical, "Sin conexion")
        End Try
    End Sub

    Private Sub Limpiar()
        NLtext.Clear()
        Divtext.Clear()
        PCtext.Clear()
        SCtext.Clear()
        TCtext.Clear()
        Promtext.Clear()
        Estadotext.Clear()


        NLtext.Focus()
    End Sub
    Private Sub BtnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnGuardar.Click

        'funcion para que no se guarden archivos vacios
        If NLtext.Text = "" Or Divtext.Text = "" Or Matext.Text = "" Or PCtext.Text = "" Or SCtext.Text = "" Or TCtext.Text = "" Or Promtext.Text = "" Then
            MsgBox("No se pueden guardar registros vacios", vbCritical, "Completar registros")
        Else
            'se insertan los datos mediante comando a la tabla en access
            ' Try
            con.Open()

            cmd = New OleDbCommand("insert into alumnos(N_legajo, Division, Materia, P_cuatrimestre, S_cuatrimestre, T_cuatrimestre, Promedio, Condicion)" & "values('" & NLtext.Text & "','" & Divtext.Text & "','" & Matext.Text & "','" & PCtext.Text & "','" & SCtext.Text & "','" & TCtext.Text & "','" & Promtext.Text & "','" & Estadotext.Text & "')", con)
                cmd.Parameters.AddWithValue("N_legajo", NLtext.Text)
                cmd.Parameters.AddWithValue("Division", Divtext.Text)
                cmd.Parameters.AddWithValue("Materia", Matext.Text)
                cmd.Parameters.AddWithValue("P_cuatrimestre", PCtext.Text)
                cmd.Parameters.AddWithValue("S_cuatrimestre", SCtext.Text)
                cmd.Parameters.AddWithValue("T_cuatrimestre", TCtext.Text)
                cmd.Parameters.AddWithValue("Promedio", Promtext.Text)
                cmd.Parameters.AddWithValue("Condicion", Estadotext.Text)

                cmd.ExecuteNonQuery()
                MsgBox("El registro a sido guardado correctamete", vbInformation, "registro guardado")

            'Catch ex As Exception

            'Box("El registro no se guardado", vbCritical, "registro NO guardado")

            ' End Try

            con.Close()

        End If


        'limpiar campos de texto
        Call Limpiar()

    End Sub

    Private Sub BtnEliminar_Click(sender As Object, e As EventArgs) Handles BtnEliminar.Click
        Dim eliminar As String
        Dim si As Byte

        si = MsgBox("¿Esta seguro que desea eliminar el registro?", vbYesNo, "Confirmar")
        If si = vbYes Then
            con.Open()
            eliminar = "DELETE FROM alumnos where N_legajo = " & NLtext.Text
            cmd = New OleDbCommand(eliminar, con)
            cmd.ExecuteNonQuery()
            MsgBox("Resgistro eliminado correctamente", vbInformation, "Aviso")
            con.Close()

        Else
            MsgBox("No se pudo elminiar el registo", vbCritical, "Aviso")

        End If
        Call Limpiar()

    End Sub


    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles BtnAprobados.Click

        Form2.Show()
        Me.Hide()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles BtnDesaprobados.Click

        Form3.Show()
        Me.Hide()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles BtnAplazados.Click

        Form4.Show()
        Me.Hide()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles BtnPromedios.Click

        Form5.Show()
        Me.Hide()


    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles CalcProm.Click
        'calculo de los promedios
        Dim PC, SC, TC, promf As Double
        Dim condic As String
        If PCtext.Text = "" Or SCtext.Text = "" Or TCtext.Text = "" Then
            MsgBox("No se puede promediar", vbCritical, "Completar registros")
        End If

        PC = PCtext.Text
        SC = SCtext.Text
        TC = TCtext.Text

        promf = (PC + SC + TC) / 3

        Promtext.Text = promf

        If promf > 6 Then
            condic = "Aprobado"
        ElseIf promf <= 6 And promf >= 4 Then
            condic = "Desaprobado"
        Else
            condic = "Aplazado"
        End If

        Estadotext.Text = condic

    End Sub

    Private Sub BtnModif_Click(sender As Object, e As EventArgs) Handles BtnModif.Click
        Dim codigocontro2
        Dim Si As Byte
        Si = MsgBox("estas seguro que quieres Actualizarlo?", vbYesNo, "Editar registro")
        If Si = vbYes Then
            con.Open()
            codigocontro2 = Val(NLtext.Text)
            Dim consulta1 As String
            Dim lista1 As New Byte
            Dim adaptador1 As New OleDbDataAdapter
            Dim registro1 As New DataSet
            consulta1 = "SELECT * FROM alumnos WHERE N_legajo = " & codigocontro2 & ""
            adaptador1 = New OleDbDataAdapter(consulta1, con)
            registro1 = New DataSet
            adaptador1.Fill(registro1, "alumnos")
            lista1 = registro1.Tables("alumnos").Rows.Count
            consulta1 = "UPDATE alumnos SET N_legajo = '" & NLtext.Text & "', Division = '" & Divtext.Text & "', Materia =  '" & Matext.Text & "', P_cuatrimestre='" & PCtext.Text & "', S_cuatrimestre ='" & SCtext.Text & "', T_cuatrimestre= '" & TCtext.Text & "', Promedio= '" & Promtext.Text & "' WHERE N_legajo = " & codigocontro2 & ""
            Dim comando As New OleDbCommand(consulta1, con)
            Dim dr As OleDbDataReader = comando.ExecuteReader
            con.Close()
            MsgBox("datos modificados")
            Call Limpiar()
        End If
    End Sub

    Function conseguirlistas()

        Dim leo = "select * FROM alumnos where N_legajo >0"
        Dim adaptador = New OleDb.OleDbDataAdapter(leo, con)
        Dim registros = New DataSet
        adaptador.Fill(registros, "alumnos")
        Dim lista = registros.Tables("alumnos").Rows.Count
        con.Close()
        Return lista
    End Function

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles BtnNuevo.Click
        Dim lista = conseguirlistas()
        Call Limpiar()
        NLtext.Text = (lista + 1)

    End Sub

    Private Sub BuscarLegajo()
        Dim consulta As String
        Dim lista As String
        If IsNumeric(NLtext.Text) Then

            consulta = "SELECT * FROM alumnos WHERE N_legajo = " & NLtext.Text
            adaptador = New OleDbDataAdapter(consulta, con)
            registros = New DataSet
            adaptador.Fill(registros, "alumnos")
            lista = registros.Tables("alumnos").Rows.Count
            If lista <> 0 Then
                NLtext.Text = registros.Tables("alumnos").Rows(0).Item("N_legajo")
                Divtext.Text = registros.Tables("alumnos").Rows(0).Item("Division")
                Matext.Text = registros.Tables("alumnos").Rows(0).Item("Materia")

                PCtext.Text = registros.Tables("alumnos").Rows(0).Item("P_cuatrimestre")
                SCtext.Text = registros.Tables("alumnos").Rows(0).Item("S_cuatrimestre")
                TCtext.Text = registros.Tables("alumnos").Rows(0).Item("T_cuatrimestre")

                Promtext.Text = registros.Tables("alumnos").Rows(0).Item("Promedio")
                Estadotext.Text = registros.Tables("alumnos").Rows(0).Item("Condicion")
                con.Close()
            Else
                Call Limpiar()
            End If

        End If
    End Sub

    Private Sub IconButton1_Click(sender As Object, e As EventArgs) Handles IconButton1.Click
        Call BuscarLegajo()
    End Sub

End Class


