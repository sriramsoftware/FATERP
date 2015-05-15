using System;
using System.Collections;
using System.Configuration;
using System.Net.Mail;
using System.Net.Mime;
using System.Web.UI.WebControls;

namespace Bay.ERP.Common.Helper
{
    public class EmailManager
    {
        public EmailManager()
        {

        }

        public EmailTo To = new EmailTo();
        public EmailCc Cc = new EmailCc();
        public EmailBcc Bcc = new EmailBcc();
        public EmailAttachments Attachments = new EmailAttachments();
        public EmailLinkedResourses LinkedResources = new EmailLinkedResourses();

        private string mailFrom = String.Empty;
        private string mailSubject = String.Empty;
        private string mailBody = String.Empty;                        
        private string errorMessage = String.Empty;

        public String From
        {
            set { mailFrom = value; }
        }

        public String Subject
        {
            set { mailSubject = value; }
            get { return mailSubject; }
        }

        public String Body
        {
            get { return mailBody; }
            set { mailBody = value; }
        }
        
        public string Send()
        {
            if (mailFrom != String.Empty)
            {
                if (To != null)
                {
                    if (mailSubject != String.Empty)
                    {
                        if (mailBody != String.Empty)
                        {
                            MailMessage mailMessage = new MailMessage();

                            SmtpClient sendMail = new SmtpClient();

                            MailAddress addressFrom = new MailAddress(mailFrom);
                            mailMessage.From = addressFrom;
                            foreach (String strTo in To)
                            {
                                try
                                {
                                    mailMessage.To.Add(strTo);
                                }
                                catch
                                {
                                    errorMessage = errorMessage + "Invalid Email";
                                }
                            }
                            mailMessage.Subject = mailSubject;

                            //CC
                            if (Cc != null)
                            {
                                foreach (String strCc in Cc)
                                {
                                    try
                                    {
                                        mailMessage.CC.Add(strCc);
                                    }
                                    catch
                                    {
                                        continue;
                                    }
                                }
                            }
                            //Bcc
                            if (Bcc != null)
                            {
                                foreach (String strBcc in Bcc)
                                {
                                    try
                                    {
                                        mailMessage.Bcc.Add(strBcc);
                                    }
                                    catch
                                    {
                                        continue;
                                    }
                                }
                            }
                            
                            //Add Mail Attachments
                            if (Attachments != null)
                            {
                                foreach (String attachmentPath in Attachments)
                                {
                                    try
                                    {
                                        Attachment newAttachment = new Attachment(attachmentPath);
                                        mailMessage.Attachments.Add(newAttachment);
                                    }
                                    catch
                                    {
                                        continue;
                                    }
                                }
                            }

                            //Add Email Banner Image
                            if (LinkedResources != null)
                            {
                                AlternateView avMailMessage = AlternateView.CreateAlternateViewFromString(mailBody, null, MediaTypeNames.Text.Html);
                                foreach (ListItem maillinkedResource in LinkedResources)
                                {
                                    try
                                    {
                                        string resourcePath = maillinkedResource.Text;
                                        string contentID = maillinkedResource.Value;
                                        if (resourcePath != "" && contentID != "")
                                        {
                                            LinkedResource newLinkedResource = new LinkedResource(resourcePath);
                                            newLinkedResource.ContentId = contentID;
                                            newLinkedResource.ContentType.Name = resourcePath;
                                            avMailMessage.LinkedResources.Add(newLinkedResource);
                                        }
                                    }
                                    catch
                                    {
                                        continue;
                                    }
                                }
                                mailMessage.AlternateViews.Add(avMailMessage);
                            }
                            else
                            {
                                mailMessage.Body = mailBody;
                            }

                            mailMessage.IsBodyHtml = true;
                           
                            SmtpClient mailSender = new SmtpClient(ConfigurationManager.AppSettings["SmtpServer"]);
                           
                            try
                            {
                                mailSender.EnableSsl = true;
                                
                                if (mailMessage.To.Count > 0)
                                {
                                    mailSender.Send(mailMessage);
                                    return "1";
                                }
                                else if (mailMessage.Bcc.Count > 0)
                                {
                                    mailSender.Send(mailMessage);
                                    return "1";
                                }
                            }
                            catch (Exception ex)
                            {
                                errorMessage = errorMessage + "Error:" + ex.Message;
                            }
                            return errorMessage;
                        }
                        else
                        {
                            return "No Mail Body";
                        }
                    }
                    else
                    {
                        return "No Mail Subject";
                    }
                }
                else
                {
                    return "To Address is absent";
                }
            }
            else
            {
                return "From Address is absent";
            }
        }
    }

    public class EmailLinkedResourses : CollectionBase
    {
        public int Add(string contentID, string contentResourcePath)
        {
            if (contentID != String.Empty && contentResourcePath != String.Empty)
            {
                ListItem mailResource = new ListItem(contentResourcePath, contentID);
                return List.Add(mailResource);
            }
            else
            {
                return 0;
            }
        }
    }

    public class EmailAttachments : CollectionBase
    {
        public int Add(string AttachmentResourcePath)
        {
            if (AttachmentResourcePath.Trim() != String.Empty)
            {
                return List.Add(AttachmentResourcePath);
            }
            else
            {
                return 0;
            }
        }
    }

    public class EmailTo : CollectionBase
    {
        public int Add(string To)
        {
            if (To.Trim() != String.Empty)
            {
                return List.Add(To);
            }
            else
            {
                return 0;
            }
        }
    }

    public class EmailCc : CollectionBase
    {
        public int Add(string Cc)
        {
            if (Cc.Trim() != String.Empty)
            {
                return List.Add(Cc);
            }
            else
            {
                return 0;
            }
        }
    }

    public class EmailBcc : CollectionBase
    {
        public int Add(string Bcc)
        {
            if (Bcc.Trim() != String.Empty)
            {
                return List.Add(Bcc);
            }
            else
            {
                return 0;
            }
        }
    }
}