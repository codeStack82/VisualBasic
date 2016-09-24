Public Class frm_LongDistanceCalls
    Private Sub frm_LongDistanceCalls_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'Initial load settings
        rdo_Daytime.Checked = True
        lbl_Output.Text = String.Empty
        lbl_EnterEmail.TextAlign = ContentAlignment.MiddleCenter
        txt_CallMinutes.Focus()

    End Sub

    Private Sub btn_CalculateCharges_Click(sender As Object, e As EventArgs) Handles btn_CalculateCharges.Click

        'Declare and set email vars
        Dim email1 As String = String.Empty
        Dim email2 As String = String.Empty

        'Declare & validate email input
        Dim email_IsValid As Boolean = False
        Dim vaild_email As String = String.Empty

        'Declare & validate minute inputs
        Dim min_IsValid As Boolean
        Dim valid_Minutes As Integer

        'Declare & get selected text 
        Dim getRateText As String = getSelectedRateText()

        'Declare & get cost per minute and calc total
        Dim costPerMinute As Decimal = getSelectedCost()
        Dim totalCost As Decimal = 0D

        'Declare & validate is text inputs are valid
        Dim text_isValid As Boolean = isTextBoxValid()

        'Ddeclare string for the output label 
        Dim outputString As String = String.Empty

        'Test conditions and report back...
        If text_isValid Then
            'Set values
            min_IsValid = isMinutesValid()

            email1 = txt_Email.Text
            email2 = txt_ReEmail.Text
            email_IsValid = isEmailValid(email1, email2)

            If min_IsValid Then
                valid_Minutes = getMinutes()
                If email_IsValid Then
                    vaild_email = getEmail()

                    'Calculate total Cost
                    totalCost = costPerMinute * valid_Minutes

                    'Declare output label string and set
                    outputString = "Category: " & getRateText & vbNewLine &
                                        "Total minutes: " & valid_Minutes.ToString() & vbNewLine &
                                        "Total Cost: " & totalCost.ToString("C") & vbNewLine &
                                        "The bill will be sent to: " & vaild_email

                    'Set output string into the output label
                    lbl_Output.Text = outputString

                    'Clear form of data for new input
                    rdo_Daytime.Checked = True
                    txt_CallMinutes.Text = String.Empty
                    txt_Email.Text = String.Empty
                    txt_ReEmail.Text = String.Empty

                    'Resize form to show output label
                    Me.Size = New System.Drawing.Size(343, 500)
                End If
            End If
        End If

    End Sub

    Private Sub btn_Clear_Click(sender As Object, e As EventArgs) Handles btn_Clear.Click

        'MessageBox setup vars
        Dim clr_Message As String = "Are you sure that you want to clear the form?"
        Dim clr_Title As String = "Clear Form Prompt"
        Dim clr_Style As MsgBoxStyle = MsgBoxStyle.YesNo Or MsgBoxStyle.DefaultButton2 Or MsgBoxStyle.Critical
        Dim clr_Response As MsgBoxResult = MsgBox(clr_Message, clr_Style, clr_Title)

        'Confirm user request
        If clr_Response = MsgBoxResult.Yes Then
            'Clear & reset form
            rdo_Daytime.Checked = True
            txt_CallMinutes.Text = String.Empty
            txt_Email.Text = String.Empty
            txt_ReEmail.Text = String.Empty
            lbl_Output.Text = String.Empty
            Me.Size = New System.Drawing.Size(343, 400)
        End If

    End Sub

    Private Sub btn_Exit_Click(sender As Object, e As EventArgs) Handles btn_Exit.Click

        'MessageBox setup vars
        Dim ext_Message As String = "Are you sure that you want to exit the form?"
        Dim ext_Title As String = "Exit Form Prompt"
        Dim ext_Style As MsgBoxStyle = MsgBoxStyle.YesNo Or MsgBoxStyle.DefaultButton2 Or MsgBoxStyle.Question
        Dim ext_Response As MsgBoxResult = MsgBox(ext_Message, ext_Style, ext_Title)

        'Confirm user request
        If ext_Response = MsgBoxResult.Yes Then
            'Close Form
            Me.Close()
        End If

    End Sub

    Function isMinutesValid() As Boolean

        'Validate the text input and return a bool value
        Dim isValid As Boolean = False
        Const maxMinutes As Integer = 20000
        Dim minutes As Integer = 0
        Dim is_minutesValid As Boolean = Integer.TryParse(txt_CallMinutes.Text, minutes)
        Dim err_message As String = String.Empty

        If is_minutesValid Then
            If minutes > 0 And minutes <= maxMinutes Then
                isValid = True
            Else
                MsgBox("Error: The minutes input value must be an integer" & vbNewLine & vbNewLine _
                       & "        The minutes input value must be greater than 0 " & vbNewLine & vbNewLine _
                       & "        The minutes input value must also be less than 20000 " & vbNewLine & vbNewLine _
                       & "        Please try again!")
                txt_CallMinutes.Clear()
                txt_CallMinutes.Focus()
            End If
        Else
            MsgBox("Error: The minutes input value must be an integer")
            txt_CallMinutes.Clear()
            txt_CallMinutes.Focus()
        End If

        ' MsgBox(isValid)

        Return isValid
    End Function

    Function getMinutes() As Integer

        Dim minutes As Integer = 0
        Dim minutes_IsValid As Boolean = isMinutesValid()

        If (minutes_IsValid) Then
            minutes = CInt(txt_CallMinutes.Text)
        End If

        Return minutes
    End Function

    Function isEmailValid(ByVal Email1 As String, ByVal Email2 As String) As Boolean
        'Return value
        Dim isInputValid As Boolean = False

        'Counter vars for Email 1
        Dim count_AT_Email1 As Integer = 0
        Dim count_dot_Email1 As Integer = 0
        Dim letterOrDigit_Email1 As Integer = 0

        'Counter vars for Email 2
        Dim count_AT_Email2 As Integer = 0
        Dim count_dot_Email2 As Integer = 0
        Dim letterOrDigit_Email2 As Integer = 0

        'Loop thru email strings - count chars
        For Each i As Char In Email1
            If i = "." Then
                count_AT_Email1 += 1
            ElseIf i = "@" Then
                count_dot_Email1 += 1
            ElseIf Char.IsLetterOrDigit(i) Then
                letterOrDigit_Email1 += 1
            End If
        Next

        'Loop thru email strings - count chars
        For Each i As Char In Email2
            If i = "." Then
                count_AT_Email2 += 1
            ElseIf i = "@" Then
                count_dot_Email2 += 1
            ElseIf Char.IsLetterOrDigit(i) Then
                letterOrDigit_Email2 += 1
            End If
        Next

        'Ensure the string are the same
        If Email1.ToLower() = Email2.ToLower() Then  'ensure emails match
            If count_AT_Email1 = 1 And count_AT_Email2 = 1 Then 'ensure that email address has an @
                If count_dot_Email1 = 1 And count_dot_Email2 = 1 Then 'ensure email has a .
                    If letterOrDigit_Email1 > 2 And letterOrDigit_Email2 > 2 Then 'ensure that email has a count of at least 3
                        isInputValid = True
                    End If
                End If
            End If
        Else
            MessageBox.Show("The email addresses you entered do not match or are not valid." & vbNewLine _
                            & vbNewLine & "Please try again!")
            'txt_Email.Clear()
            txt_ReEmail.Clear()
            txt_Email.Focus()
        End If

        Return isInputValid
    End Function

    Function getEmail() As String

        Dim emailAddress As String = String.Empty
        Dim email1 As String = txt_Email.Text
        Dim email2 As String = txt_ReEmail.Text
        Dim email_IsValid As Boolean = isEmailValid(email1, email2)


        If (email_IsValid) Then
            emailAddress = txt_Email.Text
        End If

        Return emailAddress
    End Function

    Function getSelectedCost() As Decimal
        'Declare and set vars
        Const cost_Daytime As Decimal = 0.07D
        Const cost_Evening As Decimal = 0.12D
        Const cost_OffPeak As Decimal = 0.05D
        Dim cost_PerMinute As Decimal
        Dim cost_DaytimeChecked As Boolean = rdo_Daytime.Checked
        Dim cost_EveningChecked As Boolean = rdo_Evening.Checked

        If (cost_DaytimeChecked) Then
            cost_PerMinute = cost_Daytime
        ElseIf (cost_DaytimeChecked) Then
            cost_PerMinute = cost_Evening
        Else
            cost_PerMinute = cost_OffPeak
        End If

        Return cost_PerMinute
    End Function

    Function getSelectedRateText() As String

        'Declare and set vars
        Dim costLabel As String
        Dim cost_DaytimeChecked As Boolean = rdo_Daytime.Checked
        Dim cost_EveningChecked As Boolean = rdo_Evening.Checked
        Dim cost_OffPeakeChecked As Boolean = rdo_OffTime.Checked

        If (cost_DaytimeChecked) Then
            costLabel = rdo_Daytime.Text.Substring(1)
        ElseIf (cost_EveningChecked) Then
            costLabel = rdo_Evening.Text.Substring(1)
        Else
            costLabel = rdo_OffTime.Text.Substring(1)
        End If

        Return costLabel
    End Function

    Function isTextBoxValid() As Boolean
        Dim isValid = True
        Dim err_message = String.Empty

        'Test if input values are empty and return correct boolean
        If txt_CallMinutes.Text = String.Empty Then
            err_message = "   ~The input minutes text box is empty" & vbNewLine & vbNewLine
            txt_CallMinutes.Focus()
            isValid = False
        End If

        If txt_Email.Text = String.Empty Then
            err_message += "   ~The email text box is empty" & vbNewLine & vbNewLine
            txt_Email.Focus()
            isValid = False
        End If

        If txt_ReEmail.Text = String.Empty Then
            err_message += "   ~The confirmation email text box is empty"
            txt_ReEmail.Focus()
            isValid = False
        End If

        'Display error message is
        If Not err_message = String.Empty Then
            MsgBox("There is still empty input values in this form:" & vbNewLine & vbNewLine & err_message)
        End If


        Return isValid
    End Function

    'Event handlers for txt box back color
    Private Sub txt_CallMinutes_GotFocus(sender As Object, e As EventArgs) Handles txt_CallMinutes.GotFocus
        Me.txt_CallMinutes.BackColor = Color.LightBlue
    End Sub

    Private Sub txt_CallMinutes_LostFocus(sender As Object, e As EventArgs) Handles txt_CallMinutes.LostFocus
        Me.txt_CallMinutes.BackColor = Color.White
    End Sub

    Private Sub txt_Email_GotFocus(sender As Object, e As EventArgs) Handles txt_Email.GotFocus
        Me.txt_Email.BackColor = Color.LightBlue
    End Sub

    Private Sub txt_Email_LostFocus(sender As Object, e As EventArgs) Handles txt_Email.LostFocus
        Me.txt_Email.BackColor = Color.White
    End Sub

    Private Sub txt_ReEmail_GotFocus(sender As Object, e As EventArgs) Handles txt_ReEmail.GotFocus
        Me.txt_ReEmail.BackColor = Color.LightBlue
    End Sub

    Private Sub txt_ReEmail_LostFocus(sender As Object, e As EventArgs) Handles txt_ReEmail.LostFocus
        Me.txt_ReEmail.BackColor = Color.White
    End Sub

End Class