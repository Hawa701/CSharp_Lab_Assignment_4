namespace CSharp_Lab_Assignment_4
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
            this.lbl_Number = new System.Windows.Forms.Label();
            this.lbl_inventoryNumber = new System.Windows.Forms.Label();
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
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_Number
            // 
            this.lbl_Number.AutoSize = true;
            this.lbl_Number.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Number.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_Number.Location = new System.Drawing.Point(36, 93);
            this.lbl_Number.Name = "lbl_Number";
            this.lbl_Number.Size = new System.Drawing.Size(73, 22);
            this.lbl_Number.TabIndex = 0;
            this.lbl_Number.Text = "Number";
            // 
            // lbl_inventoryNumber
            // 
            this.lbl_inventoryNumber.AutoSize = true;
            this.lbl_inventoryNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_inventoryNumber.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbl_inventoryNumber.Location = new System.Drawing.Point(511, 93);
            this.lbl_inventoryNumber.Name = "lbl_inventoryNumber";
            this.lbl_inventoryNumber.Size = new System.Drawing.Size(151, 22);
            this.lbl_inventoryNumber.TabIndex = 1;
            this.lbl_inventoryNumber.Text = "Inventory Number";
            // 
            // lbl_date
            // 
            this.lbl_date.AutoSize = true;
            this.lbl_date.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_date.ForeColor = System.Drawing.SystemColors.Control;
            this.lbl_date.Location = new System.Drawing.Point(267, 93);
            this.lbl_date.Name = "lbl_date";
            this.lbl_date.Size = new System.Drawing.Size(48, 22);
            this.lbl_date.TabIndex = 2;
            this.lbl_date.Text = "Date";
            // 
            // txt_Number
            // 
            this.txt_Number.BackColor = System.Drawing.Color.White;
            this.txt_Number.Location = new System.Drawing.Point(40, 118);
            this.txt_Number.Name = "txt_Number";
            this.txt_Number.Size = new System.Drawing.Size(212, 26);
            this.txt_Number.TabIndex = 3;
            // 
            // txt_inventoryNumber
            // 
            this.txt_inventoryNumber.Location = new System.Drawing.Point(515, 120);
            this.txt_inventoryNumber.Name = "txt_inventoryNumber";
            this.txt_inventoryNumber.Size = new System.Drawing.Size(212, 26);
            this.txt_inventoryNumber.TabIndex = 5;
            // 
            // txt_date
            // 
            this.txt_date.Location = new System.Drawing.Point(271, 118);
            this.txt_date.Name = "txt_date";
            this.txt_date.Size = new System.Drawing.Size(224, 26);
            this.txt_date.TabIndex = 6;
            // 
            // lbl_objectName
            // 
            this.lbl_objectName.AutoSize = true;
            this.lbl_objectName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_objectName.ForeColor = System.Drawing.SystemColors.Control;
            this.lbl_objectName.Location = new System.Drawing.Point(36, 175);
            this.lbl_objectName.Name = "lbl_objectName";
            this.lbl_objectName.Size = new System.Drawing.Size(114, 22);
            this.lbl_objectName.TabIndex = 7;
            this.lbl_objectName.Text = "Object Name";
            // 
            // txt_objectName
            // 
            this.txt_objectName.Location = new System.Drawing.Point(40, 200);
            this.txt_objectName.Name = "txt_objectName";
            this.txt_objectName.Size = new System.Drawing.Size(687, 26);
            this.txt_objectName.TabIndex = 8;
            // 
            // lbl_count
            // 
            this.lbl_count.AutoSize = true;
            this.lbl_count.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_count.ForeColor = System.Drawing.SystemColors.Control;
            this.lbl_count.Location = new System.Drawing.Point(36, 253);
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
            this.lbl_price.Location = new System.Drawing.Point(402, 253);
            this.lbl_price.Name = "lbl_price";
            this.lbl_price.Size = new System.Drawing.Size(51, 22);
            this.lbl_price.TabIndex = 10;
            this.lbl_price.Text = "Price";
            // 
            // txt_count
            // 
            this.txt_count.Location = new System.Drawing.Point(40, 278);
            this.txt_count.Name = "txt_count";
            this.txt_count.Size = new System.Drawing.Size(321, 26);
            this.txt_count.TabIndex = 11;
            // 
            // txt_price
            // 
            this.txt_price.Location = new System.Drawing.Point(406, 278);
            this.txt_price.Name = "txt_price";
            this.txt_price.Size = new System.Drawing.Size(321, 26);
            this.txt_price.TabIndex = 12;
            // 
            // btn_Add
            // 
            this.btn_Add.BackColor = System.Drawing.Color.Gray;
            this.btn_Add.Location = new System.Drawing.Point(177, 361);
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
            this.btn_Cancel.Location = new System.Drawing.Point(436, 361);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(175, 35);
            this.btn_Cancel.TabIndex = 14;
            this.btn_Cancel.Text = "Cancel";
            this.btn_Cancel.UseVisualStyleBackColor = false;
            this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(327, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(226, 37);
            this.label1.TabIndex = 15;
            this.label1.Text = "Add Inventory";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(800, 435);
            this.Controls.Add(this.label1);
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
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Number;
        private System.Windows.Forms.Label lbl_inventoryNumber;
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
        private System.Windows.Forms.Label label1;
    }
}

