Public Class InventorySystem
    Private _products As List(Of Product)
    Private _orders As List(Of Order)

    Public Sub New()
        _products = New List(Of Product)()
        _orders = New List(Of Order)()
    End Sub

    Public Sub AddProduct(product As Product)
        _products.Add(product)
    End Sub

    Public Sub CreateOrder(orderId As Integer, customer As Customer, productIds As List(Of Integer))
        Dim order As New Order(orderId, customer)
        For Each productId In productIds
            Dim product = _products.Find(Function(p) p.ProductId = productId)
            If product IsNot Nothing Then
                order.AddProduct(product)
            End If
        Next
        _orders.Add(order)
    End Sub

    Public Sub DisplayInventory()
        Console.WriteLine("Current Inventory:")
        For Each product In _products
            product.DisplayProductInfo()
        Next
    End Sub

    Public Sub DisplayOrders()
        Console.WriteLine("Order History:")
        For Each order In _orders
            order.DisplayOrderInfo()
        Next
    End Sub
End Class
