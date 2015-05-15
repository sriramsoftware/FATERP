// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 22-Sep-2013, 04:06:30




using System;
using System.Diagnostics;
using System.ServiceModel;
using System.Runtime.Serialization;
using System.Collections.Generic;
using System.Xml.Serialization;


namespace Bay.ERP.Common.BusinessEntities
{
    [Serializable]
    [DataContract(Name = "INVTransaction_Custom", Namespace = "http://www.e-p-m-s.com/types")]
    public partial class INVTransaction_CustomEntity : BaseEntity
    {
        #region Properties


        private Int64 _TransferID;
        private String _TRFNo;
        private Int64 _ItemID;
        private Int64 _TransferFromStoreID;
        private Int64 _TransferToStoreID;
        private String _FromProjectName;
        private String _FromStoreName;
        private String _ToProjectName;
        private String _ToStoreName;
        private String _ItemName;
        private String _UnitName;
        private DateTime _RequestDate;
        private Decimal? _RequestQty;
        private Decimal? _SINRequestedQty;
        private Decimal? _SINIssueQty;
        private Int64? _SINTransferID;
        private Int64? _SINItemID;
        private Int64? _SINFromStoreID;
        private Int64? _SINToStoreID;


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
        public Int64 ItemID
        {
            get { return _ItemID; }
            set { _ItemID = value; }
        }

        [DataMember]
        public Int64 TransferFromStoreID
        {
            get { return _TransferFromStoreID; }
            set { _TransferFromStoreID = value; }
        }

        [DataMember]
        public Int64 TransferToStoreID
        {
            get { return _TransferToStoreID; }
            set { _TransferToStoreID = value; }
        }

        [DataMember]
        public String FromProjectName
        {
            get { return _FromProjectName; }
            set { _FromProjectName = value; }
        }

        [DataMember]
        public String FromStoreName
        {
            get { return _FromStoreName; }
            set { _FromStoreName = value; }
        }

        [DataMember]
        public String ToProjectName
        {
            get { return _ToProjectName; }
            set { _ToProjectName = value; }
        }

        [DataMember]
        public String ToStoreName
        {
            get { return _ToStoreName; }
            set { _ToStoreName = value; }
        }

        [DataMember]
        public String ItemName
        {
            get { return _ItemName; }
            set { _ItemName = value; }
        }

        [DataMember]
        public String UnitName
        {
            get { return _UnitName; }
            set { _UnitName = value; }
        }

        [DataMember]
        public DateTime RequestDate
        {
            get { return _RequestDate; }
            set { _RequestDate = value; }
        }

        [DataMember]
        public Decimal? RequestQty
        {
            get { return _RequestQty; }
            set { _RequestQty = value; }
        }

        [DataMember]
        public Decimal? SINRequestedQty
        {
            get { return _SINRequestedQty; }
            set { _SINRequestedQty = value; }
        }

        [DataMember]
        public Decimal? SINIssueQty
        {
            get { return _SINIssueQty; }
            set { _SINIssueQty = value; }
        }

        [DataMember]
        public Int64? SINTransferID
        {
            get { return _SINTransferID; }
            set { _SINTransferID = value; }
        }

        [DataMember]
        public Int64? SINItemID
        {
            get { return _SINItemID; }
            set { _SINItemID = value; }
        }

        [DataMember]
        public Int64? SINFromStoreID
        {
            get { return _SINFromStoreID; }
            set { _SINFromStoreID = value; }
        }

        [DataMember]
        public Int64? SINToStoreID
        {
            get { return _SINToStoreID; }
            set { _SINToStoreID = value; }
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

        public INVTransaction_CustomEntity() : base()
        {
        }

        #endregion

        #region Constant

        public const String FLD_NAME_TransferID = "TransferID";
        public const String FLD_NAME_TRFNo = "TRFNo";
        public const String FLD_NAME_ItemID = "ItemID";
        public const String FLD_NAME_TransferFromStoreID = "TransferFromStoreID";
        public const String FLD_NAME_TransferToStoreID = "TransferToStoreID";
        public const String FLD_NAME_FromProjectName = "FromProjectName";
        public const String FLD_NAME_FromStoreName = "FromStoreName";
        public const String FLD_NAME_ToProjectName = "ToProjectName";
        public const String FLD_NAME_ToStoreName = "ToStoreName";
        public const String FLD_NAME_ItemName = "ItemName";
        public const String FLD_NAME_UnitName = "UnitName";
        public const String FLD_NAME_RequestDate = "RequestDate";
        public const String FLD_NAME_RequestQty = "RequestQty";
        public const String FLD_NAME_SINRequestedQty = "SINRequestedQty";
        public const String FLD_NAME_SINIssueQty = "SINIssueQty";
        public const String FLD_NAME_SINTransferID = "SINTransferID";
        public const String FLD_NAME_SINItemID = "SINItemID";
        public const String FLD_NAME_SINFromStoreID = "SINFromStoreID";
        public const String FLD_NAME_SINToStoreID = "SINToStoreID";

        #endregion
    }
}
