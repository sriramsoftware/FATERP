// Copyright and All Rights Reserved by
//B2B Solution, Bangladesh;
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 30-Nov-2011, 01:41:28




using System;
using System.Diagnostics;
using System.ServiceModel;
using System.Runtime.Serialization;
using System.Collections.Generic;
using System.Xml.Serialization;


namespace Bay.ERP.Common.BusinessEntities
{
    [Serializable]
    [DataContract(Name = "PRMPreBOQTemplateItemMap", Namespace = "http://www.e-p-m-s.com/types")]
    public partial class PRMPreBOQTemplateItemMapEntity : BaseEntity
    {
        #region Properties


        private Int64 _PreBOQTemplateItemMapID;
        private Int64 _PreBOQTemplateID;
        private Int64 _ItemID;
        private Int32 _SequenceNo;


        [DataMember]
        public Int64 PreBOQTemplateItemMapID
        {
            get { return _PreBOQTemplateItemMapID; }
            set { _PreBOQTemplateItemMapID = value; }
        }

        [DataMember]
        public Int64 PreBOQTemplateID
        {
            get { return _PreBOQTemplateID; }
            set { _PreBOQTemplateID = value; }
        }

        [DataMember]
        public Int64 ItemID
        {
            get { return _ItemID; }
            set { _ItemID = value; }
        }

        [DataMember]
        public Int32 SequenceNo
        {
            get { return _SequenceNo; }
            set { _SequenceNo = value; }
        }

        [XmlIgnore()]
        public override bool IsNew
        {
            [DebuggerStepThrough()]
            get
            {
                return (PreBOQTemplateItemMapID <= 0);
            }
        }


        #endregion

        #region Constructor

        public PRMPreBOQTemplateItemMapEntity() : base()
        {
        }

        #endregion

        #region Constant

        public const String FLD_NAME_PreBOQTemplateItemMapID = "PreBOQTemplateItemMapID";
        public const String FLD_NAME_PreBOQTemplateID = "PreBOQTemplateID";
        public const String FLD_NAME_ItemID = "ItemID";
        public const String FLD_NAME_SequenceNo = "SequenceNo";

        #endregion
    }
}
