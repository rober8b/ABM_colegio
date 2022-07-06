Imports System
Imports System.Data
Imports System.Data.OleDb
Public Class Form2
    Dim con As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\rober\Desktop\tablas-colegio.accdb")
    Dim contar As Integer
    Dim N_legajom As Integer
    Dim Divisionm As Integer
    Dim Materiam As String
    Dim P_cuatrimestrem As Integer
    Dim S_cuatrimestrem As Integer
    Dim T_cuatrimestrem As Integer
    Dim Promf As Integer
    Dim Estadom As String


    Private Sub Btnlect_Click(sender As Object, e As EventArgs) Handles Btnlect.Click
        Call Limpiar()
        Dim con As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\rober\Desktop\tablas-colegio.accdb")
        con.Open()


        Dim leo = "select * FROM alumnos where N_legajo >0"
        Dim adaptador = New OleDb.OleDbDataAdapter(leo, con)
        Dim registro = New DataSet
        adaptador.Fill(registro, "alumnos")
        Dim lista = registro.Tables("alumnos").Rows.Count

        contar = 0

        Do While contar < lista

            N_legajom = registro.Tables("alumnos").Rows(contar).Item("N_legajo")
            Divisionm = registro.Tables("alumnos").Rows(contar).Item("Division")
            Materiam = registro.Tables("alumnos").Rows(contar).Item("Materia")
            P_cuatrimestrem = registro.Tables("alumnos").Rows(contar).Item("P_cuatrimestre")
            S_cuatrimestrem = registro.Tables("alumnos").Rows(contar).Item("S_cuatrimestre")
            T_cuatrimestrem = registro.Tables("alumnos").Rows(contar).Item("T_cuatrimestre")
            Promf = registro.Tables("alumnos").Rows(contar).Item("Promedio")
            Estadom = registro.Tables("alumnos").Rows(contar).Item("Condicion")

            If Promf >= 7 Then 'aprobados

                Call grabaaux()

            End If

            contar = contar + 1
        Loop

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

    Private Sub grabaaux()
        Dim conexion1 As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\rober\Desktop\tablas-colegio.accdb")
        conexion1.Open()
        Dim consulta As String = "insert into alumnosaux(N_legajo, Division, Materia, P_cuatrimestre, S_cuatrimestre, T_cuatrimestre, Promedio, Condicion)" & "values('" & N_legajom & "','" & Divisionm & "','" & Materiam & "','" & P_cuatrimestrem & "','" & S_cuatrimestrem & "','" & T_cuatrimestrem & "','" & Promf & "','" & Estadom & "')"
        Dim COMANDO As New OleDbCommand(consulta, conexion1)
        Dim DR As OleDbDataReader = COMANDO.ExecuteReader
        conexion1.Close()

    End Sub

    Private Sub Limpiar()
        con.Open()
        Dim borra As String = "DELETE*From alumnosaux"
        Dim COMANDOb As New OleDbCommand(borra, con)
        Dim DRb As OleDbDataReader = COMANDOb.ExecuteReader
        MsgBox("Proceso completado", vbInformation, "Listo")
        con.Close()
    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the '_tablas_colegioDataSet5.alumnosaux' table. You can move, or remove it, as needed.
        Me.AlumnosauxTableAdapter.Fill(Me._tablas_colegioDataSet5.alumnosaux)

    End Sub

    Private Sub BtnVolver_Click_1(sender As Object, e As EventArgs) Handles BtnVolver.Click
        Form1.Show()
        Me.Hide()
    End Sub



End Class