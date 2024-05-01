<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_splashscreen_a194333
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
        Me.Lbl_name = New System.Windows.Forms.Label()
        Me.txt_name = New System.Windows.Forms.TextBox()
        Me.btn_start = New System.Windows.Forms.Button()
        Me.lbl_title = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Lbl_name
        '
        Me.Lbl_name.AutoSize = True
        Me.Lbl_name.Location = New System.Drawing.Point(388, 124)
        Me.Lbl_name.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Lbl_name.Name = "Lbl_name"
        Me.Lbl_name.Size = New System.Drawing.Size(199, 17)
        Me.Lbl_name.TabIndex = 0
        Me.Lbl_name.Text = "Please enter your name below"
        '
        'txt_name
        '
        Me.txt_name.Location = New System.Drawing.Point(415, 171)
        Me.txt_name.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_name.Name = "txt_name"
        Me.txt_name.Size = New System.Drawing.Size(132, 22)
        Me.txt_name.TabIndex = 1
        Me.txt_name.Text = "Anonymous"
        '
        'btn_start
        '
        Me.btn_start.Location = New System.Drawing.Point(429, 234)
        Me.btn_start.Margin = New System.Windows.Forms.Padding(4)
        Me.btn_start.Name = "btn_start"
        Me.btn_start.Size = New System.Drawing.Size(100, 28)
        Me.btn_start.TabIndex = 2
        Me.btn_start.Text = "START"
        Me.btn_start.UseVisualStyleBackColor = True
        '
        'lbl_title
        '
        Me.lbl_title.AutoSize = True
        Me.lbl_title.Font = New System.Drawing.Font("Times New Roman", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_title.ForeColor = System.Drawing.Color.Blue
        Me.lbl_title.Location = New System.Drawing.Point(303, 46)
        Me.lbl_title.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_title.Name = "lbl_title"
        Me.lbl_title.Size = New System.Drawing.Size(405, 45)
        Me.lbl_title.TabIndex = 3
        Me.lbl_title.Text = "UKM Faculty Records"
        '
        'frm_splashscreen_a194333
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Yellow
        Me.ClientSize = New System.Drawing.Size(1067, 554)
        Me.Controls.Add(Me.lbl_title)
        Me.Controls.Add(Me.btn_start)
        Me.Controls.Add(Me.txt_name)
        Me.Controls.Add(Me.Lbl_name)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "frm_splashscreen_a194333"
        Me.Text = "UKM Faculty Records"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Lbl_name As Label
    Friend WithEvents txt_name As TextBox
    Friend WithEvents btn_start As Button
    Friend WithEvents lbl_title As Label
End Class
