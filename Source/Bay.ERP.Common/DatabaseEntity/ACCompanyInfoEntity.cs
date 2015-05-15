// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 28-Jan-2013, 12:49:20




using System;
using System.Diagnostics;
using System.ServiceModel;
using System.Runtime.Serialization;
using System.Collections.Generic;
using System.Xml.Serialization;


namespace Bay.ERP.Common.BusinessEntities
{
    [Serializable]
    [DataContract(Name = "ACCompanyInfo", Namespace = "http://www.e-p-m-s.com/types")]
    public partial class ACCompanyInfoEntity : BaseEntity
    {
        #region Properties


        private Int64 _CompanyInfoID;
        private String _CompanyName;
        private String _AddressLine1;
        private String _AddressLine2;
        private String _PhoneNumber;
        private String _Email;
        private String _OfficialCompanyNumber;
        private Int64 _HomeCurrencyID;
        private Int64 _FiscalYearID;


        [DataMember]
        public Int64 CompanyInfoID
        {
            get { return _CompanyInfoID; }
            set { _CompanyInfoID = value; }
        }

        [DataMember]
        public String CompanyName
        {
            get { return _CompanyName; }
            set { _CompanyName = value; }
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
        public String PhoneNumber
        {
            get { return _PhoneNumber; }
            set { _PhoneNumber = value; }
        }

        [DataMember]
        public String Email
        {
            get { return _Email; }
            set { _Email = value; }
        }

        [DataMember]
        public String OfficialCompanyNumber
        {
            get { return _OfficialCompanyNumber; }
            set { _OfficialCompanyNumber = value; }
        }

        [DataMember]
        public Int64 HomeCurrencyID
        {
            get { return _HomeCurrencyID; }
            set { _HomeCurrencyID = value; }
        }

        [DataMember]
        public Int64 FiscalYearID
        {
            get { return _FiscalYearID; }
            set { _FiscalYearID = value; }
        }

        [XmlIgnore()]
        public override bool IsNew
        {
            [DebuggerStepThrough()]
            get
            {
                return (CompanyInfoID <= 0);
            }
        }


        #endregion

        #region Constructor

        public ACCompanyInfoEntity() : base()
        {
        }

        #endregion

        #region Constant

        public const String FLD_NAME_CompanyInfoID = "CompanyInfoID";
        public const String FLD_NAME_CompanyName = "CompanyName";
        public const String FLD_NAME_AddressLine1 = "AddressLine1";
        public const String FLD_NAME_AddressLine2 = "AddressLine2";
        public const String FLD_NAME_PhoneNumber = "PhoneNumber";
        public const String FLD_NAME_Email = "Email";
        public const String FLD_NAME_OfficialCompanyNumber = "OfficialCompanyNumber";
        public const String FLD_NAME_HomeCurrencyID = "HomeCurrencyID";
        public const String FLD_NAME_FiscalYearID = "FiscalYearID";

        #endregion
    }
}
