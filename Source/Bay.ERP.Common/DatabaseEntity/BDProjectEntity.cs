// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 25-May-2015, 10:52:28




using System;
using System.Diagnostics;
using System.ServiceModel;
using System.Runtime.Serialization;
using System.Collections.Generic;
using System.Xml.Serialization;


namespace Bay.ERP.Common.BusinessEntities
{
    [Serializable]
    [DataContract(Name = "BDProject", Namespace = "http://www.e-p-m-s.com/types")]
    public partial class BDProjectEntity : BaseEntity
    {
        #region Properties


        private Int64 _ProjectID;
        private Int64 _OperatorID;
        private Int64 _ZoneID;
        private String _ProjectCode;
        private String _ProjectName;
        private Decimal? _LandAreaKatha;
        private Decimal? _LandAreaSft;
        private Decimal? _RoadWidth;
        private Int64? _RoadWidthUnitID;
        private Int32? _NoOfStoried;
        private Int32? _NoOfBasement;
        private String _Description;
        private String _BSC;
        private Decimal? _ClientPercentage;
        private Decimal? _CompanyPercentage;
        private Int64 _ProjectCategoryID;
        private Int64 _ProjectStatusID;
        private Boolean _IsRemoved;


        [DataMember]
        public Int64 ProjectID
        {
            get { return _ProjectID; }
            set { _ProjectID = value; }
        }

        [DataMember]
        public Int64 OperatorID
        {
            get { return _OperatorID; }
            set { _OperatorID = value; }
        }

        [DataMember]
        public Int64 ZoneID
        {
            get { return _ZoneID; }
            set { _ZoneID = value; }
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
        public Decimal? LandAreaKatha
        {
            get { return _LandAreaKatha; }
            set { _LandAreaKatha = value; }
        }

        [DataMember]
        public Decimal? LandAreaSft
        {
            get { return _LandAreaSft; }
            set { _LandAreaSft = value; }
        }

        [DataMember]
        public Decimal? RoadWidth
        {
            get { return _RoadWidth; }
            set { _RoadWidth = value; }
        }

        [DataMember]
        public Int64? RoadWidthUnitID
        {
            get { return _RoadWidthUnitID; }
            set { _RoadWidthUnitID = value; }
        }

        [DataMember]
        public Int32? NoOfStoried
        {
            get { return _NoOfStoried; }
            set { _NoOfStoried = value; }
        }

        [DataMember]
        public Int32? NoOfBasement
        {
            get { return _NoOfBasement; }
            set { _NoOfBasement = value; }
        }

        [DataMember]
        public String Description
        {
            get { return _Description; }
            set { _Description = value; }
        }

        [DataMember]
        public String BSC
        {
            get { return _BSC; }
            set { _BSC = value; }
        }

        [DataMember]
        public Decimal? ClientPercentage
        {
            get { return _ClientPercentage; }
            set { _ClientPercentage = value; }
        }

        [DataMember]
        public Decimal? CompanyPercentage
        {
            get { return _CompanyPercentage; }
            set { _CompanyPercentage = value; }
        }

        [DataMember]
        public Int64 ProjectCategoryID
        {
            get { return _ProjectCategoryID; }
            set { _ProjectCategoryID = value; }
        }

        [DataMember]
        public Int64 ProjectStatusID
        {
            get { return _ProjectStatusID; }
            set { _ProjectStatusID = value; }
        }

        [DataMember]
        public Boolean IsRemoved
        {
            get { return _IsRemoved; }
            set { _IsRemoved = value; }
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

        public BDProjectEntity() : base()
        {
        }

        #endregion

        #region Constant

        public const String FLD_NAME_ProjectID = "ProjectID";
        public const String FLD_NAME_OperatorID = "OperatorID";
        public const String FLD_NAME_ZoneID = "ZoneID";
        public const String FLD_NAME_ProjectCode = "ProjectCode";
        public const String FLD_NAME_ProjectName = "ProjectName";
        public const String FLD_NAME_LandAreaKatha = "LandAreaKatha";
        public const String FLD_NAME_LandAreaSft = "LandAreaSft";
        public const String FLD_NAME_RoadWidth = "RoadWidth";
        public const String FLD_NAME_RoadWidthUnitID = "RoadWidthUnitID";
        public const String FLD_NAME_NoOfStoried = "NoOfStoried";
        public const String FLD_NAME_NoOfBasement = "NoOfBasement";
        public const String FLD_NAME_Description = "Description";
        public const String FLD_NAME_BSC = "BSC";
        public const String FLD_NAME_ClientPercentage = "ClientPercentage";
        public const String FLD_NAME_CompanyPercentage = "CompanyPercentage";
        public const String FLD_NAME_ProjectCategoryID = "ProjectCategoryID";
        public const String FLD_NAME_ProjectStatusID = "ProjectStatusID";
        public const String FLD_NAME_IsRemoved = "IsRemoved";

        #endregion
    }
}
