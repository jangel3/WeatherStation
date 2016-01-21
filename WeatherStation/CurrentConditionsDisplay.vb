Public Class CurrentConditionsDisplay
    Implements Observer, DisplayElement

    Private temperature As String
    Private humidity As String
    Private pressure As String
    Private weatherData As Subject

    Public Sub New(weatherData As Subject)
        Me.weatherData = weatherData
        weatherData.RegisterObserver(Me)
    End Sub
    Public Sub Display() Implements DisplayElement.Display
        Console.WriteLine("Current conditions: " + temperature + "F degrees and " + humidity + "% humidity")
    End Sub

    Public Sub Update(temperature As String, humidity As String, pressure As String) Implements Observer.Update
        Me.temperature = temperature
        Me.humidity = humidity
        Me.pressure = pressure
        REM Testing purposes
        Display()
    End Sub
End Class