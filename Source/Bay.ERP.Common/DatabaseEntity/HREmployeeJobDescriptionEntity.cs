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
    [DataContract(Name = "HREmployeeJobDescription", Namespace = "http://www.e-p-m-s.com/types")]
    public partial class HREmployeeJobDescriptionEntity : BaseEntity
    {
        #region Properties


        private Int64 _EmployeeJobDescriptionID;
        private Int64 _EmployeeID;
        private String _Description;
        private String _Remarks;
        private DateTime _CreateDate;


        [DataMember]
        public Int64 EmployeeJobDescriptionID
        {
            get { return _EmployeeJobDescriptionID; }
            set { _EmployeeJobDescriptionID = value; }
        }

        [DataMember]
        public Int64 EmployeeID
        {
            get { return _EmployeeID; }
            set { _EmployeeID = value; }
        }

        [DataMember]
        public String Description
        {
            get { return _Description; }
            set { _Description = value; }
        }

        [DataMember]
        public String Remarks
        {
            get { return _Remarks; }
            set { _Remarks = value; }
        }

        [DataMember]
        public DateTime CreateDate
        {
            get { return _CreateDate; }
            set { _CreateDate = value; }
        }

        [XmlIgnore()]
        public override bool IsNew
        {
            [DebuggerStepThrough()]
            get
            {
                return (EmployeeJobDescriptionID <= 0);
            }
        }


        #endregion

        #region Constructor

        public HREmployeeJobDescriptionEntity() : base()
        {
        }

        #endregion

        #region Constant

        public const String FLD_NAME_EmployeeJobDescriptionID = "EmployeeJobDescriptionID";
        public const String FLD_NAME_EmployeeID = "EmployeeID";
        public const String FLD_NAME_Description = "Description";
        public const String FLD_NAME_Remarks = "Remarks";
        public const String FLD_NAME_CreateDate = "CreateDate";

        #endregion
    }
}
