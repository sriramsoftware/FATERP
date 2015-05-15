// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 10-Dec-2013, 10:00:46




using System;
using System.Diagnostics;
using System.ServiceModel;
using System.Runtime.Serialization;
using System.Collections.Generic;
using System.Xml.Serialization;


namespace Bay.ERP.Common.BusinessEntities
{
    [Serializable]
    [DataContract(Name = "INVStoreIssueNoteItemMap_RPT", Namespace = "http://www.e-p-m-s.com/types")]
    public partial class INVStoreIssueNoteItemMap_RPTEntity : BaseEntity
    {
        #region Properties


        private Int64 _ItemID;
        private Int64? _IssuedFromStoreID;
        private Int64 _IssuedFromStoreUnitID;
        private Decimal? _IssuedQty;
        private Int64 _RequestedByEmployeeID;
        private Int64 _ProjectID;
        private Decimal? _RequestedQty;
        private String _ProjectCode;
        private String _ProjectName;
        private String _StoreName;
        private Decimal? _ReturnedQty;
        private Decimal? _ActualIssuedQty;
        private String _ItemName;
        private String _UnitName;


        [DataMember]
        public Int64 ItemID
        {
            get { return _ItemID; }
            set { _ItemID = value; }
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
        public Decimal? IssuedQty
        {
            get { return _IssuedQty; }
            set { _IssuedQty = value; }
        }

        [DataMember]
        public Int64 RequestedByEmployeeID
        {
            get { return _RequestedByEmployeeID; }
            set { _RequestedByEmployeeID = value; }
        }

        [DataMember]
        public Int64 ProjectID
        {
            get { return _ProjectID; }
            set { _ProjectID = value; }
        }

        [DataMember]
        public Decimal? RequestedQty
        {
            get { return _RequestedQty; }
            set { _RequestedQty = value; }
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
        public String StoreName
        {
            get { return _StoreName; }
            set { _StoreName = value; }
        }

        [DataMember]
        public Decimal? ReturnedQty
        {
            get { return _ReturnedQty; }
            set { _ReturnedQty = value; }
        }

        [DataMember]
        public Decimal? ActualIssuedQty
        {
            get { return _ActualIssuedQty; }
            set { _ActualIssuedQty = value; }
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

        [XmlIgnore()]
        public override bool IsNew
        {
            [DebuggerStepThrough()]
            get
            {
                return (ItemID <= 0);
            }
        }


        #endregion

        #region Constructor

        public INVStoreIssueNoteItemMap_RPTEntity() : base()
        {
        }

        #endregion

        #region Constant

        public const String FLD_NAME_ItemID = "ItemID";
        public const String FLD_NAME_IssuedFromStoreID = "IssuedFromStoreID";
        public const String FLD_NAME_IssuedFromStoreUnitID = "IssuedFromStoreUnitID";
        public const String FLD_NAME_IssuedQty = "IssuedQty";
        public const String FLD_NAME_RequestedByEmployeeID = "RequestedByEmployeeID";
        public const String FLD_NAME_ProjectID = "ProjectID";
        public const String FLD_NAME_RequestedQty = "RequestedQty";
        public const String FLD_NAME_ProjectCode = "ProjectCode";
        public const String FLD_NAME_ProjectName = "ProjectName";
        public const String FLD_NAME_StoreName = "StoreName";
        public const String FLD_NAME_ReturnedQty = "ReturnedQty";
        public const String FLD_NAME_ActualIssuedQty = "ActualIssuedQty";
        public const String FLD_NAME_ItemName = "ItemName";
        public const String FLD_NAME_UnitName = "UnitName";

        #endregion
    }
}
