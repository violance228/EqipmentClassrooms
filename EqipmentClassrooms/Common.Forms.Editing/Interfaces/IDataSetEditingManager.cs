
using Common.Data.Interfaces;
using System.Drawing;

namespace Common.Forms.Editing.Interfaces
{
    public interface IDataSetEditingManager
    {
        IEntitiesDataSet DataSet { get; set; }
        Icon Icon { set; }
        void ShowEntityDataEditor(string entityCaption);
    }
}
