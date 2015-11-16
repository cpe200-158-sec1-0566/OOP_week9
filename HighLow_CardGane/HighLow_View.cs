using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HighLow_CardGane
{
    public partial class HighLow_View : Form
    {

        HighLow_Controller highLow_Controller = new HighLow_Controller();
        HighLow_Model highLow_Model = new HighLow_Model();

        string[] player_text = new string [2];
        bool checkgameend = false;

        public HighLow_View()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if(highLow_Controller.clicked()&& checkgameend == false)
            {
                player_text = highLow_Model.process_game();

                //set text
                Card_P1.Text = player_text[0];
                Card_P2.Text = player_text[1];

                if(player_text[0] == "Player1 Win!!"|| player_text[1] == "Player1 Loss!!")
                { checkgameend = true; }
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void HighLow_View_Load(object sender, EventArgs e)
        {

        }
    }
}
