﻿using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioAula60FazendoJunto01 {
    internal class ContaBancaria {

        public int Numero { get; private set; }
        public string Titular { get; private set; }
        public double Saldo { get; private set; }

        public ContaBancaria(int numero, string titular) {
            Numero = numero;
            Titular = titular;
        }

        public ContaBancaria(int numero, string titular, double saldo) : this(numero, titular) {
            Saldo = saldo;
        }

        public void Deposito(double quantia) {
            Saldo = Saldo + quantia;
        }

        public void Saque(double quantia) {
            Saldo = Saldo - quantia;
        }

        public override string ToString () {
            return "Conta "
                + Numero
                + ", Titular: "
                + Titular
                + ", Saldo: $ "
                + Saldo.ToString("F2", CultureInfo.InvariantCulture);
        }

    }
}
