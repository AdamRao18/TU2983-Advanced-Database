Public Class frm_customer_view_a194333
    Private Sub frm_customer_view_a194333_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim mysql As String = "SELECT FLD_CUST_ID FROM TBL_CUSTOMER ORDER BY FLD_CUST_ID"

        Dim mydatatable As New DataTable

        Dim myreader As New OleDb.OleDbDataAdapter(mysql, myconnection)

        myreader.Fill(mydatatable)

        lst_customer.DataSource = mydatatable
        lst_customer.DisplayMember = "FLD_CUST_ID"

        refresh_text(lst_customer.Text)

    End Sub
    Private Sub refresh_text(customer_id As String)

        Dim mysql As String = "SELECT * FROM TBL_CUSTOMER WHERE FLD_CUST_ID='" & customer_id & "'"

        Dim mydatatable As New DataTable

        Dim myreader As New OleDb.OleDbDataAdapter(mysql, myconnection)

        myreader.Fill(mydatatable)

        txt_id.Text = mydatatable.Rows(0).Item("FLD_CUST_ID")
        txt_firstname.Text = mydatatable.Rows(0).Item("FLD_CUST_FIRSTNAME")
        txt_lastname.Text = mydatatable.Rows(0).Item("FLD_CUST_LASTNAME")
        txt_phoneNum.Text = mydatatable.Rows(0).Item("FLD_PHONE_NUMBER")
        txt_address.Text = mydatatable.Rows(0).Item("FLD_CUST_ADDRESS")
        txt_email.Text = mydatatable.Rows(0).Item("FLD_CUST_EMAIL")

    End Sub
    Private Sub lst_customer_MouseClick(sender As Object, e As EventArgs) Handles lst_customer.MouseClick

        refresh_text(lst_customer.Text)

    End Sub

    Private Sub btn_back_Click(sender As Object, e As EventArgs) Handles btn_back.Click

        frm_mainmenu_a194333.Show()
        Me.Hide()

    End Sub

    Private Sub btn_update_Click(sender As Object, e As EventArgs) Handles btn_update.Click

        frm_updatecustomer_a194333.Show()
        Me.Hide()

    End Sub

    Private Sub btn_insert_Click(sender As Object, e As EventArgs) Handles btn_insert.Click

        frm_insertcustomer_a194333.Show()
        Me.Hide()

    End Sub
End Class