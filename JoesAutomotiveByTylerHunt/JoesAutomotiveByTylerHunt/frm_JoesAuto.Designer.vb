<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_JoesAuto
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
        Me.btn_CalcTotal = New System.Windows.Forms.Button()
        Me.btn_Clear = New System.Windows.Forms.Button()
        Me.btn_Exit = New System.Windows.Forms.Button()
        Me.gb_OilLube = New System.Windows.Forms.GroupBox()
        Me.gb_Flushes = New System.Windows.Forms.GroupBox()
        Me.cb_OilChange = New System.Windows.Forms.CheckBox()
        Me.cb_LubeJob = New System.Windows.Forms.CheckBox()
        Me.cb_TransFlush = New System.Windows.Forms.CheckBox()
        Me.cb_RadFlush = New System.Windows.Forms.CheckBox()
        Me.gb_Misc = New System.Windows.Forms.GroupBox()
        Me.cb_ReplMuffler = New System.Windows.Forms.CheckBox()
        Me.cb_Inspection = New System.Windows.Forms.CheckBox()
        Me.cb_TireRotate = New System.Windows.Forms.CheckBox()
        Me.gb_PartsLabor = New System.Windows.Forms.GroupBox()
        Me.lbl_Parts = New System.Windows.Forms.Label()
        Me.lbl_Labor = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.gb_Summary = New System.Windows.Forms.GroupBox()
        Me.lbl_ServLabor = New System.Windows.Forms.Label()
        Me.lbl_SummPrts = New System.Windows.Forms.Label()
        Me.lbl_SummTax = New System.Windows.Forms.Label()
        Me.lbl_TotalFees = New System.Windows.Forms.Label()
        Me.txt_ServLabor = New System.Windows.Forms.TextBox()
        Me.txt_PartsTotal = New System.Windows.Forms.TextBox()
        Me.txt_PartsTax = New System.Windows.Forms.TextBox()
        Me.txt_TotalFees = New System.Windows.Forms.TextBox()
        Me.txt_PartsCost = New System.Windows.Forms.TextBox()
        Me.txt_LaborCost = New System.Windows.Forms.TextBox()
        Me.gb_OilLube.SuspendLayout()
        Me.gb_Flushes.SuspendLayout()
        Me.gb_Misc.SuspendLayout()
        Me.gb_PartsLabor.SuspendLayout()
        Me.gb_Summary.SuspendLayout()
        Me.SuspendLayout()
        '
        'btn_CalcTotal
        '
        Me.btn_CalcTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.125!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_CalcTotal.Location = New System.Drawing.Point(17, 856)
        Me.btn_CalcTotal.Name = "btn_CalcTotal"
        Me.btn_CalcTotal.Size = New System.Drawing.Size(237, 68)
        Me.btn_CalcTotal.TabIndex = 0
        Me.btn_CalcTotal.Text = "&Calculate Total"
        Me.btn_CalcTotal.UseVisualStyleBackColor = True
        '
        'btn_Clear
        '
        Me.btn_Clear.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btn_Clear.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.125!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Clear.Location = New System.Drawing.Point(424, 856)
        Me.btn_Clear.Name = "btn_Clear"
        Me.btn_Clear.Size = New System.Drawing.Size(237, 68)
        Me.btn_Clear.TabIndex = 1
        Me.btn_Clear.Text = "C&lear"
        Me.btn_Clear.UseVisualStyleBackColor = True
        '
        'btn_Exit
        '
        Me.btn_Exit.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.125!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Exit.Location = New System.Drawing.Point(845, 856)
        Me.btn_Exit.Name = "btn_Exit"
        Me.btn_Exit.Size = New System.Drawing.Size(237, 68)
        Me.btn_Exit.TabIndex = 2
        Me.btn_Exit.Text = "&Exit"
        Me.btn_Exit.UseVisualStyleBackColor = True
        '
        'gb_OilLube
        '
        Me.gb_OilLube.Controls.Add(Me.cb_LubeJob)
        Me.gb_OilLube.Controls.Add(Me.cb_OilChange)
        Me.gb_OilLube.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.125!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gb_OilLube.Location = New System.Drawing.Point(12, 12)
        Me.gb_OilLube.Name = "gb_OilLube"
        Me.gb_OilLube.Size = New System.Drawing.Size(526, 192)
        Me.gb_OilLube.TabIndex = 3
        Me.gb_OilLube.TabStop = False
        Me.gb_OilLube.Text = "Oil and Lube"
        '
        'gb_Flushes
        '
        Me.gb_Flushes.Controls.Add(Me.cb_TransFlush)
        Me.gb_Flushes.Controls.Add(Me.cb_RadFlush)
        Me.gb_Flushes.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.125!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gb_Flushes.Location = New System.Drawing.Point(551, 12)
        Me.gb_Flushes.Name = "gb_Flushes"
        Me.gb_Flushes.Size = New System.Drawing.Size(526, 192)
        Me.gb_Flushes.TabIndex = 4
        Me.gb_Flushes.TabStop = False
        Me.gb_Flushes.Text = "Flushes"
        '
        'cb_OilChange
        '
        Me.cb_OilChange.AutoSize = True
        Me.cb_OilChange.Location = New System.Drawing.Point(36, 50)
        Me.cb_OilChange.Name = "cb_OilChange"
        Me.cb_OilChange.Size = New System.Drawing.Size(443, 35)
        Me.cb_OilChange.TabIndex = 0
        Me.cb_OilChange.Text = "Oil Change                       ($26.00)"
        Me.cb_OilChange.UseVisualStyleBackColor = True
        '
        'cb_LubeJob
        '
        Me.cb_LubeJob.AutoSize = True
        Me.cb_LubeJob.Location = New System.Drawing.Point(36, 114)
        Me.cb_LubeJob.Name = "cb_LubeJob"
        Me.cb_LubeJob.Size = New System.Drawing.Size(440, 35)
        Me.cb_LubeJob.TabIndex = 1
        Me.cb_LubeJob.Text = "Lube Job                          ($18.00)"
        Me.cb_LubeJob.UseVisualStyleBackColor = True
        '
        'cb_TransFlush
        '
        Me.cb_TransFlush.AutoSize = True
        Me.cb_TransFlush.Location = New System.Drawing.Point(33, 114)
        Me.cb_TransFlush.Name = "cb_TransFlush"
        Me.cb_TransFlush.Size = New System.Drawing.Size(439, 35)
        Me.cb_TransFlush.TabIndex = 3
        Me.cb_TransFlush.Text = "Transmission Flush        ($26.00)"
        Me.cb_TransFlush.UseVisualStyleBackColor = True
        '
        'cb_RadFlush
        '
        Me.cb_RadFlush.AutoSize = True
        Me.cb_RadFlush.Location = New System.Drawing.Point(33, 50)
        Me.cb_RadFlush.Name = "cb_RadFlush"
        Me.cb_RadFlush.Size = New System.Drawing.Size(443, 35)
        Me.cb_RadFlush.TabIndex = 2
        Me.cb_RadFlush.Text = "Radiator Flush                 ($30.00)"
        Me.cb_RadFlush.UseVisualStyleBackColor = True
        '
        'gb_Misc
        '
        Me.gb_Misc.Controls.Add(Me.cb_TireRotate)
        Me.gb_Misc.Controls.Add(Me.cb_ReplMuffler)
        Me.gb_Misc.Controls.Add(Me.cb_Inspection)
        Me.gb_Misc.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.125!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gb_Misc.Location = New System.Drawing.Point(12, 210)
        Me.gb_Misc.Name = "gb_Misc"
        Me.gb_Misc.Size = New System.Drawing.Size(526, 266)
        Me.gb_Misc.TabIndex = 5
        Me.gb_Misc.TabStop = False
        Me.gb_Misc.Text = "Misc."
        '
        'cb_ReplMuffler
        '
        Me.cb_ReplMuffler.AutoSize = True
        Me.cb_ReplMuffler.Location = New System.Drawing.Point(33, 114)
        Me.cb_ReplMuffler.Name = "cb_ReplMuffler"
        Me.cb_ReplMuffler.Size = New System.Drawing.Size(457, 35)
        Me.cb_ReplMuffler.TabIndex = 3
        Me.cb_ReplMuffler.Text = "Replace Muffler               ($100.00)"
        Me.cb_ReplMuffler.UseVisualStyleBackColor = True
        '
        'cb_Inspection
        '
        Me.cb_Inspection.AutoSize = True
        Me.cb_Inspection.Location = New System.Drawing.Point(33, 50)
        Me.cb_Inspection.Name = "cb_Inspection"
        Me.cb_Inspection.Size = New System.Drawing.Size(447, 35)
        Me.cb_Inspection.TabIndex = 2
        Me.cb_Inspection.Text = "Inspection                         ($15.00)"
        Me.cb_Inspection.UseVisualStyleBackColor = True
        '
        'cb_TireRotate
        '
        Me.cb_TireRotate.AutoSize = True
        Me.cb_TireRotate.Location = New System.Drawing.Point(33, 181)
        Me.cb_TireRotate.Name = "cb_TireRotate"
        Me.cb_TireRotate.Size = New System.Drawing.Size(443, 35)
        Me.cb_TireRotate.TabIndex = 4
        Me.cb_TireRotate.Text = "Tire Rotation                    ($20.00)"
        Me.cb_TireRotate.UseVisualStyleBackColor = True
        '
        'gb_PartsLabor
        '
        Me.gb_PartsLabor.Controls.Add(Me.txt_LaborCost)
        Me.gb_PartsLabor.Controls.Add(Me.txt_PartsCost)
        Me.gb_PartsLabor.Controls.Add(Me.Label1)
        Me.gb_PartsLabor.Controls.Add(Me.lbl_Labor)
        Me.gb_PartsLabor.Controls.Add(Me.lbl_Parts)
        Me.gb_PartsLabor.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.125!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gb_PartsLabor.Location = New System.Drawing.Point(551, 210)
        Me.gb_PartsLabor.Name = "gb_PartsLabor"
        Me.gb_PartsLabor.Size = New System.Drawing.Size(526, 266)
        Me.gb_PartsLabor.TabIndex = 6
        Me.gb_PartsLabor.TabStop = False
        Me.gb_PartsLabor.Text = "Parts and Labor"
        '
        'lbl_Parts
        '
        Me.lbl_Parts.AutoSize = True
        Me.lbl_Parts.Location = New System.Drawing.Point(20, 54)
        Me.lbl_Parts.Name = "lbl_Parts"
        Me.lbl_Parts.Size = New System.Drawing.Size(132, 31)
        Me.lbl_Parts.TabIndex = 0
        Me.lbl_Parts.Text = "Parts ( $ )"
        '
        'lbl_Labor
        '
        Me.lbl_Labor.AutoSize = True
        Me.lbl_Labor.Location = New System.Drawing.Point(6, 115)
        Me.lbl_Labor.Name = "lbl_Labor"
        Me.lbl_Labor.Size = New System.Drawing.Size(146, 31)
        Me.lbl_Labor.TabIndex = 1
        Me.lbl_Labor.Text = "Labor (hrs)"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(317, 118)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(196, 29)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "($20.00 per hour)"
        '
        'gb_Summary
        '
        Me.gb_Summary.Controls.Add(Me.txt_TotalFees)
        Me.gb_Summary.Controls.Add(Me.txt_PartsTax)
        Me.gb_Summary.Controls.Add(Me.txt_PartsTotal)
        Me.gb_Summary.Controls.Add(Me.txt_ServLabor)
        Me.gb_Summary.Controls.Add(Me.lbl_TotalFees)
        Me.gb_Summary.Controls.Add(Me.lbl_SummTax)
        Me.gb_Summary.Controls.Add(Me.lbl_SummPrts)
        Me.gb_Summary.Controls.Add(Me.lbl_ServLabor)
        Me.gb_Summary.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.125!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gb_Summary.Location = New System.Drawing.Point(12, 483)
        Me.gb_Summary.Name = "gb_Summary"
        Me.gb_Summary.Size = New System.Drawing.Size(1065, 320)
        Me.gb_Summary.TabIndex = 7
        Me.gb_Summary.TabStop = False
        Me.gb_Summary.Text = "Summary"
        '
        'lbl_ServLabor
        '
        Me.lbl_ServLabor.AutoSize = True
        Me.lbl_ServLabor.Location = New System.Drawing.Point(247, 51)
        Me.lbl_ServLabor.Name = "lbl_ServLabor"
        Me.lbl_ServLabor.Size = New System.Drawing.Size(233, 31)
        Me.lbl_ServLabor.TabIndex = 1
        Me.lbl_ServLabor.Text = "Service and Labor"
        '
        'lbl_SummPrts
        '
        Me.lbl_SummPrts.AutoSize = True
        Me.lbl_SummPrts.Location = New System.Drawing.Point(398, 117)
        Me.lbl_SummPrts.Name = "lbl_SummPrts"
        Me.lbl_SummPrts.Size = New System.Drawing.Size(78, 31)
        Me.lbl_SummPrts.TabIndex = 2
        Me.lbl_SummPrts.Text = "Parts"
        '
        'lbl_SummTax
        '
        Me.lbl_SummTax.AutoSize = True
        Me.lbl_SummTax.Location = New System.Drawing.Point(280, 186)
        Me.lbl_SummTax.Name = "lbl_SummTax"
        Me.lbl_SummTax.Size = New System.Drawing.Size(199, 31)
        Me.lbl_SummTax.TabIndex = 3
        Me.lbl_SummTax.Text = "Tax ( on Parts )"
        '
        'lbl_TotalFees
        '
        Me.lbl_TotalFees.AutoSize = True
        Me.lbl_TotalFees.Location = New System.Drawing.Point(333, 258)
        Me.lbl_TotalFees.Name = "lbl_TotalFees"
        Me.lbl_TotalFees.Size = New System.Drawing.Size(143, 31)
        Me.lbl_TotalFees.TabIndex = 4
        Me.lbl_TotalFees.Text = "Total Fees"
        '
        'txt_ServLabor
        '
        Me.txt_ServLabor.Enabled = False
        Me.txt_ServLabor.Location = New System.Drawing.Point(509, 51)
        Me.txt_ServLabor.Name = "txt_ServLabor"
        Me.txt_ServLabor.Size = New System.Drawing.Size(195, 38)
        Me.txt_ServLabor.TabIndex = 5
        '
        'txt_PartsTotal
        '
        Me.txt_PartsTotal.Enabled = False
        Me.txt_PartsTotal.Location = New System.Drawing.Point(509, 117)
        Me.txt_PartsTotal.Name = "txt_PartsTotal"
        Me.txt_PartsTotal.Size = New System.Drawing.Size(195, 38)
        Me.txt_PartsTotal.TabIndex = 6
        '
        'txt_PartsTax
        '
        Me.txt_PartsTax.Enabled = False
        Me.txt_PartsTax.Location = New System.Drawing.Point(509, 179)
        Me.txt_PartsTax.Name = "txt_PartsTax"
        Me.txt_PartsTax.Size = New System.Drawing.Size(195, 38)
        Me.txt_PartsTax.TabIndex = 7
        '
        'txt_TotalFees
        '
        Me.txt_TotalFees.Enabled = False
        Me.txt_TotalFees.Location = New System.Drawing.Point(509, 251)
        Me.txt_TotalFees.Name = "txt_TotalFees"
        Me.txt_TotalFees.Size = New System.Drawing.Size(195, 38)
        Me.txt_TotalFees.TabIndex = 8
        '
        'txt_PartsCost
        '
        Me.txt_PartsCost.Location = New System.Drawing.Point(158, 54)
        Me.txt_PartsCost.Name = "txt_PartsCost"
        Me.txt_PartsCost.Size = New System.Drawing.Size(153, 38)
        Me.txt_PartsCost.TabIndex = 9
        '
        'txt_LaborCost
        '
        Me.txt_LaborCost.Location = New System.Drawing.Point(158, 111)
        Me.txt_LaborCost.Name = "txt_LaborCost"
        Me.txt_LaborCost.Size = New System.Drawing.Size(153, 38)
        Me.txt_LaborCost.TabIndex = 10
        '
        'frm_JoesAuto
        '
        Me.AcceptButton = Me.btn_CalcTotal
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btn_Clear
        Me.ClientSize = New System.Drawing.Size(1089, 959)
        Me.Controls.Add(Me.gb_Summary)
        Me.Controls.Add(Me.gb_PartsLabor)
        Me.Controls.Add(Me.gb_Misc)
        Me.Controls.Add(Me.gb_Flushes)
        Me.Controls.Add(Me.gb_OilLube)
        Me.Controls.Add(Me.btn_Exit)
        Me.Controls.Add(Me.btn_Clear)
        Me.Controls.Add(Me.btn_CalcTotal)
        Me.MaximumSize = New System.Drawing.Size(1115, 1030)
        Me.MinimumSize = New System.Drawing.Size(1115, 1030)
        Me.Name = "frm_JoesAuto"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Joe's Automotive By Tyler Hunt"
        Me.gb_OilLube.ResumeLayout(False)
        Me.gb_OilLube.PerformLayout()
        Me.gb_Flushes.ResumeLayout(False)
        Me.gb_Flushes.PerformLayout()
        Me.gb_Misc.ResumeLayout(False)
        Me.gb_Misc.PerformLayout()
        Me.gb_PartsLabor.ResumeLayout(False)
        Me.gb_PartsLabor.PerformLayout()
        Me.gb_Summary.ResumeLayout(False)
        Me.gb_Summary.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btn_CalcTotal As Button
    Friend WithEvents btn_Clear As Button
    Friend WithEvents btn_Exit As Button
    Friend WithEvents gb_OilLube As GroupBox
    Friend WithEvents cb_LubeJob As CheckBox
    Friend WithEvents cb_OilChange As CheckBox
    Friend WithEvents gb_Flushes As GroupBox
    Friend WithEvents cb_TransFlush As CheckBox
    Friend WithEvents cb_RadFlush As CheckBox
    Friend WithEvents gb_Misc As GroupBox
    Friend WithEvents cb_TireRotate As CheckBox
    Friend WithEvents cb_ReplMuffler As CheckBox
    Friend WithEvents cb_Inspection As CheckBox
    Friend WithEvents gb_PartsLabor As GroupBox
    Friend WithEvents txt_LaborCost As TextBox
    Friend WithEvents txt_PartsCost As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents lbl_Labor As Label
    Friend WithEvents lbl_Parts As Label
    Friend WithEvents gb_Summary As GroupBox
    Friend WithEvents txt_TotalFees As TextBox
    Friend WithEvents txt_PartsTax As TextBox
    Friend WithEvents txt_PartsTotal As TextBox
    Friend WithEvents txt_ServLabor As TextBox
    Friend WithEvents lbl_TotalFees As Label
    Friend WithEvents lbl_SummTax As Label
    Friend WithEvents lbl_SummPrts As Label
    Friend WithEvents lbl_ServLabor As Label
End Class
