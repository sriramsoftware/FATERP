// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 13-Dec-2012, 11:43:49




using System;
using System.Diagnostics;
using System.ServiceModel;
using System.Runtime.Serialization;
using System.Collections.Generic;
using System.Xml.Serialization;


namespace Bay.ERP.Common.BusinessEntities
{
    [Serializable]
    [DataContract(Name = "ACCPrePayableStatement", Namespace = "http://www.e-p-m-s.com/types")]
    public partial class ACCPrePayableStatementEntity : BaseEntity
    {
        #region Properties


        private Int64 _PrePayableStatementID;
        private String _Ref;
        private DateTime _CreateDate;
        private DateTime _StartDate;
        private DateTime _EndDate;
        private Boolean _IsRemoved;


        [DataMember]
        public Int64 PrePayableStatementID
        {
            get { return _PrePayableStatementID; }
            set { _PrePayableStatementID = value; }
        }

        [DataMember]
        public String Ref
        {
            get { return _Ref; }
            set { _Ref = value; }
        }

        [DataMember]
        public DateTime CreateDate
        {
            get { return _CreateDate; }
            set { _CreateDate = value; }
        }

        [DataMember]
        public DateTime StartDate
        {
            get { return _StartDate; }
            set { _StartDate = value; }
        }

        [DataMember]
        public DateTime EndDate
        {
            get { return _EndDate; }
            set { _EndDate = value; }
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
                return (PrePayableStatementID <= 0);
            }
        }


        #endregion

        #region Constructor

        public ACCPrePayableStatementEntity() : base()
        {
        }

        #endregion

        #region Constant

        public const String FLD_NAME_PrePayableStatementID = "PrePayableStatementID";
        public const String FLD_NAME_Ref = "Ref";
        public const String FLD_NAME_CreateDate = "CreateDate";
        public const String FLD_NAME_StartDate = "StartDate";
        public const String FLD_NAME_EndDate = "EndDate";
        public const String FLD_NAME_IsRemoved = "IsRemoved";

        #endregion
    }
}
