Public Class frm_studentdetails_a194333
    Private Sub frm_studentdetails_a194333_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim mysql As String = "SELECT FLD_MATRIC FROM TBL_STUDENTS_A194333"

        Dim mydatatable As New DataTable

        Dim myreader As New OleDb.OleDbDataAdapter(mysql, myconnection)

        myreader.Fill(mydatatable)

        lst_matric.DataSource = mydatatable
        lst_matric.DisplayMember = "FLD_MATRIC"

        refresh_text(lst_matric.Text)

    End Sub

    Private Sub refresh_text(matric As String)

        Dim mysql As String = "SELECT * FROM TBL_STUDENTS_A194333 WHERE FLD_MATRIC ='" & matric & "'"

        Dim mydatatable As New DataTable

        Dim myreader As New OleDb.OleDbDataAdapter(mysql, myconnection)

        myreader.Fill(mydatatable)

        txt_matric.Text = mydatatable.Rows(0).Item("FLD_MATRIC")
        txt_name.Text = mydatatable.Rows(0).Item("FLD_NAME")
        txt_dept.Text = mydatatable.Rows(0).Item("FLD_DEPT")

        Try

            pic_student.BackgroundImage = Image.FromFile("pictures/" & txt_matric.Text & ".jpg")

        Catch ex As Exception

            pic_student.BackgroundImage = Image.FromFile("pictures/nophoto.jpg")

        End Try

    End Sub
    Private Sub lst_matric_MouseClick(sender As Object, e As EventArgs) Handles lst_matric.MouseClick

        refresh_text(lst_matric.Text)

    End Sub

    Private Sub btn_back_Click(sender As Object, e As EventArgs) Handles btn_back.Click

        frm_mainmenu_a194333.Show()
        Me.Hide()

    End Sub
End Class