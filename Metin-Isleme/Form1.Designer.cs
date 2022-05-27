
namespace Metin_Isleme
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
            this.btnMetinYukle = new System.Windows.Forms.Button();
            this.rtxtFile = new System.Windows.Forms.RichTextBox();
            this.btnStackAktar = new System.Windows.Forms.Button();
            this.rtxtFileValues = new System.Windows.Forms.RichTextBox();
            this.txtSentences = new System.Windows.Forms.TextBox();
            this.txtWords = new System.Windows.Forms.TextBox();
            this.tbGeneral = new System.Windows.Forms.TabControl();
            this.tbUploadText = new System.Windows.Forms.TabPage();
            this.lblDatas = new System.Windows.Forms.Label();
            this.lblPath = new System.Windows.Forms.Label();
            this.tbStackTransfer = new System.Windows.Forms.TabPage();
            this.txtGeneralValues = new System.Windows.Forms.TextBox();
            this.lblGeneralValues = new System.Windows.Forms.Label();
            this.lblWords = new System.Windows.Forms.Label();
            this.lblSentences = new System.Windows.Forms.Label();
            this.tbHeap = new System.Windows.Forms.TabPage();
            this.btnWordSort = new System.Windows.Forms.Button();
            this.lblCount = new System.Windows.Forms.Label();
            this.txtCount = new System.Windows.Forms.TextBox();
            this.lblHeapExplanation = new System.Windows.Forms.Label();
            this.lblHeapValues = new System.Windows.Forms.Label();
            this.txtHeapValues = new System.Windows.Forms.TextBox();
            this.btnHeapTransfer = new System.Windows.Forms.Button();
            this.tbHash = new System.Windows.Forms.TabPage();
            this.btnHash = new System.Windows.Forms.Button();
            this.tbGeneral.SuspendLayout();
            this.tbUploadText.SuspendLayout();
            this.tbStackTransfer.SuspendLayout();
            this.tbHeap.SuspendLayout();
            this.tbHash.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnMetinYukle
            // 
            this.btnMetinYukle.Location = new System.Drawing.Point(461, 358);
            this.btnMetinYukle.Name = "btnMetinYukle";
            this.btnMetinYukle.Size = new System.Drawing.Size(99, 46);
            this.btnMetinYukle.TabIndex = 0;
            this.btnMetinYukle.Text = "Metin Yükle";
            this.btnMetinYukle.UseVisualStyleBackColor = true;
            this.btnMetinYukle.Click += new System.EventHandler(this.btnMetinYukle_Click);
            // 
            // rtxtFile
            // 
            this.rtxtFile.Location = new System.Drawing.Point(340, 64);
            this.rtxtFile.Name = "rtxtFile";
            this.rtxtFile.ReadOnly = true;
            this.rtxtFile.Size = new System.Drawing.Size(334, 62);
            this.rtxtFile.TabIndex = 1;
            this.rtxtFile.Text = "";
            // 
            // btnStackAktar
            // 
            this.btnStackAktar.Enabled = false;
            this.btnStackAktar.Location = new System.Drawing.Point(281, 328);
            this.btnStackAktar.Name = "btnStackAktar";
            this.btnStackAktar.Size = new System.Drawing.Size(99, 46);
            this.btnStackAktar.TabIndex = 2;
            this.btnStackAktar.Text = "Stack’e Oku";
            this.btnStackAktar.UseVisualStyleBackColor = true;
            this.btnStackAktar.Click += new System.EventHandler(this.btnStackAktar_Click);
            // 
            // rtxtFileValues
            // 
            this.rtxtFileValues.Location = new System.Drawing.Point(340, 132);
            this.rtxtFileValues.Name = "rtxtFileValues";
            this.rtxtFileValues.ReadOnly = true;
            this.rtxtFileValues.Size = new System.Drawing.Size(334, 208);
            this.rtxtFileValues.TabIndex = 3;
            this.rtxtFileValues.Text = "";
            // 
            // txtSentences
            // 
            this.txtSentences.Location = new System.Drawing.Point(61, 55);
            this.txtSentences.Multiline = true;
            this.txtSentences.Name = "txtSentences";
            this.txtSentences.ReadOnly = true;
            this.txtSentences.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtSentences.Size = new System.Drawing.Size(556, 225);
            this.txtSentences.TabIndex = 4;
            // 
            // txtWords
            // 
            this.txtWords.Location = new System.Drawing.Point(623, 55);
            this.txtWords.Multiline = true;
            this.txtWords.Name = "txtWords";
            this.txtWords.ReadOnly = true;
            this.txtWords.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtWords.Size = new System.Drawing.Size(301, 225);
            this.txtWords.TabIndex = 5;
            // 
            // tbGeneral
            // 
            this.tbGeneral.Controls.Add(this.tbUploadText);
            this.tbGeneral.Controls.Add(this.tbStackTransfer);
            this.tbGeneral.Controls.Add(this.tbHeap);
            this.tbGeneral.Controls.Add(this.tbHash);
            this.tbGeneral.Location = new System.Drawing.Point(138, 25);
            this.tbGeneral.Name = "tbGeneral";
            this.tbGeneral.SelectedIndex = 0;
            this.tbGeneral.Size = new System.Drawing.Size(992, 485);
            this.tbGeneral.TabIndex = 6;
            // 
            // tbUploadText
            // 
            this.tbUploadText.Controls.Add(this.lblDatas);
            this.tbUploadText.Controls.Add(this.lblPath);
            this.tbUploadText.Controls.Add(this.btnMetinYukle);
            this.tbUploadText.Controls.Add(this.rtxtFile);
            this.tbUploadText.Controls.Add(this.rtxtFileValues);
            this.tbUploadText.Location = new System.Drawing.Point(4, 29);
            this.tbUploadText.Name = "tbUploadText";
            this.tbUploadText.Padding = new System.Windows.Forms.Padding(3);
            this.tbUploadText.Size = new System.Drawing.Size(984, 452);
            this.tbUploadText.TabIndex = 0;
            this.tbUploadText.Text = "Metin Yükle";
            this.tbUploadText.UseVisualStyleBackColor = true;
            // 
            // lblDatas
            // 
            this.lblDatas.AutoSize = true;
            this.lblDatas.Location = new System.Drawing.Point(222, 232);
            this.lblDatas.Name = "lblDatas";
            this.lblDatas.Size = new System.Drawing.Size(104, 20);
            this.lblDatas.TabIndex = 5;
            this.lblDatas.Text = "Metin Verileri :";
            // 
            // lblPath
            // 
            this.lblPath.AutoSize = true;
            this.lblPath.Location = new System.Drawing.Point(222, 83);
            this.lblPath.Name = "lblPath";
            this.lblPath.Size = new System.Drawing.Size(116, 20);
            this.lblPath.TabIndex = 4;
            this.lblPath.Text = "Dosya Konumu :";
            // 
            // tbStackTransfer
            // 
            this.tbStackTransfer.Controls.Add(this.txtGeneralValues);
            this.tbStackTransfer.Controls.Add(this.lblGeneralValues);
            this.tbStackTransfer.Controls.Add(this.lblWords);
            this.tbStackTransfer.Controls.Add(this.lblSentences);
            this.tbStackTransfer.Controls.Add(this.txtSentences);
            this.tbStackTransfer.Controls.Add(this.txtWords);
            this.tbStackTransfer.Controls.Add(this.btnStackAktar);
            this.tbStackTransfer.Location = new System.Drawing.Point(4, 29);
            this.tbStackTransfer.Name = "tbStackTransfer";
            this.tbStackTransfer.Padding = new System.Windows.Forms.Padding(3);
            this.tbStackTransfer.Size = new System.Drawing.Size(984, 452);
            this.tbStackTransfer.TabIndex = 1;
            this.tbStackTransfer.Text = "Stack\'e Aktar";
            this.tbStackTransfer.UseVisualStyleBackColor = true;
            // 
            // txtGeneralValues
            // 
            this.txtGeneralValues.Location = new System.Drawing.Point(623, 328);
            this.txtGeneralValues.Multiline = true;
            this.txtGeneralValues.Name = "txtGeneralValues";
            this.txtGeneralValues.ReadOnly = true;
            this.txtGeneralValues.Size = new System.Drawing.Size(301, 71);
            this.txtGeneralValues.TabIndex = 11;
            // 
            // lblGeneralValues
            // 
            this.lblGeneralValues.AutoSize = true;
            this.lblGeneralValues.Location = new System.Drawing.Point(730, 305);
            this.lblGeneralValues.Name = "lblGeneralValues";
            this.lblGeneralValues.Size = new System.Drawing.Size(98, 20);
            this.lblGeneralValues.TabIndex = 10;
            this.lblGeneralValues.Text = "Genel Bilgiler";
            // 
            // lblWords
            // 
            this.lblWords.AutoSize = true;
            this.lblWords.Location = new System.Drawing.Point(730, 32);
            this.lblWords.Name = "lblWords";
            this.lblWords.Size = new System.Drawing.Size(72, 20);
            this.lblWords.TabIndex = 7;
            this.lblWords.Text = "Kelimeler";
            // 
            // lblSentences
            // 
            this.lblSentences.AutoSize = true;
            this.lblSentences.Location = new System.Drawing.Point(281, 32);
            this.lblSentences.Name = "lblSentences";
            this.lblSentences.Size = new System.Drawing.Size(68, 20);
            this.lblSentences.TabIndex = 6;
            this.lblSentences.Text = "Cümleler";
            // 
            // tbHeap
            // 
            this.tbHeap.Controls.Add(this.btnWordSort);
            this.tbHeap.Controls.Add(this.lblCount);
            this.tbHeap.Controls.Add(this.txtCount);
            this.tbHeap.Controls.Add(this.lblHeapExplanation);
            this.tbHeap.Controls.Add(this.lblHeapValues);
            this.tbHeap.Controls.Add(this.txtHeapValues);
            this.tbHeap.Controls.Add(this.btnHeapTransfer);
            this.tbHeap.Location = new System.Drawing.Point(4, 29);
            this.tbHeap.Name = "tbHeap";
            this.tbHeap.Padding = new System.Windows.Forms.Padding(3);
            this.tbHeap.Size = new System.Drawing.Size(984, 452);
            this.tbHeap.TabIndex = 2;
            this.tbHeap.Text = "Heap\'e Aktar";
            this.tbHeap.UseVisualStyleBackColor = true;
            // 
            // btnWordSort
            // 
            this.btnWordSort.Enabled = false;
            this.btnWordSort.Location = new System.Drawing.Point(132, 315);
            this.btnWordSort.Name = "btnWordSort";
            this.btnWordSort.Size = new System.Drawing.Size(150, 52);
            this.btnWordSort.TabIndex = 6;
            this.btnWordSort.Text = "Kelimeleri Sırala ve Getir";
            this.btnWordSort.UseVisualStyleBackColor = true;
            this.btnWordSort.Click += new System.EventHandler(this.btnWordSort_Click);
            // 
            // lblCount
            // 
            this.lblCount.AutoSize = true;
            this.lblCount.Location = new System.Drawing.Point(67, 261);
            this.lblCount.Name = "lblCount";
            this.lblCount.Size = new System.Drawing.Size(149, 20);
            this.lblCount.TabIndex = 5;
            this.lblCount.Text = "Kelime Sayısı Giriniz :";
            // 
            // txtCount
            // 
            this.txtCount.Location = new System.Drawing.Point(234, 258);
            this.txtCount.Name = "txtCount";
            this.txtCount.Size = new System.Drawing.Size(136, 27);
            this.txtCount.TabIndex = 4;
            // 
            // lblHeapExplanation
            // 
            this.lblHeapExplanation.AutoSize = true;
            this.lblHeapExplanation.Location = new System.Drawing.Point(579, 71);
            this.lblHeapExplanation.Name = "lblHeapExplanation";
            this.lblHeapExplanation.Size = new System.Drawing.Size(149, 20);
            this.lblHeapExplanation.TabIndex = 3;
            this.lblHeapExplanation.Text = "(Frekansa Göre Sıralı)";
            // 
            // lblHeapValues
            // 
            this.lblHeapValues.AutoSize = true;
            this.lblHeapValues.Location = new System.Drawing.Point(572, 51);
            this.lblHeapValues.Name = "lblHeapValues";
            this.lblHeapValues.Size = new System.Drawing.Size(157, 20);
            this.lblHeapValues.TabIndex = 2;
            this.lblHeapValues.Text = "Heap Ağacının Verileri";
            // 
            // txtHeapValues
            // 
            this.txtHeapValues.Location = new System.Drawing.Point(397, 102);
            this.txtHeapValues.Multiline = true;
            this.txtHeapValues.Name = "txtHeapValues";
            this.txtHeapValues.ReadOnly = true;
            this.txtHeapValues.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtHeapValues.Size = new System.Drawing.Size(503, 227);
            this.txtHeapValues.TabIndex = 1;
            // 
            // btnHeapTransfer
            // 
            this.btnHeapTransfer.Enabled = false;
            this.btnHeapTransfer.Location = new System.Drawing.Point(132, 102);
            this.btnHeapTransfer.Name = "btnHeapTransfer";
            this.btnHeapTransfer.Size = new System.Drawing.Size(150, 52);
            this.btnHeapTransfer.TabIndex = 0;
            this.btnHeapTransfer.Text = "Heap\'e Aktar";
            this.btnHeapTransfer.UseVisualStyleBackColor = true;
            this.btnHeapTransfer.Click += new System.EventHandler(this.btnHeapTransfer_Click);
            // 
            // tbHash
            // 
            this.tbHash.Controls.Add(this.btnHash);
            this.tbHash.Location = new System.Drawing.Point(4, 29);
            this.tbHash.Name = "tbHash";
            this.tbHash.Padding = new System.Windows.Forms.Padding(3);
            this.tbHash.Size = new System.Drawing.Size(984, 452);
            this.tbHash.TabIndex = 3;
            this.tbHash.Text = "Hash";
            this.tbHash.UseVisualStyleBackColor = true;
            // 
            // btnHash
            // 
            this.btnHash.Enabled = false;
            this.btnHash.Location = new System.Drawing.Point(402, 274);
            this.btnHash.Name = "btnHash";
            this.btnHash.Size = new System.Drawing.Size(142, 47);
            this.btnHash.TabIndex = 0;
            this.btnHash.Text = "Kelimeleri Hashle";
            this.btnHash.UseVisualStyleBackColor = true;
            this.btnHash.Click += new System.EventHandler(this.btnHash_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1326, 544);
            this.Controls.Add(this.tbGeneral);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tbGeneral.ResumeLayout(false);
            this.tbUploadText.ResumeLayout(false);
            this.tbUploadText.PerformLayout();
            this.tbStackTransfer.ResumeLayout(false);
            this.tbStackTransfer.PerformLayout();
            this.tbHeap.ResumeLayout(false);
            this.tbHeap.PerformLayout();
            this.tbHash.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnMetinYukle;
        private System.Windows.Forms.RichTextBox rtxtFile;
        private System.Windows.Forms.Button btnStackAktar;
        private System.Windows.Forms.RichTextBox rtxtFileValues;
        private System.Windows.Forms.TextBox txtSentences;
        private System.Windows.Forms.TextBox txtWords;
        private System.Windows.Forms.TabControl tbGeneral;
        private System.Windows.Forms.TabPage tbUploadText;
        private System.Windows.Forms.TabPage tbStackTransfer;
        private System.Windows.Forms.TabPage tbHeap;
        private System.Windows.Forms.Button btnHeapTransfer;
        private System.Windows.Forms.Label lblDatas;
        protected internal System.Windows.Forms.Label lblPath;
        private System.Windows.Forms.Label lblWords;
        private System.Windows.Forms.Label lblSentences;
        private System.Windows.Forms.TextBox txtGeneralValues;
        private System.Windows.Forms.Label lblGeneralValues;
        private System.Windows.Forms.TextBox txtHeapValues;
        private System.Windows.Forms.Label lblHeapExplanation;
        private System.Windows.Forms.Label lblHeapValues;
        private System.Windows.Forms.Button btnWordSort;
        private System.Windows.Forms.Label lblCount;
        private System.Windows.Forms.TextBox txtCount;
        private System.Windows.Forms.TabPage tbHash;
        private System.Windows.Forms.Button btnHash;
    }
}

