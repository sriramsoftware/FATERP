// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 12-Jan-2014, 03:42:17




using System;
using System.Diagnostics;
using System.ServiceModel;
using System.Runtime.Serialization;
using System.Collections.Generic;
using System.Xml.Serialization;


namespace Bay.ERP.Common.BusinessEntities
{
    [Serializable]
    [DataContract(Name = "HREmployeeAdditionalPaymentInfo", Namespace = "http://www.e-p-m-s.com/types")]
    public partial class HREmployeeAdditionalPaymentInfoEntity : BaseEntity
    {
        #region Properties


        private Int64 _EmployeeAdditonalPaymentInfoID;
        private DateTime _PayDate;
        private Decimal _PayAmount;
        private Decimal _PayCurrency;
        private String _Notes;
        private Boolean _PayNow;
        private Int64 _PayDuringPayrollGenerationEditorID;


        [DataMember]
        public Int64 EmployeeAdditonalPaymentInfoID
        {
            get { return _EmployeeAdditonalPaymentInfoID; }
            set { _EmployeeAdditonalPaymentInfoID = value; }
        }

        [DataMember]
        public DateTime PayDate
        {
            get { return _PayDate; }
            set { _PayDate = value; }
        }

        [DataMember]
        public Decimal PayAmount
        {
            get { return _PayAmount; }
            set { _PayAmount = value; }
        }

        [DataMember]
        public Decimal PayCurrency
        {
            get { return _PayCurrency; }
            set { _PayCurrency = value; }
        }

        [DataMember]
        public String Notes
        {
            get { return _Notes; }
            set { _Notes = value; }
        }

        [DataMember]
        public Boolean PayNow
        {
            get { return _PayNow; }
            set { _PayNow = value; }
        }

        [DataMember]
        public Int64 PayDuringPayrollGenerationEditorID
        {
            get { return _PayDuringPayrollGenerationEditorID; }
            set { _PayDuringPayrollGenerationEditorID = value; }
        }

        [XmlIgnore()]
        public override bool IsNew
        {
            [DebuggerStepThrough()]
            get
            {
                return (EmployeeAdditonalPaymentInfoID <= 0);
            }
        }


        #endregion

        #region Constructor

        public HREmployeeAdditionalPaymentInfoEntity() : base()
        {
        }

        #endregion

        #region Constant

        public const String FLD_NAME_EmployeeAdditonalPaymentInfoID = "EmployeeAdditonalPaymentInfoID";
        public const String FLD_NAME_PayDate = "PayDate";
        public const String FLD_NAME_PayAmount = "PayAmount";
        public const String FLD_NAME_PayCurrency = "PayCurrency";
        public const String FLD_NAME_Notes = "Notes";
        public const String FLD_NAME_PayNow = "PayNow";
        public const String FLD_NAME_PayDuringPayrollGenerationEditorID = "PayDuringPayrollGenerationEditorID";

        #endregion
    }
}
