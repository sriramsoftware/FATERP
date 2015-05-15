// Copyright and All Rights Reserved by
//B2B Solution, Bangladesh;
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 16-Jul-2012, 10:35:09




using System;
using System.Diagnostics;
using System.ServiceModel;
using System.Runtime.Serialization;
using System.Collections.Generic;
using System.Xml.Serialization;


namespace Bay.ERP.Common.BusinessEntities
{
    [Serializable]
    [DataContract(Name = "BDProjectAssignedPerson_Detailed", Namespace = "http://www.e-p-m-s.com/types")]
    public partial class BDProjectAssignedPerson_DetailedEntity : BaseEntity
    {
        #region Properties


        private Int64 _ProjectAssignedPersonID;
        private Int64 _ProjectID;
        private Int64 _EmployeeID;
        private Int64 _ProjectAssignedPersonTeamRoleID;
        private String _Description;
        private String _BDProjectProjectName;
        private String _MemberFullName;
        private String _ProjectAssignedPersonTeamRoleName;
        private Int64? _RowNumber;


        [DataMember]
        public Int64 ProjectAssignedPersonID
        {
            get { return _ProjectAssignedPersonID; }
            set { _ProjectAssignedPersonID = value; }
        }

        [DataMember]
        public Int64 ProjectID
        {
            get { return _ProjectID; }
            set { _ProjectID = value; }
        }

        [DataMember]
        public Int64 EmployeeID
        {
            get { return _EmployeeID; }
            set { _EmployeeID = value; }
        }

        [DataMember]
        public Int64 ProjectAssignedPersonTeamRoleID
        {
            get { return _ProjectAssignedPersonTeamRoleID; }
            set { _ProjectAssignedPersonTeamRoleID = value; }
        }

        [DataMember]
        public String Description
        {
            get { return _Description; }
            set { _Description = value; }
        }

        [DataMember]
        public String BDProjectProjectName
        {
            get { return _BDProjectProjectName; }
            set { _BDProjectProjectName = value; }
        }

        [DataMember]
        public String MemberFullName
        {
            get { return _MemberFullName; }
            set { _MemberFullName = value; }
        }

        [DataMember]
        public String ProjectAssignedPersonTeamRoleName
        {
            get { return _ProjectAssignedPersonTeamRoleName; }
            set { _ProjectAssignedPersonTeamRoleName = value; }
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
                return (ProjectAssignedPersonID <= 0);
            }
        }


        #endregion

        #region Constructor

        public BDProjectAssignedPerson_DetailedEntity() : base()
        {
        }

        #endregion

        #region Constant

        public const String FLD_NAME_ProjectAssignedPersonID = "ProjectAssignedPersonID";
        public const String FLD_NAME_ProjectID = "ProjectID";
        public const String FLD_NAME_EmployeeID = "EmployeeID";
        public const String FLD_NAME_ProjectAssignedPersonTeamRoleID = "ProjectAssignedPersonTeamRoleID";
        public const String FLD_NAME_Description = "Description";
        public const String FLD_NAME_BDProjectProjectName = "BDProjectProjectName";
        public const String FLD_NAME_MemberFullName = "MemberFullName";
        public const String FLD_NAME_ProjectAssignedPersonTeamRoleName = "ProjectAssignedPersonTeamRoleName";
        public const String FLD_NAME_RowNumber = "RowNumber";

        #endregion
    }
}
