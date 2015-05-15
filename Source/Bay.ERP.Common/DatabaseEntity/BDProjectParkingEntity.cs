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
    [DataContract(Name = "BDProjectParking", Namespace = "http://www.e-p-m-s.com/types")]
    public partial class BDProjectParkingEntity : BaseEntity
    {
        #region Properties


        private Int64 _ProjectParkingID;
        private Int64 _ProjectID;
        private Decimal _Ground;
        private Decimal? _LowerGround;
        private Decimal? _Basement1;
        private Decimal? _Basement2;
        private Decimal? _Basement3;
        private Decimal? _Basement4;
        private Decimal? _Basement5;
        private Decimal? _Basement6;
        private Decimal? _Outdoor;
        private Decimal _Total;
        private Decimal _GuestParking;
        private Decimal? _DisableParking;


        [DataMember]
        public Int64 ProjectParkingID
        {
            get { return _ProjectParkingID; }
            set { _ProjectParkingID = value; }
        }

        [DataMember]
        public Int64 ProjectID
        {
            get { return _ProjectID; }
            set { _ProjectID = value; }
        }

        [DataMember]
        public Decimal Ground
        {
            get { return _Ground; }
            set { _Ground = value; }
        }

        [DataMember]
        public Decimal? LowerGround
        {
            get { return _LowerGround; }
            set { _LowerGround = value; }
        }

        [DataMember]
        public Decimal? Basement1
        {
            get { return _Basement1; }
            set { _Basement1 = value; }
        }

        [DataMember]
        public Decimal? Basement2
        {
            get { return _Basement2; }
            set { _Basement2 = value; }
        }

        [DataMember]
        public Decimal? Basement3
        {
            get { return _Basement3; }
            set { _Basement3 = value; }
        }

        [DataMember]
        public Decimal? Basement4
        {
            get { return _Basement4; }
            set { _Basement4 = value; }
        }

        [DataMember]
        public Decimal? Basement5
        {
            get { return _Basement5; }
            set { _Basement5 = value; }
        }

        [DataMember]
        public Decimal? Basement6
        {
            get { return _Basement6; }
            set { _Basement6 = value; }
        }

        [DataMember]
        public Decimal? Outdoor
        {
            get { return _Outdoor; }
            set { _Outdoor = value; }
        }

        [DataMember]
        public Decimal Total
        {
            get { return _Total; }
            set { _Total = value; }
        }

        [DataMember]
        public Decimal GuestParking
        {
            get { return _GuestParking; }
            set { _GuestParking = value; }
        }

        [DataMember]
        public Decimal? DisableParking
        {
            get { return _DisableParking; }
            set { _DisableParking = value; }
        }

        [XmlIgnore()]
        public override bool IsNew
        {
            [DebuggerStepThrough()]
            get
            {
                return (ProjectParkingID <= 0);
            }
        }


        #endregion

        #region Constructor

        public BDProjectParkingEntity() : base()
        {
        }

        #endregion

        #region Constant

        public const String FLD_NAME_ProjectParkingID = "ProjectParkingID";
        public const String FLD_NAME_ProjectID = "ProjectID";
        public const String FLD_NAME_Ground = "Ground";
        public const String FLD_NAME_LowerGround = "LowerGround";
        public const String FLD_NAME_Basement1 = "Basement1";
        public const String FLD_NAME_Basement2 = "Basement2";
        public const String FLD_NAME_Basement3 = "Basement3";
        public const String FLD_NAME_Basement4 = "Basement4";
        public const String FLD_NAME_Basement5 = "Basement5";
        public const String FLD_NAME_Basement6 = "Basement6";
        public const String FLD_NAME_Outdoor = "Outdoor";
        public const String FLD_NAME_Total = "Total";
        public const String FLD_NAME_GuestParking = "GuestParking";
        public const String FLD_NAME_DisableParking = "DisableParking";

        #endregion
    }
}
