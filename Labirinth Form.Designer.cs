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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_GenerateLab
            // 
            this.btn_GenerateLab.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_GenerateLab.Location = new System.Drawing.Point(12, 12);
            this.btn_GenerateLab.Name = "btn_GenerateLab";
            this.btn_GenerateLab.Size = new System.Drawing.Size(99, 58);
            this.btn_GenerateLab.TabIndex = 0;
            this.btn_GenerateLab.Text = "Начать игру";
            this.btn_GenerateLab.UseVisualStyleBackColor = true;
            this.btn_GenerateLab.Click += new System.EventHandler(this.btn_GenerateLab_Click);
            // 
            // btn_Move_Up
            // 
            this.btn_Move_Up.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_Move_Up.Location = new System.Drawing.Point(65, 143);
            this.btn_Move_Up.Name = "btn_Move_Up";
            this.btn_Move_Up.Size = new System.Drawing.Size(74, 39);
            this.btn_Move_Up.TabIndex = 1;
            this.btn_Move_Up.Text = "Up";
            this.btn_Move_Up.UseVisualStyleBackColor = true;
            this.btn_Move_Up.Click += new System.EventHandler(this.btn_Move_Up_Click);
            // 
            // btn_Move_Down
            // 
            this.btn_Move_Down.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_Move_Down.Location = new System.Drawing.Point(65, 230);
            this.btn_Move_Down.Name = "btn_Move_Down";
            this.btn_Move_Down.Size = new System.Drawing.Size(74, 31);
            this.btn_Move_Down.TabIndex = 2;
            this.btn_Move_Down.Text = "Down";
            this.btn_Move_Down.UseVisualStyleBackColor = true;
            this.btn_Move_Down.Click += new System.EventHandler(this.btn_Move_Down_Click);
            // 
            // btn_Move_Left
            // 
            this.btn_Move_Left.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_Move_Left.Location = new System.Drawing.Point(23, 188);
            this.btn_Move_Left.Name = "btn_Move_Left";
            this.btn_Move_Left.Size = new System.Drawing.Size(63, 36);
            this.btn_Move_Left.TabIndex = 3;
            this.btn_Move_Left.Text = "Left";
            this.btn_Move_Left.UseVisualStyleBackColor = true;
            this.btn_Move_Left.Click += new System.EventHandler(this.btn_Move_Left_Click);
            // 
            // btn_Move_Right
            // 
            this.btn_Move_Right.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_Move_Right.Location = new System.Drawing.Point(115, 188);
            this.btn_Move_Right.Name = "btn_Move_Right";
            this.btn_Move_Right.Size = new System.Drawing.Size(62, 36);
            this.btn_Move_Right.TabIndex = 4;
            this.btn_Move_Right.Text = "Right";
            this.btn_Move_Right.UseVisualStyleBackColor = true;
            this.btn_Move_Right.Click += new System.EventHandler(this.btn_Move_Right_Click);
            // 
            // rtb_Labirinth
            // 
            this.rtb_Labirinth.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rtb_Labirinth.Location = new System.Drawing.Point(39, 13);
            this.rtb_Labirinth.Name = "rtb_Labirinth";
            this.rtb_Labirinth.Size = new System.Drawing.Size(120, 106);
            this.rtb_Labirinth.TabIndex = 5;
            this.rtb_Labirinth.Text = "";
            // 
            // PlayerLabel
            // 
            this.PlayerLabel.AutoSize = true;
            this.PlayerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PlayerLabel.Location = new System.Drawing.Point(8, 100);
            this.PlayerLabel.Name = "PlayerLabel";
            this.PlayerLabel.Size = new System.Drawing.Size(91, 20);
            this.PlayerLabel.TabIndex = 6;
            this.PlayerLabel.Text = "Player stats";
            // 
            // rtb_PlayerStats
            // 
            this.rtb_PlayerStats.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rtb_PlayerStats.Location = new System.Drawing.Point(12, 123);
            this.rtb_PlayerStats.Name = "rtb_PlayerStats";
            this.rtb_PlayerStats.Size = new System.Drawing.Size(99, 164);
            this.rtb_PlayerStats.TabIndex = 7;
            this.rtb_PlayerStats.Text = "";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Info;
            this.panel1.Controls.Add(this.rtb_Labirinth);
            this.panel1.Controls.Add(this.btn_Move_Up);
            this.panel1.Controls.Add(this.btn_Move_Right);
            this.panel1.Controls.Add(this.btn_Move_Down);
            this.panel1.Controls.Add(this.btn_Move_Left);
            this.panel1.Location = new System.Drawing.Point(117, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 275);
            this.panel1.TabIndex = 8;
            // 
            // LabirinthForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(330, 299);
            this.Controls.Add(this.PlayerLabel);
            this.Controls.Add(this.rtb_PlayerStats);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btn_GenerateLab);
            this.Name = "LabirinthForm";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
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
        private System.Windows.Forms.Panel panel1;
    }
}

