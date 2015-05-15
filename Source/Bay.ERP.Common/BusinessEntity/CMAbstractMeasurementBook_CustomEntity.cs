// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 06-Oct-2012, 11:18:25




using System;
using System.Diagnostics;
using System.ServiceModel;
using System.Runtime.Serialization;
using System.Collections.Generic;
using System.Xml.Serialization;


namespace Bay.ERP.Common.BusinessEntities
{
    [Serializable]
    [DataContract(Name = "CMAbstractMeasurementBook_Custom", Namespace = "http://www.e-p-m-s.com/types")]
    public partial class CMAbstractMeasurementBook_CustomEntity : BaseEntity
    {
        #region Properties


        private Int64 _ItemID;
        private Int64 _ProjectID;
        private String _ProjectName;
        private String _ItemName;
        private String _UnitName;
        private Decimal? _TotalQty;


        [DataMember]
        public Int64 ItemID
        {
            get { return _ItemID; }
            set { _ItemID = value; }
        }

        [DataMember]
        public Int64 ProjectID
        {
            get { return _ProjectID; }
            set { _ProjectID = value; }
        }

        [DataMember]
        public String ProjectName
        {
            get { return _ProjectName; }
            set { _ProjectName = value; }
        }

        [DataMember]
        public String ItemName
        {
            get { return _ItemName; }
            set { _ItemName = value; }
        }

        [DataMember]
        public String UnitName
        {
            get { return _UnitName; }
            set { _UnitName = value; }
        }

        [DataMember]
        public Decimal? TotalQty
        {
            get { return _TotalQty; }
            set { _TotalQty = value; }
        }

        [XmlIgnore()]
        public override bool IsNew
        {
            [DebuggerStepThrough()]
            get
            {
                return (ItemID <= 0);
            }
        }


        #endregion

        #region Constructor

        public CMAbstractMeasurementBook_CustomEntity() : base()
        {
        }

        #endregion

        #region Constant

        public const String FLD_NAME_ItemID = "ItemID";
        public const String FLD_NAME_ProjectID = "ProjectID";
        public const String FLD_NAME_ProjectName = "ProjectName";
        public const String FLD_NAME_ItemName = "ItemName";
        public const String FLD_NAME_UnitName = "UnitName";
        public const String FLD_NAME_TotalQty = "TotalQty";

        #endregion
    }
}
