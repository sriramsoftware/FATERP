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
    [DataContract(Name = "HREmployeeEmergencyContactInfo", Namespace = "http://www.e-p-m-s.com/types")]
    public partial class HREmployeeEmergencyContactInfoEntity : BaseEntity
    {
        #region Properties


        private Int64 _EmployeeEmergencyContactInfoID;
        private Int64 _EmployeeID;
        private String _FirstName;
        private String _MiddleName;
        private String _LastName;
        private String _HomePhoneNumber;
        private String _MobilePhoneNumber;
        private String _RelationShip;


        [DataMember]
        public Int64 EmployeeEmergencyContactInfoID
        {
            get { return _EmployeeEmergencyContactInfoID; }
            set { _EmployeeEmergencyContactInfoID = value; }
        }

        [DataMember]
        public Int64 EmployeeID
        {
            get { return _EmployeeID; }
            set { _EmployeeID = value; }
        }

        [DataMember]
        public String FirstName
        {
            get { return _FirstName; }
            set { _FirstName = value; }
        }

        [DataMember]
        public String MiddleName
        {
            get { return _MiddleName; }
            set { _MiddleName = value; }
        }

        [DataMember]
        public String LastName
        {
            get { return _LastName; }
            set { _LastName = value; }
        }

        [DataMember]
        public String HomePhoneNumber
        {
            get { return _HomePhoneNumber; }
            set { _HomePhoneNumber = value; }
        }

        [DataMember]
        public String MobilePhoneNumber
        {
            get { return _MobilePhoneNumber; }
            set { _MobilePhoneNumber = value; }
        }

        [DataMember]
        public String RelationShip
        {
            get { return _RelationShip; }
            set { _RelationShip = value; }
        }

        [XmlIgnore()]
        public override bool IsNew
        {
            [DebuggerStepThrough()]
            get
            {
                return (EmployeeEmergencyContactInfoID <= 0);
            }
        }


        #endregion

        #region Constructor

        public HREmployeeEmergencyContactInfoEntity() : base()
        {
        }

        #endregion

        #region Constant

        public const String FLD_NAME_EmployeeEmergencyContactInfoID = "EmployeeEmergencyContactInfoID";
        public const String FLD_NAME_EmployeeID = "EmployeeID";
        public const String FLD_NAME_FirstName = "FirstName";
        public const String FLD_NAME_MiddleName = "MiddleName";
        public const String FLD_NAME_LastName = "LastName";
        public const String FLD_NAME_HomePhoneNumber = "HomePhoneNumber";
        public const String FLD_NAME_MobilePhoneNumber = "MobilePhoneNumber";
        public const String FLD_NAME_RelationShip = "RelationShip";

        #endregion
    }
}
