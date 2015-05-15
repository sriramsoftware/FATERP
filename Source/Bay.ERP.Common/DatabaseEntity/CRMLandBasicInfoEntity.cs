// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 03-Apr-2013, 03:04:35




using System;
using System.Diagnostics;
using System.ServiceModel;
using System.Runtime.Serialization;
using System.Collections.Generic;
using System.Xml.Serialization;


namespace Bay.ERP.Common.BusinessEntities
{
    [Serializable]
    [DataContract(Name = "CRMLandBasicInfo", Namespace = "http://www.e-p-m-s.com/types")]
    public partial class CRMLandBasicInfoEntity : BaseEntity
    {
        #region Properties


        private Int64 _LandBasicInfoID;
        private Int64 _LandOwnerTypeID;
        private String _ContactFullName;
        private String _MobileNo;
        private String _LandPhone;
        private String _PresentAddress;
        private String _Email;
        private Int64 _InterestedLandLocationID;
        private Int64 _CityID;
        private String _LandArea1;
        private Int64? _AreaUnitID1;
        private String _LandArea2;
        private Int64? _AreaUnitID2;
        private String _PlotNumber;
        private String _PlotAddress;
        private String _PlotMapUrl;
        private String _Area;
        private String _Dimension;
        private String _SpecialFeatures;
        private String _Structure;
        private String _RAJUKDetails;
        private Int64? _LeadGeneratedByEmployeeID;
        private Int64? _LeadManagedByOneEmployeeID;
        private Int64? _LeadManagedByTwoEmployeeID;
        private DateTime? _LeadConversionDate;
        private Int64? _ReferredByEmployeeID;
        private Int64? _LandOwnerOfProject;
        private Int64 _CreatedByEmployeeID;
        private String _IP;
        private DateTime _CreateDate;


        [DataMember]
        public Int64 LandBasicInfoID
        {
            get { return _LandBasicInfoID; }
            set { _LandBasicInfoID = value; }
        }

        [DataMember]
        public Int64 LandOwnerTypeID
        {
            get { return _LandOwnerTypeID; }
            set { _LandOwnerTypeID = value; }
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
        public Int64 InterestedLandLocationID
        {
            get { return _InterestedLandLocationID; }
            set { _InterestedLandLocationID = value; }
        }

        [DataMember]
        public Int64 CityID
        {
            get { return _CityID; }
            set { _CityID = value; }
        }

        [DataMember]
        public String LandArea1
        {
            get { return _LandArea1; }
            set { _LandArea1 = value; }
        }

        [DataMember]
        public Int64? AreaUnitID1
        {
            get { return _AreaUnitID1; }
            set { _AreaUnitID1 = value; }
        }

        [DataMember]
        public String LandArea2
        {
            get { return _LandArea2; }
            set { _LandArea2 = value; }
        }

        [DataMember]
        public Int64? AreaUnitID2
        {
            get { return _AreaUnitID2; }
            set { _AreaUnitID2 = value; }
        }

        [DataMember]
        public String PlotNumber
        {
            get { return _PlotNumber; }
            set { _PlotNumber = value; }
        }

        [DataMember]
        public String PlotAddress
        {
            get { return _PlotAddress; }
            set { _PlotAddress = value; }
        }

        [DataMember]
        public String PlotMapUrl
        {
            get { return _PlotMapUrl; }
            set { _PlotMapUrl = value; }
        }

        [DataMember]
        public String Area
        {
            get { return _Area; }
            set { _Area = value; }
        }

        [DataMember]
        public String Dimension
        {
            get { return _Dimension; }
            set { _Dimension = value; }
        }

        [DataMember]
        public String SpecialFeatures
        {
            get { return _SpecialFeatures; }
            set { _SpecialFeatures = value; }
        }

        [DataMember]
        public String Structure
        {
            get { return _Structure; }
            set { _Structure = value; }
        }

        [DataMember]
        public String RAJUKDetails
        {
            get { return _RAJUKDetails; }
            set { _RAJUKDetails = value; }
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
        public Int64? ReferredByEmployeeID
        {
            get { return _ReferredByEmployeeID; }
            set { _ReferredByEmployeeID = value; }
        }

        [DataMember]
        public Int64? LandOwnerOfProject
        {
            get { return _LandOwnerOfProject; }
            set { _LandOwnerOfProject = value; }
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

        [XmlIgnore()]
        public override bool IsNew
        {
            [DebuggerStepThrough()]
            get
            {
                return (LandBasicInfoID <= 0);
            }
        }


        #endregion

        #region Constructor

        public CRMLandBasicInfoEntity() : base()
        {
        }

        #endregion

        #region Constant

        public const String FLD_NAME_LandBasicInfoID = "LandBasicInfoID";
        public const String FLD_NAME_LandOwnerTypeID = "LandOwnerTypeID";
        public const String FLD_NAME_ContactFullName = "ContactFullName";
        public const String FLD_NAME_MobileNo = "MobileNo";
        public const String FLD_NAME_LandPhone = "LandPhone";
        public const String FLD_NAME_PresentAddress = "PresentAddress";
        public const String FLD_NAME_Email = "Email";
        public const String FLD_NAME_InterestedLandLocationID = "InterestedLandLocationID";
        public const String FLD_NAME_CityID = "CityID";
        public const String FLD_NAME_LandArea1 = "LandArea1";
        public const String FLD_NAME_AreaUnitID1 = "AreaUnitID1";
        public const String FLD_NAME_LandArea2 = "LandArea2";
        public const String FLD_NAME_AreaUnitID2 = "AreaUnitID2";
        public const String FLD_NAME_PlotNumber = "PlotNumber";
        public const String FLD_NAME_PlotAddress = "PlotAddress";
        public const String FLD_NAME_PlotMapUrl = "PlotMapUrl";
        public const String FLD_NAME_Area = "Area";
        public const String FLD_NAME_Dimension = "Dimension";
        public const String FLD_NAME_SpecialFeatures = "SpecialFeatures";
        public const String FLD_NAME_Structure = "Structure";
        public const String FLD_NAME_RAJUKDetails = "RAJUKDetails";
        public const String FLD_NAME_LeadGeneratedByEmployeeID = "LeadGeneratedByEmployeeID";
        public const String FLD_NAME_LeadManagedByOneEmployeeID = "LeadManagedByOneEmployeeID";
        public const String FLD_NAME_LeadManagedByTwoEmployeeID = "LeadManagedByTwoEmployeeID";
        public const String FLD_NAME_LeadConversionDate = "LeadConversionDate";
        public const String FLD_NAME_ReferredByEmployeeID = "ReferredByEmployeeID";
        public const String FLD_NAME_LandOwnerOfProject = "LandOwnerOfProject";
        public const String FLD_NAME_CreatedByEmployeeID = "CreatedByEmployeeID";
        public const String FLD_NAME_IP = "IP";
        public const String FLD_NAME_CreateDate = "CreateDate";

        #endregion
    }
}
