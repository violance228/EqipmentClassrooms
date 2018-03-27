using System;
using Common.Entities;
using EqipmentClassrooms.Domain;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace EqipmentClassroomsArea.Tests
{   [TestClass]
    class EqipmentUnitTest
    {
        private readonly DateTime _date = new DateTime(2000,1,1);
        private readonly string _name = "Назва";
        private readonly string _eqipmentnametype = "Назва типу обладнання";
        private readonly string _description = "Опис";

        [TestMethod]
        public void Eqipment_Instance_IsNotNull()
        {
            Eqipment eqipment = new Eqipment(_name,_date, _eqipmentnametype, _description);
            Assert.IsNotNull(eqipment);
        }

        [TestMethod]
        public void Eqipment_IsInstanceOfIEntity()
        {
            Eqipment eqipment = new Eqipment(_name, _date, _eqipmentnametype, _description);
            Assert.IsInstanceOfType(eqipment, typeof(Entity));
        }

        [TestMethod]
        public void eqipment_name_Initialized()
        {
            //
            Eqipment eqipment = new Eqipment(_name, _date, _eqipmentnametype, _description);
            //
            Assert.AreEqual(eqipment.Name, _name);
        }

        [TestMethod]
        public void eqipment_Date_Initialized()
        {
            Eqipment eqipment = new Eqipment(_name, _date, _eqipmentnametype, _description);
            Assert.AreEqual(eqipment.Date, _date);
        }

        [TestMethod]
        public void Eqipment_EqipmentNameType_Initialized()
        {
            Eqipment eqipment = new Eqipment(_name, _date, _eqipmentnametype, _description);
            Assert.AreEqual(eqipment.EqipmentNameType, _eqipmentnametype);
        }
        [TestMethod]
        public void Eqipment_Description_Initialized()
        {
            Eqipment eqipment = new Eqipment(_name, _date, _eqipmentnametype, _description);
            Assert.AreEqual(eqipment.Description, _description);
        }
        [TestMethod]
        public void Eqipment_Key_ContainsName()
        {
            Eqipment eqipment = new Eqipment(_name, _date, _eqipmentnametype, _description);
            Assert.IsTrue(eqipment.Key.Contains(_name));
        }
        [TestMethod]
        public void Eqipment_Key_ContainsDateInDbFormat()
        {
            Eqipment eqipment = new Eqipment(_name, _date, _eqipmentnametype, _description);
            Assert.IsTrue(eqipment.Key.Contains(_date.ToString("yyyy.MM.dd")));
        }
        [TestMethod]
        public void Eqipment_ToString_ContainsName()
        {
            Eqipment eqipment = new Eqipment(_name, _date, _eqipmentnametype, _description);
            Assert.IsTrue(eqipment.ToString().Contains(_name));
        }
        [TestMethod]
        public void Eqipment_ToString_ContainsDateInShortFormat()
        {
            Eqipment eqipment = new Eqipment(_name, _date, _eqipmentnametype, _description);
            Assert.IsTrue(eqipment.ToString().Contains(_date.ToString("d")));
        }
        [TestMethod]
        public void Eqipment_ToString_ContainsEqipmentNameType()
        {
            Eqipment eqipment = new Eqipment(_name, _date, _eqipmentnametype, _description);
            Assert.IsTrue(eqipment.ToString().Contains(_eqipmentnametype.ToString()));
        }
        [TestMethod]
        public void Eqipment_ToString_ContainsDescription()
        {
            Eqipment eqipment = new Eqipment(_name, _date, _eqipmentnametype, _description);
            Assert.IsTrue(eqipment.ToString().Contains(_description.ToString()));
        }
    }
}
