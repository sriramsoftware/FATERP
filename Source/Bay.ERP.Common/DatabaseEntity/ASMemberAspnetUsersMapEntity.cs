// Copyright and All Rights Reserved by
//B2B Solution, Bangladesh;
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 08-Jan-2012, 03:24:04




using System;
using System.Diagnostics;
using System.ServiceModel;
using System.Runtime.Serialization;
using System.Collections.Generic;
using System.Xml.Serialization;


namespace Bay.ERP.Common.BusinessEntities
{
    [Serializable]
    [DataContract(Name = "ASMemberAspnetUsersMap", Namespace = "http://www.e-p-m-s.com/types")]
    public partial class ASMemberAspnetUsersMapEntity : BaseEntity
    {
        #region Properties


        private Int64 _ASMemberAspnetUsersMapID;
        private Int64 _MemberID;
        private Guid _UserId;


        [DataMember]
        public Int64 ASMemberAspnetUsersMapID
        {
            get { return _ASMemberAspnetUsersMapID; }
            set { _ASMemberAspnetUsersMapID = value; }
        }

        [DataMember]
        public Int64 MemberID
        {
            get { return _MemberID; }
            set { _MemberID = value; }
        }

        [DataMember]
        public Guid UserId
        {
            get { return _UserId; }
            set { _UserId = value; }
        }

        [XmlIgnore()]
        public override bool IsNew
        {
            [DebuggerStepThrough()]
            get
            {
                return (ASMemberAspnetUsersMapID <= 0);
            }
        }


        #endregion

        #region Constructor

        public ASMemberAspnetUsersMapEntity() : base()
        {
        }

        #endregion

        #region Constant

        public const String FLD_NAME_ASMemberAspnetUsersMapID = "ASMemberAspnetUsersMapID";
        public const String FLD_NAME_MemberID = "MemberID";
        public const String FLD_NAME_UserId = "UserId";

        #endregion
    }
}
