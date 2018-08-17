using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bingo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();                        
        }

        private void button1_Click(object sender, EventArgs e)
        {
            BingoModel bingo = new BingoModel();
            txtCartelaExemplo.Text = "";
            List<int[]> cartela = new List<int[]>();

            cartela.Add(bingo.gerarColuna(5, 1, 16).OrderBy(i => i).ToArray());
            cartela.Add(bingo.gerarColuna(5, 16, 31).OrderBy(i => i).ToArray());
            cartela.Add(bingo.gerarColuna(4, 31, 46).OrderBy(i => i).ToArray());
            cartela.Add(bingo.gerarColuna(5, 46, 61).OrderBy(i => i).ToArray());
            cartela.Add(bingo.gerarColuna(5, 61, 76).OrderBy(i => i).ToArray());

            for (int i = 0; i < cartela.Count(); i++)
            {
                foreach (var item in cartela[i])
                {
                    txtCartelaExemplo.Text += item.ToString() + " ";                    
                }                
            }
            txtCartelaExemplo.Text = txtCartelaExemplo.Text.TrimEnd();

        }
    }
}


