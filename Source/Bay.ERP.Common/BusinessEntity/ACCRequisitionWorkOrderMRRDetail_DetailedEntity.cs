// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 21-Jan-2013, 04:58:29




using System;
using System.Diagnostics;
using System.ServiceModel;
using System.Runtime.Serialization;
using System.Collections.Generic;
using System.Xml.Serialization;


namespace Bay.ERP.Common.BusinessEntities
{
    [Serializable]
    [DataContract(Name = "ACCRequisitionWorkOrderMRRDetail_Detailed", Namespace = "http://www.e-p-m-s.com/types")]
    public partial class ACCRequisitionWorkOrderMRRDetail_DetailedEntity : BaseEntity
    {
        #region Properties


        private Int64 _RequisitionItemID;
        private String _ProjectCode;
        private String _ProjectName;
        private String _RequisitionNo;
        private DateTime _RequisitionDate;
        private String _ItemName;
        private Int64 _BrandID;
        private Int64 _RegionID;
        private Int64 _CountryID;
        private Decimal _RequisitionQty;
        private Decimal? _WORequiredQty;
        private Decimal? _MRRQty;
        private String _BrandName;
        private String _OriginRegionName;
        private String _OriginCountryName;
        private Int64? _RowNumber;


        [DataMember]
        public Int64 RequisitionItemID
        {
            get { return _RequisitionItemID; }
            set { _RequisitionItemID = value; }
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
        public String RequisitionNo
        {
            get { return _RequisitionNo; }
            set { _RequisitionNo = value; }
        }

        [DataMember]
        public DateTime RequisitionDate
        {
            get { return _RequisitionDate; }
            set { _RequisitionDate = value; }
        }

        [DataMember]
        public String ItemName
        {
            get { return _ItemName; }
            set { _ItemName = value; }
        }

        [DataMember]
        public Int64 BrandID
        {
            get { return _BrandID; }
            set { _BrandID = value; }
        }

        [DataMember]
        public Int64 RegionID
        {
            get { return _RegionID; }
            set { _RegionID = value; }
        }

        [DataMember]
        public Int64 CountryID
        {
            get { return _CountryID; }
            set { _CountryID = value; }
        }

        [DataMember]
        public Decimal RequisitionQty
        {
            get { return _RequisitionQty; }
            set { _RequisitionQty = value; }
        }

        [DataMember]
        public Decimal? WORequiredQty
        {
            get { return _WORequiredQty; }
            set { _WORequiredQty = value; }
        }

        [DataMember]
        public Decimal? MRRQty
        {
            get { return _MRRQty; }
            set { _MRRQty = value; }
        }

        [DataMember]
        public String BrandName
        {
            get { return _BrandName; }
            set { _BrandName = value; }
        }

        [DataMember]
        public String OriginRegionName
        {
            get { return _OriginRegionName; }
            set { _OriginRegionName = value; }
        }

        [DataMember]
        public String OriginCountryName
        {
            get { return _OriginCountryName; }
            set { _OriginCountryName = value; }
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
                return (RequisitionItemID <= 0);
            }
        }


        #endregion

        #region Constructor

        public ACCRequisitionWorkOrderMRRDetail_DetailedEntity() : base()
        {
        }

        #endregion

        #region Constant

        public const String FLD_NAME_RequisitionItemID = "RequisitionItemID";
        public const String FLD_NAME_ProjectCode = "ProjectCode";
        public const String FLD_NAME_ProjectName = "ProjectName";
        public const String FLD_NAME_RequisitionNo = "RequisitionNo";
        public const String FLD_NAME_RequisitionDate = "RequisitionDate";
        public const String FLD_NAME_ItemName = "ItemName";
        public const String FLD_NAME_BrandID = "BrandID";
        public const String FLD_NAME_RegionID = "RegionID";
        public const String FLD_NAME_CountryID = "CountryID";
        public const String FLD_NAME_RequisitionQty = "RequisitionQty";
        public const String FLD_NAME_WORequiredQty = "WORequiredQty";
        public const String FLD_NAME_MRRQty = "MRRQty";
        public const String FLD_NAME_BrandName = "BrandName";
        public const String FLD_NAME_OriginRegionName = "OriginRegionName";
        public const String FLD_NAME_OriginCountryName = "OriginCountryName";
        public const String FLD_NAME_RowNumber = "RowNumber";

        #endregion
    }
}
