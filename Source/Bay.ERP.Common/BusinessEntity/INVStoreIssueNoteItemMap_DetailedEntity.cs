// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 18-Dec-2012, 11:36:43




using System;
using System.Diagnostics;
using System.ServiceModel;
using System.Runtime.Serialization;
using System.Collections.Generic;
using System.Xml.Serialization;


namespace Bay.ERP.Common.BusinessEntities
{
    [Serializable]
    [DataContract(Name = "INVStoreIssueNoteItemMap_Detailed", Namespace = "http://www.e-p-m-s.com/types")]
    public partial class INVStoreIssueNoteItemMap_DetailedEntity : BaseEntity
    {
        #region Properties


        private Int64 _StoreIssueNoteItemMapID;
        private Int64 _StoreIssueNoteID;
        private Int64 _ItemID;
        private String _FolioNo;
        private Decimal _RequestQty;
        private Decimal? _IssueQty;
        private Int64? _IssuedFromStoreID;
        private Int64 _IssuedFromStoreUnitID;
        private DateTime? _ReceivedDate;
        private Int64? _ReceivedByEmployeeID;
        private Decimal? _ReturnQty;
        private DateTime? _ReturnDate;
        private Int64? _ReturnToStoreID;
        private Int64? _ReturnToStoreUnitID;
        private Int64? _ReturnedByEmployeeID;
        private Decimal? _ActualUse;
        private Decimal? _Amount;
        private String _PurposeOfWorks;
        private Int64? _INVStoreIssueNoteProjectID;
        private String _MDItemItemName;
        private String _INVStoreName;
        private Int64? _INVStoreUnitStoreID;
        private String _ReceivedByMemberFullName;
        private String _ReturnedByMemberFullName;
        private Int64? _RowNumber;


        [DataMember]
        public Int64 StoreIssueNoteItemMapID
        {
            get { return _StoreIssueNoteItemMapID; }
            set { _StoreIssueNoteItemMapID = value; }
        }

        [DataMember]
        public Int64 StoreIssueNoteID
        {
            get { return _StoreIssueNoteID; }
            set { _StoreIssueNoteID = value; }
        }

        [DataMember]
        public Int64 ItemID
        {
            get { return _ItemID; }
            set { _ItemID = value; }
        }

        [DataMember]
        public String FolioNo
        {
            get { return _FolioNo; }
            set { _FolioNo = value; }
        }

        [DataMember]
        public Decimal RequestQty
        {
            get { return _RequestQty; }
            set { _RequestQty = value; }
        }

        [DataMember]
        public Decimal? IssueQty
        {
            get { return _IssueQty; }
            set { _IssueQty = value; }
        }

        [DataMember]
        public Int64? IssuedFromStoreID
        {
            get { return _IssuedFromStoreID; }
            set { _IssuedFromStoreID = value; }
        }

        [DataMember]
        public Int64 IssuedFromStoreUnitID
        {
            get { return _IssuedFromStoreUnitID; }
            set { _IssuedFromStoreUnitID = value; }
        }

        [DataMember]
        public DateTime? ReceivedDate
        {
            get { return _ReceivedDate; }
            set { _ReceivedDate = value; }
        }

        [DataMember]
        public Int64? ReceivedByEmployeeID
        {
            get { return _ReceivedByEmployeeID; }
            set { _ReceivedByEmployeeID = value; }
        }

        [DataMember]
        public Decimal? ReturnQty
        {
            get { return _ReturnQty; }
            set { _ReturnQty = value; }
        }

        [DataMember]
        public DateTime? ReturnDate
        {
            get { return _ReturnDate; }
            set { _ReturnDate = value; }
        }

        [DataMember]
        public Int64? ReturnToStoreID
        {
            get { return _ReturnToStoreID; }
            set { _ReturnToStoreID = value; }
        }

        [DataMember]
        public Int64? ReturnToStoreUnitID
        {
            get { return _ReturnToStoreUnitID; }
            set { _ReturnToStoreUnitID = value; }
        }

        [DataMember]
        public Int64? ReturnedByEmployeeID
        {
            get { return _ReturnedByEmployeeID; }
            set { _ReturnedByEmployeeID = value; }
        }

        [DataMember]
        public Decimal? ActualUse
        {
            get { return _ActualUse; }
            set { _ActualUse = value; }
        }

        [DataMember]
        public Decimal? Amount
        {
            get { return _Amount; }
            set { _Amount = value; }
        }

        [DataMember]
        public String PurposeOfWorks
        {
            get { return _PurposeOfWorks; }
            set { _PurposeOfWorks = value; }
        }

        [DataMember]
        public Int64? INVStoreIssueNoteProjectID
        {
            get { return _INVStoreIssueNoteProjectID; }
            set { _INVStoreIssueNoteProjectID = value; }
        }

        [DataMember]
        public String MDItemItemName
        {
            get { return _MDItemItemName; }
            set { _MDItemItemName = value; }
        }

        [DataMember]
        public String INVStoreName
        {
            get { return _INVStoreName; }
            set { _INVStoreName = value; }
        }

        [DataMember]
        public Int64? INVStoreUnitStoreID
        {
            get { return _INVStoreUnitStoreID; }
            set { _INVStoreUnitStoreID = value; }
        }

        [DataMember]
        public String ReceivedByMemberFullName
        {
            get { return _ReceivedByMemberFullName; }
            set { _ReceivedByMemberFullName = value; }
        }

        [DataMember]
        public String ReturnedByMemberFullName
        {
            get { return _ReturnedByMemberFullName; }
            set { _ReturnedByMemberFullName = value; }
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
                return (StoreIssueNoteItemMapID <= 0);
            }
        }


        #endregion

        #region Constructor

        public INVStoreIssueNoteItemMap_DetailedEntity() : base()
        {
        }

        #endregion

        #region Constant

        public const String FLD_NAME_StoreIssueNoteItemMapID = "StoreIssueNoteItemMapID";
        public const String FLD_NAME_StoreIssueNoteID = "StoreIssueNoteID";
        public const String FLD_NAME_ItemID = "ItemID";
        public const String FLD_NAME_FolioNo = "FolioNo";
        public const String FLD_NAME_RequestQty = "RequestQty";
        public const String FLD_NAME_IssueQty = "IssueQty";
        public const String FLD_NAME_IssuedFromStoreID = "IssuedFromStoreID";
        public const String FLD_NAME_IssuedFromStoreUnitID = "IssuedFromStoreUnitID";
        public const String FLD_NAME_ReceivedDate = "ReceivedDate";
        public const String FLD_NAME_ReceivedByEmployeeID = "ReceivedByEmployeeID";
        public const String FLD_NAME_ReturnQty = "ReturnQty";
        public const String FLD_NAME_ReturnDate = "ReturnDate";
        public const String FLD_NAME_ReturnToStoreID = "ReturnToStoreID";
        public const String FLD_NAME_ReturnToStoreUnitID = "ReturnToStoreUnitID";
        public const String FLD_NAME_ReturnedByEmployeeID = "ReturnedByEmployeeID";
        public const String FLD_NAME_ActualUse = "ActualUse";
        public const String FLD_NAME_Amount = "Amount";
        public const String FLD_NAME_PurposeOfWorks = "PurposeOfWorks";
        public const String FLD_NAME_INVStoreIssueNoteProjectID = "INVStoreIssueNoteProjectID";
        public const String FLD_NAME_MDItemItemName = "MDItemItemName";
        public const String FLD_NAME_INVStoreName = "INVStoreName";
        public const String FLD_NAME_INVStoreUnitStoreID = "INVStoreUnitStoreID";
        public const String FLD_NAME_ReceivedByMemberFullName = "ReceivedByMemberFullName";
        public const String FLD_NAME_ReturnedByMemberFullName = "ReturnedByMemberFullName";
        public const String FLD_NAME_RowNumber = "RowNumber";

        #endregion
    }
}
