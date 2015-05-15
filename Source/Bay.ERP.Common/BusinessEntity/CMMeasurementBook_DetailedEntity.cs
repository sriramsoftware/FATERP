// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 23-Jan-2013, 03:48:49




using System;
using System.Diagnostics;
using System.ServiceModel;
using System.Runtime.Serialization;
using System.Collections.Generic;
using System.Xml.Serialization;


namespace Bay.ERP.Common.BusinessEntities
{
    [Serializable]
    [DataContract(Name = "CMMeasurementBook_Detailed", Namespace = "http://www.e-p-m-s.com/types")]
    public partial class CMMeasurementBook_DetailedEntity : BaseEntity
    {
        #region Properties


        private Int64 _MeasurementBookID;
        private Int64 _ProjectID;
        private String _ProjectCode;
        private Int64 _VendorCategoryID;
        private Int64 _ReferenceID;
        private Int64? _BillID;
        private Int64? _WorkOrderID;
        private Int64 _ItemID;
        private DateTime _CreateDate;
        private String _ProjectName;
        private String _VendorCategoryName;
        private String _BillNo;
        private String _WorkOrderNo;
        private String _ItemName;
        private String _ResourceName;
        private Int64? _RowNumber;


        [DataMember]
        public Int64 MeasurementBookID
        {
            get { return _MeasurementBookID; }
            set { _MeasurementBookID = value; }
        }

        [DataMember]
        public Int64 ProjectID
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
        public Int64 VendorCategoryID
        {
            get { return _VendorCategoryID; }
            set { _VendorCategoryID = value; }
        }

        [DataMember]
        public Int64 ReferenceID
        {
            get { return _ReferenceID; }
            set { _ReferenceID = value; }
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
        public Int64 ItemID
        {
            get { return _ItemID; }
            set { _ItemID = value; }
        }

        [DataMember]
        public DateTime CreateDate
        {
            get { return _CreateDate; }
            set { _CreateDate = value; }
        }

        [DataMember]
        public String ProjectName
        {
            get { return _ProjectName; }
            set { _ProjectName = value; }
        }

        [DataMember]
        public String VendorCategoryName
        {
            get { return _VendorCategoryName; }
            set { _VendorCategoryName = value; }
        }

        [DataMember]
        public String BillNo
        {
            get { return _BillNo; }
            set { _BillNo = value; }
        }

        [DataMember]
        public String WorkOrderNo
        {
            get { return _WorkOrderNo; }
            set { _WorkOrderNo = value; }
        }

        [DataMember]
        public String ItemName
        {
            get { return _ItemName; }
            set { _ItemName = value; }
        }

        [DataMember]
        public String ResourceName
        {
            get { return _ResourceName; }
            set { _ResourceName = value; }
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
                return (MeasurementBookID <= 0);
            }
        }


        #endregion

        #region Constructor

        public CMMeasurementBook_DetailedEntity() : base()
        {
        }

        #endregion

        #region Constant

        public const String FLD_NAME_MeasurementBookID = "MeasurementBookID";
        public const String FLD_NAME_ProjectID = "ProjectID";
        public const String FLD_NAME_ProjectCode = "ProjectCode";
        public const String FLD_NAME_VendorCategoryID = "VendorCategoryID";
        public const String FLD_NAME_ReferenceID = "ReferenceID";
        public const String FLD_NAME_BillID = "BillID";
        public const String FLD_NAME_WorkOrderID = "WorkOrderID";
        public const String FLD_NAME_ItemID = "ItemID";
        public const String FLD_NAME_CreateDate = "CreateDate";
        public const String FLD_NAME_ProjectName = "ProjectName";
        public const String FLD_NAME_VendorCategoryName = "VendorCategoryName";
        public const String FLD_NAME_BillNo = "BillNo";
        public const String FLD_NAME_WorkOrderNo = "WorkOrderNo";
        public const String FLD_NAME_ItemName = "ItemName";
        public const String FLD_NAME_ResourceName = "ResourceName";
        public const String FLD_NAME_RowNumber = "RowNumber";

        #endregion
    }
}
