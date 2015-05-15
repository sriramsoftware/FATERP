// Copyright and All Rights Reserved by
//B2B Solution, Bangladesh;
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 08-Jan-2012, 09:54:11




using System;
using System.Diagnostics;
using System.ServiceModel;
using System.Runtime.Serialization;
using System.Collections.Generic;
using System.Xml.Serialization;


namespace Bay.ERP.Common.BusinessEntities
{
    [Serializable]
    [DataContract(Name = "CMContractor_Detailed", Namespace = "http://www.e-p-m-s.com/types")]
    public partial class CMContractor_DetailedEntity : BaseEntity
    {
        #region Properties


        private Int64 _ContractorID;
        private Int64 _MemberID;
        private String _NameOfWork;
        private DateTime _Date;
        private String _Name;
        private Int64 _PreparedBy;
        private Boolean _IsRemoved;
        private String _MemberFullName;
        private String _PreparedByName;
        private Int64? _RowNumber;


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

        [DataMember]
        public String MemberFullName
        {
            get { return _MemberFullName; }
            set { _MemberFullName = value; }
        }

        [DataMember]
        public String PreparedByName
        {
            get { return _PreparedByName; }
            set { _PreparedByName = value; }
        }

        [DataMember]
        public Int64? RowNumber
        {
            get { return _RowNumber; }
            set { _RowNumber = value; }
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

        public CMContractor_DetailedEntity() : base()
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
        public const String FLD_NAME_MemberFullName = "MemberFullName";
        public const String FLD_NAME_PreparedByName = "PreparedByName";
        public const String FLD_NAME_RowNumber = "RowNumber";

        #endregion
    }
}
