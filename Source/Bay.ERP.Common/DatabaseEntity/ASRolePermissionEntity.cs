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
    [DataContract(Name = "ASRolePermission", Namespace = "http://www.e-p-m-s.com/types")]
    public partial class ASRolePermissionEntity : BaseEntity
    {
        #region Properties


        private Int64 _ASRolePermissionID;
        private String _ASRoleName;
        private String _PermissionKey;
        private Int64 _Ts;


        [DataMember]
        public Int64 ASRolePermissionID
        {
            get { return _ASRolePermissionID; }
            set { _ASRolePermissionID = value; }
        }

        [DataMember]
        public String ASRoleName
        {
            get { return _ASRoleName; }
            set { _ASRoleName = value; }
        }

        [DataMember]
        public String PermissionKey
        {
            get { return _PermissionKey; }
            set { _PermissionKey = value; }
        }

        [DataMember]
        public Int64 Ts
        {
            get { return _Ts; }
            set { _Ts = value; }
        }

        [XmlIgnore()]
        public override bool IsNew
        {
            [DebuggerStepThrough()]
            get
            {
                return (ASRolePermissionID <= 0);
            }
        }


        #endregion

        #region Constructor

        public ASRolePermissionEntity() : base()
        {
        }

        #endregion

        #region Constant

        public const String FLD_NAME_ASRolePermissionID = "ASRolePermissionID";
        public const String FLD_NAME_ASRoleName = "ASRoleName";
        public const String FLD_NAME_PermissionKey = "PermissionKey";
        public const String FLD_NAME_Ts = "Ts";

        #endregion
    }
}