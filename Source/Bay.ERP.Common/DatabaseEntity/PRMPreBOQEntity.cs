// Copyright and All Rights Reserved by
//B2B Solution, Bangladesh;
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 13-May-2012, 04:19:57




using System;
using System.Diagnostics;
using System.ServiceModel;
using System.Runtime.Serialization;
using System.Collections.Generic;
using System.Xml.Serialization;


namespace Bay.ERP.Common.BusinessEntities
{
    [Serializable]
    [DataContract(Name = "PRMPreBOQ", Namespace = "http://www.e-p-m-s.com/types")]
    public partial class PRMPreBOQEntity : BaseEntity
    {
        #region Properties


        private Int64 _PreBOQID;
        private Int64 _ProjectID;
        private DateTime? _StartDate;
        private Int64 _PreparedByMemberID;
        private String _Remarks;
        private Int64? _PreBOQStatusID;
        private Boolean _IsRemoved;
        private Boolean _IsLocked;


        [DataMember]
        public Int64 PreBOQID
        {
            get { return _PreBOQID; }
            set { _PreBOQID = value; }
        }

        [DataMember]
        public Int64 ProjectID
        {
            get { return _ProjectID; }
            set { _ProjectID = value; }
        }

        [DataMember]
        public DateTime? StartDate
        {
            get { return _StartDate; }
            set { _StartDate = value; }
        }

        [DataMember]
        public Int64 PreparedByMemberID
        {
            get { return _PreparedByMemberID; }
            set { _PreparedByMemberID = value; }
        }

        [DataMember]
        public String Remarks
        {
            get { return _Remarks; }
            set { _Remarks = value; }
        }

        [DataMember]
        public Int64? PreBOQStatusID
        {
            get { return _PreBOQStatusID; }
            set { _PreBOQStatusID = value; }
        }

        [DataMember]
        public Boolean IsRemoved
        {
            get { return _IsRemoved; }
            set { _IsRemoved = value; }
        }

        [DataMember]
        public Boolean IsLocked
        {
            get { return _IsLocked; }
            set { _IsLocked = value; }
        }

        [XmlIgnore()]
        public override bool IsNew
        {
            [DebuggerStepThrough()]
            get
            {
                return (PreBOQID <= 0);
            }
        }


        #endregion

        #region Constructor

        public PRMPreBOQEntity() : base()
        {
        }

        #endregion

        #region Constant

        public const String FLD_NAME_PreBOQID = "PreBOQID";
        public const String FLD_NAME_ProjectID = "ProjectID";
        public const String FLD_NAME_StartDate = "StartDate";
        public const String FLD_NAME_PreparedByMemberID = "PreparedByMemberID";
        public const String FLD_NAME_Remarks = "Remarks";
        public const String FLD_NAME_PreBOQStatusID = "PreBOQStatusID";
        public const String FLD_NAME_IsRemoved = "IsRemoved";
        public const String FLD_NAME_IsLocked = "IsLocked";

        #endregion
    }
}
