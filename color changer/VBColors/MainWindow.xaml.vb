Class MainWindow
    Private Sub bRed_Click(sender As Object, e As RoutedEventArgs) Handles bRed.Click
        Background.Background = Brushes.Red
        tbColorInfo.Text = "#FFFF0000"
    End Sub

    Private Sub bMaroon_Click(sender As Object, e As RoutedEventArgs) Handles bMaroon.Click
        Background.Background = Brushes.Maroon
        tbColorInfo.Text = "#FF800000"
    End Sub

    Private Sub bYellow_Click(sender As Object, e As RoutedEventArgs) Handles bYellow.Click
        Background.Background = Brushes.Yellow
        tbColorInfo.Text = "#FFFFFF00"
    End Sub

    Private Sub bOlive_Click(sender As Object, e As RoutedEventArgs) Handles bOlive.Click
        Background.Background = Brushes.Olive
        tbColorInfo.Text = "#FF808000"
    End Sub

    Private Sub bLime_Click(sender As Object, e As RoutedEventArgs) Handles bLime.Click
        Background.Background = Brushes.Lime
        tbColorInfo.Text = "#FF00FF00"
    End Sub

    Private Sub bAqua_Click(sender As Object, e As RoutedEventArgs) Handles bAqua.Click
        Background.Background = Brushes.Aqua
        tbColorInfo.Text = "#FF00FFFF"
    End Sub

    Private Sub bFuchsia_Click(sender As Object, e As RoutedEventArgs) Handles bFuchsia.Click
        Background.Background = Brushes.Fuchsia
        tbColorInfo.Text = "#FFFF00FF"
    End Sub

    Private Sub bPurple_Click(sender As Object, e As RoutedEventArgs) Handles bPurple.Click
        Background.Background = Brushes.Purple
        tbColorInfo.Text = "#FF800080"
    End Sub

    Private Sub bExit_Click(sender As Object, e As RoutedEventArgs) Handles bExit.Click
        System.Windows.Application.Current.Shutdown()
    End Sub
End Class
