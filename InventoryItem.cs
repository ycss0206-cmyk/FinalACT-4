namespace WinFormsApp4;

internal sealed class InventoryItem
{
    public int Id { get; set; }
    public string ItemName { get; set; } = string.Empty;
    public string Sku { get; set; } = string.Empty;
    public string Category { get; set; } = string.Empty;
    public int Quantity { get; set; }
    public decimal UnitPrice { get; set; }
    public decimal StockValue => Quantity * UnitPrice;
}
