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
    [DataContract(Name = "BDProjectOtherInfo", Namespace = "http://www.e-p-m-s.com/types")]
    public partial class BDProjectOtherInfoEntity : BaseEntity
    {
        #region Properties


        private Int64 _ProjectOtherInfoID;
        private Int64 _ProjectID;
        private Decimal? _TBA;
        private Int64? _TBAUnitID;
        private Decimal? _FAR;
        private Decimal? _FARBonus;
        private Decimal? _FIA;
        private Int64? _FIAUnitID;
        private Decimal? _FIAAchieved;
        private Int64? _FIAAchievedUnitID;
        private Decimal? _GSA;
        private Int64? _GSAUnitID;
        private Decimal? _MGCPercentages;
        private Decimal? _MGCArea;
        private Int64? _MGCAreaUnitID;
        private String _GroundCoverage;
        private DateTime? _DateOfAgreement;
        private DateTime? _DateOfHandover;
        private String _DelayClause;


        [DataMember]
        public Int64 ProjectOtherInfoID
        {
            get { return _ProjectOtherInfoID; }
            set { _ProjectOtherInfoID = value; }
        }

        [DataMember]
        public Int64 ProjectID
        {
            get { return _ProjectID; }
            set { _ProjectID = value; }
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
        public Decimal? FARBonus
        {
            get { return _FARBonus; }
            set { _FARBonus = value; }
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
        public Decimal? FIAAchieved
        {
            get { return _FIAAchieved; }
            set { _FIAAchieved = value; }
        }

        [DataMember]
        public Int64? FIAAchievedUnitID
        {
            get { return _FIAAchievedUnitID; }
            set { _FIAAchievedUnitID = value; }
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
        public Decimal? MGCPercentages
        {
            get { return _MGCPercentages; }
            set { _MGCPercentages = value; }
        }

        [DataMember]
        public Decimal? MGCArea
        {
            get { return _MGCArea; }
            set { _MGCArea = value; }
        }

        [DataMember]
        public Int64? MGCAreaUnitID
        {
            get { return _MGCAreaUnitID; }
            set { _MGCAreaUnitID = value; }
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

        [XmlIgnore()]
        public override bool IsNew
        {
            [DebuggerStepThrough()]
            get
            {
                return (ProjectOtherInfoID <= 0);
            }
        }


        #endregion

        #region Constructor

        public BDProjectOtherInfoEntity() : base()
        {
        }

        #endregion

        #region Constant

        public const String FLD_NAME_ProjectOtherInfoID = "ProjectOtherInfoID";
        public const String FLD_NAME_ProjectID = "ProjectID";
        public const String FLD_NAME_TBA = "TBA";
        public const String FLD_NAME_TBAUnitID = "TBAUnitID";
        public const String FLD_NAME_FAR = "FAR";
        public const String FLD_NAME_FARBonus = "FARBonus";
        public const String FLD_NAME_FIA = "FIA";
        public const String FLD_NAME_FIAUnitID = "FIAUnitID";
        public const String FLD_NAME_FIAAchieved = "FIAAchieved";
        public const String FLD_NAME_FIAAchievedUnitID = "FIAAchievedUnitID";
        public const String FLD_NAME_GSA = "GSA";
        public const String FLD_NAME_GSAUnitID = "GSAUnitID";
        public const String FLD_NAME_MGCPercentages = "MGCPercentages";
        public const String FLD_NAME_MGCArea = "MGCArea";
        public const String FLD_NAME_MGCAreaUnitID = "MGCAreaUnitID";
        public const String FLD_NAME_GroundCoverage = "GroundCoverage";
        public const String FLD_NAME_DateOfAgreement = "DateOfAgreement";
        public const String FLD_NAME_DateOfHandover = "DateOfHandover";
        public const String FLD_NAME_DelayClause = "DelayClause";

        #endregion
    }
}
