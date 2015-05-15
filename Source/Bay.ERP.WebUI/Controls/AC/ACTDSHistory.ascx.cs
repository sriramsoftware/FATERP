// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 05-Mar-2013, 10:30:04




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
    public partial class ACTDSHistoryControl : BaseControl
    {       
        #region Properties

        public Int64 _TDSHistoryID
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

        public ACTDSHistoryEntity _ACTDSHistoryEntity
        {
            get
            {
                ACTDSHistoryEntity entity = new ACTDSHistoryEntity();

                if (ViewState["CurrentEntity"] != null)
                {
                    entity = (ACTDSHistoryEntity)ViewState["CurrentEntity"];
                }

                return entity;
            }
            set
            {
                ViewState["CurrentEntity"] = value;
            }
        }

        private ACTDSHistoryEntity CurrentACTDSHistoryEntity
        {
            get
            {
                if (_TDSHistoryID > 0)
                {
                    if (_ACTDSHistoryEntity.TDSHistoryID != _TDSHistoryID)
                    {
                        _ACTDSHistoryEntity = FCCACTDSHistory.GetFacadeCreate().GetByID(_TDSHistoryID);
                    }
                }

                return _ACTDSHistoryEntity;
            }
            set
            {
                _ACTDSHistoryEntity = value;
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
        }

        private void PrepareEditView()
        {
            ACTDSHistoryEntity aCTDSHistoryEntity = CurrentACTDSHistoryEntity;


            if (!aCTDSHistoryEntity.IsNew)
            {
                
            }
        }

        private void BindList()
        {
            BindACTDSHistoryList();
        }

        private void BindACTDSHistoryList()
        {
            lvACTDSHistory.DataBind();
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

        protected void lvACTDSHistory_ItemCommand(object sender, ListViewCommandEventArgs e)
        {
            Int64 TDSHistoryID;

            Int64.TryParse(e.CommandArgument.ToString(), out TDSHistoryID);

            if (TDSHistoryID > 0)
            {
                if (string.Equals(e.CommandName, "EditItem"))
                {
                    _TDSHistoryID = TDSHistoryID;

                    PrepareEditView();
                }
                else if (string.Equals(e.CommandName, "DeleteItem"))
                {
                    try
                    {
                        Int64 result = -1;

                        String fe = SqlExpressionBuilder.PrepareFilterExpression(ACTDSHistoryEntity.FLD_NAME_TDSHistoryID, TDSHistoryID.ToString(), SQLMatchType.Equal);

                        ACTDSHistoryEntity aCTDSHistoryEntity = new ACTDSHistoryEntity();


                        result = FCCACTDSHistory.GetFacadeCreate().Delete(aCTDSHistoryEntity, fe, DatabaseOperationType.Delete, TransactionRequired.No);

                        if (result == 0)
                        {
                            _TDSHistoryID = 0;
                            _ACTDSHistoryEntity = new ACTDSHistoryEntity();
                            PrepareInitialView();
                            BindACTDSHistoryList();

                            MiscUtil.ShowMessage(lblMessage, "A CTDSHistory has been successfully deleted.", true);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to delete A CTDSHistory.", true);
                        }
                    }
                    catch (Exception ex)
                    {
                        MiscUtil.ShowMessage(lblMessage, ex.Message, true);
                    }
                }
            }
        }

        #endregion List View Event

        #region ObjectDataSource Event

        protected void odsACTDSHistory_Selecting(object sender, ObjectDataSourceSelectingEventArgs e)
        {
            e.InputParameters["filterExpression"] = String.Empty;
        }

        #endregion

        #region Button Event

        #endregion

        #endregion Event
    }
}
