// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 03-May-2012, 11:02:33




using System;
using System.Web.UI.WebControls;
using System.Collections.Generic;
using System.Linq;

using Bay.ERP.Web.UI.Helper;
using Bay.ERP.Common.BusinessEntities;
using Bay.ERP.BusinessFacade;
using Bay.ERP.FacadeCreator.FacadeContext;
using Bay.ERP.Common.Helper;
using Bay.ERP.Common.Shared;

namespace Bay.ERP.Web.UI
{
    public partial class PRMSupplierItemCategoryMapControl : SupplierBaseControl
    {
        #region Extra

        class CustomerComparer : IEqualityComparer<PRMSupplierItemCategoryMapEntity>
        {
            public bool Equals(PRMSupplierItemCategoryMapEntity x, PRMSupplierItemCategoryMapEntity y)
            {
                return (x.SupplierItemCategoryID.Equals(y.SupplierItemCategoryID) && x.SupplierID.Equals(y.SupplierID));
            }

            public int GetHashCode(PRMSupplierItemCategoryMapEntity obj)
            {
                return obj.SupplierItemCategoryID.GetHashCode();
            }
        }

        #endregion

        #region Properties

        public Int64 _SupplierItemCategoryMapID
        {
            get
            {
                Int64 id = 0;

                if (ViewState["ID"] != null)
                {
                    Int64.TryParse(ViewState["ID"].ToString(), out id);
                }

                return id;
            }
            set
            {
                ViewState["ID"] = value;
            }
        }

        public PRMSupplierItemCategoryMapEntity _PRMSupplierItemCategoryMapEntity
        {
            get
            {
                PRMSupplierItemCategoryMapEntity entity = new PRMSupplierItemCategoryMapEntity();

                if (ViewState["CurrentEntity"] != null)
                {
                    entity = (PRMSupplierItemCategoryMapEntity)ViewState["CurrentEntity"];
                }

                return entity;
            }
            set
            {
                ViewState["CurrentEntity"] = value;
            }
        }

        private PRMSupplierItemCategoryMapEntity CurrentPRMSupplierItemCategoryMapEntity
        {
            get
            {
                if (_SupplierItemCategoryMapID > 0)
                {
                    if (_PRMSupplierItemCategoryMapEntity.SupplierItemCategoryMapID != _SupplierItemCategoryMapID)
                    {
                        _PRMSupplierItemCategoryMapEntity = FCCPRMSupplierItemCategoryMap.GetFacadeCreate().GetByID(_SupplierItemCategoryMapID);
                    }
                }

                return _PRMSupplierItemCategoryMapEntity;
            }
            set
            {
                _PRMSupplierItemCategoryMapEntity = value;
            }
        }

        public IList<PRMSupplierItemCategoryMapEntity> _CurrentSupplierItemCategoryList
        {
            get
            {
                IList<PRMSupplierItemCategoryMapEntity> supplierItemCategoryList = null;

                if (ViewState["CurrentSupplierItemCategoryList"] != null)
                {
                    supplierItemCategoryList = (List<PRMSupplierItemCategoryMapEntity>)ViewState["CurrentSupplierItemCategoryList"];
                }
                else
                {
                    supplierItemCategoryList = new List<PRMSupplierItemCategoryMapEntity>();
                }

                return supplierItemCategoryList;
            }
            set
            {
                ViewState["CurrentSupplierItemCategoryList"] = value;
            }
        }

        #endregion

        #region Methods

        private void PrepareValidator()
        {
        }

        private void PrepareInitialView()
        {
            BindList();
        }

        private void PrepareEditView()
        {
            PRMSupplierItemCategoryMapEntity pRMSupplierItemCategoryMapEntity = CurrentPRMSupplierItemCategoryMapEntity;
        }

        private void BindList()
        {
            BindPRMSupplierItemCategoryMapList();
        }

        private void BindPRMSupplierItemCategoryMapList()
        {
            IList<MDSupplierItemCategoryEntity> supplierItemCategoryList = FCCMDSupplierItemCategory.GetFacadeCreate().GetIL(null, null, String.Empty, String.Empty, DatabaseOperationType.Load);
            chbxItemCategory.DataSource = supplierItemCategoryList;
            chbxItemCategory.DataTextField = "Name";
            chbxItemCategory.DataValueField = "SupplierItemCategoryID";
            chbxItemCategory.DataBind();

            if (chbxItemCategory != null && chbxItemCategory.Items.Count > 0)
            {
                String fe = SqlExpressionBuilder.PrepareFilterExpression(PRMSupplierItemCategoryMapEntity.FLD_NAME_SupplierID, this.OverviewSupplierID.ToString(), SQLMatchType.Equal);
                IList<PRMSupplierItemCategoryMapEntity> supplierItemCategoryMapList = FCCPRMSupplierItemCategoryMap.GetFacadeCreate().GetIL(null, null, String.Empty, fe, DatabaseOperationType.LoadWithFilterExpression);

                if (supplierItemCategoryMapList != null && supplierItemCategoryMapList.Count > 0)
                {
                    _CurrentSupplierItemCategoryList = supplierItemCategoryMapList;

                    foreach (PRMSupplierItemCategoryMapEntity ent in supplierItemCategoryMapList)
                    {
                        foreach (ListItem chbxItem in chbxItemCategory.Items)
                        {

                            if (ent.SupplierItemCategoryID.ToString() == chbxItem.Value.ToString())
                            {
                                chbxItem.Selected = true;
                                break;
                            }
                        }
                    }
                }
            }
        }

        private PRMSupplierItemCategoryMapEntity BuildPRMSupplierItemCategoryMapEntity()
        {
            PRMSupplierItemCategoryMapEntity pRMSupplierItemCategoryMapEntity = CurrentPRMSupplierItemCategoryMapEntity;

            return pRMSupplierItemCategoryMapEntity;
        }

        private void SavePRMSupplierItemCategoryMapEntity()
        {
            if (IsValid)
            {
                try
                {
                    IList<PRMSupplierItemCategoryMapEntity> newMappedItems = new List<PRMSupplierItemCategoryMapEntity>();

                    foreach (ListItem chbxItem in chbxItemCategory.Items)
                    {
                        if (chbxItem.Selected)
                        {
                            PRMSupplierItemCategoryMapEntity pRMItemCategoryMapEntity = new PRMSupplierItemCategoryMapEntity();
                            pRMItemCategoryMapEntity.SupplierItemCategoryID = Int64.Parse(chbxItem.Value.ToString());
                            pRMItemCategoryMapEntity.SupplierID = this.OverviewSupplierID;
                            newMappedItems.Add(pRMItemCategoryMapEntity);
                        }
                    }

                    IList<PRMSupplierItemCategoryMapEntity> deleteList = _CurrentSupplierItemCategoryList.Except(newMappedItems, new CustomerComparer()).ToList();
                    IList<PRMSupplierItemCategoryMapEntity> addNewList = newMappedItems.Except(_CurrentSupplierItemCategoryList, new CustomerComparer()).ToList();

                    if (deleteList != null && deleteList.Count > 0)
                    {
                        foreach (PRMSupplierItemCategoryMapEntity ent in deleteList)
                        {
                            String fe1 = SqlExpressionBuilder.PrepareFilterExpression(PRMSupplierItemCategoryMapEntity.FLD_NAME_SupplierID, ent.SupplierID.ToString(), SQLMatchType.Equal);
                            String fe2 = SqlExpressionBuilder.PrepareFilterExpression(PRMSupplierItemCategoryMapEntity.FLD_NAME_SupplierItemCategoryID, ent.SupplierItemCategoryID.ToString(), SQLMatchType.Equal);
                            String fe = SqlExpressionBuilder.PrepareFilterExpression(fe1, SQLJoinType.AND, fe2);

                            FCCPRMSupplierItemCategoryMap.GetFacadeCreate().Delete(ent, fe, DatabaseOperationType.Delete, TransactionRequired.No);
                        }
                    }

                    if (addNewList != null && addNewList.Count > 0)
                    {
                        foreach (PRMSupplierItemCategoryMapEntity ent in addNewList)
                        {
                            FCCPRMSupplierItemCategoryMap.GetFacadeCreate().Add(ent, DatabaseOperationType.Add, TransactionRequired.No);
                        }
                    }

                    MiscUtil.ShowMessage(lblMessage, "Vendor Item Category Map Information has been added successfully.", false);
                    BindList();
                    //_CurrentSupplierItemCategoryList = new List<PRMSupplierItemCategoryMapEntity>();

                }
                catch (Exception ex)
                {
                    MiscUtil.ShowMessage(lblMessage, ex.Message, true);
                }
            }
        }

        #endregion

        #region Event

        #region Page Event

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                PrepareValidator();
                PrepareInitialView();
                PrepareEditView();
            }
        }

        #endregion

        #region Button Event

        protected void btnSave_Click(object sender, EventArgs e)
        {
            SavePRMSupplierItemCategoryMapEntity();
        }

        #endregion

        #endregion Event
    }
}
