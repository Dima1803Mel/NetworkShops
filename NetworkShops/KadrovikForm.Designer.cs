using System.Windows.Forms;

namespace NetworkShops
{
    partial class KadrovikForm
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
            this.Familia = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.AddEmployee = new System.Windows.Forms.Button();
            this.DeleteEmployee = new System.Windows.Forms.Button();
            this.Name = new System.Windows.Forms.TextBox();
            this.Otchestvo = new System.Windows.Forms.TextBox();
            this.DateOfBirth = new System.Windows.Forms.TextBox();
            this.Number = new System.Windows.Forms.TextBox();
            this.idShop = new System.Windows.Forms.TextBox();
            this.LoginField = new System.Windows.Forms.TextBox();
            this.PassField = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.Role = new System.Windows.Forms.ComboBox();
            this.Salary = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.idEmployee = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(541, 626);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Familia
            // 
            this.Familia.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Familia.Location = new System.Drawing.Point(736, 13);
            this.Familia.Multiline = true;
            this.Familia.Name = "Familia";
            this.Familia.Size = new System.Drawing.Size(267, 26);
            this.Familia.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(586, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "Фамилия";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(605, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 24);
            this.label2.TabIndex = 4;
            this.label2.Text = "Имя";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(589, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 24);
            this.label3.TabIndex = 6;
            this.label3.Text = "Отчество";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label4.Location = new System.Drawing.Point(567, 157);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(151, 24);
            this.label4.TabIndex = 8;
            this.label4.Text = "Дата рождения";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label5.Location = new System.Drawing.Point(559, 210);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(167, 24);
            this.label5.TabIndex = 10;
            this.label5.Text = "Номер телефона";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label6.Location = new System.Drawing.Point(576, 260);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(126, 24);
            this.label6.TabIndex = 12;
            this.label6.Text = "ID магазина";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label7.Location = new System.Drawing.Point(603, 317);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(70, 24);
            this.label7.TabIndex = 14;
            this.label7.Text = "Логин";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label8.Location = new System.Drawing.Point(597, 375);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(82, 24);
            this.label8.TabIndex = 16;
            this.label8.Text = "Пароль";
            // 
            // AddEmployee
            // 
            this.AddEmployee.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddEmployee.Location = new System.Drawing.Point(861, 542);
            this.AddEmployee.Name = "AddEmployee";
            this.AddEmployee.Size = new System.Drawing.Size(142, 41);
            this.AddEmployee.TabIndex = 17;
            this.AddEmployee.Text = "Добавить";
            this.AddEmployee.UseVisualStyleBackColor = true;
            this.AddEmployee.Click += new System.EventHandler(this.AddEmployee_Click);
            // 
            // DeleteEmployee
            // 
            this.DeleteEmployee.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DeleteEmployee.Location = new System.Drawing.Point(861, 597);
            this.DeleteEmployee.Name = "DeleteEmployee";
            this.DeleteEmployee.Size = new System.Drawing.Size(142, 41);
            this.DeleteEmployee.TabIndex = 18;
            this.DeleteEmployee.Text = "Удалить";
            this.DeleteEmployee.UseVisualStyleBackColor = true;
            this.DeleteEmployee.Click += new System.EventHandler(this.DeleteEmployee_Click);
            // 
            // Name
            // 
            this.Name.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Name.Location = new System.Drawing.Point(736, 59);
            this.Name.Multiline = true;
            this.Name.Name = "Name";
            this.Name.Size = new System.Drawing.Size(267, 26);
            this.Name.TabIndex = 19;
            // 
            // Otchestvo
            // 
            this.Otchestvo.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Otchestvo.Location = new System.Drawing.Point(736, 107);
            this.Otchestvo.Multiline = true;
            this.Otchestvo.Name = "Otchestvo";
            this.Otchestvo.Size = new System.Drawing.Size(267, 26);
            this.Otchestvo.TabIndex = 20;
            // 
            // DateOfBirth
            // 
            this.DateOfBirth.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DateOfBirth.Location = new System.Drawing.Point(736, 156);
            this.DateOfBirth.Multiline = true;
            this.DateOfBirth.Name = "DateOfBirth";
            this.DateOfBirth.Size = new System.Drawing.Size(267, 26);
            this.DateOfBirth.TabIndex = 21;
            this.DateOfBirth.TextChanged += new System.EventHandler(this.DateOfBirth_TextChanged_1);
            // 
            // Number
            // 
            this.Number.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Number.Location = new System.Drawing.Point(736, 210);
            this.Number.Multiline = true;
            this.Number.Name = "Number";
            this.Number.Size = new System.Drawing.Size(267, 26);
            this.Number.TabIndex = 22;
            this.Number.TextChanged += new System.EventHandler(this.Number_TextChanged_1);
            // 
            // idShop
            // 
            this.idShop.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.idShop.Location = new System.Drawing.Point(736, 260);
            this.idShop.Multiline = true;
            this.idShop.Name = "idShop";
            this.idShop.Size = new System.Drawing.Size(267, 26);
            this.idShop.TabIndex = 23;
            // 
            // LoginField
            // 
            this.LoginField.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LoginField.Location = new System.Drawing.Point(736, 317);
            this.LoginField.Multiline = true;
            this.LoginField.Name = "LoginField";
            this.LoginField.Size = new System.Drawing.Size(267, 26);
            this.LoginField.TabIndex = 24;
            // 
            // PassField
            // 
            this.PassField.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PassField.Location = new System.Drawing.Point(736, 373);
            this.PassField.Multiline = true;
            this.PassField.Name = "PassField";
            this.PassField.Size = new System.Drawing.Size(267, 26);
            this.PassField.TabIndex = 25;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.ForeColor = System.Drawing.SystemColors.Control;
            this.label9.Location = new System.Drawing.Point(600, 487);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(73, 31);
            this.label9.TabIndex = 26;
            this.label9.Text = "Роль";
            // 
            // Role
            // 
            this.Role.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Role.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Role.FormattingEnabled = true;
            this.Role.Location = new System.Drawing.Point(736, 487);
            this.Role.Name = "Role";
            this.Role.Size = new System.Drawing.Size(267, 30);
            this.Role.TabIndex = 27;
            this.Role.SelectedIndexChanged += new System.EventHandler(this.Role_SelectedIndexChanged);
            // 
            // Salary
            // 
            this.Salary.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Salary.Location = new System.Drawing.Point(736, 429);
            this.Salary.Multiline = true;
            this.Salary.Name = "Salary";
            this.Salary.Size = new System.Drawing.Size(267, 26);
            this.Salary.TabIndex = 29;
            this.Salary.TextChanged += new System.EventHandler(this.Salary_TextChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label10.Location = new System.Drawing.Point(590, 431);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(97, 24);
            this.label10.TabIndex = 28;
            this.label10.Text = "Зарплата";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label11.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label11.Location = new System.Drawing.Point(692, 607);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(31, 22);
            this.label11.TabIndex = 30;
            this.label11.Text = "ID";
            // 
            // idEmployee
            // 
            this.idEmployee.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.idEmployee.Location = new System.Drawing.Point(742, 605);
            this.idEmployee.Name = "idEmployee";
            this.idEmployee.Size = new System.Drawing.Size(96, 29);
            this.idEmployee.TabIndex = 31;
            // 
            // KadrovikForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(1076, 673);
            this.Controls.Add(this.idEmployee);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.Salary);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.Role);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.PassField);
            this.Controls.Add(this.LoginField);
            this.Controls.Add(this.idShop);
            this.Controls.Add(this.Number);
            this.Controls.Add(this.DateOfBirth);
            this.Controls.Add(this.Otchestvo);
            this.Controls.Add(this.Name);
            this.Controls.Add(this.DeleteEmployee);
            this.Controls.Add(this.AddEmployee);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Familia);
            this.Controls.Add(this.dataGridView1);
            this.Text = "KadrovikForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox Familia;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button AddEmployee;
        private System.Windows.Forms.Button DeleteEmployee;
        private TextBox Name;
        private TextBox Otchestvo;
        private TextBox DateOfBirth;
        private TextBox Number;
        private TextBox idShop;
        private TextBox LoginField;
        private TextBox PassField;
        private Label label9;
        private ComboBox Role;
        private TextBox Salary;
        private Label label10;
        private Label label11;
        private TextBox idEmployee;
    }
}