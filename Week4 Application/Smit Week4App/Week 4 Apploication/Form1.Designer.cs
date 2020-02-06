namespace Week_4_Apploication
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Divide = new System.Windows.Forms.RadioButton();
            this.Subtract = new System.Windows.Forms.RadioButton();
            this.Multiply = new System.Windows.Forms.RadioButton();
            this.Add = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.Imdone = new System.Windows.Forms.Button();
            this.Amiright = new System.Windows.Forms.Button();
            this.Nextquestion = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.Output = new System.Windows.Forms.Label();
            this.Solution = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.AutoSize = true;
            this.groupBox1.Controls.Add(this.Divide);
            this.groupBox1.Controls.Add(this.Subtract);
            this.groupBox1.Controls.Add(this.Multiply);
            this.groupBox1.Controls.Add(this.Add);
            this.groupBox1.Font = new System.Drawing.Font("Comic Sans MS", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(862, 164);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Select An Equation Type";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // Divide
            // 
            this.Divide.AutoSize = true;
            this.Divide.Location = new System.Drawing.Point(720, 65);
            this.Divide.Name = "Divide";
            this.Divide.Size = new System.Drawing.Size(124, 39);
            this.Divide.TabIndex = 1;
            this.Divide.TabStop = true;
            this.Divide.Text = "Division";
            this.Divide.UseVisualStyleBackColor = true;
            this.Divide.CheckedChanged += new System.EventHandler(this.radioButton4_CheckedChanged);
            // 
            // Subtract
            // 
            this.Subtract.AutoSize = true;
            this.Subtract.Location = new System.Drawing.Point(206, 65);
            this.Subtract.Name = "Subtract";
            this.Subtract.Size = new System.Drawing.Size(183, 39);
            this.Subtract.TabIndex = 1;
            this.Subtract.TabStop = true;
            this.Subtract.Text = "Substraction";
            this.Subtract.UseVisualStyleBackColor = true;
            this.Subtract.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // Multiply
            // 
            this.Multiply.AutoSize = true;
            this.Multiply.Location = new System.Drawing.Point(465, 65);
            this.Multiply.Name = "Multiply";
            this.Multiply.Size = new System.Drawing.Size(190, 39);
            this.Multiply.TabIndex = 0;
            this.Multiply.TabStop = true;
            this.Multiply.Text = "Multiplication";
            this.Multiply.UseVisualStyleBackColor = true;
            this.Multiply.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            // 
            // Add
            // 
            this.Add.AutoSize = true;
            this.Add.Location = new System.Drawing.Point(16, 65);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(133, 39);
            this.Add.TabIndex = 0;
            this.Add.TabStop = true;
            this.Add.Text = "Addition";
            this.Add.UseVisualStyleBackColor = true;
            this.Add.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.textBox3);
            this.groupBox2.Controls.Add(this.textBox2);
            this.groupBox2.Controls.Add(this.textBox1);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Font = new System.Drawing.Font("Comic Sans MS", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(12, 182);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(862, 98);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Can you answer this question?";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(625, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 35);
            this.label3.TabIndex = 5;
            this.label3.Text = "=";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(720, 38);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 40);
            this.textBox3.TabIndex = 4;
            this.textBox3.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(418, 38);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 40);
            this.textBox2.TabIndex = 3;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(62, 38);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 40);
            this.textBox1.TabIndex = 2;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(272, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 35);
            this.label2.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(106, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 35);
            this.label1.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.Imdone);
            this.groupBox3.Controls.Add(this.Amiright);
            this.groupBox3.Controls.Add(this.Nextquestion);
            this.groupBox3.Location = new System.Drawing.Point(12, 299);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(862, 100);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            // 
            // Imdone
            // 
            this.Imdone.Font = new System.Drawing.Font("Comic Sans MS", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Imdone.Location = new System.Drawing.Point(668, 30);
            this.Imdone.Name = "Imdone";
            this.Imdone.Size = new System.Drawing.Size(152, 45);
            this.Imdone.TabIndex = 2;
            this.Imdone.Text = "I\'m Done";
            this.Imdone.UseVisualStyleBackColor = true;
            this.Imdone.Click += new System.EventHandler(this.button3_Click);
            // 
            // Amiright
            // 
            this.Amiright.AutoSize = true;
            this.Amiright.Font = new System.Drawing.Font("Comic Sans MS", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Amiright.Location = new System.Drawing.Point(349, 30);
            this.Amiright.Name = "Amiright";
            this.Amiright.Size = new System.Drawing.Size(169, 45);
            this.Amiright.TabIndex = 1;
            this.Amiright.Text = "Am I Right?";
            this.Amiright.UseVisualStyleBackColor = true;
            this.Amiright.Click += new System.EventHandler(this.button2_Click);
            // 
            // Nextquestion
            // 
            this.Nextquestion.AutoSize = true;
            this.Nextquestion.Font = new System.Drawing.Font("Comic Sans MS", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Nextquestion.Location = new System.Drawing.Point(16, 30);
            this.Nextquestion.Name = "Nextquestion";
            this.Nextquestion.Size = new System.Drawing.Size(186, 45);
            this.Nextquestion.TabIndex = 0;
            this.Nextquestion.Text = "Next question";
            this.Nextquestion.UseVisualStyleBackColor = true;
            this.Nextquestion.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.AutoSize = true;
            this.groupBox4.Controls.Add(this.Output);
            this.groupBox4.Controls.Add(this.Solution);
            this.groupBox4.Location = new System.Drawing.Point(12, 405);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(862, 90);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Enter += new System.EventHandler(this.groupBox4_Enter);
            // 
            // Output
            // 
            this.Output.AutoSize = true;
            this.Output.Font = new System.Drawing.Font("Comic Sans MS", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Output.Location = new System.Drawing.Point(423, 39);
            this.Output.Name = "Output";
            this.Output.Size = new System.Drawing.Size(22, 33);
            this.Output.TabIndex = 1;
            this.Output.Text = " ";
            this.Output.Click += new System.EventHandler(this.Output_Click);
            // 
            // Solution
            // 
            this.Solution.AutoSize = true;
            this.Solution.Font = new System.Drawing.Font("Comic Sans MS", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Solution.Location = new System.Drawing.Point(98, 39);
            this.Solution.Name = "Solution";
            this.Solution.Size = new System.Drawing.Size(0, 33);
            this.Solution.TabIndex = 0;
            this.Solution.Click += new System.EventHandler(this.Solution_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(886, 507);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "QuickMath";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton Divide;
        private System.Windows.Forms.RadioButton Subtract;
        private System.Windows.Forms.RadioButton Multiply;
        private System.Windows.Forms.RadioButton Add;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button Imdone;
        private System.Windows.Forms.Button Amiright;
        private System.Windows.Forms.Button Nextquestion;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label Solution;
        private System.Windows.Forms.Label Output;
    }
}

