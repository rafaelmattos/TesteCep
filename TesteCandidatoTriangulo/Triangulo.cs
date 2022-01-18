using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace TesteCandidatoTriangulo
{
    public class Triangulo
    {
        /// <somamary>
        ///    6
        ///   3 5
        ///  9 7 1
        /// 4 6 8 4
        /// Um elemento somente pode ser somado com um dos dois elementos da próxima linha. Como o elemento 5 na Linha 2 pode ser somado com 7 e 1, mas não com o 9.
        /// Neste triangulo o total máximo é 6 + 5 + 7 + 8 = 26
        /// 
        /// Seu código deverá receber uma matriz (multidimensional) como entrada. O triângulo acima seria: [[6],[3,5],[9,7,1],[4,6,8,4]]
        /// </somamary>
        /// <param name="dadosTriangulo"></param>
        /// <returns>Retorna o resultado do calculo conforme regra acima</returns>
        public int ResultadoTriangulo(string dadosTriangulo)
        {

            int ultimoIndex = 1;
            int indexAtual = 1;
            int soma = 0;

            var matches = Regex.Matches(dadosTriangulo, @"\[(,?[0-9]+)*\]");

            foreach (Match item in matches)
            {
                var itens = Regex.Matches(item.Value, @"[0-9][0-9]?");
                int atual = 0;

                foreach (Match i in itens)
                {
                    if (ultimoIndex == i.Index || ultimoIndex + 2 == i.Index)
                    {
                        var valor = int.Parse(i.Value);
                        if (atual < valor)
                        {
                            atual = valor;
                            indexAtual = i.Index;
                        }
                    }
                }
                soma += atual;
                ultimoIndex = indexAtual;
            }
            return soma;
        }
    }
}
