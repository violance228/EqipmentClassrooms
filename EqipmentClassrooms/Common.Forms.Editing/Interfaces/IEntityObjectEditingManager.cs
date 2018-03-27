using Common.Data.Interfaces;
using Common.Interfaces;
using System.Drawing;

namespace Common.Forms.Editing.Interfaces
{
    public interface IEntityObjectEditingManager
    {
        IEntitiesDataSet DataSet { get; set; }
        Icon Icon { set; }
        bool AddObject(string entityCaption);
        bool EditObject(IEntity entityObject);
        bool DeleteObject(IEntity entityObject);
    }
}
