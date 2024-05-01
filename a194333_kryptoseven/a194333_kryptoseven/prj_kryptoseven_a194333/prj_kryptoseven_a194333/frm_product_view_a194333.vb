Public Class frm_product_view_a194333
    Private Sub frm_product_view_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim mysql As String = "SELECT FLD_PRODUCT_ID FROM TBL_PRODUCTS_A194333 ORDER BY FLD_PRODUCT_ID"

        Dim mydatatable As New DataTable

        Dim myreader As New OleDb.OleDbDataAdapter(mysql, myconnection)

        myreader.Fill(mydatatable)

        lst_product.DataSource = mydatatable
        lst_product.DisplayMember = "FLD_PRODUCT_ID"

        refresh_text(lst_product.Text)

    End Sub
    Private Sub refresh_text(product_id As String)

        Dim mysql As String = "SELECT * FROM TBL_PRODUCTS_A194333 WHERE FLD_PRODUCT_ID='" & product_id & "'"

        Dim mydatatable As New DataTable

        Dim myreader As New OleDb.OleDbDataAdapter(mysql, myconnection)

        myreader.Fill(mydatatable)

        txt_product_id.Text = mydatatable.Rows(0).Item("FLD_PRODUCT_ID")
        txt_name.Text = mydatatable.Rows(0).Item("FLD_PRODUCT_NAME")
        txt_category.Text = mydatatable.Rows(0).Item("FLD_CATEGORY")
        txt_type.Text = mydatatable.Rows(0).Item("FLD_TYPE")
        txt_description.Text = mydatatable.Rows(0).Item("FLD_DESCRIPTION")
        txt_stock.Text = mydatatable.Rows(0).Item("FLD_STOCK")
        txt_price.Text = mydatatable.Rows(0).Item("FLD_PRICE")

        Try

            pic_product.BackgroundImage = Image.FromFile("pictures/" & txt_product_id.Text & ".jpeg")

        Catch ex As Exception

            pic_product.BackgroundImage = Image.FromFile("pictures/nophoto.jpg")

        End Try

    End Sub
    Private Sub lst_product_Mouseclick(sender As Object, e As EventArgs) Handles lst_product.MouseClick

        refresh_text(lst_product.Text)

    End Sub

    Private Sub btn_prod_back_Click(sender As Object, e As EventArgs) Handles btn_prod_back.Click

        frm_mainmenu_a194333.Show()
        Me.Hide()

    End Sub
    Private Sub btn_prod_insert_Click(sender As Object, e As EventArgs) Handles btn_prod_insert.Click

        frm_insertproduct_a194333.Show()
        Me.Hide()

    End Sub

    Private Sub btn_prod_update_Click(sender As Object, e As EventArgs) Handles btn_prod_update.Click

        frm_updateproduct_a194333.Show()
        Me.Hide()

    End Sub
End Class