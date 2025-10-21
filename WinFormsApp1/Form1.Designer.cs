namespace WinFormsApp1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            dateTimePicker1 = new DateTimePicker();
            button1 = new Button();
            label2 = new Label();
            label3 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(66, 76);
            label1.Name = "label1";
            label1.Size = new Size(84, 19);
            label1.TabIndex = 0;
            label1.Text = "請選擇生日";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(66, 135);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(250, 27);
            dateTimePicker1.TabIndex = 1;
            dateTimePicker1.ValueChanged += dateTimePicker1_ValueChanged;
            // 
            // button1
            // 
            button1.Location = new Point(66, 267);
            button1.Name = "button1";
            button1.Size = new Size(103, 46);
            button1.TabIndex = 2;
            button1.Text = "分析結果";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(437, 76);
            label2.Name = "label2";
            label2.Size = new Size(54, 19);
            label2.TabIndex = 3;
            label2.Text = "關於你";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(437, 119);
            label3.Name = "label3";
            label3.Size = new Size(99, 19);
            label3.TabIndex = 4;
            label3.Text = "你的星座是：";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(button1);
            Controls.Add(dateTimePicker1);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DateTimePicker dateTimePicker1;
        private Button button1;
        private Label label2;
        private Label label3;
    }
}
