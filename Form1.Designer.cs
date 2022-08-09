
namespace WindowsFormsApp2
{
    partial class Form1
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
            this.lbl_number = new System.Windows.Forms.Label();
            this.lbl_datePicker = new System.Windows.Forms.Label();
            this.lbl_sku = new System.Windows.Forms.Label();
            this.lbl_count = new System.Windows.Forms.Label();
            this.lbl_price = new System.Windows.Forms.Label();
            this.btn_add = new System.Windows.Forms.Button();
            this.txt_number = new System.Windows.Forms.TextBox();
            this.txt_objName = new System.Windows.Forms.TextBox();
            this.txt_count = new System.Windows.Forms.TextBox();
            this.txt_price = new System.Windows.Forms.TextBox();
            this.txt_inventory = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.lbl_objName = new System.Windows.Forms.Label();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.dt_products = new System.Windows.Forms.DataGridView();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.chk_options = new System.Windows.Forms.CheckedListBox();
            this.gb_payment = new System.Windows.Forms.GroupBox();
            this.rb_payPal = new System.Windows.Forms.RadioButton();
            this.rb_telebir = new System.Windows.Forms.RadioButton();
            this.gb_delivery = new System.Windows.Forms.GroupBox();
            this.rb_3day = new System.Windows.Forms.RadioButton();
            this.rb_24hour = new System.Windows.Forms.RadioButton();
            this.lbl_logedInUser = new System.Windows.Forms.Label();
            this.btn_logout = new System.Windows.Forms.Button();
            this.lbl_search = new System.Windows.Forms.Label();
            this.txt_search = new System.Windows.Forms.TextBox();
            this.btn_search = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rb_byName = new System.Windows.Forms.RadioButton();
            this.rb_invNo = new System.Windows.Forms.RadioButton();
            this.rb_price = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.dt_products)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.gb_payment.SuspendLayout();
            this.gb_delivery.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_number
            // 
            this.lbl_number.AutoSize = true;
            this.lbl_number.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_number.Location = new System.Drawing.Point(122, 100);
            this.lbl_number.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_number.Name = "lbl_number";
            this.lbl_number.Size = new System.Drawing.Size(89, 23);
            this.lbl_number.TabIndex = 0;
            this.lbl_number.Text = "Number";
            // 
            // lbl_datePicker
            // 
            this.lbl_datePicker.AutoSize = true;
            this.lbl_datePicker.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_datePicker.Location = new System.Drawing.Point(442, 100);
            this.lbl_datePicker.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_datePicker.Name = "lbl_datePicker";
            this.lbl_datePicker.Size = new System.Drawing.Size(56, 23);
            this.lbl_datePicker.TabIndex = 1;
            this.lbl_datePicker.Text = "Date";
            // 
            // lbl_sku
            // 
            this.lbl_sku.AutoSize = true;
            this.lbl_sku.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_sku.Location = new System.Drawing.Point(666, 100);
            this.lbl_sku.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_sku.Name = "lbl_sku";
            this.lbl_sku.Size = new System.Drawing.Size(186, 23);
            this.lbl_sku.TabIndex = 2;
            this.lbl_sku.Text = "Inventory Number";
            // 
            // lbl_count
            // 
            this.lbl_count.AutoSize = true;
            this.lbl_count.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_count.Location = new System.Drawing.Point(124, 296);
            this.lbl_count.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_count.Name = "lbl_count";
            this.lbl_count.Size = new System.Drawing.Size(68, 23);
            this.lbl_count.TabIndex = 4;
            this.lbl_count.Text = "Count";
            // 
            // lbl_price
            // 
            this.lbl_price.AutoSize = true;
            this.lbl_price.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_price.Location = new System.Drawing.Point(400, 296);
            this.lbl_price.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_price.Name = "lbl_price";
            this.lbl_price.Size = new System.Drawing.Size(61, 23);
            this.lbl_price.TabIndex = 5;
            this.lbl_price.Text = "Price";
            // 
            // btn_add
            // 
            this.btn_add.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_add.Location = new System.Drawing.Point(126, 507);
            this.btn_add.Margin = new System.Windows.Forms.Padding(4);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(120, 42);
            this.btn_add.TabIndex = 6;
            this.btn_add.Text = "Add";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // txt_number
            // 
            this.txt_number.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_number.Location = new System.Drawing.Point(128, 152);
            this.txt_number.Margin = new System.Windows.Forms.Padding(4);
            this.txt_number.Name = "txt_number";
            this.txt_number.Size = new System.Drawing.Size(159, 27);
            this.txt_number.TabIndex = 8;
            this.txt_number.TextChanged += new System.EventHandler(this.txt_number_TextChanged);
            this.txt_number.Validating += new System.ComponentModel.CancelEventHandler(this.txt_number_Validating);
            // 
            // txt_objName
            // 
            this.txt_objName.Location = new System.Drawing.Point(125, 236);
            this.txt_objName.Margin = new System.Windows.Forms.Padding(4);
            this.txt_objName.Multiline = true;
            this.txt_objName.Name = "txt_objName";
            this.txt_objName.Size = new System.Drawing.Size(372, 32);
            this.txt_objName.TabIndex = 17;
            // 
            // txt_count
            // 
            this.txt_count.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_count.Location = new System.Drawing.Point(125, 339);
            this.txt_count.Margin = new System.Windows.Forms.Padding(4);
            this.txt_count.Name = "txt_count";
            this.txt_count.Size = new System.Drawing.Size(119, 27);
            this.txt_count.TabIndex = 18;
            // 
            // txt_price
            // 
            this.txt_price.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_price.Location = new System.Drawing.Point(378, 339);
            this.txt_price.Margin = new System.Windows.Forms.Padding(4);
            this.txt_price.Name = "txt_price";
            this.txt_price.Size = new System.Drawing.Size(119, 27);
            this.txt_price.TabIndex = 19;
            // 
            // txt_inventory
            // 
            this.txt_inventory.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_inventory.Location = new System.Drawing.Point(670, 152);
            this.txt_inventory.Margin = new System.Windows.Forms.Padding(4);
            this.txt_inventory.Name = "txt_inventory";
            this.txt_inventory.Size = new System.Drawing.Size(169, 27);
            this.txt_inventory.TabIndex = 20;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Location = new System.Drawing.Point(329, 152);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(4);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(299, 27);
            this.dateTimePicker1.TabIndex = 21;
            // 
            // lbl_objName
            // 
            this.lbl_objName.AutoSize = true;
            this.lbl_objName.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_objName.Location = new System.Drawing.Point(122, 209);
            this.lbl_objName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_objName.Name = "lbl_objName";
            this.lbl_objName.Size = new System.Drawing.Size(137, 23);
            this.lbl_objName.TabIndex = 22;
            this.lbl_objName.Text = "Object Name";
            // 
            // btn_cancel
            // 
            this.btn_cancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cancel.Location = new System.Drawing.Point(378, 507);
            this.btn_cancel.Margin = new System.Windows.Forms.Padding(4);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(120, 42);
            this.btn_cancel.TabIndex = 23;
            this.btn_cancel.Text = "Cancel";
            this.btn_cancel.UseVisualStyleBackColor = true;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // dt_products
            // 
            this.dt_products.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dt_products.Location = new System.Drawing.Point(536, 339);
            this.dt_products.Name = "dt_products";
            this.dt_products.RowHeadersWidth = 51;
            this.dt_products.RowTemplate.Height = 24;
            this.dt_products.Size = new System.Drawing.Size(452, 217);
            this.dt_products.TabIndex = 25;
            this.dt_products.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dt_products_CellContentClick);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // chk_options
            // 
            this.chk_options.FormattingEnabled = true;
            this.chk_options.Items.AddRange(new object[] {
            "Is Available",
            "Delivery",
            "Discount",
            "Coupon",
            "Store Credit"});
            this.chk_options.Location = new System.Drawing.Point(536, 209);
            this.chk_options.Name = "chk_options";
            this.chk_options.Size = new System.Drawing.Size(369, 114);
            this.chk_options.TabIndex = 28;
            this.chk_options.SelectedIndexChanged += new System.EventHandler(this.checkedListBox1_SelectedIndexChanged);
            // 
            // gb_payment
            // 
            this.gb_payment.Controls.Add(this.rb_payPal);
            this.gb_payment.Controls.Add(this.rb_telebir);
            this.gb_payment.Location = new System.Drawing.Point(125, 389);
            this.gb_payment.Name = "gb_payment";
            this.gb_payment.Size = new System.Drawing.Size(162, 100);
            this.gb_payment.TabIndex = 29;
            this.gb_payment.TabStop = false;
            this.gb_payment.Text = "Pyament";
            // 
            // rb_payPal
            // 
            this.rb_payPal.AutoSize = true;
            this.rb_payPal.Location = new System.Drawing.Point(17, 57);
            this.rb_payPal.Name = "rb_payPal";
            this.rb_payPal.Size = new System.Drawing.Size(82, 24);
            this.rb_payPal.TabIndex = 1;
            this.rb_payPal.TabStop = true;
            this.rb_payPal.Text = "PayPal";
            this.rb_payPal.UseVisualStyleBackColor = true;
            // 
            // rb_telebir
            // 
            this.rb_telebir.AutoSize = true;
            this.rb_telebir.Location = new System.Drawing.Point(17, 27);
            this.rb_telebir.Name = "rb_telebir";
            this.rb_telebir.Size = new System.Drawing.Size(87, 24);
            this.rb_telebir.TabIndex = 0;
            this.rb_telebir.TabStop = true;
            this.rb_telebir.Text = "Telebirr";
            this.rb_telebir.UseVisualStyleBackColor = true;
            this.rb_telebir.CheckedChanged += new System.EventHandler(this.rb_telebir_CheckedChanged);
            // 
            // gb_delivery
            // 
            this.gb_delivery.Controls.Add(this.rb_3day);
            this.gb_delivery.Controls.Add(this.rb_24hour);
            this.gb_delivery.Location = new System.Drawing.Point(335, 389);
            this.gb_delivery.Name = "gb_delivery";
            this.gb_delivery.Size = new System.Drawing.Size(162, 100);
            this.gb_delivery.TabIndex = 30;
            this.gb_delivery.TabStop = false;
            this.gb_delivery.Text = "Delivery";
            // 
            // rb_3day
            // 
            this.rb_3day.AutoSize = true;
            this.rb_3day.Location = new System.Drawing.Point(17, 57);
            this.rb_3day.Name = "rb_3day";
            this.rb_3day.Size = new System.Drawing.Size(137, 24);
            this.rb_3day.TabIndex = 1;
            this.rb_3day.TabStop = true;
            this.rb_3day.Text = "3 Day or More";
            this.rb_3day.UseVisualStyleBackColor = true;
            // 
            // rb_24hour
            // 
            this.rb_24hour.AutoSize = true;
            this.rb_24hour.Location = new System.Drawing.Point(17, 27);
            this.rb_24hour.Name = "rb_24hour";
            this.rb_24hour.Size = new System.Drawing.Size(90, 24);
            this.rb_24hour.TabIndex = 0;
            this.rb_24hour.TabStop = true;
            this.rb_24hour.Text = "24 Hour";
            this.rb_24hour.UseVisualStyleBackColor = true;
            // 
            // lbl_logedInUser
            // 
            this.lbl_logedInUser.AutoSize = true;
            this.lbl_logedInUser.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.lbl_logedInUser.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_logedInUser.Location = new System.Drawing.Point(56, 33);
            this.lbl_logedInUser.Name = "lbl_logedInUser";
            this.lbl_logedInUser.Size = new System.Drawing.Size(202, 33);
            this.lbl_logedInUser.TabIndex = 31;
            this.lbl_logedInUser.Text = "Loged in User";
            this.lbl_logedInUser.Click += new System.EventHandler(this.lbl_logedInUser_Click);
            // 
            // btn_logout
            // 
            this.btn_logout.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_logout.Location = new System.Drawing.Point(905, 33);
            this.btn_logout.Margin = new System.Windows.Forms.Padding(4);
            this.btn_logout.Name = "btn_logout";
            this.btn_logout.Size = new System.Drawing.Size(83, 33);
            this.btn_logout.TabIndex = 32;
            this.btn_logout.Text = "Logout";
            this.btn_logout.UseVisualStyleBackColor = true;
            this.btn_logout.Click += new System.EventHandler(this.btn_logout_Click);
            // 
            // lbl_search
            // 
            this.lbl_search.AutoSize = true;
            this.lbl_search.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.lbl_search.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_search.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbl_search.Location = new System.Drawing.Point(331, 25);
            this.lbl_search.Name = "lbl_search";
            this.lbl_search.Size = new System.Drawing.Size(144, 24);
            this.lbl_search.TabIndex = 33;
            this.lbl_search.Text = "Search a Product";
            // 
            // txt_search
            // 
            this.txt_search.Location = new System.Drawing.Point(329, 59);
            this.txt_search.Name = "txt_search";
            this.txt_search.Size = new System.Drawing.Size(214, 27);
            this.txt_search.TabIndex = 34;
            this.txt_search.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_search_KeyPress);
            // 
            // btn_search
            // 
            this.btn_search.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_search.Location = new System.Drawing.Point(562, 59);
            this.btn_search.Margin = new System.Windows.Forms.Padding(4);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(83, 27);
            this.btn_search.TabIndex = 35;
            this.btn_search.Text = "Search";
            this.btn_search.UseVisualStyleBackColor = true;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rb_price);
            this.groupBox1.Controls.Add(this.rb_invNo);
            this.groupBox1.Controls.Add(this.rb_byName);
            this.groupBox1.Location = new System.Drawing.Point(490, 9);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(408, 43);
            this.groupBox1.TabIndex = 36;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Option";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // rb_byName
            // 
            this.rb_byName.AutoSize = true;
            this.rb_byName.Location = new System.Drawing.Point(64, 17);
            this.rb_byName.Name = "rb_byName";
            this.rb_byName.Size = new System.Drawing.Size(74, 24);
            this.rb_byName.TabIndex = 0;
            this.rb_byName.TabStop = true;
            this.rb_byName.Text = "Name";
            this.rb_byName.UseVisualStyleBackColor = true;
            // 
            // rb_invNo
            // 
            this.rb_invNo.AutoSize = true;
            this.rb_invNo.Location = new System.Drawing.Point(158, 19);
            this.rb_invNo.Name = "rb_invNo";
            this.rb_invNo.Size = new System.Drawing.Size(123, 24);
            this.rb_invNo.TabIndex = 1;
            this.rb_invNo.TabStop = true;
            this.rb_invNo.Text = "Inventory No";
            this.rb_invNo.UseVisualStyleBackColor = true;
            // 
            // rb_price
            // 
            this.rb_price.AutoSize = true;
            this.rb_price.Location = new System.Drawing.Point(309, 19);
            this.rb_price.Name = "rb_price";
            this.rb_price.Size = new System.Drawing.Size(69, 24);
            this.rb_price.TabIndex = 37;
            this.rb_price.TabStop = true;
            this.rb_price.Text = "Price";
            this.rb_price.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1000, 562);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn_search);
            this.Controls.Add(this.txt_search);
            this.Controls.Add(this.lbl_search);
            this.Controls.Add(this.btn_logout);
            this.Controls.Add(this.lbl_logedInUser);
            this.Controls.Add(this.gb_delivery);
            this.Controls.Add(this.gb_payment);
            this.Controls.Add(this.chk_options);
            this.Controls.Add(this.dt_products);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.lbl_objName);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.txt_inventory);
            this.Controls.Add(this.txt_price);
            this.Controls.Add(this.txt_count);
            this.Controls.Add(this.txt_objName);
            this.Controls.Add(this.txt_number);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.lbl_price);
            this.Controls.Add(this.lbl_count);
            this.Controls.Add(this.lbl_sku);
            this.Controls.Add(this.lbl_datePicker);
            this.Controls.Add(this.lbl_number);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dt_products)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.gb_payment.ResumeLayout(false);
            this.gb_payment.PerformLayout();
            this.gb_delivery.ResumeLayout(false);
            this.gb_delivery.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_number;
        private System.Windows.Forms.Label lbl_datePicker;
        private System.Windows.Forms.Label lbl_sku;
        private System.Windows.Forms.Label lbl_count;
        private System.Windows.Forms.Label lbl_price;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.TextBox txt_number;
        private System.Windows.Forms.TextBox txt_objName;
        private System.Windows.Forms.TextBox txt_count;
        private System.Windows.Forms.TextBox txt_price;
        private System.Windows.Forms.TextBox txt_inventory;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label lbl_objName;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.DataGridView dt_products;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.CheckedListBox chk_options;
        private System.Windows.Forms.GroupBox gb_delivery;
        private System.Windows.Forms.RadioButton rb_3day;
        private System.Windows.Forms.RadioButton rb_24hour;
        private System.Windows.Forms.GroupBox gb_payment;
        private System.Windows.Forms.RadioButton rb_payPal;
        private System.Windows.Forms.RadioButton rb_telebir;
        private System.Windows.Forms.Label lbl_logedInUser;
        private System.Windows.Forms.Button btn_logout;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.TextBox txt_search;
        private System.Windows.Forms.Label lbl_search;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rb_byName;
        private System.Windows.Forms.RadioButton rb_invNo;
        private System.Windows.Forms.RadioButton rb_price;
    }
}

