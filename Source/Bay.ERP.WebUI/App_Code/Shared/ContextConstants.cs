
namespace Bay.ERP.Web.UI
{
    public sealed class ContextConstants
    {
        public const string Facade = "facade";

        public const string ROLE_ADMIN = "Admin";
        public const string MEMBER = "Member";
        public const string ROLE_EMPLOYEE = "Employee";
        public const string ROLE_CONSULTANT = "Consultant";
        public const string ROLE_CANDIDATE = "Candidate";
        public const string ROLE_COMPANY = "Company";
        public const string ROLE_COMPANY_CONTACT = "CompanyContact";
        public const string ROLE_CLIENT = "Client";
        public const string ROLE_VENDOR = "Vendor";
        public const string ROLE_PARTNER = "Partner";
        public const string ROLE_VOULME_CANDIDATE = "VolumeCandidate";
        public const string ROLE_DEVELOPER = "Developer";
        public const string SITESETTING = "SiteSetting";

        public const string ASSESSMENT_CURRENT_TEST_ID = "CurrentTestId";

        public const string MEMBER_DOCUMENT_TYPE_PHOTO = "Photo";
        public const string MEMBER_DOCUMENT_TYPE_VIDEORESUME = "Video Resume";
        public const string MEMBER_DOCUMENT_TYPE_WORDRESUME = "Word Resume";
        public const string MEMBER_DOCUMENT_TYPE_OFFERLETTER = "Offer Letter";

        public const int MAXIMUM_UPLOAD_SIZE = 100;
        public const int MAXIMUM_EMAIL_ATTACHMENT_SIZE = 10;

        public const string MEMBER_SIGNATURE = "Signature";

        public const string TRAINING_COURSE_MATERIAL = "Training Course Material";

        public const string TASK_CATEGORY_NAME_ONBOARDING = "On-Boarding";
        public const string TASK_CATEGORY_DESCRIPTION_ONBOARDING = "Tasks related to On-Boarding process of applicant";

        public const string EPHTMLTOPDFKEY = "QfZkVwV2hDbNj2yMMHythCGQoGqOIrOm149JxbnAs8fZwJYWU3k1CSXMglcti3GB";

        public const int MEMBER_DEFAULT_AVAILABILITY = 315;
        public const int MEMBER_DOCUMENT_TYPE_OFFERLETTER_ID = 295;

        public const string GB_SCHEDULEDFORID = "ScheduledForID";

        public const string DEFAULT_PASSWORD = "password";

        public static readonly string[] DAYSINWEEK = new string[] { "Sunday", "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday" };
        
        private ContextConstants()
        {
        }
    }
}