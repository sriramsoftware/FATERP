// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 06-Oct-2012, 10:59:14




using System;
using System.Diagnostics;
using System.ServiceModel;
using System.Runtime.Serialization;
using System.Collections.Generic;
using System.Xml.Serialization;


namespace Bay.ERP.Common.BusinessEntities
{
    [Serializable]
    [DataContract(Name = "APWOPanelItemCategoryMap", Namespace = "http://www.e-p-m-s.com/types")]
    public partial class APWOPanelItemCategoryMapEntity : BaseEntity
    {
        #region Properties


        private Int64 _APWOPanelItemCategoryMapID;
        private Int64 _APPanelID;
        private Int64 _ItemCategoryID;


        [DataMember]
        public Int64 APWOPanelItemCategoryMapID
        {
            get { return _APWOPanelItemCategoryMapID; }
            set { _APWOPanelItemCategoryMapID = value; }
        }

        [DataMember]
        public Int64 APPanelID
        {
            get { return _APPanelID; }
            set { _APPanelID = value; }
        }

        [DataMember]
        public Int64 ItemCategoryID
        {
            get { return _ItemCategoryID; }
            set { _ItemCategoryID = value; }
        }

        [XmlIgnore()]
        public override bool IsNew
        {
            [DebuggerStepThrough()]
            get
            {
                return (APWOPanelItemCategoryMapID <= 0);
            }
        }


        #endregion

        #region Constructor

        public APWOPanelItemCategoryMapEntity() : base()
        {
        }

        #endregion

        #region Constant

        public const String FLD_NAME_APWOPanelItemCategoryMapID = "APWOPanelItemCategoryMapID";
        public const String FLD_NAME_APPanelID = "APPanelID";
        public const String FLD_NAME_ItemCategoryID = "ItemCategoryID";

        #endregion
    }
}
