// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 14-Aug-2013, 02:50:29




using System;
using System.Diagnostics;
using System.ServiceModel;
using System.Runtime.Serialization;
using System.Collections.Generic;
using System.Xml.Serialization;


namespace Bay.ERP.Common.BusinessEntities
{
    [Serializable]
    [DataContract(Name = "CMBillFloorDetail", Namespace = "http://www.e-p-m-s.com/types")]
    public partial class CMBillFloorDetailEntity : BaseEntity
    {
        #region Properties


        private Int64 _BillFloorDetailID;
        private Int64 _BillID;
        private Int64 _BillFloorDetailCategoryID;
        private Int64 _ProjectFloorID;
        private Int64? _ProjectFloorUnitID;
        private Decimal? _FloorBillAmount;
        private String _Remarks;
        private DateTime _EntryDate;
        private String _Extra1;
        private String _Extra2;


        [DataMember]
        public Int64 BillFloorDetailID
        {
            get { return _BillFloorDetailID; }
            set { _BillFloorDetailID = value; }
        }

        [DataMember]
        public Int64 BillID
        {
            get { return _BillID; }
            set { _BillID = value; }
        }

        [DataMember]
        public Int64 BillFloorDetailCategoryID
        {
            get { return _BillFloorDetailCategoryID; }
            set { _BillFloorDetailCategoryID = value; }
        }

        [DataMember]
        public Int64 ProjectFloorID
        {
            get { return _ProjectFloorID; }
            set { _ProjectFloorID = value; }
        }

        [DataMember]
        public Int64? ProjectFloorUnitID
        {
            get { return _ProjectFloorUnitID; }
            set { _ProjectFloorUnitID = value; }
        }

        [DataMember]
        public Decimal? FloorBillAmount
        {
            get { return _FloorBillAmount; }
            set { _FloorBillAmount = value; }
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
        public String Extra1
        {
            get { return _Extra1; }
            set { _Extra1 = value; }
        }

        [DataMember]
        public String Extra2
        {
            get { return _Extra2; }
            set { _Extra2 = value; }
        }

        [XmlIgnore()]
        public override bool IsNew
        {
            [DebuggerStepThrough()]
            get
            {
                return (BillFloorDetailID <= 0);
            }
        }


        #endregion

        #region Constructor

        public CMBillFloorDetailEntity() : base()
        {
        }

        #endregion

        #region Constant

        public const String FLD_NAME_BillFloorDetailID = "BillFloorDetailID";
        public const String FLD_NAME_BillID = "BillID";
        public const String FLD_NAME_BillFloorDetailCategoryID = "BillFloorDetailCategoryID";
        public const String FLD_NAME_ProjectFloorID = "ProjectFloorID";
        public const String FLD_NAME_ProjectFloorUnitID = "ProjectFloorUnitID";
        public const String FLD_NAME_FloorBillAmount = "FloorBillAmount";
        public const String FLD_NAME_Remarks = "Remarks";
        public const String FLD_NAME_EntryDate = "EntryDate";
        public const String FLD_NAME_Extra1 = "Extra1";
        public const String FLD_NAME_Extra2 = "Extra2";

        #endregion
    }
}
