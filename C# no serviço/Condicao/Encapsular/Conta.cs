using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsular
{
    internal class Conta
    {
        public string _cliente;
        public double _saldo;

        public void Sacar(double valor)
        {
            _saldo -= valor;
        }

        public void Depositar(double valor)
        {
            _saldo += valor;
        }

    }
}
