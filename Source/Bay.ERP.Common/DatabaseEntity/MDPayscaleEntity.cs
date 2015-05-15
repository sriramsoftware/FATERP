// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 19-Dec-2013, 12:42:28




using System;
using System.Diagnostics;
using System.ServiceModel;
using System.Runtime.Serialization;
using System.Collections.Generic;
using System.Xml.Serialization;


namespace Bay.ERP.Common.BusinessEntities
{
    [Serializable]
    [DataContract(Name = "MDPayscale", Namespace = "http://www.e-p-m-s.com/types")]
    public partial class MDPayscaleEntity : BaseEntity
    {
        #region Properties


        private Int64 _PayscaleID;
        private String _Name;
        private String _Description;
        private Decimal _MinimumSalary;
        private Decimal _MaximumSalary;
        private Decimal _AverageSalary;
        private Int64 _SalaryRateDurationID;
        private Boolean _IsRemoved;


        [DataMember]
        public Int64 PayscaleID
        {
            get { return _PayscaleID; }
            set { _PayscaleID = value; }
        }

        [DataMember]
        public String Name
        {
            get { return _Name; }
            set { _Name = value; }
        }

        [DataMember]
        public String Description
        {
            get { return _Description; }
            set { _Description = value; }
        }

        [DataMember]
        public Decimal MinimumSalary
        {
            get { return _MinimumSalary; }
            set { _MinimumSalary = value; }
        }

        [DataMember]
        public Decimal MaximumSalary
        {
            get { return _MaximumSalary; }
            set { _MaximumSalary = value; }
        }

        [DataMember]
        public Decimal AverageSalary
        {
            get { return _AverageSalary; }
            set { _AverageSalary = value; }
        }

        [DataMember]
        public Int64 SalaryRateDurationID
        {
            get { return _SalaryRateDurationID; }
            set { _SalaryRateDurationID = value; }
        }

        [DataMember]
        public Boolean IsRemoved
        {
            get { return _IsRemoved; }
            set { _IsRemoved = value; }
        }

        [XmlIgnore()]
        public override bool IsNew
        {
            [DebuggerStepThrough()]
            get
            {
                return (PayscaleID <= 0);
            }
        }


        #endregion

        #region Constructor

        public MDPayscaleEntity() : base()
        {
        }

        #endregion

        #region Constant

        public const String FLD_NAME_PayscaleID = "PayscaleID";
        public const String FLD_NAME_Name = "Name";
        public const String FLD_NAME_Description = "Description";
        public const String FLD_NAME_MinimumSalary = "MinimumSalary";
        public const String FLD_NAME_MaximumSalary = "MaximumSalary";
        public const String FLD_NAME_AverageSalary = "AverageSalary";
        public const String FLD_NAME_SalaryRateDurationID = "SalaryRateDurationID";
        public const String FLD_NAME_IsRemoved = "IsRemoved";

        #endregion
    }
}
