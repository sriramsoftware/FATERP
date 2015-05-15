// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 05-Oct-2012, 11:26:30




using System;
using System.Web.UI.WebControls;
using System.Collections.Generic;

using Bay.ERP.Web.UI.Helper;
using Bay.ERP.Common.BusinessEntities;
using Bay.ERP.BusinessFacade;
using Bay.ERP.FacadeCreator.FacadeContext;
using Bay.ERP.Common.Helper;
using Bay.ERP.Common.Shared;
using System.Net.Mail;
using System.Net;
using System.Threading;
using System.ComponentModel;

namespace Bay.ERP.Web.UI
{
    public partial class CMNSendMailControl : BaseControl
    {
        #region Method

        public void SendMail()
        {
            DateTime current_time = DateTime.Now;
            current_time = current_time.AddSeconds(10);
            Thread.Sleep(100);
            if (current_time != DateTime.Now)
            {
                MailMessage msg = new MailMessage();
                msg.From = new MailAddress("erp@baydevelopments.com");
                msg.To.Add("ismail.zabiulla@b2b-erp.com");
                msg.Body = "This is a auto generated mail from the ERP;\n You have a notification to approve a requisition.";
                msg.IsBodyHtml = true;
                msg.Subject = "Movie Data";
                SmtpClient smt = new SmtpClient("127.0.0.1");
                smt.Port = 25;
               // smt.Credentials = new NetworkCredential("erp@baydevelopments.com", "b@y.1212");
                smt.Send(msg);
            }

            //http://www.c-sharpcorner.com/uploadfile/17e8f6/sending-automatic-mails-in-Asp-Net/

            
            MiscUtil.ShowMessage(lblMessage, "Mail Sent.", false);
        }

        #endregion

        #region Event

        #region Page Event

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                
            }
        }

        #endregion

        public void bw_DoWork(object sender, DoWorkEventArgs e)
        {
            SendMail();
        }
        protected void Button1_Click(object sender, EventArgs e)
        {
            SendMail();
        }

        #endregion Event
    }
}