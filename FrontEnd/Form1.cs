using FrontEnd.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrontEnd
{
    public partial class Form1 : Form
    {
        private CurrentGame GameControl;
        public Form1()
        {
            InitializeComponent();
            GameControl = new CurrentGame(this.Pnl_Board);
            SetDisonnectedUI();
        }

        private void Btn_Connect_Click(object sender, EventArgs e)
        {
            Connect();
        }

        private void Btn_Disconnect_Click(object sender, EventArgs e)
        {
            Disconnect();
        }

        private void Btn_NewGame_Click(object sender, EventArgs e)
        {
            Connect();
        }

        private async void Connect()
        {
            string Url = "http://" + this.Txt_Server.Text + "/api/game";
            SetConnectingUI();
            Stream GameStream;
            try
            {
                GameStream = await ClsHttp.GetUrl(Url);
            }
            catch (System.Net.Http.HttpRequestException Exception)
            {
                MessageBox.Show(Exception.Message, "Connection Error", MessageBoxButtons.OK);
                Disconnect();
                return;
            }

            SetConnectedUI();
            // TODO: Validation of NewGame
            Game NewGame = await JsonSerializer.DeserializeAsync<Game>(GameStream);
            GameControl.NewGame(NewGame);
        }

        private void Disconnect()
        {
            SetDisonnectedUI();
            GameControl.ResetBoard();
        }

        private void SetConnectingUI()
        {
            this.Txt_Server.Enabled = false;
            this.Btn_Connect.Enabled = false;
            this.Btn_Disconnect.Enabled = false;
            this.Btn_NewGame.Enabled = false;
        }

        private void SetConnectedUI()
        {
            this.Txt_Server.Enabled = false;
            this.Btn_Connect.Enabled = false;
            this.Btn_Disconnect.Enabled = true;
            this.Btn_NewGame.Enabled = true;
        }

        private void SetDisonnectedUI()
        {
            this.Txt_Server.Enabled = true;
            this.Btn_Connect.Enabled = true;
            this.Btn_Disconnect.Enabled = false;
            this.Btn_NewGame.Enabled = false;
        }

    }
}
