Public Interface Subject

    Sub RegisterObserver(o As Observer)
    Sub RemoverObserver(o As Observer)
    Sub NotifyObservers()
End Interface
