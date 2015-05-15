// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 04-Mar-2013, 09:29:16




using System;
using System.Diagnostics;
using System.ServiceModel;
using System.Runtime.Serialization;
using System.Collections.Generic;
using System.Xml.Serialization;


namespace Bay.ERP.Common.BusinessEntities
{
    [Serializable]
    [DataContract(Name = "ACTDS", Namespace = "http://www.e-p-m-s.com/types")]
    public partial class ACTDSEntity : BaseEntity
    {
        #region Properties


        private Int64 _TDSID;
        private Int64 _TDSCategoryID;
        private Decimal _StartValue;
        private Decimal _EndValue;
        private Decimal _Tax;
        private String _Remarks;


        [DataMember]
        public Int64 TDSID
        {
            get { return _TDSID; }
            set { _TDSID = value; }
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

        [XmlIgnore()]
        public override bool IsNew
        {
            [DebuggerStepThrough()]
            get
            {
                return (TDSID <= 0);
            }
        }


        #endregion

        #region Constructor

        public ACTDSEntity() : base()
        {
        }

        #endregion

        #region Constant

        public const String FLD_NAME_TDSID = "TDSID";
        public const String FLD_NAME_TDSCategoryID = "TDSCategoryID";
        public const String FLD_NAME_StartValue = "StartValue";
        public const String FLD_NAME_EndValue = "EndValue";
        public const String FLD_NAME_Tax = "Tax";
        public const String FLD_NAME_Remarks = "Remarks";

        #endregion
    }
}
