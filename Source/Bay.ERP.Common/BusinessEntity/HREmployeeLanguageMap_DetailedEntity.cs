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
    [DataContract(Name = "HREmployeeLanguageMap_Detailed", Namespace = "http://www.e-p-m-s.com/types")]
    public partial class HREmployeeLanguageMap_DetailedEntity : BaseEntity
    {
        #region Properties


        private Int64 _EmployeeLanguageMapID;
        private Int64 _EmployeeID;
        private Int64 _EmployeeLanguageID;
        private Int64 _EmployeeCompetencyLevelID;
        private String _Remarks;
        private String _EmployeeFullName;
        private String _EmployeeLanguageName;
        private String _EmployeeCompetencyLevelName;
        private Int64? _RowNumber;


        [DataMember]
        public Int64 EmployeeLanguageMapID
        {
            get { return _EmployeeLanguageMapID; }
            set { _EmployeeLanguageMapID = value; }
        }

        [DataMember]
        public Int64 EmployeeID
        {
            get { return _EmployeeID; }
            set { _EmployeeID = value; }
        }

        [DataMember]
        public Int64 EmployeeLanguageID
        {
            get { return _EmployeeLanguageID; }
            set { _EmployeeLanguageID = value; }
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
        public String EmployeeLanguageName
        {
            get { return _EmployeeLanguageName; }
            set { _EmployeeLanguageName = value; }
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
                return (EmployeeLanguageMapID <= 0);
            }
        }


        #endregion

        #region Constructor

        public HREmployeeLanguageMap_DetailedEntity() : base()
        {
        }

        #endregion

        #region Constant

        public const String FLD_NAME_EmployeeLanguageMapID = "EmployeeLanguageMapID";
        public const String FLD_NAME_EmployeeID = "EmployeeID";
        public const String FLD_NAME_EmployeeLanguageID = "EmployeeLanguageID";
        public const String FLD_NAME_EmployeeCompetencyLevelID = "EmployeeCompetencyLevelID";
        public const String FLD_NAME_Remarks = "Remarks";
        public const String FLD_NAME_EmployeeFullName = "EmployeeFullName";
        public const String FLD_NAME_EmployeeLanguageName = "EmployeeLanguageName";
        public const String FLD_NAME_EmployeeCompetencyLevelName = "EmployeeCompetencyLevelName";
        public const String FLD_NAME_RowNumber = "RowNumber";

        #endregion
    }
}
