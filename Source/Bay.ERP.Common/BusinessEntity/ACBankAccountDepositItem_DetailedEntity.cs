// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 17-Jul-2013, 11:47:45




using System;
using System.Diagnostics;
using System.ServiceModel;
using System.Runtime.Serialization;
using System.Collections.Generic;
using System.Xml.Serialization;


namespace Bay.ERP.Common.BusinessEntities
{
    [Serializable]
    [DataContract(Name = "ACBankAccountDepositItem_Detailed", Namespace = "http://www.e-p-m-s.com/types")]
    public partial class ACBankAccountDepositItem_DetailedEntity : BaseEntity
    {
        #region Properties


        private Int64 _BankAccountDepositItemID;
        private Int64 _BankAccountDepositID;
        private Int64 _AccountID;
        private Int64? _DimensionID;
        private Decimal _Amount;
        private String _Memo;
        private Int64? _ProjectID;
        private Int64? _RequisitionID;
        private Int64? _BillID;
        private Int64? _WorkOrderID;
        private Int64? _ProjectFloorID;
        private Int64? _ProjectFloorUnitID;
        private Int64? _ItemID;
        private String _BankAccountDepositName;
        private String _AccountName;
        private String _ACDimensionName;
        private String _WorkOrderNo;
        private String _ProjectCode;
        private String _ProjectName;
        private String _ProjectFloorUnitName;
        private String _RequisitionNo;
        private String _BillNo;
        private String _ProjectFloorName;
        private String _ItemName;
        private Int64? _RowNumber;


        [DataMember]
        public Int64 BankAccountDepositItemID
        {
            get { return _BankAccountDepositItemID; }
            set { _BankAccountDepositItemID = value; }
        }

        [DataMember]
        public Int64 BankAccountDepositID
        {
            get { return _BankAccountDepositID; }
            set { _BankAccountDepositID = value; }
        }

        [DataMember]
        public Int64 AccountID
        {
            get { return _AccountID; }
            set { _AccountID = value; }
        }

        [DataMember]
        public Int64? DimensionID
        {
            get { return _DimensionID; }
            set { _DimensionID = value; }
        }

        [DataMember]
        public Decimal Amount
        {
            get { return _Amount; }
            set { _Amount = value; }
        }

        [DataMember]
        public String Memo
        {
            get { return _Memo; }
            set { _Memo = value; }
        }

        [DataMember]
        public Int64? ProjectID
        {
            get { return _ProjectID; }
            set { _ProjectID = value; }
        }

        [DataMember]
        public Int64? RequisitionID
        {
            get { return _RequisitionID; }
            set { _RequisitionID = value; }
        }

        [DataMember]
        public Int64? BillID
        {
            get { return _BillID; }
            set { _BillID = value; }
        }

        [DataMember]
        public Int64? WorkOrderID
        {
            get { return _WorkOrderID; }
            set { _WorkOrderID = value; }
        }

        [DataMember]
        public Int64? ProjectFloorID
        {
            get { return _ProjectFloorID; }
            set { _ProjectFloorID = value; }
        }

        [DataMember]
        public Int64? ProjectFloorUnitID
        {
            get { return _ProjectFloorUnitID; }
            set { _ProjectFloorUnitID = value; }
        }

        [DataMember]
        public Int64? ItemID
        {
            get { return _ItemID; }
            set { _ItemID = value; }
        }

        [DataMember]
        public String BankAccountDepositName
        {
            get { return _BankAccountDepositName; }
            set { _BankAccountDepositName = value; }
        }

        [DataMember]
        public String AccountName
        {
            get { return _AccountName; }
            set { _AccountName = value; }
        }

        [DataMember]
        public String ACDimensionName
        {
            get { return _ACDimensionName; }
            set { _ACDimensionName = value; }
        }

        [DataMember]
        public String WorkOrderNo
        {
            get { return _WorkOrderNo; }
            set { _WorkOrderNo = value; }
        }

        [DataMember]
        public String ProjectCode
        {
            get { return _ProjectCode; }
            set { _ProjectCode = value; }
        }

        [DataMember]
        public String ProjectName
        {
            get { return _ProjectName; }
            set { _ProjectName = value; }
        }

        [DataMember]
        public String ProjectFloorUnitName
        {
            get { return _ProjectFloorUnitName; }
            set { _ProjectFloorUnitName = value; }
        }

        [DataMember]
        public String RequisitionNo
        {
            get { return _RequisitionNo; }
            set { _RequisitionNo = value; }
        }

        [DataMember]
        public String BillNo
        {
            get { return _BillNo; }
            set { _BillNo = value; }
        }

        [DataMember]
        public String ProjectFloorName
        {
            get { return _ProjectFloorName; }
            set { _ProjectFloorName = value; }
        }

        [DataMember]
        public String ItemName
        {
            get { return _ItemName; }
            set { _ItemName = value; }
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
                return (BankAccountDepositItemID <= 0);
            }
        }


        #endregion

        #region Constructor

        public ACBankAccountDepositItem_DetailedEntity() : base()
        {
        }

        #endregion

        #region Constant

        public const String FLD_NAME_BankAccountDepositItemID = "BankAccountDepositItemID";
        public const String FLD_NAME_BankAccountDepositID = "BankAccountDepositID";
        public const String FLD_NAME_AccountID = "AccountID";
        public const String FLD_NAME_DimensionID = "DimensionID";
        public const String FLD_NAME_Amount = "Amount";
        public const String FLD_NAME_Memo = "Memo";
        public const String FLD_NAME_ProjectID = "ProjectID";
        public const String FLD_NAME_RequisitionID = "RequisitionID";
        public const String FLD_NAME_BillID = "BillID";
        public const String FLD_NAME_WorkOrderID = "WorkOrderID";
        public const String FLD_NAME_ProjectFloorID = "ProjectFloorID";
        public const String FLD_NAME_ProjectFloorUnitID = "ProjectFloorUnitID";
        public const String FLD_NAME_ItemID = "ItemID";
        public const String FLD_NAME_BankAccountDepositName = "BankAccountDepositName";
        public const String FLD_NAME_AccountName = "AccountName";
        public const String FLD_NAME_ACDimensionName = "ACDimensionName";
        public const String FLD_NAME_WorkOrderNo = "WorkOrderNo";
        public const String FLD_NAME_ProjectCode = "ProjectCode";
        public const String FLD_NAME_ProjectName = "ProjectName";
        public const String FLD_NAME_ProjectFloorUnitName = "ProjectFloorUnitName";
        public const String FLD_NAME_RequisitionNo = "RequisitionNo";
        public const String FLD_NAME_BillNo = "BillNo";
        public const String FLD_NAME_ProjectFloorName = "ProjectFloorName";
        public const String FLD_NAME_ItemName = "ItemName";
        public const String FLD_NAME_RowNumber = "RowNumber";

        #endregion
    }
}