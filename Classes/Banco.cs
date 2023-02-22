using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace PrimeiroProjeto.Classes
{
    internal class Banco
    {
        private int _nconta;
        private string _titular;
        private double _saldoDaConta { get; set; }
        private string _depInicial { get; set; }

        public Banco() { }

        public Banco(int Nconta, string titular, double saldoDaConta)
        {
            _nconta = Nconta;
            _titular = titular;
            _saldoDaConta = saldoDaConta;
        }

        public Banco(int Nconta, string titular)
        {
            Nconta = _nconta;
            titular = _titular;
        }
        
       
        public int NConta
        {
            get { return _nconta; }
            set
            {
                if (value.ToString().Length >= 4)
                {
                    _nconta = value;
                }
            }
        }

        public string Titular
        {
            get { return _titular; }
            set
            {
                if (value.Length >= 2)
                {
                    _titular = value;
                }
            }
        }

        public string DepInicial
        {
            get { return _depInicial; }
            set { _depInicial = value; }
        }

        public double SaldoDaConta
        {
            get { return _saldoDaConta; }
            set { _saldoDaConta = value;  }
        }

        public void Deposito(double vlrDep)
        {
            _saldoDaConta += + vlrDep;
        }

        public void Saque(double vlrSaq)
        {
            _saldoDaConta = (_saldoDaConta - 5) - vlrSaq;
        }

        public override string ToString()
        {
            return "Conta: " + _nconta + ", Titular: " + _titular + ", Saldo: " + _saldoDaConta;
        }
    }
}
