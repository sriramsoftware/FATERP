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
    [DataContract(Name = "INVStore_Detailed", Namespace = "http://www.e-p-m-s.com/types")]
    public partial class INVStore_DetailedEntity : BaseEntity
    {
        #region Properties


        private Int64 _StoreID;
        private Int64 _ProjectID;
        private Int64 _DepartmentID;
        private Int64 _StoreInChargeEmployeeID;
        private String _Name;
        private String _StoreTrackNumber;
        private String _Location;
        private String _Description;
        private DateTime _CreateDate;
        private Boolean _IsRemoved;
        private Boolean _IsDefault;
        private String _ProjectName;
        private String _DepartmentName;
        private String _MemberFullName;
        private Int64? _RowNumber;


        [DataMember]
        public Int64 StoreID
        {
            get { return _StoreID; }
            set { _StoreID = value; }
        }

        [DataMember]
        public Int64 ProjectID
        {
            get { return _ProjectID; }
            set { _ProjectID = value; }
        }

        [DataMember]
        public Int64 DepartmentID
        {
            get { return _DepartmentID; }
            set { _DepartmentID = value; }
        }

        [DataMember]
        public Int64 StoreInChargeEmployeeID
        {
            get { return _StoreInChargeEmployeeID; }
            set { _StoreInChargeEmployeeID = value; }
        }

        [DataMember]
        public String Name
        {
            get { return _Name; }
            set { _Name = value; }
        }

        [DataMember]
        public String StoreTrackNumber
        {
            get { return _StoreTrackNumber; }
            set { _StoreTrackNumber = value; }
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
        public Boolean IsDefault
        {
            get { return _IsDefault; }
            set { _IsDefault = value; }
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
                return (StoreID <= 0);
            }
        }


        #endregion

        #region Constructor

        public INVStore_DetailedEntity() : base()
        {
        }

        #endregion

        #region Constant

        public const String FLD_NAME_StoreID = "StoreID";
        public const String FLD_NAME_ProjectID = "ProjectID";
        public const String FLD_NAME_DepartmentID = "DepartmentID";
        public const String FLD_NAME_StoreInChargeEmployeeID = "StoreInChargeEmployeeID";
        public const String FLD_NAME_Name = "Name";
        public const String FLD_NAME_StoreTrackNumber = "StoreTrackNumber";
        public const String FLD_NAME_Location = "Location";
        public const String FLD_NAME_Description = "Description";
        public const String FLD_NAME_CreateDate = "CreateDate";
        public const String FLD_NAME_IsRemoved = "IsRemoved";
        public const String FLD_NAME_IsDefault = "IsDefault";
        public const String FLD_NAME_ProjectName = "ProjectName";
        public const String FLD_NAME_DepartmentName = "DepartmentName";
        public const String FLD_NAME_MemberFullName = "MemberFullName";
        public const String FLD_NAME_RowNumber = "RowNumber";

        #endregion
    }
}
