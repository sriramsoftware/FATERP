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
    [DataContract(Name = "HREmployeeResume", Namespace = "http://www.e-p-m-s.com/types")]
    public partial class HREmployeeResumeEntity : BaseEntity
    {
        #region Properties


        private Int64 _EmployeeResumeID;
        private Int64 _EmployeeID;
        private Int64 _ResumeCategoryID;
        private String _Text;
        private String _Remarks;


        [DataMember]
        public Int64 EmployeeResumeID
        {
            get { return _EmployeeResumeID; }
            set { _EmployeeResumeID = value; }
        }

        [DataMember]
        public Int64 EmployeeID
        {
            get { return _EmployeeID; }
            set { _EmployeeID = value; }
        }

        [DataMember]
        public Int64 ResumeCategoryID
        {
            get { return _ResumeCategoryID; }
            set { _ResumeCategoryID = value; }
        }

        [DataMember]
        public String Text
        {
            get { return _Text; }
            set { _Text = value; }
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
                return (EmployeeResumeID <= 0);
            }
        }


        #endregion

        #region Constructor

        public HREmployeeResumeEntity() : base()
        {
        }

        #endregion

        #region Constant

        public const String FLD_NAME_EmployeeResumeID = "EmployeeResumeID";
        public const String FLD_NAME_EmployeeID = "EmployeeID";
        public const String FLD_NAME_ResumeCategoryID = "ResumeCategoryID";
        public const String FLD_NAME_Text = "Text";
        public const String FLD_NAME_Remarks = "Remarks";

        #endregion
    }
}
