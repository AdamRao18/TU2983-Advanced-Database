<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_mainmenu_a194333
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
        Me.Lbl_mainmenu = New System.Windows.Forms.Label()
        Me.btn_product = New System.Windows.Forms.Button()
        Me.btn_cust = New System.Windows.Forms.Button()
        Me.btn_order = New System.Windows.Forms.Button()
        Me.btn_staff = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Lbl_mainmenu
        '
        Me.Lbl_mainmenu.AutoSize = True
        Me.Lbl_mainmenu.BackColor = System.Drawing.Color.Transparent
        Me.Lbl_mainmenu.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!)
        Me.Lbl_mainmenu.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Lbl_mainmenu.Location = New System.Drawing.Point(12, 20)
        Me.Lbl_mainmenu.Name = "Lbl_mainmenu"
        Me.Lbl_mainmenu.Size = New System.Drawing.Size(247, 46)
        Me.Lbl_mainmenu.TabIndex = 0
        Me.Lbl_mainmenu.Text = "KryptoSeven"
        '
        'btn_product
        '
        Me.btn_product.Location = New System.Drawing.Point(376, 146)
        Me.btn_product.Name = "btn_product"
        Me.btn_product.Size = New System.Drawing.Size(91, 30)
        Me.btn_product.TabIndex = 1
        Me.btn_product.Text = "Products"
        Me.btn_product.UseVisualStyleBackColor = True
        '
        'btn_cust
        '
        Me.btn_cust.Location = New System.Drawing.Point(376, 238)
        Me.btn_cust.Name = "btn_cust"
        Me.btn_cust.Size = New System.Drawing.Size(91, 26)
        Me.btn_cust.TabIndex = 2
        Me.btn_cust.Text = "Customer"
        Me.btn_cust.UseVisualStyleBackColor = True
        '
        'btn_order
        '
        Me.btn_order.Location = New System.Drawing.Point(376, 290)
        Me.btn_order.Name = "btn_order"
        Me.btn_order.Size = New System.Drawing.Size(91, 26)
        Me.btn_order.TabIndex = 3
        Me.btn_order.Text = "Order"
        Me.btn_order.UseVisualStyleBackColor = True
        '
        'btn_staff
        '
        Me.btn_staff.Location = New System.Drawing.Point(376, 195)
        Me.btn_staff.Name = "btn_staff"
        Me.btn_staff.Size = New System.Drawing.Size(91, 27)
        Me.btn_staff.TabIndex = 4
        Me.btn_staff.Text = "Staff"
        Me.btn_staff.UseVisualStyleBackColor = True
        '
        'frm_mainmenu_a194333
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.prj_kryptoseven_a194333.My.Resources.Resources.Untitled_design__2_
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btn_staff)
        Me.Controls.Add(Me.btn_order)
        Me.Controls.Add(Me.btn_cust)
        Me.Controls.Add(Me.btn_product)
        Me.Controls.Add(Me.Lbl_mainmenu)
        Me.Name = "frm_mainmenu_a194333"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Main Menu"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Lbl_mainmenu As Label
    Friend WithEvents btn_product As Button
    Friend WithEvents btn_cust As Button
    Friend WithEvents btn_order As Button
    Friend WithEvents btn_staff As Button
End Class
