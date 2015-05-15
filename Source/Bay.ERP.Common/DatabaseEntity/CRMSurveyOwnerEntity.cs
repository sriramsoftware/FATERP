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
    [DataContract(Name = "CRMSurveyOwner", Namespace = "http://www.e-p-m-s.com/types")]
    public partial class CRMSurveyOwnerEntity : BaseEntity
    {
        #region Properties


        private Int64 _SurveyOwnerID;
        private Int64 _SurveyOwnerTypeID;
        private String _Name;
        private String _AddressLine1;
        private String _AddressLine2;
        private String _ContactNo1;
        private String _ContactNo2;
        private String _Email;
        private String _WebLink;
        private String _Remarks;


        [DataMember]
        public Int64 SurveyOwnerID
        {
            get { return _SurveyOwnerID; }
            set { _SurveyOwnerID = value; }
        }

        [DataMember]
        public Int64 SurveyOwnerTypeID
        {
            get { return _SurveyOwnerTypeID; }
            set { _SurveyOwnerTypeID = value; }
        }

        [DataMember]
        public String Name
        {
            get { return _Name; }
            set { _Name = value; }
        }

        [DataMember]
        public String AddressLine1
        {
            get { return _AddressLine1; }
            set { _AddressLine1 = value; }
        }

        [DataMember]
        public String AddressLine2
        {
            get { return _AddressLine2; }
            set { _AddressLine2 = value; }
        }

        [DataMember]
        public String ContactNo1
        {
            get { return _ContactNo1; }
            set { _ContactNo1 = value; }
        }

        [DataMember]
        public String ContactNo2
        {
            get { return _ContactNo2; }
            set { _ContactNo2 = value; }
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
                return (SurveyOwnerID <= 0);
            }
        }


        #endregion

        #region Constructor

        public CRMSurveyOwnerEntity() : base()
        {
        }

        #endregion

        #region Constant

        public const String FLD_NAME_SurveyOwnerID = "SurveyOwnerID";
        public const String FLD_NAME_SurveyOwnerTypeID = "SurveyOwnerTypeID";
        public const String FLD_NAME_Name = "Name";
        public const String FLD_NAME_AddressLine1 = "AddressLine1";
        public const String FLD_NAME_AddressLine2 = "AddressLine2";
        public const String FLD_NAME_ContactNo1 = "ContactNo1";
        public const String FLD_NAME_ContactNo2 = "ContactNo2";
        public const String FLD_NAME_Email = "Email";
        public const String FLD_NAME_WebLink = "WebLink";
        public const String FLD_NAME_Remarks = "Remarks";

        #endregion
    }
}
