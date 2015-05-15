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
    [DataContract(Name = "PRMMaterialReceiveItemMap", Namespace = "http://www.e-p-m-s.com/types")]
    public partial class PRMMaterialReceiveItemMapEntity : BaseEntity
    {
        #region Properties


        private Int64 _MaterialReceiveItemMapID;
        private Int64 _MaterialReceiveID;
        private Int64 _RequisitionItemID;
        private Decimal _WOItemTotalRate;
        private DateTime _ReceiveDate;
        private Decimal _ReceiveQty;
        private Decimal _ItemRate;
        private String _ChallanNo;


        [DataMember]
        public Int64 MaterialReceiveItemMapID
        {
            get { return _MaterialReceiveItemMapID; }
            set { _MaterialReceiveItemMapID = value; }
        }

        [DataMember]
        public Int64 MaterialReceiveID
        {
            get { return _MaterialReceiveID; }
            set { _MaterialReceiveID = value; }
        }

        [DataMember]
        public Int64 RequisitionItemID
        {
            get { return _RequisitionItemID; }
            set { _RequisitionItemID = value; }
        }

        [DataMember]
        public Decimal WOItemTotalRate
        {
            get { return _WOItemTotalRate; }
            set { _WOItemTotalRate = value; }
        }

        [DataMember]
        public DateTime ReceiveDate
        {
            get { return _ReceiveDate; }
            set { _ReceiveDate = value; }
        }

        [DataMember]
        public Decimal ReceiveQty
        {
            get { return _ReceiveQty; }
            set { _ReceiveQty = value; }
        }

        [DataMember]
        public Decimal ItemRate
        {
            get { return _ItemRate; }
            set { _ItemRate = value; }
        }

        [DataMember]
        public String ChallanNo
        {
            get { return _ChallanNo; }
            set { _ChallanNo = value; }
        }

        [XmlIgnore()]
        public override bool IsNew
        {
            [DebuggerStepThrough()]
            get
            {
                return (MaterialReceiveItemMapID <= 0);
            }
        }


        #endregion

        #region Constructor

        public PRMMaterialReceiveItemMapEntity() : base()
        {
        }

        #endregion

        #region Constant

        public const String FLD_NAME_MaterialReceiveItemMapID = "MaterialReceiveItemMapID";
        public const String FLD_NAME_MaterialReceiveID = "MaterialReceiveID";
        public const String FLD_NAME_RequisitionItemID = "RequisitionItemID";
        public const String FLD_NAME_WOItemTotalRate = "WOItemTotalRate";
        public const String FLD_NAME_ReceiveDate = "ReceiveDate";
        public const String FLD_NAME_ReceiveQty = "ReceiveQty";
        public const String FLD_NAME_ItemRate = "ItemRate";
        public const String FLD_NAME_ChallanNo = "ChallanNo";

        #endregion
    }
}
