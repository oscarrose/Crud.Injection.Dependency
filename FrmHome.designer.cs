
namespace Crud.With.Inyector
{
    partial class FrmHome
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.PTitle = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnClose = new System.Windows.Forms.Button();
            this.DataGridProduct = new System.Windows.Forms.DataGridView();
            this.btnNew = new System.Windows.Forms.Button();
            this.EditProduct = new System.Windows.Forms.Button();
            this.BtnDeleteProduct = new System.Windows.Forms.Button();
            this.PTitle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridProduct)).BeginInit();
            this.SuspendLayout();
            // 
            // PTitle
            // 
            this.PTitle.BackColor = System.Drawing.Color.Indigo;
            this.PTitle.Controls.Add(this.label1);
            this.PTitle.Controls.Add(this.BtnClose);
            this.PTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.PTitle.Location = new System.Drawing.Point(0, 0);
            this.PTitle.Name = "PTitle";
            this.PTitle.Size = new System.Drawing.Size(1329, 48);
            this.PTitle.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(7, 2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(178, 44);
            this.label1.TabIndex = 1;
            this.label1.Text = "Products";
            // 
            // BtnClose
            // 
            this.BtnClose.BackColor = System.Drawing.Color.Indigo;
            this.BtnClose.FlatAppearance.BorderSize = 0;
            this.BtnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnClose.ForeColor = System.Drawing.Color.White;
            this.BtnClose.Location = new System.Drawing.Point(1260, -1);
            this.BtnClose.Name = "BtnClose";
            this.BtnClose.Size = new System.Drawing.Size(69, 46);
            this.BtnClose.TabIndex = 1;
            this.BtnClose.Text = "X";
            this.BtnClose.UseVisualStyleBackColor = false;
         
            // 
            // DataGridProduct
            // 
            this.DataGridProduct.BackgroundColor = System.Drawing.Color.White;
            this.DataGridProduct.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGridProduct.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.DataGridProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DataGridProduct.DefaultCellStyle = dataGridViewCellStyle6;
            this.DataGridProduct.GridColor = System.Drawing.Color.Black;
            this.DataGridProduct.Location = new System.Drawing.Point(0, 140);
            this.DataGridProduct.MultiSelect = false;
            this.DataGridProduct.Name = "DataGridProduct";
            this.DataGridProduct.ReadOnly = true;
            this.DataGridProduct.RowHeadersWidth = 51;
            this.DataGridProduct.RowTemplate.Height = 24;
            this.DataGridProduct.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DataGridProduct.Size = new System.Drawing.Size(1329, 610);
            this.DataGridProduct.TabIndex = 1;
            // 
            // btnNew
            // 
            this.btnNew.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnNew.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNew.FlatAppearance.BorderSize = 0;
            this.btnNew.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNew.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNew.ForeColor = System.Drawing.Color.Black;
            this.btnNew.Location = new System.Drawing.Point(979, 89);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(93, 45);
            this.btnNew.TabIndex = 2;
            this.btnNew.Text = "New";
            this.btnNew.UseVisualStyleBackColor = false;
            // 
            // EditProduct
            // 
            this.EditProduct.BackColor = System.Drawing.Color.Gold;
            this.EditProduct.Cursor = System.Windows.Forms.Cursors.Hand;
            this.EditProduct.FlatAppearance.BorderSize = 0;
            this.EditProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EditProduct.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EditProduct.ForeColor = System.Drawing.Color.Black;
            this.EditProduct.Location = new System.Drawing.Point(1098, 89);
            this.EditProduct.Name = "EditProduct";
            this.EditProduct.Size = new System.Drawing.Size(93, 45);
            this.EditProduct.TabIndex = 2;
            this.EditProduct.Text = "Edit";
            this.EditProduct.UseVisualStyleBackColor = false;
            // 
            // BtnDeleteProduct
            // 
            this.BtnDeleteProduct.BackColor = System.Drawing.Color.Red;
            this.BtnDeleteProduct.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnDeleteProduct.FlatAppearance.BorderSize = 0;
            this.BtnDeleteProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnDeleteProduct.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnDeleteProduct.ForeColor = System.Drawing.Color.Black;
            this.BtnDeleteProduct.Location = new System.Drawing.Point(1218, 89);
            this.BtnDeleteProduct.Name = "BtnDeleteProduct";
            this.BtnDeleteProduct.Size = new System.Drawing.Size(93, 45);
            this.BtnDeleteProduct.TabIndex = 2;
            this.BtnDeleteProduct.Text = "Delete";
            this.BtnDeleteProduct.UseVisualStyleBackColor = false;
            // 
            // FrmHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1329, 752);
            this.Controls.Add(this.BtnDeleteProduct);
            this.Controls.Add(this.EditProduct);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.DataGridProduct);
            this.Controls.Add(this.PTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmHome";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.PTitle.ResumeLayout(false);
            this.PTitle.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridProduct)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PTitle;
        private System.Windows.Forms.Button BtnClose;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView DataGridProduct;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Button EditProduct;
        private System.Windows.Forms.Button BtnDeleteProduct;
    }
}

