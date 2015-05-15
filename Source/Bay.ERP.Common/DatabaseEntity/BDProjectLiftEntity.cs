// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 22-Jun-2013, 02:07:00




using System;
using System.Diagnostics;
using System.ServiceModel;
using System.Runtime.Serialization;
using System.Collections.Generic;
using System.Xml.Serialization;


namespace Bay.ERP.Common.BusinessEntities
{
    [Serializable]
    [DataContract(Name = "BDProjectLift", Namespace = "http://www.e-p-m-s.com/types")]
    public partial class BDProjectLiftEntity : BaseEntity
    {
        #region Properties


        private Int64 _ProjectLiftID;
        private Int64 _ProjectID;
        private Decimal _NumberOfLift;
        private Int64? _LiftBrandID;
        private Int64? _LiftBrandSupplierID;
        private Decimal _NumberOfPassengerLift;
        private Int64? _PassengerLiftBrandID;
        private Int64? _PassengerLiftBrandSupplierID;
        private Decimal? _CapacityOfPassengerLift;
        private Decimal? _NumberOfServiceLift;
        private Int64? _ServiceLiftBrandID;
        private Int64? _ServiceLiftBrandSupplierID;
        private Decimal? _CapacityOfServiceLift;
        private Decimal? _NumberOfFireFighterLift;
        private Int64 _BrandID;
        private Int64? _BrandSupplierID;


        [DataMember]
        public Int64 ProjectLiftID
        {
            get { return _ProjectLiftID; }
            set { _ProjectLiftID = value; }
        }

        [DataMember]
        public Int64 ProjectID
        {
            get { return _ProjectID; }
            set { _ProjectID = value; }
        }

        [DataMember]
        public Decimal NumberOfLift
        {
            get { return _NumberOfLift; }
            set { _NumberOfLift = value; }
        }

        [DataMember]
        public Int64? LiftBrandID
        {
            get { return _LiftBrandID; }
            set { _LiftBrandID = value; }
        }

        [DataMember]
        public Int64? LiftBrandSupplierID
        {
            get { return _LiftBrandSupplierID; }
            set { _LiftBrandSupplierID = value; }
        }

        [DataMember]
        public Decimal NumberOfPassengerLift
        {
            get { return _NumberOfPassengerLift; }
            set { _NumberOfPassengerLift = value; }
        }

        [DataMember]
        public Int64? PassengerLiftBrandID
        {
            get { return _PassengerLiftBrandID; }
            set { _PassengerLiftBrandID = value; }
        }

        [DataMember]
        public Int64? PassengerLiftBrandSupplierID
        {
            get { return _PassengerLiftBrandSupplierID; }
            set { _PassengerLiftBrandSupplierID = value; }
        }

        [DataMember]
        public Decimal? CapacityOfPassengerLift
        {
            get { return _CapacityOfPassengerLift; }
            set { _CapacityOfPassengerLift = value; }
        }

        [DataMember]
        public Decimal? NumberOfServiceLift
        {
            get { return _NumberOfServiceLift; }
            set { _NumberOfServiceLift = value; }
        }

        [DataMember]
        public Int64? ServiceLiftBrandID
        {
            get { return _ServiceLiftBrandID; }
            set { _ServiceLiftBrandID = value; }
        }

        [DataMember]
        public Int64? ServiceLiftBrandSupplierID
        {
            get { return _ServiceLiftBrandSupplierID; }
            set { _ServiceLiftBrandSupplierID = value; }
        }

        [DataMember]
        public Decimal? CapacityOfServiceLift
        {
            get { return _CapacityOfServiceLift; }
            set { _CapacityOfServiceLift = value; }
        }

        [DataMember]
        public Decimal? NumberOfFireFighterLift
        {
            get { return _NumberOfFireFighterLift; }
            set { _NumberOfFireFighterLift = value; }
        }

        [DataMember]
        public Int64 BrandID
        {
            get { return _BrandID; }
            set { _BrandID = value; }
        }

        [DataMember]
        public Int64? BrandSupplierID
        {
            get { return _BrandSupplierID; }
            set { _BrandSupplierID = value; }
        }

        [XmlIgnore()]
        public override bool IsNew
        {
            [DebuggerStepThrough()]
            get
            {
                return (ProjectLiftID <= 0);
            }
        }


        #endregion

        #region Constructor

        public BDProjectLiftEntity() : base()
        {
        }

        #endregion

        #region Constant

        public const String FLD_NAME_ProjectLiftID = "ProjectLiftID";
        public const String FLD_NAME_ProjectID = "ProjectID";
        public const String FLD_NAME_NumberOfLift = "NumberOfLift";
        public const String FLD_NAME_LiftBrandID = "LiftBrandID;";
        public const String FLD_NAME_LiftBrandSupplierID = "LiftBrandSupplierID;";
        public const String FLD_NAME_NumberOfPassengerLift = "NumberOfPassengerLift";
        public const String FLD_NAME_PassengerLiftBrandID = "PassengerLiftBrandID";
        public const String FLD_NAME_PassengerLiftBrandSupplierID = "PassengerLiftBrandSupplierID";
        public const String FLD_NAME_CapacityOfPassengerLift = "CapacityOfPassengerLift";
        public const String FLD_NAME_NumberOfServiceLift = "NumberOfServiceLift";
        public const String FLD_NAME_ServiceLiftBrandID = "ServiceLiftBrandID";
        public const String FLD_NAME_ServiceLiftBrandSupplierID = "ServiceLiftBrandSupplierID";
        public const String FLD_NAME_CapacityOfServiceLift = "CapacityOfServiceLift";
        public const String FLD_NAME_NumberOfFireFighterLift = "NumberOfFireFighterLift";
        public const String FLD_NAME_BrandID = "BrandID";
        public const String FLD_NAME_BrandSupplierID = "BrandSupplierID";

        #endregion
    }
}
