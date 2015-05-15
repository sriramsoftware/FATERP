// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 14-Jul-2013, 01:40:47




using System;
using System.Diagnostics;
using System.ServiceModel;
using System.Runtime.Serialization;
using System.Collections.Generic;
using System.Xml.Serialization;


namespace Bay.ERP.Common.BusinessEntities
{
    [Serializable]
    [DataContract(Name = "BDProcessAssignedResourceMap_RPT", Namespace = "http://www.e-p-m-s.com/types")]
    public partial class BDProcessAssignedResourceMap_RPTEntity : BaseEntity
    {
        #region Properties


        private Int64 _ProcessAssignedResourceMapID;
        private Int64 _ProcessAssignedResourceID;
        private Int64 _ResourceCategoryID;
        private Int64 _ReferenceID;
        private String _ResourceName;
        private String _ResourceDesignation;
        private String _ResourceCompany;
        private String _ResourceMobileNo;
        private String _ResourceEmail;
        private String _AddressLine1;
        private String _AddressLine2;
        private Int64? _ResourceTypeID;
        private DateTime? _ResourceDOB;
        private String _Remarks;
        private String _Title;
        private String _Purposes;


        [DataMember]
        public Int64 ProcessAssignedResourceMapID
        {
            get { return _ProcessAssignedResourceMapID; }
            set { _ProcessAssignedResourceMapID = value; }
        }

        [DataMember]
        public Int64 ProcessAssignedResourceID
        {
            get { return _ProcessAssignedResourceID; }
            set { _ProcessAssignedResourceID = value; }
        }

        [DataMember]
        public Int64 ResourceCategoryID
        {
            get { return _ResourceCategoryID; }
            set { _ResourceCategoryID = value; }
        }

        [DataMember]
        public Int64 ReferenceID
        {
            get { return _ReferenceID; }
            set { _ReferenceID = value; }
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
        public Int64? ResourceTypeID
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

        [DataMember]
        public String Remarks
        {
            get { return _Remarks; }
            set { _Remarks = value; }
        }

        [DataMember]
        public String Title
        {
            get { return _Title; }
            set { _Title = value; }
        }

        [DataMember]
        public String Purposes
        {
            get { return _Purposes; }
            set { _Purposes = value; }
        }

        [XmlIgnore()]
        public override bool IsNew
        {
            [DebuggerStepThrough()]
            get
            {
                return (ProcessAssignedResourceMapID <= 0);
            }
        }


        #endregion

        #region Constructor

        public BDProcessAssignedResourceMap_RPTEntity() : base()
        {
        }

        #endregion

        #region Constant

        public const String FLD_NAME_ProcessAssignedResourceMapID = "ProcessAssignedResourceMapID";
        public const String FLD_NAME_ProcessAssignedResourceID = "ProcessAssignedResourceID";
        public const String FLD_NAME_ResourceCategoryID = "ResourceCategoryID";
        public const String FLD_NAME_ReferenceID = "ReferenceID";
        public const String FLD_NAME_ResourceName = "ResourceName";
        public const String FLD_NAME_ResourceDesignation = "ResourceDesignation";
        public const String FLD_NAME_ResourceCompany = "ResourceCompany";
        public const String FLD_NAME_ResourceMobileNo = "ResourceMobileNo";
        public const String FLD_NAME_ResourceEmail = "ResourceEmail";
        public const String FLD_NAME_AddressLine1 = "AddressLine1";
        public const String FLD_NAME_AddressLine2 = "AddressLine2";
        public const String FLD_NAME_ResourceTypeID = "ResourceTypeID";
        public const String FLD_NAME_ResourceDOB = "ResourceDOB";
        public const String FLD_NAME_Remarks = "Remarks";
        public const String FLD_NAME_Title = "Title";
        public const String FLD_NAME_Purposes = "Purposes";

        #endregion
    }
}
