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
    [DataContract(Name = "HREmployeeEducation", Namespace = "http://www.e-p-m-s.com/types")]
    public partial class HREmployeeEducationEntity : BaseEntity
    {
        #region Properties


        private Int64 _EmployeeEducationID;
        private Int64 _EmployeeID;
        private Int64 _EducationalDegreeID;
        private Int32? _PassedYear;
        private String _Session;
        private String _Result;
        private String _ResultOutOf;
        private String _Remarks;
        private Boolean _IsCompleted;
        private Boolean _IsLastAcquired;


        [DataMember]
        public Int64 EmployeeEducationID
        {
            get { return _EmployeeEducationID; }
            set { _EmployeeEducationID = value; }
        }

        [DataMember]
        public Int64 EmployeeID
        {
            get { return _EmployeeID; }
            set { _EmployeeID = value; }
        }

        [DataMember]
        public Int64 EducationalDegreeID
        {
            get { return _EducationalDegreeID; }
            set { _EducationalDegreeID = value; }
        }

        [DataMember]
        public Int32? PassedYear
        {
            get { return _PassedYear; }
            set { _PassedYear = value; }
        }

        [DataMember]
        public String Session
        {
            get { return _Session; }
            set { _Session = value; }
        }

        [DataMember]
        public String Result
        {
            get { return _Result; }
            set { _Result = value; }
        }

        [DataMember]
        public String ResultOutOf
        {
            get { return _ResultOutOf; }
            set { _ResultOutOf = value; }
        }

        [DataMember]
        public String Remarks
        {
            get { return _Remarks; }
            set { _Remarks = value; }
        }

        [DataMember]
        public Boolean IsCompleted
        {
            get { return _IsCompleted; }
            set { _IsCompleted = value; }
        }

        [DataMember]
        public Boolean IsLastAcquired
        {
            get { return _IsLastAcquired; }
            set { _IsLastAcquired = value; }
        }

        [XmlIgnore()]
        public override bool IsNew
        {
            [DebuggerStepThrough()]
            get
            {
                return (EmployeeEducationID <= 0);
            }
        }


        #endregion

        #region Constructor

        public HREmployeeEducationEntity() : base()
        {
        }

        #endregion

        #region Constant

        public const String FLD_NAME_EmployeeEducationID = "EmployeeEducationID";
        public const String FLD_NAME_EmployeeID = "EmployeeID";
        public const String FLD_NAME_EducationalDegreeID = "EducationalDegreeID";
        public const String FLD_NAME_PassedYear = "PassedYear";
        public const String FLD_NAME_Session = "Session";
        public const String FLD_NAME_Result = "Result";
        public const String FLD_NAME_ResultOutOf = "ResultOutOf";
        public const String FLD_NAME_Remarks = "Remarks";
        public const String FLD_NAME_IsCompleted = "IsCompleted";
        public const String FLD_NAME_IsLastAcquired = "IsLastAcquired";

        #endregion
    }
}
