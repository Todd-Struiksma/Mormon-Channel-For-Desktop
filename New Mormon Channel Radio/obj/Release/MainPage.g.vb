﻿

#ExternalChecksum("C:\Users\Todd\documents\visual studio 2013\Projects\New Mormon Channel Radio\New Mormon Channel Radio\MainPage.xaml", "{406ea660-64cf-4c82-b6f0-42d48172a799}", "AB8A9D23F5B110EE7768D10C42925BB1")
'------------------------------------------------------------------------------
' <auto-generated>
'     This code was generated by a tool.
'
'     Changes to this file may cause incorrect behavior and will be lost if
'     the code is regenerated.
' </auto-generated>
'------------------------------------------------------------------------------

Option Strict Off
Option Explicit On

Namespace Global.New_Mormon_Channel_Radio

    Partial Class MainPage
        Implements Global.Windows.UI.Xaml.Markup.IComponentConnector

        <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks", "4.0.0.0")>  _
        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute()>  _
        Public Sub Connect(ByVal connectionId As Integer, ByVal target As Global.System.Object) Implements Global.Windows.UI.Xaml.Markup.IComponentConnector.Connect
            If(connectionId = 1) Then
                #ExternalSource("..\..\MainPage.xaml",10)
                AddHandler CType(target,Global.Windows.UI.Xaml.Controls.Primitives.ButtonBase).Click, AddressOf Me.AppBarButton_Click
                #End ExternalSource
            Else If(connectionId = 2) Then
                #ExternalSource("..\..\MainPage.xaml",11)
                AddHandler CType(target,Global.Windows.UI.Xaml.Controls.Primitives.ButtonBase).Click, AddressOf Me.AppBarButton_Click_1
                #End ExternalSource
            Else If(connectionId = 3) Then
                #ExternalSource("..\..\MainPage.xaml",12)
                AddHandler CType(target,Global.Windows.UI.Xaml.Controls.Primitives.ButtonBase).Click, AddressOf Me.AppBarButton_Click_2
                #End ExternalSource
            Else If(connectionId = 4) Then
                #ExternalSource("..\..\MainPage.xaml",15)
                AddHandler CType(target,Global.Windows.UI.Xaml.Controls.Primitives.ButtonBase).Click, AddressOf Me.AppBarButton_Click_3
                #End ExternalSource
            End If
            Me._contentLoaded = true
        End Sub
    End Class

End Namespace


