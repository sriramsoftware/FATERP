// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 21-Oct-2012, 06:49:23




using System;
using System.Diagnostics;
using System.ServiceModel;
using System.Runtime.Serialization;
using System.Collections.Generic;
using System.Xml.Serialization;


namespace Bay.ERP.Common.BusinessEntities
{
    [Serializable]
    [DataContract(Name = "APPanelForwardMember_Detailed", Namespace = "http://www.e-p-m-s.com/types")]
    public partial class APPanelForwardMember_DetailedEntity : BaseEntity
    {
        #region Properties


        private Int64 _APPanelForwardMemberID;
        private Int64 _APPanelID;
        private Int64 _EmployeeID;
        private Int64 _DepartmentID;
        private String _APPanelName;
        private Int64? _HREmployeeMemberID;
        private String _MemberFullName;
        private String _MDDepartmentName;
        private Int64? _RowNumber;


        [DataMember]
        public Int64 APPanelForwardMemberID
        {
            get { return _APPanelForwardMemberID; }
            set { _APPanelForwardMemberID = value; }
        }

        [DataMember]
        public Int64 APPanelID
        {
            get { return _APPanelID; }
            set { _APPanelID = value; }
        }

        [DataMember]
        public Int64 EmployeeID
        {
            get { return _EmployeeID; }
            set { _EmployeeID = value; }
        }

        [DataMember]
        public Int64 DepartmentID
        {
            get { return _DepartmentID; }
            set { _DepartmentID = value; }
        }

        [DataMember]
        public String APPanelName
        {
            get { return _APPanelName; }
            set { _APPanelName = value; }
        }

        [DataMember]
        public Int64? HREmployeeMemberID
        {
            get { return _HREmployeeMemberID; }
            set { _HREmployeeMemberID = value; }
        }

        [DataMember]
        public String MemberFullName
        {
            get { return _MemberFullName; }
            set { _MemberFullName = value; }
        }

        [DataMember]
        public String MDDepartmentName
        {
            get { return _MDDepartmentName; }
            set { _MDDepartmentName = value; }
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
                return (APPanelForwardMemberID <= 0);
            }
        }


        #endregion

        #region Constructor

        public APPanelForwardMember_DetailedEntity() : base()
        {
        }

        #endregion

        #region Constant

        public const String FLD_NAME_APPanelForwardMemberID = "APPanelForwardMemberID";
        public const String FLD_NAME_APPanelID = "APPanelID";
        public const String FLD_NAME_EmployeeID = "EmployeeID";
        public const String FLD_NAME_DepartmentID = "DepartmentID";
        public const String FLD_NAME_APPanelName = "APPanelName";
        public const String FLD_NAME_HREmployeeMemberID = "HREmployeeMemberID";
        public const String FLD_NAME_MemberFullName = "MemberFullName";
        public const String FLD_NAME_MDDepartmentName = "MDDepartmentName";
        public const String FLD_NAME_RowNumber = "RowNumber";

        #endregion
    }
}
