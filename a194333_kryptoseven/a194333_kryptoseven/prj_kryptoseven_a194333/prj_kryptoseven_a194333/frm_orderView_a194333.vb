Public Class frm_orderView_a194333
    Private Sub btn_back_Click(sender As Object, e As EventArgs) Handles btn_back.Click

        frm_mainmenu_a194333.Show()
        Me.Hide()

    End Sub

    Private Sub btn_makeOrder_Click(sender As Object, e As EventArgs) Handles btn_makeOrder.Click

        frm_makeOrder_a194333.Show()
        Me.Hide()

    End Sub

    Private Sub btn_viewOrder_Click(sender As Object, e As EventArgs) Handles btn_viewOrder.Click

        frm_viewOrder_a194333.Show()
        Me.Hide()

    End Sub
End Class