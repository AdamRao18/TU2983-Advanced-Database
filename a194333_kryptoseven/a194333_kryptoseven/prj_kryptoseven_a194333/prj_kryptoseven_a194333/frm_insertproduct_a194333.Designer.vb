<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_insertproduct_a194333
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
        Me.LabelText1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txt_product_id = New System.Windows.Forms.TextBox()
        Me.txt_name = New System.Windows.Forms.TextBox()
        Me.txt_type = New System.Windows.Forms.TextBox()
        Me.txt_category = New System.Windows.Forms.TextBox()
        Me.txt_description = New System.Windows.Forms.TextBox()
        Me.txt_price = New System.Windows.Forms.TextBox()
        Me.txt_stock = New System.Windows.Forms.TextBox()
        Me.btn_picture = New System.Windows.Forms.Button()
        Me.btn_insert = New System.Windows.Forms.Button()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.pic_product = New System.Windows.Forms.PictureBox()
        Me.txt_picture = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.btn_back = New System.Windows.Forms.Button()
        CType(Me.pic_product, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LabelText1
        '
        Me.LabelText1.AutoSize = True
        Me.LabelText1.Location = New System.Drawing.Point(84, 65)
        Me.LabelText1.Name = "LabelText1"
        Me.LabelText1.Size = New System.Drawing.Size(21, 17)
        Me.LabelText1.TabIndex = 0
        Me.LabelText1.Text = "ID"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(84, 111)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(45, 17)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Name"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(84, 151)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(40, 17)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Type"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(84, 193)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(65, 17)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Category"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(84, 232)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(79, 17)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Description"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(84, 274)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(75, 17)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Price (RM)"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(84, 312)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(43, 17)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "Stock"
        '
        'txt_product_id
        '
        Me.txt_product_id.Location = New System.Drawing.Point(186, 60)
        Me.txt_product_id.Name = "txt_product_id"
        Me.txt_product_id.Size = New System.Drawing.Size(308, 22)
        Me.txt_product_id.TabIndex = 7
        '
        'txt_name
        '
        Me.txt_name.Location = New System.Drawing.Point(186, 106)
        Me.txt_name.Name = "txt_name"
        Me.txt_name.Size = New System.Drawing.Size(308, 22)
        Me.txt_name.TabIndex = 8
        '
        'txt_type
        '
        Me.txt_type.Location = New System.Drawing.Point(186, 146)
        Me.txt_type.Name = "txt_type"
        Me.txt_type.Size = New System.Drawing.Size(308, 22)
        Me.txt_type.TabIndex = 9
        '
        'txt_category
        '
        Me.txt_category.Location = New System.Drawing.Point(186, 188)
        Me.txt_category.Name = "txt_category"
        Me.txt_category.Size = New System.Drawing.Size(308, 22)
        Me.txt_category.TabIndex = 10
        '
        'txt_description
        '
        Me.txt_description.Location = New System.Drawing.Point(186, 227)
        Me.txt_description.Name = "txt_description"
        Me.txt_description.Size = New System.Drawing.Size(308, 22)
        Me.txt_description.TabIndex = 11
        '
        'txt_price
        '
        Me.txt_price.Location = New System.Drawing.Point(186, 269)
        Me.txt_price.Name = "txt_price"
        Me.txt_price.Size = New System.Drawing.Size(308, 22)
        Me.txt_price.TabIndex = 12
        '
        'txt_stock
        '
        Me.txt_stock.Location = New System.Drawing.Point(186, 307)
        Me.txt_stock.Name = "txt_stock"
        Me.txt_stock.Size = New System.Drawing.Size(308, 22)
        Me.txt_stock.TabIndex = 13
        '
        'btn_picture
        '
        Me.btn_picture.Location = New System.Drawing.Point(563, 325)
        Me.btn_picture.Name = "btn_picture"
        Me.btn_picture.Size = New System.Drawing.Size(143, 33)
        Me.btn_picture.TabIndex = 14
        Me.btn_picture.Text = "Select Image"
        Me.btn_picture.UseVisualStyleBackColor = True
        '
        'btn_insert
        '
        Me.btn_insert.Location = New System.Drawing.Point(371, 364)
        Me.btn_insert.Name = "btn_insert"
        Me.btn_insert.Size = New System.Drawing.Size(98, 37)
        Me.btn_insert.TabIndex = 15
        Me.btn_insert.Text = "INSERT"
        Me.btn_insert.UseVisualStyleBackColor = True
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'pic_product
        '
        Me.pic_product.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.pic_product.Location = New System.Drawing.Point(514, 63)
        Me.pic_product.Name = "pic_product"
        Me.pic_product.Size = New System.Drawing.Size(250, 197)
        Me.pic_product.TabIndex = 16
        Me.pic_product.TabStop = False
        '
        'txt_picture
        '
        Me.txt_picture.Location = New System.Drawing.Point(563, 282)
        Me.txt_picture.Name = "txt_picture"
        Me.txt_picture.Size = New System.Drawing.Size(143, 22)
        Me.txt_picture.TabIndex = 17
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(1665, 484)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 18
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'btn_back
        '
        Me.btn_back.Location = New System.Drawing.Point(12, 12)
        Me.btn_back.Name = "btn_back"
        Me.btn_back.Size = New System.Drawing.Size(75, 23)
        Me.btn_back.TabIndex = 19
        Me.btn_back.Text = "Back"
        Me.btn_back.UseVisualStyleBackColor = True
        '
        'frm_insertproduct_a194333
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.prj_kryptoseven_a194333.My.Resources.Resources.Untitled_design__2_
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btn_back)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.txt_picture)
        Me.Controls.Add(Me.pic_product)
        Me.Controls.Add(Me.btn_insert)
        Me.Controls.Add(Me.btn_picture)
        Me.Controls.Add(Me.txt_stock)
        Me.Controls.Add(Me.txt_price)
        Me.Controls.Add(Me.txt_description)
        Me.Controls.Add(Me.txt_category)
        Me.Controls.Add(Me.txt_type)
        Me.Controls.Add(Me.txt_name)
        Me.Controls.Add(Me.txt_product_id)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.LabelText1)
        Me.Name = "frm_insertproduct_a194333"
        Me.Text = "frm_insertproduct_a194333"
        CType(Me.pic_product, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LabelText1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents txt_product_id As TextBox
    Friend WithEvents txt_name As TextBox
    Friend WithEvents txt_type As TextBox
    Friend WithEvents txt_category As TextBox
    Friend WithEvents txt_description As TextBox
    Friend WithEvents txt_price As TextBox
    Friend WithEvents txt_stock As TextBox
    Friend WithEvents btn_picture As Button
    Friend WithEvents btn_insert As Button
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents pic_product As PictureBox
    Friend WithEvents txt_picture As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents btn_back As Button
End Class
