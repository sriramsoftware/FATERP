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
    [DataContract(Name = "CRMMDAgreementVariable", Namespace = "http://www.e-p-m-s.com/types")]
    public partial class CRMMDAgreementVariableEntity : BaseEntity
    {
        #region Properties


        private Int64 _AgreementVariableID;
        private String _Name;
        private String _Value;
        private String _Remarks;
        private Int64 _CreatedByEmployeeID;
        private DateTime _CreateDate;
        private String _IP;
        private Boolean _IsRemoved;


        [DataMember]
        public Int64 AgreementVariableID
        {
            get { return _AgreementVariableID; }
            set { _AgreementVariableID = value; }
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
                return (AgreementVariableID <= 0);
            }
        }


        #endregion

        #region Constructor

        public CRMMDAgreementVariableEntity() : base()
        {
        }

        #endregion

        #region Constant

        public const String FLD_NAME_AgreementVariableID = "AgreementVariableID";
        public const String FLD_NAME_Name = "Name";
        public const String FLD_NAME_Value = "Value";
        public const String FLD_NAME_Remarks = "Remarks";
        public const String FLD_NAME_CreatedByEmployeeID = "CreatedByEmployeeID";
        public const String FLD_NAME_CreateDate = "CreateDate";
        public const String FLD_NAME_IP = "IP";
        public const String FLD_NAME_IsRemoved = "IsRemoved";

        #endregion
    }
}
