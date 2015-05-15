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
    [DataContract(Name = "KBMDUserTreeStatus", Namespace = "http://www.e-p-m-s.com/types")]
    public partial class KBMDUserTreeStatusEntity : BaseEntity
    {
        #region Properties


        private Int64 _UserTreeStatusID;
        private String _Name;
        private String _Remarks;
        private Boolean _IsRemoved;


        [DataMember]
        public Int64 UserTreeStatusID
        {
            get { return _UserTreeStatusID; }
            set { _UserTreeStatusID = value; }
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
                return (UserTreeStatusID <= 0);
            }
        }


        #endregion

        #region Constructor

        public KBMDUserTreeStatusEntity() : base()
        {
        }

        #endregion

        #region Constant

        public const String FLD_NAME_UserTreeStatusID = "UserTreeStatusID";
        public const String FLD_NAME_Name = "Name";
        public const String FLD_NAME_Remarks = "Remarks";
        public const String FLD_NAME_IsRemoved = "IsRemoved";

        #endregion
    }
}
