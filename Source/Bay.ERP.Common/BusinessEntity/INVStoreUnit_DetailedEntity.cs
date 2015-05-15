// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 18-Dec-2012, 10:49:09




using System;
using System.Diagnostics;
using System.ServiceModel;
using System.Runtime.Serialization;
using System.Collections.Generic;
using System.Xml.Serialization;


namespace Bay.ERP.Common.BusinessEntities
{
    [Serializable]
    [DataContract(Name = "INVStoreUnit_Detailed", Namespace = "http://www.e-p-m-s.com/types")]
    public partial class INVStoreUnit_DetailedEntity : BaseEntity
    {
        #region Properties


        private Int64 _StoreUnitID;
        private Int64 _StoreID;
        private Int64 _InventoryStoreUnitTypeID;
        private String _UnitTrackNumber;
        private String _StoreUnitLocation;
        private String _Description;
        private DateTime _CreateDate;
        private Boolean _IsRemoved;
        private Boolean _IsDefault;
        private Int64? _ParentStoreUnitID;
        private String _StoreName;
        private String _StoreTrackNumber;
        private String _StoreLocation;
        private String _ProjectName;
        private String _DepartmentName;
        private String _MemberFullName;
        private String _MDInventoryStoreUnitName;
        private Int64 _INVStoreUnitStoreID;
        private Int64? _RowNumber;


        [DataMember]
        public Int64 StoreUnitID
        {
            get { return _StoreUnitID; }
            set { _StoreUnitID = value; }
        }

        [DataMember]
        public Int64 StoreID
        {
            get { return _StoreID; }
            set { _StoreID = value; }
        }

        [DataMember]
        public Int64 InventoryStoreUnitTypeID
        {
            get { return _InventoryStoreUnitTypeID; }
            set { _InventoryStoreUnitTypeID = value; }
        }

        [DataMember]
        public String UnitTrackNumber
        {
            get { return _UnitTrackNumber; }
            set { _UnitTrackNumber = value; }
        }

        [DataMember]
        public String StoreUnitLocation
        {
            get { return _StoreUnitLocation; }
            set { _StoreUnitLocation = value; }
        }

        [DataMember]
        public String Description
        {
            get { return _Description; }
            set { _Description = value; }
        }

        [DataMember]
        public DateTime CreateDate
        {
            get { return _CreateDate; }
            set { _CreateDate = value; }
        }

        [DataMember]
        public Boolean IsRemoved
        {
            get { return _IsRemoved; }
            set { _IsRemoved = value; }
        }

        [DataMember]
        public Boolean IsDefault
        {
            get { return _IsDefault; }
            set { _IsDefault = value; }
        }

        [DataMember]
        public Int64? ParentStoreUnitID
        {
            get { return _ParentStoreUnitID; }
            set { _ParentStoreUnitID = value; }
        }

        [DataMember]
        public String StoreName
        {
            get { return _StoreName; }
            set { _StoreName = value; }
        }

        [DataMember]
        public String StoreTrackNumber
        {
            get { return _StoreTrackNumber; }
            set { _StoreTrackNumber = value; }
        }

        [DataMember]
        public String StoreLocation
        {
            get { return _StoreLocation; }
            set { _StoreLocation = value; }
        }

        [DataMember]
        public String ProjectName
        {
            get { return _ProjectName; }
            set { _ProjectName = value; }
        }

        [DataMember]
        public String DepartmentName
        {
            get { return _DepartmentName; }
            set { _DepartmentName = value; }
        }

        [DataMember]
        public String MemberFullName
        {
            get { return _MemberFullName; }
            set { _MemberFullName = value; }
        }

        [DataMember]
        public String MDInventoryStoreUnitName
        {
            get { return _MDInventoryStoreUnitName; }
            set { _MDInventoryStoreUnitName = value; }
        }

        [DataMember]
        public Int64 INVStoreUnitStoreID
        {
            get { return _INVStoreUnitStoreID; }
            set { _INVStoreUnitStoreID = value; }
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
                return (StoreUnitID <= 0);
            }
        }


        #endregion

        #region Constructor

        public INVStoreUnit_DetailedEntity() : base()
        {
        }

        #endregion

        #region Constant

        public const String FLD_NAME_StoreUnitID = "StoreUnitID";
        public const String FLD_NAME_StoreID = "StoreID";
        public const String FLD_NAME_InventoryStoreUnitTypeID = "InventoryStoreUnitTypeID";
        public const String FLD_NAME_UnitTrackNumber = "UnitTrackNumber";
        public const String FLD_NAME_StoreUnitLocation = "StoreUnitLocation";
        public const String FLD_NAME_Description = "Description";
        public const String FLD_NAME_CreateDate = "CreateDate";
        public const String FLD_NAME_IsRemoved = "IsRemoved";
        public const String FLD_NAME_IsDefault = "IsDefault";
        public const String FLD_NAME_ParentStoreUnitID = "ParentStoreUnitID";
        public const String FLD_NAME_StoreName = "StoreName";
        public const String FLD_NAME_StoreTrackNumber = "StoreTrackNumber";
        public const String FLD_NAME_StoreLocation = "StoreLocation";
        public const String FLD_NAME_ProjectName = "ProjectName";
        public const String FLD_NAME_DepartmentName = "DepartmentName";
        public const String FLD_NAME_MemberFullName = "MemberFullName";
        public const String FLD_NAME_MDInventoryStoreUnitName = "MDInventoryStoreUnitName";
        public const String FLD_NAME_INVStoreUnitStoreID = "INVStoreUnitStoreID";
        public const String FLD_NAME_RowNumber = "RowNumber";

        #endregion
    }
}
