using System;

namespace Modelos
{
    public class Moedas
    {
        public int id;
        public string moedas;
        public string territorio;
        public string simbolo;
        public string codigoIso;
        public string unidadeFracionaria;
        public decimal valorEmReal;

        //public Moedas() { }

        public Moedas(string moedas, string territorio, string simbolo, string codigoIso, string unidadeFracionaria, decimal valorEmReal)
        {
            
            Moeda = moedas;
            Territorio = territorio;
            Simbolo = simbolo;
            CodigoIso = codigoIso;
            UnidadeFracionaria = unidadeFracionaria;
            ValorEmReal = valorEmReal;
        }
        public Moedas(int id, string moedas, string territorio, string simbolo, string codigoIso, string unidadeFracionaria, decimal valorEmReal) :this(moedas, territorio, simbolo, codigoIso, unidadeFracionaria, valorEmReal)
        {
            Id = id;
            
        }
        public int Id
        {
            get
            {
                return id;
            }

            set
            {
                id = value;
            }
        }

        public string Moeda
        {
            get
            {
                return moedas;
            }

            set
            {
                moedas = value.ToUpper();
            }
        }

        public string Territorio
        {
            get
            {
                return territorio;
            }

            set
            {
                territorio = value.ToUpper();
            }
        }

        public string Simbolo
        {
            get
            {
                return simbolo;
            }

            set
            {
                simbolo = value.ToUpper();
            }
        }

        public string CodigoIso
        {
            get
            {
                return codigoIso;
            }

            set
            {
                codigoIso = value.ToUpper();
            }
        }

        public string UnidadeFracionaria
        {
            get
            {
                return unidadeFracionaria;
            }

            set
            {
                unidadeFracionaria = value.ToUpper();
            }
        }

        public decimal ValorEmReal
        {
            get
            {
                return valorEmReal;
            }

            set
            {
                valorEmReal = value;
            }
        }
    }
}
