Public NotInheritable Class SystemMediaTransportControls
    Public Property IsPlayEnabled As Boolean
    Public Property IsPauseEnabled As Boolean
    Public Event ButtonPressed As TypedEventHandler(Of SystemMediaTransportControls, SystemMediaTransportControlsButtonPressedEventArgs)
End Class
