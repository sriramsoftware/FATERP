// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 20-May-2013, 04:56:23




using System;
using System.Diagnostics;
using System.ServiceModel;
using System.Runtime.Serialization;
using System.Collections.Generic;
using System.Xml.Serialization;


namespace Bay.ERP.Common.BusinessEntities
{
    [Serializable]
    [DataContract(Name = "BDProjectStatusWiseFloorUnit_RPT", Namespace = "http://www.e-p-m-s.com/types")]
    public partial class BDProjectStatusWiseFloorUnit_RPTEntity : BaseEntity
    {
        #region Properties


        private String _ProjectFloorUnitName;
        private Decimal _UnitArea;
        private Decimal _TotalArea;
        private String _Facing;
        private Decimal _Toilet;
        private Decimal _Kitchen;
        private Decimal _Parking;
        private Decimal _BathRoom;
        private Decimal _BedRoom;
        private Boolean _IsIDServiceAvailable;
        private Boolean _ElectricityService;
        private Boolean _CommonGenerator;
        private Decimal? _PricePerSft;
        private Decimal? _AreaPrice;
        private Decimal? _IDPrice;
        private Decimal? _AdditionalCharges;
        private String _Features;
        private String _FloorName;
        private String _ProjectCode;
        private String _ProjectName;
        private Int64 _ProjectID;
        private Int64 _ProjectFloorUnitStatusID;
        private String _Name;


        [DataMember]
        public String ProjectFloorUnitName
        {
            get { return _ProjectFloorUnitName; }
            set { _ProjectFloorUnitName = value; }
        }

        [DataMember]
        public Decimal UnitArea
        {
            get { return _UnitArea; }
            set { _UnitArea = value; }
        }

        [DataMember]
        public Decimal TotalArea
        {
            get { return _TotalArea; }
            set { _TotalArea = value; }
        }

        [DataMember]
        public String Facing
        {
            get { return _Facing; }
            set { _Facing = value; }
        }

        [DataMember]
        public Decimal Toilet
        {
            get { return _Toilet; }
            set { _Toilet = value; }
        }

        [DataMember]
        public Decimal Kitchen
        {
            get { return _Kitchen; }
            set { _Kitchen = value; }
        }

        [DataMember]
        public Decimal Parking
        {
            get { return _Parking; }
            set { _Parking = value; }
        }

        [DataMember]
        public Decimal BathRoom
        {
            get { return _BathRoom; }
            set { _BathRoom = value; }
        }

        [DataMember]
        public Decimal BedRoom
        {
            get { return _BedRoom; }
            set { _BedRoom = value; }
        }

        [DataMember]
        public Boolean IsIDServiceAvailable
        {
            get { return _IsIDServiceAvailable; }
            set { _IsIDServiceAvailable = value; }
        }

        [DataMember]
        public Boolean ElectricityService
        {
            get { return _ElectricityService; }
            set { _ElectricityService = value; }
        }

        [DataMember]
        public Boolean CommonGenerator
        {
            get { return _CommonGenerator; }
            set { _CommonGenerator = value; }
        }

        [DataMember]
        public Decimal? PricePerSft
        {
            get { return _PricePerSft; }
            set { _PricePerSft = value; }
        }

        [DataMember]
        public Decimal? AreaPrice
        {
            get { return _AreaPrice; }
            set { _AreaPrice = value; }
        }

        [DataMember]
        public Decimal? IDPrice
        {
            get { return _IDPrice; }
            set { _IDPrice = value; }
        }

        [DataMember]
        public Decimal? AdditionalCharges
        {
            get { return _AdditionalCharges; }
            set { _AdditionalCharges = value; }
        }

        [DataMember]
        public String Features
        {
            get { return _Features; }
            set { _Features = value; }
        }

        [DataMember]
        public String FloorName
        {
            get { return _FloorName; }
            set { _FloorName = value; }
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
        public Int64 ProjectID
        {
            get { return _ProjectID; }
            set { _ProjectID = value; }
        }

        [DataMember]
        public Int64 ProjectFloorUnitStatusID
        {
            get { return _ProjectFloorUnitStatusID; }
            set { _ProjectFloorUnitStatusID = value; }
        }

        [DataMember]
        public String Name
        {
            get { return _Name; }
            set { _Name = value; }
        }

        [XmlIgnore()]
        public override bool IsNew
        {
            [DebuggerStepThrough()]
            get
            {
                return (ProjectFloorUnitStatusID <= 0);
            }
        }


        #endregion

        #region Constructor

        public BDProjectStatusWiseFloorUnit_RPTEntity() : base()
        {
        }

        #endregion

        #region Constant

        public const String FLD_NAME_ProjectFloorUnitName = "ProjectFloorUnitName";
        public const String FLD_NAME_UnitArea = "UnitArea";
        public const String FLD_NAME_TotalArea = "TotalArea";
        public const String FLD_NAME_Facing = "Facing";
        public const String FLD_NAME_Toilet = "Toilet";
        public const String FLD_NAME_Kitchen = "Kitchen";
        public const String FLD_NAME_Parking = "Parking";
        public const String FLD_NAME_BathRoom = "BathRoom";
        public const String FLD_NAME_BedRoom = "BedRoom";
        public const String FLD_NAME_IsIDServiceAvailable = "IsIDServiceAvailable";
        public const String FLD_NAME_ElectricityService = "ElectricityService";
        public const String FLD_NAME_CommonGenerator = "CommonGenerator";
        public const String FLD_NAME_PricePerSft = "PricePerSft";
        public const String FLD_NAME_AreaPrice = "AreaPrice";
        public const String FLD_NAME_IDPrice = "IDPrice";
        public const String FLD_NAME_AdditionalCharges = "AdditionalCharges";
        public const String FLD_NAME_Features = "Features";
        public const String FLD_NAME_FloorName = "FloorName";
        public const String FLD_NAME_ProjectCode = "ProjectCode";
        public const String FLD_NAME_ProjectName = "ProjectName";
        public const String FLD_NAME_ProjectID = "ProjectID";
        public const String FLD_NAME_ProjectFloorUnitStatusID = "ProjectFloorUnitStatusID";
        public const String FLD_NAME_Name = "Name";

        #endregion
    }
}
