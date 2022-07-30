namespace CSharp_Lab_Assignment_4
{
    partial class InventoryPage
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
            this.lbl_Number = new System.Windows.Forms.Label();
            this.lbl_date = new System.Windows.Forms.Label();
            this.txt_Number = new System.Windows.Forms.TextBox();
            this.txt_inventoryNumber = new System.Windows.Forms.TextBox();
            this.txt_date = new System.Windows.Forms.DateTimePicker();
            this.lbl_objectName = new System.Windows.Forms.Label();
            this.txt_objectName = new System.Windows.Forms.TextBox();
            this.lbl_count = new System.Windows.Forms.Label();
            this.lbl_price = new System.Windows.Forms.Label();
            this.txt_count = new System.Windows.Forms.TextBox();
            this.txt_price = new System.Windows.Forms.TextBox();
            this.btn_Add = new System.Windows.Forms.Button();
            this.btn_Cancel = new System.Windows.Forms.Button();
            this.lbl_AddInventory = new System.Windows.Forms.Label();
            this.dvList = new System.Windows.Forms.DataGridView();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.chk_colorChoice = new System.Windows.Forms.CheckedListBox();
            this.lbl_Color = new System.Windows.Forms.Label();
            this.rb_Available = new System.Windows.Forms.RadioButton();
            this.rb_NotAvailable = new System.Windows.Forms.RadioButton();
            this.groupBox = new System.Windows.Forms.GroupBox();
            this.btn_logOut = new System.Windows.Forms.Button();
            this.lbl_inventoryNumber = new System.Windows.Forms.Label();
            this.lbl_Table = new System.Windows.Forms.Label();
            this.lbl_welcomeBack = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dvList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.groupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_Number
            // 
            this.lbl_Number.AutoSize = true;
            this.lbl_Number.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Number.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_Number.Location = new System.Drawing.Point(37, 173);
            this.lbl_Number.Name = "lbl_Number";
            this.lbl_Number.Size = new System.Drawing.Size(73, 22);
            this.lbl_Number.TabIndex = 0;
            this.lbl_Number.Text = "Number";
            // 
            // lbl_date
            // 
            this.lbl_date.AutoSize = true;
            this.lbl_date.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_date.ForeColor = System.Drawing.SystemColors.Control;
            this.lbl_date.Location = new System.Drawing.Point(232, 173);
            this.lbl_date.Name = "lbl_date";
            this.lbl_date.Size = new System.Drawing.Size(48, 22);
            this.lbl_date.TabIndex = 2;
            this.lbl_date.Text = "Date";
            // 
            // txt_Number
            // 
            this.txt_Number.BackColor = System.Drawing.Color.White;
            this.txt_Number.Location = new System.Drawing.Point(41, 198);
            this.txt_Number.Name = "txt_Number";
            this.txt_Number.Size = new System.Drawing.Size(170, 26);
            this.txt_Number.TabIndex = 3;
            // 
            // txt_inventoryNumber
            // 
            this.txt_inventoryNumber.Location = new System.Drawing.Point(490, 200);
            this.txt_inventoryNumber.Name = "txt_inventoryNumber";
            this.txt_inventoryNumber.Size = new System.Drawing.Size(177, 26);
            this.txt_inventoryNumber.TabIndex = 5;
            // 
            // txt_date
            // 
            this.txt_date.Location = new System.Drawing.Point(236, 198);
            this.txt_date.Name = "txt_date";
            this.txt_date.Size = new System.Drawing.Size(224, 26);
            this.txt_date.TabIndex = 6;
            // 
            // lbl_objectName
            // 
            this.lbl_objectName.AutoSize = true;
            this.lbl_objectName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_objectName.ForeColor = System.Drawing.SystemColors.Control;
            this.lbl_objectName.Location = new System.Drawing.Point(37, 255);
            this.lbl_objectName.Name = "lbl_objectName";
            this.lbl_objectName.Size = new System.Drawing.Size(114, 22);
            this.lbl_objectName.TabIndex = 7;
            this.lbl_objectName.Text = "Object Name";
            // 
            // txt_objectName
            // 
            this.txt_objectName.Location = new System.Drawing.Point(41, 280);
            this.txt_objectName.Name = "txt_objectName";
            this.txt_objectName.Size = new System.Drawing.Size(626, 26);
            this.txt_objectName.TabIndex = 8;
            // 
            // lbl_count
            // 
            this.lbl_count.AutoSize = true;
            this.lbl_count.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_count.ForeColor = System.Drawing.SystemColors.Control;
            this.lbl_count.Location = new System.Drawing.Point(37, 333);
            this.lbl_count.Name = "lbl_count";
            this.lbl_count.Size = new System.Drawing.Size(58, 22);
            this.lbl_count.TabIndex = 9;
            this.lbl_count.Text = "Count";
            // 
            // lbl_price
            // 
            this.lbl_price.AutoSize = true;
            this.lbl_price.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_price.ForeColor = System.Drawing.SystemColors.Control;
            this.lbl_price.Location = new System.Drawing.Point(342, 333);
            this.lbl_price.Name = "lbl_price";
            this.lbl_price.Size = new System.Drawing.Size(51, 22);
            this.lbl_price.TabIndex = 10;
            this.lbl_price.Text = "Price";
            // 
            // txt_count
            // 
            this.txt_count.Location = new System.Drawing.Point(41, 358);
            this.txt_count.Name = "txt_count";
            this.txt_count.Size = new System.Drawing.Size(277, 26);
            this.txt_count.TabIndex = 11;
            // 
            // txt_price
            // 
            this.txt_price.Location = new System.Drawing.Point(346, 358);
            this.txt_price.Name = "txt_price";
            this.txt_price.Size = new System.Drawing.Size(321, 26);
            this.txt_price.TabIndex = 12;
            // 
            // btn_Add
            // 
            this.btn_Add.BackColor = System.Drawing.Color.Gray;
            this.btn_Add.Location = new System.Drawing.Point(41, 521);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(175, 35);
            this.btn_Add.TabIndex = 13;
            this.btn_Add.Text = "Add";
            this.btn_Add.UseVisualStyleBackColor = false;
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.BackColor = System.Drawing.Color.Gray;
            this.btn_Cancel.Location = new System.Drawing.Point(266, 521);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(175, 35);
            this.btn_Cancel.TabIndex = 14;
            this.btn_Cancel.Text = "Cancel";
            this.btn_Cancel.UseVisualStyleBackColor = false;
            this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
            // 
            // lbl_AddInventory
            // 
            this.lbl_AddInventory.AutoSize = true;
            this.lbl_AddInventory.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_AddInventory.ForeColor = System.Drawing.Color.White;
            this.lbl_AddInventory.Location = new System.Drawing.Point(590, 29);
            this.lbl_AddInventory.Name = "lbl_AddInventory";
            this.lbl_AddInventory.Size = new System.Drawing.Size(243, 37);
            this.lbl_AddInventory.TabIndex = 15;
            this.lbl_AddInventory.Text = "Inventory Page";
            // 
            // dvList
            // 
            this.dvList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvList.Location = new System.Drawing.Point(703, 198);
            this.dvList.Name = "dvList";
            this.dvList.RowHeadersWidth = 62;
            this.dvList.RowTemplate.Height = 28;
            this.dvList.Size = new System.Drawing.Size(562, 358);
            this.dvList.TabIndex = 16;
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // chk_colorChoice
            // 
            this.chk_colorChoice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(40)))), ((int)(((byte)(44)))));
            this.chk_colorChoice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.chk_colorChoice.ForeColor = System.Drawing.SystemColors.Window;
            this.chk_colorChoice.FormattingEnabled = true;
            this.chk_colorChoice.Items.AddRange(new object[] {
            "Black",
            "White"});
            this.chk_colorChoice.Location = new System.Drawing.Point(346, 439);
            this.chk_colorChoice.Name = "chk_colorChoice";
            this.chk_colorChoice.Size = new System.Drawing.Size(321, 48);
            this.chk_colorChoice.TabIndex = 19;
            // 
            // lbl_Color
            // 
            this.lbl_Color.AutoSize = true;
            this.lbl_Color.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Color.ForeColor = System.Drawing.SystemColors.Control;
            this.lbl_Color.Location = new System.Drawing.Point(342, 414);
            this.lbl_Color.Name = "lbl_Color";
            this.lbl_Color.Size = new System.Drawing.Size(53, 22);
            this.lbl_Color.TabIndex = 20;
            this.lbl_Color.Text = "Color";
            // 
            // rb_Available
            // 
            this.rb_Available.AutoSize = true;
            this.rb_Available.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.rb_Available.Location = new System.Drawing.Point(6, 19);
            this.rb_Available.Name = "rb_Available";
            this.rb_Available.Size = new System.Drawing.Size(97, 24);
            this.rb_Available.TabIndex = 23;
            this.rb_Available.TabStop = true;
            this.rb_Available.Text = "Available";
            this.rb_Available.UseVisualStyleBackColor = true;
            // 
            // rb_NotAvailable
            // 
            this.rb_NotAvailable.AutoSize = true;
            this.rb_NotAvailable.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.rb_NotAvailable.Location = new System.Drawing.Point(6, 43);
            this.rb_NotAvailable.Name = "rb_NotAvailable";
            this.rb_NotAvailable.Size = new System.Drawing.Size(126, 24);
            this.rb_NotAvailable.TabIndex = 24;
            this.rb_NotAvailable.TabStop = true;
            this.rb_NotAvailable.Text = "Not Available";
            this.rb_NotAvailable.UseVisualStyleBackColor = true;
            // 
            // groupBox
            // 
            this.groupBox.Controls.Add(this.rb_Available);
            this.groupBox.Controls.Add(this.rb_NotAvailable);
            this.groupBox.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox.Location = new System.Drawing.Point(41, 414);
            this.groupBox.Name = "groupBox";
            this.groupBox.Size = new System.Drawing.Size(277, 73);
            this.groupBox.TabIndex = 25;
            this.groupBox.TabStop = false;
            this.groupBox.Text = "Product Availability";
            // 
            // btn_logOut
            // 
            this.btn_logOut.BackColor = System.Drawing.Color.Gray;
            this.btn_logOut.Location = new System.Drawing.Point(490, 521);
            this.btn_logOut.Name = "btn_logOut";
            this.btn_logOut.Size = new System.Drawing.Size(175, 35);
            this.btn_logOut.TabIndex = 26;
            this.btn_logOut.Text = "Log Out";
            this.btn_logOut.UseVisualStyleBackColor = false;
            this.btn_logOut.Click += new System.EventHandler(this.btn_logOut_Click);
            // 
            // lbl_inventoryNumber
            // 
            this.lbl_inventoryNumber.AutoSize = true;
            this.lbl_inventoryNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_inventoryNumber.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbl_inventoryNumber.Location = new System.Drawing.Point(486, 173);
            this.lbl_inventoryNumber.Name = "lbl_inventoryNumber";
            this.lbl_inventoryNumber.Size = new System.Drawing.Size(151, 22);
            this.lbl_inventoryNumber.TabIndex = 1;
            this.lbl_inventoryNumber.Text = "Inventory Number";
            // 
            // lbl_Table
            // 
            this.lbl_Table.AutoSize = true;
            this.lbl_Table.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Table.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbl_Table.Location = new System.Drawing.Point(699, 173);
            this.lbl_Table.Name = "lbl_Table";
            this.lbl_Table.Size = new System.Drawing.Size(56, 22);
            this.lbl_Table.TabIndex = 27;
            this.lbl_Table.Text = "Table";
            // 
            // lbl_welcomeBack
            // 
            this.lbl_welcomeBack.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_welcomeBack.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbl_welcomeBack.Location = new System.Drawing.Point(148, 108);
            this.lbl_welcomeBack.Name = "lbl_welcomeBack";
            this.lbl_welcomeBack.Size = new System.Drawing.Size(607, 31);
            this.lbl_welcomeBack.TabIndex = 28;
            this.lbl_welcomeBack.Text = "Welcome back ";
            // 
            // InventoryPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(25)))), ((int)(((byte)(28)))));
            this.ClientSize = new System.Drawing.Size(1288, 596);
            this.Controls.Add(this.lbl_welcomeBack);
            this.Controls.Add(this.lbl_Table);
            this.Controls.Add(this.btn_logOut);
            this.Controls.Add(this.groupBox);
            this.Controls.Add(this.lbl_Color);
            this.Controls.Add(this.chk_colorChoice);
            this.Controls.Add(this.dvList);
            this.Controls.Add(this.lbl_AddInventory);
            this.Controls.Add(this.btn_Cancel);
            this.Controls.Add(this.btn_Add);
            this.Controls.Add(this.txt_price);
            this.Controls.Add(this.txt_count);
            this.Controls.Add(this.lbl_price);
            this.Controls.Add(this.lbl_count);
            this.Controls.Add(this.txt_objectName);
            this.Controls.Add(this.lbl_objectName);
            this.Controls.Add(this.txt_date);
            this.Controls.Add(this.txt_inventoryNumber);
            this.Controls.Add(this.txt_Number);
            this.Controls.Add(this.lbl_date);
            this.Controls.Add(this.lbl_inventoryNumber);
            this.Controls.Add(this.lbl_Number);
            this.Name = "InventoryPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inventory Page";
            ((System.ComponentModel.ISupportInitialize)(this.dvList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.groupBox.ResumeLayout(false);
            this.groupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Number;
        private System.Windows.Forms.Label lbl_date;
        private System.Windows.Forms.TextBox txt_Number;
        private System.Windows.Forms.TextBox txt_inventoryNumber;
        private System.Windows.Forms.DateTimePicker txt_date;
        private System.Windows.Forms.Label lbl_objectName;
        private System.Windows.Forms.TextBox txt_objectName;
        private System.Windows.Forms.Label lbl_count;
        private System.Windows.Forms.Label lbl_price;
        private System.Windows.Forms.TextBox txt_count;
        private System.Windows.Forms.TextBox txt_price;
        private System.Windows.Forms.Button btn_Add;
        private System.Windows.Forms.Button btn_Cancel;
        private System.Windows.Forms.Label lbl_AddInventory;
        private System.Windows.Forms.DataGridView dvList;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.CheckedListBox chk_colorChoice;
        private System.Windows.Forms.Label lbl_Color;
        private System.Windows.Forms.GroupBox groupBox;
        private System.Windows.Forms.RadioButton rb_Available;
        private System.Windows.Forms.RadioButton rb_NotAvailable;
        private System.Windows.Forms.Label lbl_Table;
        private System.Windows.Forms.Button btn_logOut;
        private System.Windows.Forms.Label lbl_inventoryNumber;
        private System.Windows.Forms.Label lbl_welcomeBack;
    }
}

