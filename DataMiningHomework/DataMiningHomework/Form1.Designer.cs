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
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.txtSampleMean = new System.Windows.Forms.TextBox();
            this.txtVarianceM3 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtVarianceM2 = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtVarianceM1 = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtVariance0 = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txtVariance1 = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.txtSD1 = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.txtSD0 = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.txtSDM1 = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.txtSDM2 = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.txtSDM3 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnGenerateSample
            // 
            this.btnGenerateSample.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGenerateSample.Location = new System.Drawing.Point(616, 409);
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
            this.label1.Location = new System.Drawing.Point(320, 492);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Sample Size:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(320, 524);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Range:";
            // 
            // txtSampleSize
            // 
            this.txtSampleSize.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtSampleSize.Location = new System.Drawing.Point(434, 489);
            this.txtSampleSize.Name = "txtSampleSize";
            this.txtSampleSize.Size = new System.Drawing.Size(152, 26);
            this.txtSampleSize.TabIndex = 3;
            this.txtSampleSize.Text = "0";
            // 
            // txtRange
            // 
            this.txtRange.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtRange.Location = new System.Drawing.Point(434, 521);
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
            this.txtBoxPopulation.Size = new System.Drawing.Size(235, 342);
            this.txtBoxPopulation.TabIndex = 5;
            this.txtBoxPopulation.Text = "";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(33, 403);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(143, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Population Mean :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(33, 466);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(163, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Population Variance:";
            // 
            // txtMean
            // 
            this.txtMean.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtMean.Location = new System.Drawing.Point(37, 426);
            this.txtMean.Name = "txtMean";
            this.txtMean.ReadOnly = true;
            this.txtMean.Size = new System.Drawing.Size(142, 26);
            this.txtMean.TabIndex = 8;
            // 
            // txtVariance
            // 
            this.txtVariance.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtVariance.Location = new System.Drawing.Point(37, 489);
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
            this.label6.Location = new System.Drawing.Point(33, 530);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(239, 20);
            this.label6.TabIndex = 11;
            this.label6.Text = "Population Standard Deviation:";
            // 
            // txtSD
            // 
            this.txtSD.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtSD.Location = new System.Drawing.Point(37, 553);
            this.txtSD.Name = "txtSD";
            this.txtSD.ReadOnly = true;
            this.txtSD.Size = new System.Drawing.Size(146, 26);
            this.txtSD.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(370, 31);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(116, 20);
            this.label7.TabIndex = 13;
            this.label7.Text = "Sample Mean:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(370, 110);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(141, 20);
            this.label8.TabIndex = 15;
            this.label8.Text = "Sample Variance:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.Location = new System.Drawing.Point(612, 57);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(160, 20);
            this.label9.TabIndex = 16;
            this.label9.Text = "Sample S.Deviation:";
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnClear.Location = new System.Drawing.Point(679, 487);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(77, 60);
            this.btnClear.TabIndex = 19;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            // 
            // txtSampleMean
            // 
            this.txtSampleMean.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtSampleMean.Location = new System.Drawing.Point(374, 63);
            this.txtSampleMean.Name = "txtSampleMean";
            this.txtSampleMean.ReadOnly = true;
            this.txtSampleMean.Size = new System.Drawing.Size(127, 26);
            this.txtSampleMean.TabIndex = 20;
            // 
            // txtVarianceM3
            // 
            this.txtVarianceM3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtVarianceM3.Location = new System.Drawing.Point(374, 167);
            this.txtVarianceM3.Name = "txtVarianceM3";
            this.txtVarianceM3.ReadOnly = true;
            this.txtVarianceM3.Size = new System.Drawing.Size(127, 26);
            this.txtVarianceM3.TabIndex = 21;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.Location = new System.Drawing.Point(370, 144);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(43, 20);
            this.label10.TabIndex = 22;
            this.label10.Text = "a: -3";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label11.Location = new System.Drawing.Point(370, 201);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(43, 20);
            this.label11.TabIndex = 24;
            this.label11.Text = "a: -2";
            // 
            // txtVarianceM2
            // 
            this.txtVarianceM2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtVarianceM2.Location = new System.Drawing.Point(374, 224);
            this.txtVarianceM2.Name = "txtVarianceM2";
            this.txtVarianceM2.ReadOnly = true;
            this.txtVarianceM2.Size = new System.Drawing.Size(127, 26);
            this.txtVarianceM2.TabIndex = 23;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label12.Location = new System.Drawing.Point(370, 253);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(43, 20);
            this.label12.TabIndex = 26;
            this.label12.Text = "a: -1";
            // 
            // txtVarianceM1
            // 
            this.txtVarianceM1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtVarianceM1.Location = new System.Drawing.Point(374, 276);
            this.txtVarianceM1.Name = "txtVarianceM1";
            this.txtVarianceM1.ReadOnly = true;
            this.txtVarianceM1.Size = new System.Drawing.Size(127, 26);
            this.txtVarianceM1.TabIndex = 25;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label13.Location = new System.Drawing.Point(370, 305);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(37, 20);
            this.label13.TabIndex = 28;
            this.label13.Text = "a: 0";
            // 
            // txtVariance0
            // 
            this.txtVariance0.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtVariance0.Location = new System.Drawing.Point(374, 328);
            this.txtVariance0.Name = "txtVariance0";
            this.txtVariance0.ReadOnly = true;
            this.txtVariance0.Size = new System.Drawing.Size(127, 26);
            this.txtVariance0.TabIndex = 27;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label14.Location = new System.Drawing.Point(370, 357);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(37, 20);
            this.label14.TabIndex = 30;
            this.label14.Text = "a: 1";
            // 
            // txtVariance1
            // 
            this.txtVariance1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtVariance1.Location = new System.Drawing.Point(374, 380);
            this.txtVariance1.Name = "txtVariance1";
            this.txtVariance1.ReadOnly = true;
            this.txtVariance1.Size = new System.Drawing.Size(127, 26);
            this.txtVariance1.TabIndex = 29;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label15.Location = new System.Drawing.Point(612, 305);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(37, 20);
            this.label15.TabIndex = 40;
            this.label15.Text = "a: 1";
            // 
            // txtSD1
            // 
            this.txtSD1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtSD1.Location = new System.Drawing.Point(616, 328);
            this.txtSD1.Name = "txtSD1";
            this.txtSD1.ReadOnly = true;
            this.txtSD1.Size = new System.Drawing.Size(127, 26);
            this.txtSD1.TabIndex = 39;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label16.Location = new System.Drawing.Point(612, 253);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(37, 20);
            this.label16.TabIndex = 38;
            this.label16.Text = "a: 0";
            // 
            // txtSD0
            // 
            this.txtSD0.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtSD0.Location = new System.Drawing.Point(616, 276);
            this.txtSD0.Name = "txtSD0";
            this.txtSD0.ReadOnly = true;
            this.txtSD0.Size = new System.Drawing.Size(127, 26);
            this.txtSD0.TabIndex = 37;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label17.Location = new System.Drawing.Point(612, 201);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(43, 20);
            this.label17.TabIndex = 36;
            this.label17.Text = "a: -1";
            // 
            // txtSDM1
            // 
            this.txtSDM1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtSDM1.Location = new System.Drawing.Point(616, 224);
            this.txtSDM1.Name = "txtSDM1";
            this.txtSDM1.ReadOnly = true;
            this.txtSDM1.Size = new System.Drawing.Size(127, 26);
            this.txtSDM1.TabIndex = 35;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label18.Location = new System.Drawing.Point(612, 149);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(43, 20);
            this.label18.TabIndex = 34;
            this.label18.Text = "a: -2";
            // 
            // txtSDM2
            // 
            this.txtSDM2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtSDM2.Location = new System.Drawing.Point(616, 172);
            this.txtSDM2.Name = "txtSDM2";
            this.txtSDM2.ReadOnly = true;
            this.txtSDM2.Size = new System.Drawing.Size(127, 26);
            this.txtSDM2.TabIndex = 33;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label19.Location = new System.Drawing.Point(612, 97);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(43, 20);
            this.label19.TabIndex = 32;
            this.label19.Text = "a: -3";
            // 
            // txtSDM3
            // 
            this.txtSDM3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtSDM3.Location = new System.Drawing.Point(616, 120);
            this.txtSDM3.Name = "txtSDM3";
            this.txtSDM3.ReadOnly = true;
            this.txtSDM3.Size = new System.Drawing.Size(127, 26);
            this.txtSDM3.TabIndex = 31;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(817, 608);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.txtSD1);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.txtSD0);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.txtSDM1);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.txtSDM2);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.txtSDM3);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.txtVariance1);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.txtVariance0);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txtVarianceM1);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtVarianceM2);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtVarianceM3);
            this.Controls.Add(this.txtSampleMean);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
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
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.TextBox txtSampleMean;
        private System.Windows.Forms.TextBox txtVarianceM3;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtVarianceM2;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtVarianceM1;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtVariance0;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtVariance1;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtSD1;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txtSD0;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox txtSDM1;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox txtSDM2;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox txtSDM3;
    }
}

