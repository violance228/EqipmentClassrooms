using Common.Data.Interfaces;

namespace Common.Data.FileIO.Interfaces
{

    public interface IFileIoController
    {
        string FileTypeCaption { get; }
        string FileExtension { get; }

        void Load(ref IEntitiesDataSet dataSet, string fileName);
        void Save(IEntitiesDataSet dataSet, string fileName);
    }

    public interface IFileIoController<D> : IFileIoController
        where D : class, IEntitiesDataSet
    {

        void Load(ref D dataSet, string fileName);
        void Save(D dataSet, string fileName);
    }
}
