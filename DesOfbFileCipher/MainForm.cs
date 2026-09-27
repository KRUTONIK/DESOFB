namespace DesOfbFileCipher;

public partial class MainForm : Form
{
    public MainForm()
    {
        InitializeComponent();
    }

    private void SelectSourceFile()
    {
        using var dialog = new OpenFileDialog
        {
            Title = "Выберите исходный файл",
            Filter = "Все файлы (*.*)|*.*",
            CheckFileExists = true
        };

        if (dialog.ShowDialog(this) != DialogResult.OK)
            return;

        sourcePathTextBox.Text = dialog.FileName;
        sizeValueLabel.Text = new FileInfo(dialog.FileName).Length + " байт";
        statusLabel.Text = "Файл выбран.";
    }

    private void SelectPasswordFile()
    {
        using var dialog = new OpenFileDialog
        {
            Title = "Выберите файл с паролем",
            Filter = "Текстовые файлы (*.txt)|*.txt|Все файлы (*.*)|*.*",
            CheckFileExists = true
        };

        if (dialog.ShowDialog(this) != DialogResult.OK)
            return;

        try
        {
            string password = File.ReadAllText(dialog.FileName).TrimEnd('\r', '\n');
            if (string.IsNullOrWhiteSpace(password))
                throw new InvalidDataException("Файл с паролем пуст.");

            passwordTextBox.Text = password;
            passwordSourceLabel.Text = "Источник пароля: " + Path.GetFileName(dialog.FileName);
        }
        catch (Exception ex)
        {
            MessageBox.Show(this, ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private void ProcessFile(bool encrypt)
    {
        try
        {
            string sourcePath = sourcePathTextBox.Text.Trim();
            FileCipherService.ValidateSource(sourcePath);

            if (string.IsNullOrWhiteSpace(passwordTextBox.Text))
                throw new InvalidOperationException("Введите пароль или выберите файл с паролем.");

            using var dialog = new SaveFileDialog
            {
                Title = encrypt ? "Сохранить зашифрованный файл" : "Сохранить расшифрованный файл",
                Filter = "Все файлы (*.*)|*.*",
                FileName = (encrypt ? "encrypted_" : "decrypted_") + Path.GetFileName(sourcePath)
            };

            if (dialog.ShowDialog(this) != DialogResult.OK)
                return;

            if (encrypt)
                FileCipherService.Encrypt(sourcePath, dialog.FileName, passwordTextBox.Text);
            else
                FileCipherService.Decrypt(sourcePath, dialog.FileName, passwordTextBox.Text);

            statusLabel.Text = encrypt ? "Файл успешно зашифрован." : "Файл успешно расшифрован.";
            MessageBox.Show(
                this,
                statusLabel.Text,
                "Готово",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }
        catch (Exception ex)
        {
            statusLabel.Text = "Операция не выполнена.";
            MessageBox.Show(this, ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private void studentInfoMenuItem_Click(object? sender, EventArgs e) =>
        MessageBox.Show(
            this,
            "Покладов Н.Н.\nГруппа ПИбд-42\nДисциплина: \"Информационная безопасность\"",
            "Данные студента",
            MessageBoxButtons.OK,
            MessageBoxIcon.Information);

    private void variantMenuItem_Click(object? sender, EventArgs e) =>
        MessageBox.Show(
            this,
            "Номер варианта: 11(4)\nАлгоритм DES\nРежим OFB (Output Feedback)",
            "Вариант",
            MessageBoxButtons.OK,
            MessageBoxIcon.Information);

    private void algorithmMenuItem_Click(object? sender, EventArgs e) =>
        MessageBox.Show(
            this,
            "DES — симметричный блочный алгоритм с блоком 64 бита и 16 раундами сети Фейстеля. " +
            "В режиме OFB очередная гамма получается шифрованием предыдущего значения обратной связи. " +
            "Гамма складывается по XOR с данными, поэтому для шифрования и расшифрования используется одна и та же операция. " +
            "В программе DES и режим OFB реализованы самостоятельно.",
            "Алгоритм DES-OFB",
            MessageBoxButtons.OK,
            MessageBoxIcon.Information);

    private void aboutMenuItem_Click(object? sender, EventArgs e) =>
        MessageBox.Show(
            this,
            "Программа шифрует и расшифровывает файлы любого формата размером не менее 1 КБ алгоритмом DES в режиме OFB. " +
            "Пароль можно ввести с клавиатуры или загрузить из файла. Для каждой операции отдельно выбирается файл назначения.",
            "О программе",
            MessageBoxButtons.OK,
            MessageBoxIcon.Information);

    private void passwordTextBox_TextChanged(object? sender, EventArgs e) =>
        passwordSourceLabel.Text = "Источник пароля: клавиатура";

    private void selectFileButton_Click(object? sender, EventArgs e) => SelectSourceFile();
    private void passwordFileButton_Click(object? sender, EventArgs e) => SelectPasswordFile();
    private void encryptButton_Click(object? sender, EventArgs e) => ProcessFile(true);
    private void decryptButton_Click(object? sender, EventArgs e) => ProcessFile(false);
    private void selectFileMenuItem_Click(object? sender, EventArgs e) => SelectSourceFile();
    private void encryptMenuItem_Click(object? sender, EventArgs e) => ProcessFile(true);
    private void decryptMenuItem_Click(object? sender, EventArgs e) => ProcessFile(false);
    private void exitMenuItem_Click(object? sender, EventArgs e) => Close();
}
