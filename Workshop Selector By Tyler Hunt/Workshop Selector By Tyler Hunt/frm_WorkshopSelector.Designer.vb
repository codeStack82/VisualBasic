<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TylerHunt_WorkshopSelector
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
        Me.components = New System.ComponentModel.Container()
        Me.gb_Workshop = New System.Windows.Forms.GroupBox()
        Me.gb_Location = New System.Windows.Forms.GroupBox()
        Me.gb_Costs = New System.Windows.Forms.GroupBox()
        Me.btn_AddWorkshop = New System.Windows.Forms.Button()
        Me.btn_CalcTotal = New System.Windows.Forms.Button()
        Me.btn_Reset = New System.Windows.Forms.Button()
        Me.btn_Exit = New System.Windows.Forms.Button()
        Me.lbl_TotalCost = New System.Windows.Forms.Label()
        Me.txt_TotalCost = New System.Windows.Forms.TextBox()
        Me.tp_FormToolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.lbx_Workshop = New System.Windows.Forms.ListBox()
        Me.lbx_Location = New System.Windows.Forms.ListBox()
        Me.lbx_Costs = New System.Windows.Forms.ListBox()
        Me.gb_Workshop.SuspendLayout()
        Me.gb_Location.SuspendLayout()
        Me.gb_Costs.SuspendLayout()
        Me.SuspendLayout()
        '
        'gb_Workshop
        '
        Me.gb_Workshop.Controls.Add(Me.lbx_Workshop)
        Me.gb_Workshop.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gb_Workshop.Location = New System.Drawing.Point(12, 12)
        Me.gb_Workshop.Name = "gb_Workshop"
        Me.gb_Workshop.Size = New System.Drawing.Size(201, 196)
        Me.gb_Workshop.TabIndex = 0
        Me.gb_Workshop.TabStop = False
        Me.gb_Workshop.Text = "Pick a Workshop"
        '
        'gb_Location
        '
        Me.gb_Location.Controls.Add(Me.lbx_Location)
        Me.gb_Location.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gb_Location.Location = New System.Drawing.Point(219, 13)
        Me.gb_Location.Name = "gb_Location"
        Me.gb_Location.Size = New System.Drawing.Size(200, 195)
        Me.gb_Location.TabIndex = 1
        Me.gb_Location.TabStop = False
        Me.gb_Location.Text = "Pick a Location"
        '
        'gb_Costs
        '
        Me.gb_Costs.Controls.Add(Me.lbx_Costs)
        Me.gb_Costs.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gb_Costs.Location = New System.Drawing.Point(425, 12)
        Me.gb_Costs.Name = "gb_Costs"
        Me.gb_Costs.Size = New System.Drawing.Size(200, 195)
        Me.gb_Costs.TabIndex = 2
        Me.gb_Costs.TabStop = False
        Me.gb_Costs.Text = "List of Costs"
        '
        'btn_AddWorkshop
        '
        Me.btn_AddWorkshop.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_AddWorkshop.Location = New System.Drawing.Point(12, 264)
        Me.btn_AddWorkshop.Name = "btn_AddWorkshop"
        Me.btn_AddWorkshop.Size = New System.Drawing.Size(148, 44)
        Me.btn_AddWorkshop.TabIndex = 3
        Me.btn_AddWorkshop.Text = "&Add Workshop"
        Me.tp_FormToolTip.SetToolTip(Me.btn_AddWorkshop, "Click to Add Workshop")
        Me.btn_AddWorkshop.UseVisualStyleBackColor = True
        '
        'btn_CalcTotal
        '
        Me.btn_CalcTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_CalcTotal.Location = New System.Drawing.Point(166, 264)
        Me.btn_CalcTotal.Name = "btn_CalcTotal"
        Me.btn_CalcTotal.Size = New System.Drawing.Size(161, 44)
        Me.btn_CalcTotal.TabIndex = 4
        Me.btn_CalcTotal.Text = "&Calculate Total"
        Me.tp_FormToolTip.SetToolTip(Me.btn_CalcTotal, "Click to calculate total costs")
        Me.btn_CalcTotal.UseVisualStyleBackColor = True
        '
        'btn_Reset
        '
        Me.btn_Reset.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btn_Reset.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Reset.Location = New System.Drawing.Point(333, 264)
        Me.btn_Reset.Name = "btn_Reset"
        Me.btn_Reset.Size = New System.Drawing.Size(143, 44)
        Me.btn_Reset.TabIndex = 5
        Me.btn_Reset.Text = "&Reset"
        Me.tp_FormToolTip.SetToolTip(Me.btn_Reset, "Click to Reset the Form")
        Me.btn_Reset.UseVisualStyleBackColor = True
        '
        'btn_Exit
        '
        Me.btn_Exit.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Exit.Location = New System.Drawing.Point(481, 264)
        Me.btn_Exit.Name = "btn_Exit"
        Me.btn_Exit.Size = New System.Drawing.Size(143, 44)
        Me.btn_Exit.TabIndex = 6
        Me.btn_Exit.Text = "&Exit"
        Me.tp_FormToolTip.SetToolTip(Me.btn_Exit, "Click to exit the Form")
        Me.btn_Exit.UseVisualStyleBackColor = True
        '
        'lbl_TotalCost
        '
        Me.lbl_TotalCost.AutoSize = True
        Me.lbl_TotalCost.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_TotalCost.Location = New System.Drawing.Point(329, 216)
        Me.lbl_TotalCost.Name = "lbl_TotalCost"
        Me.lbl_TotalCost.Size = New System.Drawing.Size(91, 20)
        Me.lbl_TotalCost.TabIndex = 7
        Me.lbl_TotalCost.Text = "Total Cost:"
        '
        'txt_TotalCost
        '
        Me.txt_TotalCost.Enabled = False
        Me.txt_TotalCost.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_TotalCost.Location = New System.Drawing.Point(431, 213)
        Me.txt_TotalCost.Name = "txt_TotalCost"
        Me.txt_TotalCost.Size = New System.Drawing.Size(194, 27)
        Me.txt_TotalCost.TabIndex = 8
        Me.tp_FormToolTip.SetToolTip(Me.txt_TotalCost, "Displays the total cost of the workshop")
        '
        'lbx_Workshop
        '
        Me.lbx_Workshop.FormattingEnabled = True
        Me.lbx_Workshop.ItemHeight = 20
        Me.lbx_Workshop.Items.AddRange(New Object() {"Handling Stress", "Time Management", "Supervision Skills", "Negotiation", "How to Interview"})
        Me.lbx_Workshop.Location = New System.Drawing.Point(7, 27)
        Me.lbx_Workshop.Name = "lbx_Workshop"
        Me.lbx_Workshop.Size = New System.Drawing.Size(188, 164)
        Me.lbx_Workshop.TabIndex = 0
        Me.tp_FormToolTip.SetToolTip(Me.lbx_Workshop, "Please select a workshop")
        '
        'lbx_Location
        '
        Me.lbx_Location.FormattingEnabled = True
        Me.lbx_Location.ItemHeight = 20
        Me.lbx_Location.Items.AddRange(New Object() {"Austin", "Chicago", "Dallas", "Orlando", "Phoenix", "Raleigh"})
        Me.lbx_Location.Location = New System.Drawing.Point(6, 25)
        Me.lbx_Location.Name = "lbx_Location"
        Me.lbx_Location.Size = New System.Drawing.Size(188, 164)
        Me.lbx_Location.TabIndex = 1
        Me.tp_FormToolTip.SetToolTip(Me.lbx_Location, "Please select a location")
        '
        'lbx_Costs
        '
        Me.lbx_Costs.FormattingEnabled = True
        Me.lbx_Costs.ItemHeight = 20
        Me.lbx_Costs.Location = New System.Drawing.Point(6, 25)
        Me.lbx_Costs.Name = "lbx_Costs"
        Me.lbx_Costs.Size = New System.Drawing.Size(188, 164)
        Me.lbx_Costs.TabIndex = 2
        Me.tp_FormToolTip.SetToolTip(Me.lbx_Costs, "Workshop cost details")
        '
        'TylerHunt_WorkshopSelector
        '
        Me.AcceptButton = Me.btn_AddWorkshop
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btn_Reset
        Me.ClientSize = New System.Drawing.Size(632, 318)
        Me.Controls.Add(Me.txt_TotalCost)
        Me.Controls.Add(Me.lbl_TotalCost)
        Me.Controls.Add(Me.btn_Exit)
        Me.Controls.Add(Me.btn_Reset)
        Me.Controls.Add(Me.btn_CalcTotal)
        Me.Controls.Add(Me.btn_AddWorkshop)
        Me.Controls.Add(Me.gb_Costs)
        Me.Controls.Add(Me.gb_Location)
        Me.Controls.Add(Me.gb_Workshop)
        Me.MaximumSize = New System.Drawing.Size(650, 365)
        Me.MinimumSize = New System.Drawing.Size(650, 365)
        Me.Name = "TylerHunt_WorkshopSelector"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Workshop Selector By Tyler Hunt"
        Me.gb_Workshop.ResumeLayout(False)
        Me.gb_Location.ResumeLayout(False)
        Me.gb_Costs.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents gb_Workshop As GroupBox
    Friend WithEvents gb_Location As GroupBox
    Friend WithEvents gb_Costs As GroupBox
    Friend WithEvents btn_AddWorkshop As Button
    Friend WithEvents btn_CalcTotal As Button
    Friend WithEvents btn_Reset As Button
    Friend WithEvents btn_Exit As Button
    Friend WithEvents lbl_TotalCost As Label
    Friend WithEvents txt_TotalCost As TextBox
    Friend WithEvents tp_FormToolTip As ToolTip
    Friend WithEvents lbx_Workshop As ListBox
    Friend WithEvents lbx_Location As ListBox
    Friend WithEvents lbx_Costs As ListBox
End Class
