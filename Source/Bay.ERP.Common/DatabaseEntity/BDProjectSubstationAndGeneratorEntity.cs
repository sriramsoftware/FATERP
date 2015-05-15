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
    [DataContract(Name = "BDProjectSubstationAndGenerator", Namespace = "http://www.e-p-m-s.com/types")]
    public partial class BDProjectSubstationAndGeneratorEntity : BaseEntity
    {
        #region Properties


        private Int64 _ProjectSubstationAndGeneratorID;
        private Int64 _ProjectID;
        private Decimal _CapacityOfSubstation;
        private Decimal _TotalNumberOfGenerator;
        private Decimal _CapacityOfGenerator1;
        private Decimal? _CapacityOfGenerator2;
        private Decimal? _CapacityOfGenerator3;
        private Decimal? _CapacityOfGenerator4;
        private Decimal? _CapacityOfGenerator5;
        private Int64 _BrandID;


        [DataMember]
        public Int64 ProjectSubstationAndGeneratorID
        {
            get { return _ProjectSubstationAndGeneratorID; }
            set { _ProjectSubstationAndGeneratorID = value; }
        }

        [DataMember]
        public Int64 ProjectID
        {
            get { return _ProjectID; }
            set { _ProjectID = value; }
        }

        [DataMember]
        public Decimal CapacityOfSubstation
        {
            get { return _CapacityOfSubstation; }
            set { _CapacityOfSubstation = value; }
        }

        [DataMember]
        public Decimal TotalNumberOfGenerator
        {
            get { return _TotalNumberOfGenerator; }
            set { _TotalNumberOfGenerator = value; }
        }

        [DataMember]
        public Decimal CapacityOfGenerator1
        {
            get { return _CapacityOfGenerator1; }
            set { _CapacityOfGenerator1 = value; }
        }

        [DataMember]
        public Decimal? CapacityOfGenerator2
        {
            get { return _CapacityOfGenerator2; }
            set { _CapacityOfGenerator2 = value; }
        }

        [DataMember]
        public Decimal? CapacityOfGenerator3
        {
            get { return _CapacityOfGenerator3; }
            set { _CapacityOfGenerator3 = value; }
        }

        [DataMember]
        public Decimal? CapacityOfGenerator4
        {
            get { return _CapacityOfGenerator4; }
            set { _CapacityOfGenerator4 = value; }
        }

        [DataMember]
        public Decimal? CapacityOfGenerator5
        {
            get { return _CapacityOfGenerator5; }
            set { _CapacityOfGenerator5 = value; }
        }

        [DataMember]
        public Int64 BrandID
        {
            get { return _BrandID; }
            set { _BrandID = value; }
        }

        [XmlIgnore()]
        public override bool IsNew
        {
            [DebuggerStepThrough()]
            get
            {
                return (ProjectSubstationAndGeneratorID <= 0);
            }
        }


        #endregion

        #region Constructor

        public BDProjectSubstationAndGeneratorEntity() : base()
        {
        }

        #endregion

        #region Constant

        public const String FLD_NAME_ProjectSubstationAndGeneratorID = "ProjectSubstationAndGeneratorID";
        public const String FLD_NAME_ProjectID = "ProjectID";
        public const String FLD_NAME_CapacityOfSubstation = "CapacityOfSubstation";
        public const String FLD_NAME_TotalNumberOfGenerator = "TotalNumberOfGenerator";
        public const String FLD_NAME_CapacityOfGenerator1 = "CapacityOfGenerator1";
        public const String FLD_NAME_CapacityOfGenerator2 = "CapacityOfGenerator2";
        public const String FLD_NAME_CapacityOfGenerator3 = "CapacityOfGenerator3";
        public const String FLD_NAME_CapacityOfGenerator4 = "CapacityOfGenerator4";
        public const String FLD_NAME_CapacityOfGenerator5 = "CapacityOfGenerator5";
        public const String FLD_NAME_BrandID = "BrandID";

        #endregion
    }
}
