namespace Labyrinth
{
    partial class LabirinthForm
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
            this.btn_GenerateLab = new System.Windows.Forms.Button();
            this.btn_Move_Up = new System.Windows.Forms.Button();
            this.btn_Move_Down = new System.Windows.Forms.Button();
            this.btn_Move_Left = new System.Windows.Forms.Button();
            this.btn_Move_Right = new System.Windows.Forms.Button();
            this.rtb_Labirinth = new System.Windows.Forms.RichTextBox();
            this.PlayerLabel = new System.Windows.Forms.Label();
            this.rtb_PlayerStats = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // btn_GenerateLab
            // 
            this.btn_GenerateLab.Location = new System.Drawing.Point(6, 3);
            this.btn_GenerateLab.Name = "btn_GenerateLab";
            this.btn_GenerateLab.Size = new System.Drawing.Size(74, 37);
            this.btn_GenerateLab.TabIndex = 0;
            this.btn_GenerateLab.Text = "Начать игру";
            this.btn_GenerateLab.UseVisualStyleBackColor = true;
            this.btn_GenerateLab.Click += new System.EventHandler(this.btn_GenerateLab_Click);
            // 
            // btn_Move_Up
            // 
            this.btn_Move_Up.Location = new System.Drawing.Point(62, 106);
            this.btn_Move_Up.Name = "btn_Move_Up";
            this.btn_Move_Up.Size = new System.Drawing.Size(63, 24);
            this.btn_Move_Up.TabIndex = 1;
            this.btn_Move_Up.Text = "Up";
            this.btn_Move_Up.UseVisualStyleBackColor = true;
            this.btn_Move_Up.Click += new System.EventHandler(this.btn_Move_Up_Click);
            // 
            // btn_Move_Down
            // 
            this.btn_Move_Down.Location = new System.Drawing.Point(62, 190);
            this.btn_Move_Down.Name = "btn_Move_Down";
            this.btn_Move_Down.Size = new System.Drawing.Size(63, 23);
            this.btn_Move_Down.TabIndex = 2;
            this.btn_Move_Down.Text = "Down";
            this.btn_Move_Down.UseVisualStyleBackColor = true;
            this.btn_Move_Down.Click += new System.EventHandler(this.btn_Move_Down_Click);
            // 
            // btn_Move_Left
            // 
            this.btn_Move_Left.Location = new System.Drawing.Point(8, 148);
            this.btn_Move_Left.Name = "btn_Move_Left";
            this.btn_Move_Left.Size = new System.Drawing.Size(48, 23);
            this.btn_Move_Left.TabIndex = 3;
            this.btn_Move_Left.Text = "Left";
            this.btn_Move_Left.UseVisualStyleBackColor = true;
            this.btn_Move_Left.Click += new System.EventHandler(this.btn_Move_Left_Click);
            // 
            // btn_Move_Right
            // 
            this.btn_Move_Right.Location = new System.Drawing.Point(131, 148);
            this.btn_Move_Right.Name = "btn_Move_Right";
            this.btn_Move_Right.Size = new System.Drawing.Size(48, 23);
            this.btn_Move_Right.TabIndex = 4;
            this.btn_Move_Right.Text = "Right";
            this.btn_Move_Right.UseVisualStyleBackColor = true;
            this.btn_Move_Right.Click += new System.EventHandler(this.btn_Move_Right_Click);
            // 
            // rtb_Labirinth
            // 
            this.rtb_Labirinth.Location = new System.Drawing.Point(62, 136);
            this.rtb_Labirinth.Name = "rtb_Labirinth";
            this.rtb_Labirinth.Size = new System.Drawing.Size(63, 48);
            this.rtb_Labirinth.TabIndex = 5;
            this.rtb_Labirinth.Text = "";
            // 
            // PlayerLabel
            // 
            this.PlayerLabel.AutoSize = true;
            this.PlayerLabel.Location = new System.Drawing.Point(253, 15);
            this.PlayerLabel.Name = "PlayerLabel";
            this.PlayerLabel.Size = new System.Drawing.Size(61, 13);
            this.PlayerLabel.TabIndex = 6;
            this.PlayerLabel.Text = "Player stats";
            // 
            // rtb_PlayerStats
            // 
            this.rtb_PlayerStats.Location = new System.Drawing.Point(217, 31);
            this.rtb_PlayerStats.Name = "rtb_PlayerStats";
            this.rtb_PlayerStats.Size = new System.Drawing.Size(141, 57);
            this.rtb_PlayerStats.TabIndex = 7;
            this.rtb_PlayerStats.Text = "";
            // 
            // LabirinthForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(380, 326);
            this.Controls.Add(this.rtb_PlayerStats);
            this.Controls.Add(this.PlayerLabel);
            this.Controls.Add(this.rtb_Labirinth);
            this.Controls.Add(this.btn_Move_Right);
            this.Controls.Add(this.btn_Move_Left);
            this.Controls.Add(this.btn_Move_Down);
            this.Controls.Add(this.btn_Move_Up);
            this.Controls.Add(this.btn_GenerateLab);
            this.Name = "LabirinthForm";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_GenerateLab;
        private System.Windows.Forms.Button btn_Move_Up;
        private System.Windows.Forms.Button btn_Move_Down;
        private System.Windows.Forms.Button btn_Move_Left;
        private System.Windows.Forms.Button btn_Move_Right;
        private System.Windows.Forms.RichTextBox rtb_Labirinth;
        private System.Windows.Forms.Label PlayerLabel;
        private System.Windows.Forms.RichTextBox rtb_PlayerStats;
    }
}

