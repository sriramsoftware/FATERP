// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 11-Jan-2012, 04:11:49



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
    public partial class REQRequisitionItemViewControl : BaseControl
    {       
        #region Properties

        public Int64 _RequisitionItemID
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

        public REQRequisitionItemEntity _REQRequisitionItemEntity
        {
            get
            {
                REQRequisitionItemEntity entity = new REQRequisitionItemEntity();

                if (ViewState["CurrentEntity"] != null)
                {
                    entity = (REQRequisitionItemEntity)ViewState["CurrentEntity"];
                }

                return entity;
            }
            set
            {
                ViewState["CurrentEntity"] = value;
            }
        }

        private REQRequisitionItemEntity CurrentREQRequisitionItemEntity
        {
            get
            {
                if (_RequisitionItemID > 0)
                {
                    if (_REQRequisitionItemEntity.RequisitionItemID != _RequisitionItemID)
                    {
                        _REQRequisitionItemEntity = FCCREQRequisitionItem.GetFacadeCreate().GetByID(_RequisitionItemID);
                    }
                }

                return _REQRequisitionItemEntity;
            }
            set
            {
                _REQRequisitionItemEntity = value;
            }
        }

        public Int64 REQRequisitionID
        {
            get
            {
                Int64 rEQRequisitionID = 0;

                if (!StringHelper.IsBlank(Helper.Url.SecureUrl[REQRequisitionEntity.FLD_NAME_RequisitionID]))
                {
                    Int64.TryParse(Helper.Url.SecureUrl[REQRequisitionEntity.FLD_NAME_RequisitionID], out rEQRequisitionID);
                }

                return rEQRequisitionID;
            }
        }

        private BDProjectEntity CurrentBDProjectEntity
        {
            get
            {
                BDProjectEntity _bDProjectEntity = new BDProjectEntity();

                if (CurrentREQRequisitionEntity.ProjectID > 0)
                {
                    _bDProjectEntity = FCCBDProject.GetFacadeCreate().GetByID(CurrentREQRequisitionEntity.ProjectID);
                }

                return _bDProjectEntity;
            }
        }

        private REQRequisitionEntity CurrentREQRequisitionEntity
        {
            get
            {
                REQRequisitionEntity _REQRequisitionEntity;

                if (REQRequisitionID > 0)
                {
                    _REQRequisitionEntity = FCCREQRequisition.GetFacadeCreate().GetByID(REQRequisitionID);
                }

                else
                {
                    _REQRequisitionEntity = new REQRequisitionEntity();
                }

                return _REQRequisitionEntity;
            }
        }

        public Decimal ItemQty
        {
            get
            {
                Decimal itemQty=0;
                if (ViewState["vs_ItemQty"] != null)
                {
                    Decimal.TryParse(ViewState["vs_ItemQty"].ToString(),out itemQty);
                }

                return itemQty;
            }
            set
            {
                ViewState["vs_ItemQty"] = value;
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
            lblRequisitonNo.Text = CurrentREQRequisitionEntity.RequisitionNo.ToString();

            hypProjectID.Value = CurrentREQRequisitionEntity.ProjectID.ToString();
            lblProjectName.Text = CurrentBDProjectEntity.ProjectName.ToString();
        }

        private void PrepareEditView()
        {
        }

        private void BindList()
        {
            BindREQRequisitionItemList();
        }

        private void BindREQRequisitionItemList()
        {
            lvREQRequisitionItem.DataBind();
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

        #region List View Event

        #endregion List View Event

        #region ObjectDataSource Event

        protected void odsREQRequisitionItem_Selecting(object sender, ObjectDataSourceSelectingEventArgs e)
        {  
            String fe = SqlExpressionBuilder.PrepareFilterExpression("REQRequisitionItem." + REQRequisitionItemEntity.FLD_NAME_RequisitionID, REQRequisitionID.ToString(), SQLMatchType.Equal);
            e.InputParameters["filterExpression"] = fe;
        }

        #endregion

        #region Button Event

        #endregion

        #endregion Event
    }
}
