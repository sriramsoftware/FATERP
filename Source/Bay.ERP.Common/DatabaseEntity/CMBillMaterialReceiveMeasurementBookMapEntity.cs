// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 05-Feb-2013, 04:16:42




using System;
using System.Diagnostics;
using System.ServiceModel;
using System.Runtime.Serialization;
using System.Collections.Generic;
using System.Xml.Serialization;


namespace Bay.ERP.Common.BusinessEntities
{
    [Serializable]
    [DataContract(Name = "CMBillMaterialReceiveMeasurementBookMap", Namespace = "http://www.e-p-m-s.com/types")]
    public partial class CMBillMaterialReceiveMeasurementBookMapEntity : BaseEntity
    {
        #region Properties


        private Int64 _BillMaterialReceiveMeasurementBookMapID;
        private Int64 _BillID;
        private Int64? _MaterialReceiveID;
        private Int64? _MaterialReceiveItemMapID;
        private Int64? _MeasurementBookID;
        private Int64? _MeasurementBookDetailID;
        private Decimal _BillPrice;


        [DataMember]
        public Int64 BillMaterialReceiveMeasurementBookMapID
        {
            get { return _BillMaterialReceiveMeasurementBookMapID; }
            set { _BillMaterialReceiveMeasurementBookMapID = value; }
        }

        [DataMember]
        public Int64 BillID
        {
            get { return _BillID; }
            set { _BillID = value; }
        }

        [DataMember]
        public Int64? MaterialReceiveID
        {
            get { return _MaterialReceiveID; }
            set { _MaterialReceiveID = value; }
        }

        [DataMember]
        public Int64? MaterialReceiveItemMapID
        {
            get { return _MaterialReceiveItemMapID; }
            set { _MaterialReceiveItemMapID = value; }
        }

        [DataMember]
        public Int64? MeasurementBookID
        {
            get { return _MeasurementBookID; }
            set { _MeasurementBookID = value; }
        }

        [DataMember]
        public Int64? MeasurementBookDetailID
        {
            get { return _MeasurementBookDetailID; }
            set { _MeasurementBookDetailID = value; }
        }

        [DataMember]
        public Decimal BillPrice
        {
            get { return _BillPrice; }
            set { _BillPrice = value; }
        }

        [XmlIgnore()]
        public override bool IsNew
        {
            [DebuggerStepThrough()]
            get
            {
                return (BillMaterialReceiveMeasurementBookMapID <= 0);
            }
        }


        #endregion

        #region Constructor

        public CMBillMaterialReceiveMeasurementBookMapEntity() : base()
        {
        }

        #endregion

        #region Constant

        public const String FLD_NAME_BillMaterialReceiveMeasurementBookMapID = "BillMaterialReceiveMeasurementBookMapID";
        public const String FLD_NAME_BillID = "BillID";
        public const String FLD_NAME_MaterialReceiveID = "MaterialReceiveID";
        public const String FLD_NAME_MaterialReceiveItemMapID = "MaterialReceiveItemMapID";
        public const String FLD_NAME_MeasurementBookID = "MeasurementBookID";
        public const String FLD_NAME_MeasurementBookDetailID = "MeasurementBookDetailID";
        public const String FLD_NAME_BillPrice = "BillPrice";

        #endregion
    }
}
