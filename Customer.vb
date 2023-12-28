Public Class Customer
    Private _customerId As Integer
    Private _customerName As String
    Private _email As String

    Public Sub New(customerId As Integer, customerName As String, email As String)
        _customerId = customerId
        _customerName = customerName
        _email = email
    End Sub

    Public ReadOnly Property CustomerId As Integer
        Get
            Return _customerId
        End Get
    End Property

    Public ReadOnly Property CustomerName As String
        Get
            Return _customerName
        End Get
    End Property

    Public ReadOnly Property Email As String
        Get
            Return _email
        End Get
    End Property

    Public Sub DisplayCustomerInfo()
        Console.WriteLine($"Customer ID: {_customerId}")
        Console.WriteLine($"Customer Name: {_customerName}")
        Console.WriteLine($"Email: {_email}")
    End Sub
End Class
