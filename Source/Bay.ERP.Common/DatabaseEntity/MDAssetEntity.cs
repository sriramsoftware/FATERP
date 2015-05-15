// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 08-Nov-2013, 09:51:38




using System;
using System.Diagnostics;
using System.ServiceModel;
using System.Runtime.Serialization;
using System.Collections.Generic;
using System.Xml.Serialization;


namespace Bay.ERP.Common.BusinessEntities
{
    [Serializable]
    [DataContract(Name = "MDAsset", Namespace = "http://www.e-p-m-s.com/types")]
    public partial class MDAssetEntity : BaseEntity
    {
        #region Properties


        private Int64 _AssetID;
        private Int64 _AssetCateogryID;
        private String _AssetCode;
        private String _AssetName;
        private String _ImageUrl;
        private Int64? _UnitID;
        private String _Description;
        private Int64? _BrandID;
        private Int64? _SupplierID;
        private DateTime? _NextMaintananceDate;
        private String _UsedOrHandeledBy;
        private Int64? _ProjectFloorUnitID;
        private Int64? _ProjectUnitLocationID;
        private Int64 _AssetOwnerTypeID;
        private Int64? _OwnerReferenceID;
        private Int64? _CurrentLocationProjectID;
        private String _InsuranceInformation;
        private String _ServiceContractInformation;
        private Decimal _Price;
        private Int64? _WorkOrderID;
        private String _Remarks;
        private Int64 _AssetConditionID;
        private Boolean _IsRemoved;
        private String _Medium;
        private Decimal? _Width;
        private Decimal? _Height;
        private Decimal? _PresentBookValue;


        [DataMember]
        public Int64 AssetID
        {
            get { return _AssetID; }
            set { _AssetID = value; }
        }

        [DataMember]
        public Int64 AssetCateogryID
        {
            get { return _AssetCateogryID; }
            set { _AssetCateogryID = value; }
        }

        [DataMember]
        public String AssetCode
        {
            get { return _AssetCode; }
            set { _AssetCode = value; }
        }

        [DataMember]
        public String AssetName
        {
            get { return _AssetName; }
            set { _AssetName = value; }
        }

        [DataMember]
        public String ImageUrl
        {
            get { return _ImageUrl; }
            set { _ImageUrl = value; }
        }

        [DataMember]
        public Int64? UnitID
        {
            get { return _UnitID; }
            set { _UnitID = value; }
        }

        [DataMember]
        public String Description
        {
            get { return _Description; }
            set { _Description = value; }
        }

        [DataMember]
        public Int64? BrandID
        {
            get { return _BrandID; }
            set { _BrandID = value; }
        }

        [DataMember]
        public Int64? SupplierID
        {
            get { return _SupplierID; }
            set { _SupplierID = value; }
        }

        [DataMember]
        public DateTime? NextMaintananceDate
        {
            get { return _NextMaintananceDate; }
            set { _NextMaintananceDate = value; }
        }

        [DataMember]
        public String UsedOrHandeledBy
        {
            get { return _UsedOrHandeledBy; }
            set { _UsedOrHandeledBy = value; }
        }

        [DataMember]
        public Int64? ProjectFloorUnitID
        {
            get { return _ProjectFloorUnitID; }
            set { _ProjectFloorUnitID = value; }
        }

        [DataMember]
        public Int64? ProjectUnitLocationID
        {
            get { return _ProjectUnitLocationID; }
            set { _ProjectUnitLocationID = value; }
        }

        [DataMember]
        public Int64 AssetOwnerTypeID
        {
            get { return _AssetOwnerTypeID; }
            set { _AssetOwnerTypeID = value; }
        }

        [DataMember]
        public Int64? OwnerReferenceID
        {
            get { return _OwnerReferenceID; }
            set { _OwnerReferenceID = value; }
        }

        [DataMember]
        public Int64? CurrentLocationProjectID
        {
            get { return _CurrentLocationProjectID; }
            set { _CurrentLocationProjectID = value; }
        }

        [DataMember]
        public String InsuranceInformation
        {
            get { return _InsuranceInformation; }
            set { _InsuranceInformation = value; }
        }

        [DataMember]
        public String ServiceContractInformation
        {
            get { return _ServiceContractInformation; }
            set { _ServiceContractInformation = value; }
        }

        [DataMember]
        public Decimal Price
        {
            get { return _Price; }
            set { _Price = value; }
        }

        [DataMember]
        public Int64? WorkOrderID
        {
            get { return _WorkOrderID; }
            set { _WorkOrderID = value; }
        }

        [DataMember]
        public String Remarks
        {
            get { return _Remarks; }
            set { _Remarks = value; }
        }

        [DataMember]
        public Int64 AssetConditionID
        {
            get { return _AssetConditionID; }
            set { _AssetConditionID = value; }
        }

        [DataMember]
        public Boolean IsRemoved
        {
            get { return _IsRemoved; }
            set { _IsRemoved = value; }
        }

        [DataMember]
        public String Medium
        {
            get { return _Medium; }
            set { _Medium = value; }
        }

        [DataMember]
        public Decimal? Width
        {
            get { return _Width; }
            set { _Width = value; }
        }

        [DataMember]
        public Decimal? Height
        {
            get { return _Height; }
            set { _Height = value; }
        }

        [DataMember]
        public Decimal? PresentBookValue
        {
            get { return _PresentBookValue; }
            set { _PresentBookValue = value; }
        }

        [XmlIgnore()]
        public override bool IsNew
        {
            [DebuggerStepThrough()]
            get
            {
                return (AssetID <= 0);
            }
        }


        #endregion

        #region Constructor

        public MDAssetEntity() : base()
        {
        }

        #endregion

        #region Constant

        public const String FLD_NAME_AssetID = "AssetID";
        public const String FLD_NAME_AssetCateogryID = "AssetCateogryID";
        public const String FLD_NAME_AssetCode = "AssetCode";
        public const String FLD_NAME_AssetName = "AssetName";
        public const String FLD_NAME_ImageUrl = "ImageUrl";
        public const String FLD_NAME_UnitID = "UnitID";
        public const String FLD_NAME_Description = "Description";
        public const String FLD_NAME_BrandID = "BrandID";
        public const String FLD_NAME_SupplierID = "SupplierID";
        public const String FLD_NAME_NextMaintananceDate = "NextMaintananceDate";
        public const String FLD_NAME_UsedOrHandeledBy = "UsedOrHandeledBy";
        public const String FLD_NAME_ProjectFloorUnitID = "ProjectFloorUnitID";
        public const String FLD_NAME_ProjectUnitLocationID = "ProjectUnitLocationID";
        public const String FLD_NAME_AssetOwnerTypeID = "AssetOwnerTypeID";
        public const String FLD_NAME_OwnerReferenceID = "OwnerReferenceID";
        public const String FLD_NAME_CurrentLocationProjectID = "CurrentLocationProjectID";
        public const String FLD_NAME_InsuranceInformation = "InsuranceInformation";
        public const String FLD_NAME_ServiceContractInformation = "ServiceContractInformation";
        public const String FLD_NAME_Price = "Price";
        public const String FLD_NAME_WorkOrderID = "WorkOrderID";
        public const String FLD_NAME_Remarks = "Remarks";
        public const String FLD_NAME_AssetConditionID = "AssetConditionID";
        public const String FLD_NAME_IsRemoved = "IsRemoved";
        public const String FLD_NAME_Medium = "Medium";
        public const String FLD_NAME_Width = "Width";
        public const String FLD_NAME_Height = "Height";
        public const String FLD_NAME_PresentBookValue = "PresentBookValue";

        #endregion
    }
}
