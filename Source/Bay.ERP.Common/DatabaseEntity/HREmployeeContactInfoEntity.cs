// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 20-Dec-2013, 02:17:52




using System;
using System.Diagnostics;
using System.ServiceModel;
using System.Runtime.Serialization;
using System.Collections.Generic;
using System.Xml.Serialization;


namespace Bay.ERP.Common.BusinessEntities
{
    [Serializable]
    [DataContract(Name = "HREmployeeContactInfo", Namespace = "http://www.e-p-m-s.com/types")]
    public partial class HREmployeeContactInfoEntity : BaseEntity
    {
        #region Properties


        private Int64 _EmployeeContactInfoID;
        private Int64 _EmployeeID;
        private Int64 _EmployeeContactTypeID;
        private String _ContactInfo;
        private String _Description;
        private String _Remarks;


        [DataMember]
        public Int64 EmployeeContactInfoID
        {
            get { return _EmployeeContactInfoID; }
            set { _EmployeeContactInfoID = value; }
        }

        [DataMember]
        public Int64 EmployeeID
        {
            get { return _EmployeeID; }
            set { _EmployeeID = value; }
        }

        [DataMember]
        public Int64 EmployeeContactTypeID
        {
            get { return _EmployeeContactTypeID; }
            set { _EmployeeContactTypeID = value; }
        }

        [DataMember]
        public String ContactInfo
        {
            get { return _ContactInfo; }
            set { _ContactInfo = value; }
        }

        [DataMember]
        public String Description
        {
            get { return _Description; }
            set { _Description = value; }
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
                return (EmployeeContactInfoID <= 0);
            }
        }


        #endregion

        #region Constructor

        public HREmployeeContactInfoEntity() : base()
        {
        }

        #endregion

        #region Constant

        public const String FLD_NAME_EmployeeContactInfoID = "EmployeeContactInfoID";
        public const String FLD_NAME_EmployeeID = "EmployeeID";
        public const String FLD_NAME_EmployeeContactTypeID = "EmployeeContactTypeID";
        public const String FLD_NAME_ContactInfo = "ContactInfo";
        public const String FLD_NAME_Description = "Description";
        public const String FLD_NAME_Remarks = "Remarks";

        #endregion
    }
}
