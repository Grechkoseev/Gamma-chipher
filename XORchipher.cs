using System.Text;

namespace Lab_3;

internal class XORchipher
{
    private List<int> _gamma;
    private string _openText;
    /// <summary>
    /// Конструктор
    /// </summary>
    /// <param name="gamma" - выходная последовательность гпсп lfsr></param>
    /// <param name="openText" - текст, который нужно зашифровать></param>
    public XORchipher(List<int> gamma, string openText)
    {
        _gamma = new List<int>(gamma.Count);

        foreach (var bit in gamma)
        {
            _gamma.Add(bit);
        }

        _openText = openText;
    }
    /// <summary>
    /// Метод шифрования шифром гаммирования
    /// </summary>
    /// <param name="lfsr" - объект lfsr с предыдущей лабораторной></param>
    /// <param name="filename" - имя файла, текст в котором нужно зашифровать></param>
    /// <returns>Возвращает зашифрованную строку</returns>
    public string EncryptText(Lfsr lfsr, string filename)
    {
        Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);
        var openTextBytes = Encoding.GetEncoding(1251).GetBytes(_openText);
        var encryptedTextBytes = new byte[openTextBytes.Length];

        for (var i = 0; i < openTextBytes.Length;)
        {
            foreach (var gamma in lfsr.ByteSequenceList)
            {
                encryptedTextBytes[i] = (byte)(openTextBytes[i] ^ gamma);
                i++;

                if (i <= openTextBytes.Length)
                {
                    break;
                }
            }
        }

        var encryptedText = Encoding.GetEncoding(1251).GetString(encryptedTextBytes);

        StringBuilder encryptedTextStringBuilder = new(Encoding.GetEncoding(1251).GetString(encryptedTextBytes));
        encryptedTextStringBuilder.Replace("\0", "");

        using StreamWriter writer = new(filename, false);
        writer.Write(encryptedText);

        MessageBox.Show("Зашифрованный файл " + filename + " успешно перезаписан", "Lab_3 variant 10");

        return encryptedTextStringBuilder.ToString();
    }
    /// <summary>
    /// Метод расшифровки
    /// </summary>
    /// <param name="lfsr" - объект lfsr с предыдущей лабораторной></param>
    /// <param name="encryptedFilename" - имя файла с зашифрованным текстом></param>
    /// <param name="decryptedFilename" - имя файла с расшифрованным текстом></param>
    /// <returns>Возвращает расшифрованную строку</returns>
    public static string DecryptText(Lfsr lfsr, string encryptedFilename, string decryptedFilename)
    {
        using StreamReader reader = new(encryptedFilename);
        var encryptedText = reader.ReadToEnd();
        var encryptedTextBytes = Encoding.GetEncoding(1251).GetBytes(encryptedText);

        var decryptedTextBytes = new byte[encryptedTextBytes.Length];

        for (var i = 0; i < encryptedTextBytes.Length;)
        {
            foreach (var gamma in lfsr.ByteSequenceList)
            {
                decryptedTextBytes[i] = (byte)(encryptedTextBytes[i] ^ gamma);
                i++;

                if (i <= encryptedTextBytes.Length)
                {
                    break;
                }
            }
        }

        var decryptedText = Encoding.GetEncoding(1251).GetString(decryptedTextBytes);

        using StreamWriter writer = new(decryptedFilename, false);
        writer.Write(decryptedText);

        MessageBox.Show("Расшифрованный файл " + decryptedFilename + " успешно создан", "Lab_3 variant 10");

        return decryptedText;
    }
}