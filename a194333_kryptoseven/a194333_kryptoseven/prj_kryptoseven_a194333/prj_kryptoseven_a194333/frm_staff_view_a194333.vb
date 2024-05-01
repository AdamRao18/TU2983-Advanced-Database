Public Class frm_staffl_view_a194333
    Private Sub frm_stafflistView_a194333_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim mysql As String = "SELECT FLD_STAFF_ID FROM TBL_STAFF ORDER BY FLD_STAFF_ID"

        Dim mydatatable As New DataTable

        Dim myreader As New OleDb.OleDbDataAdapter(mysql, myconnection)

        myreader.Fill(mydatatable)

        lst_staff.DataSource = mydatatable
        lst_staff.DisplayMember = "FLD_STAFF_ID"

        refresh_text(lst_staff.Text)

    End Sub
    Private Sub refresh_text(staff_id As String)

        Dim mysql As String = "SELECT * FROM TBL_STAFF WHERE FLD_STAFF_ID='" & staff_id & "'"

        Dim mydatatable As New DataTable

        Dim myreader As New OleDb.OleDbDataAdapter(mysql, myconnection)

        myreader.Fill(mydatatable)

        txt_id.Text = mydatatable.Rows(0).Item("FLD_STAFF_ID")
        txt_name.Text = mydatatable.Rows(0).Item("FLD_STAFF_NAME")
        txt_phoneNum.Text = mydatatable.Rows(0).Item("FLD_PHONE_NUMBER")
        txt_email.Text = mydatatable.Rows(0).Item("FLD_EMAIL")

    End Sub
    Private Sub lst_staff_MouseClick(sender As Object, e As MouseEventArgs) Handles lst_staff.MouseClick

        refresh_text(lst_staff.Text)

    End Sub
    Private Sub btn_back_Click(sender As Object, e As EventArgs) Handles btn_back.Click

        frm_mainmenu_a194333.Show()
        Me.Hide()

    End Sub

    Private Sub btn_update_Click(sender As Object, e As EventArgs) Handles btn_update.Click

        frm_updatestaff_a194333.Show()
        Me.Hide()

    End Sub

    Private Sub btn_insert_Click(sender As Object, e As EventArgs) Handles btn_insert.Click

        frm_insertstaff_a194333.Show()
        Me.Hide()

    End Sub
End Class