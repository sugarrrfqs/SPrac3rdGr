namespace pnnpk
{
    partial class ChangeEmpForm
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
            this.cancel_button = new System.Windows.Forms.Button();
            this.change_button = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.emp_id_label = new System.Windows.Forms.Label();
            this.emp_name_label = new System.Windows.Forms.Label();
            this.emp_new_name_label = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.emp_new_id_box = new System.Windows.Forms.TextBox();
            this.browse_emp_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cancel_button
            // 
            this.cancel_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cancel_button.Location = new System.Drawing.Point(267, 181);
            this.cancel_button.Name = "cancel_button";
            this.cancel_button.Size = new System.Drawing.Size(106, 29);
            this.cancel_button.TabIndex = 35;
            this.cancel_button.Text = "Отменить";
            this.cancel_button.UseVisualStyleBackColor = true;
            this.cancel_button.Click += new System.EventHandler(this.cancel_button_Click);
            // 
            // change_button
            // 
            this.change_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.change_button.Location = new System.Drawing.Point(155, 181);
            this.change_button.Name = "change_button";
            this.change_button.Size = new System.Drawing.Size(106, 29);
            this.change_button.TabIndex = 34;
            this.change_button.Text = "Сохранить";
            this.change_button.UseVisualStyleBackColor = true;
            this.change_button.Click += new System.EventHandler(this.change_button_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(287, 31);
            this.label1.TabIndex = 26;
            this.label1.Text = "Смена пользователя:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(14, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(163, 24);
            this.label3.TabIndex = 56;
            this.label3.Text = "ID пользователя:";
            // 
            // emp_id_label
            // 
            this.emp_id_label.AutoSize = true;
            this.emp_id_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.emp_id_label.Location = new System.Drawing.Point(183, 50);
            this.emp_id_label.Name = "emp_id_label";
            this.emp_id_label.Size = new System.Drawing.Size(73, 24);
            this.emp_id_label.TabIndex = 55;
            this.emp_id_label.Text = "emp_id";
            // 
            // emp_name_label
            // 
            this.emp_name_label.AutoSize = true;
            this.emp_name_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.emp_name_label.Location = new System.Drawing.Point(14, 74);
            this.emp_name_label.Name = "emp_name_label";
            this.emp_name_label.Size = new System.Drawing.Size(106, 24);
            this.emp_name_label.TabIndex = 57;
            this.emp_name_label.Text = "emp_name";
            // 
            // emp_new_name_label
            // 
            this.emp_new_name_label.AutoSize = true;
            this.emp_new_name_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.emp_new_name_label.Location = new System.Drawing.Point(14, 137);
            this.emp_new_name_label.Name = "emp_new_name_label";
            this.emp_new_name_label.Size = new System.Drawing.Size(152, 24);
            this.emp_new_name_label.TabIndex = 60;
            this.emp_new_name_label.Text = "emp_new_name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(14, 113);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(232, 24);
            this.label4.TabIndex = 59;
            this.label4.Text = "ID нового пользователя:";
            // 
            // emp_new_id_box
            // 
            this.emp_new_id_box.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.emp_new_id_box.Location = new System.Drawing.Point(252, 113);
            this.emp_new_id_box.Name = "emp_new_id_box";
            this.emp_new_id_box.Size = new System.Drawing.Size(85, 27);
            this.emp_new_id_box.TabIndex = 61;
            // 
            // browse_emp_button
            // 
            this.browse_emp_button.Location = new System.Drawing.Point(343, 112);
            this.browse_emp_button.Name = "browse_emp_button";
            this.browse_emp_button.Size = new System.Drawing.Size(30, 30);
            this.browse_emp_button.TabIndex = 62;
            this.browse_emp_button.Text = "...";
            this.browse_emp_button.UseVisualStyleBackColor = true;
            this.browse_emp_button.Click += new System.EventHandler(this.browse_emp_button_Click);
            // 
            // ChangeEmpForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(381, 217);
            this.Controls.Add(this.browse_emp_button);
            this.Controls.Add(this.emp_new_id_box);
            this.Controls.Add(this.emp_new_name_label);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.emp_name_label);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.emp_id_label);
            this.Controls.Add(this.cancel_button);
            this.Controls.Add(this.change_button);
            this.Controls.Add(this.label1);
            this.Name = "ChangeEmpForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button cancel_button;
        private System.Windows.Forms.Button change_button;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label emp_id_label;
        private System.Windows.Forms.Label emp_name_label;
        private System.Windows.Forms.Label emp_new_name_label;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox emp_new_id_box;
        private System.Windows.Forms.Button browse_emp_button;
    }
}