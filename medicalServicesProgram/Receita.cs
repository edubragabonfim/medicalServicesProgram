using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace medicalServicesProgram
{
    class Receita
    {
        #region Attributes
        string _descricao;
        double _valor;
        DateTime _data;

        #endregion

        #region Builder
        /// <summary>
        /// Método construtor da classe Receita.
        /// </summary>
        /// <param name="descricao">Nome da conta que gerou a receita.</param>
        /// <param name="valor">Valor de Entrada</param>
        public Receita(string descricao, double valor)
        {
            DateTime now = DateTime.Now;  // Usuado para capturar o momento exato na criação da Receita.

            _descricao = descricao;
            _valor = valor;
            _data = new DateTime(now.Year, now.Month, now.Day, 0, 0, 0);
        }

        #endregion

        #region Methods
        /// <summary>
        /// Método que gera uma descrição completa de uma determinada Receita.
        /// </summary>
        /// <returns>String com Valor, Descrição e Data.</returns>
        public string Relatorio()
        {
            return $"Entrada de {_valor:C2} referente a {_descricao} na data {_data.ToString("dd/MM/yyyy")}";
        }

        #endregion
    }
}
