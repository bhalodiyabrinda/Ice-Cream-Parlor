namespace Ice_Cream_parler
{
    partial class FamilyPackOrder
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
            button1 = new Button();
            panel1 = new Panel();
            lable1 = new Label();
            comboBox3 = new ComboBox();
            comboBox2 = new ComboBox();
            comboBox1 = new ComboBox();
            textBox3 = new TextBox();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.BackColor = Color.Orchid;
            panel2.Controls.Add(label5);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(label8);
            panel2.Controls.Add(button1);
            panel2.ForeColor = Color.White;
            panel2.Location = new Point(83, 138);
            panel2.Name = "panel2";
            panel2.Size = new Size(903, 493);
            panel2.TabIndex = 19;
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
            lable1.Location = new Point(225, 17);
            lable1.Name = "lable1";
            lable1.Size = new Size(627, 74);
            lable1.TabIndex = 0;
            lable1.Text = "Family Pack Order";
            // 
            // comboBox3
            // 
            comboBox3.FormattingEnabled = true;
            comboBox3.Items.AddRange(new object[] { "Family Pack" });
            comboBox3.Location = new Point(528, 218);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new Size(235, 28);
            comboBox3.TabIndex = 27;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Items.AddRange(new object[] { "₹ 120/-" });
            comboBox2.Location = new Point(528, 401);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(235, 28);
            comboBox2.TabIndex = 26;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Crunchy Butterscotch", "Choco Brownie", "Fruit Bonaza", "Kasar Pista", "Staawberry", "Black Currant" });
            comboBox1.Location = new Point(528, 279);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(235, 28);
            comboBox1.TabIndex = 25;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(528, 341);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(235, 27);
            textBox3.TabIndex = 24;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.White;
            label5.Location = new Point(274, 267);
            label5.Name = "label5";
            label5.Size = new Size(62, 28);
            label5.TabIndex = 11;
            label5.Text = "Piece";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.White;
            label6.Location = new Point(274, 203);
            label6.Name = "label6";
            label6.Size = new Size(87, 28);
            label6.TabIndex = 10;
            label6.Text = "Adderss";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.White;
            label7.Location = new Point(274, 141);
            label7.Name = "label7";
            label7.Size = new Size(82, 28);
            label7.TabIndex = 9;
            label7.Text = "Flavour";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.White;
            label8.Location = new Point(269, 80);
            label8.Name = "label8";
            label8.Size = new Size(160, 28);
            label8.TabIndex = 8;
            label8.Text = "Packaging Type";
            // 
            // FamilyPackOrder
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Plum;
            ClientSize = new Size(1082, 643);
            Controls.Add(comboBox3);
            Controls.Add(comboBox2);
            Controls.Add(comboBox1);
            Controls.Add(textBox3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "FamilyPackOrder";
            Text = "FamilyPackOrder";
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel2;
        private Button button1;
        private Panel panel1;
        private Label lable1;
        private ComboBox comboBox3;
        private ComboBox comboBox2;
        private ComboBox comboBox1;
        private TextBox textBox3;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
    }
}