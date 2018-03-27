//using Common.Data.Interfaces;

//namespace EqipmentClassrooms.FileIO.Interfaces
//{

//    public interface IFileIOController
//    {
//        string FileTypeCaption { get; }
//        string FileExtension { get; }

//        void Load(ref IEntitiesDataSet dataSet, string fileName);
//        void Save(IEntitiesDataSet dataSet, string fileName);
//    }

//    public interface IFileIOController<D> : IFileIOController
//        where D : class, IEntitiesDataSet
//    {

//        void Load(ref D dataSet, string fileName);
//        void Save(D dataSet, string fileName);
//    }
//}
