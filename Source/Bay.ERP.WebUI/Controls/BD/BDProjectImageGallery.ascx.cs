// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 22-Jun-2013, 02:07:00




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
    public partial class BDProjectImageGalleryControl : ProjectBaseControl
    {       
        #region Properties

        public Int64 _ProjectImageGalleryID
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

        public BDProjectImageGalleryEntity _BDProjectImageGalleryEntity
        {
            get
            {
                BDProjectImageGalleryEntity entity = new BDProjectImageGalleryEntity();

                if (ViewState["CurrentEntity"] != null)
                {
                    entity = (BDProjectImageGalleryEntity)ViewState["CurrentEntity"];
                }

                return entity;
            }
            set
            {
                ViewState["CurrentEntity"] = value;
            }
        }

        private BDProjectImageGalleryEntity CurrentBDProjectImageGalleryEntity
        {
            get
            {
                if (OverviewProjectID > 0)
                {
                    String fe = SqlExpressionBuilder.PrepareFilterExpression(BDProjectImageGalleryEntity.FLD_NAME_ProjectID, this.OverviewProjectID.ToString(), SQLMatchType.Equal);
                    IList<BDProjectImageGalleryEntity> BDProjectImageGalleryList = FCCBDProjectImageGallery.GetFacadeCreate().GetIL(null, null, String.Empty, fe, DatabaseOperationType.LoadWithFilterExpression);

                    if (BDProjectImageGalleryList != null && BDProjectImageGalleryList.Count > 0)
                    {
                        _BDProjectImageGalleryEntity = BDProjectImageGalleryList[0];
                    }
                    else
                    {
                        _BDProjectImageGalleryEntity = new BDProjectImageGalleryEntity();
                    }
                }

                return _BDProjectImageGalleryEntity;
            }
            set
            {
                _BDProjectImageGalleryEntity = value;
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

        private void BindList()
        {
            BindBDProjectImageGalleryList();
        }

        private void BindBDProjectImageGalleryList()
        {
            lvBDProjectImageGallery.DataBind();
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
            }
        }

        #endregion

        #region List View Event

        protected void lvBDProjectImageGallery_ItemCommand(object sender, ListViewCommandEventArgs e)
        {
            Int64 ProjectImageGalleryID;

            Int64.TryParse(e.CommandArgument.ToString(), out ProjectImageGalleryID);

            if (ProjectImageGalleryID > 0)
            {
                if (string.Equals(e.CommandName, "EditItem"))
                {
                    _ProjectImageGalleryID = ProjectImageGalleryID;
                }

                else if (string.Equals(e.CommandName, "DeleteItem"))
                {
                    try
                    {
                        Int64 result = -1;

                        String fe = SqlExpressionBuilder.PrepareFilterExpression(BDProjectImageGalleryEntity.FLD_NAME_ProjectImageGalleryID, ProjectImageGalleryID.ToString(), SQLMatchType.Equal);

                        BDProjectImageGalleryEntity bDProjectImageGalleryEntity = new BDProjectImageGalleryEntity();


                        result = FCCBDProjectImageGallery.GetFacadeCreate().Delete(bDProjectImageGalleryEntity, fe, DatabaseOperationType.Delete, TransactionRequired.No);

                        if (result == 0)
                        {
                            _ProjectImageGalleryID = 0;
                            _BDProjectImageGalleryEntity = new BDProjectImageGalleryEntity();
                            PrepareInitialView();
                            BindBDProjectImageGalleryList();

                            MiscUtil.ShowMessage(lblMessage, "Project Image Gallery has been successfully deleted.", true);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to delete Project Image Gallery.", true);
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

        protected void odsBDProjectImageGallery_Selecting(object sender, ObjectDataSourceSelectingEventArgs e)
        {
            String fe = SqlExpressionBuilder.PrepareFilterExpression(BDProjectImageGalleryEntity.FLD_NAME_ProjectID, OverviewProjectID.ToString(), SQLMatchType.Equal);
            e.InputParameters["filterExpression"] = fe;
        }

        #endregion

        #region Button Event

        protected void btnClick_Click(object sender, EventArgs e)
        {
            BindList();
        }

        #endregion

        #region File Uploader Events

        protected void afuFiles_UploadedComplete(object sender, AsyncFileUploadEventArgs e)
        {
            BDProjectImageGalleryEntity ent = new BDProjectImageGalleryEntity();
            ent.ProjectID = this.OverviewProjectID;
            ent.OriginalFileName = Path.GetFileName(e.FileName);
            ent.CurrentFileName = Guid.NewGuid().ToString() + Path.GetExtension(e.FileName);
            ent.FileType = "";
            ent.Extension = Path.GetExtension(e.FileName);
            ent.Path = FileUploadConstants.Bill.BILL_UPLOAD + ent.CurrentFileName;
            ent.Remarks = String.Empty;

            FCCBDProjectImageGallery.GetFacadeCreate().Add(ent, DatabaseOperationType.Add, TransactionRequired.No);

            // file upload

            afuFiles.SaveAs(Server.MapPath(ent.Path));

            //LoadFileListGried
            BindList();
        }

        protected void afuFiles_UploadedFileError(object sender, AsyncFileUploadEventArgs e)
        {
            //ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "error", "top.$get(\"" + uploadResult.ClientID + "\").innerHTML = 'Error: " + e.StatusMessage + "';", true);
        }

        #endregion

        #endregion Event
    }
}
