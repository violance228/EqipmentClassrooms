using Common.Data.FileIO.Interfaces;
using EqipmentClassrooms.Domain;
using System;
using System.Text;
using System.Xml;
using Common.Data.Interfaces;
using EqipmentClassrooms.Interfaces;

namespace EqipmentClassrooms.FileIO
{
    public class EqipmentClassroomsXmlFileIoController 
        : IFileIoController<IEqipmentClassroomsDataSet>
    {
        private string _fileTypeCaption = "Файл формату XML";

        public string FileTypeCaption
        {
            //get{throw new NotImplementedException}
            get { return _fileTypeCaption; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("FileTypeCaption");
                }
                _fileTypeCaption = value;
            }
        }
        private string _fileExtension = ".xml";

        public virtual string FileExtension
        {
            get { return _fileExtension; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("FileExtension");
                }
                _fileExtension = value;
            }
        }
        public void Load(ref IEqipmentClassroomsDataSet dataSet, string fileName)
        {
            XmlTextReader reader = null;
            try
            {
                reader = new XmlTextReader(fileName)
                {
                    WhitespaceHandling = WhitespaceHandling.None
                };
                while (reader.Read())
                {
                    if (reader.NodeType == XmlNodeType.Element)
                    {
                        if (reader.Name == "Audience")
                        {
                            ReadAudience(ref dataSet, reader);
                        }
                        else if (reader.Name == "AudienceEqipmentType")
                        {
                            ReadAudienceEqipmentTypes(ref dataSet, reader);
                        }
                        else if (reader.Name == "AudienceType")
                        {
                            ReadAudienceType(ref dataSet, reader);
                        }
                        else if (reader.Name == "Eqipment")
                        {
                            ReadEqipment(ref dataSet, reader);
                        }
                        else if (reader.Name == "EqipmentAudience")
                        {
                            ReadEqipmentAudience(ref dataSet, reader);
                        }
                        else if (reader.Name == "Eqipment")
                        {
                            ReadEqipmentType(ref dataSet, reader);
                        }
                    }
                }
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                if (reader != null)
                    reader.Close();
            }
        }



        //private void ReadAudienceType(ref IEqipmentClassroomsDataSet dataSet, XmlTextReader reader)
        //{
        //    throw new NotImplementedException();
        //}

        //private void ReadEqipmentType(ref IEqipmentClassroomsDataSet dataSet, XmlTextWriter reader)
        //{
        //    throw new NotImplementedException();
        //}

        //private void ReadEqipmentAudience(ref IEqipmentClassroomsDataSet dataSet, XmlTextWriter reader)
        //{
        //    throw new NotImplementedException();
        //}

        //private void ReadEqipment(ref IEqipmentClassroomsDataSet dataSet, XmlTextWriter reader)
        //{
        //    throw new NotImplementedException();
        //}

        //private void ReadAudienceType(ref IEqipmentClassroomsDataSet dataSet, XmlTextWriter reader)
        //{
        //    throw new NotImplementedException();
        //}

        //private void ReadAudienceEqipmentTypes(ref IEqipmentClassroomsDataSet dataSet, XmlTextWriter reader)
        //{
        //    throw new NotImplementedException();
        //}

        //private void ReadAudience(ref IEqipmentClassroomsDataSet dataSet, XmlTextWriter reader)
        //{
        //    throw new NotImplementedException();
        //}

        private static int? ReadId(XmlTextReader reader)
        {
            string sId = reader.GetAttribute("Id");
            int? id = string.IsNullOrWhiteSpace(sId) ?
                (int?)null : int.Parse(sId);
            return id;
        }
        //private void ReadData(ref EqipmentClassroomsDataSet dataSet, XmlTextReader reader)
        //{
        //    while (reader.Read())
        //    {
        //        if (reader.NodeType == XmlNodeType.Element)
        //        {
        //            if (reader.Name == "Audience")
        //            {
        //                ReadAudience(ref dataSet, reader);
        //            }
        //            else if (reader.Name == "AudienceEqipmentType")
        //            {
        //                ReadAudienceEqipmentTypes(ref dataSet, reader);
        //            }
        //            else if (reader.Name == "AudienceType")
        //            {
        //                ReadAudienceType(ref dataSet, reader);
        //            }
        //            else if (reader.Name == "Eqipment")
        //            {
        //                ReadEqipment(ref dataSet, reader);
        //            }
        //            else if (reader.Name == "EqipmentAudience")
        //            {
        //                ReadEqipmentAudience(ref dataSet, reader);
        //            }
        //            else if (reader.Name == "EqipmentType")
        //            {
        //                ReadEqipmentType(ref dataSet, reader);
        //            }
        //        }
        //    }
        //}
        private void ReadAudience(ref IEqipmentClassroomsDataSet dataSet, XmlTextReader reader)
        {
            Audience audience = new Audience
            {
                Name = reader.GetAttribute("Name"),
                NameTypeAudience = reader.GetAttribute("NameTypeAudience"),
                Number = ReadNumber(reader),
                Note = reader.GetAttribute("Note")
            };
            dataSet.Audiencess.Add(audience);
        }
        private uint? ReadNumber(XmlTextReader reader)
        {
            string mNumber = reader.GetAttribute("Number");
           uint? number = string.IsNullOrWhiteSpace(mNumber) ?
                (uint?)null : uint.Parse(mNumber);
            return number;
        }

        private void ReadAudienceEqipmentTypes(ref IEqipmentClassroomsDataSet dataSet, XmlTextReader reader)
        {
            AudienceEqipmentTypes audienceeqipmenttypes = new AudienceEqipmentTypes
            {
                Name = reader.GetAttribute("Name"),
                NameTypeAudience = reader.GetAttribute("NameTypeAudience"),
                NameTypeEqipment = reader.GetAttribute("NameTypeEqipment"),
                Note = reader.GetAttribute("Note")
            };
            dataSet.AudienceEqipmentTypes.Add(audienceeqipmenttypes);
        }

        private void ReadAudienceType(ref IEqipmentClassroomsDataSet dataSet, XmlTextReader reader)
        {
            AudienceType audiencetype = new AudienceType(reader.GetAttribute("Name"))
            {
                NameTypeAudience = reader.GetAttribute("NameTypeAudience"),
                Definition = reader.GetAttribute("Definition"),
                Note = reader.GetAttribute("Note")
            };
            dataSet.AudienceTypess.Add(audiencetype);
        }
        private void ReadEqipment(ref IEqipmentClassroomsDataSet dataSet, XmlTextReader reader)
        {
            Eqipment eqipment = new Eqipment(reader.GetAttribute("Name"), DateTime.Parse(reader.GetAttribute("Date")), reader.GetAttribute("EqipmentNameType"),  reader.GetAttribute("Description"))
            {
             
            };
            dataSet.Eqipmentss.Add(eqipment);
        }
        private void ReadEqipmentAudience(ref IEqipmentClassroomsDataSet dataSet, XmlTextReader reader)
        {
            EqipmentAudience eqipmentaudience = new EqipmentAudience
            {
                Name = reader.GetAttribute("Name"),
                EqipmentNameType = reader.GetAttribute("EqipmentNameType"),
                Note = reader.GetAttribute("Note"),
                Number1 = ReadNumber1(reader),
                InventoryNumber = ReadInventoryNumber(reader),
            };
            dataSet.EqipmentAudiencess.Add(eqipmentaudience);
        }
        private uint? ReadNumber1(XmlTextReader reader)
        {
            string nNumber = reader.GetAttribute("Number1");
            uint? number1 = string.IsNullOrWhiteSpace(nNumber) ?
                (uint?)null : uint.Parse(nNumber);
            return number1;
        }
        private double? ReadInventoryNumber(XmlTextReader reader)
        {
            string nInventoryNumber = reader.GetAttribute("InventoryNumber");
            int? inventorynumber = string.IsNullOrWhiteSpace(nInventoryNumber) ?
                (int?)null : int.Parse(nInventoryNumber);
            return inventorynumber;
        }
        private void ReadEqipmentType(ref IEqipmentClassroomsDataSet dataSet, XmlTextReader reader)
        {
            EqipmentType eqipmenttype = new EqipmentType(reader.GetAttribute("Name"), reader.GetAttribute("Definition"), reader.GetAttribute("EqipmentNameType"))
            {
                Note = reader.GetAttribute("Note")
            };
            dataSet.EqipmentTypess.Add(eqipmenttype);
        }
        public void Save(IEqipmentClassroomsDataSet dataSet, string fileName)
        {
            XmlTextWriter writer = null;
            try
            {
                writer = new XmlTextWriter(fileName, Encoding.Unicode);
                writer.WriteStartDocument();
                writer.WriteStartElement("EqupmentClassroomsDataSet");
                WriteAudiencess(dataSet, writer);
                WriteAudienceEqipmentTypes(dataSet, writer);
                WriteAudienceTypess(dataSet, writer);
                WriteEqipmentss(dataSet, writer);
                WriteEqipmentAudiencess(dataSet, writer);
                WriteEqipmentTypess(dataSet, writer);
                writer.WriteEndElement();
                writer.WriteEndDocument();
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                if (writer != null)
                    writer.Close();
            }
        }
        //private void WriteData(EqipmentClassroomsDataSet dataSet, XmlTextWriter writer)
        //{
        //    writer.WriteStartDocument();
        //    writer.WriteStartElement("EqipmentClassroomsDataSet");
        //    WriteAudiencess(dataSet, writer);
        //    WriteAudienceEqipmentTypes(dataSet, writer);
        //    WriteAudienceTypess(dataSet, writer);
        //    WriteEqipmentss(dataSet, writer);
        //    WriteEqipmentAudiencess(dataSet, writer);
        //    WriteEqipmentTypess(dataSet, writer);
        //    writer.WriteEndElement();
        //    writer.WriteEndDocument();
        //}
        private void WriteAudiencess(IEqipmentClassroomsDataSet dataSet, XmlTextWriter writer)
        {
            foreach (Audience obj in dataSet.Audiencess)
            {
                writer.WriteStartElement("Audience");
                writer.WriteAttributeString("Name", obj.Name);
                writer.WriteAttributeString("NameTypeAudience", obj.NameTypeAudience);
                writer.WriteAttributeString("Note", obj.Note);
                writer.WriteAttributeString("Number", obj.Number.ToString());
                writer.WriteEndElement();
            }
        }
        private void WriteAudienceEqipmentTypes(IEqipmentClassroomsDataSet dataSet, XmlTextWriter writer)
        {
            foreach (AudienceEqipmentTypes obj in dataSet.AudienceEqipmentTypes)
            {
                writer.WriteStartElement("AudienceEqipmentTypes");
                writer.WriteAttributeString("Name", obj.Name);
                writer.WriteAttributeString("NameTypeAudience", obj.NameTypeAudience);
                writer.WriteAttributeString("NameTypeEqipment", obj.NameTypeEqipment);
                writer.WriteAttributeString("Note", obj.Note);
                writer.WriteEndElement();
            }
        }
        private void WriteAudienceTypess(IEqipmentClassroomsDataSet dataSet, XmlTextWriter writer)
        {
            foreach (AudienceType obj in dataSet.AudienceTypess)
            {
                writer.WriteStartElement("AudienceType");
                writer.WriteAttributeString("Name", obj.Name);
                writer.WriteAttributeString("NameTypeAudience", obj.NameTypeAudience);
                writer.WriteAttributeString("Definition", obj.Definition);
                writer.WriteAttributeString("Note", obj.Note);
                writer.WriteEndElement();
            }
        }
        private void WriteEqipmentss(IEqipmentClassroomsDataSet dataSet, XmlTextWriter writer)
        {
            foreach (Eqipment obj in dataSet.Eqipmentss)
            {
                writer.WriteStartElement("Eqipment");
                writer.WriteAttributeString("Name", obj.Name);
                writer.WriteAttributeString("EqipmentNameType", obj.EqipmentNameType);
                writer.WriteAttributeString("Description", obj.Description);
                writer.WriteAttributeString("Date", obj.Date.Value.ToString("d"));
                writer.WriteEndElement();
            }
        }
        private void WriteEqipmentAudiencess(IEqipmentClassroomsDataSet dataSet, XmlTextWriter writer)
        {
            foreach (EqipmentAudience obj in dataSet.EqipmentAudiencess)
            {
                writer.WriteStartElement("EqipmentAudience");
                writer.WriteAttributeString("Name", obj.Name);
                writer.WriteAttributeString("EqipmentNameType", obj.EqipmentNameType);
                writer.WriteAttributeString("Note", obj.Note);
                writer.WriteAttributeString("Number1", obj.Number1.ToString());
                writer.WriteAttributeString("InventoryNumber", obj.InventoryNumber.ToString());
                writer.WriteEndElement();

            }
        }
        private void WriteEqipmentTypess(IEqipmentClassroomsDataSet dataSet, XmlTextWriter writer)
        {
            foreach (EqipmentType obj in dataSet.EqipmentTypess)
            {
                writer.WriteStartElement("EqipmentType");
                writer.WriteAttributeString("Name", obj.Name);
                writer.WriteAttributeString("EqipmentNameType", obj.EqipmentNameType);
                writer.WriteAttributeString("Note", obj.Note);
                writer.WriteAttributeString("Definition", obj.Definition);
                writer.WriteEndElement();

            }
        }
        public void Load(ref IEntitiesDataSet dataSet, string fileName)
        {
            IEqipmentClassroomsDataSet ds = Cast(dataSet);
            Load(ref ds, fileName);
        }
        private IEqipmentClassroomsDataSet Cast(IEntitiesDataSet dataSet)
        {
            IEqipmentClassroomsDataSet ds = dataSet as IEqipmentClassroomsDataSet;
            if (ds == null)
            {
                throw new InvalidCastException(
                    "Набір даних типу " + dataSet.GetType().Name
                    + " не можна привести до типу IEqipmentClassroomsDataSet");
            }
            return ds;
        }

        public void Save(IEntitiesDataSet dataSet, string fileName)
        {
            IEqipmentClassroomsDataSet ds = Cast(dataSet);
            Save(ds, fileName);
        }


    }
}