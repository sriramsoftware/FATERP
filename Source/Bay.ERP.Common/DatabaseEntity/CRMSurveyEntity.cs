// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 24-Oct-2013, 12:51:37




using System;
using System.Diagnostics;
using System.ServiceModel;
using System.Runtime.Serialization;
using System.Collections.Generic;
using System.Xml.Serialization;


namespace Bay.ERP.Common.BusinessEntities
{
    [Serializable]
    [DataContract(Name = "CRMSurvey", Namespace = "http://www.e-p-m-s.com/types")]
    public partial class CRMSurveyEntity : BaseEntity
    {
        #region Properties


        private Int64 _SurveyID;
        private Int64 _SurveyMasterID;
        private Int64 _SurveyOwnerID;
        private Int64 _AreaID;
        private String _Description;
        private String _PlotAddress;
        private Decimal _ApproximatePlotSize;
        private Int64 _AreaUnitID;
        private Decimal _ApproximateFloorSizeSft;
        private Decimal _Floors;
        private Decimal _ApproximateTotalSpaceSft;
        private String _Basements;
        private String _NoOfCarParking;
        private String _ACSystem;
        private String _GeneratorBackup;
        private String _LiftsCapacity;
        private String _ToiletsPerFloor;
        private String _AvailableFloorSft;
        private String _AvailableForOccupancy;
        private String _RentalRateBDTPerSft;
        private String _SellingRateBDTPerSft;
        private String _HandoverTime;
        private Int64 _SurveyBuildingStatusID;
        private Int64 _SurveySourceInformationID;
        private String _SourcePersonInformation;
        private String _ContactInfo;
        private String _Remarks;
        private String _AdditionalRemarks;
        private String _OthersRemarks;
        private DateTime? _CreateDate;
        private DateTime _SurveyDate;
        private String _IP;
        private Int64 _SurveyByEmployeeID;
        private Int64 _CreateByEmployeeID;


        [DataMember]
        public Int64 SurveyID
        {
            get { return _SurveyID; }
            set { _SurveyID = value; }
        }

        [DataMember]
        public Int64 SurveyMasterID
        {
            get { return _SurveyMasterID; }
            set { _SurveyMasterID = value; }
        }

        [DataMember]
        public Int64 SurveyOwnerID
        {
            get { return _SurveyOwnerID; }
            set { _SurveyOwnerID = value; }
        }

        [DataMember]
        public Int64 AreaID
        {
            get { return _AreaID; }
            set { _AreaID = value; }
        }

        [DataMember]
        public String Description
        {
            get { return _Description; }
            set { _Description = value; }
        }

        [DataMember]
        public String PlotAddress
        {
            get { return _PlotAddress; }
            set { _PlotAddress = value; }
        }

        [DataMember]
        public Decimal ApproximatePlotSize
        {
            get { return _ApproximatePlotSize; }
            set { _ApproximatePlotSize = value; }
        }

        [DataMember]
        public Int64 AreaUnitID
        {
            get { return _AreaUnitID; }
            set { _AreaUnitID = value; }
        }

        [DataMember]
        public Decimal ApproximateFloorSizeSft
        {
            get { return _ApproximateFloorSizeSft; }
            set { _ApproximateFloorSizeSft = value; }
        }

        [DataMember]
        public Decimal Floors
        {
            get { return _Floors; }
            set { _Floors = value; }
        }

        [DataMember]
        public Decimal ApproximateTotalSpaceSft
        {
            get { return _ApproximateTotalSpaceSft; }
            set { _ApproximateTotalSpaceSft = value; }
        }

        [DataMember]
        public String Basements
        {
            get { return _Basements; }
            set { _Basements = value; }
        }

        [DataMember]
        public String NoOfCarParking
        {
            get { return _NoOfCarParking; }
            set { _NoOfCarParking = value; }
        }

        [DataMember]
        public String ACSystem
        {
            get { return _ACSystem; }
            set { _ACSystem = value; }
        }

        [DataMember]
        public String GeneratorBackup
        {
            get { return _GeneratorBackup; }
            set { _GeneratorBackup = value; }
        }

        [DataMember]
        public String LiftsCapacity
        {
            get { return _LiftsCapacity; }
            set { _LiftsCapacity = value; }
        }

        [DataMember]
        public String ToiletsPerFloor
        {
            get { return _ToiletsPerFloor; }
            set { _ToiletsPerFloor = value; }
        }

        [DataMember]
        public String AvailableFloorSft
        {
            get { return _AvailableFloorSft; }
            set { _AvailableFloorSft = value; }
        }

        [DataMember]
        public String AvailableForOccupancy
        {
            get { return _AvailableForOccupancy; }
            set { _AvailableForOccupancy = value; }
        }

        [DataMember]
        public String RentalRateBDTPerSft
        {
            get { return _RentalRateBDTPerSft; }
            set { _RentalRateBDTPerSft = value; }
        }

        [DataMember]
        public String SellingRateBDTPerSft
        {
            get { return _SellingRateBDTPerSft; }
            set { _SellingRateBDTPerSft = value; }
        }

        [DataMember]
        public String HandoverTime
        {
            get { return _HandoverTime; }
            set { _HandoverTime = value; }
        }

        [DataMember]
        public Int64 SurveyBuildingStatusID
        {
            get { return _SurveyBuildingStatusID; }
            set { _SurveyBuildingStatusID = value; }
        }

        [DataMember]
        public Int64 SurveySourceInformationID
        {
            get { return _SurveySourceInformationID; }
            set { _SurveySourceInformationID = value; }
        }

        [DataMember]
        public String SourcePersonInformation
        {
            get { return _SourcePersonInformation; }
            set { _SourcePersonInformation = value; }
        }

        [DataMember]
        public String ContactInfo
        {
            get { return _ContactInfo; }
            set { _ContactInfo = value; }
        }

        [DataMember]
        public String Remarks
        {
            get { return _Remarks; }
            set { _Remarks = value; }
        }

        [DataMember]
        public String AdditionalRemarks
        {
            get { return _AdditionalRemarks; }
            set { _AdditionalRemarks = value; }
        }

        [DataMember]
        public String OthersRemarks
        {
            get { return _OthersRemarks; }
            set { _OthersRemarks = value; }
        }

        [DataMember]
        public DateTime? CreateDate
        {
            get { return _CreateDate; }
            set { _CreateDate = value; }
        }

        [DataMember]
        public DateTime SurveyDate
        {
            get { return _SurveyDate; }
            set { _SurveyDate = value; }
        }

        [DataMember]
        public String IP
        {
            get { return _IP; }
            set { _IP = value; }
        }

        [DataMember]
        public Int64 SurveyByEmployeeID
        {
            get { return _SurveyByEmployeeID; }
            set { _SurveyByEmployeeID = value; }
        }

        [DataMember]
        public Int64 CreateByEmployeeID
        {
            get { return _CreateByEmployeeID; }
            set { _CreateByEmployeeID = value; }
        }

        [XmlIgnore()]
        public override bool IsNew
        {
            [DebuggerStepThrough()]
            get
            {
                return (SurveyID <= 0);
            }
        }


        #endregion

        #region Constructor

        public CRMSurveyEntity() : base()
        {
        }

        #endregion

        #region Constant

        public const String FLD_NAME_SurveyID = "SurveyID";
        public const String FLD_NAME_SurveyMasterID = "SurveyMasterID";
        public const String FLD_NAME_SurveyOwnerID = "SurveyOwnerID";
        public const String FLD_NAME_AreaID = "AreaID";
        public const String FLD_NAME_Description = "Description";
        public const String FLD_NAME_PlotAddress = "PlotAddress";
        public const String FLD_NAME_ApproximatePlotSize = "ApproximatePlotSize";
        public const String FLD_NAME_AreaUnitID = "AreaUnitID";
        public const String FLD_NAME_ApproximateFloorSizeSft = "ApproximateFloorSizeSft";
        public const String FLD_NAME_Floors = "Floors";
        public const String FLD_NAME_ApproximateTotalSpaceSft = "ApproximateTotalSpaceSft";
        public const String FLD_NAME_Basements = "Basements";
        public const String FLD_NAME_NoOfCarParking = "NoOfCarParking";
        public const String FLD_NAME_ACSystem = "ACSystem";
        public const String FLD_NAME_GeneratorBackup = "GeneratorBackup";
        public const String FLD_NAME_LiftsCapacity = "LiftsCapacity";
        public const String FLD_NAME_ToiletsPerFloor = "ToiletsPerFloor";
        public const String FLD_NAME_AvailableFloorSft = "AvailableFloorSft";
        public const String FLD_NAME_AvailableForOccupancy = "AvailableForOccupancy";
        public const String FLD_NAME_RentalRateBDTPerSft = "RentalRateBDTPerSft";
        public const String FLD_NAME_SellingRateBDTPerSft = "SellingRateBDTPerSft";
        public const String FLD_NAME_HandoverTime = "HandoverTime";
        public const String FLD_NAME_SurveyBuildingStatusID = "SurveyBuildingStatusID";
        public const String FLD_NAME_SurveySourceInformationID = "SurveySourceInformationID";
        public const String FLD_NAME_SourcePersonInformation = "SourcePersonInformation";
        public const String FLD_NAME_ContactInfo = "ContactInfo";
        public const String FLD_NAME_Remarks = "Remarks";
        public const String FLD_NAME_AdditionalRemarks = "AdditionalRemarks";
        public const String FLD_NAME_OthersRemarks = "OthersRemarks";
        public const String FLD_NAME_CreateDate = "CreateDate";
        public const String FLD_NAME_SurveyDate = "SurveyDate";
        public const String FLD_NAME_IP = "IP";
        public const String FLD_NAME_SurveyByEmployeeID = "SurveyByEmployeeID";
        public const String FLD_NAME_CreateByEmployeeID = "CreateByEmployeeID";

        #endregion
    }
}
