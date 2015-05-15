// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 10-Oct-2012, 02:11:32




using System;
using System.Diagnostics;
using System.ServiceModel;
using System.Runtime.Serialization;
using System.Collections.Generic;
using System.Xml.Serialization;


namespace Bay.ERP.Common.BusinessEntities
{
    [Serializable]
    [DataContract(Name = "APWOPanelItemCategoryMap_Detailed", Namespace = "http://www.e-p-m-s.com/types")]
    public partial class APWOPanelItemCategoryMap_DetailedEntity : BaseEntity
    {
        #region Properties


        private Int64 _APWOPanelItemCategoryMapID;
        private Int64 _APPanelID;
        private Int64 _ItemCategoryID;
        private String _PanelName;
        private String _CategoryName;
        private Int64? _RowNumber;


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

        [DataMember]
        public String PanelName
        {
            get { return _PanelName; }
            set { _PanelName = value; }
        }

        [DataMember]
        public String CategoryName
        {
            get { return _CategoryName; }
            set { _CategoryName = value; }
        }

        [DataMember]
        public Int64? RowNumber
        {
            get { return _RowNumber; }
            set { _RowNumber = value; }
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

        public APWOPanelItemCategoryMap_DetailedEntity() : base()
        {
        }

        #endregion

        #region Constant

        public const String FLD_NAME_APWOPanelItemCategoryMapID = "APWOPanelItemCategoryMapID";
        public const String FLD_NAME_APPanelID = "APPanelID";
        public const String FLD_NAME_ItemCategoryID = "ItemCategoryID";
        public const String FLD_NAME_PanelName = "PanelName";
        public const String FLD_NAME_CategoryName = "CategoryName";
        public const String FLD_NAME_RowNumber = "RowNumber";

        #endregion
    }
}
