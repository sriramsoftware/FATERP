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
    [DataContract(Name = "HRAdditonalInformation", Namespace = "http://www.e-p-m-s.com/types")]
    public partial class HRAdditonalInformationEntity : BaseEntity
    {
        #region Properties


        private Int64 _AdditonalInformationID;
        private Int64 _EmployeeID;
        private Int64 _EmployeeAdditionalInformationCategoryID;
        private Decimal _Value;
        private String _ExtraStringColumn;
        private String _ExtraField1;
        private String _Remarks;


        [DataMember]
        public Int64 AdditonalInformationID
        {
            get { return _AdditonalInformationID; }
            set { _AdditonalInformationID = value; }
        }

        [DataMember]
        public Int64 EmployeeID
        {
            get { return _EmployeeID; }
            set { _EmployeeID = value; }
        }

        [DataMember]
        public Int64 EmployeeAdditionalInformationCategoryID
        {
            get { return _EmployeeAdditionalInformationCategoryID; }
            set { _EmployeeAdditionalInformationCategoryID = value; }
        }

        [DataMember]
        public Decimal Value
        {
            get { return _Value; }
            set { _Value = value; }
        }

        [DataMember]
        public String ExtraStringColumn
        {
            get { return _ExtraStringColumn; }
            set { _ExtraStringColumn = value; }
        }

        [DataMember]
        public String ExtraField1
        {
            get { return _ExtraField1; }
            set { _ExtraField1 = value; }
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
                return (AdditonalInformationID <= 0);
            }
        }


        #endregion

        #region Constructor

        public HRAdditonalInformationEntity() : base()
        {
        }

        #endregion

        #region Constant

        public const String FLD_NAME_AdditonalInformationID = "AdditonalInformationID";
        public const String FLD_NAME_EmployeeID = "EmployeeID";
        public const String FLD_NAME_EmployeeAdditionalInformationCategoryID = "EmployeeAdditionalInformationCategoryID";
        public const String FLD_NAME_Value = "Value";
        public const String FLD_NAME_ExtraStringColumn = "ExtraStringColumn";
        public const String FLD_NAME_ExtraField1 = "ExtraField1";
        public const String FLD_NAME_Remarks = "Remarks";

        #endregion
    }
}
