namespace DataMiningHomework
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnGenerateSample = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSampleSize = new System.Windows.Forms.TextBox();
            this.txtRange = new System.Windows.Forms.TextBox();
            this.txtBoxPopulation = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtMean = new System.Windows.Forms.TextBox();
            this.txtVariance = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtSD = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtMeanCumulative = new System.Windows.Forms.RichTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtVarianceCumulative = new System.Windows.Forms.RichTextBox();
            this.txtDeviationCumulative = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // btnGenerateSample
            // 
            this.btnGenerateSample.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGenerateSample.Location = new System.Drawing.Point(609, 548);
            this.btnGenerateSample.Name = "btnGenerateSample";
            this.btnGenerateSample.Size = new System.Drawing.Size(140, 61);
            this.btnGenerateSample.TabIndex = 0;
            this.btnGenerateSample.Text = "Generate Sample";
            this.btnGenerateSample.UseVisualStyleBackColor = true;
            this.btnGenerateSample.Click += new System.EventHandler(this.btnGenerateSample_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(316, 548);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Sample Size:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(316, 580);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Range:";
            // 
            // txtSampleSize
            // 
            this.txtSampleSize.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtSampleSize.Location = new System.Drawing.Point(430, 545);
            this.txtSampleSize.Name = "txtSampleSize";
            this.txtSampleSize.Size = new System.Drawing.Size(152, 26);
            this.txtSampleSize.TabIndex = 3;
            this.txtSampleSize.Text = "0";
            // 
            // txtRange
            // 
            this.txtRange.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtRange.Location = new System.Drawing.Point(430, 577);
            this.txtRange.Name = "txtRange";
            this.txtRange.Size = new System.Drawing.Size(152, 26);
            this.txtRange.TabIndex = 4;
            this.txtRange.Text = "0";
            // 
            // txtBoxPopulation
            // 
            this.txtBoxPopulation.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtBoxPopulation.Location = new System.Drawing.Point(37, 54);
            this.txtBoxPopulation.Name = "txtBoxPopulation";
            this.txtBoxPopulation.ReadOnly = true;
            this.txtBoxPopulation.Size = new System.Drawing.Size(235, 370);
            this.txtBoxPopulation.TabIndex = 5;
            this.txtBoxPopulation.Text = "";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(33, 427);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(143, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Population Mean :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(33, 490);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(163, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Population Variance:";
            // 
            // txtMean
            // 
            this.txtMean.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtMean.Location = new System.Drawing.Point(37, 450);
            this.txtMean.Name = "txtMean";
            this.txtMean.ReadOnly = true;
            this.txtMean.Size = new System.Drawing.Size(142, 26);
            this.txtMean.TabIndex = 8;
            // 
            // txtVariance
            // 
            this.txtVariance.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtVariance.Location = new System.Drawing.Point(37, 513);
            this.txtVariance.Name = "txtVariance";
            this.txtVariance.ReadOnly = true;
            this.txtVariance.Size = new System.Drawing.Size(146, 26);
            this.txtVariance.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(33, 31);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(162, 20);
            this.label5.TabIndex = 10;
            this.label5.Text = "Population Samples:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(33, 554);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(239, 20);
            this.label6.TabIndex = 11;
            this.label6.Text = "Population Standard Deviation:";
            // 
            // txtSD
            // 
            this.txtSD.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtSD.Location = new System.Drawing.Point(37, 577);
            this.txtSD.Name = "txtSD";
            this.txtSD.ReadOnly = true;
            this.txtSD.Size = new System.Drawing.Size(146, 26);
            this.txtSD.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(316, 31);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(143, 20);
            this.label7.TabIndex = 13;
            this.label7.Text = "Cumulative Mean:";
            // 
            // txtMeanCumulative
            // 
            this.txtMeanCumulative.Location = new System.Drawing.Point(320, 54);
            this.txtMeanCumulative.Name = "txtMeanCumulative";
            this.txtMeanCumulative.ReadOnly = true;
            this.txtMeanCumulative.Size = new System.Drawing.Size(108, 485);
            this.txtMeanCumulative.TabIndex = 14;
            this.txtMeanCumulative.Text = "";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(465, 31);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(124, 20);
            this.label8.TabIndex = 15;
            this.label8.Text = "Cum. Variance:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.Location = new System.Drawing.Point(614, 31);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(143, 20);
            this.label9.TabIndex = 16;
            this.label9.Text = "Cum. S.Deviation:";
            // 
            // txtVarianceCumulative
            // 
            this.txtVarianceCumulative.Location = new System.Drawing.Point(469, 54);
            this.txtVarianceCumulative.Name = "txtVarianceCumulative";
            this.txtVarianceCumulative.ReadOnly = true;
            this.txtVarianceCumulative.Size = new System.Drawing.Size(108, 485);
            this.txtVarianceCumulative.TabIndex = 17;
            this.txtVarianceCumulative.Text = "";
            // 
            // txtDeviationCumulative
            // 
            this.txtDeviationCumulative.Location = new System.Drawing.Point(618, 54);
            this.txtDeviationCumulative.Name = "txtDeviationCumulative";
            this.txtDeviationCumulative.ReadOnly = true;
            this.txtDeviationCumulative.Size = new System.Drawing.Size(108, 485);
            this.txtDeviationCumulative.TabIndex = 18;
            this.txtDeviationCumulative.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(799, 633);
            this.Controls.Add(this.txtDeviationCumulative);
            this.Controls.Add(this.txtVarianceCumulative);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtMeanCumulative);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtSD);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtVariance);
            this.Controls.Add(this.txtMean);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtBoxPopulation);
            this.Controls.Add(this.txtRange);
            this.Controls.Add(this.txtSampleSize);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnGenerateSample);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Data Mining Homework";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGenerateSample;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSampleSize;
        private System.Windows.Forms.TextBox txtRange;
        private System.Windows.Forms.RichTextBox txtBoxPopulation;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtMean;
        private System.Windows.Forms.TextBox txtVariance;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtSD;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.RichTextBox txtMeanCumulative;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.RichTextBox txtVarianceCumulative;
        private System.Windows.Forms.RichTextBox txtDeviationCumulative;
    }
}

