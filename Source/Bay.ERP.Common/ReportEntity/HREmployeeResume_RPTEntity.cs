// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 13-Jul-2013, 09:56:00




using System;
using System.Diagnostics;
using System.ServiceModel;
using System.Runtime.Serialization;
using System.Collections.Generic;
using System.Xml.Serialization;


namespace Bay.ERP.Common.BusinessEntities
{
    [Serializable]
    [DataContract(Name = "HREmployeeResume_RPT", Namespace = "http://www.e-p-m-s.com/types")]
    public partial class HREmployeeResume_RPTEntity : BaseEntity
    {
        #region Properties

        private Int64 _EmployeeResumeID;
        private String _EmployeeResume;
        
        [DataMember]
        public Int64 EmployeeResumeID
        {
            get { return _EmployeeResumeID; }
            set { _EmployeeResumeID = value; }
        }

        [DataMember]
        public String EmployeeResume
        {
            get { return _EmployeeResume; }
            set { EmployeeResume = value; }
        }

        [XmlIgnore()]
        public override bool IsNew
        {
            [DebuggerStepThrough()]
            get
            {
                return (EmployeeResumeID <= 0);
            }
        }


        #endregion

        #region Constructor

        public HREmployeeResume_RPTEntity()
            : base()
        {
        }

        #endregion

        #region Constant

        public const String FLD_NAME_EmployeeResumeID = "EmployeeResumeID";
        public const String FLD_NAME_EmployeeResume = "EmployeeResume";

        #endregion
    }
}
