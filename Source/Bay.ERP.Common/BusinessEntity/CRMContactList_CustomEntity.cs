// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 14-Jul-2013, 12:25:01




using System;
using System.Diagnostics;
using System.ServiceModel;
using System.Runtime.Serialization;
using System.Collections.Generic;
using System.Xml.Serialization;


namespace Bay.ERP.Common.BusinessEntities
{
    [Serializable]
    [DataContract(Name = "CRMContactList_Custom", Namespace = "http://www.e-p-m-s.com/types")]
    public partial class CRMContactList_CustomEntity : BaseEntity
    {
        #region Properties


        private Int64 _ResourceID;
        private String _ResourceCategoryID;
        private String _ResourceName;
        private String _ResourceDesignation;
        private String _ResourceCompany;
        private String _ResourceMobileNo;
        private String _ResourceEmail;
        private String _AddressLine1;
        private String _AddressLine2;
        private Int64 _ResourceTypeID;
        private DateTime? _ResourceDOB;


        [DataMember]
        public Int64 ResourceID
        {
            get { return _ResourceID; }
            set { _ResourceID = value; }
        }

        [DataMember]
        public String ResourceCategoryID
        {
            get { return _ResourceCategoryID; }
            set { _ResourceCategoryID = value; }
        }

        [DataMember]
        public String ResourceName
        {
            get { return _ResourceName; }
            set { _ResourceName = value; }
        }

        [DataMember]
        public String ResourceDesignation
        {
            get { return _ResourceDesignation; }
            set { _ResourceDesignation = value; }
        }

        [DataMember]
        public String ResourceCompany
        {
            get { return _ResourceCompany; }
            set { _ResourceCompany = value; }
        }

        [DataMember]
        public String ResourceMobileNo
        {
            get { return _ResourceMobileNo; }
            set { _ResourceMobileNo = value; }
        }

        [DataMember]
        public String ResourceEmail
        {
            get { return _ResourceEmail; }
            set { _ResourceEmail = value; }
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
        public Int64 ResourceTypeID
        {
            get { return _ResourceTypeID; }
            set { _ResourceTypeID = value; }
        }

        [DataMember]
        public DateTime? ResourceDOB
        {
            get { return _ResourceDOB; }
            set { _ResourceDOB = value; }
        }

        [XmlIgnore()]
        public override bool IsNew
        {
            [DebuggerStepThrough()]
            get
            {
                return (ResourceID <= 0);
            }
        }


        #endregion

        #region Constructor

        public CRMContactList_CustomEntity() : base()
        {
        }

        #endregion

        #region Constant

        public const String FLD_NAME_ResourceID = "ResourceID";
        public const String FLD_NAME_ResourceCategoryID = "ResourceCategoryID";
        public const String FLD_NAME_ResourceName = "ResourceName";
        public const String FLD_NAME_ResourceDesignation = "ResourceDesignation";
        public const String FLD_NAME_ResourceCompany = "ResourceCompany";
        public const String FLD_NAME_ResourceMobileNo = "ResourceMobileNo";
        public const String FLD_NAME_ResourceEmail = "ResourceEmail";
        public const String FLD_NAME_AddressLine1 = "AddressLine1";
        public const String FLD_NAME_AddressLine2 = "AddressLine2";
        public const String FLD_NAME_ResourceTypeID = "ResourceTypeID";
        public const String FLD_NAME_ResourceDOB = "ResourceDOB";

        #endregion
    }
}
