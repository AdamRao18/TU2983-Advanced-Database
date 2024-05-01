Public Class frm_viewOrder_a194333
    Private Sub frm_viewOrder_a194333_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim mysql As String = "SELECT FLD_ORDERNUMBER FROM TBL_ORDER"

        Dim mydatatable As New DataTable

        Dim myreader As New OleDb.OleDbDataAdapter(mysql, myconnection)

        myreader.Fill(mydatatable)

        cmb_orderNum.DataSource = mydatatable
        cmb_orderNum.DisplayMember = "FLD_ORDERNUMBER"

        refresh_grid(cmb_orderNum.Text)

    End Sub
    Private Sub refresh_grid(orderNum As String)

        Dim mysql As String = "SELECT * FROM TBL_ORDERPROD WHERE FLD_ORDERNUMBER='" & orderNum & "'"

        Dim mydatatable As New DataTable

        Dim myreader As New OleDb.OleDbDataAdapter(mysql, myconnection)

        myreader.Fill(mydatatable)

        grd_product.DataSource = mydatatable

    End Sub
    Private Sub cmb_orderNum_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmb_orderNum.SelectedIndexChanged

        refresh_grid(cmb_orderNum.Text)

    End Sub

    Private Sub btn_back_Click(sender As Object, e As EventArgs) Handles btn_back.Click

        frm_orderView_a194333.Show()
        Me.Hide()

    End Sub
End Class