// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 04-Oct-2012, 03:40:52




using System;
using System.Diagnostics;
using System.ServiceModel;
using System.Runtime.Serialization;
using System.Collections.Generic;
using System.Xml.Serialization;


namespace Bay.ERP.Common.BusinessEntities
{
    [Serializable]
    [DataContract(Name = "CMMeasurementBookDetail_Detailed", Namespace = "http://www.e-p-m-s.com/types")]
    public partial class CMMeasurementBookDetail_DetailedEntity : BaseEntity
    {
        #region Properties


        private Int64 _MeasurementBookDetailID;
        private Int64? _MeasurementBookID;
        private String _Description;
        private Int64 _UnitID;
        private Decimal? _Lengthft;
        private Decimal? _Lenghtin;
        private Decimal? _Widthft;
        private Decimal? _Widthin;
        private Decimal? _Heightft;
        private Decimal? _Heightin;
        private Decimal _Nos;
        private Decimal _Qty;
        private Int64? _CMMeasurementBookProjectID;
        private String _UnitName;
        private Int64? _RowNumber;


        [DataMember]
        public Int64 MeasurementBookDetailID
        {
            get { return _MeasurementBookDetailID; }
            set { _MeasurementBookDetailID = value; }
        }

        [DataMember]
        public Int64? MeasurementBookID
        {
            get { return _MeasurementBookID; }
            set { _MeasurementBookID = value; }
        }

        [DataMember]
        public String Description
        {
            get { return _Description; }
            set { _Description = value; }
        }

        [DataMember]
        public Int64 UnitID
        {
            get { return _UnitID; }
            set { _UnitID = value; }
        }

        [DataMember]
        public Decimal? Lengthft
        {
            get { return _Lengthft; }
            set { _Lengthft = value; }
        }

        [DataMember]
        public Decimal? Lenghtin
        {
            get { return _Lenghtin; }
            set { _Lenghtin = value; }
        }

        [DataMember]
        public Decimal? Widthft
        {
            get { return _Widthft; }
            set { _Widthft = value; }
        }

        [DataMember]
        public Decimal? Widthin
        {
            get { return _Widthin; }
            set { _Widthin = value; }
        }

        [DataMember]
        public Decimal? Heightft
        {
            get { return _Heightft; }
            set { _Heightft = value; }
        }

        [DataMember]
        public Decimal? Heightin
        {
            get { return _Heightin; }
            set { _Heightin = value; }
        }

        [DataMember]
        public Decimal Nos
        {
            get { return _Nos; }
            set { _Nos = value; }
        }

        [DataMember]
        public Decimal Qty
        {
            get { return _Qty; }
            set { _Qty = value; }
        }

        [DataMember]
        public Int64? CMMeasurementBookProjectID
        {
            get { return _CMMeasurementBookProjectID; }
            set { _CMMeasurementBookProjectID = value; }
        }

        [DataMember]
        public String UnitName
        {
            get { return _UnitName; }
            set { _UnitName = value; }
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
                return (MeasurementBookDetailID <= 0);
            }
        }


        #endregion

        #region Constructor

        public CMMeasurementBookDetail_DetailedEntity() : base()
        {
        }

        #endregion

        #region Constant

        public const String FLD_NAME_MeasurementBookDetailID = "MeasurementBookDetailID";
        public const String FLD_NAME_MeasurementBookID = "MeasurementBookID";
        public const String FLD_NAME_Description = "Description";
        public const String FLD_NAME_UnitID = "UnitID";
        public const String FLD_NAME_Lengthft = "Lengthft";
        public const String FLD_NAME_Lenghtin = "Lenghtin";
        public const String FLD_NAME_Widthft = "Widthft";
        public const String FLD_NAME_Widthin = "Widthin";
        public const String FLD_NAME_Heightft = "Heightft";
        public const String FLD_NAME_Heightin = "Heightin";
        public const String FLD_NAME_Nos = "Nos";
        public const String FLD_NAME_Qty = "Qty";
        public const String FLD_NAME_CMMeasurementBookProjectID = "CMMeasurementBookProjectID";
        public const String FLD_NAME_UnitName = "UnitName";
        public const String FLD_NAME_RowNumber = "RowNumber";

        #endregion
    }
}
