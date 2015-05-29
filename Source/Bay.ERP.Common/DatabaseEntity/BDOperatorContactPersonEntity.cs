// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 29-May-2015, 12:50:36




using System;
using System.Diagnostics;
using System.ServiceModel;
using System.Runtime.Serialization;
using System.Collections.Generic;
using System.Xml.Serialization;


namespace Bay.ERP.Common.BusinessEntities
{
    [Serializable]
    [DataContract(Name = "BDOperatorContactPerson", Namespace = "http://www.e-p-m-s.com/types")]
    public partial class BDOperatorContactPersonEntity : BaseEntity
    {
        #region Properties


        private Int64 _OperatorContactPersonID;
        private Int64 _OperatorID;
        private Int64 _ZoneID;
        private String _Name;
        private Int64? _ZoneDesignationID;
        private String _ID;
        private String _Phone;
        private String _MobileNo;
        private String _Fax;
        private String _Email;
        private String _WebLink;


        [DataMember]
        public Int64 OperatorContactPersonID
        {
            get { return _OperatorContactPersonID; }
            set { _OperatorContactPersonID = value; }
        }

        [DataMember]
        public Int64 OperatorID
        {
            get { return _OperatorID; }
            set { _OperatorID = value; }
        }

        [DataMember]
        public Int64 ZoneID
        {
            get { return _ZoneID; }
            set { _ZoneID = value; }
        }

        [DataMember]
        public String Name
        {
            get { return _Name; }
            set { _Name = value; }
        }

        [DataMember]
        public Int64? ZoneDesignationID
        {
            get { return _ZoneDesignationID; }
            set { _ZoneDesignationID = value; }
        }

        [DataMember]
        public String ID
        {
            get { return _ID; }
            set { _ID = value; }
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

        [XmlIgnore()]
        public override bool IsNew
        {
            [DebuggerStepThrough()]
            get
            {
                return (OperatorContactPersonID <= 0);
            }
        }


        #endregion

        #region Constructor

        public BDOperatorContactPersonEntity() : base()
        {
        }

        #endregion

        #region Constant

        public const String FLD_NAME_OperatorContactPersonID = "OperatorContactPersonID";
        public const String FLD_NAME_OperatorID = "OperatorID";
        public const String FLD_NAME_ZoneID = "ZoneID";
        public const String FLD_NAME_Name = "Name";
        public const String FLD_NAME_ZoneDesignationID = "ZoneDesignationID";
        public const String FLD_NAME_ID = "ID";
        public const String FLD_NAME_Phone = "Phone";
        public const String FLD_NAME_MobileNo = "MobileNo";
        public const String FLD_NAME_Fax = "Fax";
        public const String FLD_NAME_Email = "Email";
        public const String FLD_NAME_WebLink = "WebLink";

        #endregion
    }
}
