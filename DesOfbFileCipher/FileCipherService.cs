namespace DesOfbFileCipher;

public static class FileCipherService
{
    public const long MinimumFileSize = 1024;

    public static void Encrypt(string sourcePath, string destinationPath, string password) =>
        Process(sourcePath, destinationPath, password);

    public static void Decrypt(string sourcePath, string destinationPath, string password) =>
        Process(sourcePath, destinationPath, password);

    private static void Process(string sourcePath, string destinationPath, string password)
    {
        ValidateSource(sourcePath);

        if (string.IsNullOrWhiteSpace(destinationPath))
            throw new ArgumentException("Не выбран файл назначения.", nameof(destinationPath));

        string sourceFullPath = Path.GetFullPath(sourcePath);
        string destinationFullPath = Path.GetFullPath(destinationPath);

        if (string.Equals(sourceFullPath, destinationFullPath, StringComparison.OrdinalIgnoreCase))
            throw new InvalidOperationException("Файл назначения должен отличаться от исходного файла.");

        byte[] key = DesOfbCipher.CreateKey(password);

        using var input = new FileStream(sourcePath, FileMode.Open, FileAccess.Read, FileShare.Read);
        using var output = new FileStream(destinationPath, FileMode.Create, FileAccess.Write, FileShare.None);

        DesOfbCipher.Transform(input, output, key, DesOfbCipher.DefaultIv);
    }

    public static long ValidateSource(string sourcePath)
    {
        if (string.IsNullOrWhiteSpace(sourcePath))
            throw new ArgumentException("Выберите исходный файл.", nameof(sourcePath));
        if (!File.Exists(sourcePath))
            throw new FileNotFoundException("Выбранный файл не найден.", sourcePath);

        long length = new FileInfo(sourcePath).Length;
        if (length < MinimumFileSize)
            throw new InvalidOperationException("Размер исходного файла должен быть не менее 1 КБ.");

        return length;
    }
}
