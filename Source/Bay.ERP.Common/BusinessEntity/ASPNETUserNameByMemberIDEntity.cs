// Copyright and All Rights Reserved by
//B2B Solution, Bangladesh;
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 08-Jan-2012, 03:49:25




using System;
using System.Diagnostics;
using System.ServiceModel;
using System.Runtime.Serialization;
using System.Collections.Generic;
using System.Xml.Serialization;


namespace Bay.ERP.Common.BusinessEntities
{
    [Serializable]
    [DataContract(Name = "ASPNETUserNameByMemberID", Namespace = "http://www.e-p-m-s.com/types")]
    public partial class ASPNETUserNameByMemberIDEntity : BaseEntity
    {
        #region Properties


        private Int64 _MemberID;
        private String _UserName;


        [DataMember]
        public Int64 MemberID
        {
            get { return _MemberID; }
            set { _MemberID = value; }
        }

        [DataMember]
        public String UserName
        {
            get { return _UserName; }
            set { _UserName = value; }
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

        public ASPNETUserNameByMemberIDEntity() : base()
        {
        }

        #endregion

        #region Constant

        public const String FLD_NAME_MemberID = "MemberID";
        public const String FLD_NAME_UserName = "UserName";

        #endregion
    }
}
