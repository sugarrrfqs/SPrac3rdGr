namespace pnnpk
{
    partial class BrowseItemForm
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
            this.search_box1 = new System.Windows.Forms.TextBox();
            this.search_box2 = new System.Windows.Forms.TextBox();
            this.search_box3 = new System.Windows.Forms.TextBox();
            this.search_box4 = new System.Windows.Forms.TextBox();
            this.search_button = new System.Windows.Forms.Button();
            this.search_clear1 = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.item_list = new System.Windows.Forms.DataGridView();
            this.add_button = new System.Windows.Forms.Button();
            this.choose_button = new System.Windows.Forms.Button();
            this.add_from_file_button = new System.Windows.Forms.Button();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.item_list)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(247, 37);
            this.label1.TabIndex = 1;
            this.label1.Text = "Выберите товар";
            // 
            // search_box1
            // 
            this.search_box1.Location = new System.Drawing.Point(19, 66);
            this.search_box1.Name = "search_box1";
            this.search_box1.Size = new System.Drawing.Size(63, 20);
            this.search_box1.TabIndex = 15;
            // 
            // search_box2
            // 
            this.search_box2.Location = new System.Drawing.Point(81, 66);
            this.search_box2.Name = "search_box2";
            this.search_box2.Size = new System.Drawing.Size(63, 20);
            this.search_box2.TabIndex = 16;
            // 
            // search_box3
            // 
            this.search_box3.Location = new System.Drawing.Point(143, 66);
            this.search_box3.Name = "search_box3";
            this.search_box3.Size = new System.Drawing.Size(63, 20);
            this.search_box3.TabIndex = 17;
            // 
            // search_box4
            // 
            this.search_box4.Location = new System.Drawing.Point(205, 66);
            this.search_box4.Name = "search_box4";
            this.search_box4.Size = new System.Drawing.Size(63, 20);
            this.search_box4.TabIndex = 18;
            // 
            // search_button
            // 
            this.search_button.Location = new System.Drawing.Point(274, 66);
            this.search_button.Name = "search_button";
            this.search_button.Size = new System.Drawing.Size(20, 20);
            this.search_button.TabIndex = 19;
            this.search_button.Text = ">";
            this.search_button.UseVisualStyleBackColor = true;
            this.search_button.Click += new System.EventHandler(this.search_button_Click);
            // 
            // search_clear1
            // 
            this.search_clear1.Location = new System.Drawing.Point(300, 66);
            this.search_clear1.Name = "search_clear1";
            this.search_clear1.Size = new System.Drawing.Size(20, 20);
            this.search_clear1.TabIndex = 20;
            this.search_clear1.Text = "X";
            this.search_clear1.UseVisualStyleBackColor = true;
            this.search_clear1.Click += new System.EventHandler(this.search_clear1_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(16, 50);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(48, 13);
            this.label8.TabIndex = 42;
            this.label8.Text = "Поиск...";
            // 
            // item_list
            // 
            this.item_list.AllowUserToAddRows = false;
            this.item_list.AllowUserToDeleteRows = false;
            this.item_list.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.item_list.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            this.item_list.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.item_list.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.item_list.Location = new System.Drawing.Point(19, 105);
            this.item_list.MultiSelect = false;
            this.item_list.Name = "item_list";
            this.item_list.ReadOnly = true;
            this.item_list.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.item_list.Size = new System.Drawing.Size(597, 418);
            this.item_list.TabIndex = 43;
            this.item_list.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.item_list_CellContentDoubleClick);
            // 
            // add_button
            // 
            this.add_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.add_button.Location = new System.Drawing.Point(326, 49);
            this.add_button.Name = "add_button";
            this.add_button.Size = new System.Drawing.Size(142, 53);
            this.add_button.TabIndex = 44;
            this.add_button.Text = "Добавить новый";
            this.add_button.UseVisualStyleBackColor = true;
            this.add_button.Click += new System.EventHandler(this.add_button_Click);
            // 
            // choose_button
            // 
            this.choose_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.choose_button.Location = new System.Drawing.Point(510, 529);
            this.choose_button.Name = "choose_button";
            this.choose_button.Size = new System.Drawing.Size(106, 29);
            this.choose_button.TabIndex = 45;
            this.choose_button.Text = "Выбрать";
            this.choose_button.UseVisualStyleBackColor = true;
            this.choose_button.Click += new System.EventHandler(this.choose_button_Click);
            // 
            // add_from_file_button
            // 
            this.add_from_file_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.add_from_file_button.Location = new System.Drawing.Point(474, 49);
            this.add_from_file_button.Name = "add_from_file_button";
            this.add_from_file_button.Size = new System.Drawing.Size(142, 53);
            this.add_from_file_button.TabIndex = 46;
            this.add_from_file_button.Text = "Добавить новый из файла";
            this.add_from_file_button.UseVisualStyleBackColor = true;
            this.add_from_file_button.Click += new System.EventHandler(this.add_from_file_button_Click);
            // 
            // BrowseItemForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(633, 565);
            this.Controls.Add(this.add_from_file_button);
            this.Controls.Add(this.choose_button);
            this.Controls.Add(this.add_button);
            this.Controls.Add(this.item_list);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.search_box1);
            this.Controls.Add(this.search_box2);
            this.Controls.Add(this.search_box3);
            this.Controls.Add(this.search_box4);
            this.Controls.Add(this.search_button);
            this.Controls.Add(this.search_clear1);
            this.Controls.Add(this.label1);
            this.Name = "BrowseItemForm";
            ((System.ComponentModel.ISupportInitialize)(this.item_list)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox search_box1;
        private System.Windows.Forms.TextBox search_box2;
        private System.Windows.Forms.TextBox search_box3;
        private System.Windows.Forms.TextBox search_box4;
        private System.Windows.Forms.Button search_button;
        private System.Windows.Forms.Button search_clear1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView item_list;
        private System.Windows.Forms.Button add_button;
        private System.Windows.Forms.Button choose_button;
        private System.Windows.Forms.Button add_from_file_button;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
    }
}