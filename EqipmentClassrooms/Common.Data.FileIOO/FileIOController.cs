using Common.Data.FileIO.Interfaces;
using Common.Data.Interfaces;
using System;

namespace Common.Data.FileIO
{
    public abstract class FileIOController<D> : IFileIOController<D>
        where D : class, IEntitiesDataSet
    {

        private string _fileTypeCaption = "Невизначений тип";

        public string FileTypeCaption
        {
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

        private string _fileExtension = ".*";

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

        public abstract void Load(ref D dataSet, string fileName);
        public abstract void Save(D dataSet, string fileName);

        public void Load(ref IEntitiesDataSet dataSet, string fileName)
        {
            D ds = CastToD(dataSet);
            Load(ref ds, fileName);
        }

        private D CastToD(IEntitiesDataSet dataSet)
        {
            D ds = dataSet as D;
            if (ds == null)
            {
                throw new InvalidCastException(
                    "Набір даних типу " + dataSet.GetType().Name
                    + " не можна привести до типу "
                    + typeof(D).Name);
            }
            return ds;
        }

        public void Save(IEntitiesDataSet dataSet, string fileName)
        {
            D ds = CastToD(dataSet);
            Save(ds, fileName);
        }
    }
}
