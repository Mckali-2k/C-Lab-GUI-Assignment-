
namespace WindowsFormsApp2
{
    partial class DetailPage
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
            this.lbl_count = new System.Windows.Forms.Label();
            this.lbl_date = new System.Windows.Forms.Label();
            this.lbl_objectName = new System.Windows.Forms.Label();
            this.lbl_inventoryNumber = new System.Windows.Forms.Label();
            this.lbl_number = new System.Windows.Forms.Label();
            this.lbl_numberDisplay = new System.Windows.Forms.Label();
            this.lbl_dateDisplay = new System.Windows.Forms.Label();
            this.lbl_inventoryNumberDisplay = new System.Windows.Forms.Label();
            this.lbl_objectNameDisplay = new System.Windows.Forms.Label();
            this.lbl_countDisplay = new System.Windows.Forms.Label();
            this.lbl_priceDisplay = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.tableLayoutPanel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.label6, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.lbl_count, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.lbl_date, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.lbl_objectName, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.lbl_inventoryNumber, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.lbl_number, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.lbl_numberDisplay, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.lbl_dateDisplay, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.lbl_inventoryNumberDisplay, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.lbl_objectNameDisplay, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.lbl_countDisplay, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.lbl_priceDisplay, 1, 5);
            this.tableLayoutPanel1.Enabled = false;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 12);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(731, 657);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // lbl_count
            // 
            this.lbl_count.AutoSize = true;
            this.lbl_count.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_count.Location = new System.Drawing.Point(3, 436);
            this.lbl_count.Name = "lbl_count";
            this.lbl_count.Size = new System.Drawing.Size(77, 29);
            this.lbl_count.TabIndex = 4;
            this.lbl_count.Text = "Count:";
            // 
            // lbl_date
            // 
            this.lbl_date.AutoSize = true;
            this.lbl_date.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_date.Location = new System.Drawing.Point(3, 109);
            this.lbl_date.Name = "lbl_date";
            this.lbl_date.Size = new System.Drawing.Size(63, 29);
            this.lbl_date.TabIndex = 1;
            this.lbl_date.Text = "Date:";
            // 
            // lbl_objectName
            // 
            this.lbl_objectName.AutoSize = true;
            this.lbl_objectName.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_objectName.Location = new System.Drawing.Point(3, 327);
            this.lbl_objectName.Name = "lbl_objectName";
            this.lbl_objectName.Size = new System.Drawing.Size(140, 29);
            this.lbl_objectName.TabIndex = 3;
            this.lbl_objectName.Text = "Object Name:";
            // 
            // lbl_inventoryNumber
            // 
            this.lbl_inventoryNumber.AutoSize = true;
            this.lbl_inventoryNumber.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_inventoryNumber.Location = new System.Drawing.Point(3, 218);
            this.lbl_inventoryNumber.Name = "lbl_inventoryNumber";
            this.lbl_inventoryNumber.Size = new System.Drawing.Size(189, 29);
            this.lbl_inventoryNumber.TabIndex = 2;
            this.lbl_inventoryNumber.Text = "Inventory Number:";
            // 
            // lbl_number
            // 
            this.lbl_number.AutoSize = true;
            this.lbl_number.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_number.Location = new System.Drawing.Point(3, 0);
            this.lbl_number.Name = "lbl_number";
            this.lbl_number.Size = new System.Drawing.Size(95, 29);
            this.lbl_number.TabIndex = 0;
            this.lbl_number.Text = "Number:";
            // 
            // lbl_numberDisplay
            // 
            this.lbl_numberDisplay.AutoSize = true;
            this.lbl_numberDisplay.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_numberDisplay.Location = new System.Drawing.Point(368, 0);
            this.lbl_numberDisplay.Name = "lbl_numberDisplay";
            this.lbl_numberDisplay.Size = new System.Drawing.Size(38, 29);
            this.lbl_numberDisplay.TabIndex = 6;
            this.lbl_numberDisplay.Text = ".....";
            // 
            // lbl_dateDisplay
            // 
            this.lbl_dateDisplay.AutoSize = true;
            this.lbl_dateDisplay.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_dateDisplay.Location = new System.Drawing.Point(368, 109);
            this.lbl_dateDisplay.Name = "lbl_dateDisplay";
            this.lbl_dateDisplay.Size = new System.Drawing.Size(38, 29);
            this.lbl_dateDisplay.TabIndex = 7;
            this.lbl_dateDisplay.Text = ".....";
            // 
            // lbl_inventoryNumberDisplay
            // 
            this.lbl_inventoryNumberDisplay.AutoSize = true;
            this.lbl_inventoryNumberDisplay.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_inventoryNumberDisplay.Location = new System.Drawing.Point(368, 218);
            this.lbl_inventoryNumberDisplay.Name = "lbl_inventoryNumberDisplay";
            this.lbl_inventoryNumberDisplay.Size = new System.Drawing.Size(38, 29);
            this.lbl_inventoryNumberDisplay.TabIndex = 8;
            this.lbl_inventoryNumberDisplay.Text = ".....";
            // 
            // lbl_objectNameDisplay
            // 
            this.lbl_objectNameDisplay.AutoSize = true;
            this.lbl_objectNameDisplay.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_objectNameDisplay.Location = new System.Drawing.Point(368, 327);
            this.lbl_objectNameDisplay.Name = "lbl_objectNameDisplay";
            this.lbl_objectNameDisplay.Size = new System.Drawing.Size(38, 29);
            this.lbl_objectNameDisplay.TabIndex = 9;
            this.lbl_objectNameDisplay.Text = ".....";
            // 
            // lbl_countDisplay
            // 
            this.lbl_countDisplay.AutoSize = true;
            this.lbl_countDisplay.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_countDisplay.Location = new System.Drawing.Point(368, 436);
            this.lbl_countDisplay.Name = "lbl_countDisplay";
            this.lbl_countDisplay.Size = new System.Drawing.Size(38, 29);
            this.lbl_countDisplay.TabIndex = 10;
            this.lbl_countDisplay.Text = ".....";
            // 
            // lbl_priceDisplay
            // 
            this.lbl_priceDisplay.AutoSize = true;
            this.lbl_priceDisplay.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_priceDisplay.Location = new System.Drawing.Point(368, 545);
            this.lbl_priceDisplay.Name = "lbl_priceDisplay";
            this.lbl_priceDisplay.Size = new System.Drawing.Size(38, 29);
            this.lbl_priceDisplay.TabIndex = 11;
            this.lbl_priceDisplay.Text = ".....";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(3, 545);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 29);
            this.label6.TabIndex = 12;
            this.label6.Text = "Price:";
            // 
            // DetailPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(755, 681);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "DetailPage";
            this.Text = "DetailPage";
            this.Load += new System.EventHandler(this.DetailPage_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lbl_number;
        private System.Windows.Forms.Label lbl_count;
        private System.Windows.Forms.Label lbl_date;
        private System.Windows.Forms.Label lbl_objectName;
        private System.Windows.Forms.Label lbl_inventoryNumber;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lbl_numberDisplay;
        private System.Windows.Forms.Label lbl_dateDisplay;
        private System.Windows.Forms.Label lbl_inventoryNumberDisplay;
        private System.Windows.Forms.Label lbl_objectNameDisplay;
        private System.Windows.Forms.Label lbl_countDisplay;
        private System.Windows.Forms.Label lbl_priceDisplay;
    }
}