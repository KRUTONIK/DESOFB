namespace DesOfbFileCipher;

partial class MainForm
{
    private System.ComponentModel.IContainer? components = null;
    private MenuStrip menuStrip = null!;
    private ToolStripMenuItem fileMenuItem = null!;
    private ToolStripMenuItem selectFileMenuItem = null!;
    private ToolStripMenuItem encryptMenuItem = null!;
    private ToolStripMenuItem decryptMenuItem = null!;
    private ToolStripMenuItem exitMenuItem = null!;
    private ToolStripMenuItem helpMenuItem = null!;
    private ToolStripMenuItem studentInfoMenuItem = null!;
    private ToolStripMenuItem variantMenuItem = null!;
    private ToolStripMenuItem algorithmMenuItem = null!;
    private ToolStripMenuItem aboutMenuItem = null!;
    private Label titleLabel = null!;
    private GroupBox sourceGroupBox = null!;
    private TextBox sourcePathTextBox = null!;
    private Button selectFileButton = null!;
    private Label sizeLabel = null!;
    private Label sizeValueLabel = null!;
    private GroupBox passwordGroupBox = null!;
    private TextBox passwordTextBox = null!;
    private Button passwordFileButton = null!;
    private Label passwordSourceLabel = null!;
    private Button encryptButton = null!;
    private Button decryptButton = null!;
    private Label statusLabel = null!;
    private Label studentLabel = null!;
    private Label variantLabel = null!;

    protected override void Dispose(bool disposing)
    {
        if (disposing && components is not null)
            components.Dispose();
        base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
        components = new System.ComponentModel.Container();
        menuStrip = new MenuStrip();
        fileMenuItem = new ToolStripMenuItem();
        selectFileMenuItem = new ToolStripMenuItem();
        encryptMenuItem = new ToolStripMenuItem();
        decryptMenuItem = new ToolStripMenuItem();
        exitMenuItem = new ToolStripMenuItem();
        helpMenuItem = new ToolStripMenuItem();
        studentInfoMenuItem = new ToolStripMenuItem();
        variantMenuItem = new ToolStripMenuItem();
        algorithmMenuItem = new ToolStripMenuItem();
        aboutMenuItem = new ToolStripMenuItem();
        titleLabel = new Label();
        sourceGroupBox = new GroupBox();
        sourcePathTextBox = new TextBox();
        selectFileButton = new Button();
        sizeLabel = new Label();
        sizeValueLabel = new Label();
        passwordGroupBox = new GroupBox();
        passwordTextBox = new TextBox();
        passwordFileButton = new Button();
        passwordSourceLabel = new Label();
        encryptButton = new Button();
        decryptButton = new Button();
        statusLabel = new Label();
        studentLabel = new Label();
        variantLabel = new Label();
        menuStrip.SuspendLayout();
        sourceGroupBox.SuspendLayout();
        passwordGroupBox.SuspendLayout();
        SuspendLayout();

        menuStrip.Items.AddRange(new ToolStripItem[] { fileMenuItem, helpMenuItem });
        menuStrip.Location = new Point(0, 0);
        menuStrip.Name = "menuStrip";
        menuStrip.Size = new Size(824, 24);

        fileMenuItem.DropDownItems.AddRange(new ToolStripItem[]
        {
            selectFileMenuItem,
            new ToolStripSeparator(),
            encryptMenuItem,
            decryptMenuItem,
            new ToolStripSeparator(),
            exitMenuItem
        });
        fileMenuItem.Text = "Файл";

        selectFileMenuItem.Text = "Выбрать исходный файл...";
        selectFileMenuItem.Click += selectFileMenuItem_Click;
        encryptMenuItem.Text = "Зашифровать...";
        encryptMenuItem.Click += encryptMenuItem_Click;
        decryptMenuItem.Text = "Расшифровать...";
        decryptMenuItem.Click += decryptMenuItem_Click;
        exitMenuItem.Text = "Выход";
        exitMenuItem.Click += exitMenuItem_Click;

        helpMenuItem.DropDownItems.AddRange(new ToolStripItem[]
        {
            studentInfoMenuItem,
            variantMenuItem,
            algorithmMenuItem,
            aboutMenuItem
        });
        helpMenuItem.Text = "Справка";
        studentInfoMenuItem.Text = "Данные студента";
        studentInfoMenuItem.Click += studentInfoMenuItem_Click;
        variantMenuItem.Text = "Вариант";
        variantMenuItem.Click += variantMenuItem_Click;
        algorithmMenuItem.Text = "Алгоритм DES-OFB";
        algorithmMenuItem.Click += algorithmMenuItem_Click;
        aboutMenuItem.Text = "О программе";
        aboutMenuItem.Click += aboutMenuItem_Click;

        titleLabel.AutoSize = true;
        titleLabel.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
        titleLabel.Location = new Point(24, 48);
        titleLabel.Text = "Шифрование файлов DES-OFB";

        sourceGroupBox.Controls.Add(sourcePathTextBox);
        sourceGroupBox.Controls.Add(selectFileButton);
        sourceGroupBox.Controls.Add(sizeLabel);
        sourceGroupBox.Controls.Add(sizeValueLabel);
        sourceGroupBox.Location = new Point(24, 96);
        sourceGroupBox.Size = new Size(776, 116);
        sourceGroupBox.Text = "Исходный файл";

        sourcePathTextBox.Location = new Point(18, 31);
        sourcePathTextBox.ReadOnly = true;
        sourcePathTextBox.Size = new Size(613, 23);

        selectFileButton.Location = new Point(642, 30);
        selectFileButton.Size = new Size(116, 25);
        selectFileButton.Text = "Выбрать...";
        selectFileButton.UseVisualStyleBackColor = true;
        selectFileButton.Click += selectFileButton_Click;

        sizeLabel.AutoSize = true;
        sizeLabel.Location = new Point(18, 76);
        sizeLabel.Text = "Размер файла:";

        sizeValueLabel.AutoSize = true;
        sizeValueLabel.Location = new Point(116, 76);
        sizeValueLabel.Text = "—";

        passwordGroupBox.Controls.Add(passwordTextBox);
        passwordGroupBox.Controls.Add(passwordFileButton);
        passwordGroupBox.Controls.Add(passwordSourceLabel);
        passwordGroupBox.Location = new Point(24, 229);
        passwordGroupBox.Size = new Size(776, 116);
        passwordGroupBox.Text = "Пароль";

        passwordTextBox.Location = new Point(18, 31);
        passwordTextBox.Size = new Size(613, 23);
        passwordTextBox.UseSystemPasswordChar = true;
        passwordTextBox.TextChanged += passwordTextBox_TextChanged;

        passwordFileButton.Location = new Point(642, 30);
        passwordFileButton.Size = new Size(116, 25);
        passwordFileButton.Text = "Из файла...";
        passwordFileButton.UseVisualStyleBackColor = true;
        passwordFileButton.Click += passwordFileButton_Click;

        passwordSourceLabel.AutoSize = true;
        passwordSourceLabel.Location = new Point(18, 76);
        passwordSourceLabel.Text = "Источник пароля: клавиатура";

        encryptButton.Location = new Point(24, 367);
        encryptButton.Size = new Size(184, 38);
        encryptButton.Text = "Зашифровать";
        encryptButton.UseVisualStyleBackColor = true;
        encryptButton.Click += encryptButton_Click;

        decryptButton.Location = new Point(220, 367);
        decryptButton.Size = new Size(184, 38);
        decryptButton.Text = "Расшифровать";
        decryptButton.UseVisualStyleBackColor = true;
        decryptButton.Click += decryptButton_Click;

        statusLabel.AutoSize = true;
        statusLabel.Location = new Point(24, 424);
        statusLabel.Text = "Выберите файл и задайте пароль.";

        studentLabel.AutoSize = true;
        studentLabel.Location = new Point(24, 466);
        studentLabel.Text = "Покладов Н.Н., ПИбд-42";

        variantLabel.AutoSize = true;
        variantLabel.Location = new Point(594, 466);
        variantLabel.Text = "Вариант 11(4) → DES-OFB";

        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(824, 501);
        Controls.Add(titleLabel);
        Controls.Add(sourceGroupBox);
        Controls.Add(passwordGroupBox);
        Controls.Add(encryptButton);
        Controls.Add(decryptButton);
        Controls.Add(statusLabel);
        Controls.Add(studentLabel);
        Controls.Add(variantLabel);
        Controls.Add(menuStrip);
        FormBorderStyle = FormBorderStyle.FixedSingle;
        MainMenuStrip = menuStrip;
        MaximizeBox = false;
        Name = "MainForm";
        StartPosition = FormStartPosition.CenterScreen;
        Text = "DES-OFB — шифрование файлов";
        menuStrip.ResumeLayout(false);
        menuStrip.PerformLayout();
        sourceGroupBox.ResumeLayout(false);
        sourceGroupBox.PerformLayout();
        passwordGroupBox.ResumeLayout(false);
        passwordGroupBox.PerformLayout();
        ResumeLayout(false);
        PerformLayout();
    }
}
