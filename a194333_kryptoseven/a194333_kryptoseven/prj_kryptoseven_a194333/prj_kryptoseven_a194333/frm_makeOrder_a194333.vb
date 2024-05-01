Public Class frm_makeOrder_a194333
    Private Sub frm_makeOrder_a194333_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim current_date = Date.Now

        txt_date.Text = current_date

        refresh_text()

        Dim mysql As String = "SELECT FLD_PRODUCT_ID FROM TBL_PRODUCTS_A194333 ORDER BY FLD_PRODUCT_ID"

        Dim mydatatable As New DataTable

        Dim myreader As New OleDb.OleDbDataAdapter(mysql, myconnection)

        myreader.Fill(mydatatable)

        cmb_product.DataSource = mydatatable
        cmb_product.DisplayMember = "FLD_PRODUCT_ID"

        refresh_text(cmb_product.Text)

        refresh_grid()

        grd_newOrder.ColumnCount = grd_orderProd.ColumnCount

        For i = 0 To grd_newOrder.ColumnCount - 1

            grd_newOrder.Columns(i).HeaderText = grd_orderProd.Columns(i).HeaderText

        Next

    End Sub
    Private Sub refresh_text(product_id As String)

        Dim mysql As String = "SELECT * FROM TBL_PRODUCTS_A194333 WHERE FLD_PRODUCT_ID='" & product_id & "'"

        Dim mydatatable As New DataTable

        Dim myreader As New OleDb.OleDbDataAdapter(mysql, myconnection)

        myreader.Fill(mydatatable)

        txt_productName.Text = mydatatable.Rows(0).Item("FLD_PRODUCT_NAME")
        txt_stock.Text = mydatatable.Rows(0).Item("FLD_STOCK")
        txt_price.Text = mydatatable.Rows(0).Item("FLD_PRICE")

    End Sub
    Private Sub refresh_text()

        Dim mysql As String = "SELECT * FROM TBL_ORDER"

        Dim mydatatable As New DataTable

        Dim myreader As New OleDb.OleDbDataAdapter(mysql, myconnection)

        myreader.Fill(mydatatable)

    End Sub

    Private Sub btn_start_Click(sender As Object, e As EventArgs) Handles btn_start.Click

        Dim mysql As String = "INSERT INTO TBL_ORDER VALUES ('" & txt_orderNum.Text & "', '" & txt_custID.Text & "', '" & txt_staffID.Text & "')"

        Dim mywriter As New OleDb.OleDbCommand(mysql, myconnection2)

        Try

            mywriter.Connection.Open()
            mywriter.ExecuteNonQuery()
            mywriter.Connection.Close()

            MsgBox("Staff and Customer data Insert Successfully")

            refresh_text()

        Catch ex As Exception

            Beep()
            MsgBox("There is a mistake in the data you entered, as shown below" & vbCrLf & vbCrLf & ex.Message)

            mywriter.Connection.Close()

        End Try

    End Sub
    Private Sub cmb_product_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmb_product.SelectedIndexChanged

        refresh_text(cmb_product.Text)

    End Sub
    Private Sub refresh_grid()

        grd_orderProd.DataSource = run_sql_query("SELECT * FROM TBL_ORDERPROD")

    End Sub
    Private Sub btn_add_Click(sender As Object, e As EventArgs) Handles btn_add.Click

        If (txt_orderNum.Text <> "" And txt_custID.Text <> "" And txt_staffID.Text <> "") Then

            Try

                grd_newOrder.RowCount = grd_newOrder.RowCount + 1

                Dim current_row As Integer = grd_newOrder.CurrentRow.Index - 1

                grd_newOrder(0, current_row).Value = txt_orderNum.Text
                grd_newOrder(1, current_row).Value = cmb_product.GetItemText(cmb_product.SelectedValue)
                grd_newOrder(2, current_row).Value = txt_date.Text

                txt_grandTotal.Text = (Convert.ToInt32(txt_price.Text) + Convert.ToInt32(txt_grandTotal.Text)).ToString()

            Catch ex As Exception

                Beep()
                MsgBox("There is a mistake in the data you entered, as shown below" & vbCrLf & vbCrLf & ex.Message)

            End Try

        Else

            MsgBox("P.O Number, CustomerID & StaffID is required before making order")

        End If

    End Sub
    Private Sub txt_paid_TextChanged(sender As Object, e As EventArgs) Handles txt_paid.TextChanged

        Try

            If txt_grandTotal.Text.Length > 0 Then

                txt_balance.Text = (Convert.ToInt32(txt_paid.Text) - Convert.ToInt32(txt_grandTotal.Text)).ToString()

            End If

        Catch ex As Exception

            Beep()
            MsgBox("There is a mistake in the data you entered, as shown below" & vbCrLf & vbCrLf & ex.Message)

            txt_balance.Text = ""
        End Try
    End Sub
    Private Sub btn_pay_Click(sender As Object, e As EventArgs) Handles btn_pay.Click

        If txt_balance.Text = 0 Then

            Dim mytransaction As OleDb.OleDbTransaction
            myconnection2.Open()
            mytransaction = myconnection2.BeginTransaction

            Try

                For i As Integer = 0 To grd_newOrder.RowCount - 1

                    Dim orderNumber As String = grd_newOrder(0, i).Value
                    Dim productID As String = grd_newOrder(1, i).Value
                    Dim orderDate As String = grd_newOrder(2, i).Value

                    Dim mysql As String = "INSERT INTO TBL_ORDERPROD VALUES ('" & orderNumber & "', '" & productID & "', '" & orderDate & "')"
                    Dim mywriter As New OleDb.OleDbCommand(mysql, myconnection2, mytransaction)

                    mywriter.ExecuteNonQuery()

                Next

                mytransaction.Commit()
                myconnection2.Close()

                Beep()
                MsgBox("Transaction successful!")

                refresh_grid()
                clear_fields()
                grd_newOrder.Rows.Clear()

            Catch ex As Exception

                Beep()
                MsgBox("Problem with transaction:" & vbCrLf & vbCrLf & ex.Message)

                mytransaction.Rollback()
                myconnection2.Close()
                refresh_grid()

            End Try

        Else

            MsgBox("Not Enough Money!!!")

        End If

    End Sub
    Private Sub clear_fields()

        txt_orderNum.Text = ""
        txt_custID.Text = ""
        txt_staffID.Text = ""
        txt_grandTotal.Text = ""
        txt_paid.Text = ""
        txt_balance.Text = ""

    End Sub
    Private Sub btn_back_Click(sender As Object, e As EventArgs) Handles btn_back.Click

        frm_orderView_a194333.Show()
        Me.Hide()

    End Sub
End Class