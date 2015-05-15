// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 08-Sep-2013, 03:37:27




using System;
using System.Diagnostics;
using System.ServiceModel;
using System.Runtime.Serialization;
using System.Collections.Generic;
using System.Xml.Serialization;


namespace Bay.ERP.Common.BusinessEntities
{
    [Serializable]
    [DataContract(Name = "HREmployeeSupervisorMap", Namespace = "http://www.e-p-m-s.com/types")]
    public partial class HREmployeeSupervisorMapEntity : BaseEntity
    {
        #region Properties


        private Int64 _EmployeeSupervisorMapID;
        private Int64 _SessionCategoryID;
        private Int64 _EmployeeID;
        private String _EmployeeCode;
        private Int64 _SupervisorTypeID;
        private Int64 _SupervisorEmployeeID;
        private String _SupervisorEmployeeCode;
        private String _Remarks;
        private DateTime _CreateDate;


        [DataMember]
        public Int64 EmployeeSupervisorMapID
        {
            get { return _EmployeeSupervisorMapID; }
            set { _EmployeeSupervisorMapID = value; }
        }

        [DataMember]
        public Int64 SessionCategoryID
        {
            get { return _SessionCategoryID; }
            set { _SessionCategoryID = value; }
        }

        [DataMember]
        public Int64 EmployeeID
        {
            get { return _EmployeeID; }
            set { _EmployeeID = value; }
        }

        [DataMember]
        public String EmployeeCode
        {
            get { return _EmployeeCode; }
            set { _EmployeeCode = value; }
        }

        [DataMember]
        public Int64 SupervisorTypeID
        {
            get { return _SupervisorTypeID; }
            set { _SupervisorTypeID = value; }
        }

        [DataMember]
        public Int64 SupervisorEmployeeID
        {
            get { return _SupervisorEmployeeID; }
            set { _SupervisorEmployeeID = value; }
        }

        [DataMember]
        public String SupervisorEmployeeCode
        {
            get { return _SupervisorEmployeeCode; }
            set { _SupervisorEmployeeCode = value; }
        }

        [DataMember]
        public String Remarks
        {
            get { return _Remarks; }
            set { _Remarks = value; }
        }

        [DataMember]
        public DateTime CreateDate
        {
            get { return _CreateDate; }
            set { _CreateDate = value; }
        }

        [XmlIgnore()]
        public override bool IsNew
        {
            [DebuggerStepThrough()]
            get
            {
                return (EmployeeSupervisorMapID <= 0);
            }
        }


        #endregion

        #region Constructor

        public HREmployeeSupervisorMapEntity() : base()
        {
        }

        #endregion

        #region Constant

        public const String FLD_NAME_EmployeeSupervisorMapID = "EmployeeSupervisorMapID";
        public const String FLD_NAME_SessionCategoryID = "SessionCategoryID";
        public const String FLD_NAME_EmployeeID = "EmployeeID";
        public const String FLD_NAME_EmployeeCode = "EmployeeCode";
        public const String FLD_NAME_SupervisorTypeID = "SupervisorTypeID";
        public const String FLD_NAME_SupervisorEmployeeID = "SupervisorEmployeeID";
        public const String FLD_NAME_SupervisorEmployeeCode = "SupervisorEmployeeCode";
        public const String FLD_NAME_Remarks = "Remarks";
        public const String FLD_NAME_CreateDate = "CreateDate";

        #endregion
    }
}
