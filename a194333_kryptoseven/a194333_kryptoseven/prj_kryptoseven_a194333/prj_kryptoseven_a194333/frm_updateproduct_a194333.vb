Public Class frm_updateproduct_a194333

    Dim current_code As String
    Private Sub frm_updateproduct_a194333_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        refresh_grid()

        get_current_code()

    End Sub
    Private Sub refresh_grid()

        Dim mysql As String = "SELECT * FROM TBL_PRODUCTS_A194333"

        Dim mydatatable As New DataTable

        Dim myreader As New OleDb.OleDbDataAdapter(mysql, myconnection)

        myreader.Fill(mydatatable)

        grd_product.DataSource = mydatatable

    End Sub
    Private Sub clear_fields()

        txt_id.Text = ""
        txt_name.Text = ""
        txt_type.Text = ""
        txt_category.Text = ""
        txt_description.Text = ""
        txt_price.Text = ""
        txt_stock.Text = ""

    End Sub
    Private Sub get_current_code()

        Dim current_row As Integer = grd_product.CurrentRow.Index

        current_code = grd_product(0, current_row).Value

        txt_id.Text = current_code
        txt_name.Text = grd_product(1, current_row).Value
        txt_price.Text = grd_product(2, current_row).Value
        txt_type.Text = grd_product(3, current_row).Value
        txt_category.Text = grd_product(4, current_row).Value
        txt_description.Text = grd_product(5, current_row).Value
        txt_stock.Text = grd_product(6, current_row).Value

    End Sub
    Private Sub grd_product_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles grd_product.CellClick

        get_current_code()

    End Sub

    Private Sub btn_update_Click(sender As Object, e As EventArgs) Handles btn_update.Click

        run_sql_command("UPDATE TBL_PRODUCTS_A194333 SET FLD_PRODUCT_NAME='" & txt_name.Text & "', FLD_PRICE=" & txt_price.Text & ", FLD_TYPE='" & txt_type.Text & "', FLD_CATEGORY='" & txt_category.Text & "', FLD_DESCRIPTION='" & txt_description.Text & ", FLD_STOCK=" & txt_stock.Text & "' WHERE FLD_PRODUCT_ID='" & current_code & "'")

        Beep()
        MsgBox("You have successfully updated the product """ & current_code & """.")

        refresh_grid()
        clear_fields()
        get_current_code()

    End Sub

    Private Sub btn_delete_Click(sender As Object, e As EventArgs) Handles btn_delete.Click

        Dim delete_confirmation = MsgBox("Are you sure you would like to delete the product """ & current_code & """?", MsgBoxStyle.YesNo)

        If delete_confirmation = MsgBoxResult.Yes Then

            run_sql_command("DELETE FROM TBL_PRODUCTS_A194333 WHERE FLD_PRODUCT_ID='" & current_code & "'")

            Beep()
            MsgBox("The product """ & current_code & """ has been successfully deleted.")

            refresh_grid()
            clear_fields()
            get_current_code()

        End If

    End Sub

    Private Sub btn_back_Click(sender As Object, e As EventArgs) Handles btn_back.Click

        frm_product_view_a194333.Show()
        Me.Hide()

    End Sub
End Class