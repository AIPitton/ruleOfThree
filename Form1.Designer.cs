namespace ruleOfThree
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.x11 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.x12 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.x21 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.resultRuleOfThree = new System.Windows.Forms.Label();
            this.bttnResultRuleOfThree = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.resultRuleOfThreeDouble = new System.Windows.Forms.Label();
            this.d11 = new System.Windows.Forms.TextBox();
            this.d12 = new System.Windows.Forms.TextBox();
            this.d13 = new System.Windows.Forms.TextBox();
            this.d21 = new System.Windows.Forms.TextBox();
            this.d22 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.bttn_CalcDouble = new System.Windows.Forms.Button();
            this.bttnReset = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Garamond", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(158, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(258, 14);
            this.label1.TabIndex = 0;
            this.label1.Text = "ENTER VALUE EXPRESSED IN X UNITS";
            // 
            // x11
            // 
            this.x11.Font = new System.Drawing.Font("Garamond", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.x11.Location = new System.Drawing.Point(316, 45);
            this.x11.Name = "x11";
            this.x11.Size = new System.Drawing.Size(100, 22);
            this.x11.TabIndex = 1;
            this.x11.TextChanged += new System.EventHandler(this.x11_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Garamond", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(549, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(258, 14);
            this.label2.TabIndex = 2;
            this.label2.Text = "ENTER VALUE EXPRESSED IN Y UNITS";
            // 
            // x12
            // 
            this.x12.Font = new System.Drawing.Font("Garamond", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.x12.Location = new System.Drawing.Point(707, 45);
            this.x12.Name = "x12";
            this.x12.Size = new System.Drawing.Size(100, 22);
            this.x12.TabIndex = 3;
            this.x12.TextChanged += new System.EventHandler(this.x12_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Garamond", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(158, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(258, 14);
            this.label3.TabIndex = 4;
            this.label3.Text = "ENTER VALUE EXPRESSED IN X UNITS";
            // 
            // x21
            // 
            this.x21.Font = new System.Drawing.Font("Garamond", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.x21.Location = new System.Drawing.Point(316, 123);
            this.x21.Name = "x21";
            this.x21.Size = new System.Drawing.Size(100, 22);
            this.x21.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Garamond", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(549, 97);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(265, 14);
            this.label4.TabIndex = 6;
            this.label4.Text = "THE RESULT EXPRESSED IN Y UNITS IS:";
            // 
            // resultRuleOfThree
            // 
            this.resultRuleOfThree.AutoSize = true;
            this.resultRuleOfThree.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.resultRuleOfThree.Font = new System.Drawing.Font("Garamond", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resultRuleOfThree.Location = new System.Drawing.Point(707, 123);
            this.resultRuleOfThree.Name = "resultRuleOfThree";
            this.resultRuleOfThree.Size = new System.Drawing.Size(2, 20);
            this.resultRuleOfThree.TabIndex = 7;
            this.resultRuleOfThree.Click += new System.EventHandler(this.resultRuleOfThree_Click);
            // 
            // bttnResultRuleOfThree
            // 
            this.bttnResultRuleOfThree.Font = new System.Drawing.Font("Garamond", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttnResultRuleOfThree.Location = new System.Drawing.Point(549, 123);
            this.bttnResultRuleOfThree.Name = "bttnResultRuleOfThree";
            this.bttnResultRuleOfThree.Size = new System.Drawing.Size(97, 30);
            this.bttnResultRuleOfThree.TabIndex = 8;
            this.bttnResultRuleOfThree.Text = "Calculate";
            this.bttnResultRuleOfThree.UseVisualStyleBackColor = true;
            this.bttnResultRuleOfThree.Click += new System.EventHandler(this.bttnResultRuleOfThree_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Garamond", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(29, 213);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(258, 14);
            this.label5.TabIndex = 9;
            this.label5.Text = "ENTER VALUE EXPRESSED IN X UNITS";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Garamond", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(29, 281);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(258, 14);
            this.label6.TabIndex = 10;
            this.label6.Text = "ENTER VALUE EXPRESSED IN X UNITS";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Garamond", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(400, 281);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(258, 14);
            this.label7.TabIndex = 11;
            this.label7.Text = "ENTER VALUE EXPRESSED IN Y UNITS";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Garamond", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(400, 213);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(258, 14);
            this.label8.TabIndex = 12;
            this.label8.Text = "ENTER VALUE EXPRESSED IN Y UNITS";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Garamond", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(724, 213);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(258, 14);
            this.label9.TabIndex = 13;
            this.label9.Text = "ENTER VALUE EXPRESSED IN Z UNITS";
            // 
            // resultRuleOfThreeDouble
            // 
            this.resultRuleOfThreeDouble.AutoSize = true;
            this.resultRuleOfThreeDouble.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.resultRuleOfThreeDouble.Font = new System.Drawing.Font("Garamond", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resultRuleOfThreeDouble.Location = new System.Drawing.Point(876, 328);
            this.resultRuleOfThreeDouble.Name = "resultRuleOfThreeDouble";
            this.resultRuleOfThreeDouble.Size = new System.Drawing.Size(2, 20);
            this.resultRuleOfThreeDouble.TabIndex = 14;
            this.resultRuleOfThreeDouble.Click += new System.EventHandler(this.resultRuleOfThreeDouble_Click);
            // 
            // d11
            // 
            this.d11.Font = new System.Drawing.Font("Garamond", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.d11.Location = new System.Drawing.Point(187, 242);
            this.d11.Name = "d11";
            this.d11.Size = new System.Drawing.Size(100, 22);
            this.d11.TabIndex = 15;
            this.d11.TextChanged += new System.EventHandler(this.d11_TextChanged);
            // 
            // d12
            // 
            this.d12.Font = new System.Drawing.Font("Garamond", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.d12.Location = new System.Drawing.Point(549, 242);
            this.d12.Name = "d12";
            this.d12.Size = new System.Drawing.Size(100, 22);
            this.d12.TabIndex = 16;
            this.d12.TextChanged += new System.EventHandler(this.d12_TextChanged);
            // 
            // d13
            // 
            this.d13.Font = new System.Drawing.Font("Garamond", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.d13.Location = new System.Drawing.Point(876, 242);
            this.d13.Name = "d13";
            this.d13.Size = new System.Drawing.Size(100, 22);
            this.d13.TabIndex = 17;
            this.d13.TextChanged += new System.EventHandler(this.d13_TextChanged);
            // 
            // d21
            // 
            this.d21.Font = new System.Drawing.Font("Garamond", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.d21.Location = new System.Drawing.Point(187, 328);
            this.d21.Name = "d21";
            this.d21.Size = new System.Drawing.Size(100, 22);
            this.d21.TabIndex = 18;
            this.d21.TextChanged += new System.EventHandler(this.d21_TextChanged);
            // 
            // d22
            // 
            this.d22.Font = new System.Drawing.Font("Garamond", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.d22.Location = new System.Drawing.Point(552, 328);
            this.d22.Name = "d22";
            this.d22.Size = new System.Drawing.Size(100, 22);
            this.d22.TabIndex = 19;
            this.d22.TextChanged += new System.EventHandler(this.d22_TextChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Garamond", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(724, 281);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(265, 14);
            this.label10.TabIndex = 20;
            this.label10.Text = "THE RESULT EXPRESSED IN Z UNITS IS:";
            // 
            // bttn_CalcDouble
            // 
            this.bttn_CalcDouble.Font = new System.Drawing.Font("Garamond", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttn_CalcDouble.Location = new System.Drawing.Point(726, 328);
            this.bttn_CalcDouble.Name = "bttn_CalcDouble";
            this.bttn_CalcDouble.Size = new System.Drawing.Size(88, 34);
            this.bttn_CalcDouble.TabIndex = 21;
            this.bttn_CalcDouble.Text = "Calculate";
            this.bttn_CalcDouble.UseVisualStyleBackColor = true;
            this.bttn_CalcDouble.Click += new System.EventHandler(this.bttn_CalcDouble_Click);
            // 
            // bttnReset
            // 
            this.bttnReset.Font = new System.Drawing.Font("Garamond", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttnReset.Location = new System.Drawing.Point(32, 406);
            this.bttnReset.Name = "bttnReset";
            this.bttnReset.Size = new System.Drawing.Size(123, 35);
            this.bttnReset.TabIndex = 22;
            this.bttnReset.Text = "Reset All Fields";
            this.bttnReset.UseVisualStyleBackColor = true;
            this.bttnReset.Click += new System.EventHandler(this.bttnReset_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1011, 465);
            this.Controls.Add(this.bttnReset);
            this.Controls.Add(this.bttn_CalcDouble);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.d22);
            this.Controls.Add(this.d21);
            this.Controls.Add(this.d13);
            this.Controls.Add(this.d12);
            this.Controls.Add(this.d11);
            this.Controls.Add(this.resultRuleOfThreeDouble);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.bttnResultRuleOfThree);
            this.Controls.Add(this.resultRuleOfThree);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.x21);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.x12);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.x11);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Rule of three. Double rule of three.";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox x11;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox x12;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox x21;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label resultRuleOfThree;
        private System.Windows.Forms.Button bttnResultRuleOfThree;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label resultRuleOfThreeDouble;
        private System.Windows.Forms.TextBox d11;
        private System.Windows.Forms.TextBox d12;
        private System.Windows.Forms.TextBox d13;
        private System.Windows.Forms.TextBox d21;
        private System.Windows.Forms.TextBox d22;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button bttn_CalcDouble;
        private System.Windows.Forms.Button bttnReset;
    }
}

