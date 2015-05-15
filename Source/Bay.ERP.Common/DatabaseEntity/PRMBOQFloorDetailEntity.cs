// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 05-Feb-2013, 10:55:37




using System;
using System.Diagnostics;
using System.ServiceModel;
using System.Runtime.Serialization;
using System.Collections.Generic;
using System.Xml.Serialization;


namespace Bay.ERP.Common.BusinessEntities
{
    [Serializable]
    [DataContract(Name = "PRMBOQFloorDetail", Namespace = "http://www.e-p-m-s.com/types")]
    public partial class PRMBOQFloorDetailEntity : BaseEntity
    {
        #region Properties


        private Int64 _BOQFloorDetailID;
        private Int64 _BOQDetailID;
        private Int64 _ProjectFloorID;
        private Decimal? _Qty;
        private Decimal? _Rate;
        private String _Remarks;
        private DateTime _EntryDate;


        [DataMember]
        public Int64 BOQFloorDetailID
        {
            get { return _BOQFloorDetailID; }
            set { _BOQFloorDetailID = value; }
        }

        [DataMember]
        public Int64 BOQDetailID
        {
            get { return _BOQDetailID; }
            set { _BOQDetailID = value; }
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

        [XmlIgnore()]
        public override bool IsNew
        {
            [DebuggerStepThrough()]
            get
            {
                return (BOQFloorDetailID <= 0);
            }
        }


        #endregion

        #region Constructor

        public PRMBOQFloorDetailEntity() : base()
        {
        }

        #endregion

        #region Constant

        public const String FLD_NAME_BOQFloorDetailID = "BOQFloorDetailID";
        public const String FLD_NAME_BOQDetailID = "BOQDetailID";
        public const String FLD_NAME_ProjectFloorID = "ProjectFloorID";
        public const String FLD_NAME_Qty = "Qty";
        public const String FLD_NAME_Rate = "Rate";
        public const String FLD_NAME_Remarks = "Remarks";
        public const String FLD_NAME_EntryDate = "EntryDate";

        #endregion
    }
}
