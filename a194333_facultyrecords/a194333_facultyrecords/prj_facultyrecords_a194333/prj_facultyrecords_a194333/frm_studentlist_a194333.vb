Public Class frm_studentlist_a194333
    Private Sub frm_studentlist_a194333_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim myconnection As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=DB_FACULTYRECORDS_A194333.accdb;Persist Security Info=False;"

        Dim mysql As String = "SELECT * FROM TBL_STUDENTS_A194333"

        Dim mydatatable As New DataTable

        Dim myreader As New OleDb.OleDbDataAdapter(mysql, myconnection)

        myreader.Fill(mydatatable)

        grd_students.DataSource = mydatatable

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles back_btn.Click

        frm_mainmenu_a194333.Show()
        Me.Hide()

    End Sub

    Private Sub btn_insert_Click(sender As Object, e As EventArgs) Handles btn_insert.Click

        frm_inserstudent_a194333.Show()
        Me.Hide()

    End Sub

    Private Sub btn_update_Click(sender As Object, e As EventArgs) Handles btn_update.Click



    End Sub
End Class