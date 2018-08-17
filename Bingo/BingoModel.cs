using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bingo
{
    class BingoModel
    {
        
        /*
        public string gerarCartela(int quantidadePedras, int quantidadeColunas)
        {
            //int tamanhoCartela = calcularNumerosCartela(quantidadeColunas);

            string cartela = "";            

            int[] col1 = new int[5];
            int[] col2 = new int[5];
            int[] col3 = new int[5];
            int[] col4 = new int[5];
            int[] col5 = new int[5];

            for (int i = 0; i < 5; i++)
            {
                col1[i] = Convert.ToInt32(sortearNumero(col1, 1, 16));
                col2[i] = Convert.ToInt32(sortearNumero(col2, 16, 31));
                col3[i] = Convert.ToInt32(sortearNumero(col3, 31, 46));
                col4[i] = Convert.ToInt32(sortearNumero(col4, 46, 61));
                col5[i] = Convert.ToInt32(sortearNumero(col5, 61, 76));
            }

            for(int i = 0; i < 5; i++)
            {
                cartela += Convert.ToString(col1[i]) + " ";
                cartela += Convert.ToString(col2[i]) + " ";
                cartela += Convert.ToString(col3[i]) + " ";
                cartela += Convert.ToString(col4[i]) + " ";
                cartela += Convert.ToString(col5[i]) + " ";
            }
            cartela = cartela.Trim();

            return cartela;
        }
        */

        public int[] gerarColuna(int quantidadePedras, int pedraInicial, int pedraFinal)
        {
            int[] coluna = new int[quantidadePedras];

            for (int i = 0; i < coluna.Count(); i++)
            {
                coluna[i] = Convert.ToInt32(sortearNumero(coluna, pedraInicial, pedraFinal));
            }
            return coluna;
        }

        //public int calcularNumerosCartela (int quantidadeColunas)
        //{
        //    return quantidadeColunas * quantidadeColunas - 1;
        //}

        public int sortearNumero(int[] coluna, int limiteMenor, int limiteMaior)
        {
            Random rnd = new Random();

            while(1 == 1)
            {
                int numeroSorteado = rnd.Next(limiteMenor, limiteMaior - 1);
                if (existeNaColuna(coluna, numeroSorteado))
                    continue;
                else
                    return numeroSorteado;                
            }            
        }

        public bool existeNaColuna(int[] coluna, int novoNumero)
        {
            for(int i = 0; i < coluna.Length; i++)
            {
                if (coluna[i] == novoNumero)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
