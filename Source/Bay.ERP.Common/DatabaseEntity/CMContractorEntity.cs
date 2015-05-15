// Copyright and All Rights Reserved by
//B2B Solution, Bangladesh;
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 05-Jan-2012, 11:52:45




using System;
using System.Diagnostics;
using System.ServiceModel;
using System.Runtime.Serialization;
using System.Collections.Generic;
using System.Xml.Serialization;


namespace Bay.ERP.Common.BusinessEntities
{
    [Serializable]
    [DataContract(Name = "CMContractor", Namespace = "http://www.e-p-m-s.com/types")]
    public partial class CMContractorEntity : BaseEntity
    {
        #region Properties


        private Int64 _ContractorID;
        private Int64 _MemberID;
        private String _NameOfWork;
        private DateTime _Date;
        private String _Name;
        private Int64 _PreparedBy;
        private Boolean _IsRemoved;


        [DataMember]
        public Int64 ContractorID
        {
            get { return _ContractorID; }
            set { _ContractorID = value; }
        }

        [DataMember]
        public Int64 MemberID
        {
            get { return _MemberID; }
            set { _MemberID = value; }
        }

        [DataMember]
        public String NameOfWork
        {
            get { return _NameOfWork; }
            set { _NameOfWork = value; }
        }

        [DataMember]
        public DateTime Date
        {
            get { return _Date; }
            set { _Date = value; }
        }

        [DataMember]
        public String Name
        {
            get { return _Name; }
            set { _Name = value; }
        }

        [DataMember]
        public Int64 PreparedBy
        {
            get { return _PreparedBy; }
            set { _PreparedBy = value; }
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
                return (ContractorID <= 0);
            }
        }


        #endregion

        #region Constructor

        public CMContractorEntity() : base()
        {
        }

        #endregion

        #region Constant

        public const String FLD_NAME_ContractorID = "ContractorID";
        public const String FLD_NAME_MemberID = "MemberID";
        public const String FLD_NAME_NameOfWork = "NameOfWork";
        public const String FLD_NAME_Date = "Date";
        public const String FLD_NAME_Name = "Name";
        public const String FLD_NAME_PreparedBy = "PreparedBy";
        public const String FLD_NAME_IsRemoved = "IsRemoved";

        #endregion
    }
}
