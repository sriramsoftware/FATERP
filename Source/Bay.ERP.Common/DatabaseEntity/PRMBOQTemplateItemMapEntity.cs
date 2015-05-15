// Copyright and All Rights Reserved by
//B2B Solution, Bangladesh;
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 10-May-2012, 05:58:01




using System;
using System.Diagnostics;
using System.ServiceModel;
using System.Runtime.Serialization;
using System.Collections.Generic;
using System.Xml.Serialization;


namespace Bay.ERP.Common.BusinessEntities
{
    [Serializable]
    [DataContract(Name = "PRMBOQTemplateItemMap", Namespace = "http://www.e-p-m-s.com/types")]
    public partial class PRMBOQTemplateItemMapEntity : BaseEntity
    {
        #region Properties


        private Int64 _BOQTemplateItemMapID;
        private Int64 _BOQTemplateID;
        private Int64 _ItemID;
        private Int32 _SequenceNo;


        [DataMember]
        public Int64 BOQTemplateItemMapID
        {
            get { return _BOQTemplateItemMapID; }
            set { _BOQTemplateItemMapID = value; }
        }

        [DataMember]
        public Int64 BOQTemplateID
        {
            get { return _BOQTemplateID; }
            set { _BOQTemplateID = value; }
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
                return (BOQTemplateItemMapID <= 0);
            }
        }


        #endregion

        #region Constructor

        public PRMBOQTemplateItemMapEntity() : base()
        {
        }

        #endregion

        #region Constant

        public const String FLD_NAME_BOQTemplateItemMapID = "BOQTemplateItemMapID";
        public const String FLD_NAME_BOQTemplateID = "BOQTemplateID";
        public const String FLD_NAME_ItemID = "ItemID";
        public const String FLD_NAME_SequenceNo = "SequenceNo";

        #endregion
    }
}
