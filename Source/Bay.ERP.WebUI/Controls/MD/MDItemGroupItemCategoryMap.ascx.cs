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
    public partial class MDItemGroupItemCategoryMapControl : BaseControl
    {

        #region Extra

        class CustomerComparer : IEqualityComparer<MDItemGroupItemCategoryMapEntity>
        {
            public bool Equals(MDItemGroupItemCategoryMapEntity x, MDItemGroupItemCategoryMapEntity y)
            {
                return (x.ItemCategoryID.Equals(y.ItemCategoryID) && x.ItemGroupID.Equals(y.ItemGroupID));
            }

            public int GetHashCode(MDItemGroupItemCategoryMapEntity obj)
            {
                return obj.ItemGroupID.GetHashCode();
            }
        }

        class CustomerComparerAnother : IEqualityComparer<MDItemGroupItemCategoryMapEntity>
        {
            public bool Equals(MDItemGroupItemCategoryMapEntity x, MDItemGroupItemCategoryMapEntity y)
            {
                return (x.ItemCategoryID.Equals(y.ItemCategoryID));
            }

            public int GetHashCode(MDItemGroupItemCategoryMapEntity obj)
            {
                return obj.ItemCategoryID.GetHashCode();
            }
        }

        #endregion

        #region Properties

        public Int64 _ItemGroupItemCategoryMapID
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

        public MDItemGroupItemCategoryMapEntity _MDItemGroupItemCategoryMapEntity
        {
            get
            {
                MDItemGroupItemCategoryMapEntity entity = new MDItemGroupItemCategoryMapEntity();

                if (ViewState["CurrentEntity"] != null)
                {
                    entity = (MDItemGroupItemCategoryMapEntity)ViewState["CurrentEntity"];
                }

                return entity;
            }
            set
            {
                ViewState["CurrentEntity"] = value;
            }
        }

        private MDItemGroupItemCategoryMapEntity CurrentMDItemGroupItemCategoryMapEntity
        {
            get
            {
                if (_ItemGroupItemCategoryMapID > 0)
                {
                    if (_MDItemGroupItemCategoryMapEntity.ItemGroupItemCategoryMapID != _ItemGroupItemCategoryMapID)
                    {
                        _MDItemGroupItemCategoryMapEntity = FCCMDItemGroupItemCategoryMap.GetFacadeCreate().GetByID(_ItemGroupItemCategoryMapID);
                    }
                }

                return _MDItemGroupItemCategoryMapEntity;
            }
            set
            {
                _MDItemGroupItemCategoryMapEntity = value;
            }
        }

        public IList<MDItemGroupItemCategoryMapEntity> _CurrentItemGroupItemCategoryMapList
        {
            get
            {
                IList<MDItemGroupItemCategoryMapEntity> itemGroupItemCategoryMapList = null;

                if (ViewState["CurrentMDItemGroupItemCategoryMap"] != null)
                {
                    itemGroupItemCategoryMapList = (List<MDItemGroupItemCategoryMapEntity>)ViewState["CurrentMDItemGroupItemCategoryMap"];
                }
                else
                {
                    itemGroupItemCategoryMapList = new List<MDItemGroupItemCategoryMapEntity>();
                }

                return itemGroupItemCategoryMapList;
            }
            set
            {
                ViewState["CurrentMDItemGroupItemCategoryMap"] = value;
            }
        }

        public IList<MDItemCategoryEntity> _CurrentItemCategoryList
        {
            get
            {
                IList<MDItemCategoryEntity> itemCategoryList = null;

                if (ViewState["CurrentItemCategoryList"] != null)
                {
                    itemCategoryList = (List<MDItemCategoryEntity>)ViewState["CurrentItemCategoryList"];
                }
                else
                {
                    itemCategoryList = new List<MDItemCategoryEntity>();
                }

                return itemCategoryList;
            }
            set
            {
                ViewState["CurrentItemCategoryList"] = value;
            }
        }

        #endregion

        #region Methods

        private void BuildDropDownList()
        {
        }

        private void PrepareValidator()
        {
        }

        private void PrepareInitialView()
        {
            BuildDropDownList();
            BindList();
        }

        private void PrepareEditView()
        {
            MDItemGroupItemCategoryMapEntity mDItemGroupItemCategoryMapEntity = CurrentMDItemGroupItemCategoryMapEntity;
        }

        private Boolean ValidateInput()
        {
            Boolean validationResult = true;
            Int64 ItemGroupID;
            Int64.TryParse(lstBxItemGroup.SelectedValue, out ItemGroupID);

            if (ItemGroupID == 0)
            {
             MiscUtil.ShowMessage(lblMessage, "Please Select a Group.", true);
             validationResult = false;
            }

            return validationResult;
        }

        private void BindList()
        {
            BindMDItemGroupItemCategoryMapList();
            BindMDItemCategoryList();
        }

        private void BindMDItemGroupItemCategoryMapList()
        {
            lstBxItemGroup.DataSource = FCCMDItemGroup.GetFacadeCreate().GetIL(null, null, String.Empty, String.Empty, DatabaseOperationType.Load);
            lstBxItemGroup.DataTextField = "GroupName";
            lstBxItemGroup.DataValueField = "ItemGroupID";
            lstBxItemGroup.DataBind();
        }

        private void BindMDItemCategoryList()
        {
            String fe = SqlExpressionBuilder.PrepareFilterExpression(MDItemCategoryEntity.FLD_NAME_ParentItemCategoryID, String.Empty, SQLMatchType.IsNull);
            IList<MDItemCategoryEntity> itemCategoryList=FCCMDItemCategory.GetFacadeCreate().GetIL(null, null, String.Empty, fe, DatabaseOperationType.LoadWithFilterExpression);
            _CurrentItemCategoryList = itemCategoryList;
            chbxItemCategroy.DataSource = itemCategoryList; 
            chbxItemCategroy.DataTextField = "CategoryName";
            chbxItemCategroy.DataValueField = "ItemCategoryID";
            chbxItemCategroy.DataBind();
        }

        private MDItemGroupItemCategoryMapEntity BuildMDItemGroupItemCategoryMapEntity()
        {
            MDItemGroupItemCategoryMapEntity mDItemGroupItemCategoryMapEntity = CurrentMDItemGroupItemCategoryMapEntity;

            return mDItemGroupItemCategoryMapEntity;
        }

        private void UpdateMDItemGroupItemCategoryMapEntity()
        {
            if (IsValid)
            {
                try
                {
                    IList<MDItemGroupItemCategoryMapEntity> newMappedItems = new List<MDItemGroupItemCategoryMapEntity>();
                 
                    foreach (ListItem chbxItem in chbxItemCategroy.Items)
                    {
                        if (chbxItem.Selected)
                        {
                            MDItemGroupItemCategoryMapEntity mDItemGroupItemCategoryMapEntity = new MDItemGroupItemCategoryMapEntity();
                            mDItemGroupItemCategoryMapEntity.ItemGroupID = Int64.Parse(lstBxItemGroup.SelectedValue.ToString());
                            mDItemGroupItemCategoryMapEntity.ItemCategoryID=Int64.Parse(chbxItem.Value.ToString());
                            newMappedItems.Add(mDItemGroupItemCategoryMapEntity);
                        }
                    }

                    IList<MDItemGroupItemCategoryMapEntity> deleteList = _CurrentItemGroupItemCategoryMapList.Except(newMappedItems, new CustomerComparer()).ToList();
                    IList<MDItemGroupItemCategoryMapEntity> addNewList = newMappedItems.Except(_CurrentItemGroupItemCategoryMapList, new CustomerComparer()).ToList();

                    if (deleteList != null && deleteList.Count > 0)
                    {
                        foreach (MDItemGroupItemCategoryMapEntity ent in deleteList)
                        {
                            String fe1 = SqlExpressionBuilder.PrepareFilterExpression(MDItemGroupItemCategoryMapEntity.FLD_NAME_ItemCategoryID, ent.ItemCategoryID.ToString(), SQLMatchType.Equal);
                            String fe2 = SqlExpressionBuilder.PrepareFilterExpression(MDItemGroupItemCategoryMapEntity.FLD_NAME_ItemGroupID, ent.ItemGroupID.ToString(), SQLMatchType.Equal);
                            String fe = SqlExpressionBuilder.PrepareFilterExpression(fe1, SQLJoinType.AND, fe2);

                            FCCMDItemGroupItemCategoryMap.GetFacadeCreate().Delete(ent, fe, DatabaseOperationType.Delete, TransactionRequired.No);
                        }
                    }

                    if (addNewList != null && addNewList.Count > 0)
                    {
                        foreach (MDItemGroupItemCategoryMapEntity ent in addNewList)
                        {
                            FCCMDItemGroupItemCategoryMap.GetFacadeCreate().Add(ent, DatabaseOperationType.Add, TransactionRequired.No);
                        }
                    }
                   
                   MiscUtil.ShowMessage(lblMessage, "Item Group Item Category Map Information has been updated successfully.", false);
                   _CurrentItemGroupItemCategoryMapList = new List<MDItemGroupItemCategoryMapEntity>(); 
                   
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
            if (ValidateInput())
            {
                UpdateMDItemGroupItemCategoryMapEntity();
            }
        }

        #endregion

        #region ListBox Event

        protected void lstBxItemGroup_SelectedIndexChanged(object sender, EventArgs e)
        {
            String fe=SqlExpressionBuilder.PrepareFilterExpression(MDItemGroupItemCategoryMapEntity.FLD_NAME_ItemGroupID,lstBxItemGroup.SelectedValue.ToString(),SQLMatchType.Equal);
            IList<MDItemGroupItemCategoryMapEntity> ItemCategoryList = FCCMDItemGroupItemCategoryMap.GetFacadeCreate().GetIL(null, null, String.Empty, fe, DatabaseOperationType.LoadWithFilterExpression);
            _CurrentItemGroupItemCategoryMapList = ItemCategoryList;

            if (ItemCategoryList != null && ItemCategoryList.Count > 0)
            {
                foreach (MDItemGroupItemCategoryMapEntity ent in ItemCategoryList)
                {
                    foreach (ListItem chbxItem in chbxItemCategroy.Items)
                    {

                        if (ent.ItemCategoryID.ToString() == chbxItem.Value.ToString())
                        {
                            chbxItem.Selected = true;
                            break;
                        }
                    }
                }
                IList<MDItemGroupItemCategoryMapEntity> TempitemGroupList=new List<MDItemGroupItemCategoryMapEntity>();
                if (_CurrentItemCategoryList != null && _CurrentItemCategoryList.Count > 0)
                {
                    foreach (MDItemCategoryEntity ent in _CurrentItemCategoryList)
                    {
                        MDItemGroupItemCategoryMapEntity mDItemGroupEntity = new MDItemGroupItemCategoryMapEntity();
                        mDItemGroupEntity.ItemCategoryID = ent.ItemCategoryID;
                        TempitemGroupList.Add(mDItemGroupEntity);
                    }

                    IList<MDItemGroupItemCategoryMapEntity> uncheckedList = TempitemGroupList.Except(_CurrentItemGroupItemCategoryMapList, new CustomerComparerAnother()).ToList();

                    if (uncheckedList != null && uncheckedList.Count > 0)
                    {
                        foreach (MDItemGroupItemCategoryMapEntity ent in uncheckedList)
                        {
                            foreach (ListItem chbxItem in chbxItemCategroy.Items)
                            {

                                if (ent.ItemCategoryID.ToString() == chbxItem.Value.ToString())
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
                foreach (ListItem chbxItem in chbxItemCategroy.Items)
                {
                 chbxItem.Selected = false;
                }
            }
        }

        #endregion

        #endregion Event

    }
}
