<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_product_view_a194333
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.btn_prod_update = New System.Windows.Forms.Button()
        Me.btn_prod_insert = New System.Windows.Forms.Button()
        Me.btn_prod_back = New System.Windows.Forms.Button()
        Me.txt_name = New System.Windows.Forms.TextBox()
        Me.txt_type = New System.Windows.Forms.TextBox()
        Me.txt_category = New System.Windows.Forms.TextBox()
        Me.txt_description = New System.Windows.Forms.TextBox()
        Me.txt_price = New System.Windows.Forms.TextBox()
        Me.txt_stock = New System.Windows.Forms.TextBox()
        Me.txt_product_id = New System.Windows.Forms.TextBox()
        Me.pic_product = New System.Windows.Forms.PictureBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.lst_product = New System.Windows.Forms.ListBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        CType(Me.pic_product, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btn_prod_update
        '
        Me.btn_prod_update.Location = New System.Drawing.Point(499, 364)
        Me.btn_prod_update.Name = "btn_prod_update"
        Me.btn_prod_update.Size = New System.Drawing.Size(121, 35)
        Me.btn_prod_update.TabIndex = 0
        Me.btn_prod_update.Text = "Update"
        Me.btn_prod_update.UseVisualStyleBackColor = True
        '
        'btn_prod_insert
        '
        Me.btn_prod_insert.Location = New System.Drawing.Point(626, 364)
        Me.btn_prod_insert.Name = "btn_prod_insert"
        Me.btn_prod_insert.Size = New System.Drawing.Size(162, 35)
        Me.btn_prod_insert.TabIndex = 1
        Me.btn_prod_insert.Text = "Insert New Product"
        Me.btn_prod_insert.UseVisualStyleBackColor = True
        '
        'btn_prod_back
        '
        Me.btn_prod_back.Location = New System.Drawing.Point(13, 13)
        Me.btn_prod_back.Name = "btn_prod_back"
        Me.btn_prod_back.Size = New System.Drawing.Size(75, 23)
        Me.btn_prod_back.TabIndex = 3
        Me.btn_prod_back.Text = "Back"
        Me.btn_prod_back.UseVisualStyleBackColor = True
        '
        'txt_name
        '
        Me.txt_name.Location = New System.Drawing.Point(271, 104)
        Me.txt_name.Name = "txt_name"
        Me.txt_name.Size = New System.Drawing.Size(201, 22)
        Me.txt_name.TabIndex = 5
        '
        'txt_type
        '
        Me.txt_type.Location = New System.Drawing.Point(271, 146)
        Me.txt_type.Name = "txt_type"
        Me.txt_type.Size = New System.Drawing.Size(201, 22)
        Me.txt_type.TabIndex = 6
        '
        'txt_category
        '
        Me.txt_category.Location = New System.Drawing.Point(271, 187)
        Me.txt_category.Name = "txt_category"
        Me.txt_category.Size = New System.Drawing.Size(201, 22)
        Me.txt_category.TabIndex = 7
        '
        'txt_description
        '
        Me.txt_description.Location = New System.Drawing.Point(271, 232)
        Me.txt_description.Name = "txt_description"
        Me.txt_description.Size = New System.Drawing.Size(201, 22)
        Me.txt_description.TabIndex = 8
        '
        'txt_price
        '
        Me.txt_price.Location = New System.Drawing.Point(271, 277)
        Me.txt_price.Name = "txt_price"
        Me.txt_price.Size = New System.Drawing.Size(201, 22)
        Me.txt_price.TabIndex = 9
        '
        'txt_stock
        '
        Me.txt_stock.Location = New System.Drawing.Point(271, 323)
        Me.txt_stock.Name = "txt_stock"
        Me.txt_stock.Size = New System.Drawing.Size(201, 22)
        Me.txt_stock.TabIndex = 10
        '
        'txt_product_id
        '
        Me.txt_product_id.Location = New System.Drawing.Point(271, 76)
        Me.txt_product_id.Name = "txt_product_id"
        Me.txt_product_id.Size = New System.Drawing.Size(201, 22)
        Me.txt_product_id.TabIndex = 11
        '
        'pic_product
        '
        Me.pic_product.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.pic_product.Location = New System.Drawing.Point(499, 76)
        Me.pic_product.Name = "pic_product"
        Me.pic_product.Size = New System.Drawing.Size(289, 271)
        Me.pic_product.TabIndex = 12
        Me.pic_product.TabStop = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(173, 189)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(65, 17)
        Me.Label4.TabIndex = 16
        Me.Label4.Text = "Category"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(173, 232)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(79, 17)
        Me.Label5.TabIndex = 17
        Me.Label5.Text = "Description"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(174, 282)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(75, 17)
        Me.Label6.TabIndex = 18
        Me.Label6.Text = "Price (RM)"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(174, 328)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(43, 17)
        Me.Label7.TabIndex = 19
        Me.Label7.Text = "Stock"
        '
        'lst_product
        '
        Me.lst_product.FormattingEnabled = True
        Me.lst_product.ItemHeight = 16
        Me.lst_product.Location = New System.Drawing.Point(13, 83)
        Me.lst_product.Name = "lst_product"
        Me.lst_product.Size = New System.Drawing.Size(127, 276)
        Me.lst_product.TabIndex = 20
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(174, 81)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(21, 17)
        Me.Label1.TabIndex = 21
        Me.Label1.Text = "ID"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(173, 109)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(45, 17)
        Me.Label2.TabIndex = 22
        Me.Label2.Text = "Name"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(174, 151)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(40, 17)
        Me.Label3.TabIndex = 23
        Me.Label3.Text = "Type"
        '
        'frm_product_view_a194333
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.prj_kryptoseven_a194333.My.Resources.Resources.Untitled_design__2_
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lst_product)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.pic_product)
        Me.Controls.Add(Me.txt_product_id)
        Me.Controls.Add(Me.txt_stock)
        Me.Controls.Add(Me.txt_price)
        Me.Controls.Add(Me.txt_description)
        Me.Controls.Add(Me.txt_category)
        Me.Controls.Add(Me.txt_type)
        Me.Controls.Add(Me.txt_name)
        Me.Controls.Add(Me.btn_prod_back)
        Me.Controls.Add(Me.btn_prod_insert)
        Me.Controls.Add(Me.btn_prod_update)
        Me.Name = "frm_product_view_a194333"
        Me.Text = "frm_product_view"
        CType(Me.pic_product, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btn_prod_update As Button
    Friend WithEvents btn_prod_insert As Button
    Friend WithEvents btn_prod_back As Button
    Friend WithEvents txt_name As TextBox
    Friend WithEvents txt_type As TextBox
    Friend WithEvents txt_category As TextBox
    Friend WithEvents txt_description As TextBox
    Friend WithEvents txt_price As TextBox
    Friend WithEvents txt_stock As TextBox
    Friend WithEvents txt_product_id As TextBox
    Friend WithEvents pic_product As PictureBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents lst_product As ListBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
End Class
