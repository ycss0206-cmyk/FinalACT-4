namespace WinFormsApp4;

partial class Form1
{
    private System.ComponentModel.IContainer? components = null;
    private Panel brandPanel = null!;
    private Panel authPanel = null!;
    private Label logoLabel = null!;
    private Label brandTitleLabel = null!;
    private Label brandDescriptionLabel = null!;
    private Label statLabel = null!;
    private Label welcomeLabel = null!;
    private Label subtitleLabel = null!;
    private Label nameLabel = null!;
    private TextBox nameTextBox = null!;
    private Label emailLabel = null!;
    private TextBox emailTextBox = null!;
    private Label passwordLabel = null!;
    private TextBox passwordTextBox = null!;
    private Label confirmPasswordLabel = null!;
    private TextBox confirmPasswordTextBox = null!;
    private CheckBox showPasswordCheckBox = null!;
    private Button submitButton = null!;
    private Button modeButton = null!;
    private Label modePromptLabel = null!;
    private Label statusLabel = null!;
    private Label demoLabel = null!;

    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null)) components.Dispose();
        base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
        brandPanel = new Panel();
        statLabel = new Label();
        brandDescriptionLabel = new Label();
        brandTitleLabel = new Label();
        logoLabel = new Label();
        authPanel = new Panel();
        demoLabel = new Label();
        statusLabel = new Label();
        modeButton = new Button();
        modePromptLabel = new Label();
        submitButton = new Button();
        showPasswordCheckBox = new CheckBox();
        passwordTextBox = new TextBox();
        confirmPasswordLabel = new Label();
        confirmPasswordTextBox = new TextBox();
        passwordLabel = new Label();
        emailTextBox = new TextBox();
        emailLabel = new Label();
        nameTextBox = new TextBox();
        nameLabel = new Label();
        subtitleLabel = new Label();
        welcomeLabel = new Label();
        brandPanel.SuspendLayout();
        authPanel.SuspendLayout();
        SuspendLayout();
        // 
        // brandPanel
        // 
        brandPanel.BackColor = Color.FromArgb(91, 63, 145);
        brandPanel.Controls.Add(statLabel);
        brandPanel.Controls.Add(brandDescriptionLabel);
        brandPanel.Controls.Add(brandTitleLabel);
        brandPanel.Controls.Add(logoLabel);
        brandPanel.Dock = DockStyle.Left;
        brandPanel.Location = new Point(0, 0);
        brandPanel.Name = "brandPanel";
        brandPanel.Padding = new Padding(48);
        brandPanel.Size = new Size(390, 650);
        brandPanel.TabIndex = 0;
      
        statLabel.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
        statLabel.ForeColor = Color.FromArgb(224, 207, 255);
        statLabel.Location = new Point(52, 535);
        statLabel.Name = "statLabel";
        statLabel.Size = new Size(280, 40);
        statLabel.TabIndex = 0;
        statLabel.Text = "●  SYSTEM STATUS  •  ALL SYSTEMS OPERATIONAL";
       
        brandDescriptionLabel.Font = new Font("Segoe UI", 11F);
        brandDescriptionLabel.ForeColor = Color.FromArgb(232, 224, 247);
        brandDescriptionLabel.Location = new Point(52, 310);
        brandDescriptionLabel.Name = "brandDescriptionLabel";
        brandDescriptionLabel.Size = new Size(275, 82);
        brandDescriptionLabel.TabIndex = 1;
        brandDescriptionLabel.Text = "Track your stock, orders, and team from one calm, intelligent workspace.";
       
        brandTitleLabel.Font = new Font("Segoe UI", 27F, FontStyle.Bold);
        brandTitleLabel.ForeColor = Color.White;
        brandTitleLabel.Location = new Point(48, 165);
        brandTitleLabel.Name = "brandTitleLabel";
        brandTitleLabel.Size = new Size(285, 125);
        brandTitleLabel.TabIndex = 2;
        brandTitleLabel.Text = "Inventory\nmade simple.";
       
        logoLabel.AutoSize = true;
        logoLabel.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
        logoLabel.ForeColor = Color.FromArgb(245, 239, 255);
        logoLabel.Location = new Point(48, 48);
        logoLabel.Name = "logoLabel";
        logoLabel.Size = new Size(190, 32);
        logoLabel.TabIndex = 3;
        logoLabel.Text = "◆  STOCKPILOT";
        
        authPanel.BackColor = Color.FromArgb(248, 245, 253);
        authPanel.Controls.Add(demoLabel);
        authPanel.Controls.Add(statusLabel);
        authPanel.Controls.Add(modeButton);
        authPanel.Controls.Add(modePromptLabel);
        authPanel.Controls.Add(submitButton);
        authPanel.Controls.Add(showPasswordCheckBox);
        authPanel.Controls.Add(confirmPasswordTextBox);
        authPanel.Controls.Add(confirmPasswordLabel);
        authPanel.Controls.Add(passwordTextBox);
        authPanel.Controls.Add(passwordLabel);
        authPanel.Controls.Add(emailTextBox);
        authPanel.Controls.Add(emailLabel);
        authPanel.Controls.Add(nameTextBox);
        authPanel.Controls.Add(nameLabel);
        authPanel.Controls.Add(subtitleLabel);
        authPanel.Controls.Add(welcomeLabel);
        authPanel.Dock = DockStyle.Fill;
        authPanel.Location = new Point(0, 0);
        authPanel.Name = "authPanel";
        authPanel.Padding = new Padding(70, 42, 70, 35);
        authPanel.Size = new Size(930, 650);
        authPanel.TabIndex = 0;
      
        demoLabel.Font = new Font("Segoe UI", 8.5F);
        demoLabel.ForeColor = Color.FromArgb(140, 151, 164);
        demoLabel.Location = new Point(70, 394);
        demoLabel.Name = "demoLabel";
        demoLabel.Size = new Size(390, 38);
        demoLabel.TabIndex = 0;
        demoLabel.Text = "Demo access: admin@stockpilot.com  /  Admin123!";
       
        statusLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
        statusLabel.ForeColor = Color.FromArgb(180, 55, 90);
        statusLabel.Location = new Point(70, 390);
        statusLabel.Name = "statusLabel";
        statusLabel.Size = new Size(390, 42);
        statusLabel.TabIndex = 1;
       
        modeButton.FlatAppearance.BorderSize = 0;
        modeButton.FlatStyle = FlatStyle.Flat;
        modeButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
        modeButton.ForeColor = Color.FromArgb(91, 63, 145);
        modeButton.Location = new Point(180, 350);
        modeButton.Name = "modeButton";
        modeButton.Size = new Size(130, 30);
        modeButton.TabIndex = 2;
        modeButton.Text = "Create an account";
       
        modePromptLabel.AutoSize = true;
        modePromptLabel.Font = new Font("Segoe UI", 9F);
        modePromptLabel.ForeColor = Color.FromArgb(104, 119, 137);
        modePromptLabel.Location = new Point(70, 355);
        modePromptLabel.Name = "modePromptLabel";
        modePromptLabel.Size = new Size(106, 15);
        modePromptLabel.TabIndex = 3;
       
        submitButton.BackColor = Color.FromArgb(91, 63, 145);
        submitButton.FlatAppearance.BorderSize = 0;
        submitButton.FlatStyle = FlatStyle.Flat;
        submitButton.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
        submitButton.ForeColor = Color.White;
        submitButton.Location = new Point(70, 287);
        submitButton.Name = "submitButton";
        submitButton.Size = new Size(390, 45);
        submitButton.TabIndex = 4;
        submitButton.Text = "Sign in to dashboard";
        submitButton.UseVisualStyleBackColor = false;
        
        showPasswordCheckBox.AutoSize = true;
        showPasswordCheckBox.Font = new Font("Segoe UI", 9F);
        showPasswordCheckBox.ForeColor = Color.FromArgb(98, 83, 119);
        showPasswordCheckBox.Location = new Point(70, 247);
        showPasswordCheckBox.Name = "showPasswordCheckBox";
        showPasswordCheckBox.Size = new Size(108, 19);
        showPasswordCheckBox.TabIndex = 5;
        showPasswordCheckBox.Text = "Show password";
        
        passwordTextBox.BackColor = Color.White;
        passwordTextBox.BorderStyle = BorderStyle.FixedSingle;
        passwordTextBox.Font = new Font("Segoe UI", 11F);
        passwordTextBox.Location = new Point(70, 203);
        passwordTextBox.Name = "passwordTextBox";
        passwordTextBox.Size = new Size(390, 27);
        passwordTextBox.TabIndex = 8;
        passwordTextBox.UseSystemPasswordChar = true;
        
        confirmPasswordLabel.AutoSize = true;
        confirmPasswordLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
        confirmPasswordLabel.ForeColor = Color.FromArgb(56, 70, 88);
        confirmPasswordLabel.Location = new Point(74, 248);
        confirmPasswordLabel.Name = "confirmPasswordLabel";
        confirmPasswordLabel.Size = new Size(139, 15);
        confirmPasswordLabel.TabIndex = 8;
        confirmPasswordLabel.Text = "CONFIRM PASSWORD";
        confirmPasswordLabel.Visible = false;
       
        confirmPasswordTextBox.BackColor = Color.White;
        confirmPasswordTextBox.BorderStyle = BorderStyle.FixedSingle;
        confirmPasswordTextBox.Font = new Font("Segoe UI", 11F);
        confirmPasswordTextBox.Location = new Point(70, 268);
        confirmPasswordTextBox.Name = "confirmPasswordTextBox";
        confirmPasswordTextBox.Size = new Size(390, 27);
        confirmPasswordTextBox.TabIndex = 9;
        confirmPasswordTextBox.UseSystemPasswordChar = true;
        confirmPasswordTextBox.Visible = false;
        
        passwordLabel.AutoSize = true;
        passwordLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
        passwordLabel.ForeColor = Color.FromArgb(56, 70, 88);
        passwordLabel.Location = new Point(74, 183);
        passwordLabel.Name = "passwordLabel";
        passwordLabel.Size = new Size(73, 15);
        passwordLabel.TabIndex = 9;
        passwordLabel.Text = "PASSWORD";
       
        emailTextBox.BackColor = Color.White;
        emailTextBox.BorderStyle = BorderStyle.FixedSingle;
        emailTextBox.Font = new Font("Segoe UI", 11F);
        emailTextBox.Location = new Point(70, 138);
        emailTextBox.Name = "emailTextBox";
        emailTextBox.Size = new Size(390, 27);
        emailTextBox.TabIndex = 10;
       
        emailLabel.AutoSize = true;
        emailLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
        emailLabel.ForeColor = Color.FromArgb(56, 70, 88);
        emailLabel.Location = new Point(74, 118);
        emailLabel.Name = "emailLabel";
        emailLabel.Size = new Size(99, 15);
        emailLabel.TabIndex = 11;
        emailLabel.Text = "EMAIL ADDRESS / USERNAME";
      
        nameTextBox.BackColor = Color.White;
        nameTextBox.BorderStyle = BorderStyle.FixedSingle;
        nameTextBox.Font = new Font("Segoe UI", 11F);
        nameTextBox.Location = new Point(70, 138);
        nameTextBox.Name = "nameTextBox";
        nameTextBox.Size = new Size(390, 27);
        nameTextBox.TabIndex = 12;
        nameTextBox.Visible = false;
       
        nameLabel.AutoSize = true;
        nameLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
        nameLabel.ForeColor = Color.FromArgb(56, 70, 88);
        nameLabel.Location = new Point(74, 118);
        nameLabel.Name = "nameLabel";
        nameLabel.Size = new Size(71, 15);
        nameLabel.TabIndex = 13;
        nameLabel.Text = "FULL NAME";
        nameLabel.Visible = false;
       
        subtitleLabel.AutoSize = true;
        subtitleLabel.Font = new Font("Segoe UI", 10F);
        subtitleLabel.ForeColor = Color.FromArgb(98, 83, 119);
        subtitleLabel.Location = new Point(74, 84);
        subtitleLabel.Name = "subtitleLabel";
        subtitleLabel.Size = new Size(244, 19);
        subtitleLabel.TabIndex = 14;
        subtitleLabel.Text = "Sign in to continue to your workspace.";
        
        welcomeLabel.AutoSize = true;
        welcomeLabel.Font = new Font("Segoe UI", 24F, FontStyle.Bold);
        welcomeLabel.ForeColor = Color.FromArgb(76, 48, 125);
        welcomeLabel.Location = new Point(70, 42);
        welcomeLabel.Name = "welcomeLabel";
        welcomeLabel.Size = new Size(237, 45);
        welcomeLabel.TabIndex = 15;
        welcomeLabel.Text = "Welcome back";
       
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = Color.FromArgb(248, 245, 253);
        ClientSize = new Size(930, 650);
        Controls.Add(authPanel);
        Font = new Font("Segoe UI", 9F);
        FormBorderStyle = FormBorderStyle.FixedSingle;
        MaximizeBox = false;
        MinimumSize = new Size(930, 650);
        Name = "Form1";
        StartPosition = FormStartPosition.CenterScreen;
        Text = "StockPilot | Sign in";
        brandPanel.ResumeLayout(false);
        brandPanel.PerformLayout();
        authPanel.ResumeLayout(false);
        authPanel.PerformLayout();
        ResumeLayout(false);
    }
}