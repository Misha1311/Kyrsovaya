namespace Kyrsovaya
{
    partial class input
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
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.OupNameShop = new System.Windows.Forms.TextBox();
            this.OupAddress = new System.Windows.Forms.TextBox();
            this.OupCode = new System.Windows.Forms.TextBox();
            this.OupProductName = new System.Windows.Forms.TextBox();
            this.OupQuantity = new System.Windows.Forms.TextBox();
            this.OupPrice = new System.Windows.Forms.TextBox();
            this.OupSum = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(42, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(295, 25);
            this.label1.TabIndex = 7;
            this.label1.Text = "Введите название магазина";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(42, 140);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(311, 25);
            this.label3.TabIndex = 9;
            this.label3.Text = "Введите артикул (код товара)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(42, 190);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(270, 25);
            this.label4.TabIndex = 10;
            this.label4.Text = "Введите название товара";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(42, 240);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(301, 25);
            this.label5.TabIndex = 11;
            this.label5.Text = "Введите количество товаров";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(42, 290);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(267, 25);
            this.label6.TabIndex = 12;
            this.label6.Text = "Введите цена за единицу";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(42, 340);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(164, 25);
            this.label7.TabIndex = 13;
            this.label7.Text = "Введите сумму";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(42, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(198, 25);
            this.label2.TabIndex = 14;
            this.label2.Text = "Введите его адрес";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(47, 398);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(306, 40);
            this.button1.TabIndex = 15;
            this.button1.Text = "Сохранить и выйти в главное меню";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // OupNameShop
            // 
            this.OupNameShop.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.OupNameShop.Location = new System.Drawing.Point(426, 34);
            this.OupNameShop.Name = "OupNameShop";
            this.OupNameShop.Size = new System.Drawing.Size(279, 31);
            this.OupNameShop.TabIndex = 19;
            // 
            // OupAddress
            // 
            this.OupAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.OupAddress.Location = new System.Drawing.Point(426, 84);
            this.OupAddress.Name = "OupAddress";
            this.OupAddress.Size = new System.Drawing.Size(279, 31);
            this.OupAddress.TabIndex = 20;
            // 
            // OupCode
            // 
            this.OupCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.OupCode.Location = new System.Drawing.Point(426, 134);
            this.OupCode.Name = "OupCode";
            this.OupCode.Size = new System.Drawing.Size(279, 31);
            this.OupCode.TabIndex = 21;
            // 
            // OupProductName
            // 
            this.OupProductName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.OupProductName.Location = new System.Drawing.Point(426, 184);
            this.OupProductName.Name = "OupProductName";
            this.OupProductName.Size = new System.Drawing.Size(279, 31);
            this.OupProductName.TabIndex = 22;
            // 
            // OupQuantity
            // 
            this.OupQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.OupQuantity.Location = new System.Drawing.Point(426, 234);
            this.OupQuantity.Name = "OupQuantity";
            this.OupQuantity.Size = new System.Drawing.Size(279, 31);
            this.OupQuantity.TabIndex = 23;
            // 
            // OupPrice
            // 
            this.OupPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.OupPrice.Location = new System.Drawing.Point(426, 284);
            this.OupPrice.Name = "OupPrice";
            this.OupPrice.Size = new System.Drawing.Size(279, 31);
            this.OupPrice.TabIndex = 24;
            // 
            // OupSum
            // 
            this.OupSum.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.OupSum.Location = new System.Drawing.Point(426, 334);
            this.OupSum.Name = "OupSum";
            this.OupSum.Size = new System.Drawing.Size(279, 31);
            this.OupSum.TabIndex = 25;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.Location = new System.Drawing.Point(426, 398);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(279, 40);
            this.button2.TabIndex = 26;
            this.button2.Text = "Добавить новые данные";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // input
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.OupSum);
            this.Controls.Add(this.OupPrice);
            this.Controls.Add(this.OupQuantity);
            this.Controls.Add(this.OupProductName);
            this.Controls.Add(this.OupCode);
            this.Controls.Add(this.OupAddress);
            this.Controls.Add(this.OupNameShop);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "input";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox OupNameShop;
        private System.Windows.Forms.TextBox OupAddress;
        private System.Windows.Forms.TextBox OupCode;
        private System.Windows.Forms.TextBox OupProductName;
        private System.Windows.Forms.TextBox OupQuantity;
        private System.Windows.Forms.TextBox OupPrice;
        private System.Windows.Forms.TextBox OupSum;
        private System.Windows.Forms.Button button2;
    }
}

