namespace pnnpk
{
    partial class PurchaseForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.purchase_list = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.add_item_button = new System.Windows.Forms.Button();
            this.edit_item_button = new System.Windows.Forms.Button();
            this.delete_item_button = new System.Windows.Forms.Button();
            this.sum_label = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.purchase_list)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(312, 31);
            this.label1.TabIndex = 3;
            this.label1.Text = "Закупка оборудования:";
            // 
            // purchase_list
            // 
            this.purchase_list.AllowUserToAddRows = false;
            this.purchase_list.AllowUserToDeleteRows = false;
            this.purchase_list.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.purchase_list.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            this.purchase_list.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.purchase_list.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.purchase_list.Location = new System.Drawing.Point(18, 55);
            this.purchase_list.MultiSelect = false;
            this.purchase_list.Name = "purchase_list";
            this.purchase_list.ReadOnly = true;
            this.purchase_list.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.purchase_list.Size = new System.Drawing.Size(854, 352);
            this.purchase_list.TabIndex = 4;
            this.purchase_list.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.purchase_list_CellDoubleClick);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(766, 413);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(106, 29);
            this.button1.TabIndex = 5;
            this.button1.Text = "Купить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(12, 413);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 31);
            this.label2.TabIndex = 6;
            this.label2.Text = "Итого:";
            // 
            // add_item_button
            // 
            this.add_item_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.add_item_button.Location = new System.Drawing.Point(542, 11);
            this.add_item_button.Name = "add_item_button";
            this.add_item_button.Size = new System.Drawing.Size(106, 29);
            this.add_item_button.TabIndex = 7;
            this.add_item_button.Text = "Добавить";
            this.add_item_button.UseVisualStyleBackColor = true;
            this.add_item_button.Click += new System.EventHandler(this.add_item_button_Click);
            // 
            // edit_item_button
            // 
            this.edit_item_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.edit_item_button.Location = new System.Drawing.Point(654, 11);
            this.edit_item_button.Name = "edit_item_button";
            this.edit_item_button.Size = new System.Drawing.Size(106, 29);
            this.edit_item_button.TabIndex = 8;
            this.edit_item_button.Text = "Изменить";
            this.edit_item_button.UseVisualStyleBackColor = true;
            this.edit_item_button.Click += new System.EventHandler(this.edit_item_button_Click);
            // 
            // delete_item_button
            // 
            this.delete_item_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.delete_item_button.Location = new System.Drawing.Point(766, 12);
            this.delete_item_button.Name = "delete_item_button";
            this.delete_item_button.Size = new System.Drawing.Size(106, 29);
            this.delete_item_button.TabIndex = 9;
            this.delete_item_button.Text = "Удалить";
            this.delete_item_button.UseVisualStyleBackColor = true;
            this.delete_item_button.Click += new System.EventHandler(this.delete_item_button_Click);
            // 
            // sum_label
            // 
            this.sum_label.AutoSize = true;
            this.sum_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.sum_label.ForeColor = System.Drawing.Color.Red;
            this.sum_label.Location = new System.Drawing.Point(112, 413);
            this.sum_label.Name = "sum_label";
            this.sum_label.Size = new System.Drawing.Size(29, 31);
            this.sum_label.TabIndex = 10;
            this.sum_label.Text = "0";
            // 
            // PurchaseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 451);
            this.Controls.Add(this.sum_label);
            this.Controls.Add(this.delete_item_button);
            this.Controls.Add(this.edit_item_button);
            this.Controls.Add(this.add_item_button);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.purchase_list);
            this.Controls.Add(this.label1);
            this.Name = "PurchaseForm";
            ((System.ComponentModel.ISupportInitialize)(this.purchase_list)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView purchase_list;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button add_item_button;
        private System.Windows.Forms.Button edit_item_button;
        private System.Windows.Forms.Button delete_item_button;
        private System.Windows.Forms.Label sum_label;
    }
}