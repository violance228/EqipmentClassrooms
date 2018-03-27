
using Common.Data.Interfaces;

namespace Common.Data.FileIO.Interfaces
{
    public interface IFileOperationsController
    {
        IEntitiesDataSet DataSet { get; }
        string FileName { get; set; }
        string DefaultFileName { get; set; }
        void New();
        void Open();
        void Save();
        void SaveAs();
        void SaveAsText();
        void Close();
    }
}
