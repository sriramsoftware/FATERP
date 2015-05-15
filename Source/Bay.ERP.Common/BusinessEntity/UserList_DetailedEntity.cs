// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 29-Jul-2012, 11:09:39




using System;
using System.Diagnostics;
using System.ServiceModel;
using System.Runtime.Serialization;
using System.Collections.Generic;
using System.Xml.Serialization;


namespace Bay.ERP.Common.BusinessEntities
{
    [Serializable]
    [DataContract(Name = "UserList_Detailed", Namespace = "http://www.e-p-m-s.com/types")]
    public partial class UserList_DetailedEntity : BaseEntity
    {
        #region Properties


        private Int64? _MemberID;
        private String _FirstName;
        private String _MiddleName;
        private String _LastName;
        private String _FullName;
        private String _UserName;
        private String _RoleName;
        private DateTime _LastLoginDate;
        private Int64? _RowNumber;


        [DataMember]
        public Int64? MemberID
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
        public String FullName
        {
            get { return _FullName; }
            set { _FullName = value; }
        }

        [DataMember]
        public String UserName
        {
            get { return _UserName; }
            set { _UserName = value; }
        }

        [DataMember]
        public String RoleName
        {
            get { return _RoleName; }
            set { _RoleName = value; }
        }

        [DataMember]
        public DateTime LastLoginDate
        {
            get { return _LastLoginDate; }
            set { _LastLoginDate = value; }
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

        public UserList_DetailedEntity() : base()
        {
        }

        #endregion

        #region Constant

        public const String FLD_NAME_MemberID = "MemberID";
        public const String FLD_NAME_FirstName = "FirstName";
        public const String FLD_NAME_MiddleName = "MiddleName";
        public const String FLD_NAME_LastName = "LastName";
        public const String FLD_NAME_FullName = "FullName";
        public const String FLD_NAME_UserName = "UserName";
        public const String FLD_NAME_RoleName = "RoleName";
        public const String FLD_NAME_LastLoginDate = "LastLoginDate";
        public const String FLD_NAME_RowNumber = "RowNumber";

        #endregion
    }
}
