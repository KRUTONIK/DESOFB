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
        // 
        // menuStrip
        // 
        menuStrip.Items.AddRange(new ToolStripItem[] { fileMenuItem, helpMenuItem });
        menuStrip.Location = new Point(0, 0);
        menuStrip.Name = "menuStrip";
        menuStrip.Size = new Size(824, 24);
        menuStrip.TabIndex = 8;
        // 
        // fileMenuItem
        // 
        fileMenuItem.DropDownItems.AddRange(new ToolStripItem[] { selectFileMenuItem, encryptMenuItem, decryptMenuItem, exitMenuItem });
        fileMenuItem.Name = "fileMenuItem";
        fileMenuItem.Size = new Size(48, 20);
        fileMenuItem.Text = "Файл";
        // 
        // selectFileMenuItem
        // 
        selectFileMenuItem.Name = "selectFileMenuItem";
        selectFileMenuItem.Size = new Size(219, 22);
        selectFileMenuItem.Text = "Выбрать исходный файл...";
        selectFileMenuItem.Click += selectFileMenuItem_Click;
        // 
        // encryptMenuItem
        // 
        encryptMenuItem.Name = "encryptMenuItem";
        encryptMenuItem.Size = new Size(219, 22);
        encryptMenuItem.Text = "Зашифровать...";
        encryptMenuItem.Click += encryptMenuItem_Click;
        // 
        // decryptMenuItem
        // 
        decryptMenuItem.Name = "decryptMenuItem";
        decryptMenuItem.Size = new Size(219, 22);
        decryptMenuItem.Text = "Расшифровать...";
        decryptMenuItem.Click += decryptMenuItem_Click;
        // 
        // exitMenuItem
        // 
        exitMenuItem.Name = "exitMenuItem";
        exitMenuItem.Size = new Size(219, 22);
        exitMenuItem.Text = "Выход";
        exitMenuItem.Click += exitMenuItem_Click;
        // 
        // helpMenuItem
        // 
        helpMenuItem.DropDownItems.AddRange(new ToolStripItem[] { studentInfoMenuItem, variantMenuItem, algorithmMenuItem, aboutMenuItem });
        helpMenuItem.Name = "helpMenuItem";
        helpMenuItem.Size = new Size(65, 20);
        helpMenuItem.Text = "Справка";
        // 
        // studentInfoMenuItem
        // 
        studentInfoMenuItem.Name = "studentInfoMenuItem";
        studentInfoMenuItem.Size = new Size(179, 22);
        studentInfoMenuItem.Text = "Данные студента";
        studentInfoMenuItem.Click += studentInfoMenuItem_Click;
        // 
        // variantMenuItem
        // 
        variantMenuItem.Name = "variantMenuItem";
        variantMenuItem.Size = new Size(179, 22);
        variantMenuItem.Text = "Вариант";
        variantMenuItem.Click += variantMenuItem_Click;
        // 
        // algorithmMenuItem
        // 
        algorithmMenuItem.Name = "algorithmMenuItem";
        algorithmMenuItem.Size = new Size(179, 22);
        algorithmMenuItem.Text = "Алгоритм DES-OFB";
        algorithmMenuItem.Click += algorithmMenuItem_Click;
        // 
        // aboutMenuItem
        // 
        aboutMenuItem.Name = "aboutMenuItem";
        aboutMenuItem.Size = new Size(179, 22);
        aboutMenuItem.Text = "О программе";
        aboutMenuItem.Click += aboutMenuItem_Click;
        // 
        // titleLabel
        // 
        titleLabel.AutoSize = true;
        titleLabel.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
        titleLabel.Location = new Point(24, 48);
        titleLabel.Name = "titleLabel";
        titleLabel.Size = new Size(342, 30);
        titleLabel.TabIndex = 0;
        titleLabel.Text = "Шифрование файлов DES-OFB";
        // 
        // sourceGroupBox
        // 
        sourceGroupBox.Controls.Add(sourcePathTextBox);
        sourceGroupBox.Controls.Add(selectFileButton);
        sourceGroupBox.Controls.Add(sizeLabel);
        sourceGroupBox.Controls.Add(sizeValueLabel);
        sourceGroupBox.Location = new Point(24, 96);
        sourceGroupBox.Name = "sourceGroupBox";
        sourceGroupBox.Size = new Size(776, 116);
        sourceGroupBox.TabIndex = 1;
        sourceGroupBox.TabStop = false;
        sourceGroupBox.Text = "Исходный файл";
        // 
        // sourcePathTextBox
        // 
        sourcePathTextBox.Location = new Point(18, 31);
        sourcePathTextBox.Name = "sourcePathTextBox";
        sourcePathTextBox.ReadOnly = true;
        sourcePathTextBox.Size = new Size(613, 23);
        sourcePathTextBox.TabIndex = 0;
        // 
        // selectFileButton
        // 
        selectFileButton.Location = new Point(642, 30);
        selectFileButton.Name = "selectFileButton";
        selectFileButton.Size = new Size(116, 25);
        selectFileButton.TabIndex = 1;
        selectFileButton.Text = "Выбрать...";
        selectFileButton.UseVisualStyleBackColor = true;
        selectFileButton.Click += selectFileButton_Click;
        // 
        // sizeLabel
        // 
        sizeLabel.AutoSize = true;
        sizeLabel.Location = new Point(18, 76);
        sizeLabel.Name = "sizeLabel";
        sizeLabel.Size = new Size(88, 15);
        sizeLabel.TabIndex = 2;
        sizeLabel.Text = "Размер файла:";
        // 
        // sizeValueLabel
        // 
        sizeValueLabel.AutoSize = true;
        sizeValueLabel.Location = new Point(116, 76);
        sizeValueLabel.Name = "sizeValueLabel";
        sizeValueLabel.Size = new Size(19, 15);
        sizeValueLabel.TabIndex = 3;
        sizeValueLabel.Text = "-";
        // 
        // passwordGroupBox
        // 
        passwordGroupBox.Controls.Add(passwordTextBox);
        passwordGroupBox.Controls.Add(passwordFileButton);
        passwordGroupBox.Controls.Add(passwordSourceLabel);
        passwordGroupBox.Location = new Point(24, 229);
        passwordGroupBox.Name = "passwordGroupBox";
        passwordGroupBox.Size = new Size(776, 116);
        passwordGroupBox.TabIndex = 2;
        passwordGroupBox.TabStop = false;
        passwordGroupBox.Text = "Пароль";
        // 
        // passwordTextBox
        // 
        passwordTextBox.Location = new Point(18, 31);
        passwordTextBox.Name = "passwordTextBox";
        passwordTextBox.Size = new Size(613, 23);
        passwordTextBox.TabIndex = 0;
        passwordTextBox.UseSystemPasswordChar = true;
        passwordTextBox.TextChanged += passwordTextBox_TextChanged;
        // 
        // passwordFileButton
        // 
        passwordFileButton.Location = new Point(642, 30);
        passwordFileButton.Name = "passwordFileButton";
        passwordFileButton.Size = new Size(116, 25);
        passwordFileButton.TabIndex = 1;
        passwordFileButton.Text = "Из файла...";
        passwordFileButton.UseVisualStyleBackColor = true;
        passwordFileButton.Click += passwordFileButton_Click;
        // 
        // passwordSourceLabel
        // 
        passwordSourceLabel.AutoSize = true;
        passwordSourceLabel.Location = new Point(18, 76);
        passwordSourceLabel.Name = "passwordSourceLabel";
        passwordSourceLabel.Size = new Size(172, 15);
        passwordSourceLabel.TabIndex = 2;
        passwordSourceLabel.Text = "Источник пароля: клавиатура";
        // 
        // encryptButton
        // 
        encryptButton.Location = new Point(24, 367);
        encryptButton.Name = "encryptButton";
        encryptButton.Size = new Size(184, 38);
        encryptButton.TabIndex = 3;
        encryptButton.Text = "Зашифровать";
        encryptButton.UseVisualStyleBackColor = true;
        encryptButton.Click += encryptButton_Click;
        // 
        // decryptButton
        // 
        decryptButton.Location = new Point(220, 367);
        decryptButton.Name = "decryptButton";
        decryptButton.Size = new Size(184, 38);
        decryptButton.TabIndex = 4;
        decryptButton.Text = "Расшифровать";
        decryptButton.UseVisualStyleBackColor = true;
        decryptButton.Click += decryptButton_Click;
        // 
        // statusLabel
        // 
        statusLabel.AutoSize = true;
        statusLabel.Location = new Point(24, 424);
        statusLabel.Name = "statusLabel";
        statusLabel.Size = new Size(193, 15);
        statusLabel.TabIndex = 5;
        statusLabel.Text = "Выберите файл и задайте пароль.";
        // 
        // studentLabel
        // 
        studentLabel.AutoSize = true;
        studentLabel.Location = new Point(24, 466);
        studentLabel.Name = "studentLabel";
        studentLabel.Size = new Size(142, 15);
        studentLabel.TabIndex = 6;
        studentLabel.Text = "Покладов Н.Н., ПИбд-42";
        // 
        // variantLabel
        // 
        variantLabel.AutoSize = true;
        variantLabel.Location = new Point(594, 466);
        variantLabel.Name = "variantLabel";
        variantLabel.Size = new Size(131, 15);
        variantLabel.TabIndex = 7;
        variantLabel.Text = "Вариант 11(4) DES-OFB";
        // 
        // MainForm
        // 
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
        Text = "DES-OFB - шифрование файлов";
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
