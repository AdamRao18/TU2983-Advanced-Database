Public Class frm_mainmenu_a194333
    Private Sub btn_product_Click(sender As Object, e As EventArgs) Handles btn_product.Click

        frm_product_view_a194333.Show()
        Me.Hide()

    End Sub

    Private Sub btn_staff_Click(sender As Object, e As EventArgs) Handles btn_staff.Click

        frm_staffl_view_a194333.Show()
        Me.Hide()

    End Sub

    Private Sub btn_cust_Click(sender As Object, e As EventArgs) Handles btn_cust.Click

        frm_customer_view_a194333.Show()
        Me.Hide()

    End Sub

    Private Sub btn_order_Click(sender As Object, e As EventArgs) Handles btn_order.Click

        frm_orderView_a194333.Show()
        Me.Hide()

    End Sub
End Class