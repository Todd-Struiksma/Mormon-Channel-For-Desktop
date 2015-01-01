' The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

'Declaration

Public NotInheritable Class MainPage
    Inherits Page

    Private Sub AppBarButton_Click(sender As Object, e As RoutedEventArgs)
        MediaElement.Source = (New Uri("http://d1jwofs8l1nyio.cloudfront.net/new_mormon"))

    End Sub

    Private Sub MediaElement_MediaOpened(sender As Object, e As RoutedEventArgs)

    End Sub

    Private Sub Button_Click_1(sender As Object, e As RoutedEventArgs)

        Frame.Height = "50"

        MediaElement.Volume = 0.5
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

    Private Sub Button_Click(sender As Object, e As RoutedEventArgs)

    End Sub

    Private Sub Slider_ValueChanged(sender As Object, e As RangeBaseValueChangedEventArgs)
        MediaElement.Volume = Slider.Value.ToString / 100
    End Sub

  
End Class
