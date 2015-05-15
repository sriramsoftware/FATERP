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
    [DataContract(Name = "CRMBuyerAllottee", Namespace = "http://www.e-p-m-s.com/types")]
    public partial class CRMBuyerAllotteeEntity : BaseEntity
    {
        #region Properties


        private Int64 _BuyerAllotteeID;
        private Int64 _BuyerBasicInfoID;
        private String _OwnerFullName;
        private String _ImageUrl;
        private Decimal? _OwnPercentage;
        private String _MobileNo;
        private String _LandPhone;
        private String _PresentAddress;
        private String _FatherName;
        private String _MotherName;
        private String _SpouseName;
        private String _TINNumber;
        private DateTime? _DateOfBirth;
        private String _Email;
        private String _BusinessDetails;


        [DataMember]
        public Int64 BuyerAllotteeID
        {
            get { return _BuyerAllotteeID; }
            set { _BuyerAllotteeID = value; }
        }

        [DataMember]
        public Int64 BuyerBasicInfoID
        {
            get { return _BuyerBasicInfoID; }
            set { _BuyerBasicInfoID = value; }
        }

        [DataMember]
        public String OwnerFullName
        {
            get { return _OwnerFullName; }
            set { _OwnerFullName = value; }
        }

        [DataMember]
        public String ImageUrl
        {
            get { return _ImageUrl; }
            set { _ImageUrl = value; }
        }

        [DataMember]
        public Decimal? OwnPercentage
        {
            get { return _OwnPercentage; }
            set { _OwnPercentage = value; }
        }

        [DataMember]
        public String MobileNo
        {
            get { return _MobileNo; }
            set { _MobileNo = value; }
        }

        [DataMember]
        public String LandPhone
        {
            get { return _LandPhone; }
            set { _LandPhone = value; }
        }

        [DataMember]
        public String PresentAddress
        {
            get { return _PresentAddress; }
            set { _PresentAddress = value; }
        }

        [DataMember]
        public String FatherName
        {
            get { return _FatherName; }
            set { _FatherName = value; }
        }

        [DataMember]
        public String MotherName
        {
            get { return _MotherName; }
            set { _MotherName = value; }
        }

        [DataMember]
        public String SpouseName
        {
            get { return _SpouseName; }
            set { _SpouseName = value; }
        }

        [DataMember]
        public String TINNumber
        {
            get { return _TINNumber; }
            set { _TINNumber = value; }
        }

        [DataMember]
        public DateTime? DateOfBirth
        {
            get { return _DateOfBirth; }
            set { _DateOfBirth = value; }
        }

        [DataMember]
        public String Email
        {
            get { return _Email; }
            set { _Email = value; }
        }

        [DataMember]
        public String BusinessDetails
        {
            get { return _BusinessDetails; }
            set { _BusinessDetails = value; }
        }

        [XmlIgnore()]
        public override bool IsNew
        {
            [DebuggerStepThrough()]
            get
            {
                return (BuyerAllotteeID <= 0);
            }
        }


        #endregion

        #region Constructor

        public CRMBuyerAllotteeEntity() : base()
        {
        }

        #endregion

        #region Constant

        public const String FLD_NAME_BuyerAllotteeID = "BuyerAllotteeID";
        public const String FLD_NAME_BuyerBasicInfoID = "BuyerBasicInfoID";
        public const String FLD_NAME_OwnerFullName = "OwnerFullName";
        public const String FLD_NAME_ImageUrl = "ImageUrl";
        public const String FLD_NAME_OwnPercentage = "OwnPercentage";
        public const String FLD_NAME_MobileNo = "MobileNo";
        public const String FLD_NAME_LandPhone = "LandPhone";
        public const String FLD_NAME_PresentAddress = "PresentAddress";
        public const String FLD_NAME_FatherName = "FatherName";
        public const String FLD_NAME_MotherName = "MotherName";
        public const String FLD_NAME_SpouseName = "SpouseName";
        public const String FLD_NAME_TINNumber = "TINNumber";
        public const String FLD_NAME_DateOfBirth = "DateOfBirth";
        public const String FLD_NAME_Email = "Email";
        public const String FLD_NAME_BusinessDetails = "BusinessDetails";

        #endregion
    }
}
