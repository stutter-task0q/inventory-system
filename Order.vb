Public Class Order
    Private _orderId As Integer
    Private _customer As Customer
    Private _products As List(Of Product)

    Public Sub New(orderId As Integer, customer As Customer)
        _orderId = orderId
        _customer = customer
        _products = New List(Of Product)()
    End Sub

    Public ReadOnly Property OrderId As Integer
        Get
            Return _orderId
        End Get
    End Property

    Public ReadOnly Property Customer As Customer
        Get
            Return _customer
        End Get
    End Property

    Public ReadOnly Property Products As List(Of Product)
        Get
            Return _products
        End Get
    End Property

    Public Sub AddProduct(product As Product)
        _products.Add(product)
    End Sub

    Public Function CalculateTotal() As Double
        Dim total As Double = 0
        For Each product In _products
            total += product.Price
        Next
        Return total
    End Function

    Public Sub DisplayOrderInfo()
        Console.WriteLine($"Order ID: {_orderId}")
        _customer.DisplayCustomerInfo()
        Console.WriteLine("Products in the order:")
        For Each product In _products
            product.DisplayProductInfo()
        Next
        Console.WriteLine($"Total: ${CalculateTotal()}")
    End Sub
End Class
