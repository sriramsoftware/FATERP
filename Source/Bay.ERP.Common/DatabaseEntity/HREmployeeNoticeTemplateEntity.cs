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
    [DataContract(Name = "HREmployeeNoticeTemplate", Namespace = "http://www.e-p-m-s.com/types")]
    public partial class HREmployeeNoticeTemplateEntity : BaseEntity
    {
        #region Properties


        private Int64 _EmployeeNoticeTemplateID;
        private Int64 _NoticeTemplateTypeID;
        private String _TemplateName;
        private String _Text;
        private String _Remarks;
        private DateTime _CreateDate;
        private String _IP;
        private Int64 _CreatedByEmployeeID;


        [DataMember]
        public Int64 EmployeeNoticeTemplateID
        {
            get { return _EmployeeNoticeTemplateID; }
            set { _EmployeeNoticeTemplateID = value; }
        }

        [DataMember]
        public Int64 NoticeTemplateTypeID
        {
            get { return _NoticeTemplateTypeID; }
            set { _NoticeTemplateTypeID = value; }
        }

        [DataMember]
        public String TemplateName
        {
            get { return _TemplateName; }
            set { _TemplateName = value; }
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

        [DataMember]
        public DateTime CreateDate
        {
            get { return _CreateDate; }
            set { _CreateDate = value; }
        }

        [DataMember]
        public String IP
        {
            get { return _IP; }
            set { _IP = value; }
        }

        [DataMember]
        public Int64 CreatedByEmployeeID
        {
            get { return _CreatedByEmployeeID; }
            set { _CreatedByEmployeeID = value; }
        }

        [XmlIgnore()]
        public override bool IsNew
        {
            [DebuggerStepThrough()]
            get
            {
                return (EmployeeNoticeTemplateID <= 0);
            }
        }


        #endregion

        #region Constructor

        public HREmployeeNoticeTemplateEntity() : base()
        {
        }

        #endregion

        #region Constant

        public const String FLD_NAME_EmployeeNoticeTemplateID = "EmployeeNoticeTemplateID";
        public const String FLD_NAME_NoticeTemplateTypeID = "NoticeTemplateTypeID";
        public const String FLD_NAME_TemplateName = "TemplateName";
        public const String FLD_NAME_Text = "Text";
        public const String FLD_NAME_Remarks = "Remarks";
        public const String FLD_NAME_CreateDate = "CreateDate";
        public const String FLD_NAME_IP = "IP";
        public const String FLD_NAME_CreatedByEmployeeID = "CreatedByEmployeeID";

        #endregion
    }
}
