

' The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

'Declaration



Public NotInheritable Class MainPage
    Inherits Page






    Private Sub AppBarButton_Click(sender As Object, e As RoutedEventArgs)
        MediaElement.Source = (New Uri("http://d1jwofs8l1nyio.cloudfront.net/new_mormon"))

    End Sub

    Private Sub MediaElement_MediaOpened(sender As Object, e As RoutedEventArgs)

        '  Slider.Value = MediaElement.Volume * 100
    End Sub


    Private Sub AppBarButton_Click_1(sender As Object, e As RoutedEventArgs)
        MediaElement.Source = (New Uri("http://d1jwofs8l1nyio.cloudfront.net/new_music"))
    End Sub



    Private Sub AppBarButton_Click_2(sender As Object, e As RoutedEventArgs)
        MediaElement.Source = (New Uri("http://d1jwofs8l1nyio.cloudfront.net/spanish"))
    End Sub

    Private Sub AppBarButton_Click_3(sender As Object, e As RoutedEventArgs)

        MediaElement.Source = (New Uri("http://d1jwofs8l1nyio.cloudfront.net/motab"))



    End Sub


    Private Sub Slider_ValueChanged_1(sender As Object, e As RangeBaseValueChangedEventArgs) Handles Slider.ValueChanged
        MediaElement.Volume = Slider.Value.ToString / 100
    End Sub

    Private Sub MediaElement_MediaOpened_1(sender As Object, e As RoutedEventArgs) Handles MediaElement.MediaOpened
        MediaElement.Volume = Slider.Value.ToString / 100
        ' Slider.Value = MediaElement.Volume.ToString * 100
    End Sub


    Private Sub MainPage_Loaded(sender As Object, e As RoutedEventArgs) Handles Me.Loaded
    End Sub
End Class

