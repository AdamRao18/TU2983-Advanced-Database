Public Class frm_insertdept_a194333
    Private Sub frm_insertdept_a194333_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        refresh_grid()

    End Sub
    Private Sub refresh_grid()

        Dim mysql As String = "SELECT * FROM TBL_DEPARTMENT_A194333"

        Dim mydatatable As New DataTable

        Dim myreader As New OleDb.OleDbDataAdapter(mysql, myconnection)

        myreader.Fill(mydatatable)

        grd_dept.DataSource = mydatatable

    End Sub
    Private Sub clear_fields()

        txt_id.Text = ""
        txt_name.Text = ""

    End Sub

    Private Sub btn_insert_Click(sender As Object, e As EventArgs) Handles btn_insert.Click

        Dim mysql As String = "INSERT INTO TBL_DEPARTMENT_A194333 VALUES ('" & txt_id.Text & "', '" & txt_name.Text & "')"

        Dim mywriter As New OleDb.OleDbCommand(mysql, myconnection2)

        Try

            mywriter.Connection.Open()
            mywriter.ExecuteNonQuery()
            mywriter.Connection.Close()

            refresh_grid()
            clear_fields()

        Catch ex As Exception

            Beep()
            MsgBox("There is a mistake in the data you entered, as shown below" & vbCrLf & vbCrLf & ex.Message)
            mywriter.Connection.Close()

        End Try
    End Sub
End Class