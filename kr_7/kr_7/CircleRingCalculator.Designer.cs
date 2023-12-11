namespace kr_7
{
    partial class CircleRingCalculatorForm
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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.calculateButton = new System.Windows.Forms.Button();
            this.txtY = new System.Windows.Forms.TextBox();
            this.txtX = new System.Windows.Forms.TextBox();
            this.resultLabel = new System.Windows.Forms.Label();
            this.btnCalculateCircle = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtRadius = new System.Windows.Forms.TextBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnCalculateCircleProperties = new System.Windows.Forms.Button();
            this.btnCheckPoint = new System.Windows.Forms.Button();
            this.btnCalculateRing = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtInnerRadius = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtOuterRadius = new System.Windows.Forms.TextBox();
            this.btnCalculateRingProperties = new System.Windows.Forms.Button();
            this.btnCheckPointRing = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(15, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 16);
            this.label2.TabIndex = 14;
            this.label2.Text = "Введіть y";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label1.Location = new System.Drawing.Point(15, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 16);
            this.label1.TabIndex = 13;
            this.label1.Text = "Введіть x";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pictureBox1.Location = new System.Drawing.Point(294, 16);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(390, 390);
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // calculateButton
            // 
            this.calculateButton.BackColor = System.Drawing.SystemColors.Control;
            this.calculateButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.calculateButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.calculateButton.ForeColor = System.Drawing.SystemColors.WindowText;
            this.calculateButton.Location = new System.Drawing.Point(18, 82);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(120, 40);
            this.calculateButton.TabIndex = 11;
            this.calculateButton.Text = "Створити точку";
            this.calculateButton.UseVisualStyleBackColor = false;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // txtY
            // 
            this.txtY.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtY.Location = new System.Drawing.Point(91, 49);
            this.txtY.Name = "txtY";
            this.txtY.Size = new System.Drawing.Size(117, 22);
            this.txtY.TabIndex = 10;
            // 
            // txtX
            // 
            this.txtX.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtX.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtX.Location = new System.Drawing.Point(91, 16);
            this.txtX.Name = "txtX";
            this.txtX.Size = new System.Drawing.Size(117, 22);
            this.txtX.TabIndex = 9;
            // 
            // resultLabel
            // 
            this.resultLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.resultLabel.Location = new System.Drawing.Point(705, 16);
            this.resultLabel.Name = "resultLabel";
            this.resultLabel.Size = new System.Drawing.Size(249, 85);
            this.resultLabel.TabIndex = 15;
            // 
            // btnCalculateCircle
            // 
            this.btnCalculateCircle.BackColor = System.Drawing.SystemColors.Control;
            this.btnCalculateCircle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCalculateCircle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnCalculateCircle.ForeColor = System.Drawing.SystemColors.WindowText;
            this.btnCalculateCircle.Location = new System.Drawing.Point(11, 174);
            this.btnCalculateCircle.Name = "btnCalculateCircle";
            this.btnCalculateCircle.Size = new System.Drawing.Size(120, 40);
            this.btnCalculateCircle.TabIndex = 16;
            this.btnCalculateCircle.Text = "Створити коло";
            this.btnCalculateCircle.UseVisualStyleBackColor = false;
            this.btnCalculateCircle.Click += new System.EventHandler(this.btnCalculateCircle_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(15, 144);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 16);
            this.label3.TabIndex = 18;
            this.label3.Text = "Радіус";
            // 
            // txtRadius
            // 
            this.txtRadius.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtRadius.Location = new System.Drawing.Point(91, 141);
            this.txtRadius.Name = "txtRadius";
            this.txtRadius.Size = new System.Drawing.Size(117, 22);
            this.txtRadius.TabIndex = 17;
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.LightCoral;
            this.btnClear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnClear.ForeColor = System.Drawing.SystemColors.WindowText;
            this.btnClear.Location = new System.Drawing.Point(708, 390);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(120, 40);
            this.btnClear.TabIndex = 19;
            this.btnClear.Text = "Очистити";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnCalculateCircleProperties
            // 
            this.btnCalculateCircleProperties.BackColor = System.Drawing.SystemColors.Control;
            this.btnCalculateCircleProperties.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCalculateCircleProperties.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnCalculateCircleProperties.ForeColor = System.Drawing.SystemColors.WindowText;
            this.btnCalculateCircleProperties.Location = new System.Drawing.Point(141, 174);
            this.btnCalculateCircleProperties.Name = "btnCalculateCircleProperties";
            this.btnCalculateCircleProperties.Size = new System.Drawing.Size(120, 40);
            this.btnCalculateCircleProperties.TabIndex = 20;
            this.btnCalculateCircleProperties.Text = "Дані";
            this.btnCalculateCircleProperties.UseVisualStyleBackColor = false;
            this.btnCalculateCircleProperties.Click += new System.EventHandler(this.btnCalculateCircleProperties_Click);
            // 
            // btnCheckPoint
            // 
            this.btnCheckPoint.BackColor = System.Drawing.SystemColors.Control;
            this.btnCheckPoint.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCheckPoint.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnCheckPoint.ForeColor = System.Drawing.SystemColors.WindowText;
            this.btnCheckPoint.Location = new System.Drawing.Point(141, 220);
            this.btnCheckPoint.Name = "btnCheckPoint";
            this.btnCheckPoint.Size = new System.Drawing.Size(120, 40);
            this.btnCheckPoint.TabIndex = 21;
            this.btnCheckPoint.Text = "Чи належить точка колу";
            this.btnCheckPoint.UseVisualStyleBackColor = false;
            this.btnCheckPoint.Click += new System.EventHandler(this.btnCheckPoint_Click);
            // 
            // btnCalculateRing
            // 
            this.btnCalculateRing.BackColor = System.Drawing.SystemColors.Control;
            this.btnCalculateRing.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCalculateRing.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnCalculateRing.ForeColor = System.Drawing.SystemColors.WindowText;
            this.btnCalculateRing.Location = new System.Drawing.Point(18, 344);
            this.btnCalculateRing.Name = "btnCalculateRing";
            this.btnCalculateRing.Size = new System.Drawing.Size(120, 40);
            this.btnCalculateRing.TabIndex = 22;
            this.btnCalculateRing.Text = "Створити кільце";
            this.btnCalculateRing.UseVisualStyleBackColor = false;
            this.btnCalculateRing.Click += new System.EventHandler(this.btnCalculateRing_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(15, 281);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(123, 16);
            this.label4.TabIndex = 24;
            this.label4.Text = "Внутрішній радіус";
            // 
            // txtInnerRadius
            // 
            this.txtInnerRadius.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtInnerRadius.Location = new System.Drawing.Point(144, 278);
            this.txtInnerRadius.Name = "txtInnerRadius";
            this.txtInnerRadius.Size = new System.Drawing.Size(117, 22);
            this.txtInnerRadius.TabIndex = 23;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(15, 314);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(116, 16);
            this.label5.TabIndex = 26;
            this.label5.Text = "Зовнішній радіус";
            // 
            // txtOuterRadius
            // 
            this.txtOuterRadius.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtOuterRadius.Location = new System.Drawing.Point(144, 311);
            this.txtOuterRadius.Name = "txtOuterRadius";
            this.txtOuterRadius.Size = new System.Drawing.Size(117, 22);
            this.txtOuterRadius.TabIndex = 25;
            // 
            // btnCalculateRingProperties
            // 
            this.btnCalculateRingProperties.BackColor = System.Drawing.SystemColors.Control;
            this.btnCalculateRingProperties.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCalculateRingProperties.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnCalculateRingProperties.ForeColor = System.Drawing.SystemColors.WindowText;
            this.btnCalculateRingProperties.Location = new System.Drawing.Point(144, 344);
            this.btnCalculateRingProperties.Name = "btnCalculateRingProperties";
            this.btnCalculateRingProperties.Size = new System.Drawing.Size(120, 40);
            this.btnCalculateRingProperties.TabIndex = 27;
            this.btnCalculateRingProperties.Text = "Дані";
            this.btnCalculateRingProperties.UseVisualStyleBackColor = false;
            this.btnCalculateRingProperties.Click += new System.EventHandler(this.btnCalculateRingProperties_Click);
            // 
            // btnCheckPointRing
            // 
            this.btnCheckPointRing.BackColor = System.Drawing.SystemColors.Control;
            this.btnCheckPointRing.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCheckPointRing.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnCheckPointRing.ForeColor = System.Drawing.SystemColors.WindowText;
            this.btnCheckPointRing.Location = new System.Drawing.Point(144, 390);
            this.btnCheckPointRing.Name = "btnCheckPointRing";
            this.btnCheckPointRing.Size = new System.Drawing.Size(120, 40);
            this.btnCheckPointRing.TabIndex = 28;
            this.btnCheckPointRing.Text = "Чи належить точка кільцю";
            this.btnCheckPointRing.UseVisualStyleBackColor = false;
            this.btnCheckPointRing.Click += new System.EventHandler(this.btnCheckPointRing_Click);
            // 
            // CircleRingCalculatorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(966, 443);
            this.Controls.Add(this.btnCheckPointRing);
            this.Controls.Add(this.btnCalculateRingProperties);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtOuterRadius);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtInnerRadius);
            this.Controls.Add(this.btnCalculateRing);
            this.Controls.Add(this.btnCheckPoint);
            this.Controls.Add(this.btnCalculateCircleProperties);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtRadius);
            this.Controls.Add(this.btnCalculateCircle);
            this.Controls.Add(this.resultLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.txtY);
            this.Controls.Add(this.txtX);
            this.Name = "CircleRingCalculatorForm";
            this.Text = "Калькулятор";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.TextBox txtY;
        private System.Windows.Forms.TextBox txtX;
        private System.Windows.Forms.Label resultLabel;
        private System.Windows.Forms.Button btnCalculateCircle;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtRadius;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnCalculateCircleProperties;
        private System.Windows.Forms.Button btnCheckPoint;
        private System.Windows.Forms.Button btnCalculateRing;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtInnerRadius;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtOuterRadius;
        private System.Windows.Forms.Button btnCalculateRingProperties;
        private System.Windows.Forms.Button btnCheckPointRing;
    }
}

