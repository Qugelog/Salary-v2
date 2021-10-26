
namespace Salary.Forms
{
    partial class RolesForm
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RolesForm));
            this.RolesPanel = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.rolesDataGrid = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.salary = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Update = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Delete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.RefreshDataBtn = new System.Windows.Forms.Button();
            this.AddRoleBtn = new System.Windows.Forms.Button();
            this.bindingSourceRoles = new System.Windows.Forms.BindingSource(this.components);
            this.printBtn = new System.Windows.Forms.Button();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.RolesPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rolesDataGrid)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceRoles)).BeginInit();
            this.SuspendLayout();
            // 
            // RolesPanel
            // 
            this.RolesPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.RolesPanel.Controls.Add(this.panel1);
            this.RolesPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RolesPanel.Location = new System.Drawing.Point(0, 0);
            this.RolesPanel.Name = "RolesPanel";
            this.RolesPanel.Size = new System.Drawing.Size(800, 450);
            this.RolesPanel.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.rolesDataGrid);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.panel1.ForeColor = System.Drawing.Color.DarkGray;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 450);
            this.panel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Georgia", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.DarkGray;
            this.label1.Location = new System.Drawing.Point(246, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(295, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Должности компании";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // rolesDataGrid
            // 
            this.rolesDataGrid.AllowUserToAddRows = false;
            this.rolesDataGrid.AllowUserToDeleteRows = false;
            this.rolesDataGrid.AllowUserToResizeColumns = false;
            this.rolesDataGrid.AllowUserToResizeRows = false;
            this.rolesDataGrid.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rolesDataGrid.AutoGenerateColumns = false;
            this.rolesDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.rolesDataGrid.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.rolesDataGrid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.rolesDataGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rolesDataGrid.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.rolesDataGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.DarkViolet;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.DarkViolet;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.rolesDataGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.rolesDataGrid.ColumnHeadersHeight = 30;
            this.rolesDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.rolesDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.name,
            this.salary,
            this.Update,
            this.Delete});
            this.rolesDataGrid.DataSource = this.bindingSourceRoles;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.DarkGray;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.Indigo;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.rolesDataGrid.DefaultCellStyle = dataGridViewCellStyle12;
            this.rolesDataGrid.EnableHeadersVisualStyles = false;
            this.rolesDataGrid.GridColor = System.Drawing.Color.MediumPurple;
            this.rolesDataGrid.Location = new System.Drawing.Point(12, 51);
            this.rolesDataGrid.MultiSelect = false;
            this.rolesDataGrid.Name = "rolesDataGrid";
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle13.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle13.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.Color.MediumPurple;
            dataGridViewCellStyle13.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.rolesDataGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle13;
            this.rolesDataGrid.RowHeadersVisible = false;
            this.rolesDataGrid.RowHeadersWidth = 51;
            dataGridViewCellStyle14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle14.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.Color.MediumPurple;
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.Color.White;
            this.rolesDataGrid.RowsDefaultCellStyle = dataGridViewCellStyle14;
            this.rolesDataGrid.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.rolesDataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.rolesDataGrid.Size = new System.Drawing.Size(785, 280);
            this.rolesDataGrid.TabIndex = 1;
            this.rolesDataGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.rolesDataGrid_CellContentClick);
            // 
            // id
            // 
            this.id.DataPropertyName = "id";
            this.id.HeaderText = "id";
            this.id.MinimumWidth = 6;
            this.id.Name = "id";
            this.id.Visible = false;
            // 
            // name
            // 
            this.name.DataPropertyName = "name";
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.MediumPurple;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.MediumPurple;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.White;
            this.name.DefaultCellStyle = dataGridViewCellStyle9;
            this.name.HeaderText = "Должность";
            this.name.MinimumWidth = 6;
            this.name.Name = "name";
            this.name.ReadOnly = true;
            // 
            // salary
            // 
            this.salary.DataPropertyName = "salary";
            this.salary.HeaderText = "Оклад";
            this.salary.MinimumWidth = 6;
            this.salary.Name = "salary";
            this.salary.ReadOnly = true;
            // 
            // Update
            // 
            this.Update.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.MediumPurple;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.MediumPurple;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.White;
            this.Update.DefaultCellStyle = dataGridViewCellStyle10;
            this.Update.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Update.HeaderText = "";
            this.Update.MinimumWidth = 6;
            this.Update.Name = "Update";
            this.Update.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Update.Text = "Изменить";
            this.Update.UseColumnTextForButtonValue = true;
            this.Update.Width = 6;
            // 
            // Delete
            // 
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.Crimson;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.Crimson;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.Color.White;
            this.Delete.DefaultCellStyle = dataGridViewCellStyle11;
            this.Delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Delete.HeaderText = "";
            this.Delete.MinimumWidth = 6;
            this.Delete.Name = "Delete";
            this.Delete.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Delete.Text = "Удалить";
            this.Delete.UseColumnTextForButtonValue = true;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            this.panel2.Controls.Add(this.printBtn);
            this.panel2.Controls.Add(this.RefreshDataBtn);
            this.panel2.Controls.Add(this.AddRoleBtn);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 350);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(800, 100);
            this.panel2.TabIndex = 7;
            // 
            // RefreshDataBtn
            // 
            this.RefreshDataBtn.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.RefreshDataBtn.BackColor = System.Drawing.Color.MediumPurple;
            this.RefreshDataBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RefreshDataBtn.FlatAppearance.BorderSize = 0;
            this.RefreshDataBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RefreshDataBtn.ForeColor = System.Drawing.Color.White;
            this.RefreshDataBtn.Location = new System.Drawing.Point(535, 34);
            this.RefreshDataBtn.Name = "RefreshDataBtn";
            this.RefreshDataBtn.Size = new System.Drawing.Size(181, 35);
            this.RefreshDataBtn.TabIndex = 7;
            this.RefreshDataBtn.Text = "ОБНОВИТЬ СПИСОК";
            this.RefreshDataBtn.UseVisualStyleBackColor = false;
            this.RefreshDataBtn.Click += new System.EventHandler(this.RefreshDataBtn_Click);
            // 
            // AddRoleBtn
            // 
            this.AddRoleBtn.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.AddRoleBtn.BackColor = System.Drawing.Color.MediumPurple;
            this.AddRoleBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AddRoleBtn.FlatAppearance.BorderSize = 0;
            this.AddRoleBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddRoleBtn.ForeColor = System.Drawing.Color.White;
            this.AddRoleBtn.Location = new System.Drawing.Point(336, 34);
            this.AddRoleBtn.Name = "AddRoleBtn";
            this.AddRoleBtn.Size = new System.Drawing.Size(181, 35);
            this.AddRoleBtn.TabIndex = 6;
            this.AddRoleBtn.Text = "ДОБАВИТЬ ДОЛЖНОСТЬ";
            this.AddRoleBtn.UseVisualStyleBackColor = false;
            this.AddRoleBtn.Click += new System.EventHandler(this.AddRoleBtn_Click);
            // 
            // printBtn
            // 
            this.printBtn.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.printBtn.BackColor = System.Drawing.Color.MediumPurple;
            this.printBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.printBtn.FlatAppearance.BorderSize = 0;
            this.printBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.printBtn.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.printBtn.ForeColor = System.Drawing.Color.White;
            this.printBtn.Location = new System.Drawing.Point(131, 34);
            this.printBtn.Name = "printBtn";
            this.printBtn.Size = new System.Drawing.Size(181, 35);
            this.printBtn.TabIndex = 11;
            this.printBtn.Text = "ПЕЧАТЬ";
            this.printBtn.UseVisualStyleBackColor = false;
            this.printBtn.Click += new System.EventHandler(this.printBtn_Click);
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Document = this.printDocument1;
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // RolesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBox = false;
            this.Controls.Add(this.RolesPanel);
            this.Name = "RolesForm";
            this.ShowIcon = false;
            this.Text = "Управление ролями";
            this.Activated += new System.EventHandler(this.RolesForm_Activated);
            this.Load += new System.EventHandler(this.Roles_Load);
            this.Enter += new System.EventHandler(this.RolesForm_Enter);
            this.RolesPanel.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rolesDataGrid)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceRoles)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel RolesPanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource bindingSourceRoles;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button AddRoleBtn;
        private System.Windows.Forms.Button RefreshDataBtn;
        public System.Windows.Forms.DataGridView rolesDataGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn salary;
        private System.Windows.Forms.DataGridViewButtonColumn Update;
        private System.Windows.Forms.DataGridViewButtonColumn Delete;
        private System.Windows.Forms.Button printBtn;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
    }
}