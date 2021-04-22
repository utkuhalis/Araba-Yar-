Public Class Form1
    Dim araba1 As Integer = 0
    Dim araba2 As Integer = 0

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Timer1.Start()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        araba1 = Int(Rnd(1) * (10))
        araba2 = Int(Rnd(1) * (10))

        Panel1.Location += New Point(+araba1, +0)
        Panel2.Location += New Point(+araba2, +0)

        If Panel1.Location.X > 465 Then
            Timer1.Stop()
            MsgBox("Turuncu Araba Kazandı")
            Yenile()
        End If

        If Panel2.Location.X > 465 Then
            Timer1.Stop()
            MsgBox("Mavi Araba Kazandı")
            Yenile()
        End If
    End Sub

    Private Sub Yenile()
        Panel1.Location = New Point(10, 28)
        Panel2.Location = New Point(10, 85)
        araba1 = 0
        araba2 = 0
    End Sub
End Class
