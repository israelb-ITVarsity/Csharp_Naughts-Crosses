namespace Tic_Tac_Toe
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
            this.A1 = new System.Windows.Forms.Button();
            this.B2 = new System.Windows.Forms.Button();
            this.B3 = new System.Windows.Forms.Button();
            this.C3 = new System.Windows.Forms.Button();
            this.C1 = new System.Windows.Forms.Button();
            this.B1 = new System.Windows.Forms.Button();
            this.A3 = new System.Windows.Forms.Button();
            this.A2 = new System.Windows.Forms.Button();
            this.C2 = new System.Windows.Forms.Button();
            this.winStreakLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.InputPlayerX = new System.Windows.Forms.TextBox();
            this.InputPlayerO = new System.Windows.Forms.TextBox();
            this.PlayerX = new System.Windows.Forms.Label();
            this.PlayerO = new System.Windows.Forms.Label();
            this.okBtn = new System.Windows.Forms.Button();
            this.listBox = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // A1
            // 
            this.A1.BackColor = System.Drawing.Color.DimGray;
            this.A1.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.A1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.A1.Location = new System.Drawing.Point(12, 42);
            this.A1.Name = "A1";
            this.A1.Size = new System.Drawing.Size(75, 75);
            this.A1.TabIndex = 0;
            this.A1.UseVisualStyleBackColor = false;
            this.A1.Click += new System.EventHandler(this.buttonClick);
            // 
            // B2
            // 
            this.B2.BackColor = System.Drawing.Color.DimGray;
            this.B2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.B2.Location = new System.Drawing.Point(93, 123);
            this.B2.Name = "B2";
            this.B2.Size = new System.Drawing.Size(75, 75);
            this.B2.TabIndex = 1;
            this.B2.UseVisualStyleBackColor = false;
            this.B2.Click += new System.EventHandler(this.buttonClick);
            // 
            // B3
            // 
            this.B3.BackColor = System.Drawing.Color.DimGray;
            this.B3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.B3.Location = new System.Drawing.Point(174, 123);
            this.B3.Name = "B3";
            this.B3.Size = new System.Drawing.Size(75, 75);
            this.B3.TabIndex = 2;
            this.B3.UseVisualStyleBackColor = false;
            this.B3.Click += new System.EventHandler(this.buttonClick);
            // 
            // C3
            // 
            this.C3.BackColor = System.Drawing.Color.DimGray;
            this.C3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.C3.Location = new System.Drawing.Point(174, 204);
            this.C3.Name = "C3";
            this.C3.Size = new System.Drawing.Size(75, 75);
            this.C3.TabIndex = 3;
            this.C3.UseVisualStyleBackColor = false;
            this.C3.Click += new System.EventHandler(this.buttonClick);
            // 
            // C1
            // 
            this.C1.BackColor = System.Drawing.Color.DimGray;
            this.C1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.C1.Location = new System.Drawing.Point(12, 204);
            this.C1.Name = "C1";
            this.C1.Size = new System.Drawing.Size(75, 75);
            this.C1.TabIndex = 4;
            this.C1.UseVisualStyleBackColor = false;
            this.C1.Click += new System.EventHandler(this.buttonClick);
            // 
            // B1
            // 
            this.B1.BackColor = System.Drawing.Color.DimGray;
            this.B1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.B1.Location = new System.Drawing.Point(12, 123);
            this.B1.Name = "B1";
            this.B1.Size = new System.Drawing.Size(75, 75);
            this.B1.TabIndex = 5;
            this.B1.UseVisualStyleBackColor = false;
            this.B1.Click += new System.EventHandler(this.buttonClick);
            // 
            // A3
            // 
            this.A3.BackColor = System.Drawing.Color.DimGray;
            this.A3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.A3.Location = new System.Drawing.Point(174, 42);
            this.A3.Name = "A3";
            this.A3.Size = new System.Drawing.Size(75, 75);
            this.A3.TabIndex = 6;
            this.A3.UseVisualStyleBackColor = false;
            this.A3.Click += new System.EventHandler(this.buttonClick);
            // 
            // A2
            // 
            this.A2.BackColor = System.Drawing.Color.DimGray;
            this.A2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.A2.Location = new System.Drawing.Point(93, 42);
            this.A2.Name = "A2";
            this.A2.Size = new System.Drawing.Size(75, 75);
            this.A2.TabIndex = 7;
            this.A2.UseVisualStyleBackColor = false;
            this.A2.Click += new System.EventHandler(this.buttonClick);
            // 
            // C2
            // 
            this.C2.BackColor = System.Drawing.Color.DimGray;
            this.C2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.C2.Location = new System.Drawing.Point(93, 204);
            this.C2.Name = "C2";
            this.C2.Size = new System.Drawing.Size(75, 75);
            this.C2.TabIndex = 9;
            this.C2.UseVisualStyleBackColor = false;
            this.C2.Click += new System.EventHandler(this.buttonClick);
            // 
            // winStreakLabel
            // 
            this.winStreakLabel.AutoSize = true;
            this.winStreakLabel.Location = new System.Drawing.Point(12, 306);
            this.winStreakLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.winStreakLabel.Name = "winStreakLabel";
            this.winStreakLabel.Size = new System.Drawing.Size(192, 13);
            this.winStreakLabel.TabIndex = 11;
            this.winStreakLabel.Text = "X is on a win streak of 50, click to reset";
            this.winStreakLabel.Click += new System.EventHandler(this.winStreakLabel_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(273, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Input name for \"X\"";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(410, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Input name for O";
            // 
            // InputPlayerX
            // 
            this.InputPlayerX.Location = new System.Drawing.Point(276, 70);
            this.InputPlayerX.Name = "InputPlayerX";
            this.InputPlayerX.Size = new System.Drawing.Size(100, 20);
            this.InputPlayerX.TabIndex = 14;
            this.InputPlayerX.TextChanged += new System.EventHandler(this.InputPlayerX_TextChanged);
            // 
            // InputPlayerO
            // 
            this.InputPlayerO.Location = new System.Drawing.Point(396, 70);
            this.InputPlayerO.Name = "InputPlayerO";
            this.InputPlayerO.Size = new System.Drawing.Size(100, 20);
            this.InputPlayerO.TabIndex = 15;
            this.InputPlayerO.TextChanged += new System.EventHandler(this.InputPLayerO_TextChanged);
            // 
            // PlayerX
            // 
            this.PlayerX.AutoSize = true;
            this.PlayerX.Location = new System.Drawing.Point(32, 13);
            this.PlayerX.Name = "PlayerX";
            this.PlayerX.Size = new System.Drawing.Size(35, 13);
            this.PlayerX.TabIndex = 16;
            this.PlayerX.Text = "label3";
            this.PlayerX.Click += new System.EventHandler(this.PlayerX_Click);
            // 
            // PlayerO
            // 
            this.PlayerO.AutoSize = true;
            this.PlayerO.Location = new System.Drawing.Point(165, 13);
            this.PlayerO.Name = "PlayerO";
            this.PlayerO.Size = new System.Drawing.Size(35, 13);
            this.PlayerO.TabIndex = 17;
            this.PlayerO.Text = "label4";
            // 
            // okBtn
            // 
            this.okBtn.BackColor = System.Drawing.Color.Silver;
            this.okBtn.Location = new System.Drawing.Point(347, 105);
            this.okBtn.Name = "okBtn";
            this.okBtn.Size = new System.Drawing.Size(75, 23);
            this.okBtn.TabIndex = 18;
            this.okBtn.Text = "OK";
            this.okBtn.UseVisualStyleBackColor = false;
            this.okBtn.Click += new System.EventHandler(this.okBtn_Click);
            // 
            // listBox
            // 
            this.listBox.FormattingEnabled = true;
            this.listBox.Location = new System.Drawing.Point(276, 183);
            this.listBox.Name = "listBox";
            this.listBox.Size = new System.Drawing.Size(238, 95);
            this.listBox.TabIndex = 19;
            this.listBox.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(344, 167);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 13);
            this.label3.TabIndex = 20;
            this.label3.Text = "SCOREBOARD";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(351, 296);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 21;
            this.button1.Text = "Delete";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(545, 368);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.listBox);
            this.Controls.Add(this.okBtn);
            this.Controls.Add(this.PlayerO);
            this.Controls.Add(this.PlayerX);
            this.Controls.Add(this.InputPlayerO);
            this.Controls.Add(this.InputPlayerX);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.winStreakLabel);
            this.Controls.Add(this.C2);
            this.Controls.Add(this.A2);
            this.Controls.Add(this.A3);
            this.Controls.Add(this.B1);
            this.Controls.Add(this.C1);
            this.Controls.Add(this.C3);
            this.Controls.Add(this.B3);
            this.Controls.Add(this.B2);
            this.Controls.Add(this.A1);
            this.ForeColor = System.Drawing.Color.Lime;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tic-Tac-Toe";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button A1;
        private System.Windows.Forms.Button B2;
        private System.Windows.Forms.Button B3;
        private System.Windows.Forms.Button C3;
        private System.Windows.Forms.Button C1;
        private System.Windows.Forms.Button B1;
        private System.Windows.Forms.Button A3;
        private System.Windows.Forms.Button A2;
        private System.Windows.Forms.Button C2;
        private System.Windows.Forms.Label winStreakLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox InputPlayerX;
        private System.Windows.Forms.TextBox InputPlayerO;
        private System.Windows.Forms.Label PlayerX;
        private System.Windows.Forms.Label PlayerO;
        private System.Windows.Forms.Button okBtn;
        private System.Windows.Forms.ListBox listBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
    }
}

