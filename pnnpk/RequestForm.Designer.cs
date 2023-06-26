namespace pnnpk
{
    partial class RequestForm
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
            this.req_id_label = new System.Windows.Forms.Label();
            this.item_id_label = new System.Windows.Forms.Label();
            this.item_type_label = new System.Windows.Forms.Label();
            this.description_box = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.problem_box = new System.Windows.Forms.TextBox();
            this.accept_req_button = new System.Windows.Forms.Button();
            this.finish_req_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(10, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(198, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Заявка номер:";
            // 
            // req_id_label
            // 
            this.req_id_label.AutoSize = true;
            this.req_id_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.req_id_label.Location = new System.Drawing.Point(214, 13);
            this.req_id_label.Name = "req_id_label";
            this.req_id_label.Size = new System.Drawing.Size(106, 37);
            this.req_id_label.TabIndex = 1;
            this.req_id_label.Text = "req_id";
            // 
            // item_id_label
            // 
            this.item_id_label.AutoSize = true;
            this.item_id_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.item_id_label.Location = new System.Drawing.Point(217, 50);
            this.item_id_label.Name = "item_id_label";
            this.item_id_label.Size = new System.Drawing.Size(70, 24);
            this.item_id_label.TabIndex = 2;
            this.item_id_label.Text = "item_id";
            // 
            // item_type_label
            // 
            this.item_type_label.AutoSize = true;
            this.item_type_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.item_type_label.Location = new System.Drawing.Point(217, 74);
            this.item_type_label.Name = "item_type_label";
            this.item_type_label.Size = new System.Drawing.Size(90, 24);
            this.item_type_label.TabIndex = 3;
            this.item_type_label.Text = "item_type";
            // 
            // description_box
            // 
            this.description_box.Location = new System.Drawing.Point(221, 100);
            this.description_box.Multiline = true;
            this.description_box.Name = "description_box";
            this.description_box.ReadOnly = true;
            this.description_box.Size = new System.Drawing.Size(451, 53);
            this.description_box.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(12, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(160, 24);
            this.label2.TabIndex = 5;
            this.label2.Text = "Характеристика:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(12, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 24);
            this.label3.TabIndex = 6;
            this.label3.Text = "ID:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(12, 74);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(183, 24);
            this.label4.TabIndex = 7;
            this.label4.Text = "Тип оборудования:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(12, 159);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(201, 24);
            this.label5.TabIndex = 8;
            this.label5.Text = "Описание проблемы:";
            // 
            // problem_box
            // 
            this.problem_box.Location = new System.Drawing.Point(221, 159);
            this.problem_box.Multiline = true;
            this.problem_box.Name = "problem_box";
            this.problem_box.ReadOnly = true;
            this.problem_box.Size = new System.Drawing.Size(451, 164);
            this.problem_box.TabIndex = 9;
            // 
            // accept_req_button
            // 
            this.accept_req_button.Location = new System.Drawing.Point(404, 54);
            this.accept_req_button.Name = "accept_req_button";
            this.accept_req_button.Size = new System.Drawing.Size(131, 40);
            this.accept_req_button.TabIndex = 10;
            this.accept_req_button.Text = "Принять заявку";
            this.accept_req_button.UseVisualStyleBackColor = true;
            this.accept_req_button.Visible = false;
            this.accept_req_button.Click += new System.EventHandler(this.accept_req_button_Click);
            // 
            // finish_req_button
            // 
            this.finish_req_button.Location = new System.Drawing.Point(541, 54);
            this.finish_req_button.Name = "finish_req_button";
            this.finish_req_button.Size = new System.Drawing.Size(131, 40);
            this.finish_req_button.TabIndex = 11;
            this.finish_req_button.Text = "Завершить";
            this.finish_req_button.UseVisualStyleBackColor = true;
            this.finish_req_button.Visible = false;
            this.finish_req_button.Click += new System.EventHandler(this.finish_req_button_Click);
            // 
            // RequestForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 338);
            this.Controls.Add(this.finish_req_button);
            this.Controls.Add(this.accept_req_button);
            this.Controls.Add(this.problem_box);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.description_box);
            this.Controls.Add(this.item_type_label);
            this.Controls.Add(this.item_id_label);
            this.Controls.Add(this.req_id_label);
            this.Controls.Add(this.label1);
            this.Name = "RequestForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label req_id_label;
        private System.Windows.Forms.Label item_id_label;
        private System.Windows.Forms.Label item_type_label;
        private System.Windows.Forms.TextBox description_box;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox problem_box;
        private System.Windows.Forms.Button accept_req_button;
        private System.Windows.Forms.Button finish_req_button;
    }
}