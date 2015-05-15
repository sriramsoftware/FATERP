// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 07-Oct-2012, 04:30:09




using System;
using System.Diagnostics;
using System.ServiceModel;
using System.Runtime.Serialization;
using System.Collections.Generic;
using System.Xml.Serialization;


namespace Bay.ERP.Common.BusinessEntities
{
    [Serializable]
    [DataContract(Name = "CMAbstractMeasurementBookHelper_Custom", Namespace = "http://www.e-p-m-s.com/types")]
    public partial class CMAbstractMeasurementBookHelper_CustomEntity : BaseEntity
    {
        #region Properties


        private Int64 _ProjectID;
        private Decimal? _PresentQty;
        private Int64 _ItemID;
        private Int64 _MeasurementBookID;


        [DataMember]
        public Int64 ProjectID
        {
            get { return _ProjectID; }
            set { _ProjectID = value; }
        }

        [DataMember]
        public Decimal? PresentQty
        {
            get { return _PresentQty; }
            set { _PresentQty = value; }
        }

        [DataMember]
        public Int64 ItemID
        {
            get { return _ItemID; }
            set { _ItemID = value; }
        }

        [DataMember]
        public Int64 MeasurementBookID
        {
            get { return _MeasurementBookID; }
            set { _MeasurementBookID = value; }
        }

        [XmlIgnore()]
        public override bool IsNew
        {
            [DebuggerStepThrough()]
            get
            {
                return (ProjectID <= 0);
            }
        }


        #endregion

        #region Constructor

        public CMAbstractMeasurementBookHelper_CustomEntity() : base()
        {
        }

        #endregion

        #region Constant

        public const String FLD_NAME_ProjectID = "ProjectID";
        public const String FLD_NAME_PresentQty = "PresentQty";
        public const String FLD_NAME_ItemID = "ItemID";
        public const String FLD_NAME_MeasurementBookID = "MeasurementBookID";

        #endregion
    }
}
