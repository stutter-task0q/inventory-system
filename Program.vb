Module Program
    Sub Main()
        ' Create the inventory system
        Dim inventorySystem As New InventorySystem()

        ' Add products to the inventory
        inventorySystem.AddProduct(New Product(1, "Laptop", 999.99))
        inventorySystem.AddProduct(New Product(2, "Smartphone", 499.99))

        ' Create customers
        Dim customer1 As New Customer(101, "Alice", "alice@example.com")
        Dim customer2 As New Customer(102, "Bob", "bob@example.com")

        ' Create orders
        inventorySystem.CreateOrder(201, customer1, New List(Of Integer) From {1, 2})
        inventorySystem.CreateOrder(202, customer2, New List(Of Integer) From {2})

        ' Display the updated inventory and order history
        inventorySystem.DisplayInventory()
        inventorySystem.DisplayOrders()
    End Sub
End Module
