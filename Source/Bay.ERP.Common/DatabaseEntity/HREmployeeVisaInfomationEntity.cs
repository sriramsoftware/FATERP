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
    [DataContract(Name = "HREmployeeVisaInfomation", Namespace = "http://www.e-p-m-s.com/types")]
    public partial class HREmployeeVisaInfomationEntity : BaseEntity
    {
        #region Properties


        private Int64 _EmployeeVisaInfomationID;
        private Int64 _EmployeeID;
        private Int64 _VisaStatusID;
        private String _VisaTransferInfo;
        private String _ProfessionInVisa;
        private String _VisaNumber;
        private DateTime? _VisaIssuedDate;
        private String _Remarks;


        [DataMember]
        public Int64 EmployeeVisaInfomationID
        {
            get { return _EmployeeVisaInfomationID; }
            set { _EmployeeVisaInfomationID = value; }
        }

        [DataMember]
        public Int64 EmployeeID
        {
            get { return _EmployeeID; }
            set { _EmployeeID = value; }
        }

        [DataMember]
        public Int64 VisaStatusID
        {
            get { return _VisaStatusID; }
            set { _VisaStatusID = value; }
        }

        [DataMember]
        public String VisaTransferInfo
        {
            get { return _VisaTransferInfo; }
            set { _VisaTransferInfo = value; }
        }

        [DataMember]
        public String ProfessionInVisa
        {
            get { return _ProfessionInVisa; }
            set { _ProfessionInVisa = value; }
        }

        [DataMember]
        public String VisaNumber
        {
            get { return _VisaNumber; }
            set { _VisaNumber = value; }
        }

        [DataMember]
        public DateTime? VisaIssuedDate
        {
            get { return _VisaIssuedDate; }
            set { _VisaIssuedDate = value; }
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
                return (EmployeeVisaInfomationID <= 0);
            }
        }


        #endregion

        #region Constructor

        public HREmployeeVisaInfomationEntity() : base()
        {
        }

        #endregion

        #region Constant

        public const String FLD_NAME_EmployeeVisaInfomationID = "EmployeeVisaInfomationID";
        public const String FLD_NAME_EmployeeID = "EmployeeID";
        public const String FLD_NAME_VisaStatusID = "VisaStatusID";
        public const String FLD_NAME_VisaTransferInfo = "VisaTransferInfo";
        public const String FLD_NAME_ProfessionInVisa = "ProfessionInVisa";
        public const String FLD_NAME_VisaNumber = "VisaNumber";
        public const String FLD_NAME_VisaIssuedDate = "VisaIssuedDate";
        public const String FLD_NAME_Remarks = "Remarks";

        #endregion
    }
}
