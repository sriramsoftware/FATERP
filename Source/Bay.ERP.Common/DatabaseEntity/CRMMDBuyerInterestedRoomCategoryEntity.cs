// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 01-Apr-2013, 02:41:21




using System;
using System.Diagnostics;
using System.ServiceModel;
using System.Runtime.Serialization;
using System.Collections.Generic;
using System.Xml.Serialization;


namespace Bay.ERP.Common.BusinessEntities
{
    [Serializable]
    [DataContract(Name = "CRMMDBuyerInterestedRoomCategory", Namespace = "http://www.e-p-m-s.com/types")]
    public partial class CRMMDBuyerInterestedRoomCategoryEntity : BaseEntity
    {
        #region Properties


        private Int64 _BuyerInterestedRoomCategoryID;
        private String _Name;
        private String _Description;
        private Boolean _IsRemoved;


        [DataMember]
        public Int64 BuyerInterestedRoomCategoryID
        {
            get { return _BuyerInterestedRoomCategoryID; }
            set { _BuyerInterestedRoomCategoryID = value; }
        }

        [DataMember]
        public String Name
        {
            get { return _Name; }
            set { _Name = value; }
        }

        [DataMember]
        public String Description
        {
            get { return _Description; }
            set { _Description = value; }
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
                return (BuyerInterestedRoomCategoryID <= 0);
            }
        }


        #endregion

        #region Constructor

        public CRMMDBuyerInterestedRoomCategoryEntity() : base()
        {
        }

        #endregion

        #region Constant

        public const String FLD_NAME_BuyerInterestedRoomCategoryID = "BuyerInterestedRoomCategoryID";
        public const String FLD_NAME_Name = "Name";
        public const String FLD_NAME_Description = "Description";
        public const String FLD_NAME_IsRemoved = "IsRemoved";

        #endregion
    }
}
