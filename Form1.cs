namespace Lab_3;

public partial class Form1 : Form
{
    private string FileText { get; set; }
    private Lfsr _lfsr;
    private const string EncryptedFilename = "encryptedFile.txt";
    private const string DecryptedFilename = "decryptedFile.txt";


    public Form1()
    {
        InitializeComponent();
        FileText = string.Empty;
    }

    private void EncryptedKeyTextBox_TextChanged(object sender, EventArgs e)
    {
        if (int.TryParse(encryptedKeyTextBox.Text, out var key))
        {
            encryptFileButton.Enabled = key is > 0 and < 256;
            decryptTextFileButton.Enabled = !string.IsNullOrEmpty(encryptedFileRichTextBox.Text);
        }
        else
        {
            encryptFileButton.Enabled = false;
            decryptTextFileButton.Enabled = false;
        }
    }

    private void SelectTextFileButton_Click(object sender, EventArgs e)
    {
        if (openFileDialog.ShowDialog() == DialogResult.Cancel)
        {
            return;
        }

        var filename = openFileDialog.FileName;
        selectedFileLabel.Text = string.Concat("Âûáğàí ôàéë  ", openFileDialog.SafeFileName);
        selectedFileLabel.Visible = true;
        FileText = File.ReadAllText(filename);
    }

    private void EncryptFileButton_Click(object sender, EventArgs e)
    {
        var key = int.Parse(encryptedKeyTextBox.Text);
        _lfsr = new Lfsr(new[] { 1, 5, 7 }, key);
        _lfsr.PutNumberToRegister(key);

        do
        {
            _lfsr.PrintNumberFromRegister();
            _lfsr.CalculateNextSequenceMember();
        } while (!_lfsr.IsCurrentSequenceMemberEqualsInitialNumber());

        _lfsr.CountByteSequenceRepresentation();

        XORchipher chipher = new(_lfsr.BinaryOutputSequence, FileText);
        encryptedFileRichTextBox.Text = chipher.EncryptText(_lfsr, EncryptedFilename);
        decryptTextFileButton.Enabled = true;
    }

    private void DecryptTextFileButton_Click(object sender, EventArgs e)
    {
        decryptedFileRichTextBox.Text = XORchipher.DecryptText(_lfsr, EncryptedFilename, DecryptedFilename);
    }
}