using Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public interface IRepositorio
    {
        void Inserir(Moedas moedas);
        void Deletar(string territorio);
        Moedas Consultar(string territorio);
        List<Moedas> Listar();
    }
}
