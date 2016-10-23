using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication2
{
   public static class calculos
    {
        #region Soma
        public static float[,] SomarMatrizes(float[,] MatrizA, float[,] MatrizB)
        {
            float[,] MatrizResultado = new float[MatrizA.GetLongLength(0), MatrizA.GetLength(1)];
            for (int x = 0; x < MatrizResultado.GetLength(0); x++)
            {
                for (int y = 0; y < MatrizResultado.GetLength(1); y++)
                {
                    MatrizResultado[x, y] = MatrizA[x, y] += MatrizB[x, y];
                }
            }
            return MatrizResultado;
        }
        #endregion
        #region subtração
        public static float[,] SubtrairMatrizes(float[,] MatrizA, float[,] MatrizB)
        {
            float[,] MatrizResultado = new float[MatrizA.GetLongLength(0), MatrizA.GetLength(1)];
            for (int x = 0; x < MatrizResultado.GetLength(0); x++)
            {
                for (int y = 0; y < MatrizResultado.GetLength(1); y++)
                {
                    MatrizResultado[x, y] = MatrizA[x, y] -= MatrizB[x, y];
                }
            }
            return MatrizResultado;
        }
        #endregion
        #region Multiplicar
        public static float[,] MultiplicarMatrizes(float[,] MatrizA, float[,] MatrizB)
        {
            float[,] MatrizResultado = new float[MatrizA.GetLength(0), MatrizB.GetLength(1)];
            for (int x = 0; x < MatrizResultado.GetLength(0); x++)
            {
                for (int y = 0; y < MatrizResultado.GetLength(1); y++)
                {
                    for (int n = 0; n < MatrizB.GetLength(0); n++)
                    {
                        string i = "" + MatrizA[x, n];
                        MatrizResultado[x, y] += MatrizA[x, n] * MatrizB[n, y];
                    }
                }
            }
            return MatrizResultado;
        }
        #endregion
        #region Matrizes Opostas e Transpostas
        public static float[,] CriarOposta(float[,] matriz)
        {
            float[,] matrizOposta = new float[matriz.GetLength(0), matriz.GetLength(1)];
            for (int x = 0; x < matrizOposta.GetLength(0); x++)
            {
                for (int y = 0; y < matrizOposta.GetLength(1); y++)
                {
                    matrizOposta[x, y] += matriz[x, y] * -1;
                }
            }
            return matrizOposta;
        }
        public static float[,] CriarTransposta(float[,] matriz)
        {
            float[,] matrizTransposta = new float[matriz.GetLength(1), matriz.GetLength(0)];
            for (int x = 0; x < matrizTransposta.GetLength(0); x++)
            {
                for (int y = 0; y < matrizTransposta.GetLength(1); y++)
                {
                    matrizTransposta[x, y] += matriz[y, x];
                }
            }
            return matrizTransposta;
        }
        #endregion
        #region Determinantes das matrizes
        public static float GerarDeterminante2x2(float[,] matriz)
        {
            float diagonalPrincipal = 1;
            float diagonalSecundaria = 1;
            float determinanteFinal = 0;
            for (int x = 0; x < matriz.GetLength(0); x++)
            {
                for (int y = 0; y < matriz.GetLength(1); y++)
                {
                    if (x == y)
                    {
                        diagonalPrincipal *= matriz[x, y];
                    }
                }
            }
            for (int x = 0; x < matriz.GetLength(0); x++)
            {
                for (int y = 0; y < matriz.GetLength(1); y++)
                {
                    if (x != y)
                    {
                        diagonalSecundaria *= matriz[x, y];
                    }
                }
            }
            determinanteFinal = diagonalPrincipal - diagonalSecundaria;
            return determinanteFinal;
        }
        public static float GerarDeterminante3x3(float[,] matriz)
        {
            float diagonalPrincipal = 0;
            float diagonalSecundaria = 0;
            float determinanteFinal = 0;
            int tamanhoSarrus = (((matriz.GetLength(0) * matriz.GetLength(1)) * 2) / 3) - 1;
            float[,] Sarrus = new float[matriz.GetLength(0), tamanhoSarrus];
            for (int x = 0; x < Sarrus.GetLength(0); x++)
            {
                for (int y = 0; y < Sarrus.GetLength(1); y++)
                {
                    if (y > matriz.GetLength(0) - 1)
                    {
                        Sarrus[x, y] += matriz[x, y - matriz.GetLength(0)];
                    }
                    else
                    {
                        Sarrus[x, y] += matriz[x, y];
                    }
                }
            }
            int voltas = 3;
            for (int i = 0; i < voltas; i++)
            {
                int numero = i;
                float mDiagonal = 1;
                for (int x = 0; x < Sarrus.GetLength(0); x++)
                {
                    for (int y = 0; y < Sarrus.GetLength(1); y++)
                    {
                        if (x == y)
                        {
                            string z = "" + Sarrus[x, y + numero];
                            mDiagonal *= Sarrus[x, y + numero];
                        }
                    }
                }
                diagonalPrincipal += mDiagonal;
            }

            for (int i = 0; i < voltas; i++)
            {
                int numero = i;
                float mDiagonal = 1;
                for (int x = 0; x < Sarrus.GetLength(0); x++)
                {
                    for (int y = Sarrus.GetLength(1) - 1; y > 0; y--)
                    {
                        if (x == (Sarrus.GetLength(1) - 1) - y)
                        {
                            string z = "" + Sarrus[x, y - numero];
                            mDiagonal *= Sarrus[x, y - numero];
                        }
                    }
                }
                diagonalSecundaria += mDiagonal;
            }
            determinanteFinal = diagonalPrincipal - diagonalSecundaria;
            return determinanteFinal;
        }
        public static float GerarDeterminanteGrande(float[,] matriz)
        {
            float[,] newMatriz = new float[0,0];
            if (matriz[0, 0] == 1)
            {
                newMatriz = new float[matriz.GetLength(0) - 1, matriz.GetLength(1) - 1];
                for (int i = 1; i < matriz.GetLength(0); i++)
                {
                    for (int j = 1; j < matriz.GetLength(1); j++)
                    {
                        newMatriz[i - 1, j - 1] = matriz[i, j] - matriz[i, 0] * matriz[0, j];
                    }
                }
            }
            else
            {
                float determinante = 0;
                newMatriz = new float[matriz.GetLength(0) - 1, matriz.GetLength(1) - 1];
                for (int i = 0; i < matriz.GetLength(0); i++)
                {
                    for (int j = 0; j < matriz.GetLength(1); i++)
                    {
                        float[,] matrix = new float[matriz.GetLength(0) - 1, matriz.GetLength(1) - 1];
                        matrix[i,j] = matriz[i+1,j+1];
                        float D = 0;
                        if(matrix.GetLength(0) == 3)
                            D = calculos.GerarDeterminante3x3(matrix);
                        else if(matrix.GetLength(0) > 3)
                            D = calculos.GerarDeterminanteGrande(matrix);
                        determinante += matriz[i, j] * ((float)Math.Pow(-1, i + j)) * D;
                    }
                }
                return determinante;
            }
            return GerarDeterminante3x3(newMatriz);
        }
        #endregion
        #region Matrizes Inversas
        public static float[,] GerarCofatora2x2(float[,] matrizA)
        {
            float[,] matrizCofatora = new float[matrizA.GetLength(0), matrizA.GetLength(1)];
            float determinanteDaVez = 0;

            for (int x = 0; x < matrizA.GetLength(0); x++)
            {
                for (int y = 0; y < matrizA.GetLength(1); y++)
                {
                    if (x == 0 && y == 0)
                    {
                        determinanteDaVez = matrizA[x + 1, y + 1];
                    }
                    else if (x == 0 && y == 1)
                    {
                        determinanteDaVez = matrizA[x + 1, y - 1];
                    }
                    else if (x == 1 && y == 0)
                    {
                        determinanteDaVez = matrizA[x - 1, y + 1];
                    }
                    else if (x == 1 && y == 1)
                    {
                        determinanteDaVez = matrizA[x - 1, y - 1];
                    }
                    double i = Math.Pow(-1, (x + y));
                    matrizCofatora[x, y] += (float)i * determinanteDaVez;
                }
            }
            return matrizCofatora;
        }
        public static float[,] GerarCofatora3x3(float[,] matrizA)
        {
            float[,] matrizCofatora = new float[matrizA.GetLength(0), matrizA.GetLength(1)];
            float determinanteAtual = 0;

            for (int x = 0; x < matrizA.GetLength(0); x++)
            {
                for (int y = 0; y < matrizA.GetLength(1); y++)
                {
                    determinanteAtual = DeterminanteCofator(x, y, matrizA);
                    double i = Math.Pow(-1, (x + y));
                    matrizCofatora[x, y] += (float)i * determinanteAtual;
                }
            }
            return matrizCofatora;
        }
        private static float DeterminanteCofator(int posX, int posY, float[,] matriz)
        {
            float[,] matrizResultante = new float[2, 2];
            int id = 0;
            for (int x = 0; x < matriz.GetLength(0); x++)
            {
                for (int y = 0; y < matriz.GetLength(1); y++)
                {
                    if (x != posX && y != posY)
                    {
                        if (id == 0)
                        {
                            matrizResultante[0, 0] += matriz[x, y];
                        }
                        else if (id == 1)
                        {
                            matrizResultante[0, 1] += matriz[x, y];
                        }
                        else if (id == 2)
                        {
                            matrizResultante[1, 0] += matriz[x, y];
                        }
                        else if (id == 3)
                        {
                            matrizResultante[1, 1] += matriz[x, y];
                        }
                        id++;
                    }
                }
            }
            float determinate = GerarDeterminante2x2(matrizResultante);
            return determinate;
        }
        public static float[,] GerarInversa(float determinante, float[,] matriz1)
        {
            float[,] matrizInversa = new float[matriz1.GetLength(0), matriz1.GetLength(1)];
            for (int x = 0; x < matriz1.GetLength(0); x++)
            {
                for (int y = 0; y < matriz1.GetLength(1); y++)
                {
                    float n = matriz1[x, y];
                    n = n / determinante;
                    matrizInversa[x, y] += n;
                }
            }

            return matrizInversa;
        }
        #endregion
    }
}
