Public Class frm_TheaterRevenue
    Public Const perKeepByTheater As Single = 0.2
    Public totalTicketsSold As Integer = 0

    Public gross_AdultSales As Decimal = 0
    Public gross_ChildSales As Decimal = 0
    Public gross_TotalSales As Decimal = 0

    Public net_AdultSales As Decimal = 0
    Public net_ChildSales As Decimal = 0
    Public net_TotalSales As Decimal = 0


    Private Sub btn_CalcTicketRevenue_Click(sender As Object, e As EventArgs) Handles btn_CalcTicketRevenue.Click
        'Declarations
        Dim adultPricePerTicket As Decimal
        Dim adultTicketsSold As Integer
        Dim adultTicketPriceTotal As Decimal

        Dim childPricePerTicket As Decimal
        Dim childTicketsSold As Integer
        Dim childTicketsPriceTotal As Decimal

        Dim ticketsSoldMessage As String = "Total Tickets Sold Today: "

        'Get valid adult data~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        If (Not txt_AdultPricePerTicket.Text = String.Empty And Not txt_AdultTicketsSold.Text = String.Empty) Then
            'If textbox is not null then attempt to get data 
            Try
                'Get input
                adultPricePerTicket = CDec(txt_AdultPricePerTicket.Text)
                adultTicketsSold = CInt(txt_AdultTicketsSold.Text)

                'Caluclate input
                adultTicketPriceTotal = adultPricePerTicket * adultTicketsSold

                'Add tickets to global ticket count
                totalTicketsSold += adultTicketsSold
                'Update Total tickets sold today Label
                lbl_TotalTicketSoldToday.Text = ticketsSoldMessage & totalTicketsSold.ToString() & " Tickets"

                'Add gross sales and populate textbox
                gross_AdultSales += adultTicketPriceTotal
                txt_AdultGrossTicketSales.Clear()
                txt_AdultGrossTicketSales.Text = gross_AdultSales.ToString("C")

                'Add net sales and populate
                net_AdultSales += CDec(perKeepByTheater) * adultTicketPriceTotal
                txt_AdultNetTicketSales.Text = net_AdultSales.ToString("C")

                'Update total net


            Catch ex As Exception
                'Error message
                MessageBox.Show("All adult ticket entries must be a numeric value" & vbCrLf &
                                vbCrLf & "Error message: " & vbCrLf & vbTab & ex.Message() & vbCrLf &
                                vbCrLf & "Please try again!")
                'Clear invalid input
                txt_AdultPricePerTicket.Clear()
                txt_AdultTicketsSold.Clear()
            End Try
        Else
            'MessageBox.Show("You must enter a numeric values for these entry fields! Adult Fields!")
            txt_AdultPricePerTicket.Text = ""
            txt_AdultTicketsSold.Text = ""
        End If


        'Get valid child data~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        If (Not txt_ChildPricePerTicket.Text = String.Empty And Not txt_ChildTicketsSold.Text = String.Empty) Then
            'If textbox is not null then attempt to get data 
            Try
                'Get input
                childPricePerTicket = CDec(txt_ChildPricePerTicket.Text)
                childTicketsSold = CInt(txt_ChildTicketsSold.Text)

                'Calculate input
                childTicketsPriceTotal = childPricePerTicket * childTicketsSold

                'Add tickets to global ticket count
                totalTicketsSold += childTicketsSold
                'Update Total tickets sold today Label
                lbl_TotalTicketSoldToday.Text = ticketsSoldMessage & totalTicketsSold.ToString() & " Tickets"

                'Add gross sales and populate textbox
                gross_ChildSales += childTicketsPriceTotal
                txt_ChildGrossTicketSales.Text = gross_ChildSales.ToString("C")

                'Add net sales and populate
                net_ChildSales += CDec(perKeepByTheater) * childTicketsPriceTotal
                txt_ChildNetTicketSales.Text = net_ChildSales.ToString("C")

            Catch ex As Exception
                'Error message
                MessageBox.Show("All child ticket entries must be a numeric value" & vbCrLf &
                     vbCrLf & "Error message: " & vbCrLf & vbTab & ex.Message() & vbCrLf &
                     vbCrLf & "Please try again!")
                'Clear invalid input
                txt_ChildPricePerTicket.Clear()
                txt_ChildTicketsSold.Clear()
            End Try
        Else
            'MessageBox.Show("You must enter a numeric values for these entry fields! Child Fields!")
            txt_ChildPricePerTicket.Text = ""
            txt_ChildTicketsSold.Text = ""
        End If

        'Update Total gross amount
        gross_TotalSales = gross_AdultSales + gross_ChildSales
        txt_TotalGrossRev.Text = gross_TotalSales.ToString("C")

        'Update Total net amount
        net_TotalSales = net_AdultSales + net_ChildSales
        txt_TotalNetTicketSales.Text = net_TotalSales.ToString("C")

        'clear adult tickit input info
        txt_AdultPricePerTicket.Clear()
        txt_AdultTicketsSold.Clear()

        'clear child ticjet input info
        txt_ChildPricePerTicket.Clear()
        txt_ChildTicketsSold.Clear()

        'Reset focus
        txt_AdultPricePerTicket.Focus()

    End Sub

    Private Sub btn_Clear_Click(sender As Object, e As EventArgs) Handles btn_Clear.Click

        'clear adult tickit input info
        txt_AdultPricePerTicket.Clear()
        txt_AdultTicketsSold.Clear()

        'clear child ticjet input info
        txt_ChildPricePerTicket.Clear()
        txt_ChildTicketsSold.Clear()

        txt_AdultPricePerTicket.Focus()

    End Sub

    Private Sub btn_ClearAll_Click(sender As Object, e As EventArgs) Handles btn_ClearAll.Click

        'clear adult tickit input info
        txt_AdultPricePerTicket.Clear()
        txt_AdultTicketsSold.Clear()
        txt_AdultGrossTicketSales.Clear()
        txt_AdultNetTicketSales.Clear()

        'clear child ticjet input info
        txt_ChildPricePerTicket.Clear()
        txt_ChildTicketsSold.Clear()
        txt_ChildGrossTicketSales.Clear()
        txt_ChildNetTicketSales.Clear()

        'Clear totals
        txt_TotalGrossRev.Clear()
        txt_TotalNetTicketSales.Clear()

        'Reset global variables
        totalTicketsSold = 0
        gross_AdultSales = 0
        gross_ChildSales = 0
        gross_TotalSales = 0

        net_AdultSales = 0
        net_ChildSales = 0
        net_TotalSales = 0

        'Reset total ticket count
        lbl_TotalTicketSoldToday.Text = ""

        'Reset Focus
        txt_AdultPricePerTicket.Focus()
    End Sub

    Private Sub btn_Exit_Click(sender As Object, e As EventArgs) Handles btn_Exit.Click
        Me.Close()
    End Sub

    Private Sub frm_TheaterRevenue_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'Initial load settings
        txt_AdultPricePerTicket.Focus()
        lbl_TotalTicketSoldToday.Text = "" 'TODO: adust the default for this

        'Initial load Date Time
        lbl_DateTime.Text = Now.ToString("D")

    End Sub

    Private Sub txt_AdultPricePerTicket_GotFocus(sender As Object, e As EventArgs) Handles txt_AdultPricePerTicket.GotFocus
        Me.txt_AdultPricePerTicket.BackColor = Color.Yellow
    End Sub

    Private Sub txt_AdultPricePerTicket_LostFocus(sender As Object, e As EventArgs) Handles txt_AdultPricePerTicket.LostFocus
        Me.txt_AdultPricePerTicket.BackColor = Color.White
    End Sub

    Private Sub txt_AdultTicketsSold_GotFocus(sender As Object, e As EventArgs) Handles txt_AdultTicketsSold.GotFocus
        Me.txt_AdultTicketsSold.BackColor = Color.Yellow
    End Sub

    Private Sub txt_AdultTicketsSold_LostFocus(sender As Object, e As EventArgs) Handles txt_AdultTicketsSold.LostFocus
        Me.txt_AdultTicketsSold.BackColor = Color.White
    End Sub

    Private Sub txt_ChildPricePerTicket_GotFocus(sender As Object, e As EventArgs) Handles txt_ChildPricePerTicket.GotFocus
        Me.txt_ChildPricePerTicket.BackColor = Color.Yellow
    End Sub

    Private Sub txt_ChildPricePerTicket_LostFocus(sender As Object, e As EventArgs) Handles txt_ChildPricePerTicket.LostFocus
        Me.txt_ChildPricePerTicket.BackColor = Color.White
    End Sub

    Private Sub txt_ChildTicketsSold_GotFocus(sender As Object, e As EventArgs) Handles txt_ChildTicketsSold.GotFocus
        Me.txt_ChildTicketsSold.BackColor = Color.Yellow
    End Sub

    Private Sub txt_ChildTicketsSold_LostFocus(sender As Object, e As EventArgs) Handles txt_ChildTicketsSold.LostFocus
        Me.txt_ChildTicketsSold.BackColor = Color.White
    End Sub

End Class
