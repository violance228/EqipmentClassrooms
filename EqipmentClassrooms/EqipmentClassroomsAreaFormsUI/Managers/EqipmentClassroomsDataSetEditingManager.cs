using Common.Forms.Editing;
using Common.Data.Interfaces;
using EqipmentClassrooms.Domain;
using System;
using System.Drawing;
using Common.Forms.Editing.Interfaces;
using EqipmentClassrooms.Interfaces;

namespace EqipmentClassroomsAreaFormsUI.Managers
{
    class EqipmentClassroomsDataSetEditingManager : IDataSetEditingManager
    {
        IEqipmentClassroomsDataSet DataSet { get; set; }

        FBindingListEditor<Audience> _fAudiencesEditor;
        FBindingListEditor<AudienceEqipmentTypes> _fAudienceEqipmentTypesEditor;
        FBindingListEditor<AudienceType> _fAudienceTypesEditor;
        FBindingListEditor<Eqipment> _fEqipmentsEditor;
        FBindingListEditor<EqipmentAudience> _fEqipmentAudiecesEditor;
        FBindingListEditor<EqipmentType> _fEqipmentTypesEditor;

        public Icon Icon { private get; set; }

        IEntitiesDataSet IDataSetEditingManager.DataSet
        {
            get { return DataSet; }
            set
            {
                if (!(value is IEqipmentClassroomsDataSet))
                {
                    throw new ArgumentException("IEqipmentClassroomsDataSet");
                }
                DataSet = (IEqipmentClassroomsDataSet)value;
            }
        }

        public void ShowEntityDataEditor(string entityCaption)
        {
            string typeName =
                DataSet.TypeNameByEntityCaption(entityCaption);
            switch (typeName)
            {
                case "Audience":
                    _fAudiencesEditor =
                        new FBindingListEditor<Audience>(
                            DataSet.Audiencess)
                        {
                            Text = entityCaption,
                            Icon = this.Icon
                        };
                    _fAudiencesEditor.ShowDialog();
                    break;
                case "AudienceEqipmentTypes":
                    _fAudienceEqipmentTypesEditor =
                        new FBindingListEditor<AudienceEqipmentTypes>(
                            DataSet.AudienceEqipmentTypes)
                        {
                            Text = entityCaption,
                            Icon = this.Icon
                        };
                    _fAudienceEqipmentTypesEditor.ShowDialog();
                    break;
                case "AudienceType":
                    _fAudienceTypesEditor =
                        new FBindingListEditor<AudienceType>(
                            DataSet.AudienceTypess)
                        {
                            Text = entityCaption,
                            Icon = this.Icon
                        };
                    _fAudienceTypesEditor.ShowDialog();
                    break;
                case "Eqipment":
                    _fEqipmentsEditor =
                        new FBindingListEditor<Eqipment>(
                            DataSet.Eqipmentss)
                        {
                            Text = entityCaption,
                            Icon = this.Icon
                        };
                    _fEqipmentsEditor.ShowDialog();
                    break;
                case "EqipmentAudience":
                    _fEqipmentAudiecesEditor =
                        new FBindingListEditor<EqipmentAudience>(
                            DataSet.EqipmentAudiencess)
                        {
                            Text = entityCaption,
                            Icon = this.Icon
                        };
                    _fEqipmentAudiecesEditor.ShowDialog();
                    break;
                case "EqipmentType":
                    _fEqipmentTypesEditor =
                        new FBindingListEditor<EqipmentType>(
                            DataSet.EqipmentTypess)
                        {
                            Text = entityCaption,
                            Icon = this.Icon
                        };
                    _fEqipmentTypesEditor.ShowDialog();
                    break;
            }
        }
    }
}
