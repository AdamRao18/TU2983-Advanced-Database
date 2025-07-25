﻿Public Class frm_updatecustomer_a194333

    Dim current_code As String
    Private Sub frm_updatecustomer_a194333_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        refresh_grid()

        get_current_code()

    End Sub
    Private Sub refresh_grid()

        Dim mysql As String = "SELECT * FROM TBL_CUSTOMER"

        Dim mydatatable As New DataTable

        Dim myreader As New OleDb.OleDbDataAdapter(mysql, myconnection)

        myreader.Fill(mydatatable)

        grd_customer.DataSource = mydatatable

    End Sub
    Private Sub clear_fields()

        txt_id.Text = ""
        txt_firstname.Text = ""
        txt_lastname.Text = ""
        txt_phoneNum.Text = ""
        txt_email.Text = ""
        txt_address.Text = ""

    End Sub
    Private Sub get_current_code()

        Dim current_row As Integer = grd_customer.CurrentRow.Index

        current_code = grd_customer(0, current_row).Value

        txt_id.Text = current_code
        txt_firstname.Text = grd_customer(1, current_row).Value
        txt_lastname.Text = grd_customer(2, current_row).Value
        txt_phoneNum.Text = grd_customer(3, current_row).Value
        txt_address.Text = grd_customer(4, current_row).Value
        txt_email.Text = grd_customer(5, current_row).Value

    End Sub
    Private Sub grd_customer_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles grd_customer.CellClick

        get_current_code()

    End Sub

    Private Sub btn_update_Click(sender As Object, e As EventArgs) Handles btn_update.Click

        run_sql_command("UPDATE TBL_CUSTOMER SET FLD_CUST_FIRSTNAME='" & txt_firstname.Text & "', FLD_CUST_LASTNAME='" & txt_lastname.Text & "', FLD_PHONE_NUMBER=" & txt_phoneNum.Text & ", FLD_CUST_ADDRESS='" & txt_address.Text & "', FLD_CUST_EMAIL='" & txt_email.Text & "' WHERE FLD_CUST_ID='" & current_code & "'")

        Beep()
        MsgBox("You have successfully updated the customer """ & current_code & """.")

        refresh_grid()
        clear_fields()
        get_current_code()

    End Sub

    Private Sub btn_delete_Click(sender As Object, e As EventArgs) Handles btn_delete.Click

        Dim delete_confirmation = MsgBox("Are you sure you would like to delete this customer with ID """ & current_code & """?", MsgBoxStyle.YesNo)

        If delete_confirmation = MsgBoxResult.Yes Then

            run_sql_command("DELETE FROM TBL_CUSTOMER WHERE FLD_CUST_ID='" & current_code & "'")

            Beep()
            MsgBox("The customer with ID """ & current_code & """ has been successfully deleted.")

            refresh_grid()
            clear_fields()
            get_current_code()

        End If

    End Sub

    Private Sub btn_back_Click(sender As Object, e As EventArgs) Handles btn_back.Click

        frm_customer_view_a194333.Show()
        Me.Hide()

    End Sub
End Class