Public Class Product
    Private _productId As Integer
    Private _productName As String
    Private _price As Double

    Public Sub New(productId As Integer, productName As String, price As Double)
        _productId = productId
        _productName = productName
        _price = price
    End Sub

    Public ReadOnly Property ProductId As Integer
        Get
            Return _productId
        End Get
    End Property

    Public ReadOnly Property ProductName As String
        Get
            Return _productName
        End Get
    End Property

    Public ReadOnly Property Price As Double
        Get
            Return _price
        End Get
    End Property

    Public Sub DisplayProductInfo()
        Console.WriteLine($"Product ID: {_productId}")
        Console.WriteLine($"Product Name: {_productName}")
        Console.WriteLine($"Price: ${_price}")
    End Sub
End Class
