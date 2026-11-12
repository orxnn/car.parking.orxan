namespace car.parking.orxan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            panel1 = new Panel();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            button1 = new Button();
            flowLayoutPanel1 = new FlowLayoutPanel();
            flowLayoutPanel2 = new FlowLayoutPanel();
            flowLayoutPanel3 = new FlowLayoutPanel();
            flowLayoutPanel4 = new FlowLayoutPanel();
            flowLayoutPanel5 = new FlowLayoutPanel();
            pictureBox1 = new PictureBox();
            panel1.SuspendLayout();
            flowLayoutPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Black;
            panel1.Controls.Add(button1);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label3);
            panel1.Location = new Point(12, 9);
            panel1.Name = "panel1";
            panel1.Size = new Size(856, 48);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.White;
            label1.Location = new Point(20, 14);
            label1.Name = "label1";
            label1.Size = new Size(33, 20);
            label1.TabIndex = 1;
            label1.Text = "Xal:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.White;
            label2.Location = new Point(59, 14);
            label2.Name = "label2";
            label2.Size = new Size(17, 20);
            label2.TabIndex = 2;
            label2.Text = "0";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.White;
            label3.Location = new Point(123, 14);
            label3.Name = "label3";
            label3.Size = new Size(40, 20);
            label3.TabIndex = 3;
            label3.Text = "Vaxt:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.White;
            label4.Location = new Point(169, 14);
            label4.Name = "label4";
            label4.Size = new Size(17, 20);
            label4.TabIndex = 4;
            label4.Text = "0";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.White;
            label5.Location = new Point(205, 14);
            label5.Name = "label5";
            label5.Size = new Size(31, 20);
            label5.TabIndex = 5;
            label5.Text = "san";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Gray;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label6.ForeColor = Color.Lime;
            label6.Location = new Point(350, 89);
            label6.Name = "label6";
            label6.Size = new Size(165, 28);
            label6.TabIndex = 6;
            label6.Text = "Duzgun park +1";
            // 
            // button1
            // 
            button1.Location = new Point(696, 10);
            button1.Name = "button1";
            button1.Size = new Size(143, 29);
            button1.TabIndex = 7;
            button1.Text = "Yeni Oyun";
            button1.UseVisualStyleBackColor = true;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Location = new Point(134, 149);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(114, 164);
            flowLayoutPanel1.TabIndex = 7;
            // 
            // flowLayoutPanel2
            // 
            flowLayoutPanel2.Location = new Point(254, 149);
            flowLayoutPanel2.Name = "flowLayoutPanel2";
            flowLayoutPanel2.Size = new Size(114, 164);
            flowLayoutPanel2.TabIndex = 8;
            // 
            // flowLayoutPanel3
            // 
            flowLayoutPanel3.Location = new Point(374, 149);
            flowLayoutPanel3.Name = "flowLayoutPanel3";
            flowLayoutPanel3.Size = new Size(114, 164);
            flowLayoutPanel3.TabIndex = 8;
            // 
            // flowLayoutPanel4
            // 
            flowLayoutPanel4.Controls.Add(pictureBox1);
            flowLayoutPanel4.Location = new Point(494, 149);
            flowLayoutPanel4.Name = "flowLayoutPanel4";
            flowLayoutPanel4.Size = new Size(114, 164);
            flowLayoutPanel4.TabIndex = 8;
            // 
            // flowLayoutPanel5
            // 
            flowLayoutPanel5.Location = new Point(614, 149);
            flowLayoutPanel5.Name = "flowLayoutPanel5";
            flowLayoutPanel5.Size = new Size(114, 164);
            flowLayoutPanel5.TabIndex = 8;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(3, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(86, 110);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DimGray;
            ClientSize = new Size(880, 560);
            Controls.Add(flowLayoutPanel2);
            Controls.Add(flowLayoutPanel3);
            Controls.Add(flowLayoutPanel4);
            Controls.Add(flowLayoutPanel5);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(label6);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            flowLayoutPanel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Button button1;
        private FlowLayoutPanel flowLayoutPanel1;
        private FlowLayoutPanel flowLayoutPanel2;
        private FlowLayoutPanel flowLayoutPanel3;
        private FlowLayoutPanel flowLayoutPanel4;
        private PictureBox pictureBox1;
        private FlowLayoutPanel flowLayoutPanel5;
    }
}
