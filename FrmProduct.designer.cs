
namespace Crud.With.Inyector
{
    partial class FrmProduct
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmProduct));
            this.PTitle = new System.Windows.Forms.Panel();
            this.BtnBack = new System.Windows.Forms.PictureBox();
            this.LbTitle = new System.Windows.Forms.Label();
            this.BtnClose = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtProductName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.CbCategories = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.CbSupplier = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.TxtPerunit = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.TxtPrice = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.TxtStock = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtOrder = new System.Windows.Forms.TextBox();
            this.TxtLevel = new System.Windows.Forms.TextBox();
            this.ChbDisc = new System.Windows.Forms.CheckBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.errorProviderProduct = new System.Windows.Forms.ErrorProvider(this.components);
            this.PTitle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BtnBack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderProduct)).BeginInit();
            this.SuspendLayout();
            // 
            // PTitle
            // 
            this.PTitle.BackColor = System.Drawing.Color.Indigo;
            this.PTitle.Controls.Add(this.BtnBack);
            this.PTitle.Controls.Add(this.LbTitle);
            this.PTitle.Controls.Add(this.BtnClose);
            this.PTitle.Location = new System.Drawing.Point(0, -1);
            this.PTitle.Margin = new System.Windows.Forms.Padding(4);
            this.PTitle.Name = "PTitle";
            this.PTitle.Size = new System.Drawing.Size(771, 55);
            this.PTitle.TabIndex = 1;
            // 
            // BtnBack
            // 
            this.BtnBack.BackColor = System.Drawing.Color.Indigo;
            this.BtnBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnBack.Image = ((System.Drawing.Image)(resources.GetObject("BtnBack.Image")));
            this.BtnBack.Location = new System.Drawing.Point(13, 18);
            this.BtnBack.Margin = new System.Windows.Forms.Padding(4);
            this.BtnBack.Name = "BtnBack";
            this.BtnBack.Size = new System.Drawing.Size(26, 26);
            this.BtnBack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.BtnBack.TabIndex = 2;
            this.BtnBack.TabStop = false;
            this.BtnBack.Click += new System.EventHandler(this.BtnBack_Click);
            // 
            // LbTitle
            // 
            this.LbTitle.AutoSize = true;
            this.LbTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbTitle.ForeColor = System.Drawing.Color.White;
            this.LbTitle.Location = new System.Drawing.Point(47, 18);
            this.LbTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LbTitle.Name = "LbTitle";
            this.LbTitle.Size = new System.Drawing.Size(75, 32);
            this.LbTitle.TabIndex = 1;
            this.LbTitle.Text = "Title";
            // 
            // BtnClose
            // 
            this.BtnClose.BackColor = System.Drawing.Color.Indigo;
            this.BtnClose.FlatAppearance.BorderSize = 0;
            this.BtnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnClose.ForeColor = System.Drawing.Color.White;
            this.BtnClose.Location = new System.Drawing.Point(1468, 2);
            this.BtnClose.Margin = new System.Windows.Forms.Padding(4);
            this.BtnClose.Name = "BtnClose";
            this.BtnClose.Size = new System.Drawing.Size(86, 58);
            this.BtnClose.TabIndex = 1;
            this.BtnClose.Text = "X";
            this.BtnClose.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(8, 67);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(133, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Product name";
            // 
            // TxtProductName
            // 
            this.TxtProductName.Location = new System.Drawing.Point(15, 95);
            this.TxtProductName.Multiline = true;
            this.TxtProductName.Name = "TxtProductName";
            this.TxtProductName.Size = new System.Drawing.Size(211, 28);
            this.TxtProductName.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(515, 67);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Categories";
            // 
            // CbCategories
            // 
            this.CbCategories.FormattingEnabled = true;
            this.CbCategories.Location = new System.Drawing.Point(520, 95);
            this.CbCategories.Name = "CbCategories";
            this.CbCategories.Size = new System.Drawing.Size(198, 28);
            this.CbCategories.TabIndex = 3;
            this.CbCategories.Text = "Select a categories";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(273, 67);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 25);
            this.label4.TabIndex = 2;
            this.label4.Text = "Suppliers";
            // 
            // CbSupplier
            // 
            this.CbSupplier.FormattingEnabled = true;
            this.CbSupplier.Location = new System.Drawing.Point(278, 95);
            this.CbSupplier.Name = "CbSupplier";
            this.CbSupplier.Size = new System.Drawing.Size(183, 28);
            this.CbSupplier.TabIndex = 2;
            this.CbSupplier.Text = "Select a suppliers";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(10, 153);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(144, 25);
            this.label5.TabIndex = 2;
            this.label5.Text = "Quanity perunit";
            // 
            // TxtPerunit
            // 
            this.TxtPerunit.Location = new System.Drawing.Point(15, 181);
            this.TxtPerunit.Multiline = true;
            this.TxtPerunit.Name = "TxtPerunit";
            this.TxtPerunit.Size = new System.Drawing.Size(211, 31);
            this.TxtPerunit.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(274, 159);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(93, 25);
            this.label6.TabIndex = 2;
            this.label6.Text = "Unit price";
            // 
            // TxtPrice
            // 
            this.TxtPrice.Location = new System.Drawing.Point(278, 181);
            this.TxtPrice.Multiline = true;
            this.TxtPrice.Name = "TxtPrice";
            this.TxtPrice.Size = new System.Drawing.Size(183, 31);
            this.TxtPrice.TabIndex = 5;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(526, 153);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(107, 25);
            this.label7.TabIndex = 2;
            this.label7.Text = "Units stock";
            // 
            // TxtStock
            // 
            this.TxtStock.Location = new System.Drawing.Point(531, 181);
            this.TxtStock.Multiline = true;
            this.TxtStock.Name = "TxtStock";
            this.TxtStock.Size = new System.Drawing.Size(187, 31);
            this.TxtStock.TabIndex = 6;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(16, 239);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(106, 25);
            this.label8.TabIndex = 2;
            this.label8.Text = "Units order";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(274, 239);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(143, 25);
            this.label9.TabIndex = 2;
            this.label9.Text = "Recorder Level";
            // 
            // txtOrder
            // 
            this.txtOrder.Location = new System.Drawing.Point(15, 267);
            this.txtOrder.Multiline = true;
            this.txtOrder.Name = "txtOrder";
            this.txtOrder.Size = new System.Drawing.Size(211, 34);
            this.txtOrder.TabIndex = 7;
            // 
            // TxtLevel
            // 
            this.TxtLevel.Location = new System.Drawing.Point(279, 267);
            this.TxtLevel.Multiline = true;
            this.TxtLevel.Name = "TxtLevel";
            this.TxtLevel.Size = new System.Drawing.Size(192, 34);
            this.TxtLevel.TabIndex = 8;
            // 
            // ChbDisc
            // 
            this.ChbDisc.AutoSize = true;
            this.ChbDisc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChbDisc.Location = new System.Drawing.Point(531, 256);
            this.ChbDisc.Name = "ChbDisc";
            this.ChbDisc.Size = new System.Drawing.Size(147, 29);
            this.ChbDisc.TabIndex = 9;
            this.ChbDisc.Text = "Discontinued";
            this.ChbDisc.UseVisualStyleBackColor = true;
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnGuardar.FlatAppearance.BorderSize = 0;
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.Location = new System.Drawing.Point(656, 319);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(101, 51);
            this.btnGuardar.TabIndex = 10;
            this.btnGuardar.Text = "Save";
            this.btnGuardar.UseVisualStyleBackColor = false;
            // 
            // errorProviderProduct
            // 
            this.errorProviderProduct.ContainerControl = this;
            // 
            // FrmProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(769, 382);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.ChbDisc);
            this.Controls.Add(this.CbSupplier);
            this.Controls.Add(this.CbCategories);
            this.Controls.Add(this.TxtStock);
            this.Controls.Add(this.TxtLevel);
            this.Controls.Add(this.TxtPrice);
            this.Controls.Add(this.txtOrder);
            this.Controls.Add(this.TxtPerunit);
            this.Controls.Add(this.TxtProductName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.PTitle);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmProduct";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmProduct";
            this.PTitle.ResumeLayout(false);
            this.PTitle.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BtnBack)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderProduct)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel PTitle;
        private System.Windows.Forms.Label LbTitle;
        private System.Windows.Forms.Button BtnClose;
        private System.Windows.Forms.PictureBox BtnBack;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.ErrorProvider errorProviderProduct;
        public System.Windows.Forms.TextBox TxtProductName;
        public System.Windows.Forms.ComboBox CbCategories;
        public System.Windows.Forms.ComboBox CbSupplier;
        public System.Windows.Forms.TextBox TxtPerunit;
        public System.Windows.Forms.TextBox TxtPrice;
        public System.Windows.Forms.TextBox TxtStock;
        public System.Windows.Forms.TextBox txtOrder;
        public System.Windows.Forms.TextBox TxtLevel;
        public System.Windows.Forms.CheckBox ChbDisc;
    }
}