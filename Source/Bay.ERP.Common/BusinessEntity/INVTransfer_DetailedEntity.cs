// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 31-Dec-2012, 03:31:40




using System;
using System.Diagnostics;
using System.ServiceModel;
using System.Runtime.Serialization;
using System.Collections.Generic;
using System.Xml.Serialization;


namespace Bay.ERP.Common.BusinessEntities
{
    [Serializable]
    [DataContract(Name = "INVTransfer_Detailed", Namespace = "http://www.e-p-m-s.com/types")]
    public partial class INVTransfer_DetailedEntity : BaseEntity
    {
        #region Properties


        private Int64 _TransferID;
        private String _TRFNo;
        private Int64 _RequestedByEmployeeID;
        private DateTime _RequestDate;
        private Int64 _TransferFromStoreID;
        private Int64 _TransferFromStoreUnitID;
        private Int64 _TransferToStoreID;
        private Int64 _TransferToStoreUnitID;
        private String _Remarks;
        private Int64 _InventoryTransferStatusID;
        private Int64? _HREmployeeMemberID;
        private String _TransferFromStore;
        private String _TransferFromStoreUnit;
        private String _TransferToStoreName;
        private String _TransferToUnit;
        private String _MDInventoryTransferStatusName;
        private Int64? _RowNumber;


        [DataMember]
        public Int64 TransferID
        {
            get { return _TransferID; }
            set { _TransferID = value; }
        }

        [DataMember]
        public String TRFNo
        {
            get { return _TRFNo; }
            set { _TRFNo = value; }
        }

        [DataMember]
        public Int64 RequestedByEmployeeID
        {
            get { return _RequestedByEmployeeID; }
            set { _RequestedByEmployeeID = value; }
        }

        [DataMember]
        public DateTime RequestDate
        {
            get { return _RequestDate; }
            set { _RequestDate = value; }
        }

        [DataMember]
        public Int64 TransferFromStoreID
        {
            get { return _TransferFromStoreID; }
            set { _TransferFromStoreID = value; }
        }

        [DataMember]
        public Int64 TransferFromStoreUnitID
        {
            get { return _TransferFromStoreUnitID; }
            set { _TransferFromStoreUnitID = value; }
        }

        [DataMember]
        public Int64 TransferToStoreID
        {
            get { return _TransferToStoreID; }
            set { _TransferToStoreID = value; }
        }

        [DataMember]
        public Int64 TransferToStoreUnitID
        {
            get { return _TransferToStoreUnitID; }
            set { _TransferToStoreUnitID = value; }
        }

        [DataMember]
        public String Remarks
        {
            get { return _Remarks; }
            set { _Remarks = value; }
        }

        [DataMember]
        public Int64 InventoryTransferStatusID
        {
            get { return _InventoryTransferStatusID; }
            set { _InventoryTransferStatusID = value; }
        }

        [DataMember]
        public Int64? HREmployeeMemberID
        {
            get { return _HREmployeeMemberID; }
            set { _HREmployeeMemberID = value; }
        }

        [DataMember]
        public String TransferFromStore
        {
            get { return _TransferFromStore; }
            set { _TransferFromStore = value; }
        }

        [DataMember]
        public String TransferFromStoreUnit
        {
            get { return _TransferFromStoreUnit; }
            set { _TransferFromStoreUnit = value; }
        }

        [DataMember]
        public String TransferToStoreName
        {
            get { return _TransferToStoreName; }
            set { _TransferToStoreName = value; }
        }

        [DataMember]
        public String TransferToUnit
        {
            get { return _TransferToUnit; }
            set { _TransferToUnit = value; }
        }

        [DataMember]
        public String MDInventoryTransferStatusName
        {
            get { return _MDInventoryTransferStatusName; }
            set { _MDInventoryTransferStatusName = value; }
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
                return (TransferID <= 0);
            }
        }


        #endregion

        #region Constructor

        public INVTransfer_DetailedEntity() : base()
        {
        }

        #endregion

        #region Constant

        public const String FLD_NAME_TransferID = "TransferID";
        public const String FLD_NAME_TRFNo = "TRFNo";
        public const String FLD_NAME_RequestedByEmployeeID = "RequestedByEmployeeID";
        public const String FLD_NAME_RequestDate = "RequestDate";
        public const String FLD_NAME_TransferFromStoreID = "TransferFromStoreID";
        public const String FLD_NAME_TransferFromStoreUnitID = "TransferFromStoreUnitID";
        public const String FLD_NAME_TransferToStoreID = "TransferToStoreID";
        public const String FLD_NAME_TransferToStoreUnitID = "TransferToStoreUnitID";
        public const String FLD_NAME_Remarks = "Remarks";
        public const String FLD_NAME_InventoryTransferStatusID = "InventoryTransferStatusID";
        public const String FLD_NAME_HREmployeeMemberID = "HREmployeeMemberID";
        public const String FLD_NAME_TransferFromStore = "TransferFromStore";
        public const String FLD_NAME_TransferFromStoreUnit = "TransferFromStoreUnit";
        public const String FLD_NAME_TransferToStoreName = "TransferToStoreName";
        public const String FLD_NAME_TransferToUnit = "TransferToUnit";
        public const String FLD_NAME_MDInventoryTransferStatusName = "MDInventoryTransferStatusName";
        public const String FLD_NAME_RowNumber = "RowNumber";

        #endregion
    }
}
