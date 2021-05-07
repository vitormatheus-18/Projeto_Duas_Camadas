using DAL;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Modelos;
using System;
using System.Collections.Generic;

namespace TesteMoedas
{
    [TestClass]
    public class TestesBDMySQL
    {
        [TestMethod]
        public void InserirMoeda()
        {
            IRepositorio rep = new RepositorioMySQL();
            try
            {
                rep.Inserir(moedas: new Moedas(moedas:"Euro", territorio:"Uni�o Europeia", simbolo: "E", codigoIso:"EUR", unidadeFracionaria:"cent", valorEmReal: 6,54 ));
            }
            catch (Exception ex)
            {
                
            }
            Assert.IsNotNull(rep.Consultar("Uni�o Europeia"));
        }

        [TestMethod]
        public void DeletarMoeda()
        {
            IRepositorio rep = new RepositorioMySQL();
            try
            {
                rep.Deletar("Uni�o Europeia");
            }
            catch (Exception ex)
            {

            }
            Assert.IsNull(rep.Consultar("Uni�o Europeia"));
        }

        [TestMethod]
        public void ConsultarMoeda()
        {
            InserirMoeda();
            Moedas moedas = null;
            IRepositorio rep = new RepositorioMySQL();
            try
            {
                moedas = rep.Consultar("Uni�o Europeia");
            }
            catch (Exception ex)
            {

            }
            Assert.IsNotNull(moedas);
        }

        [TestMethod]
        public void ListarMoeda()
        {
            List<Moedas> moedas = null;
            IRepositorio rep = new RepositorioMySQL();
            try
            {
               moedas = rep.Listar();
            }
            catch (Exception ex)
            {

            }
            Assert.IsNotNull(moedas);
        }
    }
}
