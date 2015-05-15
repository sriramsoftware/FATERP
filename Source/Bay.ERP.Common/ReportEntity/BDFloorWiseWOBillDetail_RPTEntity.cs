// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 29-Aug-2013, 01:19:26




using System;
using System.Diagnostics;
using System.ServiceModel;
using System.Runtime.Serialization;
using System.Collections.Generic;
using System.Xml.Serialization;


namespace Bay.ERP.Common.BusinessEntities
{
    [Serializable]
    [DataContract(Name = "BDFloorWiseWOBillDetail_RPT", Namespace = "http://www.e-p-m-s.com/types")]
    public partial class BDFloorWiseWOBillDetail_RPTEntity : BaseEntity
    {
        #region Properties


        private Int64? _ProjectID;
        private String _ProjectCode;
        private String _ProjectName;
        private String _FloorName;
        private String _ProjectFloorUnitName;
        private Int64? _ProjectFloorID;
        private Int64? _ProjectFloorUnitID;
        private Decimal? _TotalWOValue;
        private Decimal? _FloorWiseWOValue;
        private Int64 _WorkOrderStatusID;
        private Decimal? _TotalFloorBillAmount;
        private Int64? _BillApprovalStatusID;


        [DataMember]
        public Int64? ProjectID
        {
            get { return _ProjectID; }
            set { _ProjectID = value; }
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
        public String FloorName
        {
            get { return _FloorName; }
            set { _FloorName = value; }
        }

        [DataMember]
        public String ProjectFloorUnitName
        {
            get { return _ProjectFloorUnitName; }
            set { _ProjectFloorUnitName = value; }
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
        public Decimal? TotalWOValue
        {
            get { return _TotalWOValue; }
            set { _TotalWOValue = value; }
        }

        [DataMember]
        public Decimal? FloorWiseWOValue
        {
            get { return _FloorWiseWOValue; }
            set { _FloorWiseWOValue = value; }
        }

        [DataMember]
        public Int64 WorkOrderStatusID
        {
            get { return _WorkOrderStatusID; }
            set { _WorkOrderStatusID = value; }
        }

        [DataMember]
        public Decimal? TotalFloorBillAmount
        {
            get { return _TotalFloorBillAmount; }
            set { _TotalFloorBillAmount = value; }
        }

        [DataMember]
        public Int64? BillApprovalStatusID
        {
            get { return _BillApprovalStatusID; }
            set { _BillApprovalStatusID = value; }
        }

        [XmlIgnore()]
        public override bool IsNew
        {
            [DebuggerStepThrough()]
            get
            {
                return (ProjectID <= 0);
            }
        }


        #endregion

        #region Constructor

        public BDFloorWiseWOBillDetail_RPTEntity() : base()
        {
        }

        #endregion

        #region Constant

        public const String FLD_NAME_ProjectID = "ProjectID";
        public const String FLD_NAME_ProjectCode = "ProjectCode";
        public const String FLD_NAME_ProjectName = "ProjectName";
        public const String FLD_NAME_FloorName = "FloorName";
        public const String FLD_NAME_ProjectFloorUnitName = "ProjectFloorUnitName";
        public const String FLD_NAME_ProjectFloorID = "ProjectFloorID";
        public const String FLD_NAME_ProjectFloorUnitID = "ProjectFloorUnitID";
        public const String FLD_NAME_TotalWOValue = "TotalWOValue";
        public const String FLD_NAME_FloorWiseWOValue = "FloorWiseWOValue";
        public const String FLD_NAME_WorkOrderStatusID = "WorkOrderStatusID";
        public const String FLD_NAME_TotalFloorBillAmount = "TotalFloorBillAmount";
        public const String FLD_NAME_BillApprovalStatusID = "BillApprovalStatusID";

        #endregion
    }
}
