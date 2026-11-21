namespace WinFormsApp4;

partial class DashboardForm
{
    private System.ComponentModel.IContainer? components = null;
    private Panel sidebar = null!;
    private Label userLabel = null!;
    private Button logoutButton = null!;
    private Label titleLabel = null!;
    private Label subtitleLabel = null!;
    private DataGridView inventoryGrid = null!;
    private GroupBox editorGroup = null!;
    private TextBox itemNameTextBox = null!;
    private TextBox skuTextBox = null!;
    private TextBox categoryTextBox = null!;
    private NumericUpDown quantityNumeric = null!;
    private NumericUpDown priceNumeric = null!;
    private Button addButton = null!;
    private Button updateButton = null!;
    private Button deleteButton = null!;
    private Button clearButton = null!;
    private Label statusLabel = null!;

    protected override void Dispose(bool disposing)
    {
        if (disposing && components != null)
        {
            components.Dispose();
        }

        base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
        components = new System.ComponentModel.Container();
        sidebar = new Panel();
        userLabel = new Label();
        logoutButton = new Button();
        titleLabel = new Label();
        subtitleLabel = new Label();
        inventoryGrid = new DataGridView();
        editorGroup = new GroupBox();
        itemNameTextBox = new TextBox();
        skuTextBox = new TextBox();
        categoryTextBox = new TextBox();
        quantityNumeric = new NumericUpDown();
        priceNumeric = new NumericUpDown();
        addButton = new Button();
        updateButton = new Button();
        deleteButton = new Button();
        clearButton = new Button();
        statusLabel = new Label();
        ((System.ComponentModel.ISupportInitialize)inventoryGrid).BeginInit();
        ((System.ComponentModel.ISupportInitialize)quantityNumeric).BeginInit();
        ((System.ComponentModel.ISupportInitialize)priceNumeric).BeginInit();

        sidebar.BackColor = Color.FromArgb(91, 63, 145);
        sidebar.Dock = DockStyle.Left;
        sidebar.Size = new Size(230, 680);
        sidebar.Controls.Add(userLabel);
        sidebar.Controls.Add(logoutButton);

        userLabel.AutoSize = false;
        userLabel.Font = new Font("Segoe UI", 10F, FontStyle.Regular);
        userLabel.ForeColor = Color.White;
        userLabel.Location = new Point(15, 35);
        userLabel.Size = new Size(200, 70);
        userLabel.TextAlign = ContentAlignment.MiddleCenter;

        logoutButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
        logoutButton.BackColor = Color.FromArgb(113, 82, 173);
        logoutButton.FlatAppearance.BorderColor = Color.FromArgb(174, 151, 218);
        logoutButton.FlatAppearance.BorderSize = 1;
        logoutButton.FlatStyle = FlatStyle.Flat;
        logoutButton.ForeColor = Color.White;
        logoutButton.Location = new Point(25, 615);
        logoutButton.Size = new Size(180, 38);
        logoutButton.Text = "Sign out";
        logoutButton.UseVisualStyleBackColor = false;

        titleLabel.AutoSize = true;
        titleLabel.Font = new Font("Segoe UI", 22F, FontStyle.Bold);
        titleLabel.ForeColor = Color.FromArgb(76, 48, 125);
        titleLabel.Location = new Point(265, 28);
        titleLabel.Text = "Inventory management";

        subtitleLabel.AutoSize = true;
        subtitleLabel.Font = new Font("Segoe UI", 10F);
        subtitleLabel.ForeColor = Color.FromArgb(98, 83, 119);
        subtitleLabel.Location = new Point(268, 68);
        subtitleLabel.Text = "Create, update, and track your stock in one place.";

        inventoryGrid.AllowUserToAddRows = false;
        inventoryGrid.AllowUserToDeleteRows = false;
        inventoryGrid.AllowUserToResizeRows = false;
        inventoryGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        inventoryGrid.BackgroundColor = Color.White;
        inventoryGrid.BorderStyle = BorderStyle.None;
        inventoryGrid.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(91, 63, 145);
        inventoryGrid.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
        inventoryGrid.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
        inventoryGrid.ColumnHeadersHeight = 34;
        inventoryGrid.EnableHeadersVisualStyles = false;
        inventoryGrid.Location = new Point(265, 105);
        inventoryGrid.MultiSelect = false;
        inventoryGrid.ReadOnly = true;
        inventoryGrid.RowHeadersVisible = false;
        inventoryGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        inventoryGrid.Size = new Size(765, 265);
        inventoryGrid.Columns.Add("Id", "ID");
        inventoryGrid.Columns.Add("ItemName", "Item name");
        inventoryGrid.Columns.Add("Sku", "SKU");
        inventoryGrid.Columns.Add("Category", "Category");
        inventoryGrid.Columns.Add("Quantity", "Quantity");
        inventoryGrid.Columns.Add("UnitPrice", "Unit price");
        inventoryGrid.Columns.Add("StockValue", "Stock value");
        inventoryGrid.Columns[0].FillWeight = 35;
        inventoryGrid.Columns[4].FillWeight = 55;

        editorGroup.BackColor = Color.White;
        editorGroup.ForeColor = Color.FromArgb(76, 48, 125);
        editorGroup.Location = new Point(265, 390);
        editorGroup.Size = new Size(765, 180);
        editorGroup.Text = "Inventory item details";
        editorGroup.Controls.Add(itemNameTextBox);
        editorGroup.Controls.Add(skuTextBox);
        editorGroup.Controls.Add(categoryTextBox);
        editorGroup.Controls.Add(quantityNumeric);
        editorGroup.Controls.Add(priceNumeric);
        editorGroup.Controls.Add(addButton);
        editorGroup.Controls.Add(updateButton);
        editorGroup.Controls.Add(deleteButton);
        editorGroup.Controls.Add(clearButton);
        AddEditorLabel("Item name", new Point(18, 30));
        AddEditorLabel("SKU", new Point(208, 30));
        AddEditorLabel("Category", new Point(398, 30));
        AddEditorLabel("Quantity", new Point(18, 82));
        AddEditorLabel("Unit price", new Point(208, 82));

        ConfigureEditorTextBox(itemNameTextBox, new Point(18, 48), "Enter item name");
        ConfigureEditorTextBox(skuTextBox, new Point(208, 48), "Enter SKU");
        ConfigureEditorTextBox(categoryTextBox, new Point(398, 48), "Enter category");
        quantityNumeric.Location = new Point(18, 100);
        quantityNumeric.Maximum = 1000000;
        quantityNumeric.Size = new Size(170, 23);
        priceNumeric.DecimalPlaces = 2;
        priceNumeric.Maximum = 1000000;
        priceNumeric.Location = new Point(208, 100);
        priceNumeric.Size = new Size(170, 23);

        ConfigureActionButton(addButton, "Add", new Point(398, 99), Color.FromArgb(91, 63, 145));
        ConfigureActionButton(updateButton, "Update", new Point(486, 99), Color.FromArgb(113, 82, 173));
        ConfigureActionButton(deleteButton, "Delete", new Point(574, 99), Color.FromArgb(180, 55, 90));
        ConfigureActionButton(clearButton, "Clear", new Point(662, 99), Color.FromArgb(120, 110, 135));

        statusLabel.AutoSize = true;
        statusLabel.ForeColor = Color.FromArgb(91, 63, 145);
        statusLabel.Location = new Point(265, 590);
        statusLabel.Text = "Select an item or add a new inventory record.";

        AutoScaleMode = AutoScaleMode.Font;
        BackColor = Color.FromArgb(248, 245, 253);
        ClientSize = new Size(1060, 680);
        Controls.Add(statusLabel);
        Controls.Add(editorGroup);
        Controls.Add(inventoryGrid);
        Controls.Add(subtitleLabel);
        Controls.Add(titleLabel);
        Controls.Add(sidebar);
        Font = new Font("Segoe UI", 9F);
        FormBorderStyle = FormBorderStyle.FixedSingle;
        MaximizeBox = false;
        StartPosition = FormStartPosition.CenterScreen;
        Text = "StockPilot | Dashboard";
        ((System.ComponentModel.ISupportInitialize)inventoryGrid).EndInit();
        ((System.ComponentModel.ISupportInitialize)quantityNumeric).EndInit();
        ((System.ComponentModel.ISupportInitialize)priceNumeric).EndInit();
    }

    private void AddEditorLabel(string text, Point location)
    {
        var label = new Label
        {
            AutoSize = true,
            Font = new Font("Segoe UI", 8F, FontStyle.Bold),
            ForeColor = Color.FromArgb(98, 83, 119),
            Location = location,
            Text = text
        };
        editorGroup.Controls.Add(label);
    }

    private static void ConfigureEditorTextBox(TextBox textBox, Point location, string placeholder)
    {
        textBox.BorderStyle = BorderStyle.FixedSingle;
        textBox.Location = location;
        textBox.PlaceholderText = placeholder;
        textBox.Size = new Size(170, 23);
    }

    private static void ConfigureActionButton(Button button, string text, Point location, Color backColor)
    {
        button.BackColor = backColor;
        button.FlatAppearance.BorderSize = 0;
        button.FlatStyle = FlatStyle.Flat;
        button.ForeColor = Color.White;
        button.Location = location;
        button.Size = new Size(80, 29);
        button.Text = text;
        button.UseVisualStyleBackColor = false;
    }
}