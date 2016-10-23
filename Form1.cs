using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class Form1 : Form
    {
        private TextBox[,] MatrizA;
        private TextBox[,] MatrizB;
        private TextBox[,] MatrizResultado;
        private float determinante;

        int LinhasA, ColunasA;
        int LinhasB, ColunasB;

        public Form1()
        {
            InitializeComponent();
        }
        #region CriarMatrizes
        private void CriarMatrizA_Click(object sender, EventArgs e)
        {
            GrupoMatrizA.Controls.Clear();
            if (linhaA.Text.Length == 0)
            {
                MessageBox.Show("Insira um número válido na linha da Matriz A", "erro");
                return;

            }
            if (ColunaA.Text == null)
            {
                MessageBox.Show("Insira um número válido na coluna da Matriz A", "erro");
                return;
            }
            LinhasA = Convert.ToInt32(linhaA.Text);
            ColunasA = Convert.ToInt32(ColunaA.Text);

            if (!int.TryParse(linhaA.Text, out LinhasA))
            {
                MessageBox.Show("Insira um número válido na linha da Matriz A", "erro");
                return;
            }
            if (!int.TryParse(ColunaA.Text, out ColunasA))
            {
                MessageBox.Show("Insira um número válido na coluna da Matriz A", "erro");
                return;
            }
            MatrizA = new TextBox[LinhasA, ColunasA];
            int TamanhoText = GrupoMatrizA.Width / ColunasA;
            for (int x = 0; x < MatrizA.GetLength(0); x++)
            {
                for (int y = 0; y < MatrizA.GetLength(1); y++)
                {
                    MatrizA[x, y] = new TextBox();
                    MatrizA[x, y].Text = "0";
                    MatrizA[x, y].Top = (x * MatrizA[x, y].Height) + 20;
                    MatrizA[x, y].Left = y * TamanhoText + 6;
                    MatrizA[x, y].Width = TamanhoText;
                    GrupoMatrizA.Controls.Add(MatrizA[x, y]);
                }
            }
        }
        private void CriarMatrizB_Click(object sender, EventArgs e)
        {
            GrupoMatrizB.Controls.Clear();
            if (LinhaB.Text == null)
            {
                MessageBox.Show("Insira um número válido na linha da Matriz B.", "Erro");
                return;
            }

            if (ColunaB.Text == null)
            {
                MessageBox.Show("Insira um número válido na coluna da Matriz B.", "Erro");
                return;
            }
            if (!int.TryParse(LinhaB.Text, out LinhasB))
            {
                MessageBox.Show("Insira um número válido na linha da Matriz B.", "Erro");
                return;
            }
            if (!int.TryParse(ColunaB.Text, out ColunasB))
            {
                MessageBox.Show("Insira um número válido na coluna da Matriz B.", "Erro");
                return;
            }
            int TamanhoText = GrupoMatrizB.Width / ColunasB;
            MatrizB = new TextBox[LinhasB, ColunasB];
            TamanhoText = GrupoMatrizB.Width / ColunasB;
            for (int x = 0; x < MatrizB.GetLength(0); x++)
            {
                for (int y = 0; y < MatrizB.GetLength(1); y++)
                {
                    MatrizB[x, y] = new TextBox();
                    MatrizB[x, y].Text = "0";
                    MatrizB[x, y].Top = (x * MatrizB[x, y].Height) + 20;
                    MatrizB[x, y].Left = y * TamanhoText + 6;
                    MatrizB[x, y].Width = TamanhoText;
                    GrupoMatrizB.Controls.Add(MatrizB[x, y]);
                }
            }
        }

        #endregion

        #region Cálculos
        //Soma
        private void Soma_Click(object sender, EventArgs e)
        {
            if (MatrizA == null || MatrizB == null)
            {
                MessageBox.Show("Matriz inválida, impossível fazer calculo!", "Error - Matriz");
                return;
            }
            float[,] tempMatrizA = new float[MatrizA.GetLength(0), MatrizA.GetLength(1)];
            float[,] tempMatrizB = new float[MatrizB.GetLength(0), MatrizB.GetLength(1)];
            if (tempMatrizA.GetLength(0) != tempMatrizB.GetLength(0) || tempMatrizA.GetLength(1) != tempMatrizB.GetLength(1))
            {
                MessageBox.Show("A soma só é possível se as matrizes forem da mesma ordem!", "Erro ao somar matrizes");
                return;
            }

            for (int x = 0; x < MatrizA.GetLength(0); x++)
            {
                for (int y = 0; y < MatrizA.GetLength(1); y++)
                {
                    float n = 0;
                    float.TryParse(MatrizA[x, y].Text, out n);
                    tempMatrizA[x, y] = n;
                    tempMatrizA[x, y] = Convert.ToSingle(MatrizA[x, y].Text);
                }
            }
            for (int x = 0; x < MatrizB.GetLength(0); x++)
            {
                for (int y = 0; y < MatrizB.GetLength(1); y++)
                {
                    float n = 0;
                    float.TryParse(MatrizB[x, y].Text, out n);
                    tempMatrizB[x, y] = n;
                    tempMatrizB[x, y] = Convert.ToSingle(MatrizB[x, y].Text);
                }
            }

            float[,] tempMatrizResultado = calculos.SomarMatrizes(tempMatrizA, tempMatrizB);
             MatrizResultado = new TextBox[tempMatrizResultado.GetLength(0), tempMatrizResultado.GetLength(1)];
             int TamanhoText = GrupoMatrizResultado.Width / MatrizResultado.GetLength(1);
             GrupoMatrizResultado.Controls.Clear();
             for (int x = 0; x < MatrizResultado.GetLength(0); x++)
             {
                 for (int y = 0; y < MatrizResultado.GetLength(1); y++)
                 {
                     MatrizResultado[x, y] = new TextBox();
                     MatrizResultado[x, y].Text = tempMatrizResultado[x, y].ToString();
                     MatrizResultado[x, y].Top = (x * MatrizResultado[x, y].Height) + 20;
                     MatrizResultado[x, y].Left = y * TamanhoText + 6;
                     MatrizResultado[x, y].Width = TamanhoText;
                     GrupoMatrizResultado.Controls.Add(MatrizResultado[x, y]);
                 }
             } 
        }
        //subtração
        private void BSubtracao_Click(object sender, EventArgs e)
        {
            if (MatrizA == null || MatrizB == null)
            {
                MessageBox.Show("Matriz nula !", "Error - Matriz");
                return;
            }
            float[,] tempMatrizA = new float[MatrizA.GetLength(0), MatrizA.GetLength(1)];
            float[,] tempMatrizB = new float[MatrizB.GetLength(0), MatrizB.GetLength(1)];
            if (tempMatrizA.GetLength(0) != tempMatrizB.GetLength(0) || tempMatrizA.GetLength(1) != tempMatrizB.GetLength(1))
            {
                MessageBox.Show("Só é possivel a subtracao de matrizes de mesma ordem !", "Erro - Soma Matrizes");
                return;
            }

            for (int x = 0; x < MatrizA.GetLength(0); x++)
            {
                for (int y = 0; y < MatrizA.GetLength(1); y++)
                {
                    float n = 0;
                    float.TryParse(MatrizA[x, y].Text, out n);
                    tempMatrizA[x, y] = n;
                }
            }
            for (int x = 0; x < MatrizB.GetLength(0); x++)
            {
                for (int y = 0; y < MatrizB.GetLength(1); y++)
                {
                    float n = 0;
                    float.TryParse(MatrizB[x, y].Text, out n);
                    tempMatrizB[x, y] = n;
                }
            }

            float[,] tempMatrizResultado = calculos.SubtrairMatrizes(tempMatrizA, tempMatrizB);
            MatrizResultado = new TextBox[tempMatrizResultado.GetLength(0), tempMatrizResultado.GetLength(1)];
            int TamanhoText = GrupoMatrizResultado.Width / MatrizResultado.GetLength(1);
            GrupoMatrizResultado.Controls.Clear();
            for (int x = 0; x < MatrizResultado.GetLength(0); x++)
            {
                for (int y = 0; y < MatrizResultado.GetLength(1); y++)
                {
                    MatrizResultado[x, y] = new TextBox();
                    MatrizResultado[x, y].Text = tempMatrizResultado[x, y].ToString();
                    MatrizResultado[x, y].Top = (x * MatrizResultado[x, y].Height) + 20;
                    MatrizResultado[x, y].Left = y * TamanhoText + 6;
                    MatrizResultado[x, y].Width = TamanhoText;
                    GrupoMatrizResultado.Controls.Add(MatrizResultado[x, y]);
                }
            }
        }
        //Multiplicação
        private void Multiplicar_Click(object sender, EventArgs e)
        {
            if (MatrizA == null || MatrizB == null)
            {
                MessageBox.Show("Matriz nula !", "Error - Matriz");
                return;
            }
            float[,] tempMatrizA = new float[MatrizA.GetLength(0), MatrizA.GetLength(1)];
            float[,] tempMatrizB = new float[MatrizB.GetLength(0), MatrizB.GetLength(1)];
            if (tempMatrizA.GetLength(1) != tempMatrizB.GetLength(0))
            {
                MessageBox.Show("Só é possivel a multiplicação de matrizes onde a coluna da matriz A é igual a linha da matriz B  !", "Erro ma multiplicação");
                return;
            }

            for (int x = 0; x < MatrizA.GetLength(0); x++)
            {
                for (int y = 0; y < MatrizA.GetLength(1); y++)
                {
                    float n = 0;
                    float.TryParse(MatrizA[x, y].Text, out n);
                    tempMatrizA[x, y] = n;

                }
            }
            for (int x = 0; x < MatrizB.GetLength(0); x++)
            {
                for (int y = 0; y < MatrizB.GetLength(1); y++)
                {
                    float n = 0;
                    float.TryParse(MatrizB[x, y].Text, out n);
                    tempMatrizB[x, y] = n;
                }
            }

            float[,] tempMatrizResultado = calculos.MultiplicarMatrizes(tempMatrizA, tempMatrizB);
            MatrizResultado = new TextBox[tempMatrizResultado.GetLength(0), tempMatrizResultado.GetLength(1)];
            int TamanhoText = GrupoMatrizResultado.Width / MatrizResultado.GetLength(1);
            GrupoMatrizResultado.Controls.Clear();
            for (int x = 0; x < MatrizResultado.GetLength(0); x++)
            {
                for (int y = 0; y < MatrizResultado.GetLength(1); y++)
                {
                    MatrizResultado[x, y] = new TextBox();
                    MatrizResultado[x, y].Text = tempMatrizResultado[x, y].ToString();
                    MatrizResultado[x, y].Top = (x * MatrizResultado[x, y].Height) + 20;
                    MatrizResultado[x, y].Left = y * TamanhoText + 6;
                    MatrizResultado[x, y].Width = TamanhoText;
                    GrupoMatrizResultado.Controls.Add(MatrizResultado[x, y]);
                }
            }
        }
        #endregion

        #region Matriz Resultado
        private void Oposta_Click(object sender, EventArgs e)
        {
            if (MatrizResultado == null)
            {
                MessageBox.Show("Matriz Nula", "Erro");
                return;
            }
            float[,] tempResultado = new float[MatrizResultado.GetLength(0), MatrizResultado.GetLength(1)];

            for (int x = 0; x < MatrizResultado.GetLength(0); x++)
            {
                for (int y = 0; y < MatrizResultado.GetLength(1); y++)
                {
                    float n = 0;
                    float.TryParse(MatrizResultado[x, y].Text, out n);
                    tempResultado[x, y] = n;
                    //tempResultante[x, y] = Convert.ToInt32(MatrizResultante[x, y].Text);
                }
            }

            float[,] tempMatrizResultado = calculos.CriarOposta(tempResultado);
            int TamanhoText = GrupoMatrizResultado.Width / MatrizResultado.GetLength(1);
            for (int x = 0; x < MatrizResultado.GetLength(0); x++)
            {
                for (int y = 0; y < MatrizResultado.GetLength(1); y++)
                {
                    MatrizResultado[x, y].Text = tempMatrizResultado[x, y].ToString();
                }
            }
        }
        private void Transposta_Click(object sender, EventArgs e)
        {
            if (MatrizResultado == null)
            {
                MessageBox.Show("Matriz nula", "Erro");
                return;
            }
            float[,] tempResultado = new float[MatrizResultado.GetLength(0), MatrizResultado.GetLength(1)];

            for (int x = 0; x < MatrizResultado.GetLength(0); x++)
            {
                for (int y = 0; y < MatrizResultado.GetLength(1); y++)
                {
                    float n = 0;
                    float.TryParse(MatrizResultado[x, y].Text, out n);
                    tempResultado[x, y] = n;
                }
            }

            float[,] tempMatrizResultado = calculos.CriarTransposta(tempResultado);
            int TamanhoText = GrupoMatrizResultado.Width / MatrizResultado.GetLength(1);
            MatrizResultado = new TextBox[tempMatrizResultado.GetLength(0), tempMatrizResultado.GetLength(1)];
            GrupoMatrizResultado.Controls.Clear();
            for (int x = 0; x < MatrizResultado.GetLength(0); x++)
            {
                for (int y = 0; y < MatrizResultado.GetLength(1); y++)
                {
                    MatrizResultado[x, y] = new TextBox();
                    MatrizResultado[x, y].Text = tempMatrizResultado[x, y].ToString();
                    MatrizResultado[x, y].Top = (x * MatrizResultado[x, y].Height) + 20;
                    MatrizResultado[x, y].Left = y * TamanhoText + 6;
                    MatrizResultado[x, y].Width = TamanhoText;
                    GrupoMatrizResultado.Controls.Add(MatrizResultado[x, y]);
                }
            }
        }
        private void Determina_Click(object sender, EventArgs e)
        {
            if (MatrizResultado == null)
            {
                MessageBox.Show("Matriz nula", "Error");
                return;
            }
            float[,] tempResultado = new float[MatrizResultado.GetLength(0), MatrizResultado.GetLength(1)];

            for (int x = 0; x < MatrizResultado.GetLength(0); x++)
            {
                for (int y = 0; y < MatrizResultado.GetLength(1); y++)
                {
                    float n = 0;
                    float.TryParse(MatrizResultado[x, y].Text, out n);
                    tempResultado[x, y] = n;
                }
            }
            if (tempResultado.GetLength(0) == 2 && tempResultado.GetLength(1) == 2)
            {
                determinante = calculos.GerarDeterminante2x2 (tempResultado);
                MessageBox.Show("" + determinante, "Determinante...");
            }
            else if (tempResultado.GetLength(0) == 3 && tempResultado.GetLength(1) == 3)
            {
                determinante = calculos.GerarDeterminante3x3(tempResultado);
                MessageBox.Show("" + determinante, "Determinante...");
            }
            else
            {
                MessageBox.Show("Não é possível gerar determinante!", "Error");
            }
        }
        private void Inversa_Click(object sender, EventArgs e)
        {
            if (MatrizResultado == null)
            {
                MessageBox.Show("Matriz nula !", "Error - Matriz");
                return;
            }
            float[,] tempResultado = new float[MatrizResultado.GetLength(0), MatrizResultado.GetLength(1)];
            float[,] matrizAdjunta = new float[MatrizResultado.GetLength(0), MatrizResultado.GetLength(1)];
            float[,] matrizCofatora = new float[MatrizResultado.GetLength(0), MatrizResultado.GetLength(1)];
            float determinante = 0;
            if (tempResultado.GetLength(0) != 2 || tempResultado.GetLength(1) != 2)
            {
                if (tempResultado.GetLength(0) != 3 || tempResultado.GetLength(1) != 3)
                {
                    MessageBox.Show("Matriz inválida!", "Erro");
                    return;
                }
            }

            for (int x = 0; x < MatrizResultado.GetLength(0); x++)
            {
                for (int y = 0; y < MatrizResultado.GetLength(1); y++)
                {
                    float n = 0;
                    float.TryParse(MatrizResultado[x, y].Text, out n);
                    tempResultado[x, y] = n;
                }
            }
            if (tempResultado.GetLength(0) == 2 && tempResultado.GetLength(1) == 2)
            {
                matrizCofatora = calculos.GerarCofatora2x2(tempResultado);
                matrizAdjunta = calculos.CriarTransposta(matrizCofatora);
                determinante = calculos.GerarDeterminante2x2(tempResultado);
            }
            else if (tempResultado.GetLength(0) == 3 && tempResultado.GetLength(1) == 3)
            {
                matrizCofatora = calculos.GerarCofatora3x3(tempResultado);
                matrizAdjunta = calculos.CriarTransposta(matrizCofatora);
                determinante = calculos.GerarDeterminante3x3(tempResultado);
            }
            else
            {
                MessageBox.Show("Matriz inválida 2!", "Erro");
                return;
            }
            if (determinante == 0)
            {
                MessageBox.Show("Matriz inválida, determinante igual a 0!", "Erro");
                return;
            }
            float[,] tempMatrizResultado = calculos.GerarInversa(determinante, matrizAdjunta);
            int TamanhoText = GrupoMatrizResultado.Width / MatrizResultado.GetLength(1);
            for (int x = 0; x < MatrizResultado.GetLength(0); x++)
            {
                for (int y = 0; y < MatrizResultado.GetLength(1); y++)
                {
                    MatrizResultado[x, y].Text = tempMatrizResultado[x, y].ToString();
                }
            }
        }
        #endregion

        #region Matriz A

        private void OpostaA_Click(object sender, EventArgs e)
        {
            if (MatrizA == null)
            {
                MessageBox.Show("Matriz nula!", "Erro");
                return;
            }
            float[,] tempResultado = new float[MatrizA.GetLength(0), MatrizA.GetLength(1)];

            for (int x = 0; x < MatrizA.GetLength(0); x++)
            {
                for (int y = 0; y < MatrizA.GetLength(1); y++)
                {
                    float n = 0;
                    float.TryParse(MatrizA[x, y].Text, out n);
                    tempResultado[x, y] = n;

                }
            }

            float[,] tempMatrizResultado = calculos.CriarOposta(tempResultado);
            int TamanhoText = GrupoMatrizResultado.Width / MatrizA.GetLength(1);
            for (int x = 0; x < MatrizA.GetLength(0); x++)
            {
                for (int y = 0; y < MatrizA.GetLength(1); y++)
                {
                    MatrizA[x, y].Text = tempMatrizResultado[x, y].ToString();
                }
            }
        } 
        private void TranpostaA_Click(object sender, EventArgs e)
        {
            if (MatrizA == null)
            {
                MessageBox.Show("Matriz nula!", "Erro");
                return;
            }
            float[,] tempResultado = new float[MatrizA.GetLength(0), MatrizA.GetLength(1)];

            for (int x = 0; x < MatrizA.GetLength(0); x++)
            {
                for (int y = 0; y < MatrizA.GetLength(1); y++)
                {
                    float n = 0;
                    float.TryParse(MatrizA[x, y].Text, out n);
                    tempResultado[x, y] = n;
                }
            }

            float[,] tempMatrizResultado = calculos.CriarTransposta(tempResultado);
            int TamanhoText = GrupoMatrizResultado.Width / MatrizA.GetLength(1);
            MatrizA = new TextBox[tempMatrizResultado.GetLength(0), tempMatrizResultado.GetLength(1)];
            GrupoMatrizA.Controls.Clear();
            for (int x = 0; x < MatrizA.GetLength(0); x++)
            {
                for (int y = 0; y < MatrizA.GetLength(1); y++)
                {
                    MatrizA[x, y] = new TextBox();
                    MatrizA[x, y].Text = tempMatrizResultado[x, y].ToString();
                    MatrizA[x, y].Top = (x * MatrizA[x, y].Height) + 20;
                    MatrizA[x, y].Left = y * TamanhoText + 6;
                    MatrizA[x, y].Width = TamanhoText;
                    GrupoMatrizA.Controls.Add(MatrizA[x, y]);
                }
            }
        }
        private void InversaA_Click(object sender, EventArgs e)
        {
            if (MatrizA == null)
            {
                MessageBox.Show("Matriz nula!", "Erro");
                return;
            }
            float[,] tempResultado = new float[MatrizA.GetLength(0), MatrizA.GetLength(1)];
            float[,] matrizAdjunta = new float[MatrizA.GetLength(0), MatrizA.GetLength(1)];
            float[,] matrizCofatora = new float[MatrizA.GetLength(0), MatrizA.GetLength(1)];
            float determinante = 0;
            if (tempResultado.GetLength(0) != 2 || tempResultado.GetLength(1) != 2)
            {
                if (tempResultado.GetLength(0) != 3 || tempResultado.GetLength(1) != 3)
                {
                    MessageBox.Show("Matriz inválida!", "Erro");
                    return;
                }
            }
            for (int x = 0; x < MatrizA.GetLength(0); x++)
            {
                for (int y = 0; y < MatrizA.GetLength(1); y++)
                {
                    float n = 0;
                    float.TryParse(MatrizA[x, y].Text, out n);
                    tempResultado[x, y] = n;
                }
            }
            if (tempResultado.GetLength(0) == 2 && tempResultado.GetLength(1) == 2)
            {
                matrizCofatora = calculos.GerarCofatora2x2(tempResultado);
                matrizAdjunta = calculos.CriarTransposta(matrizCofatora);
                determinante = calculos.GerarDeterminante2x2(tempResultado);
            }
            else if (tempResultado.GetLength(0) == 3 && tempResultado.GetLength(1) == 3)
            {
                matrizCofatora = calculos.GerarCofatora3x3(tempResultado);
                matrizAdjunta = calculos.CriarTransposta(matrizCofatora);
                determinante = calculos.GerarDeterminante3x3(tempResultado);
            }
            else
            {
                MessageBox.Show("Matriz invalida!", "Erro");
                return;
            }
            if (determinante == 0)
            {
                MessageBox.Show("Matriz inválida, o determinante é igual a 0!", "Erro");
                return;
            }
            float[,] tempMatrizResultante = calculos.GerarInversa(determinante, matrizAdjunta);
            int TamanhoText = GrupoMatrizA.Width / MatrizA.GetLength(1);
            for (int x = 0; x < MatrizA.GetLength(0); x++)
            {
                for (int y = 0; y < MatrizA.GetLength(1); y++)
                {
                    MatrizA[x, y].Text = tempMatrizResultante[x, y].ToString();
                }
            }
        }
        private void DeterminaA_Click(object sender, EventArgs e)
        {
            if (MatrizA == null)
            {
                MessageBox.Show("Matriz nula!", "Erro");
                return;
            }
            float[,] tempResultado = new float[MatrizA.GetLength(0), MatrizA.GetLength(1)];

            for (int x = 0; x < MatrizA.GetLength(0); x++)
            {
                for (int y = 0; y < MatrizA.GetLength(1); y++)
                {
                    float n = 0;
                    float.TryParse(MatrizA[x, y].Text, out n);
                    tempResultado[x, y] = n;
                }
            }
            if (tempResultado.GetLength(0) == 2 && tempResultado.GetLength(1) == 2)
            {
                determinante = calculos.GerarDeterminante2x2(tempResultado);
                MessageBox.Show("" + determinante, "Determinante...");
            }
            else if (tempResultado.GetLength(0) == 3 && tempResultado.GetLength(1) == 3)
            {
                determinante = calculos.GerarDeterminante3x3(tempResultado);
                MessageBox.Show("" + determinante, "Determinante...");
            }
            else
            {
                MessageBox.Show("Não é possível gerar determinante!", "Erro, Matriz invalida");
            }
        }
        #endregion
        #region Matriz B
        private void OpostaB_Click(object sender, EventArgs e)
        {
            if (MatrizB == null)
            {
                MessageBox.Show("Matriz nula!", "Erro");
                return;
            }
            float[,] tempResultado = new float[MatrizB.GetLength(0), MatrizB.GetLength(1)];

            for (int x = 0; x < MatrizB.GetLength(0); x++)
            {
                for (int y = 0; y < MatrizB.GetLength(1); y++)
                {
                    float n = 0;
                    float.TryParse(MatrizB[x, y].Text, out n);
                    tempResultado[x, y] = n;
                }
            }

            float[,] tempMatrizResultado = calculos.CriarOposta(tempResultado);
            int TamanhoText = GrupoMatrizB.Width / MatrizB.GetLength(1);
            for (int x = 0; x < MatrizB.GetLength(0); x++)
            {
                for (int y = 0; y < MatrizB.GetLength(1); y++)
                {
                    MatrizB[x, y].Text = tempMatrizResultado[x, y].ToString();
                }
            }
        }
        private void TranpostaB_Click(object sender, EventArgs e)
        {
            if (MatrizB == null)
            {
                MessageBox.Show("Matriz nula!", "Erro");
                return;
            }
            float[,] tempResultado = new float[MatrizB.GetLength(0), MatrizB.GetLength(1)];

            for (int x = 0; x < MatrizB.GetLength(0); x++)
            {
                for (int y = 0; y < MatrizB.GetLength(1); y++)
                {
                    float n = 0;
                    float.TryParse(MatrizB[x, y].Text, out n);
                    tempResultado[x, y] = n;
                }
            }

            float[,] tempMatrizResultado = calculos.CriarTransposta(tempResultado);
            int TamanhoText = GrupoMatrizB.Width / MatrizB.GetLength(1);
            MatrizB = new TextBox[tempMatrizResultado.GetLength(0), tempMatrizResultado.GetLength(1)];
            GrupoMatrizB.Controls.Clear();
            for (int x = 0; x < MatrizB.GetLength(0); x++)
            {
                for (int y = 0; y < MatrizB.GetLength(1); y++)
                {
                    MatrizB[x, y] = new TextBox();
                    MatrizB[x, y].Text = tempMatrizResultado[x, y].ToString();
                    MatrizB[x, y].Top = (x * MatrizB[x, y].Height) + 20;
                    MatrizB[x, y].Left = y * TamanhoText + 6;
                    MatrizB[x, y].Width = TamanhoText;
                    GrupoMatrizB.Controls.Add(MatrizB[x, y]);
                }
            }
        }
        private void InversaB_Click(object sender, EventArgs e)
        {
            if (MatrizB == null)
            {
                MessageBox.Show("Matriz nula !", "Error - Matriz");
                return;
            }
            float[,] tempResultado = new float[MatrizB.GetLength(0), MatrizB.GetLength(1)];
            float[,] matrizAdjunta = new float[MatrizB.GetLength(0), MatrizB.GetLength(1)];
            float[,] matrizCofatora = new float[MatrizB.GetLength(0), MatrizB.GetLength(1)];
            float determinante = 0;
            if (tempResultado.GetLength(0) != 2 || tempResultado.GetLength(1) != 2)
            {
                if (tempResultado.GetLength(0) != 3 || tempResultado.GetLength(1) != 3)
                {
                    MessageBox.Show("Matriz invalida !", "Error - Matriz");
                    return;
                }
            }

            for (int x = 0; x < MatrizB.GetLength(0); x++)
            {
                for (int y = 0; y < MatrizB.GetLength(1); y++)
                {
                    float n = 0;
                    float.TryParse(MatrizB[x, y].Text, out n);
                    tempResultado[x, y] = n;
                    //tempResultante[x, y] = Convert.ToInt32(Matriz2[x, y].Text);
                }
            }
            /*Matriz Adjunta(A) = Matriz Transposta(Matriz dos cofatores(A))
            Matriz Inversa(A) = (1/ Determinante(A)) * Matriz Adjunta(A)*/
            if (tempResultado.GetLength(0) == 2 && tempResultado.GetLength(1) == 2)
            {
                matrizCofatora = calculos.GerarCofatora2x2(tempResultado);
                matrizAdjunta = calculos.CriarTransposta(matrizCofatora);
                determinante = calculos.GerarDeterminante2x2(tempResultado);
            }
            else if (tempResultado.GetLength(0) == 3 && tempResultado.GetLength(1) == 3)
            {
                matrizCofatora = calculos.GerarCofatora3x3(tempResultado);
                matrizAdjunta = calculos.CriarTransposta(matrizCofatora);
                determinante = calculos.GerarDeterminante3x3(tempResultado);
            }
            else
            {
                MessageBox.Show("Matriz invalida !", "Error - Matriz");
                return;
            }
            if (determinante == 0)
            {
                MessageBox.Show("Matriz invalida, determinante igual a 0 !", "Error - Matriz");
                return;
            }
            tempResultado = calculos.GerarInversa(determinante, matrizAdjunta);
            int TamanhoText = GrupoMatrizB.Width / MatrizB.GetLength(1);
            for (int x = 0; x < MatrizB.GetLength(0); x++)
            {
                for (int y = 0; y < MatrizB.GetLength(1); y++)
                {
                    MatrizB[x, y].Text = tempResultado[x, y].ToString();
                }
            }
        }
        private void DeterminaB_Click(object sender, EventArgs e)
        {
            if (MatrizB == null)
            {
                MessageBox.Show("Matriz nula!", "Erro");
                return;
            }
            float[,] tempResultado = new float[MatrizB.GetLength(0), MatrizB.GetLength(1)];

            for (int x = 0; x < MatrizB.GetLength(0); x++)
            {
                for (int y = 0; y < MatrizB.GetLength(1); y++)
                {
                    float n = 0;
                    float.TryParse(MatrizB[x, y].Text, out n);
                    tempResultado[x, y] = n;
                }
            }
            if (tempResultado.GetLength(0) == 2 && tempResultado.GetLength(1) == 2)
            {
                determinante = calculos.GerarDeterminante2x2(tempResultado);
                MessageBox.Show("" + determinante, "Determinante...");
            }
            else if (tempResultado.GetLength(0) == 3 && tempResultado.GetLength(1) == 3)
            {
                determinante = calculos.GerarDeterminante3x3(tempResultado);
                MessageBox.Show("" + determinante, "Determinante...");
            }
            else if (tempResultado.GetLength(0) >= 4 && tempResultado.GetLength(1) >= 4)
            {
                determinante = calculos.GerarDeterminanteGrande(tempResultado);
                MessageBox.Show("" + determinante, "Determinante...");
            }
            else
            {
                MessageBox.Show("Não é possível gerar determinante!", "Erro, Matriz invalida");
            }
        }
         
        #endregion

        private void LinhaB_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 08 && e.KeyChar != ',')
            {

                e.Handled = true;
            }
        }

        private void ColunaB_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 08 && e.KeyChar != ',')
            {

                e.Handled = true;
            }
        }

        private void ColunaA_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 08 && e.KeyChar != ',')
            {

                e.Handled = true;
            }
        }

        private void linhaA_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 08 && e.KeyChar != ',')
            {

                e.Handled = true;
            }
        }

        private void linhaA_TextChanged(object sender, EventArgs e)
        {
            linhaA.MaxLength = 2;
        }

        private void ColunaA_TextChanged(object sender, EventArgs e)
        {
            ColunaA.MaxLength = 2;
        }

        private void LinhaB_TextChanged(object sender, EventArgs e)
        {
            LinhaB.MaxLength = 2;
        }

        private void ColunaB_TextChanged(object sender, EventArgs e)
        {
            ColunaB.MaxLength = 2;
        }
        
        
    }
}



