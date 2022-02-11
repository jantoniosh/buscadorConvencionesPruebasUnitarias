using buscadorWebApi.Controllers;
using buscadorWebApi.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Xunit;

namespace convencionesTest
{
    public class convencionesTest
    {
        public static DbContextOptions<DemoConvencionesDBContext> dbContextOptions { get; set; }
        public static string connectionString = "Data Source=LAPTOP-K0T01G6Q\\TEW_SQLEXPRESS;Initial Catalog=DemoConvencionesDB;Integrated Security=True;MultipleActiveResultSets=True";
        static convencionesTest()
        {
            dbContextOptions = new DbContextOptionsBuilder<DemoConvencionesDBContext>()
                .UseSqlServer(connectionString)
                .Options;
        }



        [Fact]
        public void GetTitulo_Return_OkResult()
        {
            //Arrange  
            var context = new DemoConvencionesDBContext(dbContextOptions);
            var controller = new tituloController(context);

            //Act  
            var data = controller.GetTitulos();

            //Assert  
            Assert.IsType<OkObjectResult>(data);
        }

        [Fact]
        public void GetTitulos_Return_OkResult()
        {
            //Arrange  
            var context = new DemoConvencionesDBContext(dbContextOptions);
            var controller = new tituloController(context);
            string texto = "obligación";

            //Act  
            var data = controller.GetTitulo(texto);

            //Assert  
            Assert.IsType<OkObjectResult>(data);
        }

        [Fact]
        public void GetTitulos_Return_NotFoundResult()
        {
            //Arrange  
            var context = new DemoConvencionesDBContext(dbContextOptions);
            var controller = new tituloController(context);
            string texto = "@@@@";

            //Act  
            var data = controller.GetTitulo(texto);
            //Assert  
            Assert.IsType<NotFoundResult>(data);
        }

        [Fact]
        public void GetEtiquetas_Return_OkResult()
        {
            //Arrange  
            var context = new DemoConvencionesDBContext(dbContextOptions);
            var controller = new etiquetaController(context);

            //Act  
            var data = controller.GetEtiquetas();

            //Assert  
            Assert.IsType<OkObjectResult>(data);
        }
        [Fact]
        public void GetFuentes_Return_OkResult()
        {
            //Arrange  
            var context = new DemoConvencionesDBContext(dbContextOptions);
            var controller = new fuenteController(context);

            //Act  
            var data = controller.GetFuentes();

            //Assert  
            Assert.IsType<OkObjectResult>(data);
        }

        [Fact]
        public void GetEntradas_Return_OkResult()
        {
            //Arrange  
            var context = new DemoConvencionesDBContext(dbContextOptions);
            var controller = new entradaController(context);

            //Act  
            var data = controller.GetEntradas();

            //Assert  
            Assert.IsType<OkObjectResult>(data);
        }

        [Fact]
        public void GetEntrada_Return_OkResult()
        {
            //Arrange  
            var context = new DemoConvencionesDBContext(dbContextOptions);
            var controller = new entradaController(context);
            string texto = "/ficha/principio-de-igualdad-y-no-discriminacion";

            //Act  
            var data = controller.GetEntrada(texto);

            //Assert  
            Assert.IsType<OkObjectResult>(data);
        }

        [Fact]
        public void GetEntrada_Return_NotFoundResult()
        {
            //Arrange  
            var context = new DemoConvencionesDBContext(dbContextOptions);
            var controller = new entradaController(context);
            string texto = "@@@@";

            //Act  
            var data = controller.GetEntrada(texto);
            //Assert  
            Assert.IsType<NotFoundResult>(data);
        }

        [Fact]
        public void GetBusqueda_Return_OkResult()
        {
            //Arrange  
            var context = new DemoConvencionesDBContext(dbContextOptions);
            var controller = new entradaController(context);
            string texto = "Principio de igualdad y no discriminación";

            //Act  
            var data = controller.GetBusqueda(texto);

            //Assert  
            Assert.IsType<OkObjectResult>(data);
        }

        [Fact]
        public void GetBusqueda_Return_NotFoundResult()
        {
            //Arrange  
            var context = new DemoConvencionesDBContext(dbContextOptions);
            var controller = new entradaController(context);
            string texto = "@@@@";

            //Act  
            var data = controller.GetBusqueda(texto);
            //Assert  
            Assert.IsType<NotFoundResult>(data);
        }

        [Fact]
        public void GetEtiqueta_Return_OkResult()
        {
            //Arrange  
            var context = new DemoConvencionesDBContext(dbContextOptions);
            var controller = new entradaController(context);
            string texto = "ViolenciaYDiscriminacion";

            //Act  
            var data = controller.GetEtiqueta(texto);

            //Assert  
            Assert.IsType<OkObjectResult>(data);
        }

        [Fact]
        public void GetEtiqueta_Return_NotFoundResult()
        {
            //Arrange  
            var context = new DemoConvencionesDBContext(dbContextOptions);
            var controller = new entradaController(context);
            string texto = "@@@@";

            //Act  
            var data = controller.GetEtiqueta(texto);
            //Assert  
            Assert.IsType<NotFoundResult>(data);
        }
    }
}