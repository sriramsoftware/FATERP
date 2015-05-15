// Copyright and All Rights Reserved by
//B2B Solution, Bangladesh;
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 22-Dec-2011, 02:17:33




using System;
using System.Diagnostics;
using System.ServiceModel;
using System.Runtime.Serialization;
using System.Collections.Generic;
using System.Xml.Serialization;


namespace Bay.ERP.Common.BusinessEntities
{
    [Serializable]
    [DataContract(Name = "BDProjectAddressInfo_Detailed", Namespace = "http://www.e-p-m-s.com/types")]
    public partial class BDProjectAddressInfo_DetailedEntity : BaseEntity
    {
        #region Properties


        private Int64 _ProjectAddressInfoID;
        private Int64 _ProjectID;
        private String _AddressLine1;
        private String _AddressLine2;
        private Int64? _CountryID;
        private Int64? _CityID;
        private String _ZipCode;
        private String _ProjectName;
        private String _CountryName;
        private String _CityName;
        private Int64? _RowNumber;


        [DataMember]
        public Int64 ProjectAddressInfoID
        {
            get { return _ProjectAddressInfoID; }
            set { _ProjectAddressInfoID = value; }
        }

        [DataMember]
        public Int64 ProjectID
        {
            get { return _ProjectID; }
            set { _ProjectID = value; }
        }

        [DataMember]
        public String AddressLine1
        {
            get { return _AddressLine1; }
            set { _AddressLine1 = value; }
        }

        [DataMember]
        public String AddressLine2
        {
            get { return _AddressLine2; }
            set { _AddressLine2 = value; }
        }

        [DataMember]
        public Int64? CountryID
        {
            get { return _CountryID; }
            set { _CountryID = value; }
        }

        [DataMember]
        public Int64? CityID
        {
            get { return _CityID; }
            set { _CityID = value; }
        }

        [DataMember]
        public String ZipCode
        {
            get { return _ZipCode; }
            set { _ZipCode = value; }
        }

        [DataMember]
        public String ProjectName
        {
            get { return _ProjectName; }
            set { _ProjectName = value; }
        }

        [DataMember]
        public String CountryName
        {
            get { return _CountryName; }
            set { _CountryName = value; }
        }

        [DataMember]
        public String CityName
        {
            get { return _CityName; }
            set { _CityName = value; }
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
                return (ProjectAddressInfoID <= 0);
            }
        }


        #endregion

        #region Constructor

        public BDProjectAddressInfo_DetailedEntity() : base()
        {
        }

        #endregion

        #region Constant

        public const String FLD_NAME_ProjectAddressInfoID = "ProjectAddressInfoID";
        public const String FLD_NAME_ProjectID = "ProjectID";
        public const String FLD_NAME_AddressLine1 = "AddressLine1";
        public const String FLD_NAME_AddressLine2 = "AddressLine2";
        public const String FLD_NAME_CountryID = "CountryID";
        public const String FLD_NAME_CityID = "CityID";
        public const String FLD_NAME_ZipCode = "ZipCode";
        public const String FLD_NAME_ProjectName = "ProjectName";
        public const String FLD_NAME_CountryName = "CountryName";
        public const String FLD_NAME_CityName = "CityName";
        public const String FLD_NAME_RowNumber = "RowNumber";

        #endregion
    }
}
