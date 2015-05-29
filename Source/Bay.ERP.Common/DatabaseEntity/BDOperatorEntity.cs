// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 28-May-2015, 11:33:13




using System;
using System.Diagnostics;
using System.ServiceModel;
using System.Runtime.Serialization;
using System.Collections.Generic;
using System.Xml.Serialization;


namespace Bay.ERP.Common.BusinessEntities
{
    [Serializable]
    [DataContract(Name = "BDOperator", Namespace = "http://www.e-p-m-s.com/types")]
    public partial class BDOperatorEntity : BaseEntity
    {
        #region Properties


        private Int64 _OperatorID;
        private String _OperatorCode;
        private String _OperatorName;
        private String _Relationship;
        private String _Phone;
        private String _MobileNo;
        private String _Fax;
        private String _Email;
        private String _WebLink;
        private DateTime _CreateDate;
        private String _Remarks;
        private String _Reason;
        private Int64 _OperatorStatusID;
        private Boolean _IsRemoved;


        [DataMember]
        public Int64 OperatorID
        {
            get { return _OperatorID; }
            set { _OperatorID = value; }
        }

        [DataMember]
        public String OperatorCode
        {
            get { return _OperatorCode; }
            set { _OperatorCode = value; }
        }

        [DataMember]
        public String OperatorName
        {
            get { return _OperatorName; }
            set { _OperatorName = value; }
        }

        [DataMember]
        public String Relationship
        {
            get { return _Relationship; }
            set { _Relationship = value; }
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
        public DateTime CreateDate
        {
            get { return _CreateDate; }
            set { _CreateDate = value; }
        }

        [DataMember]
        public String Remarks
        {
            get { return _Remarks; }
            set { _Remarks = value; }
        }

        [DataMember]
        public String Reason
        {
            get { return _Reason; }
            set { _Reason = value; }
        }

        [DataMember]
        public Int64 OperatorStatusID
        {
            get { return _OperatorStatusID; }
            set { _OperatorStatusID = value; }
        }

        [DataMember]
        public Boolean IsRemoved
        {
            get { return _IsRemoved; }
            set { _IsRemoved = value; }
        }

        [XmlIgnore()]
        public override bool IsNew
        {
            [DebuggerStepThrough()]
            get
            {
                return (OperatorID <= 0);
            }
        }


        #endregion

        #region Constructor

        public BDOperatorEntity() : base()
        {
        }

        #endregion

        #region Constant

        public const String FLD_NAME_OperatorID = "OperatorID";
        public const String FLD_NAME_OperatorCode = "OperatorCode";
        public const String FLD_NAME_OperatorName = "OperatorName";
        public const String FLD_NAME_Relationship = "Relationship";
        public const String FLD_NAME_Phone = "Phone";
        public const String FLD_NAME_MobileNo = "MobileNo";
        public const String FLD_NAME_Fax = "Fax";
        public const String FLD_NAME_Email = "Email";
        public const String FLD_NAME_WebLink = "WebLink";
        public const String FLD_NAME_CreateDate = "CreateDate";
        public const String FLD_NAME_Remarks = "Remarks";
        public const String FLD_NAME_Reason = "Reason";
        public const String FLD_NAME_OperatorStatusID = "OperatorStatusID";
        public const String FLD_NAME_IsRemoved = "IsRemoved";

        #endregion
    }
}
