// Copyright and All Rights Reserved by
//B2B Solution, Bangladesh;
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 07-Jan-2012, 02:49:42




using System;
using System.Diagnostics;
using System.ServiceModel;
using System.Runtime.Serialization;
using System.Collections.Generic;
using System.Xml.Serialization;


namespace Bay.ERP.Common.BusinessEntities
{
    [Serializable]
    [DataContract(Name = "CMFinancialStrengthMajorWork", Namespace = "http://www.e-p-m-s.com/types")]
    public partial class CMFinancialStrengthMajorWorkEntity : BaseEntity
    {
        #region Properties


        private Int64 _FinancialStrengthMajorWorkID;
        private Int64 _ContractorID;
        private String _Name;


        [DataMember]
        public Int64 FinancialStrengthMajorWorkID
        {
            get { return _FinancialStrengthMajorWorkID; }
            set { _FinancialStrengthMajorWorkID = value; }
        }

        [DataMember]
        public Int64 ContractorID
        {
            get { return _ContractorID; }
            set { _ContractorID = value; }
        }

        [DataMember]
        public String Name
        {
            get { return _Name; }
            set { _Name = value; }
        }

        [XmlIgnore()]
        public override bool IsNew
        {
            [DebuggerStepThrough()]
            get
            {
                return (FinancialStrengthMajorWorkID <= 0);
            }
        }


        #endregion

        #region Constructor

        public CMFinancialStrengthMajorWorkEntity() : base()
        {
        }

        #endregion

        #region Constant

        public const String FLD_NAME_FinancialStrengthMajorWorkID = "FinancialStrengthMajorWorkID";
        public const String FLD_NAME_ContractorID = "ContractorID";
        public const String FLD_NAME_Name = "Name";

        #endregion
    }
}
