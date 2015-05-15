// Copyright and All Rights Reserved by
//B2B Solution, Bangladesh;
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 05-Jan-2012, 11:52:45




using System;
using System.Diagnostics;
using System.ServiceModel;
using System.Runtime.Serialization;
using System.Collections.Generic;
using System.Xml.Serialization;


namespace Bay.ERP.Common.BusinessEntities
{
    [Serializable]
    [DataContract(Name = "CMContractorContactPerson", Namespace = "http://www.e-p-m-s.com/types")]
    public partial class CMContractorContactPersonEntity : BaseEntity
    {
        #region Properties


        private Int64 _ContractorContactPersonID;
        private Int64 _ContractorID;
        private String _Name;
        private String _Designation;
        private String _Phone;
        private String _Email;
        private String _AddressLine1;
        private String _AddressLine2;


        [DataMember]
        public Int64 ContractorContactPersonID
        {
            get { return _ContractorContactPersonID; }
            set { _ContractorContactPersonID = value; }
        }

        [DataMember]
        public Int64 ContractorID
        {
            get { return _ContractorID; }
            set { _ContractorID = value; }
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
        public String Email
        {
            get { return _Email; }
            set { _Email = value; }
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

        [XmlIgnore()]
        public override bool IsNew
        {
            [DebuggerStepThrough()]
            get
            {
                return (ContractorContactPersonID <= 0);
            }
        }


        #endregion

        #region Constructor

        public CMContractorContactPersonEntity() : base()
        {
        }

        #endregion

        #region Constant

        public const String FLD_NAME_ContractorContactPersonID = "ContractorContactPersonID";
        public const String FLD_NAME_ContractorID = "ContractorID";
        public const String FLD_NAME_Name = "Name";
        public const String FLD_NAME_Designation = "Designation";
        public const String FLD_NAME_Phone = "Phone";
        public const String FLD_NAME_Email = "Email";
        public const String FLD_NAME_AddressLine1 = "AddressLine1";
        public const String FLD_NAME_AddressLine2 = "AddressLine2";

        #endregion
    }
}
