namespace pnnpk
{
    partial class ChangeGroupForm
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
            this.change_group_button = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ID_label = new System.Windows.Forms.Label();
            this.group_box = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // change_group_button
            // 
            this.change_group_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.change_group_button.Location = new System.Drawing.Point(116, 116);
            this.change_group_button.Name = "change_group_button";
            this.change_group_button.Size = new System.Drawing.Size(125, 31);
            this.change_group_button.TabIndex = 0;
            this.change_group_button.Text = "Изменить";
            this.change_group_button.UseVisualStyleBackColor = true;
            this.change_group_button.Click += new System.EventHandler(this.change_group_button_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(161, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "ID оборудования";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(12, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(160, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "Новый ID группы";
            // 
            // ID_label
            // 
            this.ID_label.AutoSize = true;
            this.ID_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ID_label.Location = new System.Drawing.Point(187, 9);
            this.ID_label.Name = "ID_label";
            this.ID_label.Size = new System.Drawing.Size(0, 24);
            this.ID_label.TabIndex = 3;
            // 
            // group_box
            // 
            this.group_box.Location = new System.Drawing.Point(178, 61);
            this.group_box.Name = "group_box";
            this.group_box.Size = new System.Drawing.Size(62, 20);
            this.group_box.TabIndex = 4;
            this.group_box.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.group_box_KeyPress);
            // 
            // ChangeGroupForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(253, 159);
            this.Controls.Add(this.group_box);
            this.Controls.Add(this.ID_label);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.change_group_button);
            this.Name = "ChangeGroupForm";
            this.Text = "ChangeGroupForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button change_group_button;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label ID_label;
        private System.Windows.Forms.TextBox group_box;
    }
}