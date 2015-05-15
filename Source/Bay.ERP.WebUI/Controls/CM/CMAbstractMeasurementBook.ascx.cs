// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 03-Oct-2012, 04:24:33




using System;
using System.Web.UI.WebControls;
using System.Collections.Generic;

using Bay.ERP.Web.UI.Helper;
using Bay.ERP.Common.BusinessEntities;
using Bay.ERP.BusinessFacade;
using Bay.ERP.FacadeCreator.FacadeContext;
using Bay.ERP.Common.Helper;
using Bay.ERP.Common.Shared;

namespace Bay.ERP.Web.UI
{
    public partial class CMAbstractMeasurementBookControl : BaseControl
    {
        #region Properties

        public Int64 _MeasurementBookID
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

        public CMMeasurementBookEntity _CMMeasurementBookEntity
        {
            get
            {
                CMMeasurementBookEntity entity = new CMMeasurementBookEntity();

                if (ViewState["CurrentEntity"] != null)
                {
                    entity = (CMMeasurementBookEntity)ViewState["CurrentEntity"];
                }

                return entity;
            }
            set
            {
                ViewState["CurrentEntity"] = value;
            }
        }

        private CMMeasurementBookEntity CurrentCMMeasurementBookEntity
        {
            get
            {
                if (_MeasurementBookID > 0)
                {
                    if (_CMMeasurementBookEntity.MeasurementBookID != _MeasurementBookID)
                    {
                        _CMMeasurementBookEntity = FCCCMMeasurementBook.GetFacadeCreate().GetByID(_MeasurementBookID);
                    }
                }

                return _CMMeasurementBookEntity;
            }
            set
            {
                _CMMeasurementBookEntity = value;
            }
        }

        #endregion

        #region Methods

        private void BuildDropDownList()
        {
            MiscUtil.PopulateBDProject(ddlProjectID, false);
        }

        private void PrepareValidator()
        {
        }

        private void PrepareInitialView()
        {
            BuildDropDownList();
            BindList();
        }

        private void BindList()
        {
            if (ddlProjectID != null && ddlProjectID.SelectedValue != "0")
            {   
                lvCMAbstractMeasurementBook.DataSource = FCCCMAbstractMeasurementBook_Custom.GetFacadeCreate().GetDT(Int64.Parse(ddlProjectID.SelectedValue.ToString()));
                lvCMAbstractMeasurementBook.DataBind();
            }
            
        }

        private void BindCMMeasurementBookList()
        {

        }

        #endregion

        #region Event

        #region Page Event

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                PrepareInitialView();
            }
        }

        #endregion

        #region List View Event

        protected void lvCMAbstractMeasurementBook_ItemDataBound(object sender, ListViewItemEventArgs e)
        {
            if (e.Item.ItemType == ListViewItemType.DataItem)
            {

                ListViewDataItem dataItem = (ListViewDataItem)e.Item;

                DataKey currentDataKey = this.lvCMAbstractMeasurementBook.DataKeys[dataItem.DataItemIndex];

                Label lblRate = (Label)e.Item.FindControl("lblRate");
                Label lblPreviousQty = (Label)e.Item.FindControl("lblPreviousQty");
                Label lblPresentQty = (Label)e.Item.FindControl("lblPresentQty");
                Label lblAmount = (Label)e.Item.FindControl("lblAmount");
                Label lblTotal = (Label)e.Item.FindControl("lblTotal");

                System.Data.DataRowView rowView = e.Item.DataItem as System.Data.DataRowView;
                string currentItemID = rowView["ItemID"].ToString();
                string currentProjectID = rowView["ProjectID"].ToString();

                String fe = String.Empty;

                
              //  IList<PRMSupplierItemMapEntity> lstSupplierItemMap = FCCPRMSupplierItemMap.GetFacadeCreate().GetIL(null, null, String.Empty, fe, DatabaseOperationType.LoadWithFilterExpression);

                //CMAbstractMeasurementBook_CustomEntity ent = (CMAbstractMeasurementBook_CustomEntity)dataItem.DataItem;
                IList<CMAbstractMeasurementBookHelper_CustomEntity> lst = FCCCMAbstractMeasurementBookHelper_Custom.GetFacadeCreate().GetIL(Int64.Parse(currentProjectID),Int64.Parse(currentItemID));
                if (lst != null && lst.Count > 0)
                {
                    lblPresentQty.Text = lst[0].PresentQty.ToString();
                }
                else
                {
                    lblPresentQty.Text = "0";
                }
              
                Decimal rate,previousQty,presentQty,total,amount;
                //lbl
                Decimal.TryParse(lblPresentQty.Text.ToString(), out presentQty);
                Decimal.TryParse(lblTotal.Text.ToString(), out total);
                Decimal.TryParse(lblRate.Text.ToString(), out rate);
                previousQty = total - presentQty;
                lblPreviousQty.Text = previousQty.ToString();
                
            }
        }

        #endregion List View Event

        #region Button Event

        #endregion

        #region Dropdown List Event

        protected void ddlProjectID_SelectedIndexChanged(object sender, EventArgs e)
        {
            BindList();
        }

        #endregion

        #endregion Event

    }
}
