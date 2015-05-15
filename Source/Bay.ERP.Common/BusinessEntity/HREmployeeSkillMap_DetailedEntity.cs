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
    [DataContract(Name = "HREmployeeSkillMap_Detailed", Namespace = "http://www.e-p-m-s.com/types")]
    public partial class HREmployeeSkillMap_DetailedEntity : BaseEntity
    {
        #region Properties


        private Int64 _EmployeeSkillMapID;
        private Int64 _EmployeeID;
        private Int64 _EmployeeSkillID;
        private Int64 _EmployeeCompetencyLevelID;
        private String _Remarks;
        private String _EmployeeFullName;
        private String _EmployeeSkillName;
        private String _EmployeeCompetencyLevelName;
        private Int64? _RowNumber;


        [DataMember]
        public Int64 EmployeeSkillMapID
        {
            get { return _EmployeeSkillMapID; }
            set { _EmployeeSkillMapID = value; }
        }

        [DataMember]
        public Int64 EmployeeID
        {
            get { return _EmployeeID; }
            set { _EmployeeID = value; }
        }

        [DataMember]
        public Int64 EmployeeSkillID
        {
            get { return _EmployeeSkillID; }
            set { _EmployeeSkillID = value; }
        }

        [DataMember]
        public Int64 EmployeeCompetencyLevelID
        {
            get { return _EmployeeCompetencyLevelID; }
            set { _EmployeeCompetencyLevelID = value; }
        }

        [DataMember]
        public String Remarks
        {
            get { return _Remarks; }
            set { _Remarks = value; }
        }

        [DataMember]
        public String EmployeeFullName
        {
            get { return _EmployeeFullName; }
            set { _EmployeeFullName = value; }
        }

        [DataMember]
        public String EmployeeSkillName
        {
            get { return _EmployeeSkillName; }
            set { _EmployeeSkillName = value; }
        }

        [DataMember]
        public String EmployeeCompetencyLevelName
        {
            get { return _EmployeeCompetencyLevelName; }
            set { _EmployeeCompetencyLevelName = value; }
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
                return (EmployeeSkillMapID <= 0);
            }
        }


        #endregion

        #region Constructor

        public HREmployeeSkillMap_DetailedEntity() : base()
        {
        }

        #endregion

        #region Constant

        public const String FLD_NAME_EmployeeSkillMapID = "EmployeeSkillMapID";
        public const String FLD_NAME_EmployeeID = "EmployeeID";
        public const String FLD_NAME_EmployeeSkillID = "EmployeeSkillID";
        public const String FLD_NAME_EmployeeCompetencyLevelID = "EmployeeCompetencyLevelID";
        public const String FLD_NAME_Remarks = "Remarks";
        public const String FLD_NAME_EmployeeFullName = "EmployeeFullName";
        public const String FLD_NAME_EmployeeSkillName = "EmployeeSkillName";
        public const String FLD_NAME_EmployeeCompetencyLevelName = "EmployeeCompetencyLevelName";
        public const String FLD_NAME_RowNumber = "RowNumber";

        #endregion
    }
}
