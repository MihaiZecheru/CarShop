// this file was generated automatically by the windows forms drag and drop stuff, i did not code this one

namespace CarShopGUI
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_createCar = new System.Windows.Forms.Button();
            this.txt_price = new System.Windows.Forms.TextBox();
            this.txt_model = new System.Windows.Forms.TextBox();
            this.txt_make = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lst_inv = new System.Windows.Forms.ListBox();
            this.btn_addToCart = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lst_cart = new System.Windows.Forms.ListBox();
            this.btn_checkout = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.lbl_total = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_createCar);
            this.groupBox1.Controls.Add(this.txt_price);
            this.groupBox1.Controls.Add(this.txt_model);
            this.groupBox1.Controls.Add(this.txt_make);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 138);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 144);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Create A Car";
            // 
            // btn_createCar
            // 
            this.btn_createCar.Location = new System.Drawing.Point(6, 114);
            this.btn_createCar.Name = "btn_createCar";
            this.btn_createCar.Size = new System.Drawing.Size(176, 23);
            this.btn_createCar.TabIndex = 1;
            this.btn_createCar.Text = "Create";
            this.btn_createCar.UseVisualStyleBackColor = true;
            this.btn_createCar.Click += new System.EventHandler(this.btn_createCar_Click);
            // 
            // txt_price
            // 
            this.txt_price.Location = new System.Drawing.Point(59, 85);
            this.txt_price.Name = "txt_price";
            this.txt_price.Size = new System.Drawing.Size(100, 23);
            this.txt_price.TabIndex = 5;
            // 
            // txt_model
            // 
            this.txt_model.Location = new System.Drawing.Point(59, 56);
            this.txt_model.Name = "txt_model";
            this.txt_model.Size = new System.Drawing.Size(100, 23);
            this.txt_model.TabIndex = 4;
            // 
            // txt_make
            // 
            this.txt_make.Location = new System.Drawing.Point(60, 24);
            this.txt_make.Name = "txt_make";
            this.txt_make.Size = new System.Drawing.Size(100, 23);
            this.txt_make.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Price:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Model: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Make:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lst_inv);
            this.groupBox2.Location = new System.Drawing.Point(218, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(263, 397);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Inventory";
            // 
            // lst_inv
            // 
            this.lst_inv.FormattingEnabled = true;
            this.lst_inv.ItemHeight = 15;
            this.lst_inv.Location = new System.Drawing.Point(6, 24);
            this.lst_inv.Name = "lst_inv";
            this.lst_inv.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.lst_inv.Size = new System.Drawing.Size(251, 364);
            this.lst_inv.TabIndex = 2;
            // 
            // btn_addToCart
            // 
            this.btn_addToCart.Location = new System.Drawing.Point(487, 194);
            this.btn_addToCart.Name = "btn_addToCart";
            this.btn_addToCart.Size = new System.Drawing.Size(93, 23);
            this.btn_addToCart.TabIndex = 4;
            this.btn_addToCart.Text = "Add To Cart ->";
            this.btn_addToCart.UseVisualStyleBackColor = true;
            this.btn_addToCart.Click += new System.EventHandler(this.btn_addToCart_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lst_cart);
            this.groupBox3.Location = new System.Drawing.Point(586, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(263, 397);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Shopping Cart";
            // 
            // lst_cart
            // 
            this.lst_cart.FormattingEnabled = true;
            this.lst_cart.ItemHeight = 15;
            this.lst_cart.Location = new System.Drawing.Point(6, 24);
            this.lst_cart.Name = "lst_cart";
            this.lst_cart.Size = new System.Drawing.Size(251, 364);
            this.lst_cart.TabIndex = 2;
            // 
            // btn_checkout
            // 
            this.btn_checkout.Location = new System.Drawing.Point(855, 189);
            this.btn_checkout.Name = "btn_checkout";
            this.btn_checkout.Size = new System.Drawing.Size(87, 23);
            this.btn_checkout.TabIndex = 5;
            this.btn_checkout.Text = "Checkout ->";
            this.btn_checkout.UseVisualStyleBackColor = true;
            this.btn_checkout.Click += new System.EventHandler(this.btn_checkout_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.lbl_total);
            this.groupBox4.Location = new System.Drawing.Point(948, 145);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(200, 137);
            this.groupBox4.TabIndex = 6;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Total Cost";
            // 
            // lbl_total
            // 
            this.lbl_total.AutoSize = true;
            this.lbl_total.Location = new System.Drawing.Point(78, 59);
            this.lbl_total.Name = "lbl_total";
            this.lbl_total.Size = new System.Drawing.Size(34, 15);
            this.lbl_total.TabIndex = 0;
            this.lbl_total.Text = "$0.00";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1159, 450);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.btn_checkout);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.btn_addToCart);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Car Shop GUI";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox groupBox1;
        private Label label1;
        private Label label3;
        private Label label2;
        private TextBox txt_price;
        private TextBox txt_model;
        private TextBox txt_make;
        private Button btn_createCar;
        private GroupBox groupBox2;
        private ListBox lst_inv;
        private Button btn_addToCart;
        private GroupBox groupBox3;
        private ListBox lst_cart;
        private Button btn_checkout;
        private GroupBox groupBox4;
        private Label lbl_total;
    }
}