
namespace Salary.Forms.Roles
{
    partial class EditRoleForm
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
            this.roleNameLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxRoleName = new System.Windows.Forms.TextBox();
            this.numericUpDownSalary = new System.Windows.Forms.NumericUpDown();
            this.AddRoleBtn = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSalary)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Controls.Add(this.roleNameLabel, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.textBoxRoleName, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.numericUpDownSalary, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.AddRoleBtn, 1, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 7;
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
            // roleNameLabel
            // 
            this.roleNameLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.roleNameLabel.AutoSize = true;
            this.roleNameLabel.Font = new System.Drawing.Font("Georgia", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.roleNameLabel.ForeColor = System.Drawing.Color.DarkGray;
            this.roleNameLabel.Location = new System.Drawing.Point(3, 0);
            this.roleNameLabel.Name = "roleNameLabel";
            this.roleNameLabel.Padding = new System.Windows.Forms.Padding(10);
            this.roleNameLabel.Size = new System.Drawing.Size(141, 45);
            this.roleNameLabel.TabIndex = 0;
            this.roleNameLabel.Text = "Должность";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Georgia", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.DarkGray;
            this.label1.Location = new System.Drawing.Point(49, 48);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(10);
            this.label1.Size = new System.Drawing.Size(95, 45);
            this.label1.TabIndex = 1;
            this.label1.Text = "Оклад";
            // 
            // textBoxRoleName
            // 
            this.textBoxRoleName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxRoleName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(231)))), ((int)(((byte)(233)))));
            this.textBoxRoleName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxRoleName.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxRoleName.Location = new System.Drawing.Point(150, 3);
            this.textBoxRoleName.Multiline = true;
            this.textBoxRoleName.Name = "textBoxRoleName";
            this.textBoxRoleName.Size = new System.Drawing.Size(647, 42);
            this.textBoxRoleName.TabIndex = 2;
            // 
            // numericUpDownSalary
            // 
            this.numericUpDownSalary.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.numericUpDownSalary.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(231)))), ((int)(((byte)(233)))));
            this.numericUpDownSalary.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.numericUpDownSalary.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numericUpDownSalary.Location = new System.Drawing.Point(150, 59);
            this.numericUpDownSalary.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.numericUpDownSalary.Name = "numericUpDownSalary";
            this.numericUpDownSalary.Size = new System.Drawing.Size(647, 22);
            this.numericUpDownSalary.TabIndex = 3;
            // 
            // AddRoleBtn
            // 
            this.AddRoleBtn.BackColor = System.Drawing.Color.MediumPurple;
            this.AddRoleBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AddRoleBtn.FlatAppearance.BorderSize = 0;
            this.AddRoleBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddRoleBtn.ForeColor = System.Drawing.Color.White;
            this.AddRoleBtn.Location = new System.Drawing.Point(150, 96);
            this.AddRoleBtn.Name = "AddRoleBtn";
            this.AddRoleBtn.Size = new System.Drawing.Size(181, 35);
            this.AddRoleBtn.TabIndex = 7;
            this.AddRoleBtn.Text = "ОБНОВИТЬ";
            this.AddRoleBtn.UseVisualStyleBackColor = false;
            this.AddRoleBtn.Click += new System.EventHandler(this.AddRoleBtn_Click);
            // 
            // EditRoleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "EditRoleForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Редактировать должность";
            this.Load += new System.EventHandler(this.EditRoleForm_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSalary)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label roleNameLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxRoleName;
        private System.Windows.Forms.NumericUpDown numericUpDownSalary;
        private System.Windows.Forms.Button AddRoleBtn;
    }
}