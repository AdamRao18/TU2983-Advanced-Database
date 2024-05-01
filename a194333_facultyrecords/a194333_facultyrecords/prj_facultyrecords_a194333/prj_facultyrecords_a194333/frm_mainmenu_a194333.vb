Public Class frm_mainmenu_a194333
    Private Sub frm_mainmenu_a194333_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim current_date As String = Date.Now

        lbl_date.Text = current_date

        lbl_welcome.Text = "Welcome " & username & " to the UKM Faculty Record System"

    End Sub

    Private Sub btn_exit_Click(sender As Object, e As EventArgs) Handles btn_exit.Click

        End

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        frm_studentdetails_a194333.Show()
        Me.Hide()

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click

        frm_studentlist_a194333.Show()
        Me.Hide()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        frm_coursesbydept_a194333.Show()
        Me.Hide()

    End Sub
End Class