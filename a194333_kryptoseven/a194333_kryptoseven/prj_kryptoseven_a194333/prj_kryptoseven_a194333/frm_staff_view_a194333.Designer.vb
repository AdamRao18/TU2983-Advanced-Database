<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_staffl_view_a194333
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
        Me.btn_back = New System.Windows.Forms.Button()
        Me.lst_staff = New System.Windows.Forms.ListBox()
        Me.txt_id = New System.Windows.Forms.TextBox()
        Me.txt_phoneNum = New System.Windows.Forms.TextBox()
        Me.txt_name = New System.Windows.Forms.TextBox()
        Me.txt_email = New System.Windows.Forms.TextBox()
        Me.btn_update = New System.Windows.Forms.Button()
        Me.btn_insert = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btn_back
        '
        Me.btn_back.Location = New System.Drawing.Point(13, 13)
        Me.btn_back.Name = "btn_back"
        Me.btn_back.Size = New System.Drawing.Size(75, 23)
        Me.btn_back.TabIndex = 0
        Me.btn_back.Text = "Back"
        Me.btn_back.UseVisualStyleBackColor = True
        '
        'lst_staff
        '
        Me.lst_staff.FormattingEnabled = True
        Me.lst_staff.ItemHeight = 16
        Me.lst_staff.Location = New System.Drawing.Point(46, 80)
        Me.lst_staff.Name = "lst_staff"
        Me.lst_staff.Size = New System.Drawing.Size(120, 228)
        Me.lst_staff.TabIndex = 1
        '
        'txt_id
        '
        Me.txt_id.Location = New System.Drawing.Point(306, 111)
        Me.txt_id.Name = "txt_id"
        Me.txt_id.Size = New System.Drawing.Size(138, 22)
        Me.txt_id.TabIndex = 2
        '
        'txt_phoneNum
        '
        Me.txt_phoneNum.Location = New System.Drawing.Point(610, 106)
        Me.txt_phoneNum.Name = "txt_phoneNum"
        Me.txt_phoneNum.Size = New System.Drawing.Size(162, 22)
        Me.txt_phoneNum.TabIndex = 3
        '
        'txt_name
        '
        Me.txt_name.Location = New System.Drawing.Point(306, 181)
        Me.txt_name.Name = "txt_name"
        Me.txt_name.Size = New System.Drawing.Size(138, 22)
        Me.txt_name.TabIndex = 4
        '
        'txt_email
        '
        Me.txt_email.Location = New System.Drawing.Point(610, 187)
        Me.txt_email.Name = "txt_email"
        Me.txt_email.Size = New System.Drawing.Size(162, 22)
        Me.txt_email.TabIndex = 5
        '
        'btn_update
        '
        Me.btn_update.Location = New System.Drawing.Point(284, 303)
        Me.btn_update.Name = "btn_update"
        Me.btn_update.Size = New System.Drawing.Size(102, 40)
        Me.btn_update.TabIndex = 6
        Me.btn_update.Text = "Update"
        Me.btn_update.UseVisualStyleBackColor = True
        '
        'btn_insert
        '
        Me.btn_insert.Location = New System.Drawing.Point(476, 303)
        Me.btn_insert.Name = "btn_insert"
        Me.btn_insert.Size = New System.Drawing.Size(156, 40)
        Me.btn_insert.TabIndex = 7
        Me.btn_insert.Text = "Insert New Staff"
        Me.btn_insert.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(200, 111)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(54, 17)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Satff ID"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(200, 186)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(78, 17)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Satff Name"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(488, 111)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(103, 17)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "Phone Number"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(491, 182)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(98, 17)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "Email Address"
        '
        'frm_staffl_view_a194333
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.prj_kryptoseven_a194333.My.Resources.Resources.Untitled_design__2_
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btn_insert)
        Me.Controls.Add(Me.btn_update)
        Me.Controls.Add(Me.txt_email)
        Me.Controls.Add(Me.txt_name)
        Me.Controls.Add(Me.txt_phoneNum)
        Me.Controls.Add(Me.txt_id)
        Me.Controls.Add(Me.lst_staff)
        Me.Controls.Add(Me.btn_back)
        Me.Name = "frm_staffl_view_a194333"
        Me.Text = "frm_stafflistView_a194333"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btn_back As Button
    Friend WithEvents lst_staff As ListBox
    Friend WithEvents txt_id As TextBox
    Friend WithEvents txt_phoneNum As TextBox
    Friend WithEvents txt_name As TextBox
    Friend WithEvents txt_email As TextBox
    Friend WithEvents btn_update As Button
    Friend WithEvents btn_insert As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
End Class
