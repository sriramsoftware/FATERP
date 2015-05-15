// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 04-Apr-2013, 04:34:01




using System;
using System.Diagnostics;
using System.ServiceModel;
using System.Runtime.Serialization;
using System.Collections.Generic;
using System.Xml.Serialization;


namespace Bay.ERP.Common.BusinessEntities
{
    [Serializable]
    [DataContract(Name = "CRMBuyerBasicInfo_Detailed", Namespace = "http://www.e-p-m-s.com/types")]
    public partial class CRMBuyerBasicInfo_DetailedEntity : BaseEntity
    {
        #region Properties


        private Int64 _BuyerBasicInfoID;
        private Int64 _BuyerTypeID;
        private String _ContactFullName;
        private String _MobileNo;
        private String _LandPhone;
        private String _PresentAddress;
        private String _Email;
        private Int64? _InterestedLandLocationID;
        private Int64? _CityID;
        private Decimal? _AreaNeededFrom;
        private Decimal? _AreaNeededTo;
        private Decimal? _ParkingNeeded;
        private Int64? _AreaUnitID;
        private Decimal? _ToiletNeeded;
        private Decimal? _UnitNeeded;
        private Int64? _AdvertiseWayID;
        private Int64? _LeadGeneratedByEmployeeID;
        private Int64? _LeadManagedByOneEmployeeID;
        private Int64? _LeadManagedByTwoEmployeeID;
        private DateTime? _LeadConversionDate;
        private Int64? _ProspectForProject;
        private String _Remarks;
        private Int64 _CreatedByEmployeeID;
        private String _IP;
        private DateTime _CreateDate;
        private String _CRMMDBuyerTypeName;
        private String _CRMMDLandLocationName;
        private String _MDCityName;
        private String _CRMMDAreaUnitName;
        private String _CRMMDAdvertiseWayName;
        private String _LeadGeneratedByMemberFullName;
        private String _LeadManagedByOneMemberFullName;
        private String _LeadManagedByTwoMemberFullName;
        private String _CreatedByMemberFullName;
        private String _BDProjectProjectName;
        private String _ImageUrl;
        private String _CompanyName;
        private Int64? _RowNumber;


        [DataMember]
        public Int64 BuyerBasicInfoID
        {
            get { return _BuyerBasicInfoID; }
            set { _BuyerBasicInfoID = value; }
        }

        [DataMember]
        public Int64 BuyerTypeID
        {
            get { return _BuyerTypeID; }
            set { _BuyerTypeID = value; }
        }

        [DataMember]
        public String ContactFullName
        {
            get { return _ContactFullName; }
            set { _ContactFullName = value; }
        }

        [DataMember]
        public String MobileNo
        {
            get { return _MobileNo; }
            set { _MobileNo = value; }
        }

        [DataMember]
        public String LandPhone
        {
            get { return _LandPhone; }
            set { _LandPhone = value; }
        }

        [DataMember]
        public String PresentAddress
        {
            get { return _PresentAddress; }
            set { _PresentAddress = value; }
        }

        [DataMember]
        public String Email
        {
            get { return _Email; }
            set { _Email = value; }
        }

        [DataMember]
        public Int64? InterestedLandLocationID
        {
            get { return _InterestedLandLocationID; }
            set { _InterestedLandLocationID = value; }
        }

        [DataMember]
        public Int64? CityID
        {
            get { return _CityID; }
            set { _CityID = value; }
        }

        [DataMember]
        public Decimal? AreaNeededFrom
        {
            get { return _AreaNeededFrom; }
            set { _AreaNeededFrom = value; }
        }

        [DataMember]
        public Decimal? AreaNeededTo
        {
            get { return _AreaNeededTo; }
            set { _AreaNeededTo = value; }
        }

        [DataMember]
        public Decimal? ParkingNeeded
        {
            get { return _ParkingNeeded; }
            set { _ParkingNeeded = value; }
        }

        [DataMember]
        public Int64? AreaUnitID
        {
            get { return _AreaUnitID; }
            set { _AreaUnitID = value; }
        }

        [DataMember]
        public Decimal? ToiletNeeded
        {
            get { return _ToiletNeeded; }
            set { _ToiletNeeded = value; }
        }

        [DataMember]
        public Decimal? UnitNeeded
        {
            get { return _UnitNeeded; }
            set { _UnitNeeded = value; }
        }

        [DataMember]
        public Int64? AdvertiseWayID
        {
            get { return _AdvertiseWayID; }
            set { _AdvertiseWayID = value; }
        }

        [DataMember]
        public Int64? LeadGeneratedByEmployeeID
        {
            get { return _LeadGeneratedByEmployeeID; }
            set { _LeadGeneratedByEmployeeID = value; }
        }

        [DataMember]
        public Int64? LeadManagedByOneEmployeeID
        {
            get { return _LeadManagedByOneEmployeeID; }
            set { _LeadManagedByOneEmployeeID = value; }
        }

        [DataMember]
        public Int64? LeadManagedByTwoEmployeeID
        {
            get { return _LeadManagedByTwoEmployeeID; }
            set { _LeadManagedByTwoEmployeeID = value; }
        }

        [DataMember]
        public DateTime? LeadConversionDate
        {
            get { return _LeadConversionDate; }
            set { _LeadConversionDate = value; }
        }

        [DataMember]
        public Int64? ProspectForProject
        {
            get { return _ProspectForProject; }
            set { _ProspectForProject = value; }
        }

        [DataMember]
        public String Remarks
        {
            get { return _Remarks; }
            set { _Remarks = value; }
        }

        [DataMember]
        public Int64 CreatedByEmployeeID
        {
            get { return _CreatedByEmployeeID; }
            set { _CreatedByEmployeeID = value; }
        }

        [DataMember]
        public String IP
        {
            get { return _IP; }
            set { _IP = value; }
        }

        [DataMember]
        public DateTime CreateDate
        {
            get { return _CreateDate; }
            set { _CreateDate = value; }
        }

        [DataMember]
        public String CRMMDBuyerTypeName
        {
            get { return _CRMMDBuyerTypeName; }
            set { _CRMMDBuyerTypeName = value; }
        }

        [DataMember]
        public String CRMMDLandLocationName
        {
            get { return _CRMMDLandLocationName; }
            set { _CRMMDLandLocationName = value; }
        }

        [DataMember]
        public String MDCityName
        {
            get { return _MDCityName; }
            set { _MDCityName = value; }
        }

        [DataMember]
        public String CRMMDAreaUnitName
        {
            get { return _CRMMDAreaUnitName; }
            set { _CRMMDAreaUnitName = value; }
        }

        [DataMember]
        public String CRMMDAdvertiseWayName
        {
            get { return _CRMMDAdvertiseWayName; }
            set { _CRMMDAdvertiseWayName = value; }
        }

        [DataMember]
        public String LeadGeneratedByMemberFullName
        {
            get { return _LeadGeneratedByMemberFullName; }
            set { _LeadGeneratedByMemberFullName = value; }
        }

        [DataMember]
        public String LeadManagedByOneMemberFullName
        {
            get { return _LeadManagedByOneMemberFullName; }
            set { _LeadManagedByOneMemberFullName = value; }
        }

        [DataMember]
        public String LeadManagedByTwoMemberFullName
        {
            get { return _LeadManagedByTwoMemberFullName; }
            set { _LeadManagedByTwoMemberFullName = value; }
        }

        [DataMember]
        public String CreatedByMemberFullName
        {
            get { return _CreatedByMemberFullName; }
            set { _CreatedByMemberFullName = value; }
        }

        [DataMember]
        public String BDProjectProjectName
        {
            get { return _BDProjectProjectName; }
            set { _BDProjectProjectName = value; }
        }

        [DataMember]
        public String ImageUrl
        {
            get { return _ImageUrl; }
            set { _ImageUrl = value; }
        }

        [DataMember]
        public String CompanyName
        {
            get { return _CompanyName; }
            set { _CompanyName = value; }
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
                return (BuyerBasicInfoID <= 0);
            }
        }


        #endregion

        #region Constructor

        public CRMBuyerBasicInfo_DetailedEntity() : base()
        {
        }

        #endregion

        #region Constant

        public const String FLD_NAME_BuyerBasicInfoID = "BuyerBasicInfoID";
        public const String FLD_NAME_BuyerTypeID = "BuyerTypeID";
        public const String FLD_NAME_ContactFullName = "ContactFullName";
        public const String FLD_NAME_MobileNo = "MobileNo";
        public const String FLD_NAME_LandPhone = "LandPhone";
        public const String FLD_NAME_PresentAddress = "PresentAddress";
        public const String FLD_NAME_Email = "Email";
        public const String FLD_NAME_InterestedLandLocationID = "InterestedLandLocationID";
        public const String FLD_NAME_CityID = "CityID";
        public const String FLD_NAME_AreaNeededFrom = "AreaNeededFrom";
        public const String FLD_NAME_AreaNeededTo = "AreaNeededTo";
        public const String FLD_NAME_ParkingNeeded = "ParkingNeeded";
        public const String FLD_NAME_AreaUnitID = "AreaUnitID";
        public const String FLD_NAME_ToiletNeeded = "ToiletNeeded";
        public const String FLD_NAME_UnitNeeded = "UnitNeeded";
        public const String FLD_NAME_AdvertiseWayID = "AdvertiseWayID";
        public const String FLD_NAME_LeadGeneratedByEmployeeID = "LeadGeneratedByEmployeeID";
        public const String FLD_NAME_LeadManagedByOneEmployeeID = "LeadManagedByOneEmployeeID";
        public const String FLD_NAME_LeadManagedByTwoEmployeeID = "LeadManagedByTwoEmployeeID";
        public const String FLD_NAME_LeadConversionDate = "LeadConversionDate";
        public const String FLD_NAME_ProspectForProject = "ProspectForProject";
        public const String FLD_NAME_Remarks = "Remarks";
        public const String FLD_NAME_CreatedByEmployeeID = "CreatedByEmployeeID";
        public const String FLD_NAME_IP = "IP";
        public const String FLD_NAME_CreateDate = "CreateDate";
        public const String FLD_NAME_CRMMDBuyerTypeName = "CRMMDBuyerTypeName";
        public const String FLD_NAME_CRMMDLandLocationName = "CRMMDLandLocationName";
        public const String FLD_NAME_MDCityName = "MDCityName";
        public const String FLD_NAME_CRMMDAreaUnitName = "CRMMDAreaUnitName";
        public const String FLD_NAME_CRMMDAdvertiseWayName = "CRMMDAdvertiseWayName";
        public const String FLD_NAME_LeadGeneratedByMemberFullName = "LeadGeneratedByMemberFullName";
        public const String FLD_NAME_LeadManagedByOneMemberFullName = "LeadManagedByOneMemberFullName";
        public const String FLD_NAME_LeadManagedByTwoMemberFullName = "LeadManagedByTwoMemberFullName";
        public const String FLD_NAME_CreatedByMemberFullName = "CreatedByMemberFullName";
        public const String FLD_NAME_BDProjectProjectName = "BDProjectProjectName";
        public const String FLD_NAME_ImageUrl = "ImageUrl";
        public const String FLD_NAME_CompanyName = "CompanyName";
        public const String FLD_NAME_RowNumber = "RowNumber";

        #endregion
    }
}
