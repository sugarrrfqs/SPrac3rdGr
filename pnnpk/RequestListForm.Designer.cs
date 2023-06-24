namespace pnnpk
{
    partial class RequestListForm
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
            this.open_request = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.status_box = new System.Windows.Forms.ComboBox();
            this.search_req_clear = new System.Windows.Forms.Button();
            this.search_req_id_box = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.search_req_button = new System.Windows.Forms.Button();
            this.login_label = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.request_list)).BeginInit();
            this.SuspendLayout();
            // 
            // request_list
            // 
            this.request_list.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.request_list.Location = new System.Drawing.Point(12, 133);
            this.request_list.Name = "request_list";
            this.request_list.Size = new System.Drawing.Size(560, 416);
            this.request_list.TabIndex = 1;
            this.request_list.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.request_list_CellDoubleClick);
            // 
            // open_request
            // 
            this.open_request.Location = new System.Drawing.Point(403, 106);
            this.open_request.Name = "open_request";
            this.open_request.Size = new System.Drawing.Size(169, 23);
            this.open_request.TabIndex = 24;
            this.open_request.Text = "Открыть заявку";
            this.open_request.UseVisualStyleBackColor = true;
            this.open_request.Click += new System.EventHandler(this.open_request_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(164, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 13);
            this.label3.TabIndex = 22;
            this.label3.Text = "Фильтр: Статус заявки";
            // 
            // status_box
            // 
            this.status_box.FormattingEnabled = true;
            this.status_box.Location = new System.Drawing.Point(167, 105);
            this.status_box.Name = "status_box";
            this.status_box.Size = new System.Drawing.Size(146, 21);
            this.status_box.TabIndex = 23;
            // 
            // search_req_clear
            // 
            this.search_req_clear.Location = new System.Drawing.Point(138, 105);
            this.search_req_clear.Name = "search_req_clear";
            this.search_req_clear.Size = new System.Drawing.Size(20, 20);
            this.search_req_clear.TabIndex = 43;
            this.search_req_clear.Text = "X";
            this.search_req_clear.UseVisualStyleBackColor = true;
            this.search_req_clear.Click += new System.EventHandler(this.search_req_clear_Click);
            // 
            // search_req_id_box
            // 
            this.search_req_id_box.Location = new System.Drawing.Point(16, 105);
            this.search_req_id_box.Name = "search_req_id_box";
            this.search_req_id_box.Size = new System.Drawing.Size(90, 20);
            this.search_req_id_box.TabIndex = 40;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 89);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(142, 13);
            this.label4.TabIndex = 41;
            this.label4.Text = "Поиск по номеру заявки...";
            // 
            // search_req_button
            // 
            this.search_req_button.Location = new System.Drawing.Point(112, 105);
            this.search_req_button.Name = "search_req_button";
            this.search_req_button.Size = new System.Drawing.Size(20, 20);
            this.search_req_button.TabIndex = 42;
            this.search_req_button.Text = ">";
            this.search_req_button.UseVisualStyleBackColor = true;
            this.search_req_button.Click += new System.EventHandler(this.search_req_button_Click);
            // 
            // login_label
            // 
            this.login_label.AutoSize = true;
            this.login_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.login_label.Location = new System.Drawing.Point(104, 56);
            this.login_label.Name = "login_label";
            this.login_label.Size = new System.Drawing.Size(51, 24);
            this.login_label.TabIndex = 3;
            this.login_label.Text = "login";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(15, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "Мастер:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(227, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Список заявок";
            // 
            // RequestListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 561);
            this.Controls.Add(this.search_req_clear);
            this.Controls.Add(this.search_req_button);
            this.Controls.Add(this.search_req_id_box);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.open_request);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.status_box);
            this.Controls.Add(this.login_label);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.request_list);
            this.Controls.Add(this.label1);
            this.Name = "RequestListForm";
            ((System.ComponentModel.ISupportInitialize)(this.request_list)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView request_list;
        private System.Windows.Forms.Button open_request;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox status_box;
        private System.Windows.Forms.Button search_req_clear;
        private System.Windows.Forms.TextBox search_req_id_box;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button search_req_button;
        private System.Windows.Forms.Label login_label;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}