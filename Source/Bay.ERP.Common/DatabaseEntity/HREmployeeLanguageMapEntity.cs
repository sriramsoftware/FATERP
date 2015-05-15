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
    [DataContract(Name = "HREmployeeLanguageMap", Namespace = "http://www.e-p-m-s.com/types")]
    public partial class HREmployeeLanguageMapEntity : BaseEntity
    {
        #region Properties


        private Int64 _EmployeeLanguageMapID;
        private Int64 _EmployeeID;
        private Int64 _EmployeeLanguageID;
        private Int64 _EmployeeCompetencyLevelID;
        private String _Remarks;


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

        public HREmployeeLanguageMapEntity() : base()
        {
        }

        #endregion

        #region Constant

        public const String FLD_NAME_EmployeeLanguageMapID = "EmployeeLanguageMapID";
        public const String FLD_NAME_EmployeeID = "EmployeeID";
        public const String FLD_NAME_EmployeeLanguageID = "EmployeeLanguageID";
        public const String FLD_NAME_EmployeeCompetencyLevelID = "EmployeeCompetencyLevelID";
        public const String FLD_NAME_Remarks = "Remarks";

        #endregion
    }
}
