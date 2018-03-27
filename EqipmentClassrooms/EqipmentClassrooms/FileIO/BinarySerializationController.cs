//using EqipmentClassrooms.FileIO.Interfaces;
//using System;
//using System.IO;
//using System.Runtime.Serialization.Formatters.Binary;
//using System.Text.RegularExpressions;

//namespace EqipmentClassrooms.FileIO
//{   
//    /*
//    public class BinarySerializationController<D>
//        : FileIOController<D> where D : class, IEntitiesDataSet
//    {

//        public BinarySerializationController()
//        {
//            FileTypeCaption = "Формат двійкової серіалізації";
//            FileExtension = ".enbd";
//        }

//        public override string FileExtension
//        {
//            get { return base.FileExtension; }
//            set
//            {
//                if (value == null || !Regex.Match(value,
//                    @"\A\s*\.[A-Za-z]{1,3}(bd)\s*\z").Success)
//                {
//                    throw new FormatException(
//                        "Розширення файлу з даними двійкової "
//                        + "серіалізації повинно об'єднувати "
//                        + "символ крапки, 1-3 латинських літери, "
//                        + "що вказують на предметну область, "
//                        + "та сполучення символів bd (binary data), "
//                        + "(за замовчанням: \".enbd\")");
//                }
//                base.FileExtension = value.Trim().ToLower();
//            }
//        }

//        public override void Load(ref D dataSet, string fileName)
//        {
//            // граничні оператори
//            string ext = Path.GetExtension(fileName).ToLower();
//            if (ext != this.FileExtension)
//            {
//                throw new ArgumentException(
//                    "Помилкове розширення файлу: для файлів, "
//                    + "що зберігають результат двійкової "
//                    + "серіалізації даних про сутності ПО "
//                    + "у контролері типу " + this.GetType().Name
//                    + " передбачено розширення "
//                    + this.FileExtension);
//            };
//            BinaryFormatter bFormatter = new BinaryFormatter();
//            using (FileStream fStream = File.OpenRead(fileName))
//            {
//                dataSet = (D)bFormatter.
//                    Deserialize(fStream);
//            }
//        }

//        public override void Save(D dataSet, string fileName)
//        {
//            // граничні оператори
//            string ext = Path.GetExtension(fileName).ToLower();
//            if (ext != this.FileExtension) return;

//            BinaryFormatter bFormatter = new BinaryFormatter();
//            using (var fStream = new FileStream(fileName,
//                FileMode.Create,
//                FileAccess.Write, FileShare.None))
//            {
//                bFormatter.Serialize(fStream, dataSet);
//            }
//        }
//    }*/
//}
