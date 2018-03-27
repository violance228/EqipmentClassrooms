using System;
using Common.Entities;
using EqipmentClassrooms.Domain;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace EqipmentClassroomsArea.Tests
{ [TestClass]
    public class EqipmentAudienceUnitTest
    {
            private readonly string _name = "Назва";
            private readonly string _eqipmentnametype = "Назва типу обладнання";
            

            [TestMethod]
            public void EqipmentAudience_Instance_IsNotNull()
            {
                EqipmentAudience audienceeqipmenttypes = new EqipmentAudience(_name, _eqipmentnametype);
                Assert.IsNotNull(audienceeqipmenttypes);
            }
            [TestMethod]
            public void EqipmentAudience_IsInstanceOfEntity()
            {
            EqipmentAudience eqipmentaudience = new EqipmentAudience(_name, _eqipmentnametype);
                Assert.IsInstanceOfType(eqipmentaudience, typeof(Entity));
            }
            [TestMethod]
            public void EqipmentAudience_Name_Initialized()
            {
            EqipmentAudience eqipmentaudience = new EqipmentAudience(_name, _eqipmentnametype);
                Assert.AreEqual(eqipmentaudience.Name, _name);
            }
            [TestMethod]
            public void EqipmentAudience_NameTypeAudience_Initialized()
            {
            EqipmentAudience eqipmentaudience = new EqipmentAudience(_name, _eqipmentnametype);
                Assert.AreEqual(eqipmentaudience.EqipmentNameType, _eqipmentnametype);
            }
            
            [TestMethod]
            public void EqipmentAudience_Key_ContainsName()
            {
            EqipmentAudience eqipmentaudience = new EqipmentAudience(_name, _eqipmentnametype);
                Assert.IsTrue(eqipmentaudience.Key.Contains(_name));
            }

            [TestMethod]
            public void EqipmentAudience_ToString_ContainsName()
            {
            EqipmentAudience eqipmentaudience = new EqipmentAudience(_name, _eqipmentnametype);
                Assert.IsTrue(eqipmentaudience.ToString().Contains(_name));
            }

            [TestMethod]
            public void EqipmentAudience_Key_ContainsNameTypeAudience()
            {
            EqipmentAudience eqipmentaudience = new EqipmentAudience(_name, _eqipmentnametype);
                Assert.IsTrue(eqipmentaudience.ToString().Contains(_eqipmentnametype));
            }

            
    }
}
