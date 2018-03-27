using System;
using System.IO;
using System.Xml.Serialization;
using EqipmentClassrooms.Data;
using EqipmentClassrooms.FileIO.Interfaces;

namespace EqipmentClassrooms.FileIO
{

    public class EqipmentClassroomsXmlSerializationController :
        IEqipmentClassroomsFileIoController
    {
        public string FileTypeCaption { get { return "Файл формату XML"; } }

        public string FileExtension { get { return ".xml"; } }

        public EqipmentClassroomsXmlSerializationController()
        {
        }

        public void Save(EqipmentClassroomsDataSet dataSet, string fileName)
        {
            // граничні оператори
            string ext = Path.GetExtension(fileName).ToLower();
            if (ext != this.FileExtension) return;
            //CorrectionFileName(ref fileName);
            using (FileStream fSteam = File.Create(fileName))
            {
                XmlSerializer xmlSerializer =
                    new XmlSerializer(typeof(EqipmentClassroomsDataSet));
                xmlSerializer.Serialize(fSteam, dataSet);
            }
        }

        public void Load(ref EqipmentClassroomsDataSet dataSet, string fileName)
        {
            // граничні оператори
            string ext = Path.GetExtension(fileName).ToLower();
            if (ext != this.FileExtension)
            {
                throw new ArgumentException(
                    "Помилкове розширення файлу: для файлів, "
                    + "щозберігають результат XML-серіалізації "
                    + "даних, використовується розширення "
                    + this.FileExtension);
            };
            using (FileStream fSteam = File.OpenRead(fileName))
            {
                XmlSerializer xmlSerializer =
                    new XmlSerializer(typeof(EqipmentClassroomsDataSet));
                dataSet = (EqipmentClassroomsDataSet)xmlSerializer.Deserialize(fSteam);
            }
        }
    }
}
