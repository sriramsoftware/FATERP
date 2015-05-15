// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 01-Jul-2013, 05:44:25




using System;
using System.Diagnostics;
using System.ServiceModel;
using System.Runtime.Serialization;
using System.Collections.Generic;
using System.Xml.Serialization;


namespace Bay.ERP.Common.BusinessEntities
{
    [Serializable]
    [DataContract(Name = "PRMAvailableBOQQtyForRequisition", Namespace = "http://www.e-p-m-s.com/types")]
    public partial class PRMAvailableBOQQtyForRequisitionEntity : BaseEntity
    {
        #region Properties


        private Int64 _AvailableBOQQtyForRequisitionID;
        private Boolean _IsBOQ;
        private Int64? _ProjectID;
        private Int64 _PreBOQOrBOQDetailID;
        private Int64 _ItemID;
        private Decimal _Qty;
        private DateTime _CreateDate;
        private Int64 _CreatedByEmployeeID;


        [DataMember]
        public Int64 AvailableBOQQtyForRequisitionID
        {
            get { return _AvailableBOQQtyForRequisitionID; }
            set { _AvailableBOQQtyForRequisitionID = value; }
        }

        [DataMember]
        public Boolean IsBOQ
        {
            get { return _IsBOQ; }
            set { _IsBOQ = value; }
        }

        [DataMember]
        public Int64? ProjectID
        {
            get { return _ProjectID; }
            set { _ProjectID = value; }
        }

        [DataMember]
        public Int64 PreBOQOrBOQDetailID
        {
            get { return _PreBOQOrBOQDetailID; }
            set { _PreBOQOrBOQDetailID = value; }
        }

        [DataMember]
        public Int64 ItemID
        {
            get { return _ItemID; }
            set { _ItemID = value; }
        }

        [DataMember]
        public Decimal Qty
        {
            get { return _Qty; }
            set { _Qty = value; }
        }

        [DataMember]
        public DateTime CreateDate
        {
            get { return _CreateDate; }
            set { _CreateDate = value; }
        }

        [DataMember]
        public Int64 CreatedByEmployeeID
        {
            get { return _CreatedByEmployeeID; }
            set { _CreatedByEmployeeID = value; }
        }

        [XmlIgnore()]
        public override bool IsNew
        {
            [DebuggerStepThrough()]
            get
            {
                return (AvailableBOQQtyForRequisitionID <= 0);
            }
        }


        #endregion

        #region Constructor

        public PRMAvailableBOQQtyForRequisitionEntity() : base()
        {
        }

        #endregion

        #region Constant

        public const String FLD_NAME_AvailableBOQQtyForRequisitionID = "AvailableBOQQtyForRequisitionID";
        public const String FLD_NAME_IsBOQ = "IsBOQ";
        public const String FLD_NAME_ProjectID = "ProjectID";
        public const String FLD_NAME_PreBOQOrBOQDetailID = "PreBOQOrBOQDetailID";
        public const String FLD_NAME_ItemID = "ItemID";
        public const String FLD_NAME_Qty = "Qty";
        public const String FLD_NAME_CreateDate = "CreateDate";
        public const String FLD_NAME_CreatedByEmployeeID = "CreatedByEmployeeID";

        #endregion
    }
}
