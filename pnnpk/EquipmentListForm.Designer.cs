namespace pnnpk
{
    partial class EquipmentListForm
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
            this.equipment_list = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.change_button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.equipment_list)).BeginInit();
            this.SuspendLayout();
            // 
            // equipment_list
            // 
            this.equipment_list.AllowUserToAddRows = false;
            this.equipment_list.AllowUserToDeleteRows = false;
            this.equipment_list.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.equipment_list.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.equipment_list.Location = new System.Drawing.Point(12, 41);
            this.equipment_list.MultiSelect = false;
            this.equipment_list.Name = "equipment_list";
            this.equipment_list.ReadOnly = true;
            this.equipment_list.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.equipment_list.Size = new System.Drawing.Size(776, 362);
            this.equipment_list.TabIndex = 0;
            this.equipment_list.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_CellMouseDoubleClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(754, 31);
            this.label1.TabIndex = 1;
            this.label1.Text = "Список оборудования: Выберите оборудование на замену";
            // 
            // change_button
            // 
            this.change_button.Location = new System.Drawing.Point(689, 409);
            this.change_button.Name = "change_button";
            this.change_button.Size = new System.Drawing.Size(99, 35);
            this.change_button.TabIndex = 2;
            this.change_button.Text = "Выбрать";
            this.change_button.UseVisualStyleBackColor = true;
            this.change_button.Click += new System.EventHandler(this.change_button_Click);
            // 
            // EquipmentListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.change_button);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.equipment_list);
            this.Name = "EquipmentListForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.EquipmentReplacementForm_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.equipment_list)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView equipment_list;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button change_button;
    }
}