// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 18-Aug-2013, 05:14:41




using System;
using System.Diagnostics;
using System.ServiceModel;
using System.Runtime.Serialization;
using System.Collections.Generic;
using System.Xml.Serialization;


namespace Bay.ERP.Common.BusinessEntities
{
    [Serializable]
    [DataContract(Name = "PRMPreBOQFloorDetail_Detailed", Namespace = "http://www.e-p-m-s.com/types")]
    public partial class PRMPreBOQFloorDetail_DetailedEntity : BaseEntity
    {
        #region Properties


        private Int64 _PreBOQFloorDetailID;
        private Int64 _PreBOQDetailID;
        private Int64 _ProjectFloorID;
        private Decimal? _Qty;
        private Decimal? _Rate;
        private String _Remarks;
        private DateTime _EntryDate;
        private Int64? _PRMPreBOQDetailPreBOQID;
        private String _BDProjectFloorName;
        private Int64? _RowNumber;


        [DataMember]
        public Int64 PreBOQFloorDetailID
        {
            get { return _PreBOQFloorDetailID; }
            set { _PreBOQFloorDetailID = value; }
        }

        [DataMember]
        public Int64 PreBOQDetailID
        {
            get { return _PreBOQDetailID; }
            set { _PreBOQDetailID = value; }
        }

        [DataMember]
        public Int64 ProjectFloorID
        {
            get { return _ProjectFloorID; }
            set { _ProjectFloorID = value; }
        }

        [DataMember]
        public Decimal? Qty
        {
            get { return _Qty; }
            set { _Qty = value; }
        }

        [DataMember]
        public Decimal? Rate
        {
            get { return _Rate; }
            set { _Rate = value; }
        }

        [DataMember]
        public String Remarks
        {
            get { return _Remarks; }
            set { _Remarks = value; }
        }

        [DataMember]
        public DateTime EntryDate
        {
            get { return _EntryDate; }
            set { _EntryDate = value; }
        }

        [DataMember]
        public Int64? PRMPreBOQDetailPreBOQID
        {
            get { return _PRMPreBOQDetailPreBOQID; }
            set { _PRMPreBOQDetailPreBOQID = value; }
        }

        [DataMember]
        public String BDProjectFloorName
        {
            get { return _BDProjectFloorName; }
            set { _BDProjectFloorName = value; }
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
                return (PreBOQFloorDetailID <= 0);
            }
        }


        #endregion

        #region Constructor

        public PRMPreBOQFloorDetail_DetailedEntity() : base()
        {
        }

        #endregion

        #region Constant

        public const String FLD_NAME_PreBOQFloorDetailID = "PreBOQFloorDetailID";
        public const String FLD_NAME_PreBOQDetailID = "PreBOQDetailID";
        public const String FLD_NAME_ProjectFloorID = "ProjectFloorID";
        public const String FLD_NAME_Qty = "Qty";
        public const String FLD_NAME_Rate = "Rate";
        public const String FLD_NAME_Remarks = "Remarks";
        public const String FLD_NAME_EntryDate = "EntryDate";
        public const String FLD_NAME_PRMPreBOQDetailPreBOQID = "PRMPreBOQDetailPreBOQID";
        public const String FLD_NAME_BDProjectFloorName = "BDProjectFloorName";
        public const String FLD_NAME_RowNumber = "RowNumber";

        #endregion
    }
}
