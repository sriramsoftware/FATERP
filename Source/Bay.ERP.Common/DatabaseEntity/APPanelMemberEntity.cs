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
    [DataContract(Name = "APPanelMember", Namespace = "http://www.e-p-m-s.com/types")]
    public partial class APPanelMemberEntity : BaseEntity
    {
        #region Properties


        private Int64 _APPanelMemberID;
        private Int64 _APPanelID;
        private Int64 _DepartmentID;
        private Int64 _EmployeeID;
        private Int32 _SequenceNo;
        private Int64? _ProxyEmployeeID;
        private Boolean _IsProxyEmployeeEnabled;


        [DataMember]
        public Int64 APPanelMemberID
        {
            get { return _APPanelMemberID; }
            set { _APPanelMemberID = value; }
        }

        [DataMember]
        public Int64 APPanelID
        {
            get { return _APPanelID; }
            set { _APPanelID = value; }
        }

        [DataMember]
        public Int64 DepartmentID
        {
            get { return _DepartmentID; }
            set { _DepartmentID = value; }
        }

        [DataMember]
        public Int64 EmployeeID
        {
            get { return _EmployeeID; }
            set { _EmployeeID = value; }
        }

        [DataMember]
        public Int32 SequenceNo
        {
            get { return _SequenceNo; }
            set { _SequenceNo = value; }
        }

        [DataMember]
        public Int64? ProxyEmployeeID
        {
            get { return _ProxyEmployeeID; }
            set { _ProxyEmployeeID = value; }
        }

        [DataMember]
        public Boolean IsProxyEmployeeEnabled
        {
            get { return _IsProxyEmployeeEnabled; }
            set { _IsProxyEmployeeEnabled = value; }
        }

        [XmlIgnore()]
        public override bool IsNew
        {
            [DebuggerStepThrough()]
            get
            {
                return (APPanelMemberID <= 0);
            }
        }


        #endregion

        #region Constructor

        public APPanelMemberEntity() : base()
        {
        }

        #endregion

        #region Constant

        public const String FLD_NAME_APPanelMemberID = "APPanelMemberID";
        public const String FLD_NAME_APPanelID = "APPanelID";
        public const String FLD_NAME_DepartmentID = "DepartmentID";
        public const String FLD_NAME_EmployeeID = "EmployeeID";
        public const String FLD_NAME_SequenceNo = "SequenceNo";
        public const String FLD_NAME_ProxyEmployeeID = "ProxyEmployeeID";
        public const String FLD_NAME_IsProxyEmployeeEnabled = "IsProxyEmployeeEnabled";

        #endregion
    }
}
