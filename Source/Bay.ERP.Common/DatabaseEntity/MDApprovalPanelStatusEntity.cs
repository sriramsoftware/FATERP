// Copyright and All Rights Reserved by
//B2B Solution, Bangladesh;
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 22-May-2012, 04:20:17




using System;
using System.Diagnostics;
using System.ServiceModel;
using System.Runtime.Serialization;
using System.Collections.Generic;
using System.Xml.Serialization;


namespace Bay.ERP.Common.BusinessEntities
{
    [Serializable]
    [DataContract(Name = "MDApprovalPanelStatus", Namespace = "http://www.e-p-m-s.com/types")]
    public partial class MDApprovalPanelStatusEntity : BaseEntity
    {
        #region Properties


        private Int64 _ApprovalPanelStatusID;
        private String _Name;
        private Boolean _IsRemoved;


        [DataMember]
        public Int64 ApprovalPanelStatusID
        {
            get { return _ApprovalPanelStatusID; }
            set { _ApprovalPanelStatusID = value; }
        }

        [DataMember]
        public String Name
        {
            get { return _Name; }
            set { _Name = value; }
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
                return (ApprovalPanelStatusID <= 0);
            }
        }


        #endregion

        #region Constructor

        public MDApprovalPanelStatusEntity() : base()
        {
        }

        #endregion

        #region Constant

        public const String FLD_NAME_ApprovalPanelStatusID = "ApprovalPanelStatusID";
        public const String FLD_NAME_Name = "Name";
        public const String FLD_NAME_IsRemoved = "IsRemoved";

        #endregion
    }
}
