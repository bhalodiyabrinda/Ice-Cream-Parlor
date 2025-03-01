namespace Ice_Cream_parler
{
    partial class CupsOrder
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
            panel2 = new Panel();
            comboBox3 = new ComboBox();
            comboBox2 = new ComboBox();
            comboBox1 = new ComboBox();
            textBox3 = new TextBox();
            label4 = new Label();
            label2 = new Label();
            button1 = new Button();
            label3 = new Label();
            label1 = new Label();
            panel1 = new Panel();
            lable1 = new Label();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.BackColor = Color.Orchid;
            panel2.Controls.Add(comboBox3);
            panel2.Controls.Add(comboBox2);
            panel2.Controls.Add(comboBox1);
            panel2.Controls.Add(textBox3);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(button1);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label1);
            panel2.ForeColor = Color.White;
            panel2.Location = new Point(83, 138);
            panel2.Name = "panel2";
            panel2.Size = new Size(903, 493);
            panel2.TabIndex = 19;
            // 
            // comboBox3
            // 
            comboBox3.FormattingEnabled = true;
            comboBox3.Items.AddRange(new object[] { "Cups" });
            comboBox3.Location = new Point(441, 86);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new Size(235, 28);
            comboBox3.TabIndex = 17;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Items.AddRange(new object[] { "₹ 40/-" });
            comboBox2.Location = new Point(441, 269);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(235, 28);
            comboBox2.TabIndex = 16;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Chocolate Cup", "Strawberry Cup", "Mango Cup", "American Nuts Cup", "Vanilla Cup", "Kesar Cup" });
            comboBox1.Location = new Point(441, 147);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(235, 28);
            comboBox1.TabIndex = 15;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(441, 209);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(235, 27);
            textBox3.TabIndex = 9;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.White;
            label4.Location = new Point(237, 269);
            label4.Name = "label4";
            label4.Size = new Size(62, 28);
            label4.TabIndex = 7;
            label4.Text = "Piece";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(237, 205);
            label2.Name = "label2";
            label2.Size = new Size(87, 28);
            label2.TabIndex = 6;
            label2.Text = "Adderss";
            // 
            // button1
            // 
            button1.BackColor = Color.Purple;
            button1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(324, 364);
            button1.Name = "button1";
            button1.Size = new Size(217, 62);
            button1.TabIndex = 5;
            button1.Text = "Place Order";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(237, 143);
            label3.Name = "label3";
            label3.Size = new Size(82, 28);
            label3.TabIndex = 3;
            label3.Text = "Flavour";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(232, 82);
            label1.Name = "label1";
            label1.Size = new Size(160, 28);
            label1.TabIndex = 1;
            label1.Text = "Packaging Type";
            // 
            // panel1
            // 
            panel1.BackColor = Color.Purple;
            panel1.Controls.Add(lable1);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(1058, 108);
            panel1.TabIndex = 18;
            // 
            // lable1
            // 
            lable1.AutoSize = true;
            lable1.Font = new Font("Showcard Gothic", 36F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lable1.ForeColor = SystemColors.ButtonHighlight;
            lable1.Location = new Point(327, 17);
            lable1.Name = "lable1";
            lable1.Size = new Size(390, 74);
            lable1.TabIndex = 0;
            lable1.Text = "Cups Order";
            // 
            // CupsOrder
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Plum;
            ClientSize = new Size(1082, 643);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "CupsOrder";
            Text = "CupsOrder";
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel2;
        private ComboBox comboBox1;
        private TextBox textBox3;
        private Label label4;
        private Label label2;
        private Button button1;
        private Label label3;
        private Label label1;
        private Panel panel1;
        private Label lable1;
        private ComboBox comboBox2;
        private ComboBox comboBox3;
    }
}