// Copyright and All Rights Reserved by
//B2B Solution, Bangladesh;
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 24-May-2012, 10:39:09




using System;
using System.Diagnostics;
using System.ServiceModel;
using System.Runtime.Serialization;
using System.Collections.Generic;
using System.Xml.Serialization;


namespace Bay.ERP.Common.BusinessEntities
{
    [Serializable]
    [DataContract(Name = "BDProjectFloor_Detailed", Namespace = "http://www.e-p-m-s.com/types")]
    public partial class BDProjectFloor_DetailedEntity : BaseEntity
    {
        #region Properties


        private Int64 _ProjectFloorID;
        private Int64 _ProjectID;
        private Int64 _FloorCategoryID;
        private Int64 _FloorID;
        private String _Name;
        private Int32 _Size;
        private String _Description;
        private Boolean _IsRemoved;
        private String _ProjectName;
        private String _FloorCategoryName;
        private String _FloorName;
        private Int64? _RowNumber;


        [DataMember]
        public Int64 ProjectFloorID
        {
            get { return _ProjectFloorID; }
            set { _ProjectFloorID = value; }
        }

        [DataMember]
        public Int64 ProjectID
        {
            get { return _ProjectID; }
            set { _ProjectID = value; }
        }

        [DataMember]
        public Int64 FloorCategoryID
        {
            get { return _FloorCategoryID; }
            set { _FloorCategoryID = value; }
        }

        [DataMember]
        public Int64 FloorID
        {
            get { return _FloorID; }
            set { _FloorID = value; }
        }

        [DataMember]
        public String Name
        {
            get { return _Name; }
            set { _Name = value; }
        }

        [DataMember]
        public Int32 Size
        {
            get { return _Size; }
            set { _Size = value; }
        }

        [DataMember]
        public String Description
        {
            get { return _Description; }
            set { _Description = value; }
        }

        [DataMember]
        public Boolean IsRemoved
        {
            get { return _IsRemoved; }
            set { _IsRemoved = value; }
        }

        [DataMember]
        public String ProjectName
        {
            get { return _ProjectName; }
            set { _ProjectName = value; }
        }

        [DataMember]
        public String FloorCategoryName
        {
            get { return _FloorCategoryName; }
            set { _FloorCategoryName = value; }
        }

        [DataMember]
        public String FloorName
        {
            get { return _FloorName; }
            set { _FloorName = value; }
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
                return (ProjectFloorID <= 0);
            }
        }


        #endregion

        #region Constructor

        public BDProjectFloor_DetailedEntity() : base()
        {
        }

        #endregion

        #region Constant

        public const String FLD_NAME_ProjectFloorID = "ProjectFloorID";
        public const String FLD_NAME_ProjectID = "ProjectID";
        public const String FLD_NAME_FloorCategoryID = "FloorCategoryID";
        public const String FLD_NAME_FloorID = "FloorID";
        public const String FLD_NAME_Name = "Name";
        public const String FLD_NAME_Size = "Size";
        public const String FLD_NAME_Description = "Description";
        public const String FLD_NAME_IsRemoved = "IsRemoved";
        public const String FLD_NAME_ProjectName = "ProjectName";
        public const String FLD_NAME_FloorCategoryName = "FloorCategoryName";
        public const String FLD_NAME_FloorName = "FloorName";
        public const String FLD_NAME_RowNumber = "RowNumber";

        #endregion
    }
}
