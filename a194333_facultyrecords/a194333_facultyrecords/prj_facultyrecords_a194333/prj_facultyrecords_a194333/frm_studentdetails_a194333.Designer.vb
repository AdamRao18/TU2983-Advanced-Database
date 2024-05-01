<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_studentdetails_a194333
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
        Me.lbl_title = New System.Windows.Forms.Label()
        Me.lst_matric = New System.Windows.Forms.ListBox()
        Me.txt_matric = New System.Windows.Forms.TextBox()
        Me.txt_name = New System.Windows.Forms.TextBox()
        Me.txt_dept = New System.Windows.Forms.TextBox()
        Me.pic_student = New System.Windows.Forms.PictureBox()
        Me.btn_back = New System.Windows.Forms.Button()
        CType(Me.pic_student, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lbl_title
        '
        Me.lbl_title.AutoSize = True
        Me.lbl_title.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_title.Location = New System.Drawing.Point(305, 59)
        Me.lbl_title.Name = "lbl_title"
        Me.lbl_title.Size = New System.Drawing.Size(190, 29)
        Me.lbl_title.TabIndex = 0
        Me.lbl_title.Text = "Student Details"
        '
        'lst_matric
        '
        Me.lst_matric.FormattingEnabled = True
        Me.lst_matric.ItemHeight = 16
        Me.lst_matric.Location = New System.Drawing.Point(155, 132)
        Me.lst_matric.Name = "lst_matric"
        Me.lst_matric.Size = New System.Drawing.Size(120, 84)
        Me.lst_matric.TabIndex = 1
        '
        'txt_matric
        '
        Me.txt_matric.Location = New System.Drawing.Point(366, 144)
        Me.txt_matric.Name = "txt_matric"
        Me.txt_matric.Size = New System.Drawing.Size(100, 22)
        Me.txt_matric.TabIndex = 2
        '
        'txt_name
        '
        Me.txt_name.Location = New System.Drawing.Point(366, 194)
        Me.txt_name.Name = "txt_name"
        Me.txt_name.Size = New System.Drawing.Size(100, 22)
        Me.txt_name.TabIndex = 3
        '
        'txt_dept
        '
        Me.txt_dept.Location = New System.Drawing.Point(366, 244)
        Me.txt_dept.Name = "txt_dept"
        Me.txt_dept.Size = New System.Drawing.Size(100, 22)
        Me.txt_dept.TabIndex = 4
        '
        'pic_student
        '
        Me.pic_student.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.pic_student.Location = New System.Drawing.Point(575, 132)
        Me.pic_student.Name = "pic_student"
        Me.pic_student.Size = New System.Drawing.Size(132, 183)
        Me.pic_student.TabIndex = 5
        Me.pic_student.TabStop = False
        '
        'btn_back
        '
        Me.btn_back.Location = New System.Drawing.Point(13, 13)
        Me.btn_back.Name = "btn_back"
        Me.btn_back.Size = New System.Drawing.Size(75, 23)
        Me.btn_back.TabIndex = 6
        Me.btn_back.Text = "Back"
        Me.btn_back.UseVisualStyleBackColor = True
        '
        'frm_studentdetails_a194333
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Yellow
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btn_back)
        Me.Controls.Add(Me.pic_student)
        Me.Controls.Add(Me.txt_dept)
        Me.Controls.Add(Me.txt_name)
        Me.Controls.Add(Me.txt_matric)
        Me.Controls.Add(Me.lst_matric)
        Me.Controls.Add(Me.lbl_title)
        Me.Name = "frm_studentdetails_a194333"
        Me.Text = "frm_studentdetails_a194333"
        CType(Me.pic_student, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lbl_title As Label
    Friend WithEvents lst_matric As ListBox
    Friend WithEvents txt_matric As TextBox
    Friend WithEvents txt_name As TextBox
    Friend WithEvents txt_dept As TextBox
    Friend WithEvents pic_student As PictureBox
    Friend WithEvents btn_back As Button
End Class
