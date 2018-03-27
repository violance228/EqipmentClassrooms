using Common.Data.Interfaces;
using Common.Forms.Editing.Interfaces;
using Common.Interfaces;
using EqipmentClassrooms.Data;
using EqipmentClassrooms.Interfaces;
using EqipmentClassrooms.Domain;
using EqipmentClassrooms.Forms.Editing.ObjectEditing;
using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace EqipmentClassroomsAreaFormsUI.Managers
{
    class EqipmentClassroomsObjectEditingManager : IEntityObjectEditingManager
    {
        private IEqipmentClassroomsDataSet _dataSet;
        IEntitiesDataSet IEntityObjectEditingManager.DataSet
        {
            get { return _dataSet; }
            set
            {
                EqipmentClassroomsDataSet dataSet = value as EqipmentClassroomsDataSet;
                if (dataSet == null)
                {
                    throw new ArgumentException("EqipmentClassroomsDataSet");
                }
                _dataSet = dataSet;
            }
        }
        public Icon Icon { private get; set; }

        private FAudienceEditor _fAudienceEditor;

        protected FAudienceEditor FAudienceEditor
        {
            get
            {
                if (_fAudienceEditor == null)
                {
                    _fAudienceEditor = new FAudienceEditor()
                    {
                        Icon = this.Icon
                    };
                }
                return _fAudienceEditor;
            }
        }
        private FAudienceEqipmentTypesEditing _fAudienceEqipmentTypesEditor;

        protected FAudienceEqipmentTypesEditing FAudienceEqipmentTypesEditor
        {
            get
            {
                if (_fAudienceEqipmentTypesEditor == null)
                {
                    _fAudienceEqipmentTypesEditor = new FAudienceEqipmentTypesEditing()
                    {
                        Icon = this.Icon
                    };
                }
                return _fAudienceEqipmentTypesEditor;
            }
        }
        private FAudienceTypeEditor _fAudienceTypeEditor;

        protected FAudienceTypeEditor FAudienceTypeEditor
        {
            get
            {
                if (_fAudienceTypeEditor == null)
                {
                    _fAudienceTypeEditor = new FAudienceTypeEditor()
                    {
                        Icon = this.Icon
                    };
                }
                return _fAudienceTypeEditor;
            }
        }
        private FEqipmentEditor _fEqipmentEditor;

        protected FEqipmentEditor FEqipmentEditor
        {
            get
            {
                if (_fEqipmentEditor == null)
                {
                    _fEqipmentEditor = new FEqipmentEditor()
                    {
                        Icon = this.Icon
                    };
                }
                return _fEqipmentEditor;
            }
        }
        private FEqipmentAudienceEditor _fEqipmentAudienceEditor;

        protected FEqipmentAudienceEditor FEqipmentAudienceEditor
        {
            get
            {
                if (_fEqipmentAudienceEditor == null)
                {
                    _fEqipmentAudienceEditor = new FEqipmentAudienceEditor()
                    {
                        Icon = this.Icon
                    };
                }
                return _fEqipmentAudienceEditor;
            }
        }
        private FEqipmentTypeEditor _fEqipmentTypeEditor;

        protected FEqipmentTypeEditor FEqipmentTypeEditor
        {
            get
            {
                if (_fEqipmentTypeEditor == null)
                {
                    _fEqipmentTypeEditor = new FEqipmentTypeEditor()
                    {
                        Icon = this.Icon
                    };
                }
                return _fEqipmentTypeEditor;
            }
        }
        public bool AddObject(string entityTypeName)
        {
            CheckDataSet();
            switch (entityTypeName)
            {
                case "Audience":
                    FAudienceEditor.ReadOnly = false;
                    FAudienceEditor.AudienceEqipmentTypesNames = _dataSet.Audiencess.
                        Select(e => e.NameTypeAudience).OrderBy(e => e);
                    FAudienceEditor.AllowUserToAddNameTypeAudience = true;
                    FAudienceEditor.Current = null;
                    if (FAudienceEditor.ShowDialog() == DialogResult.OK)
                    {
                        _dataSet.Audiencess.Add(FAudienceEditor.Current);
                        return true;
                    }
                    break;
                case "AudienceEqipmentTypes":
                    FAudienceEqipmentTypesEditor.ReadOnly = false;
                    FAudienceEqipmentTypesEditor.NameTypeAudiences = _dataSet.AudienceEqipmentTypes.
                        Select(e => e.NameTypeAudience).OrderBy(e => e);
                    FAudienceEqipmentTypesEditor.AllowUserToAddNameTypeAudience = true;
                    FAudienceEqipmentTypesEditor.EqipmentNameTypes = _dataSet.AudienceEqipmentTypes.
                        Select(e => e.NameTypeEqipment).OrderBy(e => e);
                    FAudienceEqipmentTypesEditor.AllowUserToAddNameTypeEqipment = true;
                    FAudienceEqipmentTypesEditor.Current = null;
                    if (FAudienceEqipmentTypesEditor.ShowDialog() == DialogResult.OK)
                    {
                        _dataSet.AudienceEqipmentTypes.Add(FAudienceEqipmentTypesEditor.Current);
                        return true;
                    }
                    break;
                case "AudienceType":
                    FAudienceTypeEditor.ReadOnly = false;
                    FAudienceTypeEditor.AudienceEqipmentTypesNames = _dataSet.AudienceTypess.
                        Select(e => e.NameTypeAudience).OrderBy(e => e);
                    FAudienceTypeEditor.AllowUserToAddNameTypeAudience = true;
                    FAudienceTypeEditor.Current = null; 
                    if (FAudienceTypeEditor.ShowDialog() == DialogResult.OK)
                    {
                        _dataSet.AudienceTypess.Add(FAudienceTypeEditor.Current);
                        return true;
                    }
                    break;
                case "Eqipment":
                    FEqipmentEditor.ReadOnly = false;
                    FEqipmentEditor.EqipmentNameTypes = _dataSet.Eqipmentss.
                        Select(e => e.EqipmentNameType).OrderBy(e => e);
                    FEqipmentEditor.AllowUserToAddEqipmentNameType = true;
                    FEqipmentEditor.Current = null;
                    if (FEqipmentEditor.ShowDialog() == DialogResult.OK)
                    {
                        _dataSet.Eqipmentss.Add(FEqipmentEditor.Current);
                        return true;
                    }
                    break;
                case "EqipmentAudience":
                    FEqipmentAudienceEditor.ReadOnly = false;
                    FEqipmentAudienceEditor.EqipmentNameTypes = _dataSet.EqipmentAudiencess.
                        Select(e => e.EqipmentNameType).OrderBy(e => e);
                    FEqipmentAudienceEditor.AllowUserToAddEqipmentNameType = true;
                    FEqipmentAudienceEditor.Current = null;
                    if (FEqipmentAudienceEditor.ShowDialog() == DialogResult.OK)
                    {
                        _dataSet.EqipmentAudiencess.Add(FEqipmentAudienceEditor.Current);
                        return true;
                    }
                    break;
                    case "EqipmentType":
                    FEqipmentTypeEditor.ReadOnly = false;
                    FEqipmentTypeEditor.EqipmentNameTypes = _dataSet.EqipmentTypess.
                        Select(e => e.EqipmentNameType).OrderBy(e => e);
                    FEqipmentTypeEditor.AllowUserToAddEqipmentNameType = true;
                    FEqipmentTypeEditor.Current = null;
                    if (FEqipmentTypeEditor.ShowDialog() == DialogResult.OK)
                    {
                        _dataSet.EqipmentTypess.Add(FEqipmentTypeEditor.Current);
                        return true;
                    }
                    break;
                default:
                    break;
            }
            return false;
        }
        private void CheckDataSet()
        {
            if (_dataSet == null)
            {
                throw new InvalidOperationException(
                    "Для виконання операцій редагування потрібен "
                    + "набір даних типу CountriesAreaDataSet");
            }
        }
        public bool EditObject(IEntity entityObject)
        {
            CheckDataSet();
            switch (entityObject.GetType().Name)
            {
                case "Audience":
                    FAudienceEditor.ReadOnly = false;
                    FAudienceEditor.AudienceEqipmentTypesNames = _dataSet.Audiencess.
                        Select(e => e.NameTypeAudience).OrderBy(e => e);
                    FAudienceEditor.AllowUserToAddNameTypeAudience = true;
                    FAudienceEditor.Current = null;
                    if (FAudienceEditor.ShowDialog() == DialogResult.OK)
                    {
                        _dataSet.Audiencess.Add(FAudienceEditor.Current);
                        return true;
                    }
                    break;
                case "AudienceEqipmentTypes":
                    FAudienceEqipmentTypesEditor.ReadOnly = false;
                    FAudienceEqipmentTypesEditor.NameTypeAudiences = _dataSet.AudienceEqipmentTypes.
                        Select(e => e.NameTypeAudience).OrderBy(e => e);
                    FAudienceEqipmentTypesEditor.AllowUserToAddNameTypeAudience = true;
                    FAudienceEqipmentTypesEditor.EqipmentNameTypes = _dataSet.AudienceEqipmentTypes.
                        Select(e => e.NameTypeEqipment).OrderBy(e => e);
                    FAudienceEqipmentTypesEditor.AllowUserToAddNameTypeEqipment = true;
                    FAudienceEqipmentTypesEditor.Current = null;
                    if (FAudienceEqipmentTypesEditor.ShowDialog() == DialogResult.OK)
                    {
                        _dataSet.AudienceEqipmentTypes.Add(FAudienceEqipmentTypesEditor.Current);
                        return true;
                    }
                    break;
                case "AudienceType":
                    FAudienceTypeEditor.ReadOnly = false;
                    FAudienceTypeEditor.AudienceEqipmentTypesNames = _dataSet.AudienceTypess.
                        Select(e => e.NameTypeAudience).OrderBy(e => e);
                    FAudienceTypeEditor.AllowUserToAddNameTypeAudience = true;
                    FAudienceTypeEditor.Current = null;
                    if (FAudienceTypeEditor.ShowDialog() == DialogResult.OK)
                    {
                        _dataSet.AudienceTypess.Add(FAudienceTypeEditor.Current);
                        return true;
                    }
                    break;
                case "Eqipment":
                    FEqipmentEditor.ReadOnly = false;
                    FEqipmentEditor.EqipmentNameTypes = _dataSet.Eqipmentss.
                        Select(e => e.EqipmentNameType).OrderBy(e => e);
                    FEqipmentEditor.AllowUserToAddEqipmentNameType = true;
                    FEqipmentEditor.Current = null;
                    if (FEqipmentEditor.ShowDialog() == DialogResult.OK)
                    {
                        _dataSet.Eqipmentss.Add(FEqipmentEditor.Current);
                        return true;
                    }
                    break;
                case "EqipmentAudience":
                    FEqipmentAudienceEditor.ReadOnly = false;
                    FEqipmentAudienceEditor.EqipmentNameTypes = _dataSet.EqipmentAudiencess.
                        Select(e => e.EqipmentNameType).OrderBy(e => e);
                    FEqipmentAudienceEditor.AllowUserToAddEqipmentNameType = true;
                    FEqipmentAudienceEditor.Current = null;
                    if (FEqipmentAudienceEditor.ShowDialog() == DialogResult.OK)
                    {
                        _dataSet.EqipmentAudiencess.Add(FEqipmentAudienceEditor.Current);
                        return true;
                    }
                    break;
                case "EqipmentType":
                    FEqipmentTypeEditor.ReadOnly = false;
                    FEqipmentTypeEditor.EqipmentNameTypes = _dataSet.EqipmentTypess.
                        Select(e => e.EqipmentNameType).OrderBy(e => e);
                    FEqipmentTypeEditor.AllowUserToAddEqipmentNameType = true;
                    FEqipmentTypeEditor.Current = null;
                    if (FEqipmentTypeEditor.ShowDialog() == DialogResult.OK)
                    {
                        _dataSet.EqipmentTypess.Add(FEqipmentTypeEditor.Current);
                        return true;
                    }
                    break;
                default:
                    break;
            }
            return false;
        }
        public bool DeleteObject(IEntity entityObject)
        {
            CheckDataSet();
            switch (entityObject.GetType().Name)
            {
                case "Audience":
                    Audience audience = (Audience)entityObject;
                    if (MessageBox.Show("Ви дійсно бажаєте видалити об'єкт " + audience.Key + "?",
                        "Підтвердження команди видалення", MessageBoxButtons.YesNo,
                        MessageBoxIcon.Exclamation) == DialogResult.Yes)
                    {
                        _dataSet.Audiencess.Remove(audience);
                        return true;
                    }
                    break;
                case "AudienceEqipmentTypes":
                    AudienceEqipmentTypes audienceeqipmenttypes = (AudienceEqipmentTypes)entityObject;
                    if (MessageBox.Show("Ви дійсно бажаєте видалити об'єкт " + audienceeqipmenttypes.Key + "?",
                        "Підтвердження команди видалення", MessageBoxButtons.YesNo,
                        MessageBoxIcon.Exclamation) == DialogResult.Yes)
                    {
                        _dataSet.AudienceEqipmentTypes.Remove(audienceeqipmenttypes);
                        return true;
                    }
                    break;
                case "AudienceType":
                    AudienceType audiencetype = (AudienceType)entityObject;
                    if (MessageBox.Show("Ви дійсно бажаєте видалити об'єкт " + audiencetype.Key + "?",
                        "Підтвердження команди видалення", MessageBoxButtons.YesNo,
                        MessageBoxIcon.Exclamation) == DialogResult.Yes)
                    {
                        _dataSet.AudienceTypess.Remove(audiencetype);
                        return true;
                    }
                    break;
                case "Eqipment":
                    Eqipment eqipment = (Eqipment)entityObject;
                    if (MessageBox.Show("Ви дійсно бажаєте видалити об'єкт " + eqipment.Key + "?",
                        "Підтвердження команди видалення", MessageBoxButtons.YesNo,
                        MessageBoxIcon.Exclamation) == DialogResult.Yes)
                    {
                        _dataSet.Eqipmentss.Remove(eqipment);
                        return true;
                    }
                    break;
                case "EqipmentAudience":
                    EqipmentAudience eqipmentaudience = (EqipmentAudience)entityObject;
                    if (MessageBox.Show("Ви дійсно бажаєте видалити об'єкт " + eqipmentaudience.Key + "?",
                        "Підтвердження команди видалення", MessageBoxButtons.YesNo,
                        MessageBoxIcon.Exclamation) == DialogResult.Yes)
                    {
                        _dataSet.EqipmentAudiencess.Remove(eqipmentaudience);
                        return true;
                    }
                    break;
                case "EqipmentType":
                    EqipmentType eqipmenttype = (EqipmentType)entityObject;
                    if (MessageBox.Show("Ви дійсно бажаєте видалити об'єкт " + eqipmenttype.Key + "?",
                        "Підтвердження команди видалення", MessageBoxButtons.YesNo,
                        MessageBoxIcon.Exclamation) == DialogResult.Yes)
                    {
                        _dataSet.EqipmentTypess.Remove(eqipmenttype);
                        return true;
                    }
                    break;
                default:
                    break;
            }
            return false;
        }
    }
}

