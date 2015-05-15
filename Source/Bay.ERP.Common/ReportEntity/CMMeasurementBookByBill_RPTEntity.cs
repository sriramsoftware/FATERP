// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 22-Oct-2012, 01:00:56




using System;
using System.Diagnostics;
using System.ServiceModel;
using System.Runtime.Serialization;
using System.Collections.Generic;
using System.Xml.Serialization;


namespace Bay.ERP.Common.BusinessEntities
{
    [Serializable]
    [DataContract(Name = "CMMeasurementBookByBill_RPT", Namespace = "http://www.e-p-m-s.com/types")]
    public partial class CMMeasurementBookByBill_RPTEntity : BaseEntity
    {
        #region Properties


        private Int64 _MeasurementBookID;
        private Int64 _ProjectID;
        private String _ProjectCode;
        private Int64 _SupplierID;
        private Int64? _BillID;
        private Int64? _WorkOrderID;
        private Int64 _ItemID;
        private DateTime _CreateDate;
        private String _Description;
        private Int64? _UnitID;
        private Decimal? _Lengthft;
        private Decimal? _Lenghtin;
        private Decimal? _Widthft;
        private Decimal? _Widthin;
        private Decimal? _Heightft;
        private Decimal? _Heightin;
        private Decimal? _Nos;
        private Decimal? _Qty;
        private String _BillNo;
        private String _UnitName;
        private String _ItemName;


        [DataMember]
        public Int64 MeasurementBookID
        {
            get { return _MeasurementBookID; }
            set { _MeasurementBookID = value; }
        }

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
        public Int64 SupplierID
        {
            get { return _SupplierID; }
            set { _SupplierID = value; }
        }

        [DataMember]
        public Int64? BillID
        {
            get { return _BillID; }
            set { _BillID = value; }
        }

        [DataMember]
        public Int64? WorkOrderID
        {
            get { return _WorkOrderID; }
            set { _WorkOrderID = value; }
        }

        [DataMember]
        public Int64 ItemID
        {
            get { return _ItemID; }
            set { _ItemID = value; }
        }

        [DataMember]
        public DateTime CreateDate
        {
            get { return _CreateDate; }
            set { _CreateDate = value; }
        }

        [DataMember]
        public String Description
        {
            get { return _Description; }
            set { _Description = value; }
        }

        [DataMember]
        public Int64? UnitID
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
        public Decimal? Nos
        {
            get { return _Nos; }
            set { _Nos = value; }
        }

        [DataMember]
        public Decimal? Qty
        {
            get { return _Qty; }
            set { _Qty = value; }
        }

        [DataMember]
        public String BillNo
        {
            get { return _BillNo; }
            set { _BillNo = value; }
        }

        [DataMember]
        public String UnitName
        {
            get { return _UnitName; }
            set { _UnitName = value; }
        }

        [DataMember]
        public String ItemName
        {
            get { return _ItemName; }
            set { _ItemName = value; }
        }

        [XmlIgnore()]
        public override bool IsNew
        {
            [DebuggerStepThrough()]
            get
            {
                return (MeasurementBookID <= 0);
            }
        }


        #endregion

        #region Constructor

        public CMMeasurementBookByBill_RPTEntity() : base()
        {
        }

        #endregion

        #region Constant

        public const String FLD_NAME_MeasurementBookID = "MeasurementBookID";
        public const String FLD_NAME_ProjectID = "ProjectID";
        public const String FLD_NAME_ProjectCode = "ProjectCode";
        public const String FLD_NAME_SupplierID = "SupplierID";
        public const String FLD_NAME_BillID = "BillID";
        public const String FLD_NAME_WorkOrderID = "WorkOrderID";
        public const String FLD_NAME_ItemID = "ItemID";
        public const String FLD_NAME_CreateDate = "CreateDate";
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
        public const String FLD_NAME_BillNo = "BillNo";
        public const String FLD_NAME_UnitName = "UnitName";
        public const String FLD_NAME_ItemName = "ItemName";

        #endregion
    }
}
