Imports System.Data.SqlClient
Imports Microsoft.Reporting.WinForms

Public Class Form1
    Dim con As SqlConnection
    Dim cmd As SqlCommand
    Dim ad As SqlDataAdapter
    Dim dt As DataSet

    Private Sub connection()
        con = New SqlConnection("Data Source=.\SQLEXPRESS;AttachDbFilename=B:\404-Vb.Net\vs_2010\RdlcEnrollment\RdlcEnrollment\Enrollment.mdf;Integrated Security=True;User Instance=True")
        Try
            con.Open()
            If con.State = ConnectionState.Open Then
                'MsgBox("Connected !")
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub createTable()
        cmd = New SqlCommand("create table Enrollment(eno int primary key,name varchar(20),date1 date,course varchar(10),duration int,amt_paid int,balance int)", connection:=con)
        Try
            cmd.ExecuteNonQuery()
            MsgBox("Created Table !")
        Catch ec As Exception
            'MsgBox(ec.Message)
        End Try
    End Sub

    Private Sub insertData()

        cmd = New SqlCommand("insert into Enrollment values(@eno,@ename,@date1,@course,@duration,@amt_paid,@balance)", connection:=con)
        cmd.Parameters.AddWithValue("@eno", Convert.ToInt32(TextBoxEno.Text))
        cmd.Parameters.AddWithValue("@ename", TextBoxName.Text)
        cmd.Parameters.AddWithValue("@date1", DateTimePickerText.Value.ToShortDateString)
        cmd.Parameters.AddWithValue("@course", TextBoxCourse.Text)
        cmd.Parameters.AddWithValue("@duration", Convert.ToInt32(TextBoxDuration.Text))
        cmd.Parameters.AddWithValue("@amt_paid", Convert.ToInt32(TextBoxAmtPaid.Text))
        cmd.Parameters.AddWithValue("@balance", Convert.ToInt32(TextBoxBalance.Text))

        Try
            cmd.ExecuteNonQuery()
            MsgBox("Inserted !")
        Catch ec As Exception
            MsgBox(ec.Message)
        End Try
    End Sub

    Private Sub ShowData()
        ad = New SqlDataAdapter("select  * from Enrollment", selectConnection:=con)
        dt = New DataSet
        Try
            ad.Fill(dt, "Enrollment")
            DataGridViewReader.DataSource = dt.Tables(0).DefaultView
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub updateTable()
        cmd = New SqlCommand("update Enrollment set amt_paid=@amt_paid where name LIKE '" & TextBoxFind.Text & "'", connection:=con)
        cmd.Parameters.AddWithValue("@amt_paid", Convert.ToInt32(TextBoxAmtPaid.Text))
        Try
            cmd.ExecuteNonQuery()
            MsgBox("Amount updated !")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub deletedTable()
        If DataGridViewReader.RowCount = 0 Then
            MsgBox("Unable to deletd")
        End If

        If MsgBox("Deleted The record ?", MsgBoxStyle.Question + MsgBoxStyle.OkCancel, "Confirmation") = MsgBoxResult.Cancel Then Return

        Try
            If DataGridViewReader.AreAllCellsSelected(0) = True Then
                cmd = New SqlCommand("delete from enrollment", connection:=con)
                cmd.ExecuteNonQuery()
                MsgBox("Deleted All !")
            End If
        Catch ec As Exception
            MsgBox(ec.Message)
        End Try

        Try
            For Each row As DataGridViewRow In DataGridViewReader.SelectedRows
                If row.Selected Then
                    cmd = New SqlCommand("delete from Enrollment where eno = '" & row.DataBoundItem(0).ToString & "'", connection:=con)
                    cmd.ExecuteNonQuery()
                    MsgBox("Deleted !")
                End If
            Next
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub checkFieldisEmpty()
        If TextBoxEno.Text = "" And TextBoxName.Text = "" And TextBoxAmtPaid.Text = "" And TextBoxBalance.Text = "" And TextBoxCourse.Text = "" And TextBoxDuration.Text = "" Then
            MsgBox("Fields empty !")
            Return
        End If

        If TextBoxEno.Text = "" Then
            MsgBox("Please Enter eno !")
            Return
        End If

        If TextBoxName.Text = "" Then
            MsgBox("Please Enter name !")
            Return
        End If

        If TextBoxAmtPaid.Text = "" Then
            MsgBox("Paid Amount must be >= 0 ")
            Return
        End If

        If TextBoxBalance.Text = "" Then
            MsgBox("Enter Your Balance !")
            Return
        End If

        If TextBoxCourse.Text = "" Then
            MsgBox("Enter your Course !")
            Return
        End If

        If TextBoxDuration.Text = "" Then
            MsgBox("Enter the duration of course ")
            Return
        End If
    End Sub

    Private Sub DeleteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DeleteToolStripMenuItem.Click
        connection()
        deletedTable()
        ButtonRefresh_Click_1(sender, e)
    End Sub

    Private Sub ButtonSave_Click_1(sender As System.Object, e As System.EventArgs) Handles ButtonSave.Click
        checkFieldisEmpty()
        connection()
        createTable()
        insertData()
        ButtonClear_Click_1(sender, e)
        ShowData()
    End Sub

    Private Sub ButtonUpdate_Click_1(sender As System.Object, e As System.EventArgs) Handles ButtonUpdate.Click
        If TextBoxAmtPaid.Text = "" Then
            MsgBox("Paid Amount must be >= 0 ")
            Return
        End If

        connection()
        updateTable()
        ButtonClear_Click_1(sender, e)
        ButtonRefresh_Click_1(sender, e)
    End Sub

    Private Sub ButtonFind_Click_1(sender As System.Object, e As System.EventArgs) Handles ButtonFind.Click
        connection()
        ad = New SqlDataAdapter("select  * from Enrollment where name LIKE '" & TextBoxFind.Text & "'", selectConnection:=con)
        dt = New DataSet
        ad.Fill(dt, "Enrollment")
        Try
            DataGridViewReader.DataSource = dt.Tables(0).DefaultView
            ButtonClear_Click_1(sender, e)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub ButtonDelete_Click_1(sender As System.Object, e As System.EventArgs) Handles ButtonDelete.Click
        connection()
        deletedTable()
        ButtonClear_Click_1(sender, e)
        ButtonRefresh_Click_1(sender, e)
    End Sub

    Private Sub ButtonRefresh_Click_1(sender As System.Object, e As System.EventArgs) Handles ButtonRefresh.Click
        connection()
        ShowData()
        ButtonClear_Click_1(sender, e)
    End Sub

    Private Sub ButtonClear_Click_1(sender As System.Object, e As System.EventArgs) Handles ButtonClear.Click
        TextBoxEno.Clear()
        TextBoxName.Clear()
        TextBoxAmtPaid.Clear()
        TextBoxBalance.Clear()
        TextBoxCourse.Clear()
        TextBoxDuration.Clear()
        TextBoxFind.Clear()
        DateTimePickerText.ResetText()
    End Sub

    Private Sub CheckBoxUnpaid_CheckedChanged_1(sender As System.Object, e As System.EventArgs) Handles CheckBoxUnpaid.CheckedChanged
        connection()
        ad = New SqlDataAdapter("select * from enrollment", selectConnection:=con)
        dt = New DataSet
        Try
            ad.Fill(dt, "Enrollment")
            DataGridViewReader.DataSource = dt.Tables(0).DefaultView
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub ButtonRp_Click(sender As System.Object, e As System.EventArgs) Handles ButtonRp.Click
        connection()
        Dim str As String = "SELECT * FROM Enrollment WHERE (amt_paid = 0) AND (date1 BETWEEN CAST(DATEADD(s, - 1, DATEADD(mm, DATEDIFF(m, 0, GETDATE()) + 1, 0)) AS date) AND CAST(DATEADD(s, - 1, DATEADD(mm, DATEDIFF(m, 0, GETDATE()) + 2, 0)) AS date))"
        Dim ad As SqlDataAdapter = New SqlDataAdapter(str, selectConnection:=con)
        Dim dt As DataTable = New DataTable
        ad.Fill(dt)

        With Me.ReportViewer1.LocalReport
            .DataSources.Clear()
            .ReportPath = "B:\404-Vb.Net\vs_2010\RdlcEnrollment\RdlcEnrollment\Report1.rdlc"
            .DataSources.Add(New ReportDataSource("DataSet1", dt))
        End With
        Me.ReportViewer1.RefreshReport()
    End Sub
End Class
