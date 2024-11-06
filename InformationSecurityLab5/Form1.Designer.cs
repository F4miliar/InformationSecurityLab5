namespace InformationSecurityLab5
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBoxDecrypted = new System.Windows.Forms.TextBox();
            this.textBoxEncrypted = new System.Windows.Forms.TextBox();
            this.buttonEncrypt = new System.Windows.Forms.Button();
            this.numericUpDownScytale = new System.Windows.Forms.NumericUpDown();
            this.buttonRead = new System.Windows.Forms.Button();
            this.buttonDecrypt = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownScytale)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxDecrypted
            // 
            this.textBoxDecrypted.Location = new System.Drawing.Point(12, 12);
            this.textBoxDecrypted.Multiline = true;
            this.textBoxDecrypted.Name = "textBoxDecrypted";
            this.textBoxDecrypted.Size = new System.Drawing.Size(286, 111);
            this.textBoxDecrypted.TabIndex = 0;
            // 
            // textBoxEncrypted
            // 
            this.textBoxEncrypted.Location = new System.Drawing.Point(304, 12);
            this.textBoxEncrypted.Multiline = true;
            this.textBoxEncrypted.Name = "textBoxEncrypted";
            this.textBoxEncrypted.Size = new System.Drawing.Size(286, 111);
            this.textBoxEncrypted.TabIndex = 1;
            // 
            // buttonEncrypt
            // 
            this.buttonEncrypt.Location = new System.Drawing.Point(304, 129);
            this.buttonEncrypt.Name = "buttonEncrypt";
            this.buttonEncrypt.Size = new System.Drawing.Size(97, 34);
            this.buttonEncrypt.TabIndex = 2;
            this.buttonEncrypt.Text = "Шифровать";
            this.buttonEncrypt.UseVisualStyleBackColor = true;
            this.buttonEncrypt.Click += new System.EventHandler(this.buttonEncrypt_Click);
            // 
            // numericUpDownScytale
            // 
            this.numericUpDownScytale.Location = new System.Drawing.Point(424, 138);
            this.numericUpDownScytale.Name = "numericUpDownScytale";
            this.numericUpDownScytale.Size = new System.Drawing.Size(48, 20);
            this.numericUpDownScytale.TabIndex = 3;
            this.numericUpDownScytale.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // buttonRead
            // 
            this.buttonRead.Location = new System.Drawing.Point(12, 129);
            this.buttonRead.Name = "buttonRead";
            this.buttonRead.Size = new System.Drawing.Size(97, 34);
            this.buttonRead.TabIndex = 4;
            this.buttonRead.Text = "Прочитать файл";
            this.buttonRead.UseVisualStyleBackColor = true;
            this.buttonRead.Click += new System.EventHandler(this.buttonRead_Click);
            // 
            // buttonDecrypt
            // 
            this.buttonDecrypt.Location = new System.Drawing.Point(493, 129);
            this.buttonDecrypt.Name = "buttonDecrypt";
            this.buttonDecrypt.Size = new System.Drawing.Size(97, 34);
            this.buttonDecrypt.TabIndex = 5;
            this.buttonDecrypt.Text = "Расшифровать";
            this.buttonDecrypt.UseVisualStyleBackColor = true;
            this.buttonDecrypt.Click += new System.EventHandler(this.buttonDecrypt_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(602, 171);
            this.Controls.Add(this.buttonDecrypt);
            this.Controls.Add(this.buttonRead);
            this.Controls.Add(this.numericUpDownScytale);
            this.Controls.Add(this.buttonEncrypt);
            this.Controls.Add(this.textBoxEncrypted);
            this.Controls.Add(this.textBoxDecrypted);
            this.Name = "Form1";
            this.Text = "Шифр Сцитала";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownScytale)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxDecrypted;
        private System.Windows.Forms.TextBox textBoxEncrypted;
        private System.Windows.Forms.Button buttonEncrypt;
        private System.Windows.Forms.NumericUpDown numericUpDownScytale;
        private System.Windows.Forms.Button buttonRead;
        private System.Windows.Forms.Button buttonDecrypt;
    }
}

