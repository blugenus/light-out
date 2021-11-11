
namespace FrontEnd
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Pnl_Top = new System.Windows.Forms.Panel();
            this.Btn_Disconnect = new System.Windows.Forms.Button();
            this.Btn_Connect = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Txt_Server = new System.Windows.Forms.TextBox();
            this.Pnl_Board = new System.Windows.Forms.Panel();
            this.Btn_NewGame = new System.Windows.Forms.Button();
            this.Pnl_Top.SuspendLayout();
            this.SuspendLayout();
            // 
            // Pnl_Top
            // 
            this.Pnl_Top.Controls.Add(this.Btn_NewGame);
            this.Pnl_Top.Controls.Add(this.Btn_Disconnect);
            this.Pnl_Top.Controls.Add(this.Btn_Connect);
            this.Pnl_Top.Controls.Add(this.label1);
            this.Pnl_Top.Controls.Add(this.Txt_Server);
            this.Pnl_Top.Dock = System.Windows.Forms.DockStyle.Top;
            this.Pnl_Top.Location = new System.Drawing.Point(0, 0);
            this.Pnl_Top.Name = "Pnl_Top";
            this.Pnl_Top.Size = new System.Drawing.Size(1140, 47);
            this.Pnl_Top.TabIndex = 4;
            // 
            // Btn_Disconnect
            // 
            this.Btn_Disconnect.Enabled = false;
            this.Btn_Disconnect.Location = new System.Drawing.Point(309, 12);
            this.Btn_Disconnect.Name = "Btn_Disconnect";
            this.Btn_Disconnect.Size = new System.Drawing.Size(75, 23);
            this.Btn_Disconnect.TabIndex = 7;
            this.Btn_Disconnect.Text = "Disconnect";
            this.Btn_Disconnect.UseVisualStyleBackColor = true;
            this.Btn_Disconnect.Click += new System.EventHandler(this.Btn_Disconnect_Click);
            // 
            // Btn_Connect
            // 
            this.Btn_Connect.Location = new System.Drawing.Point(228, 12);
            this.Btn_Connect.Name = "Btn_Connect";
            this.Btn_Connect.Size = new System.Drawing.Size(75, 23);
            this.Btn_Connect.TabIndex = 6;
            this.Btn_Connect.Text = "Connect";
            this.Btn_Connect.UseVisualStyleBackColor = true;
            this.Btn_Connect.Click += new System.EventHandler(this.Btn_Connect_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 15);
            this.label1.TabIndex = 5;
            this.label1.Text = "Server IP:Port";
            // 
            // Txt_Server
            // 
            this.Txt_Server.Location = new System.Drawing.Point(104, 12);
            this.Txt_Server.Name = "Txt_Server";
            this.Txt_Server.Size = new System.Drawing.Size(118, 23);
            this.Txt_Server.TabIndex = 4;
            this.Txt_Server.Text = "localhost:48243";
            // 
            // Pnl_Board
            // 
            this.Pnl_Board.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Pnl_Board.Location = new System.Drawing.Point(0, 47);
            this.Pnl_Board.Name = "Pnl_Board";
            this.Pnl_Board.Size = new System.Drawing.Size(1140, 494);
            this.Pnl_Board.TabIndex = 5;
            // 
            // Btn_NewGame
            // 
            this.Btn_NewGame.Location = new System.Drawing.Point(390, 11);
            this.Btn_NewGame.Name = "Btn_NewGame";
            this.Btn_NewGame.Size = new System.Drawing.Size(75, 23);
            this.Btn_NewGame.TabIndex = 8;
            this.Btn_NewGame.Text = "New Game";
            this.Btn_NewGame.UseVisualStyleBackColor = true;
            this.Btn_NewGame.Click += new System.EventHandler(this.Btn_NewGame_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1140, 541);
            this.Controls.Add(this.Pnl_Board);
            this.Controls.Add(this.Pnl_Top);
            this.Name = "Form1";
            this.Text = "Light Out";
            this.Pnl_Top.ResumeLayout(false);
            this.Pnl_Top.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Pnl_Top;
        private System.Windows.Forms.Button Btn_Disconnect;
        private System.Windows.Forms.Button Btn_Connect;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Txt_Server;
        private System.Windows.Forms.Panel Pnl_Board;
        private System.Windows.Forms.Button Btn_NewGame;
    }
}

