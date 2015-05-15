// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 06-Oct-2013, 01:41:30




using System;
using System.Diagnostics;
using System.ServiceModel;
using System.Runtime.Serialization;
using System.Collections.Generic;
using System.Xml.Serialization;


namespace Bay.ERP.Common.BusinessEntities
{
    [Serializable]
    [DataContract(Name = "CMConsultant", Namespace = "http://www.e-p-m-s.com/types")]
    public partial class CMConsultantEntity : BaseEntity
    {
        #region Properties


        private Int64 _ConsultantID;
        private Int64? _MemberID;
        private Int64 _OutsourceCategoryID;
        private String _Name;
        private String _ImageUrl;
        private String _CurrentPosition;
        private String _InstitueName;
        private String _EmailAddress1;
        private String _EmailAddress2;
        private String _ContactNo1;
        private String _ContactNo2;
        private String _Phone;
        private String _Remarks;
        private Boolean _IsRemoved;


        [DataMember]
        public Int64 ConsultantID
        {
            get { return _ConsultantID; }
            set { _ConsultantID = value; }
        }

        [DataMember]
        public Int64? MemberID
        {
            get { return _MemberID; }
            set { _MemberID = value; }
        }

        [DataMember]
        public Int64 OutsourceCategoryID
        {
            get { return _OutsourceCategoryID; }
            set { _OutsourceCategoryID = value; }
        }

        [DataMember]
        public String Name
        {
            get { return _Name; }
            set { _Name = value; }
        }

        [DataMember]
        public String ImageUrl
        {
            get { return _ImageUrl; }
            set { _ImageUrl = value; }
        }

        [DataMember]
        public String CurrentPosition
        {
            get { return _CurrentPosition; }
            set { _CurrentPosition = value; }
        }

        [DataMember]
        public String InstitueName
        {
            get { return _InstitueName; }
            set { _InstitueName = value; }
        }

        [DataMember]
        public String EmailAddress1
        {
            get { return _EmailAddress1; }
            set { _EmailAddress1 = value; }
        }

        [DataMember]
        public String EmailAddress2
        {
            get { return _EmailAddress2; }
            set { _EmailAddress2 = value; }
        }

        [DataMember]
        public String ContactNo1
        {
            get { return _ContactNo1; }
            set { _ContactNo1 = value; }
        }

        [DataMember]
        public String ContactNo2
        {
            get { return _ContactNo2; }
            set { _ContactNo2 = value; }
        }

        [DataMember]
        public String Phone
        {
            get { return _Phone; }
            set { _Phone = value; }
        }

        [DataMember]
        public String Remarks
        {
            get { return _Remarks; }
            set { _Remarks = value; }
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
                return (ConsultantID <= 0);
            }
        }


        #endregion

        #region Constructor

        public CMConsultantEntity() : base()
        {
        }

        #endregion

        #region Constant

        public const String FLD_NAME_ConsultantID = "ConsultantID";
        public const String FLD_NAME_MemberID = "MemberID";
        public const String FLD_NAME_OutsourceCategoryID = "OutsourceCategoryID";
        public const String FLD_NAME_Name = "Name";
        public const String FLD_NAME_ImageUrl = "ImageUrl";
        public const String FLD_NAME_CurrentPosition = "CurrentPosition";
        public const String FLD_NAME_InstitueName = "InstitueName";
        public const String FLD_NAME_EmailAddress1 = "EmailAddress1";
        public const String FLD_NAME_EmailAddress2 = "EmailAddress2";
        public const String FLD_NAME_ContactNo1 = "ContactNo1";
        public const String FLD_NAME_ContactNo2 = "ContactNo2";
        public const String FLD_NAME_Phone = "Phone";
        public const String FLD_NAME_Remarks = "Remarks";
        public const String FLD_NAME_IsRemoved = "IsRemoved";

        #endregion
    }
}
