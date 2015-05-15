// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 07-Jan-2014, 10:14:40




using System;
using System.Diagnostics;
using System.ServiceModel;
using System.Runtime.Serialization;
using System.Collections.Generic;
using System.Xml.Serialization;


namespace Bay.ERP.Common.BusinessEntities
{
    [Serializable]
    [DataContract(Name = "HREmployeeBankAccountInformation_Detailed", Namespace = "http://www.e-p-m-s.com/types")]
    public partial class HREmployeeBankAccountInformation_DetailedEntity : BaseEntity
    {
        #region Properties


        private Int64 _EmployeeBankAccountInformationID;
        private Int64 _EmployeeID;
        private String _BankAccountNo;
        private String _BankName;
        private String _BankAddress;
        private Int64 _CityID;
        private String _ZipCode;
        private byte?[] _POBox;
        private Int64 _BankAccountCategoryID;
        private String _SwipeCode;
        private String _RoutingNo;
        private Boolean _IsSalaryAccotunt;
        private Boolean _IsDefault;
        private String _EmployeeFullName;
        private String _CityName;
        private String _BankAccountCategoryName;
        private Int64? _RowNumber;


        [DataMember]
        public Int64 EmployeeBankAccountInformationID
        {
            get { return _EmployeeBankAccountInformationID; }
            set { _EmployeeBankAccountInformationID = value; }
        }

        [DataMember]
        public Int64 EmployeeID
        {
            get { return _EmployeeID; }
            set { _EmployeeID = value; }
        }

        [DataMember]
        public String BankAccountNo
        {
            get { return _BankAccountNo; }
            set { _BankAccountNo = value; }
        }

        [DataMember]
        public String BankName
        {
            get { return _BankName; }
            set { _BankName = value; }
        }

        [DataMember]
        public String BankAddress
        {
            get { return _BankAddress; }
            set { _BankAddress = value; }
        }

        [DataMember]
        public Int64 CityID
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
        public byte?[] POBox
        {
            get { return _POBox; }
            set { _POBox = value; }
        }

        [DataMember]
        public Int64 BankAccountCategoryID
        {
            get { return _BankAccountCategoryID; }
            set { _BankAccountCategoryID = value; }
        }

        [DataMember]
        public String SwipeCode
        {
            get { return _SwipeCode; }
            set { _SwipeCode = value; }
        }

        [DataMember]
        public String RoutingNo
        {
            get { return _RoutingNo; }
            set { _RoutingNo = value; }
        }

        [DataMember]
        public Boolean IsSalaryAccotunt
        {
            get { return _IsSalaryAccotunt; }
            set { _IsSalaryAccotunt = value; }
        }

        [DataMember]
        public Boolean IsDefault
        {
            get { return _IsDefault; }
            set { _IsDefault = value; }
        }

        [DataMember]
        public String EmployeeFullName
        {
            get { return _EmployeeFullName; }
            set { _EmployeeFullName = value; }
        }

        [DataMember]
        public String CityName
        {
            get { return _CityName; }
            set { _CityName = value; }
        }

        [DataMember]
        public String BankAccountCategoryName
        {
            get { return _BankAccountCategoryName; }
            set { _BankAccountCategoryName = value; }
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
                return (EmployeeBankAccountInformationID <= 0);
            }
        }


        #endregion

        #region Constructor

        public HREmployeeBankAccountInformation_DetailedEntity() : base()
        {
        }

        #endregion

        #region Constant

        public const String FLD_NAME_EmployeeBankAccountInformationID = "EmployeeBankAccountInformationID";
        public const String FLD_NAME_EmployeeID = "EmployeeID";
        public const String FLD_NAME_BankAccountNo = "BankAccountNo";
        public const String FLD_NAME_BankName = "BankName";
        public const String FLD_NAME_BankAddress = "BankAddress";
        public const String FLD_NAME_CityID = "CityID";
        public const String FLD_NAME_ZipCode = "ZipCode";
        public const String FLD_NAME_POBox = "POBox";
        public const String FLD_NAME_BankAccountCategoryID = "BankAccountCategoryID";
        public const String FLD_NAME_SwipeCode = "SwipeCode";
        public const String FLD_NAME_RoutingNo = "RoutingNo";
        public const String FLD_NAME_IsSalaryAccotunt = "IsSalaryAccotunt";
        public const String FLD_NAME_IsDefault = "IsDefault";
        public const String FLD_NAME_EmployeeFullName = "EmployeeFullName";
        public const String FLD_NAME_CityName = "CityName";
        public const String FLD_NAME_BankAccountCategoryName = "BankAccountCategoryName";
        public const String FLD_NAME_RowNumber = "RowNumber";

        #endregion
    }
}
