// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 17-Apr-2013, 05:21:43




using System;
using System.Diagnostics;
using System.ServiceModel;
using System.Runtime.Serialization;
using System.Collections.Generic;
using System.Xml.Serialization;


namespace Bay.ERP.Common.BusinessEntities
{
    [Serializable]
    [DataContract(Name = "CRMAgreementVariableMap", Namespace = "http://www.e-p-m-s.com/types")]
    public partial class CRMAgreementVariableMapEntity : BaseEntity
    {
        #region Properties


        private Int64 _AgreementVariableMapID;
        private Int64 _AgreementID;
        private String _Name;
        private String _Value;
        private String _Remarks;
        private Int64 _CreatedByEmployeeID;
        private DateTime _CreateDate;
        private String _IP;


        [DataMember]
        public Int64 AgreementVariableMapID
        {
            get { return _AgreementVariableMapID; }
            set { _AgreementVariableMapID = value; }
        }

        [DataMember]
        public Int64 AgreementID
        {
            get { return _AgreementID; }
            set { _AgreementID = value; }
        }

        [DataMember]
        public String Name
        {
            get { return _Name; }
            set { _Name = value; }
        }

        [DataMember]
        public String Value
        {
            get { return _Value; }
            set { _Value = value; }
        }

        [DataMember]
        public String Remarks
        {
            get { return _Remarks; }
            set { _Remarks = value; }
        }

        [DataMember]
        public Int64 CreatedByEmployeeID
        {
            get { return _CreatedByEmployeeID; }
            set { _CreatedByEmployeeID = value; }
        }

        [DataMember]
        public DateTime CreateDate
        {
            get { return _CreateDate; }
            set { _CreateDate = value; }
        }

        [DataMember]
        public String IP
        {
            get { return _IP; }
            set { _IP = value; }
        }

        [XmlIgnore()]
        public override bool IsNew
        {
            [DebuggerStepThrough()]
            get
            {
                return (AgreementVariableMapID <= 0);
            }
        }


        #endregion

        #region Constructor

        public CRMAgreementVariableMapEntity() : base()
        {
        }

        #endregion

        #region Constant

        public const String FLD_NAME_AgreementVariableMapID = "AgreementVariableMapID";
        public const String FLD_NAME_AgreementID = "AgreementID";
        public const String FLD_NAME_Name = "Name";
        public const String FLD_NAME_Value = "Value";
        public const String FLD_NAME_Remarks = "Remarks";
        public const String FLD_NAME_CreatedByEmployeeID = "CreatedByEmployeeID";
        public const String FLD_NAME_CreateDate = "CreateDate";
        public const String FLD_NAME_IP = "IP";

        #endregion
    }
}
