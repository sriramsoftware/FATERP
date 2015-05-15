// Copyright and All Rights Reserved by
//B2B Solution, Bangladesh;
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 07-May-2012, 12:01:21




using System;
using System.Diagnostics;
using System.ServiceModel;
using System.Runtime.Serialization;
using System.Collections.Generic;
using System.Xml.Serialization;


namespace Bay.ERP.Common.BusinessEntities
{
    [Serializable]
    [DataContract(Name = "PRMSupplierView_Custom", Namespace = "http://www.e-p-m-s.com/types")]
    public partial class PRMSupplierView_CustomEntity : BaseEntity
    {
        #region Properties


        private Int64 _SupplierID;
        private String _SupplierCode;
        private String _SupplierName;
        private String _Relationship;
        private String _Phone;
        private String _Email;
        private String _Fax;
        private String _MobileNo;
        private String _WebLink;
        private DateTime _CreateDate;
        private Int64 _SupplierTypeID;
        private Int64 _SupplierStatusID;
        private String _SupplierTypeName;
        private String _SupplierStatusName;
        private Int64? _SupplierItemCategoryID;
        private String _SupplierItemCategoryName;
        private Int64? _RowNumber;


        [DataMember]
        public Int64 SupplierID
        {
            get { return _SupplierID; }
            set { _SupplierID = value; }
        }

        [DataMember]
        public String SupplierCode
        {
            get { return _SupplierCode; }
            set { _SupplierCode = value; }
        }

        [DataMember]
        public String SupplierName
        {
            get { return _SupplierName; }
            set { _SupplierName = value; }
        }

        [DataMember]
        public String Relationship
        {
            get { return _Relationship; }
            set { _Relationship = value; }
        }

        [DataMember]
        public String Phone
        {
            get { return _Phone; }
            set { _Phone = value; }
        }

        [DataMember]
        public String Email
        {
            get { return _Email; }
            set { _Email = value; }
        }

        [DataMember]
        public String Fax
        {
            get { return _Fax; }
            set { _Fax = value; }
        }

        [DataMember]
        public String MobileNo
        {
            get { return _MobileNo; }
            set { _MobileNo = value; }
        }

        [DataMember]
        public String WebLink
        {
            get { return _WebLink; }
            set { _WebLink = value; }
        }

        [DataMember]
        public DateTime CreateDate
        {
            get { return _CreateDate; }
            set { _CreateDate = value; }
        }

        [DataMember]
        public Int64 SupplierTypeID
        {
            get { return _SupplierTypeID; }
            set { _SupplierTypeID = value; }
        }

        [DataMember]
        public Int64 SupplierStatusID
        {
            get { return _SupplierStatusID; }
            set { _SupplierStatusID = value; }
        }

        [DataMember]
        public String SupplierTypeName
        {
            get { return _SupplierTypeName; }
            set { _SupplierTypeName = value; }
        }

        [DataMember]
        public String SupplierStatusName
        {
            get { return _SupplierStatusName; }
            set { _SupplierStatusName = value; }
        }

        [DataMember]
        public Int64? SupplierItemCategoryID
        {
            get { return _SupplierItemCategoryID; }
            set { _SupplierItemCategoryID = value; }
        }

        [DataMember]
        public String SupplierItemCategoryName
        {
            get { return _SupplierItemCategoryName; }
            set { _SupplierItemCategoryName = value; }
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
                return (SupplierID <= 0);
            }
        }


        #endregion

        #region Constructor

        public PRMSupplierView_CustomEntity() : base()
        {
        }

        #endregion

        #region Constant

        public const String FLD_NAME_SupplierID = "SupplierID";
        public const String FLD_NAME_SupplierCode = "SupplierCode";
        public const String FLD_NAME_SupplierName = "SupplierName";
        public const String FLD_NAME_Relationship = "Relationship";
        public const String FLD_NAME_Phone = "Phone";
        public const String FLD_NAME_Email = "Email";
        public const String FLD_NAME_Fax = "Fax";
        public const String FLD_NAME_MobileNo = "MobileNo";
        public const String FLD_NAME_WebLink = "WebLink";
        public const String FLD_NAME_CreateDate = "CreateDate";
        public const String FLD_NAME_SupplierTypeID = "SupplierTypeID";
        public const String FLD_NAME_SupplierStatusID = "SupplierStatusID";
        public const String FLD_NAME_SupplierTypeName = "SupplierTypeName";
        public const String FLD_NAME_SupplierStatusName = "SupplierStatusName";
        public const String FLD_NAME_SupplierItemCategoryID = "SupplierItemCategoryID";
        public const String FLD_NAME_SupplierItemCategoryName = "SupplierItemCategoryName";
        public const String FLD_NAME_RowNumber = "RowNumber";

        #endregion
    }
}
