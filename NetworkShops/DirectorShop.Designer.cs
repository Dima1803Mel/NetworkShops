namespace NetworkShops
{
    partial class DirectorShop
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
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.idProduct = new System.Windows.Forms.TextBox();
            this.nameProduct = new System.Windows.Forms.TextBox();
            this.countProduct = new System.Windows.Forms.TextBox();
            this.price = new System.Windows.Forms.TextBox();
            this.AddProduct = new System.Windows.Forms.Button();
            this.DeleteProduct = new System.Windows.Forms.Button();
            this.DoCustom = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.id_delete_product = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(68, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(381, 42);
            this.label1.TabIndex = 0;
            this.label1.Text = "Список ассортимента";
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 54);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(523, 589);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(585, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "ID продукта";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(560, 147);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(192, 24);
            this.label3.TabIndex = 3;
            this.label3.Text = "Название продукта";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label4.Location = new System.Drawing.Point(546, 218);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(213, 24);
            this.label4.TabIndex = 4;
            this.label4.Text = "Количество продукта";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label5.Location = new System.Drawing.Point(621, 287);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 24);
            this.label5.TabIndex = 5;
            this.label5.Text = "Цена";
            // 
            // idProduct
            // 
            this.idProduct.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.idProduct.Location = new System.Drawing.Point(774, 75);
            this.idProduct.Name = "idProduct";
            this.idProduct.Size = new System.Drawing.Size(232, 32);
            this.idProduct.TabIndex = 6;
            // 
            // nameProduct
            // 
            this.nameProduct.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nameProduct.Location = new System.Drawing.Point(774, 147);
            this.nameProduct.Name = "nameProduct";
            this.nameProduct.Size = new System.Drawing.Size(232, 32);
            this.nameProduct.TabIndex = 7;
            // 
            // countProduct
            // 
            this.countProduct.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.countProduct.Location = new System.Drawing.Point(774, 218);
            this.countProduct.Name = "countProduct";
            this.countProduct.Size = new System.Drawing.Size(232, 32);
            this.countProduct.TabIndex = 8;
            // 
            // price
            // 
            this.price.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.price.Location = new System.Drawing.Point(774, 285);
            this.price.Name = "price";
            this.price.Size = new System.Drawing.Size(232, 32);
            this.price.TabIndex = 9;
            // 
            // AddProduct
            // 
            this.AddProduct.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddProduct.Location = new System.Drawing.Point(774, 368);
            this.AddProduct.Name = "AddProduct";
            this.AddProduct.Size = new System.Drawing.Size(232, 41);
            this.AddProduct.TabIndex = 10;
            this.AddProduct.Text = "Добавить продукт";
            this.AddProduct.UseVisualStyleBackColor = true;
            this.AddProduct.Click += new System.EventHandler(this.AddProduct_Click);
            // 
            // DeleteProduct
            // 
            this.DeleteProduct.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DeleteProduct.Location = new System.Drawing.Point(774, 520);
            this.DeleteProduct.Name = "DeleteProduct";
            this.DeleteProduct.Size = new System.Drawing.Size(232, 41);
            this.DeleteProduct.TabIndex = 11;
            this.DeleteProduct.Text = "Удалить продукт";
            this.DeleteProduct.UseVisualStyleBackColor = true;
            this.DeleteProduct.Click += new System.EventHandler(this.DeleteProduct_Click);
            // 
            // DoCustom
            // 
            this.DoCustom.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DoCustom.Location = new System.Drawing.Point(774, 442);
            this.DoCustom.Name = "DoCustom";
            this.DoCustom.Size = new System.Drawing.Size(232, 41);
            this.DoCustom.TabIndex = 12;
            this.DoCustom.Text = "Сделать закупку";
            this.DoCustom.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label6.Location = new System.Drawing.Point(560, 528);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(32, 24);
            this.label6.TabIndex = 13;
            this.label6.Text = "ID";
            // 
            // id_delete_product
            // 
            this.id_delete_product.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.id_delete_product.Location = new System.Drawing.Point(625, 528);
            this.id_delete_product.Name = "id_delete_product";
            this.id_delete_product.Size = new System.Drawing.Size(100, 32);
            this.id_delete_product.TabIndex = 14;
            // 
            // DirectorShop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(1018, 655);
            this.Controls.Add(this.id_delete_product);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.DoCustom);
            this.Controls.Add(this.DeleteProduct);
            this.Controls.Add(this.AddProduct);
            this.Controls.Add(this.price);
            this.Controls.Add(this.countProduct);
            this.Controls.Add(this.nameProduct);
            this.Controls.Add(this.idProduct);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Name = "DirectorShop";
            this.Text = "DirectorShop";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox idProduct;
        private System.Windows.Forms.TextBox nameProduct;
        private System.Windows.Forms.TextBox countProduct;
        private System.Windows.Forms.TextBox price;
        private System.Windows.Forms.Button AddProduct;
        private System.Windows.Forms.Button DeleteProduct;
        private System.Windows.Forms.Button DoCustom;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox id_delete_product;
    }
}