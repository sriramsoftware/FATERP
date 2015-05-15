// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 30-Jan-2013, 03:35:13




using System;
using System.Diagnostics;
using System.ServiceModel;
using System.Runtime.Serialization;
using System.Collections.Generic;
using System.Xml.Serialization;


namespace Bay.ERP.Common.BusinessEntities
{
    [Serializable]
    [DataContract(Name = "ACFiscalYear", Namespace = "http://www.e-p-m-s.com/types")]
    public partial class ACFiscalYearEntity : BaseEntity
    {
        #region Properties


        private Int64 _FiscalYearID;
        private DateTime _BeginDate;
        private DateTime _EndDate;
        private Boolean _IsClosed;
        private Boolean _IsLocked;
        private Boolean _IsRemoved;


        [DataMember]
        public Int64 FiscalYearID
        {
            get { return _FiscalYearID; }
            set { _FiscalYearID = value; }
        }

        [DataMember]
        public DateTime BeginDate
        {
            get { return _BeginDate; }
            set { _BeginDate = value; }
        }

        [DataMember]
        public DateTime EndDate
        {
            get { return _EndDate; }
            set { _EndDate = value; }
        }

        [DataMember]
        public Boolean IsClosed
        {
            get { return _IsClosed; }
            set { _IsClosed = value; }
        }

        [DataMember]
        public Boolean IsLocked
        {
            get { return _IsLocked; }
            set { _IsLocked = value; }
        }

        [DataMember]
        public Boolean IsRemoved
        {
            get { return _IsRemoved; }
            set { _IsRemoved = value; }
        }

        [XmlIgnore()]
        public override bool IsNew
        {
            [DebuggerStepThrough()]
            get
            {
                return (FiscalYearID <= 0);
            }
        }


        #endregion

        #region Constructor

        public ACFiscalYearEntity() : base()
        {
        }

        #endregion

        #region Constant

        public const String FLD_NAME_FiscalYearID = "FiscalYearID";
        public const String FLD_NAME_BeginDate = "BeginDate";
        public const String FLD_NAME_EndDate = "EndDate";
        public const String FLD_NAME_IsClosed = "IsClosed";
        public const String FLD_NAME_IsLocked = "IsLocked";
        public const String FLD_NAME_IsRemoved = "IsRemoved";

        #endregion
    }
}
