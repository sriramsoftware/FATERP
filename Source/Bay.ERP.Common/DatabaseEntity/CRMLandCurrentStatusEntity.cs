// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 01-Apr-2013, 02:41:21




using System;
using System.Diagnostics;
using System.ServiceModel;
using System.Runtime.Serialization;
using System.Collections.Generic;
using System.Xml.Serialization;


namespace Bay.ERP.Common.BusinessEntities
{
    [Serializable]
    [DataContract(Name = "CRMLandCurrentStatus", Namespace = "http://www.e-p-m-s.com/types")]
    public partial class CRMLandCurrentStatusEntity : BaseEntity
    {
        #region Properties


        private Int64 _LandCurrentStatusID;
        private Int64 _LandBasicInfoID;
        private String _Ownership;
        private String _Mutation;
        private String _CurrentUsage;
        private String _CommercialPermit;
        private String _Tenant;
        private String _LoanLiability;
        private String _NOC;
        private String _Agreements;
        private String _Litigation;


        [DataMember]
        public Int64 LandCurrentStatusID
        {
            get { return _LandCurrentStatusID; }
            set { _LandCurrentStatusID = value; }
        }

        [DataMember]
        public Int64 LandBasicInfoID
        {
            get { return _LandBasicInfoID; }
            set { _LandBasicInfoID = value; }
        }

        [DataMember]
        public String Ownership
        {
            get { return _Ownership; }
            set { _Ownership = value; }
        }

        [DataMember]
        public String Mutation
        {
            get { return _Mutation; }
            set { _Mutation = value; }
        }

        [DataMember]
        public String CurrentUsage
        {
            get { return _CurrentUsage; }
            set { _CurrentUsage = value; }
        }

        [DataMember]
        public String CommercialPermit
        {
            get { return _CommercialPermit; }
            set { _CommercialPermit = value; }
        }

        [DataMember]
        public String Tenant
        {
            get { return _Tenant; }
            set { _Tenant = value; }
        }

        [DataMember]
        public String LoanLiability
        {
            get { return _LoanLiability; }
            set { _LoanLiability = value; }
        }

        [DataMember]
        public String NOC
        {
            get { return _NOC; }
            set { _NOC = value; }
        }

        [DataMember]
        public String Agreements
        {
            get { return _Agreements; }
            set { _Agreements = value; }
        }

        [DataMember]
        public String Litigation
        {
            get { return _Litigation; }
            set { _Litigation = value; }
        }

        [XmlIgnore()]
        public override bool IsNew
        {
            [DebuggerStepThrough()]
            get
            {
                return (LandCurrentStatusID <= 0);
            }
        }


        #endregion

        #region Constructor

        public CRMLandCurrentStatusEntity() : base()
        {
        }

        #endregion

        #region Constant

        public const String FLD_NAME_LandCurrentStatusID = "LandCurrentStatusID";
        public const String FLD_NAME_LandBasicInfoID = "LandBasicInfoID";
        public const String FLD_NAME_Ownership = "Ownership";
        public const String FLD_NAME_Mutation = "Mutation";
        public const String FLD_NAME_CurrentUsage = "CurrentUsage";
        public const String FLD_NAME_CommercialPermit = "CommercialPermit";
        public const String FLD_NAME_Tenant = "Tenant";
        public const String FLD_NAME_LoanLiability = "LoanLiability";
        public const String FLD_NAME_NOC = "NOC";
        public const String FLD_NAME_Agreements = "Agreements";
        public const String FLD_NAME_Litigation = "Litigation";

        #endregion
    }
}
