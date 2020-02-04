Class MainWindow
    Private Sub MainWindow_Loaded(sender As Object, e As RoutedEventArgs) Handles Me.Loaded

        For Each C As UIElement In Background.Children ' Search every item in Grid:Background.
            If TypeOf C Is Button Then 'Is current item is a button ?

                With DirectCast(C, Button)  'Use [DirectCast] To adapt current item As button.

                    '[.DataContext] ? it effect of [With] above, it equal [DirectCast(C, Button).DataContext]
                    If .DataContext IsNot Nothing Then AddHandler .Click,
                        Sub()
                            Background.Background = .Background 'We can use color from other item.

                            'I add color code in DataContext at design page(xaml), make it easier to set it all at once.
                            tbColorInfo.Text = .DataContext
                        End Sub

                End With

            End If
        Next

        'If we don't need [sender As Object] or [e As RoutedEventArgs] just left it out.
        AddHandler bExit.Click, Sub()
                                    Application.Current.Shutdown()
                                End Sub
    End Sub
End Class
