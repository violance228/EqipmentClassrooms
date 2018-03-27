using Common.Entities;
using EqipmentClassrooms.Domain;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace EqipmentClassroomsArea.Tests
{   [TestClass]
    public class AudienceUnitTest
    {       
            private readonly string _name = "Назва";
            private readonly string _nametypeaudience = "Назва типу аудиторії";
        private readonly uint _number = 305;

            [TestMethod]
            public void Audience_Instance_IsNotNull()
            {
                Audience audience = new Audience(_name, _nametypeaudience, _number);
                Assert.IsNotNull(audience);
            }
            [TestMethod]
            public void Audience_IsInstanceOfEntity()
            {
                Audience audience = new Audience(_name, _nametypeaudience, _number);
                Assert.IsInstanceOfType(audience, typeof(Entity));
            }
            [TestMethod]
            public void Audience_Name_Initialized()
            {
                Audience audience = new Audience(_name, _nametypeaudience, _number);
                Assert.AreEqual(audience.Name, _name);
            }
            [TestMethod]
            public void Audience_NameTypeAudience_Initialized()
            {
                Audience audience= new Audience(_name, _nametypeaudience, _number);
                Assert.AreEqual(audience.NameTypeAudience, _nametypeaudience);
            }
            
            [TestMethod]
            public void Audience_Key_ContainsName()
            {
                Audience audience = new Audience(_name, _nametypeaudience,_number);
                Assert.IsTrue(audience.Key.Contains(_name));
            }

            [TestMethod]
            public void Audience_ToString_ContainsName()
            {
                Audience audience = new Audience(_name, _nametypeaudience, _number);
                Assert.IsTrue(audience.ToString().Contains(_name));
            }

            [TestMethod]
            public void Audience_Key_ContainsNameTypeAudience()
            {
                Audience audience = new Audience(_name, _nametypeaudience,_number);
                Assert.IsTrue(audience.ToString().Contains(_nametypeaudience));
            }

            [TestMethod]
            public void Audience_ToString_ContainsNameTypeEqipment()
            {
                Audience audience = new Audience(_name, _nametypeaudience,_number);
                Assert.IsTrue(audience.ToString().Contains(_name));
            }
    }
}

