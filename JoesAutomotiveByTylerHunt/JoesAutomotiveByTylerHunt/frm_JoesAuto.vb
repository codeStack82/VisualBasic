Public Class frm_JoesAuto
    Private Sub frm_JoesAuto_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btn_CalcTotal_Click(sender As Object, e As EventArgs) Handles btn_CalcTotal.Click
        'Calculate and display summary data
        IsPartsValid().ToString()
        DisplaySummaryData()

    End Sub

    Private Sub btn_Clear_Click(sender As Object, e As EventArgs) Handles btn_Clear.Click
        Dim result As Integer = MessageBox.Show("Are you sure that you want to clear all input" &
                                             " fields?", "Clear all input fields?", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning)
        If (result = DialogResult.Yes) Then
            clearAll()
        End If

    End Sub

    Private Sub btn_Exit_Click(sender As Object, e As EventArgs) Handles btn_Exit.Click
        'Close Application
        Me.Close()
    End Sub

    Sub DisplaySummaryData()
        txt_ServLabor.Text = Total_ServiceAndLaborCost.ToString("c2")
        txt_PartsTotal.Text = Total_PartsCost.ToString("c2")
        txt_PartsTax.Text = TaxCharges.ToString("c2")
        txt_TotalFees.Text = Total_Charges.ToString("c2")
    End Sub


    'Get Checkbox totaLS
    Function OilLubeCharges() As Decimal
        Dim addCost As Decimal
        If (cb_OilChange.Checked) Then
            addCost += 26D
        End If
        If (cb_LubeJob.Checked) Then
            addCost += 18D
        End If
        Return addCost
    End Function

    Function FlushCharges() As Decimal
        Dim addCost As Decimal
        If (cb_RadFlush.Checked) Then
            addCost += 30D
        End If
        If (cb_TransFlush.Checked) Then
            addCost += 26D
        End If
        Return addCost
    End Function

    Function MiscCharges() As Decimal
        Dim addCost As Decimal
        If (cb_Inspection.Checked) Then
            addCost += 15D
        End If
        If (cb_ReplMuffler.Checked) Then
            addCost += 100D
        End If
        If (cb_TireRotate.Checked) Then
            addCost += 20D
        End If
        Return addCost
    End Function

    'Calc totals
    Function Total_ServiceAndLaborCost() As Decimal
        Dim ServiceLaborCost As Decimal
        Const RATEPERHOUR As Decimal = 20D

        'Calc service and labor costs where applicable
        ServiceLaborCost = OilLubeCharges() + FlushCharges() + MiscCharges()

        'Add if labor field is not null
        If IsLaborValid() Then
            ServiceLaborCost += CDec(txt_LaborCost.Text) * RATEPERHOUR
        End If

        Return ServiceLaborCost
    End Function

    Function Total_PartsCost() As Decimal
        Dim PartsCost As Decimal

        If IsPartsValid() Then
            PartsCost = CDec(txt_PartsCost.Text)
        Else
            PartsCost = 0D
        End If

        Return PartsCost
    End Function

    Function Total_Charges() As Decimal
        'Sum all costs
        Return Total_ServiceAndLaborCost() + Total_PartsCost() + TaxCharges()
    End Function

    Function TaxCharges() As Decimal
        Const TAXRATE As Decimal = 0.06D
        Dim PartsCost As Decimal

        If IsPartsValid() Then
            PartsCost = CDec(txt_PartsCost.Text)
        Else
            PartsCost = 0D
        End If

        Return PartsCost * TAXRATE

    End Function


    'Validate data
    Function IsPartsValid() As Boolean
        Dim valid As Boolean

        If Not Decimal.TryParse(txt_PartsCost.Text, Nothing) And Not txt_PartsCost.Text IsNot String.Empty Then
            valid = False
            txt_PartsCost.Text = String.Empty
        Else
            valid = True
        End If

        Return valid
    End Function

    Function IsLaborValid() As Boolean
        Dim valid As Boolean

        If Not Decimal.TryParse(txt_LaborCost.Text, Nothing) And Not txt_LaborCost.Text IsNot String.Empty Then
            valid = False
            txt_LaborCost.Text = String.Empty
        Else
            valid = True
        End If

        Return valid
    End Function

    'Clear input fields
    Sub clearOilLube()
        cb_OilChange.Checked = False
        cb_LubeJob.Checked = False
    End Sub

    Sub clearFlush()
        cb_RadFlush.Checked = False
        cb_TransFlush.Checked = False
    End Sub

    Sub clearOther()
        txt_PartsCost.Text = String.Empty
        txt_LaborCost.Text = String.Empty
    End Sub

    Sub clearMisc()
        cb_Inspection.Checked = False
        cb_ReplMuffler.Checked = False
        cb_TireRotate.Checked = False
    End Sub

    Sub clearSummary()
        txt_ServLabor.Text = String.Empty
        txt_PartsTotal.Text = String.Empty
        txt_PartsTax.Text = String.Empty
        txt_TotalFees.Text = String.Empty
    End Sub

    Sub clearAll()
        'Clear all input fields
        clearOilLube()
        clearFlush()
        clearMisc()
        clearOther()
        clearSummary()
    End Sub

End Class
