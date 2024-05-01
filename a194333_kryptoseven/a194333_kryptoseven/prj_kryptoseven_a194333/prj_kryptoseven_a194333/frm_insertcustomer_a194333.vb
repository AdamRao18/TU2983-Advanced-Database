Public Class frm_insertcustomer_a194333
    Private Sub frm_insertcustomer_a194333_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        refresh_text()

        txt_id.Text = generate_id()

    End Sub
    Private Function generate_id() As String

        Dim lastID As String = run_sql_query("SELECT MAX(FLD_CUST_ID) AS LASTID FROM TBL_CUSTOMER").Rows(0).Item("LASTID")

        MsgBox(lastID)

        Dim newID As String = "CS0" & Mid(lastID, 3) + 1

        Return newID

    End Function
    Private Sub refresh_text()

        Dim mysql As String = "SELECT * FROM TBL_CUSTOMER"

        Dim mydatatable As New DataTable

        Dim myreader As New OleDb.OleDbDataAdapter(mysql, myconnection)

        myreader.Fill(mydatatable)

    End Sub
    Private Sub clear_fields()

        txt_id.Text = ""
        txt_firstname.Text = ""
        txt_lastname.Text = ""
        txt_phoneNum.Text = ""
        txt_address.Text = ""
        txt_email.Text = ""

    End Sub
    Private Sub btn_insert_Click(sender As Object, e As EventArgs) Handles btn_insert.Click

        Dim mysql As String = "INSERT INTO TBL_CUSTOMER VALUES ('" & txt_id.Text & "', '" & txt_firstname.Text & "', '" & txt_lastname.Text & "', " & txt_phoneNum.Text & ",'" & txt_address.Text & "','" & txt_email.Text & "')"

        Dim mywriter As New OleDb.OleDbCommand(mysql, myconnection2)

        Try

            mywriter.Connection.Open()
            mywriter.ExecuteNonQuery()
            mywriter.Connection.Close()

            MsgBox("Customer Data Insert Successfully")

            frm_customer_view_a194333.Show()
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

        frm_customer_view_a194333.Show()
        Me.Hide()

    End Sub
End Class