Imports System.Data.SqlClient
Public Class Form1
    Dim con As SqlConnection
    Dim cmd As SqlCommand
    Dim ad As SqlDataAdapter
    Dim dt As DataSet

    Private Sub Connection()
        con = New SqlConnection("Data Source=.\SQLEXPRESS;AttachDbFilename=B:\404-Vb.Net\vs_2010\LicOfIndia\LicOfIndia\LicOfIndia.mdf;Integrated Security=True;User Instance=True")
        Try
            con.Open()
            If con.State = ConnectionState.Open Then
                'MsgBox("Connected")
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub createTable()
        cmd = New SqlCommand("create table tblPolicyDetails(polyno int primary key,holdername varchar(20),polytype varchar(20),premAmt int,nofyear int)", Connection:=con)
        Try
            cmd.ExecuteNonQuery()
        Catch ec As Exception
            'MsgBox(ec.Message)
        End Try
    End Sub

    Private Sub InsertData()
        Dim polnum As Integer = Convert.ToInt32(TextBoxPolicyNumber.Text)
        Dim polname As String = TextBoxPolicyHolderName.Text
        Dim poltype As String = ComboBoxPolicyType.Text
        Dim polamt As String = Convert.ToInt32(TextBoxPremiumofAmt.Text)
        Dim polyear As String = Convert.ToInt32(TextBoxNoOfYear.Text)

        cmd = New SqlCommand("Insert into tblPolicyDetails values(@polnum,@polname,@poltype,@polamt,@polyear)", Connection:=con)
        cmd.Parameters.AddWithValue("@polnum", polnum)
        cmd.Parameters.AddWithValue("@polname", polname)
        cmd.Parameters.AddWithValue("@poltype", poltype)
        cmd.Parameters.AddWithValue("@polamt", polamt)
        cmd.Parameters.AddWithValue("@polyear", polyear)
        Try
            cmd.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub showData()
        ad = New SqlDataAdapter("select * from  tblPolicyDetails", selectConnection:=con)
        dt = New DataSet
        ad.Fill(dt, "tblPolicyDetails")
        DataGridViewReader.DataSource = dt.Tables(0).DefaultView
    End Sub

    Private Sub ButtonSave_Click(sender As System.Object, e As System.EventArgs) Handles ButtonSave.Click
        Connection()
        createTable()
        InsertData()
        showData()
    End Sub

    Private Sub ButtonRefresh_Click(sender As System.Object, e As System.EventArgs) Handles ButtonRefresh.Click
        Connection()
        ad = New SqlDataAdapter("select * from  tblPolicyDetails", selectConnection:=con)
        dt = New DataSet
        ad.Fill(dt, "tblPolicyDetails")
        DataGridViewReader.DataSource = dt.Tables(0).DefaultView
    End Sub

    Private Sub ButtonClear_Click(sender As System.Object, e As System.EventArgs) Handles ButtonClear.Click
        TextBoxNoOfYear.Clear()
        TextBoxPolicyHolderName.Clear()
        TextBoxPolicyNumber.Clear()
        TextBoxPremiumofAmt.Clear()
        TextBoxSearch.Clear()
        ComboBoxPolicyType.SelectedItem = "- Choose Item -"
    End Sub

    Private Sub ButtonDelete_Click(sender As System.Object, e As System.EventArgs) Handles ButtonDelete.Click
        Connection()

        If DataGridViewReader.RowCount = 0 Then
            MsgBox("Unable to deleted, No data found")
        End If

        If MsgBox("Delete record ?", MsgBoxStyle.Question + MsgBoxStyle.OkCancel, "Confirmation") = MsgBoxResult.Cancel Then Return

        Try
            If DataGridViewReader.AreAllCellsSelected(0) = True Then
                cmd = New SqlCommand("delete from tblPolicyDetails", Connection:=con)
                cmd.ExecuteNonQuery()
                ButtonRefresh_Click(sender, e)
                MsgBox("Deleted")
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        Try
            For Each row As DataGridViewRow In DataGridViewReader.SelectedRows
                If row.Selected Then
                    cmd = New SqlCommand("delete from tblPolicyDetails where polyno='" & row.DataBoundItem(0).ToString & "'", Connection:=con)
                    cmd.ExecuteNonQuery()
                    ButtonRefresh_Click(sender, e)
                    MsgBox("Deleted")
                End If
            Next
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub ButtonUpdate_Click(sender As System.Object, e As System.EventArgs) Handles ButtonUpdate.Click
        Connection()

        Dim polnum As Integer = Convert.ToInt32(TextBoxPolicyNumber.Text)
        Dim polname As String = TextBoxPolicyHolderName.Text
        Dim poltype As String = ComboBoxPolicyType.Text
        Dim polamt As String = Convert.ToInt32(TextBoxPremiumofAmt.Text)
        Dim polyear As String = Convert.ToInt32(TextBoxNoOfYear.Text)

        cmd = New SqlCommand("update tblPolicyDetails set holdername=@polname,polytype=@poltype,premAmt=@polamt,nofyear=@polyear where polyno=@polnum", Connection:=con)
        cmd.Parameters.AddWithValue("@polnum", polnum)
        cmd.Parameters.AddWithValue("@polname", polname)
        cmd.Parameters.AddWithValue("@poltype", poltype)
        cmd.Parameters.AddWithValue("@polamt", polamt)
        cmd.Parameters.AddWithValue("@polyear", polyear)
        Try
            cmd.ExecuteNonQuery()
            ButtonRefresh_Click(sender, e)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class
