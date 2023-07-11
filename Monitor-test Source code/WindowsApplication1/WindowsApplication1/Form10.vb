Public Class Form10

    ' Кнопка "Меню"
    Private Sub Button11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button11.Click
        Me.Visible = False
        Form1.Show()
    End Sub

    ' Кнопка "Выход"
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        End
    End Sub

    ' Кнопка "Квадратный"
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Visible = False
        Form9.Show()
    End Sub

    ' Кнопка "Прямоугольный"
    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Me.Visible = False
        Form13.Show()
    End Sub
End Class