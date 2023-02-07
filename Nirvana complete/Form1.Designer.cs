namespace Nirvana1._0
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
            this.massBox1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tempBox1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.materialBox1 = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.materialBox2 = new System.Windows.Forms.ComboBox();
            this.tempBox2 = new System.Windows.Forms.TextBox();
            this.massBox2 = new System.Windows.Forms.TextBox();
            this.calculateButton = new System.Windows.Forms.Button();
            this.stateBox1 = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.stateBox2 = new System.Windows.Forms.ComboBox();
            this.lblAnswer = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Monotxt_IV25", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(204, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(364, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Welcome to Nirvana 1.0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Monotxt_IV25", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(88, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(168, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Input Mass 1 (g)";
            // 
            // massBox1
            // 
            this.massBox1.Location = new System.Drawing.Point(91, 117);
            this.massBox1.Name = "massBox1";
            this.massBox1.Size = new System.Drawing.Size(175, 20);
            this.massBox1.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Monotxt_IV25", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(55, 171);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(248, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Input Initial Temp 1 (C)";
            // 
            // tempBox1
            // 
            this.tempBox1.Location = new System.Drawing.Point(91, 208);
            this.tempBox1.Name = "tempBox1";
            this.tempBox1.Size = new System.Drawing.Size(175, 20);
            this.tempBox1.TabIndex = 4;
            this.tempBox1.TextChanged += new System.EventHandler(this.TempBox1_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Monotxt_IV25", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(98, 256);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(158, 16);
            this.label4.TabIndex = 5;
            this.label4.Text = "Select Material";
            // 
            // materialBox1
            // 
            this.materialBox1.FormattingEnabled = true;
            this.materialBox1.Items.AddRange(new object[] {
            "Water",
            "Ethyl Alchohol",
            "Lead",
            "Aluminum",
            "Silver",
            "Gold",
            "Copper",
            "Ice",
            "Steam"});
            this.materialBox1.Location = new System.Drawing.Point(91, 292);
            this.materialBox1.Name = "materialBox1";
            this.materialBox1.Size = new System.Drawing.Size(175, 21);
            this.materialBox1.TabIndex = 6;
            this.materialBox1.SelectedIndexChanged += new System.EventHandler(this.MaterialBox1_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Monotxt_IV25", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(489, 84);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(168, 16);
            this.label5.TabIndex = 7;
            this.label5.Text = "Input Mass 2 (g)";
            this.label5.Click += new System.EventHandler(this.Label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Monotxt_IV25", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(452, 171);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(248, 16);
            this.label6.TabIndex = 8;
            this.label6.Text = "Input Initial Temp 2 (C)";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Monotxt_IV25", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(499, 256);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(158, 16);
            this.label7.TabIndex = 9;
            this.label7.Text = "Select Material";
            // 
            // materialBox2
            // 
            this.materialBox2.FormattingEnabled = true;
            this.materialBox2.Items.AddRange(new object[] {
            "Water",
            "Ethyl Alchohol",
            "Lead",
            "Aluminum",
            "Silver",
            "Gold",
            "Copper",
            "Ice",
            "Steam"});
            this.materialBox2.Location = new System.Drawing.Point(492, 292);
            this.materialBox2.Name = "materialBox2";
            this.materialBox2.Size = new System.Drawing.Size(175, 21);
            this.materialBox2.TabIndex = 10;
            this.materialBox2.SelectedIndexChanged += new System.EventHandler(this.MaterialBox2_SelectedIndexChanged);
            // 
            // tempBox2
            // 
            this.tempBox2.Location = new System.Drawing.Point(492, 207);
            this.tempBox2.Name = "tempBox2";
            this.tempBox2.Size = new System.Drawing.Size(175, 20);
            this.tempBox2.TabIndex = 11;
            // 
            // massBox2
            // 
            this.massBox2.Location = new System.Drawing.Point(492, 117);
            this.massBox2.Name = "massBox2";
            this.massBox2.Size = new System.Drawing.Size(175, 20);
            this.massBox2.TabIndex = 12;
            // 
            // calculateButton
            // 
            this.calculateButton.Font = new System.Drawing.Font("Monotxt_IV25", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calculateButton.Location = new System.Drawing.Point(310, 344);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(126, 50);
            this.calculateButton.TabIndex = 13;
            this.calculateButton.Text = "Calculate";
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.CalculateButton_Click);
            // 
            // stateBox1
            // 
            this.stateBox1.FormattingEnabled = true;
            this.stateBox1.Items.AddRange(new object[] {
            "S",
            "L",
            "G"});
            this.stateBox1.Location = new System.Drawing.Point(151, 374);
            this.stateBox1.Name = "stateBox1";
            this.stateBox1.Size = new System.Drawing.Size(49, 21);
            this.stateBox1.TabIndex = 14;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Monotxt_IV25", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(78, 344);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(198, 16);
            this.label8.TabIndex = 15;
            this.label8.Text = "State of Material 1";
            this.label8.Click += new System.EventHandler(this.Label8_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Monotxt_IV25", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(480, 344);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(198, 16);
            this.label9.TabIndex = 16;
            this.label9.Text = "State of Material 1";
            // 
            // stateBox2
            // 
            this.stateBox2.FormattingEnabled = true;
            this.stateBox2.Items.AddRange(new object[] {
            "S",
            "L",
            "G"});
            this.stateBox2.Location = new System.Drawing.Point(557, 374);
            this.stateBox2.Name = "stateBox2";
            this.stateBox2.Size = new System.Drawing.Size(49, 21);
            this.stateBox2.TabIndex = 17;
            // 
            // lblAnswer
            // 
            this.lblAnswer.AutoSize = true;
            this.lblAnswer.Font = new System.Drawing.Font("Monotxt_IV25", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAnswer.Location = new System.Drawing.Point(334, 397);
            this.lblAnswer.Name = "lblAnswer";
            this.lblAnswer.Size = new System.Drawing.Size(68, 16);
            this.lblAnswer.TabIndex = 18;
            this.lblAnswer.Text = "Answer";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(408, 397);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(18, 13);
            this.label10.TabIndex = 19;
            this.label10.Text = "*C";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.lblAnswer);
            this.Controls.Add(this.stateBox2);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.stateBox1);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.massBox2);
            this.Controls.Add(this.tempBox2);
            this.Controls.Add(this.materialBox2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.materialBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tempBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.massBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Nirvana1.0";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox massBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tempBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox materialBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox materialBox2;
        private System.Windows.Forms.TextBox tempBox2;
        private System.Windows.Forms.TextBox massBox2;
        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.ComboBox stateBox1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox stateBox2;
        private System.Windows.Forms.Label lblAnswer;
        private System.Windows.Forms.Label label10;
    }
}

