namespace CustomerQueueManagementApp
{
    partial class Form1
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.nameEnqueueTextBox = new System.Windows.Forms.TextBox();
            this.complainEnqueueTextBox = new System.Windows.Forms.TextBox();
            this.serialDequeueTextBox = new System.Windows.Forms.TextBox();
            this.nameDequeueTextBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.complainDequeueTextBox = new System.Windows.Forms.TextBox();
            this.enqueueButton = new System.Windows.Forms.Button();
            this.dequeueButton = new System.Windows.Forms.Button();
            this.customerListView = new System.Windows.Forms.ListView();
            this.serial = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Customer Enqueue";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 135);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Complain";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(280, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Customer Dequeue";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(301, 76);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Serial";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(301, 125);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Name";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(13, 258);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(78, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Waiting Queue";
            // 
            // nameEnqueueTextBox
            // 
            this.nameEnqueueTextBox.Location = new System.Drawing.Point(79, 76);
            this.nameEnqueueTextBox.Name = "nameEnqueueTextBox";
            this.nameEnqueueTextBox.Size = new System.Drawing.Size(100, 20);
            this.nameEnqueueTextBox.TabIndex = 7;
            this.nameEnqueueTextBox.TextChanged += new System.EventHandler(this.nameEnqueueTextBox_TextChanged);
            // 
            // complainEnqueueTextBox
            // 
            this.complainEnqueueTextBox.Location = new System.Drawing.Point(79, 132);
            this.complainEnqueueTextBox.Name = "complainEnqueueTextBox";
            this.complainEnqueueTextBox.Size = new System.Drawing.Size(100, 20);
            this.complainEnqueueTextBox.TabIndex = 8;
            // 
            // serialDequeueTextBox
            // 
            this.serialDequeueTextBox.Location = new System.Drawing.Point(356, 69);
            this.serialDequeueTextBox.Name = "serialDequeueTextBox";
            this.serialDequeueTextBox.Size = new System.Drawing.Size(100, 20);
            this.serialDequeueTextBox.TabIndex = 9;
            // 
            // nameDequeueTextBox
            // 
            this.nameDequeueTextBox.Location = new System.Drawing.Point(356, 118);
            this.nameDequeueTextBox.Name = "nameDequeueTextBox";
            this.nameDequeueTextBox.Size = new System.Drawing.Size(100, 20);
            this.nameDequeueTextBox.TabIndex = 10;
            this.nameDequeueTextBox.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(304, 167);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(50, 13);
            this.label8.TabIndex = 11;
            this.label8.Text = "Complain";
            // 
            // complainDequeueTextBox
            // 
            this.complainDequeueTextBox.Location = new System.Drawing.Point(356, 167);
            this.complainDequeueTextBox.Name = "complainDequeueTextBox";
            this.complainDequeueTextBox.Size = new System.Drawing.Size(100, 20);
            this.complainDequeueTextBox.TabIndex = 12;
            // 
            // enqueueButton
            // 
            this.enqueueButton.Location = new System.Drawing.Point(185, 74);
            this.enqueueButton.Name = "enqueueButton";
            this.enqueueButton.Size = new System.Drawing.Size(75, 23);
            this.enqueueButton.TabIndex = 13;
            this.enqueueButton.Text = "Enqueue";
            this.enqueueButton.UseVisualStyleBackColor = true;
            this.enqueueButton.Click += new System.EventHandler(this.enqueueButton_Click);
            // 
            // dequeueButton
            // 
            this.dequeueButton.Location = new System.Drawing.Point(495, 69);
            this.dequeueButton.Name = "dequeueButton";
            this.dequeueButton.Size = new System.Drawing.Size(75, 23);
            this.dequeueButton.TabIndex = 14;
            this.dequeueButton.Text = "Dequeue";
            this.dequeueButton.UseVisualStyleBackColor = true;
            this.dequeueButton.Click += new System.EventHandler(this.button2_Click);
            // 
            // customerListView
            // 
            this.customerListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.serial,
            this.columnHeader1,
            this.columnHeader2});
            this.customerListView.GridLines = true;
            this.customerListView.Location = new System.Drawing.Point(26, 302);
            this.customerListView.Name = "customerListView";
            this.customerListView.Size = new System.Drawing.Size(529, 168);
            this.customerListView.TabIndex = 15;
            this.customerListView.UseCompatibleStateImageBehavior = false;
            this.customerListView.View = System.Windows.Forms.View.Details;
            this.customerListView.SelectedIndexChanged += new System.EventHandler(this.customerListView_SelectedIndexChanged);
            // 
            // serial
            // 
            this.serial.Text = "serial";
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Name";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(598, 515);
            this.Controls.Add(this.customerListView);
            this.Controls.Add(this.dequeueButton);
            this.Controls.Add(this.enqueueButton);
            this.Controls.Add(this.complainDequeueTextBox);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.nameDequeueTextBox);
            this.Controls.Add(this.serialDequeueTextBox);
            this.Controls.Add(this.complainEnqueueTextBox);
            this.Controls.Add(this.nameEnqueueTextBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox nameEnqueueTextBox;
        private System.Windows.Forms.TextBox complainEnqueueTextBox;
        private System.Windows.Forms.TextBox serialDequeueTextBox;
        private System.Windows.Forms.TextBox nameDequeueTextBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox complainDequeueTextBox;
        private System.Windows.Forms.Button enqueueButton;
        private System.Windows.Forms.Button dequeueButton;
        private System.Windows.Forms.ListView customerListView;
        private System.Windows.Forms.ColumnHeader serial;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
    }
}

