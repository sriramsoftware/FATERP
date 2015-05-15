// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 30-Nov-2011, 02:49:46




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
    public partial class PRMPreBOQToBOQMigrationControl : ProjectBaseControl
    {       
        #region Properties

        public PRMPreBOQEntity _PRMPreBOQEntity
        {
            get
            {
                PRMPreBOQEntity entity = new PRMPreBOQEntity();

                if (ViewState["CurrentEntity"] != null)
                {
                    entity = (PRMPreBOQEntity)ViewState["CurrentEntity"];
                }

                return entity;
            }
            set
            {
                ViewState["CurrentEntity"] = value;
            }
        }

        private PRMPreBOQEntity CurrentPRMPreBOQEntity
        {
            get
            {
                if (this.OverviewProjectID > 0)
                {
                    String fe = SqlExpressionBuilder.PrepareFilterExpression(PRMPreBOQEntity.FLD_NAME_ProjectID, this.OverviewProjectID.ToString(), SQLMatchType.Equal);

                    IList<PRMPreBOQEntity> tempList = FCCPRMPreBOQ.GetFacadeCreate().GetIL(null, null, String.Empty, fe, DatabaseOperationType.LoadWithFilterExpression);

                    if (tempList != null && tempList.Count > 0)
                    {
                        _PRMPreBOQEntity = tempList[0];
                    }
                    else
                    {
                        _PRMPreBOQEntity = new PRMPreBOQEntity();
                    }
                }

                return _PRMPreBOQEntity;
            }
            set
            {
                _PRMPreBOQEntity = value;
            }
        }

        #endregion

        #region Methods

        private void PrepareValidator()
        {
        }

        private void PrepareInitialView()
        {            
            FormLock(CurrentPRMPreBOQEntity.IsLocked);

            _PRMPreBOQEntity = null;
        }
        private void FormLock(Boolean isLocked)
        {
            #region Form Lock

            if (isLocked == true)
            {
                btnSubmit.Enabled = false;
                lblFormLock.Visible = true;
            }
            else
            {
                btnSubmit.ToolTip = "Migration From BOQ To Project Cost Takes Some Times; Then The Form Has been Locked, After That No Information Can Be Changed.";
                btnSubmit.Enabled = true;
                lblFormLock.Visible = false;
            }

            #endregion Form Lock
        } 

        private void SavePRMPreBOQEntity()
        {
            if (IsValid)
            {
                try
                {
                    Int64 result = 0;

                    IList<PreBOQtoBOQMigration_CustomEntity> list = FCCPreBOQtoBOQMigration_Custom.GetFacadeCreate().GetIL(CurrentPRMPreBOQEntity.PreBOQID, this.CurrentMember.MemberID);

                    if(list != null && list.Count > 0)
                    {
                        if( list[0].BOQID != null)
                        {
                            result = list[0].BOQID.Value;
                        }
                    }

                    if(result > 0)
                    {
                        PRMPreBOQEntity _pRMPreBOQEntity = CurrentPRMPreBOQEntity;
                        _pRMPreBOQEntity.PreBOQStatusID = MasterDataConstants.PreBOQStatus.COMPLETED;
                        String fe = SqlExpressionBuilder.PrepareFilterExpression(PRMPreBOQEntity.FLD_NAME_PreBOQID, CurrentPRMPreBOQEntity.PreBOQID.ToString(), SQLMatchType.Equal);
                        FCCPRMPreBOQ.GetFacadeCreate().Update(_pRMPreBOQEntity, fe, DatabaseOperationType.Update, TransactionRequired.No);
                        PrepareInitialView();

                        MiscUtil.ShowMessage(lblMessage, "BOQ to Project Cost migration is successful.", UIConstants.MessageType.GREEN);
                    }
                    else
                    {
                        MiscUtil.ShowMessage(lblMessage, "BOQ to Project Cost migration Failed.", UIConstants.MessageType.RED);
                    }
                }
                catch (Exception ex)
                {
                    MiscUtil.ShowMessage(lblMessage, ex.Message, UIConstants.MessageType.RED);
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
            }
        }

        #endregion

        #region Button Event

        protected void btnSave_Click(object sender, EventArgs e)
        {
            SavePRMPreBOQEntity();
        }

        #endregion

        #endregion Event
    }
}
