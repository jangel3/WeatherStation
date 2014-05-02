Imports System.Collections.Generic

Public Class WeatherData
    Implements Subject

    'Delegate Sub MeasurementsChanged()
    Public Event MeasurementsChanging As EventHandler

    Private observers As List(Of Observer)
    Private temperature As String
    Private humidity As String
    Private pressure As String

    Public Sub New()
        observers = New List(Of Observer)
    End Sub

    Public Sub GetTemperature()

    End Sub

    Public Sub GetHumidity()

    End Sub

    Public Sub GetPressure()

    End Sub

    Public Sub OnChange() Handles Me.MeasurementsChanging
        NotifyObservers()
    End Sub

    Public Sub RegisterObserver(o As Observer) Implements Subject.RegisterObserver
        observers.Add(o)
    End Sub

    Public Sub RemoverObserver(o As Observer) Implements Subject.RemoverObserver
        Dim i As Int32 = observers.IndexOf(o)
        If (i >= 0) Then
            observers.Remove(o)
        End If
    End Sub

    Public Sub NotifyObservers() Implements Subject.NotifyObservers
        For Each o As Observer In observers
            o.Update(temperature, humidity, pressure)
        Next
    End Sub

    Public Sub SetMeasurements(temperature As String, humidity As String, pressure As String)
        'Dim ev As New MeasurementsChanged(AddressOf NotifyObservers)
        Me.temperature = temperature
        Me.humidity = humidity
        Me.pressure = pressure
        RaiseEvent MeasurementsChanging(Me, EventArgs.Empty)
    End Sub
End Class
