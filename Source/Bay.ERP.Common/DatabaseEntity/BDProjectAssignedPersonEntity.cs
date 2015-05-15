// Copyright and All Rights Reserved by
//B2B Solution, Bangladesh;
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 15-Jul-2012, 05:23:43




using System;
using System.Diagnostics;
using System.ServiceModel;
using System.Runtime.Serialization;
using System.Collections.Generic;
using System.Xml.Serialization;


namespace Bay.ERP.Common.BusinessEntities
{
    [Serializable]
    [DataContract(Name = "BDProjectAssignedPerson", Namespace = "http://www.e-p-m-s.com/types")]
    public partial class BDProjectAssignedPersonEntity : BaseEntity
    {
        #region Properties


        private Int64 _ProjectAssignedPersonID;
        private Int64 _ProjectID;
        private Int64 _EmployeeID;
        private Int64 _ProjectAssignedPersonTeamRoleID;
        private String _Description;


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

        public BDProjectAssignedPersonEntity() : base()
        {
        }

        #endregion

        #region Constant

        public const String FLD_NAME_ProjectAssignedPersonID = "ProjectAssignedPersonID";
        public const String FLD_NAME_ProjectID = "ProjectID";
        public const String FLD_NAME_EmployeeID = "EmployeeID";
        public const String FLD_NAME_ProjectAssignedPersonTeamRoleID = "ProjectAssignedPersonTeamRoleID";
        public const String FLD_NAME_Description = "Description";

        #endregion
    }
}
