// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 03-Oct-2012, 05:32:03




using System;
using System.Web.UI.WebControls;
using System.Collections.Generic;

using Bay.ERP.Web.UI.Helper;
using Bay.ERP.Common.BusinessEntities;
using Bay.ERP.BusinessFacade;
using Bay.ERP.FacadeCreator.FacadeContext;
using Bay.ERP.Common.Helper;
using Bay.ERP.Common.Shared;
using Bay.ERP.Web.UI.Manager;
using System.Web.Script.Serialization;

namespace Bay.ERP.Web.UI
{
    public class NewSequenceJSON
    {
        public Int64  id { get; set; }
        public Int32 seq { get; set; }
 
    }

    public class NewSequenceListJSON
    {
        List<NewSequenceJSON> list = new List<NewSequenceJSON>();
    }

    public partial class APPanelMemberControl : BaseControl
    {       
        #region Properties

        public Int64 _APPanelMemberID
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

        public APPanelMemberEntity _APPanelMemberEntity
        {
            get
            {
                APPanelMemberEntity entity = new APPanelMemberEntity();

                if (ViewState["CurrentEntity"] != null)
                {
                    entity = (APPanelMemberEntity)ViewState["CurrentEntity"];
                }

                return entity;
            }
            set
            {
                ViewState["CurrentEntity"] = value;
            }
        }

        private APPanelMemberEntity CurrentAPPanelMemberEntity
        {
            get
            {
                if (_APPanelMemberID > 0)
                {
                    if (_APPanelMemberEntity.APPanelMemberID != _APPanelMemberID)
                    {
                        _APPanelMemberEntity = FCCAPPanelMember.GetFacadeCreate().GetByID(_APPanelMemberID);
                    }
                }

                return _APPanelMemberEntity;
            }
            set
            {
                _APPanelMemberEntity = value;
            }
        }

        #endregion

        #region Methods

        private void BuildDropDownList()
        {
            MiscUtil.PopulateAPPanel(ddlAPPanelID, false);
            MiscUtil.PopulateMDDepartment(ddlDepartmentID, false);
            MiscUtil.PopulateHREmployee(ddlEmployeeID, false);
            MiscUtil.PopulateHREmployee(ddlProxyEmployeeID, true);
        }

        private void PrepareValidator()
        {
        }

        private void PrepareInitialView()
        {
            BuildDropDownList();

            txtSequenceNo.Text = String.Empty;
            chkIsProxyEmployeeEnabled.Checked = false;

            btnSubmit.Text = "Add";
            btnAddNew.Visible = false;
        }

        private void PrepareEditView()
        {
            APPanelMemberEntity aPPanelMemberEntity = CurrentAPPanelMemberEntity;


            if (!aPPanelMemberEntity.IsNew)
            {
                if (ddlAPPanelID.Items.Count > 0 && aPPanelMemberEntity.APPanelID != null)
                {
                    ddlAPPanelID.SelectedValue = aPPanelMemberEntity.APPanelID.ToString();
                }

                if (ddlDepartmentID.Items.Count > 0 && aPPanelMemberEntity.DepartmentID != null)
                {
                    ddlDepartmentID.SelectedValue = aPPanelMemberEntity.DepartmentID.ToString();
                }

                if (ddlEmployeeID.Items.Count > 0 && aPPanelMemberEntity.EmployeeID != null)
                {
                    ddlEmployeeID.SelectedValue = aPPanelMemberEntity.EmployeeID.ToString();
                }

                txtSequenceNo.Text = aPPanelMemberEntity.SequenceNo.ToString();

                if (ddlProxyEmployeeID.Items.Count > 0 && aPPanelMemberEntity.ProxyEmployeeID != null)
                {
                    ddlProxyEmployeeID.SelectedValue = aPPanelMemberEntity.ProxyEmployeeID.ToString();
                }

                chkIsProxyEmployeeEnabled.Checked = aPPanelMemberEntity.IsProxyEmployeeEnabled;

                btnSubmit.Text = "Update";
                btnAddNew.Visible = true;
            }
        }

        private void BindList()
        {
            BindAPPanelMemberList();
        }

        private void BindAPPanelMemberList()
        {
            lvAPPanelMember.DataBind();
            lvAPPanelForwardMember.DataBind();
        }

        private APPanelMemberEntity BuildAPPanelMemberEntity()
        {
            APPanelMemberEntity aPPanelMemberEntity = CurrentAPPanelMemberEntity;

            if (ddlAPPanelID.Items.Count > 0)
            {
                if (ddlAPPanelID.SelectedValue == "0")
                {
                }
                else
                {
                    aPPanelMemberEntity.APPanelID = Int64.Parse(ddlAPPanelID.SelectedValue);
                }
            }

            if (ddlDepartmentID.Items.Count > 0)
            {
                if (ddlDepartmentID.SelectedValue == "0")
                {
                }
                else
                {
                    aPPanelMemberEntity.DepartmentID = Int64.Parse(ddlDepartmentID.SelectedValue);
                }
            }

            if (ddlEmployeeID.Items.Count > 0)
            {
                if (ddlEmployeeID.SelectedValue == "0")
                {
                }
                else
                {
                    aPPanelMemberEntity.EmployeeID = Int64.Parse(ddlEmployeeID.SelectedValue);
                }
            }

            if (!txtSequenceNo.Text.Trim().IsNullOrEmpty())
            {
                aPPanelMemberEntity.SequenceNo = Int32.Parse(txtSequenceNo.Text.Trim());
            }

            if (ddlProxyEmployeeID.Items.Count > 0)
            {
                if (ddlProxyEmployeeID.SelectedValue == "0")
                {
                    aPPanelMemberEntity.ProxyEmployeeID = null;
                }
                else
                {
                    aPPanelMemberEntity.ProxyEmployeeID = Int64.Parse(ddlProxyEmployeeID.SelectedValue);
                }
            }

            aPPanelMemberEntity.IsProxyEmployeeEnabled = chkIsProxyEmployeeEnabled.Checked;

            return aPPanelMemberEntity;
        }

        private void SaveAPPanelMemberEntity()
        {
            if (IsValid)
            {
                try
                {
                    APPanelMemberEntity aPPanelMemberEntity = BuildAPPanelMemberEntity();

                    Int64 result = -1;

                    if (aPPanelMemberEntity.IsNew)
                    {
                        result = FCCAPPanelMember.GetFacadeCreate().Add(aPPanelMemberEntity, DatabaseOperationType.Add, TransactionRequired.No);
                    }
                    else
                    {
                        String filterExpression = SqlExpressionBuilder.PrepareFilterExpression(APPanelMemberEntity.FLD_NAME_APPanelMemberID, aPPanelMemberEntity.APPanelMemberID.ToString(), SQLMatchType.Equal);
                        result = FCCAPPanelMember.GetFacadeCreate().Update(aPPanelMemberEntity, filterExpression, DatabaseOperationType.Update, TransactionRequired.No);
                    }

                    if (result > 0)
                    {
                        _APPanelMemberID = 0;
                        _APPanelMemberEntity = new APPanelMemberEntity();
                        PrepareInitialView();
                        BindAPPanelMemberList();

                        if (aPPanelMemberEntity.IsNew)
                        {
                            MiscUtil.ShowMessage(lblMessage, "Approval Process Panel Member Information has been added successfully.", false);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Approval Process Panel Member Information has been updated successfully.", false);
                        }
                    }
                    else
                    {
                        if (aPPanelMemberEntity.IsNew)
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to add Approval Process Panel Member Information.", false);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to update Approval Process Panel Member Information.", false);
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
            if (!IsPostBack)
            {
                PrepareValidator();
                PrepareInitialView();
                PrepareEditView();
            }
        }

        #endregion

        #region List View Event

        protected void lvAPPanelMember_ItemCommand(object sender, ListViewCommandEventArgs e)
        {
            Int64 APPanelMemberID;

            Int64.TryParse(e.CommandArgument.ToString(), out APPanelMemberID);

            if (APPanelMemberID > 0)
            {
                if (string.Equals(e.CommandName, "EditItem"))
                {
                    _APPanelMemberID = APPanelMemberID;

                    PrepareEditView();

                    cpeEditor.Collapsed = false;
                    cpeEditor.ClientState = "false";
                }
                else if (string.Equals(e.CommandName, "DeleteItem"))
                {
                    try
                    {
                        Int64 result = -1;

                        String fe = SqlExpressionBuilder.PrepareFilterExpression(APPanelMemberEntity.FLD_NAME_APPanelMemberID, APPanelMemberID.ToString(), SQLMatchType.Equal);

                        APPanelMemberEntity aPPanelMemberEntity = new APPanelMemberEntity();


                        result = FCCAPPanelMember.GetFacadeCreate().Delete(aPPanelMemberEntity, fe, DatabaseOperationType.Delete, TransactionRequired.No);

                        if (result == 0)
                        {
                            _APPanelMemberID = 0;
                            _APPanelMemberEntity = new APPanelMemberEntity();
                            PrepareInitialView();
                            BindAPPanelMemberList();

                            MiscUtil.ShowMessage(lblMessage, "Approval Process Panel Member has been successfully deleted.", true);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to delete Approval Process Panel Member.", true);
                        }
                    }
                    catch (Exception ex)
                    {
                        MiscUtil.ShowMessage(lblMessage, ex.Message, true);
                    }
                }
            }
        }




        protected void lvAPPanelMember_ItemDataBound(object sender, ListViewItemEventArgs e)
        {
            if (e.Item.ItemType == ListViewItemType.DataItem)
            {

                ListViewDataItem dataItem = (ListViewDataItem)e.Item;

                APPanelMember_CustomEntity ent = (APPanelMember_CustomEntity)dataItem.DataItem;

                Image Image2 = (Image)e.Item.FindControl("Image2");

                String fe_memberImage = SqlExpressionBuilder.PrepareFilterExpression(HREmployeePhotoEntity.FLD_NAME_EmployeeID, ent.EmployeeID.ToString(), SQLMatchType.Equal);
                IList<HREmployeePhotoEntity> lstEmployeePhoto = FCCHREmployeePhoto.GetFacadeCreate().GetIL(1, 1, String.Empty, fe_memberImage, DatabaseOperationType.LoadWithFilterExpression);

                if (lstEmployeePhoto != null && lstEmployeePhoto.Count > 0)
                {
                     Image2.ImageUrl= lstEmployeePhoto[0].Path;
                }
                else
                {
                    Image2.ImageUrl = "~/Images/approval_pic.JPG";
                }
            }
        }
        #endregion List View Event

        #region ObjectDataSource Event

        protected void odsAPPanelMember_Selecting(object sender, ObjectDataSourceSelectingEventArgs e)
        {
            Int64 aPPanelID = 0;
            Int64.TryParse(ddlAPPanelID.SelectedValue, out aPPanelID);

            String fe = SqlExpressionBuilder.PrepareFilterExpression("APPanelMember." + APPanelMember_CustomEntity.FLD_NAME_APPanelID, aPPanelID.ToString(), SQLMatchType.Equal);
            //String se = SqlExpressionBuilder.PrepareSortExpression("APPanelMember." + APPanelMember_CustomEntity.FLD_NAME_SequenceNo, SQLSortOrderType.Assending);
            String se = SqlExpressionBuilder.PrepareSortExpression(APPanelMember_CustomEntity.FLD_NAME_SequenceNo, SQLSortOrderType.Assending);

            e.InputParameters["sortExpression"] = se;
            e.InputParameters["filterExpression"] = fe;            
        }

        protected void odsAPPanelForwardMember_Selecting(object sender, ObjectDataSourceSelectingEventArgs e)
        {
            Int64 aPPanelID = 0;
            Int64.TryParse(ddlAPPanelID.SelectedValue, out aPPanelID);

            String fe = SqlExpressionBuilder.PrepareFilterExpression("APPanelForwardMember." + APPanelMember_CustomEntity.FLD_NAME_APPanelID, aPPanelID.ToString(), SQLMatchType.Equal);

            e.InputParameters["filterExpression"] = fe;
        }

        #endregion

        #region Button Event

        protected void btnSave_Click(object sender, EventArgs e)
        {
            SaveAPPanelMemberEntity();
        }

        protected void btnAddNew_Click(object sender, EventArgs e)
        {
            _APPanelMemberID = 0;
            _APPanelMemberEntity = new APPanelMemberEntity();
            PrepareInitialView();
        }

        protected void btnClear_Click(object sender, EventArgs e)
        {
            PrepareInitialView();
            PrepareEditView();
        }

        protected void btnSaveSequence_Click(object sender, EventArgs e)
        {
            List<APPanelMemberEntity> appm = new List<APPanelMemberEntity>();

            Int32 newSequence = 1;

            JavaScriptSerializer js = new JavaScriptSerializer();
            List<NewSequenceJSON> ns = js.Deserialize<List<NewSequenceJSON>>(hydNewSequence.Value);

            foreach (NewSequenceJSON nsj in ns)
            {
                APPanelMemberEntity ent = new APPanelMemberEntity();
                ent.APPanelMemberID = nsj.id;
                ent.SequenceNo = nsj.seq;

                appm.Add(ent);
                newSequence++;
            }

            APRobot.SavePanelMembersSequence(appm);

            BindList();

            MiscUtil.ShowMessage(lblMessage, "Approval Panel Member Sequence Savbed.", UIConstants.MessageType.GREEN);

        }
        

        #endregion

        #region ObjectDataSource Event

        protected void ddlAPPanelID_SelectedIndexChanged(object sender, EventArgs e)
        {
            BindList();
        }

        #endregion Event

        #endregion Event                
    }
}
