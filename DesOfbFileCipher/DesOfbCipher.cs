using System.Text;

namespace DesOfbFileCipher;

public static class DesOfbCipher
{
    public static readonly byte[] DefaultIv = [1, 2, 3, 4, 5, 6, 7, 8];

    public static byte[] CreateKey(string password)
    {
        if (string.IsNullOrWhiteSpace(password))
            throw new ArgumentException("Введите пароль.", nameof(password));

        byte[] source = Encoding.UTF8.GetBytes(password);
        byte[] key = new byte[8];
        Array.Copy(source, key, Math.Min(source.Length, key.Length));
        return key;
    }

    public static void Transform(Stream input, Stream output, ReadOnlySpan<byte> key, ReadOnlySpan<byte> iv)
    {
        if (key.Length != 8)
            throw new ArgumentException("Ключ DES должен содержать 8 байт.", nameof(key));
        if (iv.Length != 8)
            throw new ArgumentException("Вектор инициализации OFB должен содержать 8 байт.", nameof(iv));

        byte[] feedback = iv.ToArray();
        byte[] block = new byte[8];

        while (true)
        {
            int count = ReadBlock(input, block);
            if (count == 0)
                break;

            feedback = DesCipher.EncryptBlock(feedback, key);

            for (int i = 0; i < count; i++)
                block[i] ^= feedback[i];

            output.Write(block, 0, count);
        }
    }

    private static int ReadBlock(Stream input, byte[] buffer)
    {
        int total = 0;

        while (total < buffer.Length)
        {
            int read = input.Read(buffer, total, buffer.Length - total);
            if (read == 0)
                break;

            total += read;
        }

        return total;
    }
}
