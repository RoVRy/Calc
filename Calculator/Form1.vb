Public Class CalcWin
    Dim X, Y As Double
    Dim Scale1 As Double = 10
    Dim Scale2 As Double = 1
    Dim DecPoint As Boolean
    Dim Oper As Integer

    Private Sub One_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles One.Click
        X = X * Scale1 + Scale2
        If DecPoint Then Scale2 /= 10
        Me.Display.Text = Str(X)
    End Sub

    Private Sub Two_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Two.Click
        X = X * Scale1 + 2 * Scale2
        If DecPoint Then Scale2 /= 10
        Me.Display.Text = Str(X)
    End Sub

    Private Sub Three_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Three.Click
        X = X * Scale1 + 3 * Scale2
        If DecPoint Then Scale2 /= 10
        Me.Display.Text = Str(X)
    End Sub

    Private Sub Four_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Four.Click
        X = X * Scale1 + 4 * Scale2
        If DecPoint Then Scale2 /= 10
        Me.Display.Text = Str(X)
    End Sub

    Private Sub Five_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Five.Click
        X = X * Scale1 + 5 * Scale2
        If DecPoint Then Scale2 /= 10
        Me.Display.Text = Str(X)
    End Sub

    Private Sub Six_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Six.Click
        X = X * Scale1 + 6 * Scale2
        If DecPoint Then Scale2 /= 10
        Me.Display.Text = Str(X)
    End Sub

    Private Sub Seven_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Seven.Click
        X = X * Scale1 + 7 * Scale2
        If DecPoint Then Scale2 /= 10
        Me.Display.Text = Str(X)
    End Sub

    Private Sub Eight_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Eight.Click
        X = X * Scale1 + 8 * Scale2
        If DecPoint Then Scale2 /= 10
        Me.Display.Text = Str(X)
    End Sub

    Private Sub Nine_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Nine.Click
        X = X * Scale1 + 9 * Scale2
        If DecPoint Then Scale2 /= 10
        Me.Display.Text = Str(X)
    End Sub

    Private Sub Zero_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Zero.Click
        X = X * Scale1
        Me.Display.Text = Str(X)
        If DecPoint Then
            Scale2 /= 10
            Me.Display.Text += "0"
        End If
    End Sub

    Private Sub PlusMinus_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PlusMinus.Click
        X = -X
        Scale2 = -Scale2
        Me.Display.Text = Str(X)
    End Sub

    Private Sub Dot_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Dot.Click
        If DecPoint Then Exit Sub
        Scale1 = 1
        Scale2 = 0.1
        DecPoint = True
    End Sub
End Class
