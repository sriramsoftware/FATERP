// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 13-Dec-2012, 11:43:49




using System;
using System.Diagnostics;
using System.ServiceModel;
using System.Runtime.Serialization;
using System.Collections.Generic;
using System.Xml.Serialization;


namespace Bay.ERP.Common.BusinessEntities
{
    [Serializable]
    [DataContract(Name = "MDPayableClassification", Namespace = "http://www.e-p-m-s.com/types")]
    public partial class MDPayableClassificationEntity : BaseEntity
    {
        #region Properties


        private Int64 _PayableClassificationID;
        private String _Name;
        private String _Narration;
        private String _PaymentMode;
        private String _PaymentChennal;
        private String _SecurityMoney;
        private String _TaxDeduction;
        private String _Remarks;
        private Boolean _IsRemoved;


        [DataMember]
        public Int64 PayableClassificationID
        {
            get { return _PayableClassificationID; }
            set { _PayableClassificationID = value; }
        }

        [DataMember]
        public String Name
        {
            get { return _Name; }
            set { _Name = value; }
        }

        [DataMember]
        public String Narration
        {
            get { return _Narration; }
            set { _Narration = value; }
        }

        [DataMember]
        public String PaymentMode
        {
            get { return _PaymentMode; }
            set { _PaymentMode = value; }
        }

        [DataMember]
        public String PaymentChennal
        {
            get { return _PaymentChennal; }
            set { _PaymentChennal = value; }
        }

        [DataMember]
        public String SecurityMoney
        {
            get { return _SecurityMoney; }
            set { _SecurityMoney = value; }
        }

        [DataMember]
        public String TaxDeduction
        {
            get { return _TaxDeduction; }
            set { _TaxDeduction = value; }
        }

        [DataMember]
        public String Remarks
        {
            get { return _Remarks; }
            set { _Remarks = value; }
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
                return (PayableClassificationID <= 0);
            }
        }


        #endregion

        #region Constructor

        public MDPayableClassificationEntity() : base()
        {
        }

        #endregion

        #region Constant

        public const String FLD_NAME_PayableClassificationID = "PayableClassificationID";
        public const String FLD_NAME_Name = "Name";
        public const String FLD_NAME_Narration = "Narration";
        public const String FLD_NAME_PaymentMode = "PaymentMode";
        public const String FLD_NAME_PaymentChennal = "PaymentChennal";
        public const String FLD_NAME_SecurityMoney = "SecurityMoney";
        public const String FLD_NAME_TaxDeduction = "TaxDeduction";
        public const String FLD_NAME_Remarks = "Remarks";
        public const String FLD_NAME_IsRemoved = "IsRemoved";

        #endregion
    }
}
