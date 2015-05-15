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
    [DataContract(Name = "HRDepartmentEmployeeMap_Detailed", Namespace = "http://www.e-p-m-s.com/types")]
    public partial class HRDepartmentEmployeeMap_DetailedEntity : BaseEntity
    {
        #region Properties


        private Int64 _DepartmentEmployeeMapID;
        private Int64 _DepartmentID;
        private Int64 _EmployeeID;
        private Boolean _IsHeadOfDepartment;
        private String _EmployeeFullName;
        private String _DepartmentCode;
        private Int64? _RowNumber;


        [DataMember]
        public Int64 DepartmentEmployeeMapID
        {
            get { return _DepartmentEmployeeMapID; }
            set { _DepartmentEmployeeMapID = value; }
        }

        [DataMember]
        public Int64 DepartmentID
        {
            get { return _DepartmentID; }
            set { _DepartmentID = value; }
        }

        [DataMember]
        public Int64 EmployeeID
        {
            get { return _EmployeeID; }
            set { _EmployeeID = value; }
        }

        [DataMember]
        public Boolean IsHeadOfDepartment
        {
            get { return _IsHeadOfDepartment; }
            set { _IsHeadOfDepartment = value; }
        }

        [DataMember]
        public String EmployeeFullName
        {
            get { return _EmployeeFullName; }
            set { _EmployeeFullName = value; }
        }

        [DataMember]
        public String DepartmentCode
        {
            get { return _DepartmentCode; }
            set { _DepartmentCode = value; }
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
                return (DepartmentEmployeeMapID <= 0);
            }
        }


        #endregion

        #region Constructor

        public HRDepartmentEmployeeMap_DetailedEntity() : base()
        {
        }

        #endregion

        #region Constant

        public const String FLD_NAME_DepartmentEmployeeMapID = "DepartmentEmployeeMapID";
        public const String FLD_NAME_DepartmentID = "DepartmentID";
        public const String FLD_NAME_EmployeeID = "EmployeeID";
        public const String FLD_NAME_IsHeadOfDepartment = "IsHeadOfDepartment";
        public const String FLD_NAME_EmployeeFullName = "EmployeeFullName";
        public const String FLD_NAME_DepartmentCode = "DepartmentCode";
        public const String FLD_NAME_RowNumber = "RowNumber";

        #endregion
    }
}
