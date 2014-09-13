' Author: Samuel Bristol
' Email: samuel.d.bristol@gmail.com
' Website: http://www.samuelbristol.com
' Date: 9/12/2014
' Purpose: Utilize event-driven programming to create an interface
'          using Visual Basic that displays all odd and even numbers
'          between two given integer input values.

Option Strict On
Option Explicit On

Public Class frmOddEven
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        ' Close the application
        Me.Close()
    End Sub

    Private Sub btnDisplay_Click(sender As Object, e As EventArgs) Handles btnDisplay.Click
        ' Clear the list boxes in case of a previous attempt that threw an error
        lstOdd.Items.Clear()
        lstEven.Items.Clear()

        ' Declare local variables
        Dim intNumber1 As Integer
        Dim intNumber2 As Integer
        Dim currentNumber As Integer

        Try
            ' Try to parse input
            intNumber1 = CInt(txtnumber1.Text)
            intNumber2 = CInt(txtnumber2.Text)

            ' Catch a case where the user enters a smaller number
            ' than the first number in the second text box.
            If intNumber1 > intNumber2 Then
                Throw New System.Exception
            End If

            ' Loop between the two numbers
            For currentNumber = intNumber1 To intNumber2
                ' Add to odd list if an odd number
                If currentNumber Mod 2 <> 0 Then
                    ' This is an odd number, add to odd list
                    lstOdd.Items.Add(currentNumber)
                Else
                    ' This is an even number, add to even list
                    lstEven.Items.Add(currentNumber)
                End If
            Next
        Catch ex As Exception
            ' Display message to user and clear the list boxes
            MsgBox("Please enter an integer value. The second number must be larger than the first.")
            lstOdd.Items.Clear()
            lstEven.Items.Clear()
        End Try
    End Sub

    Private Sub txtnumber1_TextChanged(sender As Object, e As EventArgs) Handles txtnumber1.TextChanged

    End Sub
End Class
