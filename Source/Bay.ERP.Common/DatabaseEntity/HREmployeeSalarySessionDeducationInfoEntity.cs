// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 12-Jan-2014, 03:42:17




using System;
using System.Diagnostics;
using System.ServiceModel;
using System.Runtime.Serialization;
using System.Collections.Generic;
using System.Xml.Serialization;


namespace Bay.ERP.Common.BusinessEntities
{
    [Serializable]
    [DataContract(Name = "HREmployeeSalarySessionDeducationInfo", Namespace = "http://www.e-p-m-s.com/types")]
    public partial class HREmployeeSalarySessionDeducationInfoEntity : BaseEntity
    {
        #region Properties


        private Int64 _EmployeeSalarySessionDeducationInfoID;
        private Int64 _SalarySessionID;
        private Decimal? _DeductionAmount;
        private String _Note;


        [DataMember]
        public Int64 EmployeeSalarySessionDeducationInfoID
        {
            get { return _EmployeeSalarySessionDeducationInfoID; }
            set { _EmployeeSalarySessionDeducationInfoID = value; }
        }

        [DataMember]
        public Int64 SalarySessionID
        {
            get { return _SalarySessionID; }
            set { _SalarySessionID = value; }
        }

        [DataMember]
        public Decimal? DeductionAmount
        {
            get { return _DeductionAmount; }
            set { _DeductionAmount = value; }
        }

        [DataMember]
        public String Note
        {
            get { return _Note; }
            set { _Note = value; }
        }

        [XmlIgnore()]
        public override bool IsNew
        {
            [DebuggerStepThrough()]
            get
            {
                return (EmployeeSalarySessionDeducationInfoID <= 0);
            }
        }


        #endregion

        #region Constructor

        public HREmployeeSalarySessionDeducationInfoEntity() : base()
        {
        }

        #endregion

        #region Constant

        public const String FLD_NAME_EmployeeSalarySessionDeducationInfoID = "EmployeeSalarySessionDeducationInfoID";
        public const String FLD_NAME_SalarySessionID = "SalarySessionID";
        public const String FLD_NAME_DeductionAmount = "DeductionAmount";
        public const String FLD_NAME_Note = "Note";

        #endregion
    }
}
