<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_orderView_a194333
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
        Me.btn_makeOrder = New System.Windows.Forms.Button()
        Me.btn_viewOrder = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btn_back
        '
        Me.btn_back.Location = New System.Drawing.Point(12, 12)
        Me.btn_back.Name = "btn_back"
        Me.btn_back.Size = New System.Drawing.Size(89, 36)
        Me.btn_back.TabIndex = 0
        Me.btn_back.Text = "Back"
        Me.btn_back.UseVisualStyleBackColor = True
        '
        'btn_makeOrder
        '
        Me.btn_makeOrder.Location = New System.Drawing.Point(202, 202)
        Me.btn_makeOrder.Name = "btn_makeOrder"
        Me.btn_makeOrder.Size = New System.Drawing.Size(139, 55)
        Me.btn_makeOrder.TabIndex = 1
        Me.btn_makeOrder.Text = "Make Order"
        Me.btn_makeOrder.UseVisualStyleBackColor = True
        '
        'btn_viewOrder
        '
        Me.btn_viewOrder.Location = New System.Drawing.Point(447, 202)
        Me.btn_viewOrder.Name = "btn_viewOrder"
        Me.btn_viewOrder.Size = New System.Drawing.Size(131, 55)
        Me.btn_viewOrder.TabIndex = 2
        Me.btn_viewOrder.Text = "View Order"
        Me.btn_viewOrder.UseVisualStyleBackColor = True
        '
        'frm_orderView_a194333
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.prj_kryptoseven_a194333.My.Resources.Resources.Untitled_design__2_
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btn_viewOrder)
        Me.Controls.Add(Me.btn_makeOrder)
        Me.Controls.Add(Me.btn_back)
        Me.Name = "frm_orderView_a194333"
        Me.Text = "frm_orderView_a194333"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btn_back As Button
    Friend WithEvents btn_makeOrder As Button
    Friend WithEvents btn_viewOrder As Button
End Class
