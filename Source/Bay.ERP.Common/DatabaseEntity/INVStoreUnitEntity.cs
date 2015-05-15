// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 17-Dec-2012, 02:43:44




using System;
using System.Diagnostics;
using System.ServiceModel;
using System.Runtime.Serialization;
using System.Collections.Generic;
using System.Xml.Serialization;


namespace Bay.ERP.Common.BusinessEntities
{
    [Serializable]
    [DataContract(Name = "INVStoreUnit", Namespace = "http://www.e-p-m-s.com/types")]
    public partial class INVStoreUnitEntity : BaseEntity
    {
        #region Properties


        private Int64 _StoreUnitID;
        private Int64 _StoreID;
        private Int64 _InventoryStoreUnitTypeID;
        private String _UnitTrackNumber;
        private String _Location;
        private String _Description;
        private DateTime _CreateDate;
        private Boolean _IsRemoved;
        private Int64? _ParentStoreUnitID;
        private Boolean _IsDefault;


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
        public String Location
        {
            get { return _Location; }
            set { _Location = value; }
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
        public Int64? ParentStoreUnitID
        {
            get { return _ParentStoreUnitID; }
            set { _ParentStoreUnitID = value; }
        }

        [DataMember]
        public Boolean IsDefault
        {
            get { return _IsDefault; }
            set { _IsDefault = value; }
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

        public INVStoreUnitEntity() : base()
        {
        }

        #endregion

        #region Constant

        public const String FLD_NAME_StoreUnitID = "StoreUnitID";
        public const String FLD_NAME_StoreID = "StoreID";
        public const String FLD_NAME_InventoryStoreUnitTypeID = "InventoryStoreUnitTypeID";
        public const String FLD_NAME_UnitTrackNumber = "UnitTrackNumber";
        public const String FLD_NAME_Location = "Location";
        public const String FLD_NAME_Description = "Description";
        public const String FLD_NAME_CreateDate = "CreateDate";
        public const String FLD_NAME_IsRemoved = "IsRemoved";
        public const String FLD_NAME_ParentStoreUnitID = "ParentStoreUnitID";
        public const String FLD_NAME_IsDefault = "IsDefault";

        #endregion
    }
}
