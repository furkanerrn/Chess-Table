using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RecapDemo1
{
    public partial class Form1 : Form
    {
       
        public Form1()
        {
            
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            Button[,] buttons = new Button[8, 8];
            for (int i = 0; i < buttons.GetUpperBound(0); i++) //Satır için değerler
            {
                for (int j = 0; j < buttons.GetUpperBound(1); j++)//Sütun için değerler
                {
                    buttons[i, j] = new Button();
                    buttons[i, j].Width = 55;
                    buttons[i, j].Height= 55;
                   
                    buttons[i, j].Left = Left;//butonun soldan uzaklığı
                    Left +=50; //soldan kaydırma işlemi
                    if ((i+j)%2==0)
                    {
                        buttons[i, j].BackColor = Color.SaddleBrown;
                    }
                    else
                    {
                        buttons[i, j].BackColor = Color.White ;
                    }
                    buttons[i, j].Top = Top;
                   
                    


                    this.Controls.Add(buttons[i, j]);//butonu ekrana koyar

                }
                Left = 0;
                Top += 50;//İkinci satıra geçtiğinde 50 artır
            }
                
            

        }
    }
}
