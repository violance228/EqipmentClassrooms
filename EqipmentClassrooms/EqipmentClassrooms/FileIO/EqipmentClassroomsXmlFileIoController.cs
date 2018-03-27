//using System;
//using EqipmentClassrooms.Data;
//using EqipmentClassrooms.Domain;
//using System.Xml;
//using System.Text;
//using EqipmentClassrooms.FileIO.Interfaces;


//namespace EqipmentClassrooms.FileIO
//{
//    public class EqipmentClassroomsXmlFileIoController :IEqipmentClassroomsFileIoController
//    {
//        private string _fileTypeCaption = "Файл формату XML";

//        public string FileTypeCaption
//        {
//            //get{throw new NotImplementedException}
//            get { return _fileTypeCaption; }
//            set
//            {
//                if (string.IsNullOrWhiteSpace(value))
//                {
//                    throw new ArgumentException("FileTypeCaption");
//                }
//                _fileTypeCaption = value;
//            }
//        }
//        private string _fileExtension = ".xml";

//        public virtual string FileExtension
//        {
//            get { return _fileExtension; }
//            set
//            {
//                if (string.IsNullOrWhiteSpace(value))
//                {
//                    throw new ArgumentException("FileTypeCaption");
//                }
//                _fileTypeCaption = value;
//            }
//        }
//        public void Load(ref EqipmentClassroomsDataSet dataSet, string fileName)
//        {
//            XmlTextWriter writer = null;
//            try
//            {
//                writer = new XmlTextWriter(fileName, Encoding.Unicode);
//                WriteData(dataSet, writer);
//            }
//            catch (Exception)
//            {
//                throw;
//            }
//            finally
//            {
//                if (writer != null)
//                    writer.Close();
//            }
//        }
//        private void ReadData(ref EqipmentClassroomsDataSet dataSet, XmlTextReader reader)
//        {
//            while (reader.Read())
//            {
//                if (reader.NodeType == XmlNodeType.Element)
//                {
//                    if (reader.Name == "Audience")
//                    {
//                        ReadAudience(ref dataSet, reader);
//                    }
//                    else if (reader.Name == "AudienceEqipmentType")
//                    {
//                        ReadAudienceEqipmentTypes(ref dataSet, reader);
//                    }
//                    else if (reader.Name == "AudienceType")
//                    {
//                        ReadAudienceType(ref dataSet, reader);
//                    }
//                    else if (reader.Name == "Eqipment")
//                    {
//                        ReadEqipment(ref dataSet, reader);
//                    }
//                    else if (reader.Name == "EqipmentAudience")
//                    {
//                        ReadEqipmentAudience(ref dataSet, reader);
//                    }
//                    else if (reader.Name == "EqipmentType")
//                    {
//                        ReadEqipmentType(ref dataSet, reader);
//                    }
//                }
//            }
//        }
//        private void ReadAudience(ref EqipmentClassroomsDataSet dataSet, XmlTextReader reader)
//        {
//            Audience audience = new Audience
//            {
//                Name = reader.GetAttribute("Name"),
//                NameTypeAudience = reader.GetAttribute("NameTypeAudience"),
//                Number = ReadNumber(reader),
//                Note = reader.GetAttribute("Note")
//            };
//            dataSet.Audiences.Add(audience);
//        }
//        private double? ReadNumber(XmlTextReader reader)
//        {
//            string mNumber = reader.GetAttribute("Number");
//            double? number = string.IsNullOrWhiteSpace(mNumber) ?
//                (double?)null : double.Parse(mNumber);
//            return number;
//        }

//        private void ReadAudienceEqipmentTypes(ref EqipmentClassroomsDataSet dataSet, XmlTextReader reader)
//        {
//            AudienceEqipmentTypes audienceeqipmenttypes = new AudienceEqipmentTypes
//            {
//                Name = reader.GetAttribute("Name"),
//                NameTypeAudience = reader.GetAttribute("NameTypeAudience"),
//                NameTypeEqipment = reader.GetAttribute("NameTypeEqipment"),
//                Note = reader.GetAttribute("Note")
//            };
//            dataSet.AudienceEqipmentTypess.Add(audienceeqipmenttypes);
//        }

//        private void ReadAudienceType(ref EqipmentClassroomsDataSet dataSet, XmlTextReader reader)
//        {
//            AudienceType audiencetype = new AudienceType(reader.GetAttribute("Name"))
//            {
//                NameTypeAudience = reader.GetAttribute("NameTypeAudience"),
//                Definition = reader.GetAttribute("Definition"),
//                Note = reader.GetAttribute("Note")
//            };
//            dataSet.AudienceTypes.Add(audiencetype);
//        }
//        private void ReadEqipment(ref EqipmentClassroomsDataSet dataSet, XmlTextReader reader)
//        {
//            Eqipment eqipment = new Eqipment(reader.GetAttribute("Name"), DateTime.Parse(reader.GetAttribute("Date")), reader.GetAttribute("EqipmentNameType"),  reader.GetAttribute("Description"))
//            {
             
//            };
//            dataSet.Eqipments.Add(eqipment);
//        }
//        private void ReadEqipmentAudience(ref EqipmentClassroomsDataSet dataSet, XmlTextReader reader)
//        {
//            EqipmentAudience eqipmentaudience = new EqipmentAudience
//            {
//                Name = reader.GetAttribute("Name"),
//                EqipmentNameType = reader.GetAttribute("EqipmentNameType"),
//                Note = reader.GetAttribute("Note"),
//                Number1 = ReadNumber1(reader),
//                InventoryNumber = ReadInventoryNumber(reader),
//            };
//            dataSet.EqipmentAudiences.Add(eqipmentaudience);
//        }
//        private int? ReadNumber1(XmlTextReader reader)
//        {
//            string nNumber = reader.GetAttribute("Number1");
//            int? number1 = string.IsNullOrWhiteSpace(nNumber) ?
//                (int?)null : int.Parse(nNumber);
//            return number1;
//        }
//        private double? ReadInventoryNumber(XmlTextReader reader)
//        {
//            string nInventoryNumber = reader.GetAttribute("InventoryNumber");
//            int? inventorynumber = string.IsNullOrWhiteSpace(nInventoryNumber) ?
//                (int?)null : int.Parse(nInventoryNumber);
//            return inventorynumber;
//        }
//        private void ReadEqipmentType(ref EqipmentClassroomsDataSet dataSet, XmlTextReader reader)
//        {
//            EqipmentType eqipmenttype = new EqipmentType(reader.GetAttribute("Name"), reader.GetAttribute("Definition"), reader.GetAttribute("EqipmentNameType"))
//            {
//                Note = reader.GetAttribute("Note")
//            };
//            dataSet.EqipmentTypes.Add(eqipmenttype);
//        }
//        public void Save(EqipmentClassroomsDataSet dataSet, string fileName)
//        {
//            XmlTextWriter writer = null;
//            try
//            {
//                writer = new XmlTextWriter(fileName, Encoding.Unicode);
//                WriteData(dataSet, writer);
//            }
//            catch (Exception)
//            {
//                throw;
//            }
//            finally
//            {
//                if (writer != null)
//                    writer.Close();
//            }
//        }
//        private void WriteData(EqipmentClassroomsDataSet dataSet, XmlTextWriter writer)
//        {
//            writer.WriteStartDocument();
//            writer.WriteStartElement("EqipmentClassroomsDataSet");
//            WriteAudiences(dataSet, writer);
//            WriteAudienceEqipmentTypess(dataSet, writer);
//            WriteAudienceTypes(dataSet, writer);
//            WriteEqipments(dataSet, writer);
//            WriteEqipmentAudiences(dataSet, writer);
//            WriteEqipmentTypes(dataSet, writer);
//            writer.WriteEndElement();
//            writer.WriteEndDocument();
//        }
//        private void WriteAudiences(EqipmentClassroomsDataSet dataSet, XmlTextWriter writer)
//        {
//            foreach (Audience obj in dataSet.Audiences)
//            {
//                writer.WriteStartElement("Audience");
//                writer.WriteAttributeString("Name", obj.Name);
//                writer.WriteAttributeString("NameTypeAudience", obj.NameTypeAudience);
//                writer.WriteAttributeString("Note", obj.Note);
//                writer.WriteAttributeString("Number", obj.Number.ToString());
//                writer.WriteEndElement();
//            }
//        }
//        private void WriteAudienceEqipmentTypess(EqipmentClassroomsDataSet dataSet, XmlTextWriter writer)
//        {
//            foreach (AudienceEqipmentTypes obj in dataSet.AudienceEqipmentTypess)
//            {
//                writer.WriteStartElement("AudienceEqipmentTypes");
//                writer.WriteAttributeString("Name", obj.Name);
//                writer.WriteAttributeString("NameTypeAudience", obj.NameTypeAudience);
//                writer.WriteAttributeString("NameTypeEqipment", obj.NameTypeEqipment);
//                writer.WriteAttributeString("Note", obj.Note);
//                writer.WriteEndElement();
//            }
//        }
//        private void WriteAudienceTypes(EqipmentClassroomsDataSet dataSet, XmlTextWriter writer)
//        {
//            foreach (AudienceType obj in dataSet.AudienceTypes)
//            {
//                writer.WriteStartElement("AudienceType");
//                writer.WriteAttributeString("Name", obj.Name);
//                writer.WriteAttributeString("NameTypeAudience", obj.NameTypeAudience);
//                writer.WriteAttributeString("Definition", obj.Definition);
//                writer.WriteAttributeString("Note", obj.Note);
//                writer.WriteEndElement();
//            }
//        }
//        private void WriteEqipments(EqipmentClassroomsDataSet dataSet, XmlTextWriter writer)
//        {
//            foreach (Eqipment obj in dataSet.Eqipments)
//            {
//                writer.WriteStartElement("Eqipment");
//                writer.WriteAttributeString("Name", obj.Name);
//                writer.WriteAttributeString("EqipmentNameType", obj.EqipmentNameType);
//                writer.WriteAttributeString("Description", obj.Description);
//                writer.WriteAttributeString("Date", obj.Date.Value.ToString("d"));
//                writer.WriteEndElement();
//            }
//        }
//        private void WriteEqipmentAudiences(EqipmentClassroomsDataSet dataSet, XmlTextWriter writer)
//        {
//            foreach (EqipmentAudience obj in dataSet.EqipmentAudiences)
//            {
//                writer.WriteStartElement("EqipmentAudience");
//                writer.WriteAttributeString("Name", obj.Name);
//                writer.WriteAttributeString("EqipmentNameType", obj.EqipmentNameType);
//                writer.WriteAttributeString("Note", obj.Note);
//                writer.WriteAttributeString("Number1", obj.Number1.ToString());
//                writer.WriteAttributeString("InventoryNumber", obj.InventoryNumber.ToString());
//                writer.WriteEndElement();

//            }
//        }
//        private void WriteEqipmentTypes(EqipmentClassroomsDataSet dataSet, XmlTextWriter writer)
//        {
//            foreach (EqipmentType obj in dataSet.EqipmentTypes)
//            {
//                writer.WriteStartElement("EqipmentType");
//                writer.WriteAttributeString("Name", obj.Name);
//                writer.WriteAttributeString("EqipmentNameType", obj.EqipmentNameType);
//                writer.WriteAttributeString("Note", obj.Note);
//                writer.WriteAttributeString("Definition", obj.Definition);
//                writer.WriteEndElement();

//            }
//        }

//    }
//}