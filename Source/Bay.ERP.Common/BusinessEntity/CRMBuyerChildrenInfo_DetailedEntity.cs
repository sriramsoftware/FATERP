// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 22-May-2013, 11:39:55




using System;
using System.Diagnostics;
using System.ServiceModel;
using System.Runtime.Serialization;
using System.Collections.Generic;
using System.Xml.Serialization;


namespace Bay.ERP.Common.BusinessEntities
{
    [Serializable]
    [DataContract(Name = "CRMBuyerChildrenInfo_Detailed", Namespace = "http://www.e-p-m-s.com/types")]
    public partial class CRMBuyerChildrenInfo_DetailedEntity : BaseEntity
    {
        #region Properties


        private Int64 _BuyerChildrenInfoID;
        private Int64 _BuyerBasicInfoID;
        private String _Name;
        private DateTime? _DOB;
        private Int64 _GenderID;
        private String _EditionalInstituteName;
        private String _GenderName;
        private Int64? _RowNumber;


        [DataMember]
        public Int64 BuyerChildrenInfoID
        {
            get { return _BuyerChildrenInfoID; }
            set { _BuyerChildrenInfoID = value; }
        }

        [DataMember]
        public Int64 BuyerBasicInfoID
        {
            get { return _BuyerBasicInfoID; }
            set { _BuyerBasicInfoID = value; }
        }

        [DataMember]
        public String Name
        {
            get { return _Name; }
            set { _Name = value; }
        }

        [DataMember]
        public DateTime? DOB
        {
            get { return _DOB; }
            set { _DOB = value; }
        }

        [DataMember]
        public Int64 GenderID
        {
            get { return _GenderID; }
            set { _GenderID = value; }
        }

        [DataMember]
        public String EditionalInstituteName
        {
            get { return _EditionalInstituteName; }
            set { _EditionalInstituteName = value; }
        }

        [DataMember]
        public String GenderName
        {
            get { return _GenderName; }
            set { _GenderName = value; }
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
                return (BuyerChildrenInfoID <= 0);
            }
        }

        #endregion

        #region Constructor

        public CRMBuyerChildrenInfo_DetailedEntity()
            : base()
        {
        }

        #endregion

        #region Constant

        public const String FLD_NAME_BuyerChildrenInfoID = "BuyerChildrenInfoID";
        public const String FLD_NAME_BuyerBasicInfoID = "BuyerBasicInfoID";
        public const String FLD_NAME_Name = "Name";
        public const String FLD_NAME_DOB = "DOB";
        public const String FLD_NAME_GenderID = "GenderID";
        public const String FLD_NAME_EditionalInstituteName = "EditionalInstituteName";
        public const String FLD_NAME_GenderName = "GenderName";
        public const String FLD_NAME_RowNumber = "RowNumber";

        #endregion
    }
}
