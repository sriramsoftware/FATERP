// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 28-Dec-2011, 07:18:54




using System;
using System.Web.UI.WebControls;
using System.Collections.Generic;
using AjaxControlToolkit;
using System.Web.UI;
using System.IO;
using System.Web;
using System.Data;

using Bay.ERP.Web.UI.Helper;
using Bay.ERP.Common.BusinessEntities;
using Bay.ERP.BusinessFacade;
using Bay.ERP.FacadeCreator.FacadeContext;
using Bay.ERP.Common.Helper;
using Bay.ERP.Common.Shared;

namespace Bay.ERP.Web.UI
{
    public partial class OTIssueUploadInfoControl : IssueBaseControl
    {       
        #region Properties

        public Int64 _IssueUploadInfoID
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

        public OTIssueUploadInfoEntity _OTIssueUploadInfoEntity
        {
            get
            {
                OTIssueUploadInfoEntity entity = new OTIssueUploadInfoEntity();

                if (ViewState["CurrentEntity"] != null)
                {
                    entity = (OTIssueUploadInfoEntity)ViewState["CurrentEntity"];
                }

                return entity;
            }
            set
            {
                ViewState["CurrentEntity"] = value;
            }
        }

        private OTIssueUploadInfoEntity CurrentOTIssueUploadInfoEntity
        {
            get
            {
                if (_IssueUploadInfoID > 0)
                {
                    if (_OTIssueUploadInfoEntity.IssueUploadInfoID != _IssueUploadInfoID)
                    {
                        _OTIssueUploadInfoEntity = FCCOTIssueUploadInfo.GetFacadeCreate().GetByID(_IssueUploadInfoID);
                    }
                }

                return _OTIssueUploadInfoEntity;
            }
            set
            {
                _OTIssueUploadInfoEntity = value;
            }
        }

        #endregion

        #region Methods

        private void BindList()
        {
            BindOTIssueUploadInfoList();
        }

        private void BindOTIssueUploadInfoList()
        {
            lvOTIssueUploadInfo.DataBind();
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
            }
        }

        #endregion

        #region List View Event

        protected void lvOTIssueUploadInfo_ItemCommand(object sender, ListViewCommandEventArgs e)
        {
            Int64 IssueUploadInfoID;

            Int64.TryParse(e.CommandArgument.ToString(), out IssueUploadInfoID);

            if (IssueUploadInfoID > 0)
            {
                if (string.Equals(e.CommandName, "DeleteItem"))
                {
                    try
                    {
                        Int64 result = -1;

                        String fe = SqlExpressionBuilder.PrepareFilterExpression(OTIssueUploadInfoEntity.FLD_NAME_IssueUploadInfoID, IssueUploadInfoID.ToString(), SQLMatchType.Equal);

                        OTIssueUploadInfoEntity oTIssueUploadInfoEntity = FCCOTIssueUploadInfo.GetFacadeCreate().GetByID(IssueUploadInfoID);


                        result = FCCOTIssueUploadInfo.GetFacadeCreate().Delete(oTIssueUploadInfoEntity, fe, DatabaseOperationType.Delete, TransactionRequired.No);

                        if (result == 0)
                        {
                            if (File.Exists(Server.MapPath(oTIssueUploadInfoEntity.Path)))
                            {
                                File.Delete(Server.MapPath(oTIssueUploadInfoEntity.Path));
                            }

                            _IssueUploadInfoID = 0;
                            _OTIssueUploadInfoEntity = new OTIssueUploadInfoEntity();                            

                            BindOTIssueUploadInfoList();

                            MiscUtil.ShowMessage(lblMessage, "File has been deleted successfully.", true);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to delete file.", true);
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

        protected void odsOTIssueUploadInfo_Selecting(object sender, ObjectDataSourceSelectingEventArgs e)
        {
            e.InputParameters["filterExpression"] = String.Empty;
        }

        #endregion

        #region Button Event

        protected void btnClick_Click(object sender, EventArgs e)
        {
            BindOTIssueUploadInfoList();
        }

        #endregion

        #region File Uploader Events

        protected void afuFiles_UploadedComplete(object sender, AsyncFileUploadEventArgs e)
        {
            OTIssueUploadInfoEntity ent = new OTIssueUploadInfoEntity();
            ent.IssueID = this.OverviewIssueID;
            ent.OriginalFileName = Path.GetFileName(e.FileName);
            ent.CurrentFileName = Guid.NewGuid().ToString() + Path.GetExtension(e.FileName);
            ent.FileType = "";
            ent.Extension = Path.GetExtension(e.FileName);
            ent.Path = FileUploadConstants.Issue.ADHOC_DOCUMENTS + ent.CurrentFileName;
            ent.Remarks = String.Empty;

            FCCOTIssueUploadInfo.GetFacadeCreate().Add(ent, DatabaseOperationType.Add, TransactionRequired.No);

            // file upload

            afuFiles.SaveAs(Server.MapPath(ent.Path));

            //LoadFileListGried
            BindOTIssueUploadInfoList();
        }

        protected void afuFiles_UploadedFileError(object sender, AsyncFileUploadEventArgs e)
        {
            //ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "error", "top.$get(\"" + uploadResult.ClientID + "\").innerHTML = 'Error: " + e.StatusMessage + "';", true);
        }

        #endregion

        #endregion Event
    }
}
