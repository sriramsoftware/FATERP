// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 03-Feb-2013, 03:00:14




using System;
using System.Diagnostics;
using System.ServiceModel;
using System.Runtime.Serialization;
using System.Collections.Generic;
using System.Xml.Serialization;


namespace Bay.ERP.Common.BusinessEntities
{
    [Serializable]
    [DataContract(Name = "CRMCustomer", Namespace = "http://www.e-p-m-s.com/types")]
    public partial class CRMCustomerEntity : BaseEntity
    {
        #region Properties


        private Int64 _CustomerID;
        private String _FirstName;
        private String _MiddleName;
        private String _LastName;
        private String _PrimaryEmail;
        private String _SecondaryEmail;
        private String _Phone;
        private String _Fax;


        [DataMember]
        public Int64 CustomerID
        {
            get { return _CustomerID; }
            set { _CustomerID = value; }
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
        public String PrimaryEmail
        {
            get { return _PrimaryEmail; }
            set { _PrimaryEmail = value; }
        }

        [DataMember]
        public String SecondaryEmail
        {
            get { return _SecondaryEmail; }
            set { _SecondaryEmail = value; }
        }

        [DataMember]
        public String Phone
        {
            get { return _Phone; }
            set { _Phone = value; }
        }

        [DataMember]
        public String Fax
        {
            get { return _Fax; }
            set { _Fax = value; }
        }

        [XmlIgnore()]
        public override bool IsNew
        {
            [DebuggerStepThrough()]
            get
            {
                return (CustomerID <= 0);
            }
        }


        #endregion

        #region Constructor

        public CRMCustomerEntity() : base()
        {
        }

        #endregion

        #region Constant

        public const String FLD_NAME_CustomerID = "CustomerID";
        public const String FLD_NAME_FirstName = "FirstName";
        public const String FLD_NAME_MiddleName = "MiddleName";
        public const String FLD_NAME_LastName = "LastName";
        public const String FLD_NAME_PrimaryEmail = "PrimaryEmail";
        public const String FLD_NAME_SecondaryEmail = "SecondaryEmail";
        public const String FLD_NAME_Phone = "Phone";
        public const String FLD_NAME_Fax = "Fax";

        #endregion
    }
}
