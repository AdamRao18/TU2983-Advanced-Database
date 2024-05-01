Public Class frm_splashscreen_a194333
    Private Sub btn_start_Click(sender As Object, e As EventArgs) Handles btn_start.Click

        username = txt_name.Text

        frm_mainmenu_a194333.Show()
        Me.Hide()

    End Sub

    Private Sub frm_splashscreen_a194333_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
