//using EqipmentClassrooms.StudyObjects;
using System;
using System.Text;
using System.Collections.Generic;
using EqipmentClassrooms.Domain;
using EqipmentClassrooms.Data;


namespace EqipmentClassrom.Training
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.Black;
            Console.Clear();
            Console.Title = "EqipmentClassrom.Traning";
            Console.OutputEncoding = Encoding.Unicode;
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Робота з даними ПО \"Обладнання аудиторії\"");

            //StudyDataSet();
            //StudyFileIO();

            Console.ReadKey(true);
        }
    }
}
//        //static readonly EqipmentClassroomsStudyObjects Objects =
//        //   new EqipmentClassroomsStudyObjects();

//        //private static void StudyObjects()
//        //{
//        //    Console.WriteLine("\n============ StudyObjects ============\n");

//        //    StudyObjects_AudienceObject();
//        //    StudyObjects_EqipmentObjects();
//        //    StudyObjects_AudienceEqipmentTypesObjects();
//        //    StudyObjects_AudienceTypeObject();
//        //    StudyObjects_EqipmentAudienceObject();
//        //    StudyObjects_EqipmentTypeObject();
//        //}
//        //private static void StudyObjects_AudienceObject()
//        //{
//        //    Console.WriteLine("\n-StudyObjects_AudienceObject-\n");
//        //    Console.WriteLine("AB:\n{0}", Objects.AB);

//        //    Console.WriteLine("\nObjects.Audience:");
//        //    foreach (var obj in Objects.Audience)
//        //    {
//        //        Console.WriteLine(obj);
//        //    }
//        //}
//        //private static void StudyObjects_EqipmentObjects()
//        //{
//        //    Console.WriteLine("\n-StudyObjects_EqipmentObjects-\n");
//        //    Console.WriteLine("Extinguisher:\n{0}", Objects.Desk);

//        //    Console.WriteLine("\nObjects.Eqipment:");
//        //    foreach (var obj in Objects.Eqipment)
//        //    {
//        //        Console.WriteLine(obj);
//        //    }
//        //}
//        //private static void StudyObjects_AudienceEqipmentTypesObjects()
//        //{
//        //    Console.WriteLine("\n-StudyObjects_AudienceEqipmentTypesObjects-\n");
//        //    Console.WriteLine("Extinguisher:\n{0}", Objects.Extinguisher);

//        //    Console.WriteLine("\nObjects.AudienceEqipmentTypes:");
//        //    foreach (var obj in Objects.AudienceEqipmentTypes)
//        //    {
//        //        Console.WriteLine(obj);
//        //    }

//        //}
//        //private static void StudyObjects_AudienceTypeObject()
//        //{
//        //    Console.WriteLine("\n-StudyObjects_AudienceTypeObject-\n");
//        //    Console.WriteLine("ComputerAudience:\n{0}", Objects.ComputerAudience);

//        //    Console.WriteLine("\nObjects.AudienceType:");
//        //    foreach (var obj in Objects.AudienceType)
//        //    {
//        //        Console.WriteLine(obj);
//        //    }
//        //}
//        //private static void StudyObjects_EqipmentAudienceObject()
//        //{
//        //    Console.WriteLine("\n-StudyObjects_EqipmentAudienceObject-\n");
//        //    Console.WriteLine("Extinguisher:\n{0}", Objects.Extinguisher);

//        //    Console.WriteLine("\nObjects.EqipmentAudience:");
//        //    foreach (var obj in Objects.EqipmentAudience)
//        //    {
//        //        Console.WriteLine(obj);
//        //    }
//        //}
//        //private static void StudyObjects_EqipmentTypeObject()
//        //{
//        //    Console.WriteLine("\n-StudyObjects_EqipmentTypeObject-\n");
//        //    Console.WriteLine("Information:\n{0}", Objects.Information);

//        //    Console.WriteLine("\nObjects.EqipmentType:");
//        //    foreach (var obj in Objects.EqipmentType)
//        //    {
//        //        Console.WriteLine(obj);
//        //    }
//        //}

//        private static void StudyDataSet()
//        {
//            Console.WriteLine("\n---StudyData---");
//            StudyData_CommonOperations();
//            StudyData_AudienceOperations();
//            StudyData_AudiencesOperations();
//            StudyData_AudienceEqipmentTypesOperations();
//            StudyData_AudienceEqipmentTypessOperations();
//            StudyData_AudienceTypesOperations();
//            StudyData_AudienceTypeOperations();
//            StudyData_EqipmentsOperations();
//            StudyData_EqipmentOperations();
//            StudyData_EqipmentAudiencesOperations();
//            StudyData_EqipmentAudienceOperations();
//            StudyData_EqipmentTypesOperations();
//            StudyData_EqipmentTypeOperations();
//        }
//        private static void StudyData_CommonOperations()
//        {
//            EqipmentClassrooms.Data.EqipmentClassroomsDataSet dataSet = new EqipmentClassrooms.Data.EqipmentClassroomsDataSet();
//            Console.WriteLine("dataSet:\n{0}", dataSet);
//            dataSet.CreateMinTestData();
//            Console.WriteLine("dataSet:\n{0}", dataSet);
//            Console.WriteLine("dataSet.Keys:\n{0}", dataSet.ToKeysString());
//            dataSet.Clear();
//            Console.WriteLine("dataSet:\n{0}", dataSet);
//        }
//        private static void StudyData_AudiencesOperations()
//        {
//            Console.WriteLine("\n--- StudyData_AudiencesOperations ---\n");

//            EqipmentClassroomsDataSet dataSet = new EqipmentClassroomsDataSet();

//            Console.WriteLine("ShowIndentedObjectsString:");

//            IEnumerable<Audience> audiences = dataSet.Audiences;

//            //Console.WriteLine("audiences:");
//            //foreach (var obj in audiences)
//            //{
//            //    Console.WriteLine(obj);
//            //}
//            dataSet.CreateMinTestData();
//            Console.WriteLine(audiences.ShowIndentedObjectsString());
//            Console.WriteLine("audience:");
//            foreach (var obj in audiences)
//            {
//                Console.WriteLine(obj);
//            }

//            Console.WriteLine("audience.Keys:");
//            foreach (var obj in audiences)
//            {
//                Console.WriteLine(obj.Key);
//            }

//            dataSet.Clear();
//            Console.WriteLine("audience:");
//            foreach (var obj in audiences)
//            {
//                Console.WriteLine(obj);
//            }

//            Console.WriteLine("audience.Keys:");
//            foreach (var obj in audiences)
//            {
//                Console.WriteLine(obj.Key);
//            }
//        }
//        private static void StudyData_AudienceOperations()
//        {
//            Console.WriteLine("\n--- StudyData_AudienceOperations ---\n");

//            EqipmentClassrooms.Data.EqipmentClassroomsDataSet dataSet = new EqipmentClassrooms.Data.EqipmentClassroomsDataSet();
//            dataSet.CreateMinTestData();
//            if (dataSet.Audiences.Count == 0)
//            {
//                Console.WriteLine("Об'єкти типу Audience відсутні\n");
//                return;
//            }
//            Audience audience = dataSet.Audiences[0];
//            Console.WriteLine("audience:\t{0}", audience);
//            string key = audience.Key;
//            if (string.IsNullOrWhiteSpace(key))
//            {
//                Console.WriteLine("ключ не визначений\n");
//                return;
//            }
//            Audience audience2 = dataSet.AudienceByKey(key);
//            Console.WriteLine("audience2:\t{0}", audience2);
//        }
//        private static void StudyData_AudienceEqipmentTypesOperations()
//        {
//            Console.WriteLine("\n--- StudyData_AudiencesEqipmentTypesOperations ---\n");

//            EqipmentClassroomsDataSet dataSet = new EqipmentClassroomsDataSet();

//            Console.WriteLine("ShowIndentedObjectsString:");

//            IEnumerable<AudienceEqipmentTypes> audienceeqipmenttypes = dataSet.AudienceEqipmentTypess;

//            dataSet.CreateMinTestData();
//            Console.WriteLine(audienceeqipmenttypes.ShowIndentedObjectsString());
//            Console.WriteLine("audienceeqipmenttypes:");
//            foreach (var obj in audienceeqipmenttypes)
//            {
//                Console.WriteLine(obj);
//            }

//            Console.WriteLine("audienceeqipmenttypes.Keys:");
//            foreach (var obj in audienceeqipmenttypes)
//            {
//                Console.WriteLine(obj.Key);
//            }

//            dataSet.Clear();
//            Console.WriteLine("audienceeqipmenttypes:");
//            foreach (var obj in audienceeqipmenttypes)
//            {
//                Console.WriteLine(obj);
//            }

//            Console.WriteLine("audienceeqipmenttypes.Keys:");
//            foreach (var obj in audienceeqipmenttypes)
//            {
//                Console.WriteLine(obj.Key);
//            }
//        }
//        private static void StudyData_AudienceEqipmentTypessOperations()
//        {
//            Console.WriteLine("\n--- StudyData_AudienceOperations ---\n");

//            EqipmentClassrooms.Data.EqipmentClassroomsDataSet dataSet = new EqipmentClassrooms.Data.EqipmentClassroomsDataSet();
//            dataSet.CreateMinTestData();
//            if (dataSet.AudienceEqipmentTypess.Count == 0)
//            {
//                Console.WriteLine("Об'єкти типу AudiedienceEqipmentTypess відсутні\n");
//                return;
//            }
//            AudienceEqipmentTypes audienceeqipmenttypess = dataSet.AudienceEqipmentTypess[0];
//            Console.WriteLine("audienceeqipmenttypes:\t{0}", audienceeqipmenttypess);
//            string key = audienceeqipmenttypess.Key;
//            if (string.IsNullOrWhiteSpace(key))
//            {
//                Console.WriteLine("ключ не визначений\n");
//                return;
//            }
//            AudienceEqipmentTypes audienceeqipmenttypess2 = dataSet.AudienceEqipmentTypesByKey(key);
//            Console.WriteLine("audienceeqipmenttypes2:\t{0}", audienceeqipmenttypess2);
//        }
//        private static void StudyData_AudienceTypesOperations()
//        {
//            Console.WriteLine("\n--- StudyData_AudiencesEqipmentTypesOperations ---\n");

//            EqipmentClassroomsDataSet dataSet = new EqipmentClassroomsDataSet();

//            Console.WriteLine("ShowIndentedObjectsString:");

//            IEnumerable<AudienceType> audiencetypes = dataSet.AudienceTypes;

//            dataSet.CreateMinTestData();
//            Console.WriteLine(audiencetypes.ShowIndentedObjectsString());
//            Console.WriteLine("audiencetypes:");
//            foreach (var obj in audiencetypes)
//            {
//                Console.WriteLine(obj);
//            }

//            Console.WriteLine("audiencetypes.Keys:");
//            foreach (var obj in audiencetypes)
//            {
//                Console.WriteLine(obj.Key);
//            }

//            dataSet.Clear();
//            Console.WriteLine("audiencetypes:");
//            foreach (var obj in audiencetypes)
//            {
//                Console.WriteLine(obj);
//            }

//            Console.WriteLine("audiencetypes.Keys:");
//            foreach (var obj in audiencetypes)
//            {
//                Console.WriteLine(obj.Key);
//            }
//        }
//        private static void StudyData_AudienceTypeOperations()
//        {
//            Console.WriteLine("\n--- StudyData_AudienceTypeOperations ---\n");

//            EqipmentClassrooms.Data.EqipmentClassroomsDataSet dataSet = new EqipmentClassrooms.Data.EqipmentClassroomsDataSet();
//            dataSet.CreateMinTestData();
//            if (dataSet.AudienceTypes.Count == 0)
//            {
//                Console.WriteLine("Об'єкти типу AudiedienceTypes відсутні\n");
//                return;
//            }
//            AudienceType audiencetype = dataSet.AudienceTypes[0];
//            Console.WriteLine("audiencetypes:\t{0}", audiencetype);
//            string key = audiencetype.Key;
//            if (string.IsNullOrWhiteSpace(key))
//            {
//                Console.WriteLine("ключ не визначений\n");
//                return;
//            }
//            AudienceType audiencetype2 = dataSet.AudienceTypeByKey(key);
//            Console.WriteLine("audiencetypes2:\t{0}", audiencetype2);
//        }
//        private static void StudyData_EqipmentsOperations()
//        {
//            Console.WriteLine("\n--- StudyData_EqipmentOperations ---\n");

//            EqipmentClassroomsDataSet dataSet = new EqipmentClassroomsDataSet();

//            Console.WriteLine("ShowIndentedObjectsString:");

//            IEnumerable<Eqipment> eqipments = dataSet.Eqipments;

//            dataSet.CreateMinTestData();
//            Console.WriteLine(eqipments.ShowIndentedObjectsString());
//            Console.WriteLine("eqipments:");
//            foreach (var obj in eqipments)
//            {
//                Console.WriteLine(obj);
//            }

//            Console.WriteLine("eqipments.Keys:");
//            foreach (var obj in eqipments)
//            {
//                Console.WriteLine(obj.Key);
//            }

//            dataSet.Clear();
//            Console.WriteLine("eqipments:");
//            foreach (var obj in eqipments)
//            {
//                Console.WriteLine(obj);
//            }

//            Console.WriteLine("eqipments.Keys:");
//            foreach (var obj in eqipments)
//            {
//                Console.WriteLine(obj.Key);
//            }
//        }
//        private static void StudyData_EqipmentOperations()
//        {
//            Console.WriteLine("\n--- StudyData_EqipmentOperations ---\n");

//            EqipmentClassrooms.Data.EqipmentClassroomsDataSet dataSet = new EqipmentClassrooms.Data.EqipmentClassroomsDataSet();
//            dataSet.CreateMinTestData();
//            if (dataSet.Eqipments.Count == 0)
//            {
//                Console.WriteLine("Об'єкти типу Eqipments відсутні\n");
//                return;
//            }
//            Eqipment eqipments = dataSet.Eqipments[0];
//            Console.WriteLine("eqipments:\t{0}", eqipments);
//            string key = eqipments.Key;
//            if (string.IsNullOrWhiteSpace(key))
//            {
//                Console.WriteLine("ключ не визначений\n");
//                return;
//            }
//            AudienceType eqipments2 = dataSet.AudienceTypeByKey(key);
//            Console.WriteLine("eqipments2:\t{0}", eqipments2);
//        }
//        private static void StudyData_EqipmentAudiencesOperations()
//        {
//            Console.WriteLine("\n--- StudyData_EqipmentAudienceOperations ---\n");

//            EqipmentClassroomsDataSet dataSet = new EqipmentClassroomsDataSet();

//            Console.WriteLine("ShowIndentedObjectsString:");

//            IEnumerable<EqipmentAudience> eqipmentaudiences = dataSet.EqipmentAudiences;

//            dataSet.CreateMinTestData();
//            Console.WriteLine(eqipmentaudiences.ShowIndentedObjectsString());
//            Console.WriteLine("eqipmentaudiences:");
//            foreach (var obj in eqipmentaudiences)
//            {
//                Console.WriteLine(obj);
//            }

//            Console.WriteLine("eqipmentaudiences.Keys:");
//            foreach (var obj in eqipmentaudiences)
//            {
//                Console.WriteLine(obj.Key);
//            }

//            dataSet.Clear();
//            Console.WriteLine("eqipmentaudiences:");
//            foreach (var obj in eqipmentaudiences)
//            {
//                Console.WriteLine(obj);
//            }

//            Console.WriteLine("eqipmentaudiences.Keys:");
//            foreach (var obj in eqipmentaudiences)
//            {
//                Console.WriteLine(obj.Key);
//            }
//        }
//        private static void StudyData_EqipmentAudienceOperations()
//        {
//            Console.WriteLine("\n--- StudyData_EqipmentAudienceOperations ---\n");

//            EqipmentClassrooms.Data.EqipmentClassroomsDataSet dataSet = new EqipmentClassrooms.Data.EqipmentClassroomsDataSet();
//            dataSet.CreateMinTestData();
//            if (dataSet.EqipmentAudiences.Count == 0)
//            {
//                Console.WriteLine("Об'єкти типу EqipmentAudience відсутні\n");
//                return;
//            }
//            EqipmentAudience eqipmentaudience = dataSet.EqipmentAudiences[0];
//            Console.WriteLine("eqipmentaudience:\t{0}", eqipmentaudience);
//            string key = eqipmentaudience.Key;
//            if (string.IsNullOrWhiteSpace(key))
//            {
//                Console.WriteLine("ключ не визначений\n");
//                return;
//            }
//            EqipmentAudience eqipmentaudience2 = dataSet.EqipmentAudienceByKey(key);
//            Console.WriteLine("audienceaudience2:\t{0}", eqipmentaudience2);
//        }
//        private static void StudyData_EqipmentTypesOperations()
//        {
//            Console.WriteLine("\n--- StudyData_EqipmentTypeOperations ---\n");

//            EqipmentClassroomsDataSet dataSet = new EqipmentClassroomsDataSet();

//            Console.WriteLine("ShowIndentedObjectsString:");

//            IEnumerable<EqipmentType> eqipmenttypes = dataSet.EqipmentTypes;

//            dataSet.CreateMinTestData();
//            Console.WriteLine(eqipmenttypes.ShowIndentedObjectsString());
//            Console.WriteLine("eqipmenttypes:");
//            foreach (var obj in eqipmenttypes)
//            {
//                Console.WriteLine(obj);
//            }

//            Console.WriteLine("eqipmenttypes.Keys:");
//            foreach (var obj in eqipmenttypes)
//            {
//                Console.WriteLine(obj.Key);
//            }

//            dataSet.Clear();
//            Console.WriteLine("eqipmenttypes:");
//            foreach (var obj in eqipmenttypes)
//            {
//                Console.WriteLine(obj);
//            }

//            Console.WriteLine("eqipmenttypes.Keys:");
//            foreach (var obj in eqipmenttypes)
//            {
//                Console.WriteLine(obj.Key);
//            }
//        }
//        private static void StudyData_EqipmentTypeOperations()
//        {
//            Console.WriteLine("\n--- StudyData_EqipmentTypeOperations ---\n");

//            EqipmentClassrooms.Data.EqipmentClassroomsDataSet dataSet = new EqipmentClassrooms.Data.EqipmentClassroomsDataSet();
//            dataSet.CreateMinTestData();
//            if (dataSet.EqipmentTypes.Count == 0)
//            {
//                Console.WriteLine("Об'єкти типу EqipmentType відсутні\n");
//                return;
//            }
//            EqipmentType eqipmenttypes = dataSet.EqipmentTypes[0];
//            Console.WriteLine("eqipmenttype:\t{0}", eqipmenttypes);
//            string key = eqipmenttypes.Key;
//            if (string.IsNullOrWhiteSpace(key))
//            {
//                Console.WriteLine("ключ не визначений\n");
//                return;
//            }
//            EqipmentAudience eqipmenttypes2 = dataSet.EqipmentAudienceByKey(key);
//            Console.WriteLine("audiencetype2:\t{0}", eqipmenttypes2);
//        }


//        private static void StudyFileIO()
//        {
//            Console.WriteLine("\n============ StudyFileIO ============\n");

//            StudyFileIO_XmlFileIoController();

//        }
//        private static void StudyFileIO_XmlFileIoController()
//        {
//            Console.WriteLine("\n--- StudyFileIO_XmlFileIOController ---\n");

//            var fileIoController = new EqipmentClassroomsXmlFileIoController();

//            Console.WriteLine("fileIoController.FileTypeCaption:\t{0}",
//                fileIoController.FileTypeCaption);
//            Console.WriteLine("fileIoController.FileExtension:\t{0}",
//                fileIoController.FileExtension);

//            var dataSet = new EqipmentClassroomsDataSet();
//            dataSet.CreateMinTestData();

//            Console.WriteLine("dataSet:\n{0}", dataSet);

//            string fileName = "EqipmentClassrooms.xml";
//            Console.WriteLine("fileName:\t{0}", fileName);

//            fileIoController.Save(dataSet, fileName);

//            dataSet.Clear();
//            Console.WriteLine("dataSet:\n{0}", dataSet);

//            fileIoController.Load(ref dataSet, fileName);
//            Console.WriteLine("dataSet:\n{0}", dataSet);

//            dataSet.Clear();
//        }


//    }
//}

