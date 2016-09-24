<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_LongDistanceCalls
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
        Me.btn_Clear = New System.Windows.Forms.Button()
        Me.btn_Exit = New System.Windows.Forms.Button()
        Me.rdo_Daytime = New System.Windows.Forms.RadioButton()
        Me.grb_CallRates = New System.Windows.Forms.GroupBox()
        Me.rdo_OffTime = New System.Windows.Forms.RadioButton()
        Me.rdo_Evening = New System.Windows.Forms.RadioButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btn_CalculateCharges = New System.Windows.Forms.Button()
        Me.grb_Email = New System.Windows.Forms.GroupBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lbl_EnterEmail = New System.Windows.Forms.Label()
        Me.txt_ReEmail = New System.Windows.Forms.TextBox()
        Me.txt_Email = New System.Windows.Forms.TextBox()
        Me.lbl_Output = New System.Windows.Forms.Label()
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.txt_CallMinutes = New System.Windows.Forms.TextBox()
        Me.grb_CallRates.SuspendLayout()
        Me.grb_Email.SuspendLayout()
        Me.SuspendLayout()
        '
        'btn_Clear
        '
        Me.btn_Clear.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btn_Clear.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Clear.Location = New System.Drawing.Point(124, 329)
        Me.btn_Clear.Name = "btn_Clear"
        Me.btn_Clear.Size = New System.Drawing.Size(85, 25)
        Me.btn_Clear.TabIndex = 4
        Me.btn_Clear.Text = "&Clear"
        Me.btn_Clear.UseVisualStyleBackColor = True
        '
        'btn_Exit
        '
        Me.btn_Exit.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Exit.Location = New System.Drawing.Point(232, 329)
        Me.btn_Exit.Name = "btn_Exit"
        Me.btn_Exit.Size = New System.Drawing.Size(85, 27)
        Me.btn_Exit.TabIndex = 5
        Me.btn_Exit.Text = "E&xit"
        Me.btn_Exit.UseVisualStyleBackColor = True
        '
        'rdo_Daytime
        '
        Me.rdo_Daytime.AutoSize = True
        Me.rdo_Daytime.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdo_Daytime.Location = New System.Drawing.Point(23, 28)
        Me.rdo_Daytime.Name = "rdo_Daytime"
        Me.rdo_Daytime.Size = New System.Drawing.Size(218, 20)
        Me.rdo_Daytime.TabIndex = 0
        Me.rdo_Daytime.Text = "&Daytime Rate  ($0.07 per minute)"
        Me.rdo_Daytime.UseVisualStyleBackColor = True
        '
        'grb_CallRates
        '
        Me.grb_CallRates.Controls.Add(Me.rdo_OffTime)
        Me.grb_CallRates.Controls.Add(Me.rdo_Evening)
        Me.grb_CallRates.Controls.Add(Me.rdo_Daytime)
        Me.grb_CallRates.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grb_CallRates.Location = New System.Drawing.Point(8, 12)
        Me.grb_CallRates.Name = "grb_CallRates"
        Me.grb_CallRates.Size = New System.Drawing.Size(309, 122)
        Me.grb_CallRates.TabIndex = 3
        Me.grb_CallRates.TabStop = False
        Me.grb_CallRates.Text = "Selcet rate"
        '
        'rdo_OffTime
        '
        Me.rdo_OffTime.AutoSize = True
        Me.rdo_OffTime.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdo_OffTime.Location = New System.Drawing.Point(22, 80)
        Me.rdo_OffTime.Name = "rdo_OffTime"
        Me.rdo_OffTime.Size = New System.Drawing.Size(216, 20)
        Me.rdo_OffTime.TabIndex = 2
        Me.rdo_OffTime.Text = "&Off-Time Rate ($0.05 per minute)"
        Me.rdo_OffTime.UseVisualStyleBackColor = True
        '
        'rdo_Evening
        '
        Me.rdo_Evening.AutoSize = True
        Me.rdo_Evening.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdo_Evening.Location = New System.Drawing.Point(22, 54)
        Me.rdo_Evening.Name = "rdo_Evening"
        Me.rdo_Evening.Size = New System.Drawing.Size(217, 20)
        Me.rdo_Evening.TabIndex = 1
        Me.rdo_Evening.Text = "&Evening Rate  ($0.12 per minute)"
        Me.rdo_Evening.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(37, 157)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(91, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Enter Minute&s:"
        '
        'btn_CalculateCharges
        '
        Me.btn_CalculateCharges.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_CalculateCharges.Location = New System.Drawing.Point(12, 329)
        Me.btn_CalculateCharges.Name = "btn_CalculateCharges"
        Me.btn_CalculateCharges.Size = New System.Drawing.Size(85, 25)
        Me.btn_CalculateCharges.TabIndex = 3
        Me.btn_CalculateCharges.Text = "C&alculate "
        Me.btn_CalculateCharges.UseVisualStyleBackColor = True
        '
        'grb_Email
        '
        Me.grb_Email.Controls.Add(Me.Label2)
        Me.grb_Email.Controls.Add(Me.lbl_EnterEmail)
        Me.grb_Email.Controls.Add(Me.txt_ReEmail)
        Me.grb_Email.Controls.Add(Me.txt_Email)
        Me.grb_Email.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grb_Email.Location = New System.Drawing.Point(12, 202)
        Me.grb_Email.Name = "grb_Email"
        Me.grb_Email.Size = New System.Drawing.Size(309, 86)
        Me.grb_Email.TabIndex = 1
        Me.grb_Email.TabStop = False
        Me.grb_Email.Text = "Enter email info"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(15, 50)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(101, 16)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "&Re-Enter Email:"
        '
        'lbl_EnterEmail
        '
        Me.lbl_EnterEmail.AutoSize = True
        Me.lbl_EnterEmail.Location = New System.Drawing.Point(37, 22)
        Me.lbl_EnterEmail.Name = "lbl_EnterEmail"
        Me.lbl_EnterEmail.Size = New System.Drawing.Size(79, 16)
        Me.lbl_EnterEmail.TabIndex = 1
        Me.lbl_EnterEmail.Text = "Enter E&mail:"
        '
        'txt_ReEmail
        '
        Me.txt_ReEmail.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_ReEmail.Location = New System.Drawing.Point(122, 47)
        Me.txt_ReEmail.Name = "txt_ReEmail"
        Me.txt_ReEmail.Size = New System.Drawing.Size(178, 22)
        Me.txt_ReEmail.TabIndex = 2
        '
        'txt_Email
        '
        Me.txt_Email.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_Email.Location = New System.Drawing.Point(122, 17)
        Me.txt_Email.Name = "txt_Email"
        Me.txt_Email.Size = New System.Drawing.Size(178, 22)
        Me.txt_Email.TabIndex = 1
        '
        'lbl_Output
        '
        Me.lbl_Output.AutoSize = True
        Me.lbl_Output.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Output.Location = New System.Drawing.Point(12, 367)
        Me.lbl_Output.Name = "lbl_Output"
        Me.lbl_Output.Size = New System.Drawing.Size(67, 16)
        Me.lbl_Output.TabIndex = 6
        Me.lbl_Output.Text = "lbl_Output"
        '
        'txt_CallMinutes
        '
        Me.txt_CallMinutes.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_CallMinutes.Location = New System.Drawing.Point(134, 154)
        Me.txt_CallMinutes.Name = "txt_CallMinutes"
        Me.txt_CallMinutes.Size = New System.Drawing.Size(178, 22)
        Me.txt_CallMinutes.TabIndex = 0
        '
        'frm_LongDistanceCalls
        '
        Me.AcceptButton = Me.btn_CalculateCharges
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btn_Clear
        Me.ClientSize = New System.Drawing.Size(327, 361)
        Me.Controls.Add(Me.lbl_Output)
        Me.Controls.Add(Me.grb_Email)
        Me.Controls.Add(Me.btn_CalculateCharges)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txt_CallMinutes)
        Me.Controls.Add(Me.grb_CallRates)
        Me.Controls.Add(Me.btn_Exit)
        Me.Controls.Add(Me.btn_Clear)
        Me.Name = "frm_LongDistanceCalls"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Long Distance Calls By Tyler Hunt"
        Me.grb_CallRates.ResumeLayout(False)
        Me.grb_CallRates.PerformLayout()
        Me.grb_Email.ResumeLayout(False)
        Me.grb_Email.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btn_Clear As Button
    Friend WithEvents btn_Exit As Button
    Friend WithEvents rdo_Daytime As RadioButton
    Friend WithEvents grb_CallRates As GroupBox
    Friend WithEvents rdo_OffTime As RadioButton
    Friend WithEvents rdo_Evening As RadioButton
    Friend WithEvents Label1 As Label
    Friend WithEvents btn_CalculateCharges As Button
    Friend WithEvents grb_Email As GroupBox
    Friend WithEvents Label2 As Label
    Friend WithEvents lbl_EnterEmail As Label
    Friend WithEvents txt_ReEmail As TextBox
    Friend WithEvents txt_Email As TextBox
    Friend WithEvents lbl_Output As Label
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents txt_CallMinutes As TextBox
End Class
