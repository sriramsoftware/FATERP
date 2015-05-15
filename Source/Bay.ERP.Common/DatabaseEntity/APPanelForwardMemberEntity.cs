// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 20-Oct-2012, 11:32:20




using System;
using System.Diagnostics;
using System.ServiceModel;
using System.Runtime.Serialization;
using System.Collections.Generic;
using System.Xml.Serialization;


namespace Bay.ERP.Common.BusinessEntities
{
    [Serializable]
    [DataContract(Name = "APPanelForwardMember", Namespace = "http://www.e-p-m-s.com/types")]
    public partial class APPanelForwardMemberEntity : BaseEntity
    {
        #region Properties


        private Int64 _APPanelForwardMemberID;
        private Int64 _APPanelID;
        private Int64 _EmployeeID;
        private Int64 _DepartmentID;


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

        public APPanelForwardMemberEntity() : base()
        {
        }

        #endregion

        #region Constant

        public const String FLD_NAME_APPanelForwardMemberID = "APPanelForwardMemberID";
        public const String FLD_NAME_APPanelID = "APPanelID";
        public const String FLD_NAME_EmployeeID = "EmployeeID";
        public const String FLD_NAME_DepartmentID = "DepartmentID";

        #endregion
    }
}
