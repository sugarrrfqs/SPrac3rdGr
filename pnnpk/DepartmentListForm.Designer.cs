namespace pnnpk
{
    partial class DepartmentListForm
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
            this.change_button = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dep_list = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dep_list)).BeginInit();
            this.SuspendLayout();
            // 
            // change_button
            // 
            this.change_button.Location = new System.Drawing.Point(211, 258);
            this.change_button.Name = "change_button";
            this.change_button.Size = new System.Drawing.Size(99, 35);
            this.change_button.TabIndex = 8;
            this.change_button.Text = "Выбрать";
            this.change_button.UseVisualStyleBackColor = true;
            this.change_button.Click += new System.EventHandler(this.change_button_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(224, 31);
            this.label1.TabIndex = 7;
            this.label1.Text = "Список отделов:";
            // 
            // dep_list
            // 
            this.dep_list.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dep_list.Location = new System.Drawing.Point(12, 41);
            this.dep_list.Name = "dep_list";
            this.dep_list.Size = new System.Drawing.Size(298, 211);
            this.dep_list.TabIndex = 6;
            // 
            // DepartmentListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(322, 304);
            this.Controls.Add(this.change_button);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dep_list);
            this.Name = "DepartmentListForm";
            ((System.ComponentModel.ISupportInitialize)(this.dep_list)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button change_button;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dep_list;
    }
}