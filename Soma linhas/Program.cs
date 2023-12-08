using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Soma_linhas {
    class Program {
        static void Main(string[] args) {

            CultureInfo CI = CultureInfo.InvariantCulture;

            int m, n, i, j;
            double soma;

            Console.Write("Qual a quantidade de linhas da matriz? ");
            n = int.Parse(Console.ReadLine());
            Console.Write("Qual a quantidade de colunas da matriz ? ");
            m = int.Parse(Console.ReadLine());

            double[] vetor = new double[n];
            double[,] matriz = new double[n, m];

            for (i = 0; i < n; i++) {
                Console.WriteLine("Digite os elementos da " + (i+1) + "a linha:");
                for (j = 0; j < m; j++) {
                    matriz[i, j] = double.Parse(Console.ReadLine(), CI);
                }
            }

            Console.WriteLine("VETOR GERADO:");
            for (i = 0; i < n; i++) {
                soma = 0;
                for (j = 0; j < m; j++) {
                    soma = soma + matriz[i, j];
                }
                Console.WriteLine(soma.ToString("F1", CI));
            }
        }
    }
}
