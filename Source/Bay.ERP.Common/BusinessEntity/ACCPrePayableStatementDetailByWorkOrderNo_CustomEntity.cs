// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 23-Jan-2013, 05:35:00




using System;
using System.Diagnostics;
using System.ServiceModel;
using System.Runtime.Serialization;
using System.Collections.Generic;
using System.Xml.Serialization;


namespace Bay.ERP.Common.BusinessEntities
{
    [Serializable]
    [DataContract(Name = "ACCPrePayableStatementDetailByWorkOrderNo_Custom", Namespace = "http://www.e-p-m-s.com/types")]
    public partial class ACCPrePayableStatementDetailByWorkOrderNo_CustomEntity : BaseEntity
    {
        #region Properties


        private Int64 _WorkOrderPaymentTermID;
        private Decimal _PaymentPercentage;
        private Decimal _CompletionPercentage;
        private DateTime? _PaymentDate;
        private String _CompletionNote;
        private Decimal? _WOAmount;
        private Int64 _WorkOrderStatusID;
        private Int64 _WorkOrderID;
        private String _WorkOrderNo;
        private DateTime _StartDate;
        private Int64 _SupplierID;


        [DataMember]
        public Int64 WorkOrderPaymentTermID
        {
            get { return _WorkOrderPaymentTermID; }
            set { _WorkOrderPaymentTermID = value; }
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
        public DateTime? PaymentDate
        {
            get { return _PaymentDate; }
            set { _PaymentDate = value; }
        }

        [DataMember]
        public String CompletionNote
        {
            get { return _CompletionNote; }
            set { _CompletionNote = value; }
        }

        [DataMember]
        public Decimal? WOAmount
        {
            get { return _WOAmount; }
            set { _WOAmount = value; }
        }

        [DataMember]
        public Int64 WorkOrderStatusID
        {
            get { return _WorkOrderStatusID; }
            set { _WorkOrderStatusID = value; }
        }

        [DataMember]
        public Int64 WorkOrderID
        {
            get { return _WorkOrderID; }
            set { _WorkOrderID = value; }
        }

        [DataMember]
        public String WorkOrderNo
        {
            get { return _WorkOrderNo; }
            set { _WorkOrderNo = value; }
        }

        [DataMember]
        public DateTime StartDate
        {
            get { return _StartDate; }
            set { _StartDate = value; }
        }

        [DataMember]
        public Int64 SupplierID
        {
            get { return _SupplierID; }
            set { _SupplierID = value; }
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

        public ACCPrePayableStatementDetailByWorkOrderNo_CustomEntity() : base()
        {
        }

        #endregion

        #region Constant

        public const String FLD_NAME_WorkOrderPaymentTermID = "WorkOrderPaymentTermID";
        public const String FLD_NAME_PaymentPercentage = "PaymentPercentage";
        public const String FLD_NAME_CompletionPercentage = "CompletionPercentage";
        public const String FLD_NAME_PaymentDate = "PaymentDate";
        public const String FLD_NAME_CompletionNote = "CompletionNote";
        public const String FLD_NAME_WOAmount = "WOAmount";
        public const String FLD_NAME_WorkOrderStatusID = "WorkOrderStatusID";
        public const String FLD_NAME_WorkOrderID = "WorkOrderID";
        public const String FLD_NAME_WorkOrderNo = "WorkOrderNo";
        public const String FLD_NAME_StartDate = "StartDate";
        public const String FLD_NAME_SupplierID = "SupplierID";

        #endregion
    }
}
