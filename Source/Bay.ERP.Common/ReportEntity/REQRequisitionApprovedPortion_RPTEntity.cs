// Copyright and All Rights Reserved by
//B2B Solution, Bangladesh;
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 16-Jul-2012, 11:43:31




using System;
using System.Diagnostics;
using System.ServiceModel;
using System.Runtime.Serialization;
using System.Collections.Generic;
using System.Xml.Serialization;


namespace Bay.ERP.Common.BusinessEntities
{
    [Serializable]
    [DataContract(Name = "REQRequisitionApprovedPortion_RPT", Namespace = "http://www.e-p-m-s.com/types")]
    public partial class REQRequisitionApprovedPortion_RPTEntity : BaseEntity
    {
        #region Properties


        private Int64 _ProjectAssignedPersonID;
        private Int64 _ProjectAssignedPersonTeamRoleID;
        private Int64 _EmployeeID;
        private Int64 _ProjectID;
        private String _ProjectAssignedPersonTeamRole;
        private String _MemberFullName;
        private String _ProjectAssignedPersonTeamRoleName;


        [DataMember]
        public Int64 ProjectAssignedPersonID
        {
            get { return _ProjectAssignedPersonID; }
            set { _ProjectAssignedPersonID = value; }
        }

        [DataMember]
        public Int64 ProjectAssignedPersonTeamRoleID
        {
            get { return _ProjectAssignedPersonTeamRoleID; }
            set { _ProjectAssignedPersonTeamRoleID = value; }
        }

        [DataMember]
        public Int64 EmployeeID
        {
            get { return _EmployeeID; }
            set { _EmployeeID = value; }
        }

        [DataMember]
        public Int64 ProjectID
        {
            get { return _ProjectID; }
            set { _ProjectID = value; }
        }

        [DataMember]
        public String ProjectAssignedPersonTeamRole
        {
            get { return _ProjectAssignedPersonTeamRole; }
            set { _ProjectAssignedPersonTeamRole = value; }
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

        public REQRequisitionApprovedPortion_RPTEntity() : base()
        {
        }

        #endregion

        #region Constant

        public const String FLD_NAME_ProjectAssignedPersonID = "ProjectAssignedPersonID";
        public const String FLD_NAME_ProjectAssignedPersonTeamRoleID = "ProjectAssignedPersonTeamRoleID";
        public const String FLD_NAME_EmployeeID = "EmployeeID";
        public const String FLD_NAME_ProjectID = "ProjectID";
        public const String FLD_NAME_ProjectAssignedPersonTeamRole = "ProjectAssignedPersonTeamRole";
        public const String FLD_NAME_MemberFullName = "MemberFullName";
        public const String FLD_NAME_ProjectAssignedPersonTeamRoleName = "ProjectAssignedPersonTeamRoleName";

        #endregion
    }
}
