// Copyright and All Rights Reserved by
//B2B Solution, Bangladesh;
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 08-Jan-2012, 04:47:08




using System;
using System.Diagnostics;
using System.ServiceModel;
using System.Runtime.Serialization;
using System.Collections.Generic;
using System.Xml.Serialization;


namespace Bay.ERP.Common.BusinessEntities
{
    [Serializable]
    [DataContract(Name = "CMConsultantContactPerson", Namespace = "http://www.e-p-m-s.com/types")]
    public partial class CMConsultantContactPersonEntity : BaseEntity
    {
        #region Properties


        private Int64 _ConsultantContactPersonID;
        private Int64 _ConsultantID;
        private String _Name;
        private String _Designation;
        private String _AddressLine1;
        private String _AddressLine2;
        private String _Phone;
        private String _ContactNo;
        private String _Email;
        private String _Remarks;


        [DataMember]
        public Int64 ConsultantContactPersonID
        {
            get { return _ConsultantContactPersonID; }
            set { _ConsultantContactPersonID = value; }
        }

        [DataMember]
        public Int64 ConsultantID
        {
            get { return _ConsultantID; }
            set { _ConsultantID = value; }
        }

        [DataMember]
        public String Name
        {
            get { return _Name; }
            set { _Name = value; }
        }

        [DataMember]
        public String Designation
        {
            get { return _Designation; }
            set { _Designation = value; }
        }

        [DataMember]
        public String AddressLine1
        {
            get { return _AddressLine1; }
            set { _AddressLine1 = value; }
        }

        [DataMember]
        public String AddressLine2
        {
            get { return _AddressLine2; }
            set { _AddressLine2 = value; }
        }

        [DataMember]
        public String Phone
        {
            get { return _Phone; }
            set { _Phone = value; }
        }

        [DataMember]
        public String ContactNo
        {
            get { return _ContactNo; }
            set { _ContactNo = value; }
        }

        [DataMember]
        public String Email
        {
            get { return _Email; }
            set { _Email = value; }
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
                return (ConsultantContactPersonID <= 0);
            }
        }


        #endregion

        #region Constructor

        public CMConsultantContactPersonEntity() : base()
        {
        }

        #endregion

        #region Constant

        public const String FLD_NAME_ConsultantContactPersonID = "ConsultantContactPersonID";
        public const String FLD_NAME_ConsultantID = "ConsultantID";
        public const String FLD_NAME_Name = "Name";
        public const String FLD_NAME_Designation = "Designation";
        public const String FLD_NAME_AddressLine1 = "AddressLine1";
        public const String FLD_NAME_AddressLine2 = "AddressLine2";
        public const String FLD_NAME_Phone = "Phone";
        public const String FLD_NAME_ContactNo = "ContactNo";
        public const String FLD_NAME_Email = "Email";
        public const String FLD_NAME_Remarks = "Remarks";

        #endregion
    }
}
