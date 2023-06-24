namespace pnnpk
{
    partial class AddItemForm
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
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.description_box = new System.Windows.Forms.TextBox();
            this.browse_button = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.count_box = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.price_box = new System.Windows.Forms.TextBox();
            this.add_button = new System.Windows.Forms.Button();
            this.cancel_button = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.sum_label = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.type_box = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(270, 31);
            this.label1.TabIndex = 4;
            this.label1.Text = "Добавление товара:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(14, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(160, 24);
            this.label2.TabIndex = 7;
            this.label2.Text = "Характеристика:";
            // 
            // description_box
            // 
            this.description_box.Location = new System.Drawing.Point(180, 88);
            this.description_box.Multiline = true;
            this.description_box.Name = "description_box";
            this.description_box.ReadOnly = true;
            this.description_box.Size = new System.Drawing.Size(403, 53);
            this.description_box.TabIndex = 6;
            // 
            // browse_button
            // 
            this.browse_button.Location = new System.Drawing.Point(589, 101);
            this.browse_button.Name = "browse_button";
            this.browse_button.Size = new System.Drawing.Size(30, 30);
            this.browse_button.TabIndex = 8;
            this.browse_button.Text = "...";
            this.browse_button.UseVisualStyleBackColor = true;
            this.browse_button.Click += new System.EventHandler(this.browse_button_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(14, 152);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 24);
            this.label3.TabIndex = 10;
            this.label3.Text = "Количество:";
            // 
            // count_box
            // 
            this.count_box.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.count_box.Location = new System.Drawing.Point(180, 152);
            this.count_box.Name = "count_box";
            this.count_box.Size = new System.Drawing.Size(70, 27);
            this.count_box.TabIndex = 9;
            this.count_box.TextChanged += new System.EventHandler(this.RecalculateSum);
            this.count_box.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.count_box_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(14, 186);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 24);
            this.label4.TabIndex = 12;
            this.label4.Text = "Цена:";
            // 
            // price_box
            // 
            this.price_box.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.price_box.Location = new System.Drawing.Point(180, 186);
            this.price_box.Name = "price_box";
            this.price_box.Size = new System.Drawing.Size(108, 27);
            this.price_box.TabIndex = 11;
            this.price_box.TextChanged += new System.EventHandler(this.RecalculateSum);
            this.price_box.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.price_box_KeyPress);
            // 
            // add_button
            // 
            this.add_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.add_button.Location = new System.Drawing.Point(404, 215);
            this.add_button.Name = "add_button";
            this.add_button.Size = new System.Drawing.Size(106, 29);
            this.add_button.TabIndex = 13;
            this.add_button.Text = "Добавить";
            this.add_button.UseVisualStyleBackColor = true;
            this.add_button.Click += new System.EventHandler(this.add_button_Click);
            // 
            // cancel_button
            // 
            this.cancel_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cancel_button.Location = new System.Drawing.Point(516, 215);
            this.cancel_button.Name = "cancel_button";
            this.cancel_button.Size = new System.Drawing.Size(106, 29);
            this.cancel_button.TabIndex = 14;
            this.cancel_button.Text = "Отменить";
            this.cancel_button.UseVisualStyleBackColor = true;
            this.cancel_button.Click += new System.EventHandler(this.cancel_button_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(14, 215);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 24);
            this.label5.TabIndex = 15;
            this.label5.Text = "Итого:";
            // 
            // sum_label
            // 
            this.sum_label.AutoSize = true;
            this.sum_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.sum_label.ForeColor = System.Drawing.Color.Red;
            this.sum_label.Location = new System.Drawing.Point(176, 220);
            this.sum_label.Name = "sum_label";
            this.sum_label.Size = new System.Drawing.Size(46, 24);
            this.sum_label.TabIndex = 16;
            this.sum_label.Text = "sum";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(14, 52);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(117, 24);
            this.label6.TabIndex = 24;
            this.label6.Text = "Тип товара:";
            // 
            // type_box
            // 
            this.type_box.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.type_box.FormattingEnabled = true;
            this.type_box.Location = new System.Drawing.Point(180, 52);
            this.type_box.Name = "type_box";
            this.type_box.Size = new System.Drawing.Size(146, 28);
            this.type_box.TabIndex = 25;
            this.type_box.TextChanged += new System.EventHandler(this.type_box_TextChanged);
            // 
            // AddItemForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(634, 254);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.type_box);
            this.Controls.Add(this.sum_label);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cancel_button);
            this.Controls.Add(this.add_button);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.price_box);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.count_box);
            this.Controls.Add(this.browse_button);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.description_box);
            this.Controls.Add(this.label1);
            this.Name = "AddItemForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button browse_button;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox count_box;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox price_box;
        private System.Windows.Forms.Button add_button;
        private System.Windows.Forms.Button cancel_button;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label sum_label;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox type_box;
        public System.Windows.Forms.TextBox description_box;
    }
}