namespace WinFormsApp4;

internal partial class DashboardForm : Form
{
    public DashboardForm(UserAccount account)
    {
        InitializeComponent();
        userLabel.Text = $"{account.Name}\n{account.Email}";
        logoutButton.Click += LogoutButton_Click;
        addButton.Click += AddButton_Click;
        updateButton.Click += UpdateButton_Click;
        deleteButton.Click += DeleteButton_Click;
        clearButton.Click += ClearButton_Click;
        inventoryGrid.CellClick += InventoryGrid_CellClick;
        LoadInventory();
    }

    private void LogoutButton_Click(object? sender, EventArgs e)
    {
        Close();
    }

    private void LoadInventory()
    {
        inventoryGrid.Rows.Clear();
        foreach (var item in InventoryService.Instance.GetAll())
        {
            inventoryGrid.Rows.Add(item.Id, item.ItemName, item.Sku, item.Category, item.Quantity,
                item.UnitPrice.ToString("C2"), item.StockValue.ToString("C2"));
        }
    }

    private InventoryItem ReadEditor(int id = 0)
    {
        return new InventoryItem
        {
            Id = id,
            ItemName = itemNameTextBox.Text,
            Sku = skuTextBox.Text,
            Category = categoryTextBox.Text,
            Quantity = (int)quantityNumeric.Value,
            UnitPrice = priceNumeric.Value
        };
    }

    private void AddButton_Click(object? sender, EventArgs e)
    {
        if (InventoryService.Instance.Create(ReadEditor(), out var message))
        {
            LoadInventory();
            ClearEditor();
        }

        ShowStatus(message);
    }

    private void UpdateButton_Click(object? sender, EventArgs e)
    {
        if (inventoryGrid.CurrentRow is null)
        {
            ShowStatus("Select an item before updating.", true);
            return;
        }

        int id = Convert.ToInt32(inventoryGrid.CurrentRow.Cells[0].Value);
        if (InventoryService.Instance.Update(ReadEditor(id), out var message))
        {
            LoadInventory();
            ClearEditor();
        }

        ShowStatus(message);
    }

    private void DeleteButton_Click(object? sender, EventArgs e)
    {
        if (inventoryGrid.CurrentRow is null)
        {
            ShowStatus("Select an item before deleting.", true);
            return;
        }

        int id = Convert.ToInt32(inventoryGrid.CurrentRow.Cells[0].Value);
        if (MessageBox.Show("Delete the selected inventory item?", "Confirm delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) != DialogResult.Yes)
        {
            return;
        }

        if (InventoryService.Instance.Delete(id, out var message))
        {
            LoadInventory();
            ClearEditor();
        }

        ShowStatus(message);
    }

    private void ClearButton_Click(object? sender, EventArgs e)
    {
        ClearEditor();
        ShowStatus("Editor cleared.");
    }

    private void InventoryGrid_CellClick(object? sender, DataGridViewCellEventArgs e)
    {
        if (e.RowIndex < 0) return;

        var row = inventoryGrid.Rows[e.RowIndex];
        itemNameTextBox.Text = Convert.ToString(row.Cells[1].Value);
        skuTextBox.Text = Convert.ToString(row.Cells[2].Value);
        categoryTextBox.Text = Convert.ToString(row.Cells[3].Value);
        quantityNumeric.Value = Convert.ToDecimal(row.Cells[4].Value);
        decimal.TryParse(Convert.ToString(row.Cells[5].Value), System.Globalization.NumberStyles.Currency,
            System.Globalization.CultureInfo.CurrentCulture, out var price);
        priceNumeric.Value = Math.Min(priceNumeric.Maximum, Math.Max(priceNumeric.Minimum, price));
        ShowStatus("Item selected. Edit the fields and choose Update.");
    }

    private void ClearEditor()
    {
        itemNameTextBox.Clear();
        skuTextBox.Clear();
        categoryTextBox.Clear();
        quantityNumeric.Value = 0;
        priceNumeric.Value = 0;
        inventoryGrid.ClearSelection();
    }

    private void ShowStatus(string message, bool error = false)
    {
        statusLabel.ForeColor = error ? Color.FromArgb(180, 55, 90) : Color.FromArgb(91, 63, 145);
        statusLabel.Text = message;
    }
}
