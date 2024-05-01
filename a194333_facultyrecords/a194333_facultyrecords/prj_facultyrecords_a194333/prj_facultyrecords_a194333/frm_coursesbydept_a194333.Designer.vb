<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_coursesbydept_a194333
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
        Me.grd_courses = New System.Windows.Forms.DataGridView()
        Me.cmb_dept = New System.Windows.Forms.ComboBox()
        Me.back_btn = New System.Windows.Forms.Button()
        CType(Me.grd_courses, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lbl_title
        '
        Me.lbl_title.AutoSize = True
        Me.lbl_title.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!)
        Me.lbl_title.Location = New System.Drawing.Point(186, 50)
        Me.lbl_title.Name = "lbl_title"
        Me.lbl_title.Size = New System.Drawing.Size(420, 46)
        Me.lbl_title.TabIndex = 0
        Me.lbl_title.Text = "Course by Department"
        '
        'grd_courses
        '
        Me.grd_courses.AllowUserToAddRows = False
        Me.grd_courses.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.grd_courses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grd_courses.Location = New System.Drawing.Point(103, 186)
        Me.grd_courses.Name = "grd_courses"
        Me.grd_courses.ReadOnly = True
        Me.grd_courses.RowHeadersWidth = 51
        Me.grd_courses.RowTemplate.Height = 24
        Me.grd_courses.Size = New System.Drawing.Size(554, 195)
        Me.grd_courses.TabIndex = 1
        '
        'cmb_dept
        '
        Me.cmb_dept.FormattingEnabled = True
        Me.cmb_dept.Location = New System.Drawing.Point(274, 131)
        Me.cmb_dept.Name = "cmb_dept"
        Me.cmb_dept.Size = New System.Drawing.Size(209, 24)
        Me.cmb_dept.TabIndex = 2
        '
        'back_btn
        '
        Me.back_btn.Location = New System.Drawing.Point(23, 60)
        Me.back_btn.Name = "back_btn"
        Me.back_btn.Size = New System.Drawing.Size(75, 23)
        Me.back_btn.TabIndex = 3
        Me.back_btn.Text = "Back"
        Me.back_btn.UseVisualStyleBackColor = True
        '
        'frm_coursesbydept_a194333
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Yellow
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.back_btn)
        Me.Controls.Add(Me.cmb_dept)
        Me.Controls.Add(Me.grd_courses)
        Me.Controls.Add(Me.lbl_title)
        Me.Name = "frm_coursesbydept_a194333"
        Me.Text = "frm_coursesbydept_a194333"
        CType(Me.grd_courses, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lbl_title As Label
    Friend WithEvents grd_courses As DataGridView
    Friend WithEvents cmb_dept As ComboBox
    Friend WithEvents back_btn As Button
End Class
