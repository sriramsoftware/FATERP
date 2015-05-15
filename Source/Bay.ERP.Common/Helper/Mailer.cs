using System;
using System.Diagnostics;
using System.Net.Mail;
using System.Web;
using System.IO;
using System.Configuration;
using Bay.ERP.Common.BusinessEntities;
using System.Collections.Generic;
using Bay.ERP.Common.Shared;

namespace Bay.ERP.Common.Helper
{
	public static class Mailer
    {
        //private static readonly string AdminEmail = ConfigurationManager.AppSettings["adminEmail"];

        //#region Constants Template Variables

        //private const string VAR_FIRST_NAME = "[firstName]";
        //private const string VAR_LAST_NAME = "[lastName]";
        
        //private const string VAR_CITY = "[city]";
        //private const string VAR_STATE = "[state]";
        //private const string VAR_ZIP = "[zip]";
        //private const string VAR_COUNTRY = "[country]";
        //private const string VAR_PHONE = "[phone]";

        //private const string VAR_CARD_TYPE = "[cardType]";
        //private const string VAR_CARD_NUMBER = "[cardNumber]";
        //private const string VAR_EXP_DATE = "[expDate]";

        //private const string VAR_DATE = "[date]";
        //private const string VAR_EMAIL = "[email]";
        //private const string VAR_EMAIL2 = "[email2]";

        //private const string VAR_VISITOR_NAME = "[name]";
        //private const string VAR_SUBJECT = "[subject]";

        //private const string VAR_COMPANY_NAME = "[companyName]";
        //private const string VAR_LEAD_SOURCE = "[leadSource]";
        //private const string VAR_CAMPAIGN_NAME = "[campaignName]";

        //private const string VAR_STATUS = "[status]";
        //private const string VAR_PREVIOUS_STATUS = "[previousStatus]";
        //private const string VAR_NEW_STATUS = "[newStatus]";

        //private const string VAR_CANDIDATE_NAME = "[candidateName]";
        //private const string VAR_JOB_TITLE = "[jobTitle]";
        //private const string VAR_JOB_LOCATION = "[jobLocation]";
        //private const string VAR_JOB_EXPERIENCE = "[jobExperience]";
        //private const string VAR_WORK_AUTHORIZATION = "[workAuthorization]";
        //private const string VAR_SKILL_SET_DESCRIPTION = "[skillSetDescription]";
        //private const string VAR_JOB_DESCRIPTION = "[jobDescription]";

        //private const string VAR_CANDIDATEOVERVIEW_PERSONALINFO = "[personalInformation]";
        //private const string VAR_CANDIDATEOVERVIEW_REMARKS = "[remarks]";
        //private const string VAR_CANDIDATEOVERVIEW_ASSIGNEDMANAGERS = "[assignedManagers]";
        //private const string VAR_CANDIDATEOVERVIEW_JOBCARTANDSTATUS = "[jobCartAndStatus]";
        //private const string VAR_CANDIDATEOVERVIEW_ASSIGNEDASSESTEST = "[assignedAssesmentTests]";
        //private const string VAR_CANDIDATEOVERVIEW_INTERVIEWSCHEDULE= "[interviewSchedule]";
        //private const string VAR_CANDIDATEOVERVIEW_RESUMEDOCUMENTS = "[resumesAndDocuments]";
        //private const string VAR_CANDIDATEOVERVIEW_OBJECTIVE = "[objective]";
        //private const string VAR_CANDIDATEOVERVIEW_SUMMARY = "[summary]";
        //private const string VAR_CANDIDATEOVERVIEW_JOBTITLE = "[jobTitle]";
        //private const string VAR_CANDIDATEOVERVIEW_SKILLSET = "[skillSet]";
        //private const string VAR_CANDIDATEOVERVIEW_EXPERIENCE = "[experience]";
        //private const string VAR_CANDIDATEOVERVIEW_EDUCATION = "[education]";
        //private const string VAR_CANDIDATEOVERVIEW_COPPYPASTERESUME = "[copyPastedResume]";

        //private const string VAR_PASSPORTEXPIRED_DATE = "[PassportExpiredDate]";
        //private const string VAR_MEMBER_NAME = "[MemberName]";
        //private const string VAR_USER_NAME = "[username]";
        //private const string VAR_SITE_NAME = "[SiteName]";
        //private const string VAR_LOGIN_URL = "[LoninUrl]";

      

        //#endregion

        //#region Methods

        //public static void SendLeadCreatedMassage(Lead lead, Company company, string leadSource, List<string> emails)
        //{
        //    try
        //    {
        //        const string KEY = "leadCreated";

        //        MailMap mailMap = Settings.Instance.GetMailMap(KEY);

        //        MailMessage message = new MailMessage();

        //        message.IsBodyHtml = true;

        //        message.From = new MailAddress(mailMap.From);

        //        foreach (string to in emails)
        //        {
        //            message.To.Add(new MailAddress(to));
        //        }

        //        message.Subject = mailMap.Subject;

        //        string body = mailMap.Body;

        //        body = body.Replace(VAR_DATE, StringHelper.Convert("MM/dd/yyyy", DateTime.Now));
        //        body = body.Replace(VAR_COMPANY_NAME, company.CompanyName);
        //        body = body.Replace(VAR_LEAD_SOURCE, leadSource);
        //        body = body.Replace(VAR_STATUS, EnumHelper.GetDescription((SalesStatus)lead.Status));

        //        message.Body = body;

        //        var mailClient = new SmtpClient();
        //        mailClient.Send(message);
        //    }
        //    catch
        //    { }
        //}

        //public static void SendLeadStatusChangedMassage(Lead lead, Company company, string leadSource, SalesStatus newSalesStatus, SalesStatus oldSalesStatus, List<string> emails)
        //{
        //    try
        //    {
        //        const string KEY = "leadStatusChanged";

        //        MailMap mailMap = Settings.Instance.GetMailMap(KEY);

        //        MailMessage message = new MailMessage();

        //        message.IsBodyHtml = true;

        //        message.From = new MailAddress(mailMap.From);

        //        foreach (string to in emails)
        //        {
        //            message.To.Add(new MailAddress(to));
        //        }

        //        message.Subject = mailMap.Subject;

        //        string body = mailMap.Body;

        //        body = body.Replace(VAR_DATE, StringHelper.Convert("MM/dd/yyyy", DateTime.Now));
        //        body = body.Replace(VAR_COMPANY_NAME, company.CompanyName);
        //        body = body.Replace(VAR_LEAD_SOURCE, leadSource);
        //        body = body.Replace(VAR_PREVIOUS_STATUS, EnumHelper.GetDescription(oldSalesStatus));
        //        body = body.Replace(VAR_NEW_STATUS, EnumHelper.GetDescription(newSalesStatus));

        //        message.Body = body;

        //        var mailClient = new SmtpClient();
        //        mailClient.Send(message);
        //    }
        //    catch
        //    { }
        //}

        //public static void SendCompanyStatusChangedRequestMassage(Company company, CompanyStatus newStatus, CompanyStatus oldStatus, List<string> emails)
        //{
        //    try
        //    {
        //        const string KEY = "companyStatusChangeReq";

        //        MailMap mailMap = Settings.Instance.GetMailMap(KEY);

        //        MailMessage message = new MailMessage();

        //        message.IsBodyHtml = true;

        //        message.From = new MailAddress(mailMap.From);

        //        foreach (string to in emails)
        //        {
        //            message.To.Add(new MailAddress(to));
        //        }

        //        message.Subject = mailMap.Subject;

        //        string body = mailMap.Body;

        //        body = body.Replace(VAR_DATE, StringHelper.Convert("MM/dd/yyyy", DateTime.Now));
        //        body = body.Replace(VAR_COMPANY_NAME, company.CompanyName);
        //        body = body.Replace(VAR_STATUS, EnumHelper.GetDescription(oldStatus));
        //        body = body.Replace(VAR_NEW_STATUS, EnumHelper.GetDescription(newStatus));

        //        message.Body = body;

        //        var mailClient = new SmtpClient();
        //        mailClient.Send(message);
        //    }
        //    catch
        //    { }
        //}

        //public static void SendCompanyAddedToCampaignMassage(Campaign campaign, List<Company> companyList, List<string> emails)
        //{
        //    try
        //    {
        //        const string KEY = "companyAddedToCampaign";

        //        MailMap mailMap = Settings.Instance.GetMailMap(KEY);

        //        MailMessage message = new MailMessage();

        //        message.IsBodyHtml = true;

        //        message.From = new MailAddress(mailMap.From);

        //        foreach (string to in emails)
        //        {
        //            message.To.Add(new MailAddress(to));
        //        }

        //        message.Subject = mailMap.Subject;

        //        string body = mailMap.Body;

        //        body = body.Replace(VAR_DATE, StringHelper.Convert("MM/dd/yyyy", DateTime.Now));
        //        body = body.Replace(VAR_CAMPAIGN_NAME, campaign.Name);

        //        string companyNames = string.Empty;

        //        if (companyList != null && companyList.Count > 0)
        //        {
        //            foreach (Company company in companyList)
        //            {
        //                companyNames += company.CompanyName + ",";
        //            }

        //            if (companyNames.Length > 0)
        //            {
        //                companyNames.Remove(companyNames.Length - 1, 1);
        //            }
        //        }
        //        body = body.Replace(VAR_COMPANY_NAME, companyNames);

        //        message.Body = body;

        //        var mailClient = new SmtpClient();
        //        mailClient.Send(message);
        //    }
        //    catch
        //    { }
        //}

        //public static void SendLeadCreatedInsideCampaignMassage(Lead lead, Company company, Campaign campaign, List<string> emails)
        //{
        //    try
        //    {
        //        const string KEY = "leadCreatedInsideCampaign";

        //        MailMap mailMap = Settings.Instance.GetMailMap(KEY);

        //        MailMessage message = new MailMessage();

        //        message.IsBodyHtml = true;

        //        message.From = new MailAddress(mailMap.From);

        //        foreach (string to in emails)
        //        {
        //            message.To.Add(new MailAddress(to));
        //        }

        //        message.Subject = mailMap.Subject;

        //        string body = mailMap.Body;

        //        body = body.Replace(VAR_DATE, StringHelper.Convert("MM/dd/yyyy", DateTime.Now));
        //        body = body.Replace(VAR_CAMPAIGN_NAME, campaign.Name);
        //        body = body.Replace(VAR_STATUS, EnumHelper.GetDescription((SalesStatus)lead.Status));
        //        body = body.Replace(VAR_COMPANY_NAME, company.CompanyName);

        //        message.Body = body;

        //        var mailClient = new SmtpClient();
        //        mailClient.Send(message);
        //    }
        //    catch
        //    { }
        //}

        //public static void SendCompanyRegistrationMassage(Company company, CompanyStatus status, bool isSelfRegistration, List<string> emails)
        //{
        //    try
        //    {
        //        const string KEY = "companyRegistration";

        //        MailMap mailMap = Settings.Instance.GetMailMap(KEY);

        //        MailMessage message = new MailMessage();

        //        message.IsBodyHtml = true;

        //        message.From = new MailAddress(mailMap.From);

        //        foreach (string to in emails)
        //        {
        //            message.To.Add(new MailAddress(to));
        //        }

        //        message.Subject = mailMap.Subject;

        //        string body = mailMap.Body;

        //        body = body.Replace(VAR_DATE, StringHelper.Convert("MM/dd/yyyy", DateTime.Now));
        //        body = body.Replace(VAR_COMPANY_NAME, company.CompanyName);
        //        body = body.Replace(VAR_STATUS, EnumHelper.GetDescription(status));

        //        message.Body = body;

        //        var mailClient = new SmtpClient();
        //        mailClient.Send(message);
        //    }
        //    catch
        //    { }
        //}


        //public static void SendPassportDateExpiredAlertMail(string candidateName, string candidateEmail,DateTime PassportExpiredDate)
        //{
        //    try
        //    {
        //        const string KEY = "PassportDateExpireTemplate";

        //        MailMap mailMap = Settings.Instance.GetMailMap(KEY);

        //        MailMessage message = new MailMessage();

        //        message.IsBodyHtml = true;

        //        message.From = new MailAddress(mailMap.From);

        //        message.To.Add(new MailAddress(candidateEmail));

        //        message.Subject = mailMap.Subject;

        //        string body = mailMap.Body;

        //         body = body.Replace("\r\n","");
        //        body = body.Replace(VAR_MEMBER_NAME, candidateName);
        //        body = body.Replace(VAR_PASSPORTEXPIRED_DATE, StringHelper.Convert("MM/dd/yyyy", PassportExpiredDate));
                
        //        message.Body = body;

        //        SmtpClient mailSender = new SmtpClient(ConfigurationManager.AppSettings["SmtpServer"]);
        //        mailSender.Send(message);
        //    }
        //    catch
        //    { }
        //}



        //public static bool SendMailToNewlyAddedCandidate(string candidateName, string candidateEmail)
        //{
        //    try
        //    {
        //        const string KEY = "CandidateProfileUpdateTemplate";

        //        MailMap mailMap = Settings.Instance.GetMailMap(KEY);

        //        MailMessage message = new MailMessage();

        //        message.IsBodyHtml = true;

        //        message.From = new MailAddress(mailMap.From);

        //        message.To.Add(new MailAddress(candidateEmail));

        //        message.Subject = mailMap.Subject;

        //        string body = mailMap.Body;
        //        string webRoot = ConfigurationManager.AppSettings["webRoot"].ToString();
                
        //        body = body.Replace("\r\n", "");
        //        body = body.Replace(VAR_MEMBER_NAME, candidateName);
        //        body = body.Replace(VAR_SITE_NAME,webRoot);
        //        body = body.Replace(VAR_USER_NAME, candidateEmail);
        //        body = body.Replace(VAR_LOGIN_URL, webRoot+"Login.aspx");
        //        message.Body = body;

        //        SmtpClient mailSender = new SmtpClient(ConfigurationManager.AppSettings["SmtpServer"]);
        //        mailSender.Send(message);
        //        return true;
        //    }
        //    catch
        //    {
        //        return false;
        //    }
        //}


        //public static void SendJobPostingMail(string candidateName,string candidateEmail, List<string> jobTitle, List<string> jobLocation, List<string> jobExperience, List<string> workAuthorization, List<string> skillSet, List<string> jobDescription)
        //{ 
        //try
        //    {
        //        const string KEY = "jobPostingMail";

        //        MailMap mailMap = Settings.Instance.GetMailMap(KEY);

        //        MailMessage message = new MailMessage();

        //        message.IsBodyHtml = true;

        //        message.From = new MailAddress(mailMap.From);

        //        //foreach (string to in emails)
        //        //{
        //        message.To.Add(new MailAddress(candidateEmail));
        //        //}
        //        //message.To.Add("tamal@tps360.com");

        //        message.Subject = mailMap.Subject;

        //        string body = mailMap.Body;
        //        body = body.Replace("\r\n","");
        //        body = body.Replace(VAR_CANDIDATE_NAME, candidateName);
        //        int startIndex = body.IndexOf("<div id='row'");
        //        int lastIndex = body.IndexOf("</div>");
        //        string jobBody = body.Substring(startIndex, (lastIndex+6) - startIndex);
                
        //        string subBody = string.Empty;                

        //        for(int i=0;i<jobTitle.Count;i++)
        //        {
        //            string tempJobBody = jobBody;

        //            tempJobBody = tempJobBody.Replace(VAR_JOB_TITLE, jobTitle[i]);
        //            tempJobBody = tempJobBody.Replace(VAR_JOB_LOCATION, jobLocation[i]);
        //            tempJobBody = tempJobBody.Replace(VAR_JOB_EXPERIENCE, jobExperience[i]);
        //            tempJobBody = tempJobBody.Replace(VAR_WORK_AUTHORIZATION, workAuthorization[i]);
        //            tempJobBody = tempJobBody.Replace(VAR_SKILL_SET_DESCRIPTION, skillSet[i]);
        //            tempJobBody = tempJobBody.Replace(VAR_JOB_DESCRIPTION, jobDescription[i]);

        //            if (subBody == string.Empty)
        //            {
        //                subBody = tempJobBody;
        //            }
        //            else 
        //            {
        //                subBody =subBody+ "<br />" + tempJobBody;
        //            }

        //        }

        //        body = body.Remove(startIndex, lastIndex - startIndex);
        //        body = body.Insert(startIndex, subBody);    
        //        message.Body = body;

        //        //var mailClient = new SmtpClient("mail.tps360.com");                

        //        SmtpClient mailClient = new SmtpClient(ConfigurationManager.AppSettings["SmtpServer"]);
        //        mailClient.Send(message);
                
        //    }
        //    catch
        //    { }
        //}

        //public static string SendCandidateOverView(string candidateName, string personalInfo, string remarks, string assignedManagers, string jobcartAndStatus, string assignedAssessTest, string interviewSchedule, string resumesDocuments, string objective, string summary, string jobTitle, string skillSet, string experience, string education,string copyPastedResume)
        //{
        //    MailMessage message = new MailMessage();
            
        //    try
        //    {
        //        const string KEY = "candidateOverview";

        //        MailMap mailMap = Settings.Instance.GetMailMap(KEY);                

        //        message.IsBodyHtml = true;

        //        message.From = new MailAddress(mailMap.From);
                
        //        //message.To.Add(new MailAddress(candidateEmail));                

        //        message.Subject = mailMap.Subject;

        //        string body = mailMap.Body;                
        //        body = body.Replace(VAR_CANDIDATE_NAME, candidateName);
                
        //        body = body.Replace(VAR_CANDIDATEOVERVIEW_PERSONALINFO, personalInfo);
        //        body = body.Replace(VAR_CANDIDATEOVERVIEW_REMARKS, remarks);
        //        body = body.Replace(VAR_CANDIDATEOVERVIEW_ASSIGNEDMANAGERS, assignedManagers);
        //        body = body.Replace(VAR_CANDIDATEOVERVIEW_JOBCARTANDSTATUS, jobcartAndStatus);
        //        body = body.Replace(VAR_CANDIDATEOVERVIEW_ASSIGNEDASSESTEST, assignedAssessTest);
        //        body = body.Replace(VAR_CANDIDATEOVERVIEW_INTERVIEWSCHEDULE, interviewSchedule);
        //        body = body.Replace(VAR_CANDIDATEOVERVIEW_RESUMEDOCUMENTS, resumesDocuments);
        //        body = body.Replace(VAR_CANDIDATEOVERVIEW_OBJECTIVE, objective);
        //        body = body.Replace(VAR_CANDIDATEOVERVIEW_SUMMARY, summary);
        //        body = body.Replace(VAR_CANDIDATEOVERVIEW_JOBTITLE, jobTitle);
        //        body = body.Replace(VAR_CANDIDATEOVERVIEW_SKILLSET, skillSet);
        //        body = body.Replace(VAR_CANDIDATEOVERVIEW_EXPERIENCE, experience);
        //        body = body.Replace(VAR_CANDIDATEOVERVIEW_EDUCATION, education);
        //        body = body.Replace(VAR_CANDIDATEOVERVIEW_COPPYPASTERESUME, copyPastedResume);
        //        body = body.Replace("\r\n", "");                
                
        //        message.Body = body;
        //    }
        //    catch(Exception ex)
        //    {
        //        message.Body = ex.ToString();
        //    }

        //    return message.Body;
        //}

        //public static void SendExternalLeadMail(Lead lead, Company company, CompanyContact companyContact, string companyState, string companyCountry, List<string> products, List<string> emails)
        //{
        //    try
        //    {
        //        const string KEY = "externalLeadCreated";

        //        MailMap mailMap = Settings.Instance.GetMailMap(KEY);

        //        MailMessage message = new MailMessage();

        //        message.IsBodyHtml = true;

        //        //if (companyContact.Email != "")
        //        //{
        //        //    mailMap.From = companyContact.Email;
        //        //}

        //        message.From = new MailAddress(mailMap.From);
                
        //        foreach (string to in emails)
        //        {
        //            message.To.Add(new MailAddress(to));
        //        }

        //        string productNames = string.Empty;

        //        foreach (string product in products)
        //        {
        //            productNames += product + ", ";
        //        }

        //        if (productNames != "" && productNames.Length > 2)
        //        {
        //            productNames = productNames.Substring(0, (productNames.Length - 2));
        //        }

        //        message.Subject = mailMap.Subject;

        //        string body = mailMap.Body;
                
        //        body = body.Replace("||EMAIL||", companyContact.Email);
        //        body = body.Replace("||FIRSTNAME||", companyContact.FirstName);
        //        body = body.Replace("||LASTNAME||", companyContact.LastName);
        //        body = body.Replace("||TITLE||", companyContact.Title);
        //        body = body.Replace("||PHONE||", companyContact.DirectNumber);
        //        body = body.Replace("||EXT||", companyContact.DirectNumberExtension);

        //        body = body.Replace("||COMPANYNAME||", company.CompanyName);
        //        body = body.Replace("||ADDRESS1||", company.Address1);
        //        body = body.Replace("||ADDRESS2||", company.Address2);
        //        body = body.Replace("||CITY||", company.City);
        //        body = body.Replace("||COUNTRY||", companyCountry);
        //        body = body.Replace("||STATE||", companyState);
        //        body = body.Replace("||ZIPCODE||", company.Zip);


        //        body = body.Replace("||PRODUCTINFO||", productNames);
        //        body = body.Replace("||COMMENTS||", lead.Description);

        //        message.Body = body;

        //        //var mailClient = new SmtpClient();
        //        SmtpClient mailClient = new SmtpClient(ConfigurationManager.AppSettings["SmtpServer"]);
        //        mailClient.Send(message);
        //    }
        //    catch
        //    { }
        //}

        //#endregion
	}
}