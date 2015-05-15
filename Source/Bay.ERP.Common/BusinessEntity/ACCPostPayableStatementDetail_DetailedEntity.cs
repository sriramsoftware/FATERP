// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 05-Mar-2013, 02:25:48




using System;
using System.Diagnostics;
using System.ServiceModel;
using System.Runtime.Serialization;
using System.Collections.Generic;
using System.Xml.Serialization;


namespace Bay.ERP.Common.BusinessEntities
{
    [Serializable]
    [DataContract(Name = "ACCPostPayableStatementDetail_Detailed", Namespace = "http://www.e-p-m-s.com/types")]
    public partial class ACCPostPayableStatementDetail_DetailedEntity : BaseEntity
    {
        #region Properties


        private Int64 _PostPayableStatementDetailID;
        private Int64 _PostPayableStatementID;
        private String _ProjectCode;
        private String _WorkOrderNo;
        private Decimal? _WorkOrderAmount;
        private DateTime? _WorkOrderDate;
        private Decimal? _PaidAmount;
        private Decimal? _SecurityMoney;
        private Decimal? _TDSAmount;
        private Decimal? _PayableAgainstWorkOrder;
        private Decimal? _ApprovedBillAmount;
        private Decimal? _NetPayableConsideringBillAndSecurity;
        private Boolean _PartyReconcile;
        private String _RequisitionNo;
        private DateTime? _RequisitionDate;
        private String _BillNo;
        private DateTime? _BillDate;
        private String _Ref;
        private String _ACCPostPayableStatementRef;
        private Int64? _ACCPrePayableStatementDetailPrePayableStatementID;
        private String _BDProjectProjectName;
        private String _PaymentStatusName;
        private String _PayableApprovalStatusName;
        private String _AccountPaybleStatementDetailCategoryName;
        private String _PayableClassificationName;
        private String _MemberFullName;
        private String _APPanelName;
        private String _SupplierName;
        private Int64? _RowNumber;


        [DataMember]
        public Int64 PostPayableStatementDetailID
        {
            get { return _PostPayableStatementDetailID; }
            set { _PostPayableStatementDetailID = value; }
        }

        [DataMember]
        public Int64 PostPayableStatementID
        {
            get { return _PostPayableStatementID; }
            set { _PostPayableStatementID = value; }
        }

        [DataMember]
        public String ProjectCode
        {
            get { return _ProjectCode; }
            set { _ProjectCode = value; }
        }

        [DataMember]
        public String WorkOrderNo
        {
            get { return _WorkOrderNo; }
            set { _WorkOrderNo = value; }
        }

        [DataMember]
        public Decimal? WorkOrderAmount
        {
            get { return _WorkOrderAmount; }
            set { _WorkOrderAmount = value; }
        }

        [DataMember]
        public DateTime? WorkOrderDate
        {
            get { return _WorkOrderDate; }
            set { _WorkOrderDate = value; }
        }

        [DataMember]
        public Decimal? PaidAmount
        {
            get { return _PaidAmount; }
            set { _PaidAmount = value; }
        }

        [DataMember]
        public Decimal? SecurityMoney
        {
            get { return _SecurityMoney; }
            set { _SecurityMoney = value; }
        }

        [DataMember]
        public Decimal? TDSAmount
        {
            get { return _TDSAmount; }
            set { _TDSAmount = value; }
        }

        [DataMember]
        public Decimal? PayableAgainstWorkOrder
        {
            get { return _PayableAgainstWorkOrder; }
            set { _PayableAgainstWorkOrder = value; }
        }

        [DataMember]
        public Decimal? ApprovedBillAmount
        {
            get { return _ApprovedBillAmount; }
            set { _ApprovedBillAmount = value; }
        }

        [DataMember]
        public Decimal? NetPayableConsideringBillAndSecurity
        {
            get { return _NetPayableConsideringBillAndSecurity; }
            set { _NetPayableConsideringBillAndSecurity = value; }
        }

        [DataMember]
        public Boolean PartyReconcile
        {
            get { return _PartyReconcile; }
            set { _PartyReconcile = value; }
        }

        [DataMember]
        public String RequisitionNo
        {
            get { return _RequisitionNo; }
            set { _RequisitionNo = value; }
        }

        [DataMember]
        public DateTime? RequisitionDate
        {
            get { return _RequisitionDate; }
            set { _RequisitionDate = value; }
        }

        [DataMember]
        public String BillNo
        {
            get { return _BillNo; }
            set { _BillNo = value; }
        }

        [DataMember]
        public DateTime? BillDate
        {
            get { return _BillDate; }
            set { _BillDate = value; }
        }

        [DataMember]
        public String Ref
        {
            get { return _Ref; }
            set { _Ref = value; }
        }

        [DataMember]
        public String ACCPostPayableStatementRef
        {
            get { return _ACCPostPayableStatementRef; }
            set { _ACCPostPayableStatementRef = value; }
        }

        [DataMember]
        public Int64? ACCPrePayableStatementDetailPrePayableStatementID
        {
            get { return _ACCPrePayableStatementDetailPrePayableStatementID; }
            set { _ACCPrePayableStatementDetailPrePayableStatementID = value; }
        }

        [DataMember]
        public String BDProjectProjectName
        {
            get { return _BDProjectProjectName; }
            set { _BDProjectProjectName = value; }
        }

        [DataMember]
        public String PaymentStatusName
        {
            get { return _PaymentStatusName; }
            set { _PaymentStatusName = value; }
        }

        [DataMember]
        public String PayableApprovalStatusName
        {
            get { return _PayableApprovalStatusName; }
            set { _PayableApprovalStatusName = value; }
        }

        [DataMember]
        public String AccountPaybleStatementDetailCategoryName
        {
            get { return _AccountPaybleStatementDetailCategoryName; }
            set { _AccountPaybleStatementDetailCategoryName = value; }
        }

        [DataMember]
        public String PayableClassificationName
        {
            get { return _PayableClassificationName; }
            set { _PayableClassificationName = value; }
        }

        [DataMember]
        public String MemberFullName
        {
            get { return _MemberFullName; }
            set { _MemberFullName = value; }
        }

        [DataMember]
        public String APPanelName
        {
            get { return _APPanelName; }
            set { _APPanelName = value; }
        }

        [DataMember]
        public String SupplierName
        {
            get { return _SupplierName; }
            set { _SupplierName = value; }
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
                return (PostPayableStatementDetailID <= 0);
            }
        }


        #endregion

        #region Constructor

        public ACCPostPayableStatementDetail_DetailedEntity() : base()
        {
        }

        #endregion

        #region Constant

        public const String FLD_NAME_PostPayableStatementDetailID = "PostPayableStatementDetailID";
        public const String FLD_NAME_PostPayableStatementID = "PostPayableStatementID";
        public const String FLD_NAME_ProjectCode = "ProjectCode";
        public const String FLD_NAME_WorkOrderNo = "WorkOrderNo";
        public const String FLD_NAME_WorkOrderAmount = "WorkOrderAmount";
        public const String FLD_NAME_WorkOrderDate = "WorkOrderDate";
        public const String FLD_NAME_PaidAmount = "PaidAmount";
        public const String FLD_NAME_SecurityMoney = "SecurityMoney";
        public const String FLD_NAME_TDSAmount = "TDSAmount";
        public const String FLD_NAME_PayableAgainstWorkOrder = "PayableAgainstWorkOrder";
        public const String FLD_NAME_ApprovedBillAmount = "ApprovedBillAmount";
        public const String FLD_NAME_NetPayableConsideringBillAndSecurity = "NetPayableConsideringBillAndSecurity";
        public const String FLD_NAME_PartyReconcile = "PartyReconcile";
        public const String FLD_NAME_RequisitionNo = "RequisitionNo";
        public const String FLD_NAME_RequisitionDate = "RequisitionDate";
        public const String FLD_NAME_BillNo = "BillNo";
        public const String FLD_NAME_BillDate = "BillDate";
        public const String FLD_NAME_Ref = "Ref";
        public const String FLD_NAME_ACCPostPayableStatementRef = "ACCPostPayableStatementRef";
        public const String FLD_NAME_ACCPrePayableStatementDetailPrePayableStatementID = "ACCPrePayableStatementDetailPrePayableStatementID";
        public const String FLD_NAME_BDProjectProjectName = "BDProjectProjectName";
        public const String FLD_NAME_PaymentStatusName = "PaymentStatusName";
        public const String FLD_NAME_PayableApprovalStatusName = "PayableApprovalStatusName";
        public const String FLD_NAME_AccountPaybleStatementDetailCategoryName = "AccountPaybleStatementDetailCategoryName";
        public const String FLD_NAME_PayableClassificationName = "PayableClassificationName";
        public const String FLD_NAME_MemberFullName = "MemberFullName";
        public const String FLD_NAME_APPanelName = "APPanelName";
        public const String FLD_NAME_SupplierName = "SupplierName";
        public const String FLD_NAME_RowNumber = "RowNumber";

        #endregion
    }
}
