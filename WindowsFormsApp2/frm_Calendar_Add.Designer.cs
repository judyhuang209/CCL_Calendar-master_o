namespace Order
{
    partial class frm_Calendar_Add
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
            this.EventTypeList = new System.Windows.Forms.ComboBox();
            this.endTimePicker = new System.Windows.Forms.DateTimePicker();
            this.startTimePicker = new System.Windows.Forms.DateTimePicker();
            this.button_confirm = new System.Windows.Forms.Button();
            this.button_cancel = new System.Windows.Forms.Button();
            this.NoteTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.startDatePicker = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // EventTypeList
            // 
            this.EventTypeList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.EventTypeList.Font = new System.Drawing.Font("新細明體", 12F);
            this.EventTypeList.FormattingEnabled = true;
            this.EventTypeList.Location = new System.Drawing.Point(119, 176);
            this.EventTypeList.Margin = new System.Windows.Forms.Padding(4);
            this.EventTypeList.Name = "EventTypeList";
            this.EventTypeList.Size = new System.Drawing.Size(213, 24);
            this.EventTypeList.TabIndex = 17;
            // 
            // endTimePicker
            // 
            this.endTimePicker.CustomFormat = "HH:mm";
            this.endTimePicker.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.endTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.endTimePicker.Location = new System.Drawing.Point(119, 126);
            this.endTimePicker.Margin = new System.Windows.Forms.Padding(4);
            this.endTimePicker.Name = "endTimePicker";
            this.endTimePicker.ShowUpDown = true;
            this.endTimePicker.Size = new System.Drawing.Size(132, 29);
            this.endTimePicker.TabIndex = 15;
            // 
            // startTimePicker
            // 
            this.startTimePicker.CustomFormat = "HH:mm";
            this.startTimePicker.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.startTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.startTimePicker.Location = new System.Drawing.Point(119, 73);
            this.startTimePicker.Margin = new System.Windows.Forms.Padding(4);
            this.startTimePicker.Name = "startTimePicker";
            this.startTimePicker.ShowUpDown = true;
            this.startTimePicker.Size = new System.Drawing.Size(132, 29);
            this.startTimePicker.TabIndex = 16;
            // 
            // button_confirm
            // 
            this.button_confirm.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button_confirm.Location = new System.Drawing.Point(205, 286);
            this.button_confirm.Margin = new System.Windows.Forms.Padding(4);
            this.button_confirm.Name = "button_confirm";
            this.button_confirm.Size = new System.Drawing.Size(127, 33);
            this.button_confirm.TabIndex = 13;
            this.button_confirm.Text = "確定";
            this.button_confirm.UseVisualStyleBackColor = true;
            this.button_confirm.Click += new System.EventHandler(this.button_confirm_Click);
            // 
            // button_cancel
            // 
            this.button_cancel.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button_cancel.Location = new System.Drawing.Point(23, 286);
            this.button_cancel.Margin = new System.Windows.Forms.Padding(4);
            this.button_cancel.Name = "button_cancel";
            this.button_cancel.Size = new System.Drawing.Size(127, 33);
            this.button_cancel.TabIndex = 14;
            this.button_cancel.Text = "取消";
            this.button_cancel.UseVisualStyleBackColor = true;
            this.button_cancel.Click += new System.EventHandler(this.button_cancel_Click);
            // 
            // NoteTextBox
            // 
            this.NoteTextBox.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.NoteTextBox.Location = new System.Drawing.Point(119, 229);
            this.NoteTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.NoteTextBox.Name = "NoteTextBox";
            this.NoteTextBox.Size = new System.Drawing.Size(213, 29);
            this.NoteTextBox.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("微軟正黑體", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label4.Location = new System.Drawing.Point(19, 178);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 22);
            this.label4.TabIndex = 8;
            this.label4.Text = "種類：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微軟正黑體", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.Location = new System.Drawing.Point(19, 232);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 22);
            this.label3.TabIndex = 9;
            this.label3.Text = "備註：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微軟正黑體", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(19, 129);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 22);
            this.label2.TabIndex = 10;
            this.label2.Text = "結束時間：";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(19, 76);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 22);
            this.label1.TabIndex = 11;
            this.label1.Text = "開始時間：";
            // 
            // startDatePicker
            // 
            this.startDatePicker.CustomFormat = "";
            this.startDatePicker.Enabled = false;
            this.startDatePicker.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.startDatePicker.Location = new System.Drawing.Point(119, 25);
            this.startDatePicker.Margin = new System.Windows.Forms.Padding(4);
            this.startDatePicker.Name = "startDatePicker";
            this.startDatePicker.Size = new System.Drawing.Size(141, 29);
            this.startDatePicker.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("微軟正黑體", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label5.Location = new System.Drawing.Point(19, 28);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 22);
            this.label5.TabIndex = 18;
            this.label5.Text = "開始時間：";
            // 
            // frm_Calendar_Add
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(346, 341);
            this.Controls.Add(this.startDatePicker);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.EventTypeList);
            this.Controls.Add(this.endTimePicker);
            this.Controls.Add(this.startTimePicker);
            this.Controls.Add(this.button_confirm);
            this.Controls.Add(this.button_cancel);
            this.Controls.Add(this.NoteTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frm_Calendar_Add";
            this.Text = "frm_Calendar_Add";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form_add_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox EventTypeList;
        private System.Windows.Forms.DateTimePicker endTimePicker;
        private System.Windows.Forms.DateTimePicker startTimePicker;
        private System.Windows.Forms.Button button_confirm;
        private System.Windows.Forms.Button button_cancel;
        private System.Windows.Forms.TextBox NoteTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker startDatePicker;
        private System.Windows.Forms.Label label5;
    }
}