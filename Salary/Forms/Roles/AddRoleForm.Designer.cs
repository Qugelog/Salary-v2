
namespace Salary.Forms.Roles
{
    partial class AddRoleForm
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.labelRoleName = new System.Windows.Forms.Label();
            this.labelRoleSalary = new System.Windows.Forms.Label();
            this.textBoxRoleName = new System.Windows.Forms.TextBox();
            this.numericUpDownSalary = new System.Windows.Forms.NumericUpDown();
            this.button2 = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSalary)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Controls.Add(this.labelRoleName, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.labelRoleSalary, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.textBoxRoleName, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.numericUpDownSalary, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.button2, 1, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 8;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(800, 450);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // labelRoleName
            // 
            this.labelRoleName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelRoleName.AutoSize = true;
            this.labelRoleName.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelRoleName.ForeColor = System.Drawing.Color.DarkGray;
            this.labelRoleName.Location = new System.Drawing.Point(3, 0);
            this.labelRoleName.Name = "labelRoleName";
            this.labelRoleName.Padding = new System.Windows.Forms.Padding(15);
            this.labelRoleName.Size = new System.Drawing.Size(231, 53);
            this.labelRoleName.TabIndex = 0;
            this.labelRoleName.Text = "Название должности";
            // 
            // labelRoleSalary
            // 
            this.labelRoleSalary.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelRoleSalary.AutoSize = true;
            this.labelRoleSalary.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelRoleSalary.ForeColor = System.Drawing.Color.DarkGray;
            this.labelRoleSalary.Location = new System.Drawing.Point(138, 53);
            this.labelRoleSalary.Name = "labelRoleSalary";
            this.labelRoleSalary.Padding = new System.Windows.Forms.Padding(15);
            this.labelRoleSalary.Size = new System.Drawing.Size(96, 53);
            this.labelRoleSalary.TabIndex = 1;
            this.labelRoleSalary.Text = "Оклад";
            // 
            // textBoxRoleName
            // 
            this.textBoxRoleName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxRoleName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(231)))), ((int)(((byte)(233)))));
            this.textBoxRoleName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxRoleName.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxRoleName.Location = new System.Drawing.Point(240, 8);
            this.textBoxRoleName.Multiline = true;
            this.textBoxRoleName.Name = "textBoxRoleName";
            this.textBoxRoleName.Size = new System.Drawing.Size(557, 37);
            this.textBoxRoleName.TabIndex = 2;
            // 
            // numericUpDownSalary
            // 
            this.numericUpDownSalary.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.numericUpDownSalary.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(231)))), ((int)(((byte)(233)))));
            this.numericUpDownSalary.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.numericUpDownSalary.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numericUpDownSalary.Location = new System.Drawing.Point(240, 67);
            this.numericUpDownSalary.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.numericUpDownSalary.Name = "numericUpDownSalary";
            this.numericUpDownSalary.Size = new System.Drawing.Size(557, 25);
            this.numericUpDownSalary.TabIndex = 3;
            this.numericUpDownSalary.ThousandsSeparator = true;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.MediumPurple;
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(240, 109);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(181, 35);
            this.button2.TabIndex = 9;
            this.button2.Text = "ДОБАВИТЬ";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // AddRoleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "AddRoleForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Добавить должность";
            this.Activated += new System.EventHandler(this.AddRoleForm_Activated);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSalary)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label labelRoleName;
        private System.Windows.Forms.Label labelRoleSalary;
        private System.Windows.Forms.TextBox textBoxRoleName;
        private System.Windows.Forms.NumericUpDown numericUpDownSalary;
        private System.Windows.Forms.Button button2;
    }
}