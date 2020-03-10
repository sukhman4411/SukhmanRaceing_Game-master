using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace SukhmanRaceing_Game
{
    public partial class Form1 : Form
    {
        Ground obj = new Ground();
        Better1 bet1 = new Better1();
        Better2 bet2 = new Better2();
        Batter3 bet3 = new Batter3();


        int won = 0;

        public Form1()
        {
            InitializeComponent();
        }

        
      

      

        public void reset()
        {
            car1.Top = 0;
            car2.Top = 0;
            car3.Top = 0;
            car4.Top = 0;
            nm.Value = 0;

            
            btnStart.Enabled = false;


            foreach (int i in cbCar.CheckedIndices)
            {
                cbCar.SetItemCheckState(i, CheckState.Unchecked);
            }
        }
        private void timer1_Tick(object sender, EventArgs e)
        {

            if (car1.Top > 220 || car2.Top > 220 || car3.Top > 220 || car4.Top > 220)
            {

                timer1.Stop();

                if (car1.Top > 220)
                {
                    won = 1;
                    obj.victory(cbPlayer, won);
                }
                else if (car2.Top > 220)
                {
                    won = 2;
                    obj.victory(cbPlayer, won);
                }
                else if (car3.Top > 220)
                {
                    won = 3;
                    obj.victory(cbPlayer, won);
                }
                else if (car4.Top > 220)
                {
                    won = 4;
                    obj.victory(cbPlayer, won);
                }
                MessageBox.Show("The car number " + won + " Come on First");
                reset();
            }
            else
            {
                car1.Top += obj.generateRandomNo();
                car2.Top += obj.generateRandomNo();
                car3.Top += obj.generateRandomNo();
                car4.Top += obj.generateRandomNo();
            }





        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }  

        private void btnSet_Click(object sender, EventArgs e) 
        {
            int count = -1;
            int nn = 0,nnn=0;

            for (int x=0;x<cbPlayer.Items.Count;x++) {
                if (cbPlayer.GetItemChecked(x)) {
                    nn++;   
                }
            
            }
           // MessageBox.Show("Player 1---"+nn);
            for (int x = 0; x < cbPlayer.Items.Count; x++)
            {
                if (cbCar.GetItemChecked(x))
                {
                    nnn++;
                }

            }


            if (nn == 1 && nnn == 1)
            {


                for (int y = 0; y < cbPlayer.Items.Count; y++)
                {
                    String[] details = cbPlayer.Items[y].ToString().Split(' ');
                    if (cbPlayer.GetItemChecked(y) && details.Length == 4)
                    {
                        for (int z = 0; z < cbCar.Items.Count; z++)
                        {
                            if (cbCar.GetItemChecked(z))
                            {
                                count = z;
                                break;
                            }

                        }
                        if (count >= 0 && nm.Value > 0)
                        {
                            String f = cbPlayer.SelectedItem.ToString().Substring(0, cbPlayer.SelectedItem.ToString().IndexOf(' '));
                            cbPlayer.Items[y] = f + " choose " + (cbCar.SelectedIndex + 1) + " Car with $ " + nm.Value;
                            btnStart.Enabled = true;
                        }
                        else
                        {
                            MessageBox.Show("select the car and fill the amount for the bet ");
                        }
                    }

                }
            }
            else {
                MessageBox.Show("select only one player and one car at a time ");
            }
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void cbPlayer_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
