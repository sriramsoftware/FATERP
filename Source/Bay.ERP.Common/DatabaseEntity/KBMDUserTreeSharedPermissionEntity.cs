// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 23-Mar-2013, 04:14:01




using System;
using System.Diagnostics;
using System.ServiceModel;
using System.Runtime.Serialization;
using System.Collections.Generic;
using System.Xml.Serialization;


namespace Bay.ERP.Common.BusinessEntities
{
    [Serializable]
    [DataContract(Name = "KBMDUserTreeSharedPermission", Namespace = "http://www.e-p-m-s.com/types")]
    public partial class KBMDUserTreeSharedPermissionEntity : BaseEntity
    {
        #region Properties


        private Int64 _UserTreeSharedPermissionID;
        private String _Name;
        private String _Remarks;
        private Boolean _IsRemoved;


        [DataMember]
        public Int64 UserTreeSharedPermissionID
        {
            get { return _UserTreeSharedPermissionID; }
            set { _UserTreeSharedPermissionID = value; }
        }

        [DataMember]
        public String Name
        {
            get { return _Name; }
            set { _Name = value; }
        }

        [DataMember]
        public String Remarks
        {
            get { return _Remarks; }
            set { _Remarks = value; }
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
                return (UserTreeSharedPermissionID <= 0);
            }
        }


        #endregion

        #region Constructor

        public KBMDUserTreeSharedPermissionEntity() : base()
        {
        }

        #endregion

        #region Constant

        public const String FLD_NAME_UserTreeSharedPermissionID = "UserTreeSharedPermissionID";
        public const String FLD_NAME_Name = "Name";
        public const String FLD_NAME_Remarks = "Remarks";
        public const String FLD_NAME_IsRemoved = "IsRemoved";

        #endregion
    }
}