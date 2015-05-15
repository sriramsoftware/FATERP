// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 24-Oct-2013, 12:51:37




using System;
using System.Diagnostics;
using System.ServiceModel;
using System.Runtime.Serialization;
using System.Collections.Generic;
using System.Xml.Serialization;


namespace Bay.ERP.Common.BusinessEntities
{
    [Serializable]
    [DataContract(Name = "CRMSurveyOwnerContactPerson", Namespace = "http://www.e-p-m-s.com/types")]
    public partial class CRMSurveyOwnerContactPersonEntity : BaseEntity
    {
        #region Properties


        private Int64 _SurveyOwnerContactPersonID;
        private Int64 _SurveyOwnerID;
        private String _Name;
        private String _Designation;
        private String _Phone;
        private String _MobileNo;
        private String _Fax;
        private String _Email;
        private String _WebLink;
        private String _Remarks;


        [DataMember]
        public Int64 SurveyOwnerContactPersonID
        {
            get { return _SurveyOwnerContactPersonID; }
            set { _SurveyOwnerContactPersonID = value; }
        }

        [DataMember]
        public Int64 SurveyOwnerID
        {
            get { return _SurveyOwnerID; }
            set { _SurveyOwnerID = value; }
        }

        [DataMember]
        public String Name
        {
            get { return _Name; }
            set { _Name = value; }
        }

        [DataMember]
        public String Designation
        {
            get { return _Designation; }
            set { _Designation = value; }
        }

        [DataMember]
        public String Phone
        {
            get { return _Phone; }
            set { _Phone = value; }
        }

        [DataMember]
        public String MobileNo
        {
            get { return _MobileNo; }
            set { _MobileNo = value; }
        }

        [DataMember]
        public String Fax
        {
            get { return _Fax; }
            set { _Fax = value; }
        }

        [DataMember]
        public String Email
        {
            get { return _Email; }
            set { _Email = value; }
        }

        [DataMember]
        public String WebLink
        {
            get { return _WebLink; }
            set { _WebLink = value; }
        }

        [DataMember]
        public String Remarks
        {
            get { return _Remarks; }
            set { _Remarks = value; }
        }

        [XmlIgnore()]
        public override bool IsNew
        {
            [DebuggerStepThrough()]
            get
            {
                return (SurveyOwnerContactPersonID <= 0);
            }
        }


        #endregion

        #region Constructor

        public CRMSurveyOwnerContactPersonEntity() : base()
        {
        }

        #endregion

        #region Constant

        public const String FLD_NAME_SurveyOwnerContactPersonID = "SurveyOwnerContactPersonID";
        public const String FLD_NAME_SurveyOwnerID = "SurveyOwnerID";
        public const String FLD_NAME_Name = "Name";
        public const String FLD_NAME_Designation = "Designation";
        public const String FLD_NAME_Phone = "Phone";
        public const String FLD_NAME_MobileNo = "MobileNo";
        public const String FLD_NAME_Fax = "Fax";
        public const String FLD_NAME_Email = "Email";
        public const String FLD_NAME_WebLink = "WebLink";
        public const String FLD_NAME_Remarks = "Remarks";

        #endregion
    }
}
