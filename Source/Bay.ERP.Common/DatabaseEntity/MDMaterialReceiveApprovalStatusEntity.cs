// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 04-Mar-2013, 11:12:01




using System;
using System.Diagnostics;
using System.ServiceModel;
using System.Runtime.Serialization;
using System.Collections.Generic;
using System.Xml.Serialization;


namespace Bay.ERP.Common.BusinessEntities
{
    [Serializable]
    [DataContract(Name = "MDMaterialReceiveApprovalStatus", Namespace = "http://www.e-p-m-s.com/types")]
    public partial class MDMaterialReceiveApprovalStatusEntity : BaseEntity
    {
        #region Properties


        private Int64 _MaterialReceiveApprovalStatusID;
        private String _Name;
        private Boolean _IsRemoved;


        [DataMember]
        public Int64 MaterialReceiveApprovalStatusID
        {
            get { return _MaterialReceiveApprovalStatusID; }
            set { _MaterialReceiveApprovalStatusID = value; }
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
                return (MaterialReceiveApprovalStatusID <= 0);
            }
        }


        #endregion

        #region Constructor

        public MDMaterialReceiveApprovalStatusEntity() : base()
        {
        }

        #endregion

        #region Constant

        public const String FLD_NAME_MaterialReceiveApprovalStatusID = "MaterialReceiveApprovalStatusID";
        public const String FLD_NAME_Name = "Name";
        public const String FLD_NAME_IsRemoved = "IsRemoved";

        #endregion
    }
}
