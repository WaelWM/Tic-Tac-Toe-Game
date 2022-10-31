
namespace TicTacToe
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.btnTic1 = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.btnTic2 = new System.Windows.Forms.Button();
            this.btnTic3 = new System.Windows.Forms.Button();
            this.btnTic4 = new System.Windows.Forms.Button();
            this.btnTic5 = new System.Windows.Forms.Button();
            this.btnTic6 = new System.Windows.Forms.Button();
            this.btnTic7 = new System.Windows.Forms.Button();
            this.btnTic8 = new System.Windows.Forms.Button();
            this.btnTic9 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.btnNewGame = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblPlayerO = new System.Windows.Forms.Label();
            this.lblPlayerX = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(88, 29);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1335, 73);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Location = new System.Drawing.Point(88, 120);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1335, 599);
            this.panel2.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Controls.Add(this.btnTic9);
            this.panel3.Controls.Add(this.btnTic6);
            this.panel3.Controls.Add(this.btnTic3);
            this.panel3.Controls.Add(this.btnTic8);
            this.panel3.Controls.Add(this.btnTic7);
            this.panel3.Controls.Add(this.btnTic5);
            this.panel3.Controls.Add(this.btnTic4);
            this.panel3.Controls.Add(this.btnTic2);
            this.panel3.Controls.Add(this.btnTic1);
            this.panel3.Location = new System.Drawing.Point(18, 12);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(613, 541);
            this.panel3.TabIndex = 0;
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel4.Controls.Add(this.panel6);
            this.panel4.Controls.Add(this.panel5);
            this.panel4.Location = new System.Drawing.Point(652, 12);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(613, 541);
            this.panel4.TabIndex = 0;
            // 
            // panel5
            // 
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel5.Controls.Add(this.lblPlayerO);
            this.panel5.Controls.Add(this.lblPlayerX);
            this.panel5.Controls.Add(this.label3);
            this.panel5.Controls.Add(this.label2);
            this.panel5.Location = new System.Drawing.Point(20, 34);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(569, 191);
            this.panel5.TabIndex = 0;
            // 
            // panel6
            // 
            this.panel6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel6.Controls.Add(this.button11);
            this.panel6.Controls.Add(this.btnNewGame);
            this.panel6.Controls.Add(this.button10);
            this.panel6.Location = new System.Drawing.Point(20, 247);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(569, 272);
            this.panel6.TabIndex = 0;
            // 
            // btnTic1
            // 
            this.btnTic1.BackColor = System.Drawing.Color.DarkGray;
            this.btnTic1.Font = new System.Drawing.Font("Times New Roman", 90F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTic1.Location = new System.Drawing.Point(15, 13);
            this.btnTic1.Name = "btnTic1";
            this.btnTic1.Size = new System.Drawing.Size(180, 158);
            this.btnTic1.TabIndex = 0;
            this.btnTic1.UseVisualStyleBackColor = false;
            this.btnTic1.Click += new System.EventHandler(this.btnTic1_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 40.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(108, -8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1014, 77);
            this.label1.TabIndex = 0;
            this.label1.Text = "Welcome to W-Tic Tac Toe Game!";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnTic2
            // 
            this.btnTic2.BackColor = System.Drawing.Color.DarkGray;
            this.btnTic2.Font = new System.Drawing.Font("Times New Roman", 90F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTic2.Location = new System.Drawing.Point(209, 13);
            this.btnTic2.Name = "btnTic2";
            this.btnTic2.Size = new System.Drawing.Size(180, 158);
            this.btnTic2.TabIndex = 0;
            this.btnTic2.UseVisualStyleBackColor = false;
            this.btnTic2.Click += new System.EventHandler(this.btnTic2_Click);
            // 
            // btnTic3
            // 
            this.btnTic3.BackColor = System.Drawing.Color.DarkGray;
            this.btnTic3.Font = new System.Drawing.Font("Times New Roman", 90F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTic3.Location = new System.Drawing.Point(403, 13);
            this.btnTic3.Name = "btnTic3";
            this.btnTic3.Size = new System.Drawing.Size(180, 158);
            this.btnTic3.TabIndex = 0;
            this.btnTic3.UseVisualStyleBackColor = false;
            this.btnTic3.Click += new System.EventHandler(this.btnTic3_Click);
            // 
            // btnTic4
            // 
            this.btnTic4.BackColor = System.Drawing.Color.DarkGray;
            this.btnTic4.Font = new System.Drawing.Font("Times New Roman", 90F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTic4.Location = new System.Drawing.Point(16, 187);
            this.btnTic4.Name = "btnTic4";
            this.btnTic4.Size = new System.Drawing.Size(180, 158);
            this.btnTic4.TabIndex = 0;
            this.btnTic4.UseVisualStyleBackColor = false;
            this.btnTic4.Click += new System.EventHandler(this.btnTic4_Click);
            // 
            // btnTic5
            // 
            this.btnTic5.BackColor = System.Drawing.Color.DarkGray;
            this.btnTic5.Font = new System.Drawing.Font("Times New Roman", 90F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTic5.Location = new System.Drawing.Point(209, 187);
            this.btnTic5.Name = "btnTic5";
            this.btnTic5.Size = new System.Drawing.Size(180, 158);
            this.btnTic5.TabIndex = 0;
            this.btnTic5.UseVisualStyleBackColor = false;
            this.btnTic5.Click += new System.EventHandler(this.btnTic5_Click);
            // 
            // btnTic6
            // 
            this.btnTic6.BackColor = System.Drawing.Color.DarkGray;
            this.btnTic6.Font = new System.Drawing.Font("Times New Roman", 90F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTic6.Location = new System.Drawing.Point(403, 187);
            this.btnTic6.Name = "btnTic6";
            this.btnTic6.Size = new System.Drawing.Size(180, 158);
            this.btnTic6.TabIndex = 0;
            this.btnTic6.UseVisualStyleBackColor = false;
            this.btnTic6.Click += new System.EventHandler(this.btnTic6_Click);
            // 
            // btnTic7
            // 
            this.btnTic7.BackColor = System.Drawing.Color.DarkGray;
            this.btnTic7.Font = new System.Drawing.Font("Times New Roman", 90F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTic7.Location = new System.Drawing.Point(16, 361);
            this.btnTic7.Name = "btnTic7";
            this.btnTic7.Size = new System.Drawing.Size(180, 158);
            this.btnTic7.TabIndex = 0;
            this.btnTic7.UseVisualStyleBackColor = false;
            this.btnTic7.Click += new System.EventHandler(this.btnTic7_Click);
            // 
            // btnTic8
            // 
            this.btnTic8.BackColor = System.Drawing.Color.DarkGray;
            this.btnTic8.Font = new System.Drawing.Font("Times New Roman", 90F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTic8.Location = new System.Drawing.Point(209, 361);
            this.btnTic8.Name = "btnTic8";
            this.btnTic8.Size = new System.Drawing.Size(180, 158);
            this.btnTic8.TabIndex = 0;
            this.btnTic8.UseVisualStyleBackColor = false;
            this.btnTic8.Click += new System.EventHandler(this.btnTic8_Click);
            // 
            // btnTic9
            // 
            this.btnTic9.BackColor = System.Drawing.Color.DarkGray;
            this.btnTic9.Font = new System.Drawing.Font("Times New Roman", 90F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTic9.Location = new System.Drawing.Point(403, 361);
            this.btnTic9.Name = "btnTic9";
            this.btnTic9.Size = new System.Drawing.Size(180, 158);
            this.btnTic9.TabIndex = 0;
            this.btnTic9.UseVisualStyleBackColor = false;
            this.btnTic9.Click += new System.EventHandler(this.btnTic9_Click);
            // 
            // button10
            // 
            this.button10.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.button10.Font = new System.Drawing.Font("Times New Roman", 49.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button10.Location = new System.Drawing.Point(10, 160);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(274, 98);
            this.button10.TabIndex = 0;
            this.button10.Text = "Reset";
            this.button10.UseVisualStyleBackColor = false;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // button11
            // 
            this.button11.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.button11.Font = new System.Drawing.Font("Times New Roman", 49.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button11.Location = new System.Drawing.Point(287, 160);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(274, 98);
            this.button11.TabIndex = 0;
            this.button11.Text = "Exit";
            this.button11.UseVisualStyleBackColor = false;
            this.button11.Click += new System.EventHandler(this.button11_Click);
            // 
            // btnNewGame
            // 
            this.btnNewGame.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnNewGame.Font = new System.Drawing.Font("Times New Roman", 49.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewGame.Location = new System.Drawing.Point(10, 34);
            this.btnNewGame.Name = "btnNewGame";
            this.btnNewGame.Size = new System.Drawing.Size(551, 98);
            this.btnNewGame.TabIndex = 0;
            this.btnNewGame.Text = "New Game";
            this.btnNewGame.UseVisualStyleBackColor = false;
            this.btnNewGame.Click += new System.EventHandler(this.button12_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 34.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(266, 67);
            this.label2.TabIndex = 0;
            this.label2.Text = "Player X:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 34.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(269, 67);
            this.label3.TabIndex = 0;
            this.label3.Text = "Player O:";
            // 
            // lblPlayerO
            // 
            this.lblPlayerO.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lblPlayerO.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblPlayerO.Font = new System.Drawing.Font("Times New Roman", 34.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayerO.Location = new System.Drawing.Point(275, 102);
            this.lblPlayerO.Name = "lblPlayerO";
            this.lblPlayerO.Size = new System.Drawing.Size(269, 67);
            this.lblPlayerO.TabIndex = 1;
            this.lblPlayerO.Text = "0";
            this.lblPlayerO.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPlayerX
            // 
            this.lblPlayerX.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lblPlayerX.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblPlayerX.Font = new System.Drawing.Font("Times New Roman", 34.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayerX.Location = new System.Drawing.Point(275, 14);
            this.lblPlayerX.Name = "lblPlayerX";
            this.lblPlayerX.Size = new System.Drawing.Size(266, 67);
            this.lblPlayerX.TabIndex = 2;
            this.lblPlayerX.Text = "0";
            this.lblPlayerX.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(29, 558);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(282, 32);
            this.label4.TabIndex = 1;
            this.label4.Text = "Developed by: Wael (¬‿¬)";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1518, 741);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Tic Tac Toe";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnTic1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnTic9;
        private System.Windows.Forms.Button btnTic6;
        private System.Windows.Forms.Button btnTic3;
        private System.Windows.Forms.Button btnTic8;
        private System.Windows.Forms.Button btnTic7;
        private System.Windows.Forms.Button btnTic5;
        private System.Windows.Forms.Button btnTic4;
        private System.Windows.Forms.Button btnTic2;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button btnNewGame;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Label lblPlayerO;
        private System.Windows.Forms.Label lblPlayerX;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
    }
}

