namespace NetworkShops
{
    partial class DirectorNetworkShops
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
            this.idShop = new System.Windows.Forms.TextBox();
            this.PlaceShop = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.AddShop = new System.Windows.Forms.Button();
            this.DeleteShop = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.idDeleteShop = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 56);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(523, 589);
            this.dataGridView1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(94, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(325, 42);
            this.label1.TabIndex = 3;
            this.label1.Text = "Список магазинов";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(611, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 24);
            this.label2.TabIndex = 4;
            this.label2.Text = "ID магазина";
            // 
            // idShop
            // 
            this.idShop.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.idShop.Location = new System.Drawing.Point(782, 89);
            this.idShop.Name = "idShop";
            this.idShop.Size = new System.Drawing.Size(232, 32);
            this.idShop.TabIndex = 7;
            // 
            // PlaceShop
            // 
            this.PlaceShop.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PlaceShop.Location = new System.Drawing.Point(782, 167);
            this.PlaceShop.Name = "PlaceShop";
            this.PlaceShop.Size = new System.Drawing.Size(232, 32);
            this.PlaceShop.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(590, 167);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(163, 24);
            this.label3.TabIndex = 8;
            this.label3.Text = "Место магазина";
            // 
            // AddShop
            // 
            this.AddShop.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddShop.Location = new System.Drawing.Point(683, 233);
            this.AddShop.Name = "AddShop";
            this.AddShop.Size = new System.Drawing.Size(232, 41);
            this.AddShop.TabIndex = 11;
            this.AddShop.Text = "Добавить магазин";
            this.AddShop.UseVisualStyleBackColor = true;
            this.AddShop.Click += new System.EventHandler(this.AddShop_Click);
            // 
            // DeleteShop
            // 
            this.DeleteShop.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DeleteShop.Location = new System.Drawing.Point(782, 305);
            this.DeleteShop.Name = "DeleteShop";
            this.DeleteShop.Size = new System.Drawing.Size(232, 41);
            this.DeleteShop.TabIndex = 12;
            this.DeleteShop.Text = "Удалить магазин";
            this.DeleteShop.UseVisualStyleBackColor = true;
            this.DeleteShop.Click += new System.EventHandler(this.DeleteShop_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label4.Location = new System.Drawing.Point(590, 314);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 24);
            this.label4.TabIndex = 13;
            this.label4.Text = "ID";
            // 
            // idDeleteShop
            // 
            this.idDeleteShop.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.idDeleteShop.Location = new System.Drawing.Point(657, 311);
            this.idDeleteShop.Name = "idDeleteShop";
            this.idDeleteShop.Size = new System.Drawing.Size(80, 32);
            this.idDeleteShop.TabIndex = 14;
            // 
            // DirectorNetworkShops
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(1058, 657);
            this.Controls.Add(this.idDeleteShop);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.DeleteShop);
            this.Controls.Add(this.AddShop);
            this.Controls.Add(this.PlaceShop);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.idShop);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "DirectorNetworkShops";
            this.Text = "DirectorNetworkShops";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox idShop;
        private System.Windows.Forms.TextBox PlaceShop;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button AddShop;
        private System.Windows.Forms.Button DeleteShop;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox idDeleteShop;
    }
}