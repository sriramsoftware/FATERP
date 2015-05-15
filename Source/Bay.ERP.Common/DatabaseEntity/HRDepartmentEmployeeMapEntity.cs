// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 20-Dec-2013, 02:17:52




using System;
using System.Diagnostics;
using System.ServiceModel;
using System.Runtime.Serialization;
using System.Collections.Generic;
using System.Xml.Serialization;


namespace Bay.ERP.Common.BusinessEntities
{
    [Serializable]
    [DataContract(Name = "HRDepartmentEmployeeMap", Namespace = "http://www.e-p-m-s.com/types")]
    public partial class HRDepartmentEmployeeMapEntity : BaseEntity
    {
        #region Properties


        private Int64 _DepartmentEmployeeMapID;
        private Int64 _DepartmentID;
        private Int64 _EmployeeID;
        private Boolean _IsHeadOfDepartment;


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

        public HRDepartmentEmployeeMapEntity() : base()
        {
        }

        #endregion

        #region Constant

        public const String FLD_NAME_DepartmentEmployeeMapID = "DepartmentEmployeeMapID";
        public const String FLD_NAME_DepartmentID = "DepartmentID";
        public const String FLD_NAME_EmployeeID = "EmployeeID";
        public const String FLD_NAME_IsHeadOfDepartment = "IsHeadOfDepartment";

        #endregion
    }
}
