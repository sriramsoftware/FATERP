// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 06-Oct-2013, 05:27:25




using System;
using System.Web.UI.WebControls;
using System.Collections.Generic;

using Bay.ERP.Web.UI.Helper;
using Bay.ERP.Common.BusinessEntities;
using Bay.ERP.BusinessFacade;
using Bay.ERP.FacadeCreator.FacadeContext;
using Bay.ERP.Common.Helper;
using Bay.ERP.Common.Shared;
using AjaxControlToolkit;
using System.IO;

namespace Bay.ERP.Web.UI
{
    public partial class CMNEventUploadInfoControl : BaseControl
    {       
        #region Properties

        public Int64 _EventUploadInfoID
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

        public CMNEventUploadInfoEntity _CMNEventUploadInfoEntity
        {
            get
            {
                CMNEventUploadInfoEntity entity = new CMNEventUploadInfoEntity();

                if (ViewState["CurrentEntity"] != null)
                {
                    entity = (CMNEventUploadInfoEntity)ViewState["CurrentEntity"];
                }

                return entity;
            }
            set
            {
                ViewState["CurrentEntity"] = value;
            }
        }

        private CMNEventUploadInfoEntity CurrentCMNEventUploadInfoEntity
        {
            get
            {
                if (_EventUploadInfoID > 0)
                {
                    if (_CMNEventUploadInfoEntity.EventUploadInfoID != _EventUploadInfoID)
                    {
                        _CMNEventUploadInfoEntity = FCCCMNEventUploadInfo.GetFacadeCreate().GetByID(_EventUploadInfoID);
                    }
                }

                return _CMNEventUploadInfoEntity;
            }
            set
            {
                _CMNEventUploadInfoEntity = value;
            }
        }

        public Int64 OverviewEventID
        {
            get
            {
                Int64 overviewEventID = 0;

                if (!StringHelper.IsBlank(Helper.Url.SecureUrl[UrlConstants.OVERVIEW_EVENT_ID]))
                {
                    Int64.TryParse(Helper.Url.SecureUrl[UrlConstants.OVERVIEW_EVENT_ID], out overviewEventID);
                }

                return overviewEventID;
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
        }

        private void BindList()
        {
            BindCMNEventUploadInfoList();
        }

        private void BindCMNEventUploadInfoList()
        {
            lvCMNEventUploadInfo.DataBind();
        }

        #endregion

        #region Event

        #region Page Event

        protected void Page_Load(object sender, EventArgs e)
        {
            afuFiles.UploadedComplete += new EventHandler<AsyncFileUploadEventArgs>(afuFiles_UploadedComplete);
            afuFiles.UploadedFileError += new EventHandler<AsyncFileUploadEventArgs>(afuFiles_UploadedFileError);
            if (!IsPostBack)
            {
                PrepareValidator();
                PrepareInitialView();
                PrepareEditView();
            }
        }

        #endregion

        #region List View Event

        protected void lvCMNEventUploadInfo_ItemCommand(object sender, ListViewCommandEventArgs e)
        {
            Int64 EventUploadInfoID;

            Int64.TryParse(e.CommandArgument.ToString(), out EventUploadInfoID);

            if (EventUploadInfoID > 0)
            {
                if (string.Equals(e.CommandName, "EditItem"))
                {
                    _EventUploadInfoID = EventUploadInfoID;

                    PrepareEditView();
                }
                else if (string.Equals(e.CommandName, "DeleteItem"))
                {
                    try
                    {
                        Int64 result = -1;

                        String fe = SqlExpressionBuilder.PrepareFilterExpression(CMNEventUploadInfoEntity.FLD_NAME_EventUploadInfoID, EventUploadInfoID.ToString(), SQLMatchType.Equal);

                        CMNEventUploadInfoEntity cMNEventUploadInfoEntity = new CMNEventUploadInfoEntity();


                        result = FCCCMNEventUploadInfo.GetFacadeCreate().Delete(cMNEventUploadInfoEntity, fe, DatabaseOperationType.Delete, TransactionRequired.No);

                        if (result == 0)
                        {
                            _EventUploadInfoID = 0;
                            _CMNEventUploadInfoEntity = new CMNEventUploadInfoEntity();
                            PrepareInitialView();
                            BindCMNEventUploadInfoList();

                            MiscUtil.ShowMessage(lblMessage, "C MNEvent Upload Info has been successfully deleted.", true);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to delete C MNEvent Upload Info.", true);
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

        protected void odsCMNEventUploadInfo_Selecting(object sender, ObjectDataSourceSelectingEventArgs e)
        {
            String fe = SqlExpressionBuilder.PrepareFilterExpression(CMNEventUploadInfoEntity.FLD_NAME_EventID, OverviewEventID.ToString(), SQLMatchType.Equal);
            e.InputParameters["filterExpression"] = fe;
        }

        #endregion

        #region Button Event

        protected void btnClick_Click(object sender, EventArgs e)
        {
            BindCMNEventUploadInfoList();
        }

        #endregion

        #region File Uploader Events

        protected void afuFiles_UploadedComplete(object sender, AsyncFileUploadEventArgs e)
        {
            try
            {
                CMNEventUploadInfoEntity ent = new CMNEventUploadInfoEntity();
                ent.EventID = OverviewEventID;
                ent.UploadedDateTime = System.DateTime.Now;
                ent.UploadedByMemberID = CurrentMember.MemberID;
                ent.OriginalFileName = Path.GetFileName(e.FileName);
                ent.CurrentFileName = Guid.NewGuid().ToString() + Path.GetExtension(e.FileName);
                ent.FileType = "";
                ent.Extension = Path.GetExtension(e.FileName);
                ent.Path = FileUploadConstants.EVENT.EVENT_IMAGE + ent.CurrentFileName;
                ent.Remarks = String.Empty;

                FCCCMNEventUploadInfo.GetFacadeCreate().Add(ent, DatabaseOperationType.Add, TransactionRequired.No);

                // file upload

                afuFiles.SaveAs(Server.MapPath(ent.Path));

                //LoadFileListGried
                BindCMNEventUploadInfoList();
                MiscUtil.ShowMessage(lblMessage, "Event Upload Info Save Successfully.", false);
            }
            catch (Exception ex)
            {
                MiscUtil.ShowMessage(lblMessage, "Some Error Occured."+ex.Message, true);
             
            }
          
        }

        protected void afuFiles_UploadedFileError(object sender, AsyncFileUploadEventArgs e)
        {
            //ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "error", "top.$get(\"" + uploadResult.ClientID + "\").innerHTML = 'Error: " + e.StatusMessage + "';", true);
        }

        #endregion

        #endregion Event
    }
}
