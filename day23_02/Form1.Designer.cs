
namespace day23_02
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
            this.select_Fruit = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.invoice_num = new System.Windows.Forms.TextBox();
            this.output_fruit = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.select_purchase = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.input_num = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.output_how = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.output_num = new System.Windows.Forms.TextBox();
            this.btn_purchase = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.output_Time = new System.Windows.Forms.TextBox();
            this.btn_ADD = new System.Windows.Forms.Button();
            this.WaitingList = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // select_Fruit
            // 
            this.select_Fruit.FormattingEnabled = true;
            this.select_Fruit.Items.AddRange(new object[] {
            "사과",
            "배",
            "수박",
            "복숭아",
            "딸기",
            "메론",
            "바나나"});
            this.select_Fruit.Location = new System.Drawing.Point(73, 35);
            this.select_Fruit.Name = "select_Fruit";
            this.select_Fruit.Size = new System.Drawing.Size(160, 28);
            this.select_Fruit.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "과일명";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(226, 123);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 84);
            this.button1.TabIndex = 2;
            this.button1.Text = "확인";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // invoice_num
            // 
            this.invoice_num.Location = new System.Drawing.Point(529, 71);
            this.invoice_num.Name = "invoice_num";
            this.invoice_num.ReadOnly = true;
            this.invoice_num.Size = new System.Drawing.Size(190, 27);
            this.invoice_num.TabIndex = 3;
            // 
            // output_fruit
            // 
            this.output_fruit.Location = new System.Drawing.Point(487, 104);
            this.output_fruit.Name = "output_fruit";
            this.output_fruit.ReadOnly = true;
            this.output_fruit.Size = new System.Drawing.Size(107, 27);
            this.output_fruit.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(412, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "과일명";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(412, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "invoice number";
            // 
            // select_purchase
            // 
            this.select_purchase.FormattingEnabled = true;
            this.select_purchase.ItemHeight = 20;
            this.select_purchase.Items.AddRange(new object[] {
            "포장",
            "새벽배달",
            "배달",
            "예약"});
            this.select_purchase.Location = new System.Drawing.Point(89, 123);
            this.select_purchase.Name = "select_purchase";
            this.select_purchase.Size = new System.Drawing.Size(131, 84);
            this.select_purchase.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 123);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "구매방식";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 84);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 20);
            this.label5.TabIndex = 9;
            this.label5.Text = "개수";
            // 
            // input_num
            // 
            this.input_num.Location = new System.Drawing.Point(73, 81);
            this.input_num.Name = "input_num";
            this.input_num.Size = new System.Drawing.Size(247, 27);
            this.input_num.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(412, 140);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 20);
            this.label6.TabIndex = 12;
            this.label6.Text = "구매방식";
            // 
            // output_how
            // 
            this.output_how.Location = new System.Drawing.Point(487, 137);
            this.output_how.Name = "output_how";
            this.output_how.ReadOnly = true;
            this.output_how.Size = new System.Drawing.Size(232, 27);
            this.output_how.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(600, 107);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(39, 20);
            this.label7.TabIndex = 14;
            this.label7.Text = "개수";
            // 
            // output_num
            // 
            this.output_num.Location = new System.Drawing.Point(645, 104);
            this.output_num.Name = "output_num";
            this.output_num.ReadOnly = true;
            this.output_num.Size = new System.Drawing.Size(74, 27);
            this.output_num.TabIndex = 13;
            // 
            // btn_purchase
            // 
            this.btn_purchase.Location = new System.Drawing.Point(412, 170);
            this.btn_purchase.Name = "btn_purchase";
            this.btn_purchase.Size = new System.Drawing.Size(307, 37);
            this.btn_purchase.TabIndex = 15;
            this.btn_purchase.Text = "구매";
            this.btn_purchase.UseVisualStyleBackColor = true;
            this.btn_purchase.Visible = false;
            this.btn_purchase.Click += new System.EventHandler(this.btn_purchase_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(412, 42);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(95, 20);
            this.label8.TabIndex = 17;
            this.label8.Text = "invoice Time";
            // 
            // output_Time
            // 
            this.output_Time.Location = new System.Drawing.Point(529, 38);
            this.output_Time.Name = "output_Time";
            this.output_Time.ReadOnly = true;
            this.output_Time.Size = new System.Drawing.Size(190, 27);
            this.output_Time.TabIndex = 16;
            // 
            // btn_ADD
            // 
            this.btn_ADD.Location = new System.Drawing.Point(232, 33);
            this.btn_ADD.Name = "btn_ADD";
            this.btn_ADD.Size = new System.Drawing.Size(88, 32);
            this.btn_ADD.TabIndex = 18;
            this.btn_ADD.Text = "관심추가";
            this.btn_ADD.UseVisualStyleBackColor = true;
            this.btn_ADD.Click += new System.EventHandler(this.btn_ADD_Click);
            // 
            // WaitingList
            // 
            this.WaitingList.FormattingEnabled = true;
            this.WaitingList.ItemHeight = 20;
            this.WaitingList.Location = new System.Drawing.Point(12, 225);
            this.WaitingList.Name = "WaitingList";
            this.WaitingList.Size = new System.Drawing.Size(307, 164);
            this.WaitingList.TabIndex = 19;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.WaitingList);
            this.Controls.Add(this.btn_ADD);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.output_Time);
            this.Controls.Add(this.btn_purchase);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.output_num);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.output_how);
            this.Controls.Add(this.input_num);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.select_purchase);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.output_fruit);
            this.Controls.Add(this.invoice_num);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.select_Fruit);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox select_Fruit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox invoice_num;
        private System.Windows.Forms.TextBox output_fruit;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox select_purchase;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox input_num;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox output_how;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox output_num;
        private System.Windows.Forms.Button btn_purchase;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox output_Time;
        private System.Windows.Forms.Button btn_ADD;
        private System.Windows.Forms.ListBox WaitingList;
    }
}

