// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 16-Apr-2012, 04:09:50




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
    public partial class PRMItemBrandMapControl : BaseControl
    {

        #region Extra

        class CustomerComparer : IEqualityComparer<PRMItemBrandMapEntity>
        {
            public bool Equals(PRMItemBrandMapEntity x, PRMItemBrandMapEntity y)
            {
                return (x.BrandID.Equals(y.BrandID) && x.ItemID.Equals(y.ItemID));
            }

            public int GetHashCode(PRMItemBrandMapEntity obj)
            {
                return obj.BrandID.GetHashCode();
            }
        }


        class CustomerComparerAnother : IEqualityComparer<PRMItemBrandMapEntity>
        {
            public bool Equals(PRMItemBrandMapEntity x, PRMItemBrandMapEntity y)
            {
                return (x.BrandID.Equals(y.BrandID));
            }

            public int GetHashCode(PRMItemBrandMapEntity obj)
            {
                return obj.BrandID.GetHashCode();
            }
        }

        #endregion

        #region Properties

        public Int64 _ItemBrandMapID
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

        public PRMItemBrandMapEntity _PRMItemBrandMapEntity
        {
            get
            {
                PRMItemBrandMapEntity entity = new PRMItemBrandMapEntity();

                if (ViewState["CurrentEntity"] != null)
                {
                    entity = (PRMItemBrandMapEntity)ViewState["CurrentEntity"];
                }

                return entity;
            }
            set
            {
                ViewState["CurrentEntity"] = value;
            }
        }

        private PRMItemBrandMapEntity CurrentPRMItemBrandMapEntity
        {
            get
            {
                if (_ItemBrandMapID > 0)
                {
                    if (_PRMItemBrandMapEntity.ItemBrandMapID != _ItemBrandMapID)
                    {
                        _PRMItemBrandMapEntity = FCCPRMItemBrandMap.GetFacadeCreate().GetByID(_ItemBrandMapID);
                    }
                }

                return _PRMItemBrandMapEntity;
            }
            set
            {
                _PRMItemBrandMapEntity = value;
            }
        }

        public IList<PRMItemBrandMapEntity> _CurrentItemBrandMapList
        {
            get
            {
                IList<PRMItemBrandMapEntity> itemBrandMapList = null;

                if (ViewState["CurrentItemBrandMapList"] != null)
                {
                    itemBrandMapList = (List<PRMItemBrandMapEntity>)ViewState["CurrentItemBrandMapList"];
                }
                else
                {
                    itemBrandMapList = new List<PRMItemBrandMapEntity>();
                }

                return itemBrandMapList;
            }
            set
            {
                ViewState["CurrentItemBrandMapList"] = value;
            }
        }

        public IList<MDBrandEntity> _CurrentItemBrandList
        {
            get
            {
                IList<MDBrandEntity> itemBrandList = null;

                if (ViewState["CurrentItemBrandList"] != null)
                {
                    itemBrandList = (List<MDBrandEntity>)ViewState["CurrentItemBrandList"];
                }
                else
                {
                    itemBrandList = new List<MDBrandEntity>();
                }

                return itemBrandList;
            }
            set
            {
                ViewState["CurrentItemBrandList"] = value;
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
            PRMItemBrandMapEntity pRMItemBrandMapEntity = CurrentPRMItemBrandMapEntity;
        }

        private void BindList()
        {
            BindPRMItemBrandMapList();
        }
       
        private void BindPRMItemBrandMapList()
        {
            String se = SqlExpressionBuilder.PrepareSortExpression(MDBrandEntity.FLD_NAME_BrandName, SQLSortOrderType.Assending);
            IList<MDBrandEntity> ItemBrandList=FCCMDBrand.GetFacadeCreate().GetIL(null, null, se, String.Empty, DatabaseOperationType.LoadWithSortExpression);
            _CurrentItemBrandList = ItemBrandList;
            chbxItemBrand.DataSource = ItemBrandList;
            chbxItemBrand.DataTextField = "BrandName";
            chbxItemBrand.DataValueField = "BrandID";
            chbxItemBrand.DataBind();
        }

        private void SavePRMItemBrandMapEntity()
        {
            if (IsValid)
            {
                try
                {
                    IList<PRMItemBrandMapEntity> newMappedItems = new List<PRMItemBrandMapEntity>();

                    foreach (ListItem chbxItem in chbxItemBrand.Items)
                    {
                        if (chbxItem.Selected)
                        {
                            PRMItemBrandMapEntity mDItemBrandMapEntity = new PRMItemBrandMapEntity();
                            mDItemBrandMapEntity.ItemID= Int64.Parse(treeItem.SelectedValue.ToString());
                            mDItemBrandMapEntity.BrandID = Int64.Parse(chbxItem.Value.ToString());
                            newMappedItems.Add(mDItemBrandMapEntity);
                        }
                    }

                    IList<PRMItemBrandMapEntity> deleteList = _CurrentItemBrandMapList.Except(newMappedItems, new CustomerComparer()).ToList();
                    IList<PRMItemBrandMapEntity> addNewList = newMappedItems.Except(_CurrentItemBrandMapList, new CustomerComparer()).ToList();

                    if (deleteList != null && deleteList.Count > 0)
                    {
                        foreach (PRMItemBrandMapEntity ent in deleteList)
                        {
                            String fe1 = SqlExpressionBuilder.PrepareFilterExpression(PRMItemBrandMapEntity.FLD_NAME_ItemID, ent.ItemID.ToString(), SQLMatchType.Equal);
                            String fe2 = SqlExpressionBuilder.PrepareFilterExpression(PRMItemBrandMapEntity.FLD_NAME_BrandID, ent.BrandID.ToString(), SQLMatchType.Equal);
                            String fe = SqlExpressionBuilder.PrepareFilterExpression(fe1, SQLJoinType.AND, fe2);

                            FCCPRMItemBrandMap.GetFacadeCreate().Delete(ent, fe, DatabaseOperationType.Delete, TransactionRequired.No);
                        }
                    }

                    if (addNewList != null && addNewList.Count > 0)
                    {
                        foreach (PRMItemBrandMapEntity ent in addNewList)
                        {
                            FCCPRMItemBrandMap.GetFacadeCreate().Add(ent, DatabaseOperationType.Add, TransactionRequired.No);
                        }
                    }

                    MiscUtil.ShowMessage(lblMessage, "Item Brand Map Information has been added successfully.", false);

                    String feCurrent = SqlExpressionBuilder.PrepareFilterExpression(PRMItemBrandMapEntity.FLD_NAME_ItemID, treeItem.SelectedValue.ToString(), SQLMatchType.Equal);
                    IList<PRMItemBrandMapEntity> ItemBrandList = FCCPRMItemBrandMap.GetFacadeCreate().GetIL(null, null, String.Empty, feCurrent, DatabaseOperationType.LoadWithFilterExpression);
                    _CurrentItemBrandMapList = ItemBrandList;

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
            SavePRMItemBrandMapEntity();
        }

        #endregion

        #region Tree Events

        protected void treeItem_SelectedNodeChanged(object sender, EventArgs e)
        {

            if (treeItem.SelectedNode.Depth == 2)
            {
                divUpdatePanel.Visible = true;

                String fe = SqlExpressionBuilder.PrepareFilterExpression(PRMItemBrandMapEntity.FLD_NAME_ItemID, treeItem.SelectedValue.ToString(), SQLMatchType.Equal);
                IList<PRMItemBrandMapEntity> ItemBrandList = FCCPRMItemBrandMap.GetFacadeCreate().GetIL(null, null, String.Empty, fe, DatabaseOperationType.LoadWithFilterExpression);
                _CurrentItemBrandMapList = ItemBrandList;

                if (ItemBrandList != null && ItemBrandList.Count > 0)
                {
                    foreach (PRMItemBrandMapEntity ent in ItemBrandList)
                    {
                        foreach (ListItem chbxItem in chbxItemBrand.Items)
                        {

                            if (ent.BrandID.ToString() == chbxItem.Value.ToString())
                            {
                                chbxItem.Selected = true;
                                break;
                            }
                        }
                    }
                    IList<PRMItemBrandMapEntity> TempitemBrandList = new List<PRMItemBrandMapEntity>();
                    if (_CurrentItemBrandMapList != null && _CurrentItemBrandMapList.Count > 0)
                    {
                        foreach (MDBrandEntity ent in _CurrentItemBrandList)
                        {
                            PRMItemBrandMapEntity mDItemBrandEntity = new PRMItemBrandMapEntity();
                            mDItemBrandEntity.BrandID = ent.BrandID;
                            TempitemBrandList.Add(mDItemBrandEntity);
                        }

                        IList<PRMItemBrandMapEntity> uncheckedList = TempitemBrandList.Except(_CurrentItemBrandMapList, new CustomerComparerAnother()).ToList();

                        if (uncheckedList != null && uncheckedList.Count > 0)
                        {
                            foreach (PRMItemBrandMapEntity ent in uncheckedList)
                            {
                                foreach (ListItem chbxItem in chbxItemBrand.Items)
                                {

                                    if (ent.BrandID.ToString() == chbxItem.Value.ToString())
                                    {
                                        chbxItem.Selected = false;
                                    }
                                }
                            }
                        }
                    }
                }
                else
                {
                    foreach (ListItem chbxItem in chbxItemBrand.Items)
                    {
                        chbxItem.Selected = false;
                    }
                }
            }
            else
            {
                divUpdatePanel.Visible = false;
            }
        }

        #endregion

        #endregion Event
    }
}
