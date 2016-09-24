Public Class TylerHunt_WorkshopSelector
    Private Sub TylerHunt_WorkshopSelector_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'initial load settings
        btn_CalcTotal.Enabled = False
        lbx_Costs.Enabled = False
        btn_Reset.Enabled = False

    End Sub

    Private Sub btn_Reset_Click(sender As Object, e As EventArgs) Handles btn_Reset.Click

        'Reset form settings
        lbx_Location.SelectedIndex = -1
        lbx_Workshop.SelectedIndex = -1
        txt_TotalCost.Text = String.Empty
        lbx_Costs.Items.Clear()
        btn_CalcTotal.Enabled = False

        'Adjsut button focus 
        lbx_Workshop.Focus()
        btn_AddWorkshop.Enabled = True
        btn_Reset.Enabled = False

    End Sub

    Private Sub btn_CalcTotal_Click(sender As Object, e As EventArgs) Handles btn_CalcTotal.Click
        Dim str_regFee As String = lbx_Costs.Items(0).ToString()
        Dim str_locFee As String = lbx_Costs.Items(1).ToString()

        Dim int_regFee As Integer = CInt(str_regFee)
        Dim int_locFee As Integer = CInt(str_locFee)

        Dim totalFee As Integer = int_regFee + int_locFee
        txt_TotalCost.Text = totalFee.ToString("c2")

        'Adjsut button focus 
        btn_CalcTotal.Enabled = False
        btn_Reset.Enabled = True
        btn_Reset.Focus()

    End Sub

    Private Sub btn_AddWorkshop_Click(sender As Object, e As EventArgs) Handles btn_AddWorkshop.Click

        If lbx_Workshop.SelectedIndex <> -1 And lbx_Location.SelectedIndex <> -1 Then
            lbx_Costs.Enabled = True

            'Arrays to hold Registration Cost, Location & Duration costs
            Dim arr_wsRegFee() As Integer = {595, 695, 995, 1295, 395}
            Dim arr_wsDuration() As Integer = {3, 3, 3, 5, 1}
            Dim arr_wslodgingFee() As Integer = {95, 125, 110, 100, 92, 90}

            'Get user selected index
            Dim wsRegIndex As Integer = lbx_Workshop.SelectedIndex
            Dim wsLodgingIndex As Integer = lbx_Location.SelectedIndex

            'Calc Fees
            Dim regFee As Integer = arr_wsRegFee(wsRegIndex)
            Dim locFee As Integer = arr_wslodgingFee(wsLodgingIndex) * arr_wsDuration(wsRegIndex)

            'Add selected items to the costs listbox
            lbx_Costs.Items.Insert(0, regFee.ToString("c2"))
            lbx_Costs.Items.Insert(1, locFee.ToString("c2"))

            'Enable and focus calc button
            btn_CalcTotal.Enabled = True
            btn_CalcTotal.Focus()

            btn_AddWorkshop.Enabled = False
        Else
            'Msg if workshop is not selected
            If lbx_Workshop.SelectedIndex = -1 Then
                MessageBox.Show("You must select a Workshop from the list!", "Select a Workshop",
                                MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
            'Msg if location is not selected
            If lbx_Location.SelectedIndex = -1 Then
                MessageBox.Show("You must select a Location for you workshop from the list!", "Select a Location",
                                MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If

        End If
    End Sub

    Private Sub btn_Exit_Click(sender As Object, e As EventArgs) Handles btn_Exit.Click
        'Close Form
        Me.Close()
    End Sub

End Class
