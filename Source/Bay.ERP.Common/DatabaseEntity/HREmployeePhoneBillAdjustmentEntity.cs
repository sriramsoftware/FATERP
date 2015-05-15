// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 30-Jan-2013, 09:34:03




using System;
using System.Diagnostics;
using System.ServiceModel;
using System.Runtime.Serialization;
using System.Collections.Generic;
using System.Xml.Serialization;


namespace Bay.ERP.Common.BusinessEntities
{
    [Serializable]
    [DataContract(Name = "HREmployeePhoneBillAdjustment", Namespace = "http://www.e-p-m-s.com/types")]
    public partial class HREmployeePhoneBillAdjustmentEntity : BaseEntity
    {
        #region Properties


        private Int64 _PhoneBillAdjustmentID;
		private Int64 _EmployeeID;
		private Int64 _SalarySessionID;
		private Decimal _PhoneBillAmount;
		private String _PhoneBillNote;
        private Boolean _IsRemoved;


        [DataMember]
        public Int64 PhoneBillAdjustmentID
        {
            get { return _PhoneBillAdjustmentID; }
            set { _PhoneBillAdjustmentID = value; }
        }

        [DataMember]
        public Int64 EmployeeID
        {
            get { return _EmployeeID; }
            set { _EmployeeID = value; }
        }

        [DataMember]
        public Int64 SalarySessionID
        {
            get { return _SalarySessionID; }
            set { _SalarySessionID = value; }
        }

        [DataMember]
        public Decimal PhoneBillAmount
        {
            get { return _PhoneBillAmount; }
            set { _PhoneBillAmount = value; }
        }

        [DataMember]
        public String PhoneBillNote
        {
            get { return _PhoneBillNote; }
            set { _PhoneBillNote = value; }
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
                return (PhoneBillAdjustmentID <= 0);
            }
        }


        #endregion

        #region Constructor

        public HREmployeePhoneBillAdjustmentEntity()
            : base()
        {
        }

        #endregion

        #region Constant

        public const String FLD_NAME_PhoneBillAdjustmentID = "PhoneBillAdjustmentID";
        public const String FLD_NAME_EmployeeID = "EmployeeID";
        public const String FLD_NAME_SalarySessionID = "SalarySessionID";
        public const String FLD_NAME_PhoneBillAmount = "PhoneBillAmount";
        public const String FLD_NAME_PhoneBillNote = "PhoneBillNote";
        public const String FLD_NAME_IsRemoved = "IsRemoved";

        #endregion
    }
}
