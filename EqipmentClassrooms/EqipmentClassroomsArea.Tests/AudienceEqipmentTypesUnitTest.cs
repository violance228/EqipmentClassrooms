using Common.Entities;
using System;
using EqipmentClassrooms.Domain;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace EqipmentClassroomsArea.Tests
{
    [TestClass]
    public class AudienceEqipmentTypesUnitTest
    {
        private readonly string _name="Назва";
        private readonly string _nametypeaudience="Назва типу аудиторії";
        private readonly string _nametypeeqipment="Назва типу обладнання";

        [TestMethod]
        public void AudienceEqipmentTypes_Instance_IsNotNull()
        {
            AudienceEqipmentTypes audienceeqipmenttypes = new AudienceEqipmentTypes(_name, _nametypeaudience, _nametypeeqipment);
            Assert.IsNotNull(audienceeqipmenttypes);
        }
        [TestMethod]
        public void AudienceEqipmentTypes_IsInstanceOfEntity()
        {
            AudienceEqipmentTypes audienceeqipmenttypes = new AudienceEqipmentTypes(_name, _nametypeaudience, _nametypeeqipment);
            Assert.IsInstanceOfType(audienceeqipmenttypes, typeof(Entity));
        }
        [TestMethod]
        public void AudienceEqipmentTypes_Name_Initialized()
        {
            AudienceEqipmentTypes audienceeqipmenttypes = new AudienceEqipmentTypes(_name, _nametypeaudience, _nametypeeqipment);
            Assert.AreEqual(audienceeqipmenttypes.Name, _name);
        }
       
        [TestMethod]
        public void AudienceEqipmentTypes_Key_ContainsName()
        {
            AudienceEqipmentTypes audienceeqipmentypes = new AudienceEqipmentTypes(_name, _nametypeaudience, _nametypeeqipment);
            Assert.IsTrue(audienceeqipmentypes.Key.Contains(_name));
        }

        [TestMethod]
        public void AudienceEqipmentTypes_ToString_ContainsName()
        {
            AudienceEqipmentTypes audienceeqipmentypes = new AudienceEqipmentTypes(_name, _nametypeaudience, _nametypeeqipment);
            Assert.IsTrue(audienceeqipmentypes.ToString().Contains(_name));
        }

        [TestMethod]
        public void AudienceEqipmentTypes_Key_ContainsNameTypeAudience()
        {
            AudienceEqipmentTypes audienceeqipmentypes = new AudienceEqipmentTypes(_name, _nametypeaudience, _nametypeeqipment);
            Assert.IsTrue(audienceeqipmentypes.ToString().Contains(_nametypeaudience));
        }

        [TestMethod]
        public void AudienceEqipmentTypes_ToString_ContainsNameTypeEqipment()
        {
            AudienceEqipmentTypes audienceeqipmentypes = new AudienceEqipmentTypes(_name, _nametypeaudience, _nametypeeqipment);
            Assert.IsTrue(audienceeqipmentypes.ToString().Contains(_nametypeeqipment));
        }

    }
}
