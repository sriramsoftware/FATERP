// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 03-Sep-2013, 04:16:48




using System;
using System.Diagnostics;
using System.ServiceModel;
using System.Runtime.Serialization;
using System.Collections.Generic;
using System.Xml.Serialization;


namespace Bay.ERP.Common.BusinessEntities
{
    [Serializable]
    [DataContract(Name = "OTIssueCategoryWiseIndividual_RPT", Namespace = "http://www.e-p-m-s.com/types")]
    public partial class OTIssueCategoryWiseIndividual_RPTEntity : BaseEntity
    {
        #region Properties


        private Int64 _IssueCategoryID;
        private Int64? _ReferenceID;
        private String _Name;
        private String _AssignedPersonEmployeeCode;
        private String _AssignedPersonDesignationName;
        private String _AssignedPersonDepartmentName;
        private String _AssignedToEmployeeFullName;
        private String _ProjectName;
        private Int32? _TotalTime;


        [DataMember]
        public Int64 IssueCategoryID
        {
            get { return _IssueCategoryID; }
            set { _IssueCategoryID = value; }
        }

        [DataMember]
        public Int64? ReferenceID
        {
            get { return _ReferenceID; }
            set { _ReferenceID = value; }
        }

        [DataMember]
        public String Name
        {
            get { return _Name; }
            set { _Name = value; }
        }

        [DataMember]
        public String AssignedPersonEmployeeCode
        {
            get { return _AssignedPersonEmployeeCode; }
            set { _AssignedPersonEmployeeCode = value; }
        }

        [DataMember]
        public String AssignedPersonDesignationName
        {
            get { return _AssignedPersonDesignationName; }
            set { _AssignedPersonDesignationName = value; }
        }

        [DataMember]
        public String AssignedPersonDepartmentName
        {
            get { return _AssignedPersonDepartmentName; }
            set { _AssignedPersonDepartmentName = value; }
        }

        [DataMember]
        public String AssignedToEmployeeFullName
        {
            get { return _AssignedToEmployeeFullName; }
            set { _AssignedToEmployeeFullName = value; }
        }

        [DataMember]
        public String ProjectName
        {
            get { return _ProjectName; }
            set { _ProjectName = value; }
        }

        [DataMember]
        public Int32? TotalTime
        {
            get { return _TotalTime; }
            set { _TotalTime = value; }
        }

        [XmlIgnore()]
        public override bool IsNew
        {
            [DebuggerStepThrough()]
            get
            {
                return (IssueCategoryID <= 0);
            }
        }


        #endregion

        #region Constructor

        public OTIssueCategoryWiseIndividual_RPTEntity() : base()
        {
        }

        #endregion

        #region Constant

        public const String FLD_NAME_IssueCategoryID = "IssueCategoryID";
        public const String FLD_NAME_ReferenceID = "ReferenceID";
        public const String FLD_NAME_Name = "Name";
        public const String FLD_NAME_AssignedPersonEmployeeCode = "AssignedPersonEmployeeCode";
        public const String FLD_NAME_AssignedPersonDesignationName = "AssignedPersonDesignationName";
        public const String FLD_NAME_AssignedPersonDepartmentName = "AssignedPersonDepartmentName";
        public const String FLD_NAME_AssignedToEmployeeFullName = "AssignedToEmployeeFullName";
        public const String FLD_NAME_ProjectName = "ProjectName";
        public const String FLD_NAME_TotalTime = "TotalTime";

        #endregion
    }
}
