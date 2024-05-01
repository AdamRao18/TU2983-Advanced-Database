Public Class frm_insertproduct_a194333

    Dim defaultpicture As String = Application.StartupPath & "\pictures\nophoto.jpg"
    Private Sub frm_insertproduct_a194333_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        refresh_text()
        txt_product_id.Text = generate_id()
        txt_picture.Text = defaultpicture
        pic_product.BackgroundImage = Image.FromFile(defaultpicture)

    End Sub
    Private Function generate_id() As String

        Dim lastID As String = run_sql_query("SELECT MAX(FLD_PRODUCT_ID) AS LASTID FROM TBL_PRODUCTS_A194333").Rows(0).Item("LASTID")

        MsgBox(lastID)

        Dim newID As String = "CR" & Mid(lastID, 3) + 1

        Return newID

    End Function
    Private Sub refresh_text()

        Dim mysql As String = "SELECT * FROM TBL_PRODUCTS_A194333"

        Dim mydatatable As New DataTable

        Dim myreader As New OleDb.OleDbDataAdapter(mysql, myconnection)

        myreader.Fill(mydatatable)

    End Sub
    Private Sub clear_fields()

        txt_product_id.Text = generate_id()
        txt_name.Text = ""
        txt_type.Text = ""
        txt_category.Text = ""
        txt_description.Text = ""
        txt_price.Text = ""
        txt_stock.Text = ""
        txt_picture.Text = defaultpicture
        pic_product.BackgroundImage = Image.FromFile(defaultpicture)

    End Sub

    Private Sub btn_insert_Click(sender As Object, e As EventArgs) Handles btn_insert.Click

        Dim mysql As String = "INSERT INTO TBL_PRODUCTS_A194333 VALUES ('" & txt_product_id.Text & "', '" & txt_name.Text & "', " & txt_price.Text & ",'" & txt_type.Text & "', '" & txt_category.Text & "', '" & txt_description.Text & "', " & txt_stock.Text & ")"

        Dim mywriter As New OleDb.OleDbCommand(mysql, myconnection2)

        Try

            mywriter.Connection.Open()
            mywriter.ExecuteNonQuery()
            mywriter.Connection.Close()

            My.Computer.FileSystem.CopyFile(txt_picture.Text, "pictures\" & txt_product_id.Text & ".jpeg")

            MsgBox("Product Insert Successfully")

            frm_product_view_a194333.Show()
            Me.Hide()

            refresh_text()
            clear_fields()

        Catch ex As Exception

            Beep()
            MsgBox("There is a mistake in the data you entered, as shown below" & vbCrLf & vbCrLf & ex.Message)

            mywriter.Connection.Close()

        End Try

    End Sub

    Private Sub btn_picture_Click(sender As Object, e As EventArgs) Handles btn_picture.Click

        Dim mydesktop As String = My.Computer.FileSystem.SpecialDirectories.Desktop

        OpenFileDialog1.InitialDirectory = mydesktop
        OpenFileDialog1.FileName = ""
        OpenFileDialog1.Filter = "JPEG files (*.jpeg)|*.jpeg"
        OpenFileDialog1.ShowDialog()

        pic_product.BackgroundImage = Image.FromFile(OpenFileDialog1.FileName)
        txt_picture.Text = OpenFileDialog1.FileName

    End Sub

    Private Sub btn_back_Click(sender As Object, e As EventArgs) Handles btn_back.Click

        frm_product_view_a194333.Show()
        Me.Hide()

    End Sub
End Class