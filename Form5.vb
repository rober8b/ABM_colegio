Imports System
Imports System.Data
Imports System.Data.OleDb
Public Class Form5
    Dim con As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\rober\Desktop\tablas-colegio.accdb")


    Private Sub Form5_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the '_tablas_colegioDataSet4.Alumnos' table. You can move, or remove it, as needed.
        Me.AlumnosTableAdapter2.Fill(Me._tablas_colegioDataSet4.Alumnos)
        'TODO: This line of code loads data into the '_tablas_colegioDataSet3.Alumnos' table. You can move, or remove it, as needed.
        Me.AlumnosTableAdapter1.Fill(Me._tablas_colegioDataSet3.Alumnos)
        'TODO: This line of code loads data into the '_tablas_colegioDataSet2.Alumnos' table. You can move, or remove it, as needed.
        Me.AlumnosTableAdapter.Fill(Me._tablas_colegioDataSet2.Alumnos)

    End Sub

    Private Sub BtnMP_Click(sender As Object, e As EventArgs)
        MejorProm.Show()
        Me.Close()

    End Sub

    Private Sub btnactu_Click(sender As Object, e As EventArgs) Handles btnactu.Click
        Dim sqll As String
        sqll = "Select * From alumnos"
        Dim adaptador As New OleDb.OleDbDataAdapter(sqll, con)
        Dim obtenerdatos As New DataSet
        adaptador.Fill(obtenerdatos, "N_legajo")
        DataGridView1.DataSource = obtenerdatos
        DataGridView1.DataMember = "N_legajo"

    End Sub

    Private Sub BtnVolver_Click_1(sender As Object, e As EventArgs) Handles BtnVolver.Click
        Form1.Show()
        Me.Close()
    End Sub
End Class