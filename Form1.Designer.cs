namespace Lab_3
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            encryptedKeyTextBox = new TextBox();
            encryptedKeyLabel = new Label();
            selectTextFileButton = new Button();
            encryptFileButton = new Button();
            decryptTextFileButton = new Button();
            descriptionLabel = new Label();
            selectedFileLabel = new Label();
            encryptedFileRichTextBox = new RichTextBox();
            decryptedFileRichTextBox = new RichTextBox();
            encryptedTextLabel = new Label();
            decryptedTextLabel = new Label();
            openFileDialog = new OpenFileDialog();
            SuspendLayout();
            // 
            // encryptedKeyTextBox
            // 
            encryptedKeyTextBox.BorderStyle = BorderStyle.FixedSingle;
            encryptedKeyTextBox.Location = new Point(505, 143);
            encryptedKeyTextBox.Name = "encryptedKeyTextBox";
            encryptedKeyTextBox.Size = new Size(45, 23);
            encryptedKeyTextBox.TabIndex = 0;
            encryptedKeyTextBox.TextChanged += EncryptedKeyTextBox_TextChanged;
            // 
            // encryptedKeyLabel
            // 
            encryptedKeyLabel.AutoSize = true;
            encryptedKeyLabel.Location = new Point(385, 146);
            encryptedKeyLabel.Name = "encryptedKeyLabel";
            encryptedKeyLabel.Size = new Size(114, 15);
            encryptedKeyLabel.TabIndex = 1;
            encryptedKeyLabel.Text = "Ключ шифрования";
            // 
            // selectTextFileButton
            // 
            selectTextFileButton.Location = new Point(272, 254);
            selectTextFileButton.Name = "selectTextFileButton";
            selectTextFileButton.Size = new Size(114, 59);
            selectTextFileButton.TabIndex = 2;
            selectTextFileButton.Text = "Выбрать текстовый файл для шифрования";
            selectTextFileButton.UseVisualStyleBackColor = true;
            selectTextFileButton.Click += SelectTextFileButton_Click;
            // 
            // encryptFileButton
            // 
            encryptFileButton.Enabled = false;
            encryptFileButton.Location = new Point(468, 254);
            encryptFileButton.Name = "encryptFileButton";
            encryptFileButton.Size = new Size(110, 59);
            encryptFileButton.TabIndex = 3;
            encryptFileButton.Text = "Зашифровать";
            encryptFileButton.UseVisualStyleBackColor = true;
            encryptFileButton.Click += EncryptFileButton_Click;
            // 
            // decryptTextFileButton
            // 
            decryptTextFileButton.Enabled = false;
            decryptTextFileButton.Location = new Point(650, 254);
            decryptTextFileButton.Name = "decryptTextFileButton";
            decryptTextFileButton.Size = new Size(115, 59);
            decryptTextFileButton.TabIndex = 4;
            decryptTextFileButton.Text = "Расшифровать";
            decryptTextFileButton.UseVisualStyleBackColor = true;
            decryptTextFileButton.Click += DecryptTextFileButton_Click;
            // 
            // descriptionLabel
            // 
            descriptionLabel.AutoSize = true;
            descriptionLabel.Location = new Point(294, 48);
            descriptionLabel.Name = "descriptionLabel";
            descriptionLabel.Size = new Size(476, 45);
            descriptionLabel.TabIndex = 5;
            descriptionLabel.Text = resources.GetString("descriptionLabel.Text");
            // 
            // selectedFileLabel
            // 
            selectedFileLabel.AutoSize = true;
            selectedFileLabel.Location = new Point(385, 198);
            selectedFileLabel.Name = "selectedFileLabel";
            selectedFileLabel.Size = new Size(108, 15);
            selectedFileLabel.TabIndex = 6;
            selectedFileLabel.Text = "Выбранный файл ";
            selectedFileLabel.Visible = false;
            // 
            // encryptedFileRichTextBox
            // 
            encryptedFileRichTextBox.BorderStyle = BorderStyle.FixedSingle;
            encryptedFileRichTextBox.Location = new Point(87, 400);
            encryptedFileRichTextBox.Name = "encryptedFileRichTextBox";
            encryptedFileRichTextBox.ReadOnly = true;
            encryptedFileRichTextBox.Size = new Size(400, 300);
            encryptedFileRichTextBox.TabIndex = 7;
            encryptedFileRichTextBox.Text = "";
            // 
            // decryptedFileRichTextBox
            // 
            decryptedFileRichTextBox.BorderStyle = BorderStyle.FixedSingle;
            decryptedFileRichTextBox.Location = new Point(650, 400);
            decryptedFileRichTextBox.Name = "decryptedFileRichTextBox";
            decryptedFileRichTextBox.ReadOnly = true;
            decryptedFileRichTextBox.Size = new Size(400, 300);
            decryptedFileRichTextBox.TabIndex = 8;
            decryptedFileRichTextBox.Text = "";
            // 
            // encryptedTextLabel
            // 
            encryptedTextLabel.AutoSize = true;
            encryptedTextLabel.Location = new Point(87, 360);
            encryptedTextLabel.Name = "encryptedTextLabel";
            encryptedTextLabel.Size = new Size(134, 15);
            encryptedTextLabel.TabIndex = 9;
            encryptedTextLabel.Text = "Зашифрованный текст";
            // 
            // decryptedTextLabel
            // 
            decryptedTextLabel.AutoSize = true;
            decryptedTextLabel.Location = new Point(650, 360);
            decryptedTextLabel.Name = "decryptedTextLabel";
            decryptedTextLabel.Size = new Size(140, 15);
            decryptedTextLabel.TabIndex = 10;
            decryptedTextLabel.Text = "Расшифрованный текст";
            // 
            // openFileDialog
            // 
            openFileDialog.InitialDirectory = "\\\\?\\C:\\Users\\igorg\\AppData\\Local\\Microsoft\\VisualStudio\\17.0_a2deef55\\WinFormsDesigner\\ivikohfr.chi";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1120, 778);
            Controls.Add(decryptedTextLabel);
            Controls.Add(encryptedTextLabel);
            Controls.Add(decryptedFileRichTextBox);
            Controls.Add(encryptedFileRichTextBox);
            Controls.Add(selectedFileLabel);
            Controls.Add(descriptionLabel);
            Controls.Add(decryptTextFileButton);
            Controls.Add(encryptFileButton);
            Controls.Add(selectTextFileButton);
            Controls.Add(encryptedKeyLabel);
            Controls.Add(encryptedKeyTextBox);
            Name = "Form1";
            Text = "Lab_3 variant 10";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox encryptedKeyTextBox;
        private Label encryptedKeyLabel;
        private Button selectTextFileButton;
        private Button encryptFileButton;
        private Button decryptTextFileButton;
        private Label descriptionLabel;
        private Label selectedFileLabel;
        private RichTextBox encryptedFileRichTextBox;
        private RichTextBox decryptedFileRichTextBox;
        private Label encryptedTextLabel;
        private Label decryptedTextLabel;
        private OpenFileDialog openFileDialog;
    }
}