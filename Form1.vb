Public Class Form1
    Dim rand As New Random
    Dim maxMove As Integer = 5
    Dim maxSleep As Integer = 10

    Dim t1 As System.Threading.Thread
    Dim t2 As System.Threading.Thread

    Private Sub btn_start_Click(sender As Object, e As EventArgs) Handles btn_start.Click
        'to run the two threads at once
        'the AdressOf property indicates which procedure I want to be running in that Thread
        t1 = New System.Threading.Thread(AddressOf Redbox)
        t2 = New System.Threading.Thread(AddressOf Bluebox)

        t1.Start()
        t2.Start()

        'Call Redbox()
        'Call Bluebox()
    End Sub


    Sub Redbox()
        Dim G As Graphics
        G = Me.CreateGraphics

        Dim bRed As Brush
        Dim bGrey As Brush
        Dim xR As Integer
        xR = 100
        bRed = New SolidBrush(Color.Red)
        bGrey = New SolidBrush(Me.BackColor)

        Do While xR < 1150
            G.FillRectangle(bRed, xR, 100, 50, 50)
            Threading.Thread.Sleep(rand.Next(maxSleep))
            G.FillRectangle(bGrey, xR, 100, 50, 50)
            xR = xR + rand.Next(maxMove)

        Loop
        G.FillRectangle(bRed, xR, 100, 50, 50)

    End Sub



    Sub Bluebox()
        Dim G As Graphics
        G = Me.CreateGraphics

        Dim bBlue As Brush
        Dim bGrey As Brush
        Dim xB As Integer
        xB = 100
        bBlue = New SolidBrush(Color.Blue)
        bGrey = New SolidBrush(Me.BackColor)

        Do While xB < 1150
            G.FillRectangle(bBlue, xB, 200, 50, 50)
            Threading.Thread.Sleep(rand.Next(maxSleep))
            G.FillRectangle(bGrey, xB, 200, 50, 50)
            xB = xB + rand.Next(maxMove)

        Loop
        G.FillRectangle(bBlue, xB, 200, 50, 50)

    End Sub

End Class
