namespace Azon.Business;

/*
    Chapter08'de ele alınacak örnek kodlar.
    InventoryProvider sınıfı için gerekli olan birim test metotları yazılacak. Senaryolarımız aşağıdaki gibi;

    - AddProduct_ShouldThrowException_WhenProductAlreadyExists. Ürün ekleme (AddProduct) testi. Ürün zaten stokta ise hata vermesi.
    - UpdateStock_ShouldReturnError_WhenProductNotFound. Ürün bulunamadığında hata döndürülmesi.
    - UpdateStock_ShouldFail_WhenStockIsInsufficient. Stok azalma sırasında yetersiz stok hatası verilmesi.
    - UpdateStock_ShouldFail_WhenExceedingMaxStockLimit. Maksimum stok limiti aşıldığında hata dönülmesi.
    - UpdateStock_ShouldUpdateCorrectly_WhenStockIsValid. Geçerli bir işlemde stok miktarının doğru güncellenmesi.

 */

public class InventoryItem
{
    public string ProductId { get; set; }
    public string Title { get; set; }
    public int Stock { get; set; }
    public int MaxStock { get; set; }
}

public class InventoryProvider
{
    private readonly Dictionary<string, InventoryItem> _inventory = new();

    public void AddProduct(string productId, string title, int maxStock)
    {
        if (_inventory.ContainsKey(productId))
        {
            throw new InvalidOperationException("Ürün zaten mevcut.");
        }

        _inventory[productId] = new InventoryItem
        {
            ProductId = productId,
            Title = title,
            MaxStock = maxStock,
            Stock = 0
        };
    }

    public string UpdateStock(string productId, int quantity)
    {
        if (!_inventory.TryGetValue(productId, out InventoryItem? item))
        {
            return "Ürün bulunamadı.";
        }

        if (quantity < 0 && Math.Abs(quantity) > item.Stock)
        {
            return "Yetersiz stok.";
        }

        if (quantity > 0 && (item.Stock + quantity) > item.MaxStock)
        {
            return "Maksimum stok limiti aşıldı.";
        }

        item.Stock += quantity;
        return "Stok güncellendi.";
    }

    public int GetStock(string productId)
    {
        if (!_inventory.ContainsKey(productId))
        {
            throw new InvalidOperationException("Ürün bulunamadı.");
        }

        return _inventory[productId].Stock;
    }
}
