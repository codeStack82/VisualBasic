<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_TheaterRevenue
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
        Me.grb_AdultTicketSales = New System.Windows.Forms.GroupBox()
        Me.txt_AdultTicketsSold = New System.Windows.Forms.TextBox()
        Me.txt_AdultPricePerTicket = New System.Windows.Forms.TextBox()
        Me.lbl_AdultTicketsSold = New System.Windows.Forms.Label()
        Me.lbl_AdultPricePerTicket = New System.Windows.Forms.Label()
        Me.grb_ChildTicketSales = New System.Windows.Forms.GroupBox()
        Me.txt_ChildTicketsSold = New System.Windows.Forms.TextBox()
        Me.txt_ChildPricePerTicket = New System.Windows.Forms.TextBox()
        Me.lbl_ChildPricePerTicketSold = New System.Windows.Forms.Label()
        Me.lbl_ChildPriceperTicket = New System.Windows.Forms.Label()
        Me.grb_GrossTicketRevenue = New System.Windows.Forms.GroupBox()
        Me.txt_TotalGrossRev = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txt_ChildGrossTicketSales = New System.Windows.Forms.TextBox()
        Me.txt_AdultGrossTicketSales = New System.Windows.Forms.TextBox()
        Me.lbl_ChildTicketSales = New System.Windows.Forms.Label()
        Me.lbl_AdultTicketSales = New System.Windows.Forms.Label()
        Me.grb_NetTicketRevenue = New System.Windows.Forms.GroupBox()
        Me.txt_TotalNetTicketSales = New System.Windows.Forms.TextBox()
        Me.lbl_TotalNetRev = New System.Windows.Forms.Label()
        Me.txt_ChildNetTicketSales = New System.Windows.Forms.TextBox()
        Me.txt_AdultNetTicketSales = New System.Windows.Forms.TextBox()
        Me.lbl_ChildNetSales = New System.Windows.Forms.Label()
        Me.lbl_AdultNetSales = New System.Windows.Forms.Label()
        Me.btn_CalcTicketRevenue = New System.Windows.Forms.Button()
        Me.btn_Clear = New System.Windows.Forms.Button()
        Me.btn_Exit = New System.Windows.Forms.Button()
        Me.lbl_DateTime = New System.Windows.Forms.Label()
        Me.lbl_TotalTicketSoldToday = New System.Windows.Forms.Label()
        Me.btn_ClearAll = New System.Windows.Forms.Button()
        Me.grb_AdultTicketSales.SuspendLayout()
        Me.grb_ChildTicketSales.SuspendLayout()
        Me.grb_GrossTicketRevenue.SuspendLayout()
        Me.grb_NetTicketRevenue.SuspendLayout()
        Me.SuspendLayout()
        '
        'grb_AdultTicketSales
        '
        Me.grb_AdultTicketSales.Controls.Add(Me.txt_AdultTicketsSold)
        Me.grb_AdultTicketSales.Controls.Add(Me.txt_AdultPricePerTicket)
        Me.grb_AdultTicketSales.Controls.Add(Me.lbl_AdultTicketsSold)
        Me.grb_AdultTicketSales.Controls.Add(Me.lbl_AdultPricePerTicket)
        Me.grb_AdultTicketSales.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grb_AdultTicketSales.Location = New System.Drawing.Point(12, 41)
        Me.grb_AdultTicketSales.Name = "grb_AdultTicketSales"
        Me.grb_AdultTicketSales.Size = New System.Drawing.Size(389, 102)
        Me.grb_AdultTicketSales.TabIndex = 0
        Me.grb_AdultTicketSales.TabStop = False
        Me.grb_AdultTicketSales.Text = "Adult Ticket Sales"
        '
        'txt_AdultTicketsSold
        '
        Me.txt_AdultTicketsSold.Location = New System.Drawing.Point(222, 59)
        Me.txt_AdultTicketsSold.Name = "txt_AdultTicketsSold"
        Me.txt_AdultTicketsSold.Size = New System.Drawing.Size(161, 27)
        Me.txt_AdultTicketsSold.TabIndex = 1
        '
        'txt_AdultPricePerTicket
        '
        Me.txt_AdultPricePerTicket.Location = New System.Drawing.Point(222, 26)
        Me.txt_AdultPricePerTicket.Name = "txt_AdultPricePerTicket"
        Me.txt_AdultPricePerTicket.Size = New System.Drawing.Size(161, 27)
        Me.txt_AdultPricePerTicket.TabIndex = 0
        '
        'lbl_AdultTicketsSold
        '
        Me.lbl_AdultTicketsSold.AutoSize = True
        Me.lbl_AdultTicketsSold.Location = New System.Drawing.Point(88, 62)
        Me.lbl_AdultTicketsSold.Name = "lbl_AdultTicketsSold"
        Me.lbl_AdultTicketsSold.Size = New System.Drawing.Size(106, 20)
        Me.lbl_AdultTicketsSold.TabIndex = 3
        Me.lbl_AdultTicketsSold.Text = "&Tickets Sold:"
        '
        'lbl_AdultPricePerTicket
        '
        Me.lbl_AdultPricePerTicket.AutoSize = True
        Me.lbl_AdultPricePerTicket.Location = New System.Drawing.Point(60, 29)
        Me.lbl_AdultPricePerTicket.Name = "lbl_AdultPricePerTicket"
        Me.lbl_AdultPricePerTicket.Size = New System.Drawing.Size(134, 20)
        Me.lbl_AdultPricePerTicket.TabIndex = 1
        Me.lbl_AdultPricePerTicket.Text = "&Price Per Ticket:"
        '
        'grb_ChildTicketSales
        '
        Me.grb_ChildTicketSales.Controls.Add(Me.txt_ChildTicketsSold)
        Me.grb_ChildTicketSales.Controls.Add(Me.txt_ChildPricePerTicket)
        Me.grb_ChildTicketSales.Controls.Add(Me.lbl_ChildPricePerTicketSold)
        Me.grb_ChildTicketSales.Controls.Add(Me.lbl_ChildPriceperTicket)
        Me.grb_ChildTicketSales.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grb_ChildTicketSales.Location = New System.Drawing.Point(407, 41)
        Me.grb_ChildTicketSales.Name = "grb_ChildTicketSales"
        Me.grb_ChildTicketSales.Size = New System.Drawing.Size(387, 102)
        Me.grb_ChildTicketSales.TabIndex = 1
        Me.grb_ChildTicketSales.TabStop = False
        Me.grb_ChildTicketSales.Text = "Child Ticket Sales"
        '
        'txt_ChildTicketsSold
        '
        Me.txt_ChildTicketsSold.Location = New System.Drawing.Point(220, 59)
        Me.txt_ChildTicketsSold.Name = "txt_ChildTicketsSold"
        Me.txt_ChildTicketsSold.Size = New System.Drawing.Size(161, 27)
        Me.txt_ChildTicketsSold.TabIndex = 3
        '
        'txt_ChildPricePerTicket
        '
        Me.txt_ChildPricePerTicket.Location = New System.Drawing.Point(220, 26)
        Me.txt_ChildPricePerTicket.Name = "txt_ChildPricePerTicket"
        Me.txt_ChildPricePerTicket.Size = New System.Drawing.Size(161, 27)
        Me.txt_ChildPricePerTicket.TabIndex = 2
        '
        'lbl_ChildPricePerTicketSold
        '
        Me.lbl_ChildPricePerTicketSold.AutoSize = True
        Me.lbl_ChildPricePerTicketSold.Location = New System.Drawing.Point(86, 62)
        Me.lbl_ChildPricePerTicketSold.Name = "lbl_ChildPricePerTicketSold"
        Me.lbl_ChildPricePerTicketSold.Size = New System.Drawing.Size(106, 20)
        Me.lbl_ChildPricePerTicketSold.TabIndex = 2
        Me.lbl_ChildPricePerTicketSold.Text = "T&ickets Sold:"
        '
        'lbl_ChildPriceperTicket
        '
        Me.lbl_ChildPriceperTicket.AutoSize = True
        Me.lbl_ChildPriceperTicket.Location = New System.Drawing.Point(58, 29)
        Me.lbl_ChildPriceperTicket.Name = "lbl_ChildPriceperTicket"
        Me.lbl_ChildPriceperTicket.Size = New System.Drawing.Size(134, 20)
        Me.lbl_ChildPriceperTicket.TabIndex = 0
        Me.lbl_ChildPriceperTicket.Text = "P&rice Per Ticket:"
        '
        'grb_GrossTicketRevenue
        '
        Me.grb_GrossTicketRevenue.Controls.Add(Me.txt_TotalGrossRev)
        Me.grb_GrossTicketRevenue.Controls.Add(Me.Label4)
        Me.grb_GrossTicketRevenue.Controls.Add(Me.txt_ChildGrossTicketSales)
        Me.grb_GrossTicketRevenue.Controls.Add(Me.txt_AdultGrossTicketSales)
        Me.grb_GrossTicketRevenue.Controls.Add(Me.lbl_ChildTicketSales)
        Me.grb_GrossTicketRevenue.Controls.Add(Me.lbl_AdultTicketSales)
        Me.grb_GrossTicketRevenue.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grb_GrossTicketRevenue.Location = New System.Drawing.Point(12, 149)
        Me.grb_GrossTicketRevenue.Name = "grb_GrossTicketRevenue"
        Me.grb_GrossTicketRevenue.Size = New System.Drawing.Size(389, 163)
        Me.grb_GrossTicketRevenue.TabIndex = 2
        Me.grb_GrossTicketRevenue.TabStop = False
        Me.grb_GrossTicketRevenue.Text = "Gross Ticket Revenue"
        '
        'txt_TotalGrossRev
        '
        Me.txt_TotalGrossRev.BackColor = System.Drawing.SystemColors.ControlLight
        Me.txt_TotalGrossRev.Location = New System.Drawing.Point(222, 107)
        Me.txt_TotalGrossRev.Name = "txt_TotalGrossRev"
        Me.txt_TotalGrossRev.ReadOnly = True
        Me.txt_TotalGrossRev.Size = New System.Drawing.Size(161, 27)
        Me.txt_TotalGrossRev.TabIndex = 9
        Me.txt_TotalGrossRev.TabStop = False
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(23, 91)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(171, 49)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Total Gross Revenue for Ticket Sales:"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txt_ChildGrossTicketSales
        '
        Me.txt_ChildGrossTicketSales.BackColor = System.Drawing.SystemColors.ControlLight
        Me.txt_ChildGrossTicketSales.Location = New System.Drawing.Point(222, 62)
        Me.txt_ChildGrossTicketSales.Name = "txt_ChildGrossTicketSales"
        Me.txt_ChildGrossTicketSales.ReadOnly = True
        Me.txt_ChildGrossTicketSales.Size = New System.Drawing.Size(161, 27)
        Me.txt_ChildGrossTicketSales.TabIndex = 8
        Me.txt_ChildGrossTicketSales.TabStop = False
        '
        'txt_AdultGrossTicketSales
        '
        Me.txt_AdultGrossTicketSales.BackColor = System.Drawing.SystemColors.ControlLight
        Me.txt_AdultGrossTicketSales.Location = New System.Drawing.Point(222, 29)
        Me.txt_AdultGrossTicketSales.Name = "txt_AdultGrossTicketSales"
        Me.txt_AdultGrossTicketSales.ReadOnly = True
        Me.txt_AdultGrossTicketSales.Size = New System.Drawing.Size(161, 27)
        Me.txt_AdultGrossTicketSales.TabIndex = 7
        Me.txt_AdultGrossTicketSales.TabStop = False
        '
        'lbl_ChildTicketSales
        '
        Me.lbl_ChildTicketSales.AutoSize = True
        Me.lbl_ChildTicketSales.Location = New System.Drawing.Point(45, 65)
        Me.lbl_ChildTicketSales.Name = "lbl_ChildTicketSales"
        Me.lbl_ChildTicketSales.Size = New System.Drawing.Size(149, 20)
        Me.lbl_ChildTicketSales.TabIndex = 2
        Me.lbl_ChildTicketSales.Text = "Child Ticket Sales:"
        '
        'lbl_AdultTicketSales
        '
        Me.lbl_AdultTicketSales.AutoSize = True
        Me.lbl_AdultTicketSales.Location = New System.Drawing.Point(45, 32)
        Me.lbl_AdultTicketSales.Name = "lbl_AdultTicketSales"
        Me.lbl_AdultTicketSales.Size = New System.Drawing.Size(149, 20)
        Me.lbl_AdultTicketSales.TabIndex = 0
        Me.lbl_AdultTicketSales.Text = "Adult Ticket Sales:"
        '
        'grb_NetTicketRevenue
        '
        Me.grb_NetTicketRevenue.Controls.Add(Me.txt_TotalNetTicketSales)
        Me.grb_NetTicketRevenue.Controls.Add(Me.lbl_TotalNetRev)
        Me.grb_NetTicketRevenue.Controls.Add(Me.txt_ChildNetTicketSales)
        Me.grb_NetTicketRevenue.Controls.Add(Me.txt_AdultNetTicketSales)
        Me.grb_NetTicketRevenue.Controls.Add(Me.lbl_ChildNetSales)
        Me.grb_NetTicketRevenue.Controls.Add(Me.lbl_AdultNetSales)
        Me.grb_NetTicketRevenue.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grb_NetTicketRevenue.Location = New System.Drawing.Point(411, 149)
        Me.grb_NetTicketRevenue.Name = "grb_NetTicketRevenue"
        Me.grb_NetTicketRevenue.Size = New System.Drawing.Size(387, 163)
        Me.grb_NetTicketRevenue.TabIndex = 3
        Me.grb_NetTicketRevenue.TabStop = False
        Me.grb_NetTicketRevenue.Text = "Net Ticket Revenue"
        '
        'txt_TotalNetTicketSales
        '
        Me.txt_TotalNetTicketSales.BackColor = System.Drawing.SystemColors.ControlLight
        Me.txt_TotalNetTicketSales.Location = New System.Drawing.Point(220, 104)
        Me.txt_TotalNetTicketSales.Name = "txt_TotalNetTicketSales"
        Me.txt_TotalNetTicketSales.ReadOnly = True
        Me.txt_TotalNetTicketSales.Size = New System.Drawing.Size(161, 27)
        Me.txt_TotalNetTicketSales.TabIndex = 12
        Me.txt_TotalNetTicketSales.TabStop = False
        '
        'lbl_TotalNetRev
        '
        Me.lbl_TotalNetRev.Location = New System.Drawing.Point(21, 91)
        Me.lbl_TotalNetRev.Name = "lbl_TotalNetRev"
        Me.lbl_TotalNetRev.Size = New System.Drawing.Size(171, 49)
        Me.lbl_TotalNetRev.TabIndex = 4
        Me.lbl_TotalNetRev.Text = "Total Net Revenue for Ticket Sales:"
        Me.lbl_TotalNetRev.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txt_ChildNetTicketSales
        '
        Me.txt_ChildNetTicketSales.BackColor = System.Drawing.SystemColors.ControlLight
        Me.txt_ChildNetTicketSales.Location = New System.Drawing.Point(220, 59)
        Me.txt_ChildNetTicketSales.Name = "txt_ChildNetTicketSales"
        Me.txt_ChildNetTicketSales.ReadOnly = True
        Me.txt_ChildNetTicketSales.Size = New System.Drawing.Size(161, 27)
        Me.txt_ChildNetTicketSales.TabIndex = 11
        Me.txt_ChildNetTicketSales.TabStop = False
        '
        'txt_AdultNetTicketSales
        '
        Me.txt_AdultNetTicketSales.BackColor = System.Drawing.SystemColors.ControlLight
        Me.txt_AdultNetTicketSales.Location = New System.Drawing.Point(220, 26)
        Me.txt_AdultNetTicketSales.Name = "txt_AdultNetTicketSales"
        Me.txt_AdultNetTicketSales.ReadOnly = True
        Me.txt_AdultNetTicketSales.Size = New System.Drawing.Size(161, 27)
        Me.txt_AdultNetTicketSales.TabIndex = 10
        Me.txt_AdultNetTicketSales.TabStop = False
        '
        'lbl_ChildNetSales
        '
        Me.lbl_ChildNetSales.AutoSize = True
        Me.lbl_ChildNetSales.Location = New System.Drawing.Point(43, 62)
        Me.lbl_ChildNetSales.Name = "lbl_ChildNetSales"
        Me.lbl_ChildNetSales.Size = New System.Drawing.Size(149, 20)
        Me.lbl_ChildNetSales.TabIndex = 2
        Me.lbl_ChildNetSales.Text = "Child Ticket Sales:"
        '
        'lbl_AdultNetSales
        '
        Me.lbl_AdultNetSales.AutoSize = True
        Me.lbl_AdultNetSales.Location = New System.Drawing.Point(43, 29)
        Me.lbl_AdultNetSales.Name = "lbl_AdultNetSales"
        Me.lbl_AdultNetSales.Size = New System.Drawing.Size(149, 20)
        Me.lbl_AdultNetSales.TabIndex = 0
        Me.lbl_AdultNetSales.Text = "Adult Ticket Sales:"
        '
        'btn_CalcTicketRevenue
        '
        Me.btn_CalcTicketRevenue.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_CalcTicketRevenue.Location = New System.Drawing.Point(12, 363)
        Me.btn_CalcTicketRevenue.Name = "btn_CalcTicketRevenue"
        Me.btn_CalcTicketRevenue.Size = New System.Drawing.Size(270, 39)
        Me.btn_CalcTicketRevenue.TabIndex = 4
        Me.btn_CalcTicketRevenue.Text = "Calculate Ticket &Revenue"
        Me.btn_CalcTicketRevenue.UseVisualStyleBackColor = True
        '
        'btn_Clear
        '
        Me.btn_Clear.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Clear.Location = New System.Drawing.Point(330, 363)
        Me.btn_Clear.Name = "btn_Clear"
        Me.btn_Clear.Size = New System.Drawing.Size(127, 39)
        Me.btn_Clear.TabIndex = 5
        Me.btn_Clear.Text = "&Clear Entries"
        Me.btn_Clear.UseVisualStyleBackColor = True
        '
        'btn_Exit
        '
        Me.btn_Exit.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btn_Exit.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Exit.Location = New System.Drawing.Point(653, 363)
        Me.btn_Exit.Name = "btn_Exit"
        Me.btn_Exit.Size = New System.Drawing.Size(135, 39)
        Me.btn_Exit.TabIndex = 7
        Me.btn_Exit.Text = "E&xit"
        Me.btn_Exit.UseVisualStyleBackColor = True
        '
        'lbl_DateTime
        '
        Me.lbl_DateTime.AutoSize = True
        Me.lbl_DateTime.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_DateTime.Location = New System.Drawing.Point(22, 13)
        Me.lbl_DateTime.Name = "lbl_DateTime"
        Me.lbl_DateTime.Size = New System.Drawing.Size(59, 20)
        Me.lbl_DateTime.TabIndex = 7
        Me.lbl_DateTime.Text = "Label1"
        '
        'lbl_TotalTicketSoldToday
        '
        Me.lbl_TotalTicketSoldToday.AutoSize = True
        Me.lbl_TotalTicketSoldToday.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_TotalTicketSoldToday.Location = New System.Drawing.Point(12, 319)
        Me.lbl_TotalTicketSoldToday.Name = "lbl_TotalTicketSoldToday"
        Me.lbl_TotalTicketSoldToday.Size = New System.Drawing.Size(59, 20)
        Me.lbl_TotalTicketSoldToday.TabIndex = 8
        Me.lbl_TotalTicketSoldToday.Text = "Label1"
        '
        'btn_ClearAll
        '
        Me.btn_ClearAll.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_ClearAll.Location = New System.Drawing.Point(463, 363)
        Me.btn_ClearAll.Name = "btn_ClearAll"
        Me.btn_ClearAll.Size = New System.Drawing.Size(127, 39)
        Me.btn_ClearAll.TabIndex = 6
        Me.btn_ClearAll.Text = "&Clear All"
        Me.btn_ClearAll.UseVisualStyleBackColor = True
        '
        'frm_TheaterRevenue
        '
        Me.AcceptButton = Me.btn_CalcTicketRevenue
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlLight
        Me.CancelButton = Me.btn_Exit
        Me.ClientSize = New System.Drawing.Size(810, 414)
        Me.Controls.Add(Me.btn_ClearAll)
        Me.Controls.Add(Me.lbl_TotalTicketSoldToday)
        Me.Controls.Add(Me.lbl_DateTime)
        Me.Controls.Add(Me.btn_Exit)
        Me.Controls.Add(Me.btn_Clear)
        Me.Controls.Add(Me.btn_CalcTicketRevenue)
        Me.Controls.Add(Me.grb_NetTicketRevenue)
        Me.Controls.Add(Me.grb_GrossTicketRevenue)
        Me.Controls.Add(Me.grb_ChildTicketSales)
        Me.Controls.Add(Me.grb_AdultTicketSales)
        Me.Name = "frm_TheaterRevenue"
        Me.Text = "Theater Revenue by Tyler Hunt"
        Me.grb_AdultTicketSales.ResumeLayout(False)
        Me.grb_AdultTicketSales.PerformLayout()
        Me.grb_ChildTicketSales.ResumeLayout(False)
        Me.grb_ChildTicketSales.PerformLayout()
        Me.grb_GrossTicketRevenue.ResumeLayout(False)
        Me.grb_GrossTicketRevenue.PerformLayout()
        Me.grb_NetTicketRevenue.ResumeLayout(False)
        Me.grb_NetTicketRevenue.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents grb_AdultTicketSales As GroupBox
    Friend WithEvents lbl_AdultTicketsSold As Label
    Friend WithEvents lbl_AdultPricePerTicket As Label
    Friend WithEvents grb_ChildTicketSales As GroupBox
    Friend WithEvents grb_GrossTicketRevenue As GroupBox
    Friend WithEvents grb_NetTicketRevenue As GroupBox
    Friend WithEvents btn_CalcTicketRevenue As Button
    Friend WithEvents btn_Clear As Button
    Friend WithEvents btn_Exit As Button
    Friend WithEvents txt_AdultTicketsSold As TextBox
    Friend WithEvents txt_AdultPricePerTicket As TextBox
    Friend WithEvents txt_ChildTicketsSold As TextBox
    Friend WithEvents txt_ChildPricePerTicket As TextBox
    Friend WithEvents lbl_ChildPricePerTicketSold As Label
    Friend WithEvents lbl_ChildPriceperTicket As Label
    Friend WithEvents txt_TotalGrossRev As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txt_ChildGrossTicketSales As TextBox
    Friend WithEvents txt_AdultGrossTicketSales As TextBox
    Friend WithEvents lbl_ChildTicketSales As Label
    Friend WithEvents lbl_AdultTicketSales As Label
    Friend WithEvents txt_TotalNetTicketSales As TextBox
    Friend WithEvents lbl_TotalNetRev As Label
    Friend WithEvents txt_ChildNetTicketSales As TextBox
    Friend WithEvents txt_AdultNetTicketSales As TextBox
    Friend WithEvents lbl_ChildNetSales As Label
    Friend WithEvents lbl_AdultNetSales As Label
    Friend WithEvents lbl_DateTime As Label
    Friend WithEvents lbl_TotalTicketSoldToday As Label
    Friend WithEvents btn_ClearAll As Button
End Class
