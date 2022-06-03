namespace GUI
{
    partial class Server_
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
            this.lbPlayers = new System.Windows.Forms.Label();
            this.btnListen = new System.Windows.Forms.Button();
            this.tbCountPlayer = new System.Windows.Forms.TextBox();
            this.lbTitle = new System.Windows.Forms.Label();
            this.btnDisable = new System.Windows.Forms.Button();
            this.btnRank = new System.Windows.Forms.Button();
            this.lbClose = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbPlayers
            // 
            this.lbPlayers.AutoSize = true;
            this.lbPlayers.Font = new System.Drawing.Font("Rockwell Condensed", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPlayers.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.lbPlayers.Location = new System.Drawing.Point(12, 178);
            this.lbPlayers.Name = "lbPlayers";
            this.lbPlayers.Size = new System.Drawing.Size(71, 30);
            this.lbPlayers.TabIndex = 0;
            this.lbPlayers.Text = "Players";
            // 
            // btnListen
            // 
            this.btnListen.BackColor = System.Drawing.Color.Purple;
            this.btnListen.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnListen.Font = new System.Drawing.Font("Rockwell Condensed", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnListen.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.btnListen.Location = new System.Drawing.Point(12, 75);
            this.btnListen.Name = "btnListen";
            this.btnListen.Size = new System.Drawing.Size(112, 46);
            this.btnListen.TabIndex = 2;
            this.btnListen.Text = "Listen";
            this.btnListen.UseVisualStyleBackColor = false;
            // 
            // tbCountPlayer
            // 
            this.tbCountPlayer.Font = new System.Drawing.Font("Rockwell Condensed", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbCountPlayer.ForeColor = System.Drawing.Color.DodgerBlue;
            this.tbCountPlayer.Location = new System.Drawing.Point(89, 178);
            this.tbCountPlayer.Name = "tbCountPlayer";
            this.tbCountPlayer.ReadOnly = true;
            this.tbCountPlayer.Size = new System.Drawing.Size(100, 33);
            this.tbCountPlayer.TabIndex = 3;
            // 
            // lbTitle
            // 
            this.lbTitle.AutoSize = true;
            this.lbTitle.Font = new System.Drawing.Font("Rockwell Condensed", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitle.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.lbTitle.Location = new System.Drawing.Point(44, 18);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(258, 35);
            this.lbTitle.TabIndex = 0;
            this.lbTitle.Text = "Sokuban_server Manager";
            // 
            // btnDisable
            // 
            this.btnDisable.BackColor = System.Drawing.Color.Purple;
            this.btnDisable.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDisable.Font = new System.Drawing.Font("Rockwell Condensed", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDisable.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.btnDisable.Location = new System.Drawing.Point(233, 75);
            this.btnDisable.Name = "btnDisable";
            this.btnDisable.Size = new System.Drawing.Size(112, 46);
            this.btnDisable.TabIndex = 2;
            this.btnDisable.Text = "Disable";
            this.btnDisable.UseVisualStyleBackColor = false;
            // 
            // btnRank
            // 
            this.btnRank.BackColor = System.Drawing.Color.Purple;
            this.btnRank.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRank.Font = new System.Drawing.Font("Rockwell Condensed", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRank.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.btnRank.Location = new System.Drawing.Point(215, 170);
            this.btnRank.Name = "btnRank";
            this.btnRank.Size = new System.Drawing.Size(112, 46);
            this.btnRank.TabIndex = 2;
            this.btnRank.Text = "Rank";
            this.btnRank.UseVisualStyleBackColor = false;
            // 
            // lbClose
            // 
            this.lbClose.AutoSize = true;
            this.lbClose.Font = new System.Drawing.Font("OCR A Extended", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbClose.ForeColor = System.Drawing.Color.Aqua;
            this.lbClose.Location = new System.Drawing.Point(324, 5);
            this.lbClose.Name = "lbClose";
            this.lbClose.Size = new System.Drawing.Size(37, 35);
            this.lbClose.TabIndex = 4;
            this.lbClose.Text = "X";
            this.lbClose.Click += new System.EventHandler(this.lbClose_Click);
            this.lbClose.MouseEnter += new System.EventHandler(this.lbClose_MouseEnter);
            this.lbClose.MouseLeave += new System.EventHandler(this.lbClose_MouseLeave);
            // 
            // Server_
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Indigo;
            this.ClientSize = new System.Drawing.Size(360, 254);
            this.Controls.Add(this.lbClose);
            this.Controls.Add(this.tbCountPlayer);
            this.Controls.Add(this.btnRank);
            this.Controls.Add(this.btnDisable);
            this.Controls.Add(this.btnListen);
            this.Controls.Add(this.lbTitle);
            this.Controls.Add(this.lbPlayers);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Server_";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Server_";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbPlayers;
        private System.Windows.Forms.Button btnListen;
        private System.Windows.Forms.TextBox tbCountPlayer;
        private System.Windows.Forms.Label lbTitle;
        private System.Windows.Forms.Button btnDisable;
        private System.Windows.Forms.Button btnRank;
        private System.Windows.Forms.Label lbClose;
    }
}