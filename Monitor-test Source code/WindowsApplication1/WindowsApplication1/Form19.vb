﻿Public Class Form19

    ' Кнопка "Выход"
    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        End
    End Sub

    ' Кнопка "Назад"
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Visible = False
        Form18.Show()
    End Sub

    ' Кнопка "Вперёд"
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Visible = False
        Form20.Show()
    End Sub

    ' Кнопка "Меню"
    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Me.Visible = False
        Form1.Show()
    End Sub

End Class