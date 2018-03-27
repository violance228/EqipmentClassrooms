using System;
using Common.Entities;
using EqipmentClassrooms.Domain;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace EqipmentClassroomsArea.Tests
{ [TestClass]
    public class EqipmentTypeUnitTest
    {
        
        private readonly string _name = "Назва";
        private readonly string _definition = "Визначення";
        private readonly string _eqipmentnametype = "Назва типу абладнання";

        [TestMethod]
        public void EqipmentType_Instance_IsNotNull()
        {
            EqipmentType eqipmenttype = new EqipmentType(_name, _definition, _eqipmentnametype);
            Assert.IsNotNull(eqipmenttype);
        }
        [TestMethod]
        public void EqipmentType_IsInstanceOfEntity()
        {
            EqipmentType eqipmenttype = new EqipmentType(_name, _definition, _eqipmentnametype);
            Assert.IsInstanceOfType(eqipmenttype, typeof(Entity));
        }
        [TestMethod]
        public void EqipmentType_Name_Initialized()
        {
            EqipmentType eqipmenttype = new EqipmentType(_name, _definition, _eqipmentnametype);
            Assert.AreEqual(eqipmenttype.Name, _name);
        }
        [TestMethod]
        public void EqipmentType_definition_Initialized()
        {
            EqipmentType eqipmenttype = new EqipmentType(_name, _definition, _eqipmentnametype);
            Assert.AreEqual(eqipmenttype.Definition, _definition);
        }
        [TestMethod]
        public void EqipmentType_eqipmentnametype_Initialized()
        {
            EqipmentType eqipmenttype = new EqipmentType(_name, _definition, _eqipmentnametype);
            Assert.AreEqual(eqipmenttype.EqipmentNameType, _eqipmentnametype);
        }
        [TestMethod]
        public void EqipmentType_Key_ContainsName()
        {
            EqipmentType eqipmenttype = new EqipmentType(_name, _definition, _eqipmentnametype);
            Assert.IsTrue(eqipmenttype.Key.Contains(_name));
        }

        [TestMethod]
        public void EqipmentType_ToString_ContainsName()
        {
            EqipmentType eqipmenttype = new EqipmentType(_name, _definition, _eqipmentnametype);
            Assert.IsTrue(eqipmenttype.ToString().Contains(_name));
        }

        [TestMethod]
        public void EqipmentType_Key_ContainsDefinition()
        {
            EqipmentType eqipmenttype = new EqipmentType(_name, _definition, _eqipmentnametype);
            Assert.IsTrue(eqipmenttype.ToString().Contains(_definition));
        }

        [TestMethod]
        public void EqipmentType_ToString_ContainsEqipmentNameType()
        {
            EqipmentType eqipmenttype = new EqipmentType(_name, _definition, _eqipmentnametype);
            Assert.IsTrue(eqipmenttype.ToString().Contains(_eqipmentnametype));
        }
    }
}
