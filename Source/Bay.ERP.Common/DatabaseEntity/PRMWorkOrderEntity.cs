// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 14-Aug-2013, 02:50:29




using System;
using System.Diagnostics;
using System.ServiceModel;
using System.Runtime.Serialization;
using System.Collections.Generic;
using System.Xml.Serialization;


namespace Bay.ERP.Common.BusinessEntities
{
    [Serializable]
    [DataContract(Name = "PRMWorkOrder", Namespace = "http://www.e-p-m-s.com/types")]
    public partial class PRMWorkOrderEntity : BaseEntity
    {
        #region Properties


        private Int64 _WorkOrderID;
        private Int64 _SupplierID;
        private String _WorkOrderNo;
        private Int64? _AttentionID;
        private String _OtherAttention;
        private DateTime _CreateDate;
        private String _Subject;
        private String _BodyTitle;
        private DateTime _StartDate;
        private DateTime _CompletionDate;
        private String _Warranty;
        private String _DelayCharge;
        private Decimal? _AIT;
        private Decimal? _CarryingCharge;
        private Decimal? _Discount;
        private Decimal? _VAT;
        private Decimal? _Tax;
        private Decimal? _GrandTotal;
        private String _RowText;
        private String _Remarks;
        private String _FootNote;
        private Int64 _PreparedByID;
        private Int64 _WorkOrderStatusID;
        private Boolean _IsFinalBilled;


        [DataMember]
        public Int64 WorkOrderID
        {
            get { return _WorkOrderID; }
            set { _WorkOrderID = value; }
        }

        [DataMember]
        public Int64 SupplierID
        {
            get { return _SupplierID; }
            set { _SupplierID = value; }
        }

        [DataMember]
        public String WorkOrderNo
        {
            get { return _WorkOrderNo; }
            set { _WorkOrderNo = value; }
        }

        [DataMember]
        public Int64? AttentionID
        {
            get { return _AttentionID; }
            set { _AttentionID = value; }
        }

        [DataMember]
        public String OtherAttention
        {
            get { return _OtherAttention; }
            set { _OtherAttention = value; }
        }

        [DataMember]
        public DateTime CreateDate
        {
            get { return _CreateDate; }
            set { _CreateDate = value; }
        }

        [DataMember]
        public String Subject
        {
            get { return _Subject; }
            set { _Subject = value; }
        }

        [DataMember]
        public String BodyTitle
        {
            get { return _BodyTitle; }
            set { _BodyTitle = value; }
        }

        [DataMember]
        public DateTime StartDate
        {
            get { return _StartDate; }
            set { _StartDate = value; }
        }

        [DataMember]
        public DateTime CompletionDate
        {
            get { return _CompletionDate; }
            set { _CompletionDate = value; }
        }

        [DataMember]
        public String Warranty
        {
            get { return _Warranty; }
            set { _Warranty = value; }
        }

        [DataMember]
        public String DelayCharge
        {
            get { return _DelayCharge; }
            set { _DelayCharge = value; }
        }

        [DataMember]
        public Decimal? AIT
        {
            get { return _AIT; }
            set { _AIT = value; }
        }

        [DataMember]
        public Decimal? CarryingCharge
        {
            get { return _CarryingCharge; }
            set { _CarryingCharge = value; }
        }

        [DataMember]
        public Decimal? Discount
        {
            get { return _Discount; }
            set { _Discount = value; }
        }

        [DataMember]
        public Decimal? VAT
        {
            get { return _VAT; }
            set { _VAT = value; }
        }

        [DataMember]
        public Decimal? Tax
        {
            get { return _Tax; }
            set { _Tax = value; }
        }

        [DataMember]
        public Decimal? GrandTotal
        {
            get { return _GrandTotal; }
            set { _GrandTotal = value; }
        }

        [DataMember]
        public String RowText
        {
            get { return _RowText; }
            set { _RowText = value; }
        }

        [DataMember]
        public String Remarks
        {
            get { return _Remarks; }
            set { _Remarks = value; }
        }

        [DataMember]
        public String FootNote
        {
            get { return _FootNote; }
            set { _FootNote = value; }
        }

        [DataMember]
        public Int64 PreparedByID
        {
            get { return _PreparedByID; }
            set { _PreparedByID = value; }
        }

        [DataMember]
        public Int64 WorkOrderStatusID
        {
            get { return _WorkOrderStatusID; }
            set { _WorkOrderStatusID = value; }
        }

        [DataMember]
        public Boolean IsFinalBilled
        {
            get { return _IsFinalBilled; }
            set { _IsFinalBilled = value; }
        }

        [XmlIgnore()]
        public override bool IsNew
        {
            [DebuggerStepThrough()]
            get
            {
                return (WorkOrderID <= 0);
            }
        }


        #endregion

        #region Constructor

        public PRMWorkOrderEntity() : base()
        {
        }

        #endregion

        #region Constant

        public const String FLD_NAME_WorkOrderID = "WorkOrderID";
        public const String FLD_NAME_SupplierID = "SupplierID";
        public const String FLD_NAME_WorkOrderNo = "WorkOrderNo";
        public const String FLD_NAME_AttentionID = "AttentionID";
        public const String FLD_NAME_OtherAttention = "OtherAttention";
        public const String FLD_NAME_CreateDate = "CreateDate";
        public const String FLD_NAME_Subject = "Subject";
        public const String FLD_NAME_BodyTitle = "BodyTitle";
        public const String FLD_NAME_StartDate = "StartDate";
        public const String FLD_NAME_CompletionDate = "CompletionDate";
        public const String FLD_NAME_Warranty = "Warranty";
        public const String FLD_NAME_DelayCharge = "DelayCharge";
        public const String FLD_NAME_AIT = "AIT";
        public const String FLD_NAME_CarryingCharge = "CarryingCharge";
        public const String FLD_NAME_Discount = "Discount";
        public const String FLD_NAME_VAT = "VAT";
        public const String FLD_NAME_Tax = "Tax";
        public const String FLD_NAME_GrandTotal = "GrandTotal";
        public const String FLD_NAME_RowText = "RowText";
        public const String FLD_NAME_Remarks = "Remarks";
        public const String FLD_NAME_FootNote = "FootNote";
        public const String FLD_NAME_PreparedByID = "PreparedByID";
        public const String FLD_NAME_WorkOrderStatusID = "WorkOrderStatusID";
        public const String FLD_NAME_IsFinalBilled = "IsFinalBilled";

        #endregion
    }
}
