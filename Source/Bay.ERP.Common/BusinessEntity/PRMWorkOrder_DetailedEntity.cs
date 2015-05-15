// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 10-Nov-2012, 10:07:19




using System;
using System.Diagnostics;
using System.ServiceModel;
using System.Runtime.Serialization;
using System.Collections.Generic;
using System.Xml.Serialization;


namespace Bay.ERP.Common.BusinessEntities
{
    [Serializable]
    [DataContract(Name = "PRMWorkOrder_Detailed", Namespace = "http://www.e-p-m-s.com/types")]
    public partial class PRMWorkOrder_DetailedEntity : BaseEntity
    {
        #region Properties


        private Int64 _WorkOrderID;
        private Int64 _SupplierID;
        private String _WorkOrderNo;
        private Int64? _AttentionID;
        private DateTime _CreateDate;
        private String _Subject;
        private String _BodyTitle;
        private DateTime _StartDate;
        private DateTime _CompletionDate;
        private String _Warranty;
        private String _DelayCharge;
        private String _Remarks;
        private String _FootNote;
        private Int64 _PreparedByID;
        private Int64 _WorkOrderStatusID;
        private String _PRMSupplierSupplierName;
        private String _AttentionFullName;
        private String _PreparedByFullName;
        private String _MDWorkOrderStatusName;
        private Int64? _RowNumber;


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
        public String PRMSupplierSupplierName
        {
            get { return _PRMSupplierSupplierName; }
            set { _PRMSupplierSupplierName = value; }
        }

        [DataMember]
        public String AttentionFullName
        {
            get { return _AttentionFullName; }
            set { _AttentionFullName = value; }
        }

        [DataMember]
        public String PreparedByFullName
        {
            get { return _PreparedByFullName; }
            set { _PreparedByFullName = value; }
        }

        [DataMember]
        public String MDWorkOrderStatusName
        {
            get { return _MDWorkOrderStatusName; }
            set { _MDWorkOrderStatusName = value; }
        }

        [DataMember]
        public Int64? RowNumber
        {
            get { return _RowNumber; }
            set { _RowNumber = value; }
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

        public PRMWorkOrder_DetailedEntity() : base()
        {
        }

        #endregion

        #region Constant

        public const String FLD_NAME_WorkOrderID = "WorkOrderID";
        public const String FLD_NAME_SupplierID = "SupplierID";
        public const String FLD_NAME_WorkOrderNo = "WorkOrderNo";
        public const String FLD_NAME_AttentionID = "AttentionID";
        public const String FLD_NAME_CreateDate = "CreateDate";
        public const String FLD_NAME_Subject = "Subject";
        public const String FLD_NAME_BodyTitle = "BodyTitle";
        public const String FLD_NAME_StartDate = "StartDate";
        public const String FLD_NAME_CompletionDate = "CompletionDate";
        public const String FLD_NAME_Warranty = "Warranty";
        public const String FLD_NAME_DelayCharge = "DelayCharge";
        public const String FLD_NAME_Remarks = "Remarks";
        public const String FLD_NAME_FootNote = "FootNote";
        public const String FLD_NAME_PreparedByID = "PreparedByID";
        public const String FLD_NAME_WorkOrderStatusID = "WorkOrderStatusID";
        public const String FLD_NAME_PRMSupplierSupplierName = "PRMSupplierSupplierName";
        public const String FLD_NAME_AttentionFullName = "AttentionFullName";
        public const String FLD_NAME_PreparedByFullName = "PreparedByFullName";
        public const String FLD_NAME_MDWorkOrderStatusName = "MDWorkOrderStatusName";
        public const String FLD_NAME_RowNumber = "RowNumber";

        #endregion
    }
}
