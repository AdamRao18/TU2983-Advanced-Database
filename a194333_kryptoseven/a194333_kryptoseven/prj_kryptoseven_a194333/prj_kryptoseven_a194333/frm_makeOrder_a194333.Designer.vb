<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frm_makeOrder_a194333
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.btn_back = New System.Windows.Forms.Button()
        Me.txt_orderNum = New System.Windows.Forms.TextBox()
        Me.txt_date = New System.Windows.Forms.TextBox()
        Me.txt_staffID = New System.Windows.Forms.TextBox()
        Me.txt_custID = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cmb_product = New System.Windows.Forms.ComboBox()
        Me.txt_productName = New System.Windows.Forms.TextBox()
        Me.txt_stock = New System.Windows.Forms.TextBox()
        Me.txt_price = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.grd_orderProd = New System.Windows.Forms.DataGridView()
        Me.btn_add = New System.Windows.Forms.Button()
        Me.txt_grandTotal = New System.Windows.Forms.TextBox()
        Me.txt_paid = New System.Windows.Forms.TextBox()
        Me.txt_balance = New System.Windows.Forms.TextBox()
        Me.btn_pay = New System.Windows.Forms.Button()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.btn_start = New System.Windows.Forms.Button()
        Me.grd_newOrder = New System.Windows.Forms.DataGridView()
        CType(Me.grd_orderProd, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grd_newOrder, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btn_back
        '
        Me.btn_back.Location = New System.Drawing.Point(13, 13)
        Me.btn_back.Name = "btn_back"
        Me.btn_back.Size = New System.Drawing.Size(86, 29)
        Me.btn_back.TabIndex = 0
        Me.btn_back.Text = "Back"
        Me.btn_back.UseVisualStyleBackColor = True
        '
        'txt_orderNum
        '
        Me.txt_orderNum.Location = New System.Drawing.Point(401, 34)
        Me.txt_orderNum.Name = "txt_orderNum"
        Me.txt_orderNum.Size = New System.Drawing.Size(100, 22)
        Me.txt_orderNum.TabIndex = 3
        '
        'txt_date
        '
        Me.txt_date.Location = New System.Drawing.Point(200, 34)
        Me.txt_date.Name = "txt_date"
        Me.txt_date.ReadOnly = True
        Me.txt_date.Size = New System.Drawing.Size(172, 22)
        Me.txt_date.TabIndex = 4
        '
        'txt_staffID
        '
        Me.txt_staffID.Location = New System.Drawing.Point(658, 34)
        Me.txt_staffID.Name = "txt_staffID"
        Me.txt_staffID.Size = New System.Drawing.Size(121, 22)
        Me.txt_staffID.TabIndex = 5
        '
        'txt_custID
        '
        Me.txt_custID.Location = New System.Drawing.Point(517, 34)
        Me.txt_custID.Name = "txt_custID"
        Me.txt_custID.Size = New System.Drawing.Size(121, 22)
        Me.txt_custID.TabIndex = 6
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label1.Location = New System.Drawing.Point(267, 11)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(42, 17)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Date"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label2.Location = New System.Drawing.Point(409, 10)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(96, 17)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "P.O Number"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label3.Location = New System.Drawing.Point(535, 9)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(96, 17)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Customer ID"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label4.Location = New System.Drawing.Point(693, 10)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(62, 17)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "Staff ID"
        '
        'cmb_product
        '
        Me.cmb_product.FormattingEnabled = True
        Me.cmb_product.Location = New System.Drawing.Point(45, 157)
        Me.cmb_product.Name = "cmb_product"
        Me.cmb_product.Size = New System.Drawing.Size(121, 24)
        Me.cmb_product.TabIndex = 11
        '
        'txt_productName
        '
        Me.txt_productName.Location = New System.Drawing.Point(194, 159)
        Me.txt_productName.Name = "txt_productName"
        Me.txt_productName.ReadOnly = True
        Me.txt_productName.Size = New System.Drawing.Size(185, 22)
        Me.txt_productName.TabIndex = 12
        '
        'txt_stock
        '
        Me.txt_stock.Location = New System.Drawing.Point(402, 157)
        Me.txt_stock.Name = "txt_stock"
        Me.txt_stock.ReadOnly = True
        Me.txt_stock.Size = New System.Drawing.Size(100, 22)
        Me.txt_stock.TabIndex = 13
        Me.txt_stock.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txt_price
        '
        Me.txt_price.Location = New System.Drawing.Point(688, 159)
        Me.txt_price.Name = "txt_price"
        Me.txt_price.ReadOnly = True
        Me.txt_price.Size = New System.Drawing.Size(100, 22)
        Me.txt_price.TabIndex = 15
        Me.txt_price.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label5.Location = New System.Drawing.Point(66, 124)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(84, 17)
        Me.Label5.TabIndex = 16
        Me.Label5.Text = "Product ID"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label6.Location = New System.Drawing.Point(267, 124)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(49, 17)
        Me.Label6.TabIndex = 17
        Me.Label6.Text = "Name"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label7.Location = New System.Drawing.Point(428, 123)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(48, 17)
        Me.Label7.TabIndex = 18
        Me.Label7.Text = "Stock"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label9.Location = New System.Drawing.Point(704, 124)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(85, 17)
        Me.Label9.TabIndex = 20
        Me.Label9.Text = "Price (RM)"
        '
        'grd_orderProd
        '
        Me.grd_orderProd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grd_orderProd.Location = New System.Drawing.Point(46, 219)
        Me.grd_orderProd.Name = "grd_orderProd"
        Me.grd_orderProd.RowHeadersWidth = 51
        Me.grd_orderProd.RowTemplate.Height = 24
        Me.grd_orderProd.Size = New System.Drawing.Size(476, 150)
        Me.grd_orderProd.TabIndex = 21
        '
        'btn_add
        '
        Me.btn_add.Location = New System.Drawing.Point(216, 380)
        Me.btn_add.Name = "btn_add"
        Me.btn_add.Size = New System.Drawing.Size(106, 41)
        Me.btn_add.TabIndex = 22
        Me.btn_add.Text = "Add"
        Me.btn_add.UseVisualStyleBackColor = True
        '
        'txt_grandTotal
        '
        Me.txt_grandTotal.Location = New System.Drawing.Point(688, 244)
        Me.txt_grandTotal.Name = "txt_grandTotal"
        Me.txt_grandTotal.Size = New System.Drawing.Size(100, 22)
        Me.txt_grandTotal.TabIndex = 23
        Me.txt_grandTotal.Text = "0"
        Me.txt_grandTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txt_paid
        '
        Me.txt_paid.Location = New System.Drawing.Point(688, 291)
        Me.txt_paid.Name = "txt_paid"
        Me.txt_paid.Size = New System.Drawing.Size(100, 22)
        Me.txt_paid.TabIndex = 24
        Me.txt_paid.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txt_balance
        '
        Me.txt_balance.Location = New System.Drawing.Point(688, 335)
        Me.txt_balance.Name = "txt_balance"
        Me.txt_balance.Size = New System.Drawing.Size(100, 22)
        Me.txt_balance.TabIndex = 25
        Me.txt_balance.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btn_pay
        '
        Me.btn_pay.Location = New System.Drawing.Point(607, 380)
        Me.btn_pay.Name = "btn_pay"
        Me.btn_pay.Size = New System.Drawing.Size(164, 41)
        Me.btn_pay.TabIndex = 26
        Me.btn_pay.Text = "Pay"
        Me.btn_pay.UseVisualStyleBackColor = True
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label10.Location = New System.Drawing.Point(543, 247)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(135, 17)
        Me.Label10.TabIndex = 27
        Me.Label10.Text = "Grand Total (RM)"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label11.Location = New System.Drawing.Point(543, 294)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(80, 17)
        Me.Label11.TabIndex = 28
        Me.Label11.Text = "Paid (RM)"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label12.Location = New System.Drawing.Point(543, 338)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(106, 17)
        Me.Label12.TabIndex = 29
        Me.Label12.Text = "Balance (RM)"
        '
        'btn_start
        '
        Me.btn_start.BackColor = System.Drawing.Color.Red
        Me.btn_start.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_start.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_start.ForeColor = System.Drawing.SystemColors.Control
        Me.btn_start.Location = New System.Drawing.Point(401, 73)
        Me.btn_start.Name = "btn_start"
        Me.btn_start.Size = New System.Drawing.Size(376, 30)
        Me.btn_start.TabIndex = 31
        Me.btn_start.Text = "CONNECT"
        Me.btn_start.UseVisualStyleBackColor = False
        '
        'grd_newOrder
        '
        Me.grd_newOrder.AllowUserToDeleteRows = False
        Me.grd_newOrder.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.grd_newOrder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grd_newOrder.Location = New System.Drawing.Point(13, 219)
        Me.grd_newOrder.Name = "grd_newOrder"
        Me.grd_newOrder.RowHeadersWidth = 51
        Me.grd_newOrder.RowTemplate.Height = 24
        Me.grd_newOrder.Size = New System.Drawing.Size(509, 150)
        Me.grd_newOrder.TabIndex = 32
        '
        'frm_makeOrder_a194333
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.prj_kryptoseven_a194333.My.Resources.Resources.Untitled_design__2_
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.grd_newOrder)
        Me.Controls.Add(Me.btn_start)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.btn_pay)
        Me.Controls.Add(Me.txt_balance)
        Me.Controls.Add(Me.txt_paid)
        Me.Controls.Add(Me.txt_grandTotal)
        Me.Controls.Add(Me.btn_add)
        Me.Controls.Add(Me.grd_orderProd)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txt_price)
        Me.Controls.Add(Me.txt_stock)
        Me.Controls.Add(Me.txt_productName)
        Me.Controls.Add(Me.cmb_product)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txt_custID)
        Me.Controls.Add(Me.txt_staffID)
        Me.Controls.Add(Me.txt_date)
        Me.Controls.Add(Me.txt_orderNum)
        Me.Controls.Add(Me.btn_back)
        Me.Name = "frm_makeOrder_a194333"
        Me.Text = "frm_makeOrder_a194333"
        CType(Me.grd_orderProd, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grd_newOrder, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btn_back As Button
    Friend WithEvents txt_orderNum As TextBox
    Friend WithEvents txt_date As TextBox
    Friend WithEvents txt_staffID As TextBox
    Friend WithEvents txt_custID As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents cmb_product As ComboBox
    Friend WithEvents txt_productName As TextBox
    Friend WithEvents txt_stock As TextBox
    Friend WithEvents txt_price As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents grd_orderProd As DataGridView
    Friend WithEvents btn_add As Button
    Friend WithEvents txt_grandTotal As TextBox
    Friend WithEvents txt_paid As TextBox
    Friend WithEvents txt_balance As TextBox
    Friend WithEvents btn_pay As Button
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents btn_start As Button
    Friend WithEvents grd_newOrder As DataGridView
End Class
