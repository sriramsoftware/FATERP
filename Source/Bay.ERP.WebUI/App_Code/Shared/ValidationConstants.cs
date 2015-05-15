using System;

namespace Bay.ERP.Web.UI
{
    /// <summary>
    /// Summary description for ValidationConstants
    /// </summary>
    public static class ValidationConstants
    {        
        public static class RegularExpression
        {
            public const string Short_Date = @"(0[1-9]|[12][0-9]|3[01])[- /.](0[1-9]|1[012])[- /.](19|20)\d\d$";


            public const string Email = @"\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*";
            /// <summary>
            /// alphabetic letters only
            /// </summary>
            /// 

            public const string Web = @"^((ht|f)tp(s?)\:\/\/|~/|/)?([\w]+:\w+@)?([a-zA-Z]{1}([\w\-]+\.)+([\w]{2,5}))(:[\d]{1,5})?((/?\w+/)+|/?)(\w+\.[\w]{3,4})?((\?\w+=\w+)?(&\w+=\w+)*)?";
            /// <summary>
            /// alphabetic letters only
            /// </summary>
            /// 

            public const string Name = @"^[A-Z a-z \. \-]*$";
            /// <summary>
            /// use numbers,(),+ and -
            /// </summary>
            public const string Phone = @"^[+]?([0-9 ( ) \s \-]{6,19})([^-+ a-zA-Z/(/)])$";
            /// <summary>
            /// 2-4 digits
            /// </summary>
            public const string PhoneExtension = @"^[0-9]{2,4}$";
            /// <summary>
            /// 5-10 digits
            /// </summary>
            /// 
            public const string Mobile = @"^[+]?([0-9 ( ) \s \-]{6,19})([^-+ a-zA-Z/(/)])$";
            /// <summary>
            /// 
            /// </summary>



            public const string ZipCode = @"^[A-Z a-z 0-9]{1,1}([A-Z a-z 0-9 \-]{3,9})";
            /// <summary>
            /// 4-10 digits
            /// </summary>
            public const string Experience = "[0-9]{1,2}((.1[0-1])|(.[1-9]))?";//@"^[0-9'.]{1,3}$";

            /// <summary>
            /// use numbers,(),+ and -
            /// </summary>
            public const string FaxNo = @"^[+]?([0-9 ( ) \s \-]{6,19})([^-+ a-zA-Z/(/)])$";


            /// <summary>
            ///  numbers
            /// </summary>
            public const string EINNumber = @"([0-9]*)";


            /// <summary>
            ///  numbers
            /// </summary>
            public const string Photo = @"(.*\.[jJ][pP][gG])|(.*\.[jJ][pP][eE][gG])|(.*\.[gG][iI][fF])|(.*\.[pP][nN][gG])";



            /// <summary>
            ///  File
            /// </summary>
            public const string File = @"(.*\.[dD][oO][cC][xX])|(.*\.[dD][oO][cC])|(.*\.[rR][tT][fF])|(.*\.[tT][xX][tT])|(.*\.[zZ][iI][pP])|(.*\.[pP][dD][fF])";


            /// <summary>
            /// decimal numbers
            /// </summary>
            public const string Salary = @"([0-9]+\.[0-9]+|[0-9]+)";


            /// <summary>
            /// decimal numbers
            /// </summary>
            public const string GPA = @"^(\d+(\.\d{1,2}))|([0-9]{1,5})$";

            /// <summary>
            /// decimal numbers
            /// </summary>
            public const string Number = @"^[0-9]{1,2}";

        }

        public static class FieldLength
        {
            /// <summary>
            /// 50 characters
            /// </summary>
            public const int Standard = 50;
            /// <summary>
            /// 19 characters
            /// </summary>
            public const int Phone = 18;
            /// <summary>
            /// 4 characters
            /// </summary>
            public const int PhoneExtension = 4;
            /// <summary>
            /// 10 characters
            /// </summary>
            public const int ZipCode = 10;

            /// <summary>
            /// 5 characters
            /// </summary>
            public const int Experience = 5;

            /// <summary>
            /// decimal maximum value length
            /// </summary>
            public const int Salary = 10;

            /// <summary>
            /// 100 characters
            /// </summary>
            public const int Remark = 100;


            /// <summary>
            /// 50 characters
            /// </summary>
            public const int Email = 50;

            /// <summary>
            /// 50 characters
            /// </summary>
            public const int Name = 50;

            /// <summary>
            /// 200 characters
            /// </summary>
            public const int CompanyName = 200;

            /// <summary>
            /// 50 characters
            /// </summary>
            public const int Address = 50;

            /// <summary>
            /// 250 characters
            /// </summary>
            public const int CurrentJobTitle = 250;

            /// <summary>
            /// 5 characters
            /// </summary>
            //public const int Experience = 5;

            /// <summary>
            /// 50 characters
            /// </summary>
            public const int City = 50;

            /// <summary>
            /// 200 characters
            /// </summary>
            public const int Location = 200;


            /// <summary>
            /// 200 characters
            /// </summary>
            public const int EmployerCompanyName = 200;

            /// <summary>
            /// 500 characters
            /// </summary>
            public const int ResponsibilitiesProjectDetails = 500;

            /// <summary>
            /// 200 characters
            /// </summary>
            public const int DegreeExamTitle = 200;

            /// <summary>
            /// 200 characters
            /// </summary>
            public const int Major = 200;


            /// <summary>
            /// 4 characters
            /// </summary>
            public const int GPAPassingScore = 4;



            /// <summary>
            /// 200 characters
            /// </summary>
            public const int UniversityCollegeSchoolName = 200;

            /// <summary>
            /// 200 characters
            /// </summary>
            public const int AccomplishmentMembershipsAwardsOthers = 200;



            /// <summary>
            /// 200 characters
            /// </summary>
            public const int SupervisorTitle = 200;


            /// <summary>
            /// 200 characters
            /// </summary>
            public const int Subject = 200;


            /// <summary>
            /// 200 characters
            /// </summary>
            public const int Description = 200;

            /// <summary>
            /// 5 characters
            /// </summary>
            public const int WorkingHour = 5;


            /// <summary>
            /// 200 characters
            /// </summary>
            public const int Designation = 200;


            /// <summary>
            /// 200 characters
            /// </summary>
            public const int FatherName = 200;


            /// <summary>
            /// 200 characters
            /// </summary>
            public const int MotherName = 200;


            /// <summary>
            /// 5 characters
            /// </summary>
            public const int Physicalmeasurements = 5;



            /// <summary>
            /// 5 characters
            /// </summary>
            public const int BirthMark = 5;



            /// <summary>
            /// 5 characters
            /// </summary>
            public const int NoofChildren = 2;


            /// <summary>
            /// 50 characters
            /// </summary>
            public const int PassportProfession = 50;


            /// <summary>
            /// 50 characters
            /// </summary>
            public const int ContactRelationship = 50;


            
            /// <summary>
            /// 200 characters
            /// </summary>
            public const int VisaIssuedConsulateOffice = 50;


            /// <summary>
            /// 200 characters
            /// </summary>
            public const int ProductName = 200;


            
           
              /// <summary>
            /// 200 characters
            /// </summary>
            public const int CampaignName = 200;
            
                /// <summary>
            /// 200 characters
            /// </summary>
            public const int  DiscountPolicy = 200;

            /// <summary>
            /// 1 characters
            /// </summary>
            public const int GPA =4;
           

        }

        public static class ErrorMessage
        {
            /// <summary>
            /// Please enter only 4 to 10 numbers
            /// </summary>
            public const string ZipCode = "Please enter only 4 to 10 AlphaNumaric";

            /// <summary>
            /// Please enter Valid Web Address.
            /// </summary>
            public const string Web = "Please enter the valid web address.";



            /// <summary>
            /// Please enter Valid Fax No.
            /// </summary>
            public const string FaxNo = "Please enter valid fax no.";


            /// <summary>
            /// Please enter Valid Email Address.
            /// </summary>
            public const string Email = "Please enter valid email address.";


            /// <summary>
            /// Please enter Valid EINNumber.
            /// </summary>
            public const string EINNumber = "Please enter Number Only.";


            /// <summary>
            /// Please Select Photo.
            /// </summary>
            public const string Photo = "Please upload JPG,JPEG,GIF and PNG only.";

            /// <summary>
            /// Please Select File Type
            /// </summary>
            public const string File = "Please upload DOC,DOCX,RTF,TXT,ZIP and PDF only.";

            /// <summary>
            /// Alphabet
            /// </summary>
            public const string FirstName = "Please enter alphabetic words only";

            /// <summary>
            /// Alphabet
            /// </summary>
            public const string MidleName = "Please enter alphabetic words only";

            /// <summary>
            /// Alphabet
            /// </summary>
            public const string Name = "Please enter alphabetic words only";

            /// <summary>
            /// Alphabet
            /// </summary>
            public const string LastName = "Please enter alphabetic words only";



            /// <summary>
            /// Alphabet
            /// </summary>
            public const string FatherName = "Please enter alphabetic words only";


            /// <summary>
            /// Alphabet
            /// </summary>
            public const string MotherName = "Please enter alphabetic words only";

            /// <summary>
            /// Alphabet
            /// </summary>
            public const string NickName = "Please enter alphabetic words only";

            public const string Phone = "Please enter a valid  phone number";


            public const string HomePhone = "Please enter a valid home phone number";

            public const string PrimaryPhone = "Please enter a valid Primary phone number";


            public const string OfficePhone = "Please enter a valid Office phone number";


            /// <summary>
            /// Please enter extension number in 2-4 digits.
            /// </summary>
            public const string PhoneExtension = "Please enter extension number in 2-4 digits.";

            public const string TollFreeNumber = "Please enter a valid toll free number";

            public const string Mobile = "Please enter a valid mobile phone number";


            public const string Address1 = "Please enter address 1";

            public const string Address2 = "Please enter address 2";


            /// <summary>
            /// Alphabet
            /// </summary>
            public const string CurrentJobTitle = " Please Enter Current Job Title";

            /// <summary>
            /// YY:MM Years and month (numaric), sample 4.5
            /// </summary>
            public const string Experience = "Please enter valid duration - YY:MM";


            /// <summary>
            /// Alphabet
            /// </summary>
            public const string City = "Please enter City name";

            /// <summary>
            /// Alphabet
            /// </summary>
            public const string Location = "Please enter Location name";


            public const string Ethnicity = "Please select ethnicity";

            public const string Maritalstatus = "Please select marital status ";

            /// <summary>
            /// Numaric
            /// </summary>
            public const string Salary = "Pleas enter numaric value only";



            public const string SalaryPaymentType = "Please select salary payment type";

            public const string JobType = "Please select job type";

            /// <summary>
            /// Alphabet
            /// </summary>
            public const string EmplpoyerCompanyName = "Pleas enter company name";


            /// <summary>
            /// Numaric
            /// </summary>
            public const string GPAscore = "Pleas enter vaild GPA score";


            public const string StartDate = "Please enter start date";


            public const string EndDate = "Please enter End date";


            public const string SalaryType = "Please Select Salary Type";

            public const string PayCycle = "Please select Pay Cycle";

            public const string PayDay = "Please enter Pay Day";

            public const string PaymentType = "Please enter Payment Type";

            public const string PaymentBy = "Please enter Payment By";

            public const string OvertimeRate = "Pleas enter numaric value only";

            public const string JoiningDate = "Please enter joining date";

            public const string ProvisionPeriod = "Please enter provision period";


            public const string IssueDate = "Please enter issue date";

            public const string AppraisalDate = "Please enter  Appraisal Date";


            public const string AppraisalReminderDate = "Please enter  Appraisal Reminder Date";

            public const string ResignTerminationNoticePeriod = "Please select notice period";

            public const string WorkingHours = "Pleas enter numaric value only";

            public const string DailyWorkSchedule = "Please select daily work schedule";


            public const string WeeklyWorkSchedule = "Please select Weeky work schedule";

            public const string PassportNumber = "Please enter passport number.";



            public const string PassportIssueDate = "Please enter passport issue date.";


            public const string PassportExpirationDate = "Please enter passport expiration date. Expiration date must be greater than Issue date.";

            public const string PassportStatus = "Please select passport status";

            public const string DrivingLicenseNumber = "Please enter driving license number.";

            public const string DrivingLicenseIssueDate = "Please enter driving license issue date.";

            public const string  DrivingLicenseExpirationDate="Please enter driving license expiration date. Expiration date must be greater than Issue date.";

            public const string  VisaType="Please select visa type.";

            public const string Password = "Please enter new password.";

            public const string RetypePassword="Please confirm your password again.";

            public const string CampaignName = "Please enter campaign name";

            public const string ProductService="Please select product/service name.";

            
            public const string Price = "Pleas enter numaric value only";

            public const string ExpectedRevenue = "Pleas enter numaric value only";

            public const string GPA = "Please enter valid GPA score";

            public const string GPARange = "Please enter valid GPA Range";

            public const string Number = "Please enter Number Only.";

            public const string BankName = "Please enter bank name.";

            public const string CashHolderName = "Please enter cash holder name.";

            public const string Desingation = "Please enter designation.";





        }
    }
}
