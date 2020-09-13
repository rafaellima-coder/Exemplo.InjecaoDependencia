using System;
using System.Collections.Generic;
using System.Text;

namespace ContraExemplo
{
    public class Empresa
    {
        private int _cod;

        public int Cod
        {
            get { return _cod; }
            set { _cod = value; }
        }
        private string _razaoSocial;

        public string RazaoSocial
        {
            get { return _razaoSocial; }
            set { _razaoSocial = value; }
        }


        /// <summary>
        ///Alto Aclopamento
        ///Alteração na classe Endereço pode quebrar a classe empresa
        ///Solução é a inversão de controle em conjunto com a injeção de dependência
        ///TIPOS
        ///1- Constructor Methodology
        ///2- Getter and Setter
        ///3- Interface Implemetation
        ///4- Service Locator
        /// </summary>
        private Endereco _endereco; 

        public Endereco Endereco
        {
            get { return _endereco; }
            set { _endereco = value; }
        }
    }
}
