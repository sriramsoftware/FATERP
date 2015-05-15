// Copyright and All Rights Reserved by
//B2B Solution, Bangladesh;
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 29-Jan-2012, 09:58:11




using System;
using System.Diagnostics;
using System.ServiceModel;
using System.Runtime.Serialization;
using System.Collections.Generic;
using System.Xml.Serialization;


namespace Bay.ERP.Common.BusinessEntities
{
    [Serializable]
    [DataContract(Name = "BDProject_RPT", Namespace = "http://www.e-p-m-s.com/types")]
    public partial class BDProject_RPTEntity : BaseEntity
    {
        #region Properties


        private Int64 _ProjectID;
        private String _ProjectCode;
        private String _ProjectName;
        private Decimal? _LandAreaKatha;
        private Decimal? _LandAreaSft;
        private Int32? _NoOfStoried;
        private Int32? _NoOfBasement;
        private String _Description;
        private Decimal? _ClientPercentage;
        private Decimal? _CompanyPercentage;
        private Int64 _ProjectStatusID;
        private Boolean _IsRemoved;
        private Int64? _ProjectAddressInfoID;
        private String _AddressLine1;
        private String _AddressLine2;
        private Int64? _CountryID;
        private Int64? _CityID;
        private String _ZipCode;
        private String _Country;
        private String _City;
        private Int64? _ProjectOtherInfoID;
        private Decimal? _TBA;
        private Int64? _TBAUnitID;
        private Decimal? _FAR;
        private Decimal? _FIA;
        private Int64? _FIAUnitID;
        private Decimal? _GSA;
        private Int64? _GSAUnitID;
        private String _GroundCoverage;
        private DateTime? _DateOfAgreement;
        private DateTime? _DateOfHandover;
        private String _DelayClause;
        private String _TBAUnit;
        private String _FIAUnit;
        private String _GSAUnit;
        private String _ProjectStatus;


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

        [DataMember]
        public Int64? ProjectAddressInfoID
        {
            get { return _ProjectAddressInfoID; }
            set { _ProjectAddressInfoID = value; }
        }

        [DataMember]
        public String AddressLine1
        {
            get { return _AddressLine1; }
            set { _AddressLine1 = value; }
        }

        [DataMember]
        public String AddressLine2
        {
            get { return _AddressLine2; }
            set { _AddressLine2 = value; }
        }

        [DataMember]
        public Int64? CountryID
        {
            get { return _CountryID; }
            set { _CountryID = value; }
        }

        [DataMember]
        public Int64? CityID
        {
            get { return _CityID; }
            set { _CityID = value; }
        }

        [DataMember]
        public String ZipCode
        {
            get { return _ZipCode; }
            set { _ZipCode = value; }
        }

        [DataMember]
        public String Country
        {
            get { return _Country; }
            set { _Country = value; }
        }

        [DataMember]
        public String City
        {
            get { return _City; }
            set { _City = value; }
        }

        [DataMember]
        public Int64? ProjectOtherInfoID
        {
            get { return _ProjectOtherInfoID; }
            set { _ProjectOtherInfoID = value; }
        }

        [DataMember]
        public Decimal? TBA
        {
            get { return _TBA; }
            set { _TBA = value; }
        }

        [DataMember]
        public Int64? TBAUnitID
        {
            get { return _TBAUnitID; }
            set { _TBAUnitID = value; }
        }

        [DataMember]
        public Decimal? FAR
        {
            get { return _FAR; }
            set { _FAR = value; }
        }

        [DataMember]
        public Decimal? FIA
        {
            get { return _FIA; }
            set { _FIA = value; }
        }

        [DataMember]
        public Int64? FIAUnitID
        {
            get { return _FIAUnitID; }
            set { _FIAUnitID = value; }
        }

        [DataMember]
        public Decimal? GSA
        {
            get { return _GSA; }
            set { _GSA = value; }
        }

        [DataMember]
        public Int64? GSAUnitID
        {
            get { return _GSAUnitID; }
            set { _GSAUnitID = value; }
        }

        [DataMember]
        public String GroundCoverage
        {
            get { return _GroundCoverage; }
            set { _GroundCoverage = value; }
        }

        [DataMember]
        public DateTime? DateOfAgreement
        {
            get { return _DateOfAgreement; }
            set { _DateOfAgreement = value; }
        }

        [DataMember]
        public DateTime? DateOfHandover
        {
            get { return _DateOfHandover; }
            set { _DateOfHandover = value; }
        }

        [DataMember]
        public String DelayClause
        {
            get { return _DelayClause; }
            set { _DelayClause = value; }
        }

        [DataMember]
        public String TBAUnit
        {
            get { return _TBAUnit; }
            set { _TBAUnit = value; }
        }

        [DataMember]
        public String FIAUnit
        {
            get { return _FIAUnit; }
            set { _FIAUnit = value; }
        }

        [DataMember]
        public String GSAUnit
        {
            get { return _GSAUnit; }
            set { _GSAUnit = value; }
        }

        [DataMember]
        public String ProjectStatus
        {
            get { return _ProjectStatus; }
            set { _ProjectStatus = value; }
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

        public BDProject_RPTEntity() : base()
        {
        }

        #endregion

        #region Constant

        public const String FLD_NAME_ProjectID = "ProjectID";
        public const String FLD_NAME_ProjectCode = "ProjectCode";
        public const String FLD_NAME_ProjectName = "ProjectName";
        public const String FLD_NAME_LandAreaKatha = "LandAreaKatha";
        public const String FLD_NAME_LandAreaSft = "LandAreaSft";
        public const String FLD_NAME_NoOfStoried = "NoOfStoried";
        public const String FLD_NAME_NoOfBasement = "NoOfBasement";
        public const String FLD_NAME_Description = "Description";
        public const String FLD_NAME_ClientPercentage = "ClientPercentage";
        public const String FLD_NAME_CompanyPercentage = "CompanyPercentage";
        public const String FLD_NAME_ProjectStatusID = "ProjectStatusID";
        public const String FLD_NAME_IsRemoved = "IsRemoved";
        public const String FLD_NAME_ProjectAddressInfoID = "ProjectAddressInfoID";
        public const String FLD_NAME_AddressLine1 = "AddressLine1";
        public const String FLD_NAME_AddressLine2 = "AddressLine2";
        public const String FLD_NAME_CountryID = "CountryID";
        public const String FLD_NAME_CityID = "CityID";
        public const String FLD_NAME_ZipCode = "ZipCode";
        public const String FLD_NAME_Country = "Country";
        public const String FLD_NAME_City = "City";
        public const String FLD_NAME_ProjectOtherInfoID = "ProjectOtherInfoID";
        public const String FLD_NAME_TBA = "TBA";
        public const String FLD_NAME_TBAUnitID = "TBAUnitID";
        public const String FLD_NAME_FAR = "FAR";
        public const String FLD_NAME_FIA = "FIA";
        public const String FLD_NAME_FIAUnitID = "FIAUnitID";
        public const String FLD_NAME_GSA = "GSA";
        public const String FLD_NAME_GSAUnitID = "GSAUnitID";
        public const String FLD_NAME_GroundCoverage = "GroundCoverage";
        public const String FLD_NAME_DateOfAgreement = "DateOfAgreement";
        public const String FLD_NAME_DateOfHandover = "DateOfHandover";
        public const String FLD_NAME_DelayClause = "DelayClause";
        public const String FLD_NAME_TBAUnit = "TBAUnit";
        public const String FLD_NAME_FIAUnit = "FIAUnit";
        public const String FLD_NAME_GSAUnit = "GSAUnit";
        public const String FLD_NAME_ProjectStatus = "ProjectStatus";

        #endregion
    }
}
