﻿Public NotInheritable Class SplashScreen1

    'TODO: легко использовать эту форму в качестве заставки. Это можно сделать на вкладке "Приложение"
    '  конструктора проектов (пункт "Свойства" в меню "Проект").


    Private Sub SplashScreen1_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        'Установить текст диалога во время выполнения в соответствии с информацией о сборке приложения.  

        'TODO: настроить сведения о сборке приложения в области "Приложение" диалогового окна 
        '  свойств проекта (в меню "Проект").

        'Отформатировать информацию о версии с использованием в качестве строки формата текста,
        '  установленного для контроля версий во время разработки. При необходимости это может использоваться для эффективной локализации.
        '  Информация о построении и редакции может быть включена на основе следующего кода с заменой 
        '  текста, установленного для контроля версий во время разработки, на строку типа "Версия {0}.{1:00}.{2}.{3}". Подробнее см.
        '  справку по String.Format().
        '
        '    Version.Text = System.String.Format(Version.Text, My.Application.Info.Version.Major, My.Application.Info.Version.Minor, My.Application.Info.Version.Build, My.Application.Info.Version.Revision)

        Version.Text = System.String.Format(Version.Text, My.Application.Info.Version.Major, My.Application.Info.Version.Minor)
    End Sub

    Private Sub ApplicationTitle_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ApplicationTitle.Click

    End Sub

    Private Sub Version_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Version.Click

    End Sub
End Class
