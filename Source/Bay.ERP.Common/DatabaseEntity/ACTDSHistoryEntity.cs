// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 05-Mar-2013, 10:30:04




using System;
using System.Diagnostics;
using System.ServiceModel;
using System.Runtime.Serialization;
using System.Collections.Generic;
using System.Xml.Serialization;


namespace Bay.ERP.Common.BusinessEntities
{
    [Serializable]
    [DataContract(Name = "ACTDSHistory", Namespace = "http://www.e-p-m-s.com/types")]
    public partial class ACTDSHistoryEntity : BaseEntity
    {
        #region Properties


        private Int64 _TDSHistoryID;
        private Int64 _TDSCategoryID;
        private Decimal _StartValue;
        private Decimal _EndValue;
        private Decimal _Tax;
        private String _Remarks;
        private DateTime _UpdatedDate;


        [DataMember]
        public Int64 TDSHistoryID
        {
            get { return _TDSHistoryID; }
            set { _TDSHistoryID = value; }
        }

        [DataMember]
        public Int64 TDSCategoryID
        {
            get { return _TDSCategoryID; }
            set { _TDSCategoryID = value; }
        }

        [DataMember]
        public Decimal StartValue
        {
            get { return _StartValue; }
            set { _StartValue = value; }
        }

        [DataMember]
        public Decimal EndValue
        {
            get { return _EndValue; }
            set { _EndValue = value; }
        }

        [DataMember]
        public Decimal Tax
        {
            get { return _Tax; }
            set { _Tax = value; }
        }

        [DataMember]
        public String Remarks
        {
            get { return _Remarks; }
            set { _Remarks = value; }
        }

        [DataMember]
        public DateTime UpdatedDate
        {
            get { return _UpdatedDate; }
            set { _UpdatedDate = value; }
        }

        [XmlIgnore()]
        public override bool IsNew
        {
            [DebuggerStepThrough()]
            get
            {
                return (TDSHistoryID <= 0);
            }
        }


        #endregion

        #region Constructor

        public ACTDSHistoryEntity() : base()
        {
        }

        #endregion

        #region Constant

        public const String FLD_NAME_TDSHistoryID = "TDSHistoryID";
        public const String FLD_NAME_TDSCategoryID = "TDSCategoryID";
        public const String FLD_NAME_StartValue = "StartValue";
        public const String FLD_NAME_EndValue = "EndValue";
        public const String FLD_NAME_Tax = "Tax";
        public const String FLD_NAME_Remarks = "Remarks";
        public const String FLD_NAME_UpdatedDate = "UpdatedDate";

        #endregion
    }
}
