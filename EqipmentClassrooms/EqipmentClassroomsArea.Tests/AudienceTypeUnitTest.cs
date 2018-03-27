using Common.Entities;
using EqipmentClassrooms.Domain;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace EqipmentClassroomsArea.Tests
{
        [TestClass]
        public class AudienceTypeTypesUnitTest
        {
            private readonly string _name = "Назва";


            [TestMethod]
            public void AudienceType_Instance_IsNotNull()
            {
                AudienceType audiencetype = new AudienceType(_name);
                Assert.IsNotNull(audiencetype);
            }
            [TestMethod]
            public void AudienceType_IsInstanceOfEntity()
            {
                AudienceType audiencetype = new AudienceType(_name);
                Assert.IsInstanceOfType(audiencetype, typeof(Entity));
            }
            [TestMethod]
            public void AudienceType_Name_Initialized()
            {
                AudienceType audiencetype = new AudienceType(_name);
                Assert.AreEqual(audiencetype.Name, _name);
            }

            [TestMethod]
            public void AudienceType_Key_ContainsName()
            {
                AudienceType audiencetype = new AudienceType(_name);
                Assert.IsTrue(audiencetype.Key.Contains(_name));
            }

            [TestMethod]
            public void AudienceType_ToString_ContainsName()
            {
                AudienceType audiencetype = new AudienceType(_name);
                Assert.IsTrue(audiencetype.ToString().Contains(_name));
            }

        }
    
}
