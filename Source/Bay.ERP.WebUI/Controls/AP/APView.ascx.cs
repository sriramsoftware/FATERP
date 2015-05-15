// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 03-Oct-2012, 03:53:48




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
using System.Web.UI.HtmlControls;

namespace Bay.ERP.Web.UI
{
    public partial class APViewControl : BaseControl
    {       
        #region Properties

        public Int64 APApprovalProcessID
        {
            get
            {
                Int64 aPApprovalProcessID = 0;

                if (!StringHelper.IsBlank(Helper.Url.SecureUrl[APApprovalProcessEntity.FLD_NAME_APApprovalProcessID]))
                {
                    Int64.TryParse(Helper.Url.SecureUrl[APApprovalProcessEntity.FLD_NAME_APApprovalProcessID], out aPApprovalProcessID);
                }

                return aPApprovalProcessID;
            }
        }

        #endregion

        #region Methods

        private void PrepareInitialView()
        {
            IList<APMemberFeedback_DetailedEntity> lst = APRobot.GetAllMemberFeedbacks_Detailed(APApprovalProcessID);

            HtmlGenericControl clear = new HtmlGenericControl("div");
            clear.Attributes.Add("style", "clear: both;");

            for(Int32 i = 0; i < lst.Count; i++)
            {
                APMemberFeedback_DetailedEntity ent = lst[i];

                HtmlGenericControl step = new HtmlGenericControl("div");
                step.Attributes.Add("class", GetBorderColorCSS(ent.APFeedbackID));


                HtmlGenericControl cnt1 = new HtmlGenericControl("div");
                cnt1.Attributes.Add("class", "cnt");


                HtmlGenericControl table = new HtmlGenericControl("table");
                table.Attributes.Add("width", "100%");
                HtmlGenericControl tr = new HtmlGenericControl("tr");
                HtmlGenericControl td1 = new HtmlGenericControl("td");
                HtmlGenericControl td2 = new HtmlGenericControl("td");
                td2.Attributes.Add("align", "center");
                td2.Attributes.Add("style", "font-size: 18px; font-weight: bold");


                HtmlGenericControl lbl2 = new HtmlGenericControl("div");
                lbl2.Attributes.Add("class", "lbl");
                HtmlGenericControl cnt2 = new HtmlGenericControl("div");
                cnt2.Attributes.Add("class", "cnt");

                HtmlGenericControl lbl3 = new HtmlGenericControl("div");
                lbl3.Attributes.Add("class", "lbl");
                HtmlGenericControl cnt3 = new HtmlGenericControl("div");
                cnt3.Attributes.Add("class", "cnt");

                HtmlGenericControl lbl4 = new HtmlGenericControl("div");
                lbl4.Attributes.Add("class", "lbl");
                HtmlGenericControl cnt4 = new HtmlGenericControl("div");
                cnt4.Attributes.Add("class", "cnt");

                HtmlGenericControl lbl5 = new HtmlGenericControl("div");
                lbl5.Attributes.Add("class", "lbl");
                HtmlGenericControl cnt5 = new HtmlGenericControl("div");
                cnt5.Attributes.Add("class", "cnt");

                HtmlGenericControl lbl6 = new HtmlGenericControl("div");
                lbl6.Attributes.Add("class", "lbl");
                HtmlGenericControl cnt6 = new HtmlGenericControl("div");
                cnt6.Attributes.Add("class", "cnt");

                HtmlGenericControl lbl7 = new HtmlGenericControl("div");
                lbl7.Attributes.Add("class", "lbl");
                HtmlGenericControl cnt7 = new HtmlGenericControl("div");
                cnt7.Attributes.Add("class", "cnt");

                HtmlGenericControl lbl8 = new HtmlGenericControl("div");
                lbl8.Attributes.Add("class", "lbl");
                HtmlGenericControl cnt8 = new HtmlGenericControl("div");
                cnt8.Attributes.Add("class", "cnt");


                Image img1 = new Image();
                img1.ID = "imgAssignedTo" + i.ToString();
                img1.BorderColor = System.Drawing.Color.Gray; 
                img1.BorderWidth = Unit.Pixel(1);
                img1.BorderStyle = BorderStyle.Solid;
                img1.ImageAlign = ImageAlign.AbsMiddle;
                img1.Height = 85;
                img1.Width = 73;
                img1.CssClass = "imgRound";
                String fe_memberImage = SqlExpressionBuilder.PrepareFilterExpression(HREmployeePhotoEntity.FLD_NAME_EmployeeID, ent.EmployeeID.ToString(), SQLMatchType.Equal);
                IList<HREmployeePhotoEntity> lstEmployeePhoto = FCCHREmployeePhoto.GetFacadeCreate().GetIL(1, 1, String.Empty, fe_memberImage, DatabaseOperationType.LoadWithFilterExpression);

                if (lstEmployeePhoto != null && lstEmployeePhoto.Count > 0)
                {
                    img1.ImageUrl = lstEmployeePhoto[0].Path;
                }
                else
                {
                    img1.ImageUrl = "~/Images/approval_pic.JPG";
                }

                td1.Controls.Add(img1);
                Literal lit_lbl1 = new Literal();
                lit_lbl1.Text = "Step " + (i + 1).ToString();
                td2.Controls.Add(lit_lbl1);
                tr.Controls.Add(td1);
                tr.Controls.Add(td2);
                table.Controls.Add(tr);
                cnt1.Controls.Add(table);
                step.Controls.Add(cnt1);

                Literal lit_lbl2 = new Literal();
                lit_lbl2.Text = "Assigned To";
                lbl2.Controls.Add(lit_lbl2);
                step.Controls.Add(lbl2);
                Literal lit_cnt2 = new Literal();
                lit_cnt2.Text = ent.MemberFullName;
                cnt2.Controls.Add(lit_cnt2);
                step.Controls.Add(cnt2);

                Literal lit_lbl3 = new Literal();
                lit_lbl3.Text = "Approval Status";
                lbl3.Controls.Add(lit_lbl3);
                step.Controls.Add(lbl3);
                Literal lit_cnt3 = new Literal();
                lit_cnt3.Text = ent.APFeedbackName;
                cnt3.Controls.Add(lit_cnt3);
                step.Controls.Add(cnt3);

                Literal lit_lbl4 = new Literal();
                lit_lbl4.Text = "Assign Date";
                lbl4.Controls.Add(lit_lbl4);
                step.Controls.Add(lbl4);
                Literal lit_cnt4 = new Literal();
                lit_cnt4.Text = ent.FeedbackRequestDate != null ? MiscUtil.ConvertDateToStringDDMMYYYY(ent.FeedbackRequestDate.Value) : "NA";
                cnt4.Controls.Add(lit_cnt4);
                step.Controls.Add(cnt4);

                Literal lit_lbl5 = new Literal();
                lit_lbl5.Text = "Last Response";
                lbl5.Controls.Add(lit_lbl5);
                step.Controls.Add(lbl5);
                Literal lit_cnt5 = new Literal();
                lit_cnt5.Text = ent.FeedbackLastResponseDate != null ? MiscUtil.ConvertDateToStringDDMMYYYY(ent.FeedbackLastResponseDate.Value) : "NA";
                cnt5.Controls.Add(lit_cnt5);
                step.Controls.Add(cnt5);

                Literal lit_lbl6 = new Literal();
                lit_lbl6.Text = "Feedback Date";
                lbl6.Controls.Add(lit_lbl6);
                step.Controls.Add(lbl6);
                Literal lit_cnt6 = new Literal();
                lit_cnt6.Text = ent.FeedbackSubmitDate != null ? MiscUtil.ConvertDateToStringDDMMYYYY(ent.FeedbackSubmitDate.Value) : "NA";
                cnt6.Controls.Add(lit_cnt6);
                step.Controls.Add(cnt6);

                Literal lit_lbl7 = new Literal();
                lit_lbl7.Text = "Proxy Member";
                lbl7.Controls.Add(lit_lbl7);
                step.Controls.Add(lbl7);
                Literal lit_cnt7 = new Literal();
                lit_cnt7.Text = ent.ProxyMemberFullName.Trim() == String.Empty ? "Not Set" : ent.ProxyMemberFullName;
                cnt7.Controls.Add(lit_cnt7);
                step.Controls.Add(cnt7);

                Literal lit_lbl8 = new Literal();
                lit_lbl8.Text = "Enabled Proxy Member";
                lbl8.Controls.Add(lit_lbl8);
                step.Controls.Add(lbl8);
                Literal lit_cnt8 = new Literal();
                lit_cnt8.Text = ent.IsProxyEmployeeEnabled ? "Yes" : "No";
                cnt8.Controls.Add(lit_cnt8);
                step.Controls.Add(cnt8);


                div.Controls.Add(step);


                if ((i + 1) < lst.Count)
                {
                    HtmlGenericControl apStepSeperator = new HtmlGenericControl("div");
                    apStepSeperator.Attributes.Add("class", "apStepSeperator");
                    Image img2 = new Image();
                    img2.ID = "imgArrow" + i.ToString();
                    img2.BorderColor = System.Drawing.Color.Gray;
                    img2.BorderWidth = Unit.Pixel(0);
                    img2.BorderStyle = BorderStyle.Solid;
                    img2.ImageAlign = ImageAlign.AbsMiddle;
                    img2.ImageUrl = "~/Images/ap-arrow-right.png";
                    apStepSeperator.Controls.Add(img2);

                    div.Controls.Add(apStepSeperator);
                }
            }

            div.Controls.Add(clear);
        }

        private String GetBorderColorCSS(Int64 feedbackID)
        {
            String css = "apStep gray";

            if (feedbackID == MasterDataConstants.APFeedback.APPROVED)
            {
                css = "apStep green";
            }
            else if (feedbackID == MasterDataConstants.APFeedback.REJECTED || 
                feedbackID == MasterDataConstants.APFeedback.CANCELED)
            {
                css = "apStep red";
            }
            else if (feedbackID == MasterDataConstants.APFeedback.NOT_YET_REQUESTED)
            {
                css = "apStep gray";
            }
            else if (feedbackID == MasterDataConstants.APFeedback.FEEDBACK_REQUESTED ||
                feedbackID == MasterDataConstants.APFeedback.ON_HOLD_BY_APPROVAL_PANEL_MEMBER ||
                feedbackID == MasterDataConstants.APFeedback.WORKING_ON_FEEDBACK ||
                feedbackID == MasterDataConstants.APFeedback.FORWARDED ||
                feedbackID == MasterDataConstants.APFeedback.FORWARD_RESPONSE_RECEIVED)
            {
                css = "apStep yellow currentStep";
            }

            return css;
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

        #endregion Event
    }
}
