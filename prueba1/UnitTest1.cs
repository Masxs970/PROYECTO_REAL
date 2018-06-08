using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ProyectoTienda;
namespace prueba1
{
    [TestClass]
    public class usuario
    {
        [TestMethod]
        public void pursuit_test()
        {
            Usuarios u = new Usuarios();
            u.Users = "fransq";
            u.Passwords = "12345";
            
            bool result = u.Pursuit();
            Assert.AreEqual(true, result);
        }
    }
}
