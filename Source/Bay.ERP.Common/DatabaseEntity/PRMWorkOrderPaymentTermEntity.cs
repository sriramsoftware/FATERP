// Copyright and All Rights Reserved by
//B2B Solution, Bangladesh;
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 25-Jun-2012, 05:50:09




using System;
using System.Diagnostics;
using System.ServiceModel;
using System.Runtime.Serialization;
using System.Collections.Generic;
using System.Xml.Serialization;


namespace Bay.ERP.Common.BusinessEntities
{
    [Serializable]
    [DataContract(Name = "PRMWorkOrderPaymentTerm", Namespace = "http://www.e-p-m-s.com/types")]
    public partial class PRMWorkOrderPaymentTermEntity : BaseEntity
    {
        #region Properties


        private Int64 _WorkOrderPaymentTermID;
        private Int64 _WorkOrderID;
        private Decimal _PaymentPercentage;
        private Decimal _CompletionPercentage;
        private String _CompletionNote;
        private DateTime? _PaymentDate;


        [DataMember]
        public Int64 WorkOrderPaymentTermID
        {
            get { return _WorkOrderPaymentTermID; }
            set { _WorkOrderPaymentTermID = value; }
        }

        [DataMember]
        public Int64 WorkOrderID
        {
            get { return _WorkOrderID; }
            set { _WorkOrderID = value; }
        }

        [DataMember]
        public Decimal PaymentPercentage
        {
            get { return _PaymentPercentage; }
            set { _PaymentPercentage = value; }
        }

        [DataMember]
        public Decimal CompletionPercentage
        {
            get { return _CompletionPercentage; }
            set { _CompletionPercentage = value; }
        }

        [DataMember]
        public String CompletionNote
        {
            get { return _CompletionNote; }
            set { _CompletionNote = value; }
        }

        [DataMember]
        public DateTime? PaymentDate
        {
            get { return _PaymentDate; }
            set { _PaymentDate = value; }
        }

        [XmlIgnore()]
        public override bool IsNew
        {
            [DebuggerStepThrough()]
            get
            {
                return (WorkOrderPaymentTermID <= 0);
            }
        }


        #endregion

        #region Constructor

        public PRMWorkOrderPaymentTermEntity() : base()
        {
        }

        #endregion

        #region Constant

        public const String FLD_NAME_WorkOrderPaymentTermID = "WorkOrderPaymentTermID";
        public const String FLD_NAME_WorkOrderID = "WorkOrderID";
        public const String FLD_NAME_PaymentPercentage = "PaymentPercentage";
        public const String FLD_NAME_CompletionPercentage = "CompletionPercentage";
        public const String FLD_NAME_CompletionNote = "CompletionNote";
        public const String FLD_NAME_PaymentDate = "PaymentDate";

        #endregion
    }
}
