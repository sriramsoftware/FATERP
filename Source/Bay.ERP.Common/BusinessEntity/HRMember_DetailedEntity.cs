// Copyright and All Rights Reserved by
//B2B Solution, Bangladesh;
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 31-Dec-2011, 05:48:38




using System;
using System.Diagnostics;
using System.ServiceModel;
using System.Runtime.Serialization;
using System.Collections.Generic;
using System.Xml.Serialization;


namespace Bay.ERP.Common.BusinessEntities
{
    [Serializable]
    [DataContract(Name = "HRMember_Detailed", Namespace = "http://www.e-p-m-s.com/types")]
    public partial class HRMember_DetailedEntity : BaseEntity
    {
        #region Properties


        private Int64 _MemberID;
        private String _FirstName;
        private String _MiddleName;
        private String _LastName;
        private Int64 _MemberTypeID;
        private String _MemberTypeName;
        private Int64? _RowNumber;


        [DataMember]
        public Int64 MemberID
        {
            get { return _MemberID; }
            set { _MemberID = value; }
        }

        [DataMember]
        public String FirstName
        {
            get { return _FirstName; }
            set { _FirstName = value; }
        }

        [DataMember]
        public String MiddleName
        {
            get { return _MiddleName; }
            set { _MiddleName = value; }
        }

        [DataMember]
        public String LastName
        {
            get { return _LastName; }
            set { _LastName = value; }
        }

        [DataMember]
        public Int64 MemberTypeID
        {
            get { return _MemberTypeID; }
            set { _MemberTypeID = value; }
        }

        [DataMember]
        public String MemberTypeName
        {
            get { return _MemberTypeName; }
            set { _MemberTypeName = value; }
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
                return (MemberID <= 0);
            }
        }


        #endregion

        #region Constructor

        public HRMember_DetailedEntity() : base()
        {
        }

        #endregion

        #region Constant

        public const String FLD_NAME_MemberID = "MemberID";
        public const String FLD_NAME_FirstName = "FirstName";
        public const String FLD_NAME_MiddleName = "MiddleName";
        public const String FLD_NAME_LastName = "LastName";
        public const String FLD_NAME_MemberTypeID = "MemberTypeID";
        public const String FLD_NAME_MemberTypeName = "MemberTypeName";
        public const String FLD_NAME_RowNumber = "RowNumber";

        #endregion
    }
}
