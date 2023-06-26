namespace pnnpk
{
    partial class ExtensiveHistoryForm
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
            this.history_list = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.history_list)).BeginInit();
            this.SuspendLayout();
            // 
            // history_list
            // 
            this.history_list.AllowUserToAddRows = false;
            this.history_list.AllowUserToDeleteRows = false;
            this.history_list.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.history_list.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.history_list.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.history_list.Location = new System.Drawing.Point(13, 13);
            this.history_list.MultiSelect = false;
            this.history_list.Name = "history_list";
            this.history_list.ReadOnly = true;
            this.history_list.Size = new System.Drawing.Size(685, 79);
            this.history_list.TabIndex = 0;
            // 
            // ExtensiveHistoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(710, 104);
            this.Controls.Add(this.history_list);
            this.Name = "ExtensiveHistoryForm";
            ((System.ComponentModel.ISupportInitialize)(this.history_list)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView history_list;
    }
}