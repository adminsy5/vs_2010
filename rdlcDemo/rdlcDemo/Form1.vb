Imports System.Data.SqlClient
Imports Microsoft.Reporting.WinForms

Public Class Form1

    Private Sub Form1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub ButtonCheck_Click(sender As System.Object, e As System.EventArgs) Handles ButtonCheck.Click
        Dim str As String = "Data Source=.\SQLEXPRESS;AttachDbFilename='C:\Users\mpiyu\AppData\Local\Temporary Projects\rdlcDemo\DemoRDLC.mdf';Integrated Security=True;User Instance=True"
        Dim con As SqlConnection = New SqlConnection(str)
        Dim dt As DataTable = New DataTable
        Dim ad As SqlDataAdapter
        ad = New SqlDataAdapter("select * from demo", con)
        ad.Fill(dt)

        With Me.ReportViewer1.LocalReport
            .DataSources.Clear()
            .ReportPath = "C:\Users\mpiyu\AppData\Local\Temporary Projects\rdlcDemo\Report1.rdlc"
            .DataSources.Add(New ReportDataSource("DataSet1", dt))
        End With
        Me.ReportViewer1.RefreshReport()
    End Sub
End Class
