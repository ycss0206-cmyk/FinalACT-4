namespace WinFormsApp4;

internal sealed class InventoryService
{
    private readonly List<InventoryItem> items = new();
    private int nextId = 1;

    public static InventoryService Instance { get; } = new();

    private InventoryService()
    {
        Create(new InventoryItem { ItemName = "Wireless Keyboard", Sku = "KB-1001", Category = "Accessories", Quantity = 24, UnitPrice = 29.99m }, out _);
        Create(new InventoryItem { ItemName = "USB-C Hub", Sku = "HB-2001", Category = "Accessories", Quantity = 16, UnitPrice = 39.50m }, out _);
        Create(new InventoryItem { ItemName = "Laptop Stand", Sku = "LS-3001", Category = "Office", Quantity = 9, UnitPrice = 54.00m }, out _);
    }

    public IReadOnlyList<InventoryItem> GetAll() => items.AsReadOnly();

    public bool Create(InventoryItem item, out string message)
    {
        if (!Validate(item, out message) || items.Any(existing => existing.Sku.Equals(item.Sku, StringComparison.OrdinalIgnoreCase)))
        {
            message = message.Length > 0 ? message : "SKU already exists.";
            return false;
        }

        item.Id = nextId++;
        item.ItemName = item.ItemName.Trim();
        item.Sku = item.Sku.Trim().ToUpperInvariant();
        item.Category = item.Category.Trim();
        items.Add(item);
        message = "Item added successfully.";
        return true;
    }

    public bool Update(InventoryItem item, out string message)
    {
        if (!Validate(item, out message)) return false;

        var existing = items.FirstOrDefault(value => value.Id == item.Id);
        if (existing is null)
        {
            message = "Select an item to update.";
            return false;
        }

        if (items.Any(value => value.Id != item.Id && value.Sku.Equals(item.Sku.Trim(), StringComparison.OrdinalIgnoreCase)))
        {
            message = "SKU already exists.";
            return false;
        }

        existing.ItemName = item.ItemName.Trim();
        existing.Sku = item.Sku.Trim().ToUpperInvariant();
        existing.Category = item.Category.Trim();
        existing.Quantity = item.Quantity;
        existing.UnitPrice = item.UnitPrice;
        message = "Item updated successfully.";
        return true;
    }

    public bool Delete(int id, out string message)
    {
        var item = items.FirstOrDefault(value => value.Id == id);
        if (item is null)
        {
            message = "Select an item to delete.";
            return false;
        }

        items.Remove(item);
        message = "Item deleted successfully.";
        return true;
    }

    private static bool Validate(InventoryItem item, out string message)
    {
        if (string.IsNullOrWhiteSpace(item.ItemName) || string.IsNullOrWhiteSpace(item.Sku) || string.IsNullOrWhiteSpace(item.Category))
        {
            message = "Item name, SKU, and category are required.";
            return false;
        }

        if (item.Quantity < 0 || item.UnitPrice < 0)
        {
            message = "Quantity and price cannot be negative.";
            return false;
        }

        message = string.Empty;
        return true;
    }
}
