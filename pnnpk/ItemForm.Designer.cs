namespace pnnpk
{
    partial class ItemForm
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
            this.request_list = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.item_type_label = new System.Windows.Forms.Label();
            this.item_id_label = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.item_group_id_label = new System.Windows.Forms.Label();
            this.change_emp_button = new System.Windows.Forms.Button();
            this.request_button = new System.Windows.Forms.Button();
            this.move_button = new System.Windows.Forms.Button();
            this.storekeeper_groupbox = new System.Windows.Forms.GroupBox();
            this.description_box = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.request_list)).BeginInit();
            this.storekeeper_groupbox.SuspendLayout();
            this.SuspendLayout();
            // 
            // request_list
            // 
            this.request_list.AllowUserToAddRows = false;
            this.request_list.AllowUserToDeleteRows = false;
            this.request_list.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.request_list.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            this.request_list.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.request_list.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.request_list.Location = new System.Drawing.Point(12, 130);
            this.request_list.MultiSelect = false;
            this.request_list.Name = "request_list";
            this.request_list.ReadOnly = true;
            this.request_list.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.request_list.Size = new System.Drawing.Size(560, 419);
            this.request_list.TabIndex = 45;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(12, 39);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(183, 24);
            this.label4.TabIndex = 49;
            this.label4.Text = "Тип оборудования:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(12, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 24);
            this.label3.TabIndex = 48;
            this.label3.Text = "ID:";
            // 
            // item_type_label
            // 
            this.item_type_label.AutoSize = true;
            this.item_type_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.item_type_label.Location = new System.Drawing.Point(198, 39);
            this.item_type_label.Name = "item_type_label";
            this.item_type_label.Size = new System.Drawing.Size(90, 24);
            this.item_type_label.TabIndex = 47;
            this.item_type_label.Text = "item_type";
            // 
            // item_id_label
            // 
            this.item_id_label.AutoSize = true;
            this.item_id_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.item_id_label.Location = new System.Drawing.Point(198, 9);
            this.item_id_label.Name = "item_id_label";
            this.item_id_label.Size = new System.Drawing.Size(70, 24);
            this.item_id_label.TabIndex = 46;
            this.item_id_label.Text = "item_id";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 24);
            this.label1.TabIndex = 51;
            this.label1.Text = "ID группы:";
            // 
            // item_group_id_label
            // 
            this.item_group_id_label.AutoSize = true;
            this.item_group_id_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.item_group_id_label.Location = new System.Drawing.Point(198, 68);
            this.item_group_id_label.Name = "item_group_id_label";
            this.item_group_id_label.Size = new System.Drawing.Size(130, 24);
            this.item_group_id_label.TabIndex = 50;
            this.item_group_id_label.Text = "item_group_id";
            // 
            // change_emp_button
            // 
            this.change_emp_button.Location = new System.Drawing.Point(6, 77);
            this.change_emp_button.Name = "change_emp_button";
            this.change_emp_button.Size = new System.Drawing.Size(198, 23);
            this.change_emp_button.TabIndex = 54;
            this.change_emp_button.Text = "Сменить пользователя";
            this.change_emp_button.UseVisualStyleBackColor = true;
            this.change_emp_button.Click += new System.EventHandler(this.change_emp_button_Click);
            // 
            // request_button
            // 
            this.request_button.Location = new System.Drawing.Point(6, 48);
            this.request_button.Name = "request_button";
            this.request_button.Size = new System.Drawing.Size(198, 23);
            this.request_button.TabIndex = 53;
            this.request_button.Text = "Заявка на ремонт";
            this.request_button.UseVisualStyleBackColor = true;
            this.request_button.Click += new System.EventHandler(this.request_button_Click);
            // 
            // move_button
            // 
            this.move_button.Location = new System.Drawing.Point(6, 19);
            this.move_button.Name = "move_button";
            this.move_button.Size = new System.Drawing.Size(198, 23);
            this.move_button.TabIndex = 52;
            this.move_button.Text = "Перемещение";
            this.move_button.UseVisualStyleBackColor = true;
            this.move_button.Click += new System.EventHandler(this.move_button_Click);
            // 
            // storekeeper_groupbox
            // 
            this.storekeeper_groupbox.Controls.Add(this.move_button);
            this.storekeeper_groupbox.Controls.Add(this.change_emp_button);
            this.storekeeper_groupbox.Controls.Add(this.request_button);
            this.storekeeper_groupbox.Location = new System.Drawing.Point(357, 12);
            this.storekeeper_groupbox.Name = "storekeeper_groupbox";
            this.storekeeper_groupbox.Size = new System.Drawing.Size(215, 112);
            this.storekeeper_groupbox.TabIndex = 55;
            this.storekeeper_groupbox.TabStop = false;
            this.storekeeper_groupbox.Text = "Кладовщик";
            this.storekeeper_groupbox.Visible = false;
            // 
            // description_box
            // 
            this.description_box.Location = new System.Drawing.Point(16, 95);
            this.description_box.Multiline = true;
            this.description_box.Name = "description_box";
            this.description_box.ReadOnly = true;
            this.description_box.Size = new System.Drawing.Size(335, 29);
            this.description_box.TabIndex = 56;
            // 
            // ItemForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 561);
            this.Controls.Add(this.description_box);
            this.Controls.Add(this.storekeeper_groupbox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.item_group_id_label);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.item_type_label);
            this.Controls.Add(this.item_id_label);
            this.Controls.Add(this.request_list);
            this.Name = "ItemForm";
            ((System.ComponentModel.ISupportInitialize)(this.request_list)).EndInit();
            this.storekeeper_groupbox.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView request_list;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label item_type_label;
        private System.Windows.Forms.Label item_id_label;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label item_group_id_label;
        private System.Windows.Forms.Button change_emp_button;
        private System.Windows.Forms.Button request_button;
        private System.Windows.Forms.Button move_button;
        private System.Windows.Forms.GroupBox storekeeper_groupbox;
        private System.Windows.Forms.TextBox description_box;
    }
}