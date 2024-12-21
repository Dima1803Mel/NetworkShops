namespace NetworkShops
{
    partial class Assistant
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.idProduct = new System.Windows.Forms.TextBox();
            this.CountProduct = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Discount = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.Price = new System.Windows.Forms.TextBox();
            this.Summa = new System.Windows.Forms.TextBox();
            this.BuyProduct = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.buys = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.MenuBar;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(23, 53);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(564, 262);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.label1.Location = new System.Drawing.Point(158, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(277, 36);
            this.label1.TabIndex = 1;
            this.label1.Text = "Список продуктов";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.label2.Location = new System.Drawing.Point(634, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "ID продукта";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.label3.Location = new System.Drawing.Point(593, 154);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(213, 24);
            this.label3.TabIndex = 3;
            this.label3.Text = "Количество продукта";
            // 
            // idProduct
            // 
            this.idProduct.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.idProduct.Location = new System.Drawing.Point(849, 87);
            this.idProduct.Name = "idProduct";
            this.idProduct.Size = new System.Drawing.Size(208, 29);
            this.idProduct.TabIndex = 4;
            this.idProduct.TextChanged += new System.EventHandler(this.idProduct_TextChanged);
            // 
            // CountProduct
            // 
            this.CountProduct.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CountProduct.Location = new System.Drawing.Point(849, 149);
            this.CountProduct.Name = "CountProduct";
            this.CountProduct.Size = new System.Drawing.Size(208, 29);
            this.CountProduct.TabIndex = 5;
            this.CountProduct.TextChanged += new System.EventHandler(this.CountProduct_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.label4.Location = new System.Drawing.Point(656, 217);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 24);
            this.label4.TabIndex = 6;
            this.label4.Text = "Скидка";
            // 
            // Discount
            // 
            this.Discount.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Discount.Location = new System.Drawing.Point(849, 212);
            this.Discount.Name = "Discount";
            this.Discount.Size = new System.Drawing.Size(208, 29);
            this.Discount.TabIndex = 7;
            this.Discount.TextChanged += new System.EventHandler(this.Discount_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.label5.Location = new System.Drawing.Point(665, 287);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 24);
            this.label5.TabIndex = 8;
            this.label5.Text = "Цена";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.label6.Location = new System.Drawing.Point(656, 348);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 24);
            this.label6.TabIndex = 9;
            this.label6.Text = "Сумма";
            // 
            // Price
            // 
            this.Price.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Price.Location = new System.Drawing.Point(849, 286);
            this.Price.Name = "Price";
            this.Price.Size = new System.Drawing.Size(208, 29);
            this.Price.TabIndex = 10;
            this.Price.TextChanged += new System.EventHandler(this.Price_TextChanged);
            // 
            // Summa
            // 
            this.Summa.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Summa.Location = new System.Drawing.Point(849, 348);
            this.Summa.Name = "Summa";
            this.Summa.Size = new System.Drawing.Size(208, 29);
            this.Summa.TabIndex = 11;
            this.Summa.TextChanged += new System.EventHandler(this.Summa_TextChanged);
            // 
            // BuyProduct
            // 
            this.BuyProduct.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BuyProduct.Location = new System.Drawing.Point(741, 403);
            this.BuyProduct.Name = "BuyProduct";
            this.BuyProduct.Size = new System.Drawing.Size(291, 43);
            this.BuyProduct.TabIndex = 12;
            this.BuyProduct.Text = "Добавить в список покупок";
            this.BuyProduct.UseVisualStyleBackColor = true;
            this.BuyProduct.Click += new System.EventHandler(this.BuyProduct_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.label7.Location = new System.Drawing.Point(93, 341);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(445, 36);
            this.label7.TabIndex = 13;
            this.label7.Text = "Список продуктов на покупку";
            // 
            // dataGridView2
            // 
            this.dataGridView2.BackgroundColor = System.Drawing.SystemColors.MenuBar;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(23, 394);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(564, 261);
            this.dataGridView2.TabIndex = 14;
            this.dataGridView2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            // 
            // buys
            // 
            this.buys.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buys.Location = new System.Drawing.Point(781, 476);
            this.buys.Name = "buys";
            this.buys.Size = new System.Drawing.Size(205, 43);
            this.buys.TabIndex = 15;
            this.buys.Text = "Продать товары";
            this.buys.UseVisualStyleBackColor = true;
            this.buys.Click += new System.EventHandler(this.buys_Click);
            // 
            // Assistant
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(1083, 667);
            this.Controls.Add(this.buys);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.BuyProduct);
            this.Controls.Add(this.Summa);
            this.Controls.Add(this.Price);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Discount);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.CountProduct);
            this.Controls.Add(this.idProduct);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Assistant";
            this.Text = "Assistant";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox idProduct;
        private System.Windows.Forms.TextBox CountProduct;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Discount;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox Price;
        private System.Windows.Forms.TextBox Summa;
        private System.Windows.Forms.Button BuyProduct;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button buys;
    }
}