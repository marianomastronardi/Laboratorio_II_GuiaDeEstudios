using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Telecom;

namespace UnitTestCentralita
{
  [TestClass]
  public class UnitTest1
  {
    /// <summary>
    /// Crear un test unitario que valide que la lista de llamadas
    /// de la centralita esté instanciada al
    /// crear un nuevo objeto del tipo Centralita.
    /// </summary>
    [TestMethod]
    public void ValidaListLlamadasCentralita()
    {
      //Arrange
      Centralita c = new Centralita("Centralita ValidaListLlamadasCentralita");

      //Act

      //Assert
      Assert.IsNotNull(c.Llamadas);
    }

    /// <summary>
    /// Controlar mediante un nuevo método de test unitario que la excepción CentralitaExcepcion
    /// se lance al intentar cargar una segunda llamada con solamente los mismos datos de origen y
    /// destino de una llamada Local ya existente
    /// </summary>
    [TestMethod]
    public void ValidateCentralitaException()
    {
      //Arrange
      Centralita c = new Centralita("Centralita ValidateCentralitaException");
      Llamada ll1 = new Local("44455566", 1, "11122233", 5);
      Llamada ll2 = new Local("44455566", 1, "11122233", 5);
      //Act
      c = c + ll1;
      c = c + ll2;
      //Assert
      //Assert.
    }
  }
}
