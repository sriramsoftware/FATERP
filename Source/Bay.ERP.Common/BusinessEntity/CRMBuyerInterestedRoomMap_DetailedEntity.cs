// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 04-Apr-2013, 04:34:01




using System;
using System.Diagnostics;
using System.ServiceModel;
using System.Runtime.Serialization;
using System.Collections.Generic;
using System.Xml.Serialization;


namespace Bay.ERP.Common.BusinessEntities
{
    [Serializable]
    [DataContract(Name = "CRMBuyerInterestedRoomMap_Detailed", Namespace = "http://www.e-p-m-s.com/types")]
    public partial class CRMBuyerInterestedRoomMap_DetailedEntity : BaseEntity
    {
        #region Properties


        private Int64 _BuyerInterestedRoomMapID;
        private Int64 _BuyerBasicInfoID;
        private Int64 _BuyerInterestedRoomCategoryID;
        private String _BuyerBasicInfoContactFullName;
        private String _BuyerInterestedRoomCategoryName;
        private Int64? _RowNumber;


        [DataMember]
        public Int64 BuyerInterestedRoomMapID
        {
            get { return _BuyerInterestedRoomMapID; }
            set { _BuyerInterestedRoomMapID = value; }
        }

        [DataMember]
        public Int64 BuyerBasicInfoID
        {
            get { return _BuyerBasicInfoID; }
            set { _BuyerBasicInfoID = value; }
        }

        [DataMember]
        public Int64 BuyerInterestedRoomCategoryID
        {
            get { return _BuyerInterestedRoomCategoryID; }
            set { _BuyerInterestedRoomCategoryID = value; }
        }

        [DataMember]
        public String BuyerBasicInfoContactFullName
        {
            get { return _BuyerBasicInfoContactFullName; }
            set { _BuyerBasicInfoContactFullName = value; }
        }

        [DataMember]
        public String BuyerInterestedRoomCategoryName
        {
            get { return _BuyerInterestedRoomCategoryName; }
            set { _BuyerInterestedRoomCategoryName = value; }
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
                return (BuyerInterestedRoomMapID <= 0);
            }
        }


        #endregion

        #region Constructor

        public CRMBuyerInterestedRoomMap_DetailedEntity() : base()
        {
        }

        #endregion

        #region Constant

        public const String FLD_NAME_BuyerInterestedRoomMapID = "BuyerInterestedRoomMapID";
        public const String FLD_NAME_BuyerBasicInfoID = "BuyerBasicInfoID";
        public const String FLD_NAME_BuyerInterestedRoomCategoryID = "BuyerInterestedRoomCategoryID";
        public const String FLD_NAME_BuyerBasicInfoContactFullName = "BuyerBasicInfoContactFullName";
        public const String FLD_NAME_BuyerInterestedRoomCategoryName = "BuyerInterestedRoomCategoryName";
        public const String FLD_NAME_RowNumber = "RowNumber";

        #endregion
    }
}
