// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 27-Jan-2013, 04:44:22




using System;
using System.Diagnostics;
using System.ServiceModel;
using System.Runtime.Serialization;
using System.Collections.Generic;
using System.Xml.Serialization;


namespace Bay.ERP.Common.BusinessEntities
{
    [Serializable]
    [DataContract(Name = "BDProjectUnitLocation_Detailed", Namespace = "http://www.e-p-m-s.com/types")]
    public partial class BDProjectUnitLocation_DetailedEntity : BaseEntity
    {
        #region Properties


        private Int64 _ProjectUnitLocationID;
        private Int64 _ProjectID;
        private String _ProjectCode;
        private String _ProjectName;
        private Int64? _ProjectFloorID;
        private String _ProjectFloorName;
        private Int64? _ProjectFloorUnitID;
        private String _ProjectFloorUnitName;
        private Int64 _FloorUnitLocationCategoryID;
        private String _FloorUnitLocationCategoryName;
        private String _ProjectUnitLocationName;
        private Decimal? _NetAreaSft;
        private Decimal? _GrossAreaSft;
        private String _Measurement;
        private String _Facing;
        private String _Dimension;
        private String _Description;
        private DateTime? _ModificationDate;
        private String _ModificationNote;
        private String _SpecialFeatures;
        private String _Extra1;
        private String _Extra2;
        private Int64? _RowNumber;


        [DataMember]
        public Int64 ProjectUnitLocationID
        {
            get { return _ProjectUnitLocationID; }
            set { _ProjectUnitLocationID = value; }
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
        public String ProjectName
        {
            get { return _ProjectName; }
            set { _ProjectName = value; }
        }

        [DataMember]
        public Int64? ProjectFloorID
        {
            get { return _ProjectFloorID; }
            set { _ProjectFloorID = value; }
        }

        [DataMember]
        public String ProjectFloorName
        {
            get { return _ProjectFloorName; }
            set { _ProjectFloorName = value; }
        }
        
        [DataMember]
        public Int64? ProjectFloorUnitID
        {
            get { return _ProjectFloorUnitID; }
            set { _ProjectFloorUnitID = value; }
        }

        [DataMember]
        public String ProjectFloorUnitName
        {
            get { return _ProjectFloorUnitName; }
            set { _ProjectFloorUnitName = value; }
        }
        
        [DataMember]
        public Int64 FloorUnitLocationCategoryID
        {
            get { return _FloorUnitLocationCategoryID; }
            set { _FloorUnitLocationCategoryID = value; }
        }

        [DataMember]
        public String FloorUnitLocationCategoryName
        {
            get { return _FloorUnitLocationCategoryName; }
            set { _FloorUnitLocationCategoryName = value; }
        }

        [DataMember]
        public String ProjectUnitLocationName
        {
            get { return _ProjectUnitLocationName; }
            set { _ProjectUnitLocationName = value; }
        }

        [DataMember]
        public Decimal? NetAreaSft
        {
            get { return _NetAreaSft; }
            set { _NetAreaSft = value; }
        }

        [DataMember]
        public Decimal? GrossAreaSft
        {
            get { return _GrossAreaSft; }
            set { _GrossAreaSft = value; }
        }

        [DataMember]
        public String Measurement
        {
            get { return _Measurement; }
            set { _Measurement = value; }
        }

        [DataMember]
        public String Facing
        {
            get { return _Facing; }
            set { _Facing = value; }
        }

        [DataMember]
        public String Dimension
        {
            get { return _Dimension; }
            set { _Dimension = value; }
        }

        [DataMember]
        public String Description
        {
            get { return _Description; }
            set { _Description = value; }
        }

        [DataMember]
        public DateTime? ModificationDate
        {
            get { return _ModificationDate; }
            set { _ModificationDate = value; }
        }

        [DataMember]
        public String ModificationNote
        {
            get { return _ModificationNote; }
            set { _ModificationNote = value; }
        }

        [DataMember]
        public String SpecialFeatures
        {
            get { return _SpecialFeatures; }
            set { _SpecialFeatures = value; }
        }

        [DataMember]
        public String Extra1
        {
            get { return _Extra1; }
            set { _Extra1 = value; }
        }

        [DataMember]
        public String Extra2
        {
            get { return _Extra2; }
            set { _Extra2 = value; }
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
                return (ProjectUnitLocationID <= 0);
            }
        }


        #endregion

        #region Constructor

        public BDProjectUnitLocation_DetailedEntity()
            : base()
        {
        }

        #endregion

        #region Constant

        public const String FLD_NAME_ProjectUnitLocationID = "ProjectUnitLocationID";
        public const String FLD_NAME_ProjectID = "ProjectID";
        public const String FLD_NAME_ProjectCode = "ProjectCode";
        public const String FLD_NAME_ProjectName = "ProjectName";
        public const String FLD_NAME_ProjectFloorID = "ProjectFloorID";
        public const String FLD_NAME_ProjectFloorName = "ProjectFloorName";
        public const String FLD_NAME_ProjectFloorUnitID = "ProjectFloorUnitID";
        public const String FLD_NAME_ProjectFloorUnitName = "ProjectFloorUnitName";
        public const String FLD_NAME_FloorUnitLocationCategoryID = "FloorUnitLocationCategoryID";
        public const String FLD_NAME_FloorUnitLocationCategoryName = "FloorUnitLocationCategoryName";
        public const String FLD_NAME_ProjectUnitLocationName = "ProjectUnitLocationName";
        public const String FLD_NAME_NetAreaSft = "NetAreaSft";
        public const String FLD_NAME_GrossAreaSft = "GrossAreaSft";
        public const String FLD_NAME_Measurement = "Measurement";
        public const String FLD_NAME_Facing = "Facing";
        public const String FLD_NAME_Dimension = "Dimension";
        public const String FLD_NAME_Description = "Description";
        public const String FLD_NAME_ModificationDate = "ModificationDate";
        public const String FLD_NAME_ModificationNote = "ModificationNote";
        public const String FLD_NAME_SpecialFeatures = "SpecialFeatures";
        public const String FLD_NAME_Extra1 = "Extra1";
        public const String FLD_NAME_Extra2 = "Extra2";
        public const String FLD_NAME_RowNumber = "RowNumber";

        #endregion
    }
}
