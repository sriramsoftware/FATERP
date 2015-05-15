// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 23-Mar-2013, 04:14:01




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
    public partial class CMNERPCommentControl : BaseControl
    {       
        #region Properties

        public Int64 PageProcessType { get; set; }
        public Int64 PageReferenceID { get; set; }


        public Int64 _CommentID
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

        public CMNERPCommentEntity _CMNERPCommentEntity
        {
            get
            {
                CMNERPCommentEntity entity = new CMNERPCommentEntity();

                if (ViewState["CurrentEntity"] != null)
                {
                    entity = (CMNERPCommentEntity)ViewState["CurrentEntity"];
                }

                return entity;
            }
            set
            {
                ViewState["CurrentEntity"] = value;
            }
        }

        private CMNERPCommentEntity CurrentCMNERPCommentEntity
        {
            get
            {
                if (_CommentID > 0)
                {
                    if (_CMNERPCommentEntity.CommentID != _CommentID)
                    {
                        _CMNERPCommentEntity = FCCCMNERPComment.GetFacadeCreate().GetByID(_CommentID);
                    }
                }

                return _CMNERPCommentEntity;
            }
            set
            {
                _CMNERPCommentEntity = value;
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

            txtComment.Text = String.Empty;

            btnSubmit.Text = "Post";
        }

        private void PrepareEditView()
        {
            CMNERPCommentEntity cMNERPCommentEntity = CurrentCMNERPCommentEntity;


            if (!cMNERPCommentEntity.IsNew)
            {

                btnSubmit.Text = "Update";
            }
        }

        private void BindList()
        {
            BindCMNERPCommentList();
        }

        private void BindCMNERPCommentList()
        {
            lvCMNERPComment.DataBind();
        }

        private CMNERPCommentEntity BuildCMNERPCommentEntity()
        {
            CMNERPCommentEntity cMNERPCommentEntity = CurrentCMNERPCommentEntity;

            cMNERPCommentEntity.ProcessCategoryID = PageProcessType;
            cMNERPCommentEntity.ReferenceID = PageReferenceID;

            cMNERPCommentEntity.Comment = txtComment.Text.Trim();
            cMNERPCommentEntity.CommentDate = System.DateTime.Now;
            Int64 employeeID = MiscUtil.GetCurrentEmployeeByMemberID(CurrentMember);

            if (employeeID > 0)
            {
                cMNERPCommentEntity.EmployeeID = employeeID;
            }

             cMNERPCommentEntity.IP = MiscUtil.GetLocalIP();

            return cMNERPCommentEntity;
        }

        private void SaveCMNERPCommentEntity()
        {
            if (IsValid)
            {
                try
                {
                    CMNERPCommentEntity cMNERPCommentEntity = BuildCMNERPCommentEntity();

                    Int64 result = -1;

                    if (cMNERPCommentEntity.IsNew)
                    {
                        result = FCCCMNERPComment.GetFacadeCreate().Add(cMNERPCommentEntity, DatabaseOperationType.Add, TransactionRequired.No);
                    }
                    else
                    {
                        String filterExpression = SqlExpressionBuilder.PrepareFilterExpression(CMNERPCommentEntity.FLD_NAME_CommentID, cMNERPCommentEntity.CommentID.ToString(), SQLMatchType.Equal);
                        result = FCCCMNERPComment.GetFacadeCreate().Update(cMNERPCommentEntity, filterExpression, DatabaseOperationType.Update, TransactionRequired.No);
                    }

                    if (result > 0)
                    {
                        _CommentID = 0;
                        _CMNERPCommentEntity = new CMNERPCommentEntity();
                        PrepareInitialView();
                        BindCMNERPCommentList();

                        if (cMNERPCommentEntity.IsNew)
                        {
                            MiscUtil.ShowMessage(lblMessage, "Comment Information has been added successfully.", false);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Comment Information has been updated successfully.", false);
                        }
                    }
                    else
                    {
                        if (cMNERPCommentEntity.IsNew)
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to add Comment Information.", false);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to update C MNERPComment Information.", false);
                        }
                    }
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
            BindList();

            if (!IsPostBack)
            {
                PrepareValidator();
                PrepareInitialView();
                PrepareEditView();
            }
        }

        #endregion

        #region List View Event

        protected void lvCMNERPComment_ItemCommand(object sender, ListViewCommandEventArgs e)
        {
            Int64 CommentID;

            Int64.TryParse(e.CommandArgument.ToString(), out CommentID);

            if (CommentID > 0)
            {
                if (string.Equals(e.CommandName, "EditItem"))
                {
                    _CommentID = CommentID;

                    PrepareEditView();
                }
                else if (string.Equals(e.CommandName, "DeleteItem"))
                {
                    try
                    {
                        Int64 result = -1;

                        String fe = SqlExpressionBuilder.PrepareFilterExpression(CMNERPCommentEntity.FLD_NAME_CommentID, CommentID.ToString(), SQLMatchType.Equal);

                        CMNERPCommentEntity cMNERPCommentEntity = new CMNERPCommentEntity();


                        result = FCCCMNERPComment.GetFacadeCreate().Delete(cMNERPCommentEntity, fe, DatabaseOperationType.Delete, TransactionRequired.No);

                        if (result == 0)
                        {
                            _CommentID = 0;
                            _CMNERPCommentEntity = new CMNERPCommentEntity();
                            PrepareInitialView();
                            BindCMNERPCommentList();

                            MiscUtil.ShowMessage(lblMessage, "C MNERPComment has been successfully deleted.", true);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to delete C MNERPComment.", true);
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

        protected void odsCMNERPComment_Selecting(object sender, ObjectDataSourceSelectingEventArgs e)
        {
            String fe = String.Empty;
            String fe1 = SqlExpressionBuilder.PrepareFilterExpression("CMNERPComment." + CMNERPCommentEntity.FLD_NAME_ProcessCategoryID, PageProcessType.ToString(), SQLMatchType.Equal);
            String fe2 = SqlExpressionBuilder.PrepareFilterExpression("CMNERPComment." + CMNERPCommentEntity.FLD_NAME_ReferenceID, PageReferenceID.ToString(), SQLMatchType.Equal);

            fe = SqlExpressionBuilder.PrepareFilterExpression(fe1, SQLJoinType.AND, fe2);

            e.InputParameters["filterExpression"] = fe;
        }

        #endregion

        #region Button Event

        protected void btnSave_Click(object sender, EventArgs e)
        {
            SaveCMNERPCommentEntity();
        }

        protected void btnAddNew_Click(object sender, EventArgs e)
        {
            _CommentID = 0;
            _CMNERPCommentEntity = new CMNERPCommentEntity();
            PrepareInitialView();
        }

        protected void btnClear_Click(object sender, EventArgs e)
        {
            PrepareInitialView();
            PrepareEditView();
        }

        #endregion

        #endregion Event
    }
}
