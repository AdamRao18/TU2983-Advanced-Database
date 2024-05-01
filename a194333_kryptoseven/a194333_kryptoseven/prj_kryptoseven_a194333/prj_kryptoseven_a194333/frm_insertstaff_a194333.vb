Public Class frm_insertstaff_a194333
    Private Sub frm_insertstaff_a194333_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        refresh_text()

    End Sub
    Private Sub refresh_text()

        Dim mysql As String = "SELECT * FROM TBL_STAFF"

        Dim mydatatable As New DataTable

        Dim myreader As New OleDb.OleDbDataAdapter(mysql, myconnection)

        myreader.Fill(mydatatable)

    End Sub
    Private Sub clear_fields()

        txt_id.Text = ""
        txt_name.Text = ""
        txt_phoneNum.Text = ""
        txt_email.Text = ""

    End Sub

    Private Sub btn_insert_Click(sender As Object, e As EventArgs) Handles btn_insert.Click

        Dim mysql As String = "INSERT INTO TBL_STAFF VALUES ('" & txt_id.Text & "', '" & txt_name.Text & "', " & txt_phoneNum.Text & ",'" & txt_email.Text & "')"

        Dim mywriter As New OleDb.OleDbCommand(mysql, myconnection2)

        Try

            mywriter.Connection.Open()
            mywriter.ExecuteNonQuery()
            mywriter.Connection.Close()

            MsgBox("Staff data Insert Successfully")

            frm_staffl_view_a194333.Show()
            Me.Hide()

            refresh_text()
            clear_fields()

        Catch ex As Exception

            Beep()
            MsgBox("There is a mistake in the data you entered, as shown below" & vbCrLf & vbCrLf & ex.Message)

            mywriter.Connection.Close()

        End Try

    End Sub

    Private Sub btn_back_Click(sender As Object, e As EventArgs) Handles btn_back.Click

        frm_staffl_view_a194333.Show()
        Me.Hide()

    End Sub
End Class