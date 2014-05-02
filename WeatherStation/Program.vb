Public Class Program

    Public Shared Sub Main(args As String())
        Dim weatherData As New WeatherData()
        Dim currentDisplay As New CurrentConditionsDisplay(weatherData)

        weatherData.SetMeasurements("50", "20", "103.2")
        Console.ReadLine()
    End Sub
End Class
