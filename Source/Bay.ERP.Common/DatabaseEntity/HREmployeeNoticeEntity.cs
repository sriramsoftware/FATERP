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
    [DataContract(Name = "HREmployeeNotice", Namespace = "http://www.e-p-m-s.com/types")]
    public partial class HREmployeeNoticeEntity : BaseEntity
    {
        #region Properties


        private Int64 _EmployeeNoticeID;
        private Int64 _SendToEmployeeID;
        private String _Memo;
        private String _Text;
        private String _Remarks;
        private DateTime _NoticeDate;
        private Int64 _PreparedByEmployeeID;
        private Int32? _PreparedByEmployeeSalaryLevel;
        private Int64? _TemplateID;
        private DateTime? _SeenNotice;
        private Int64? _ViewCount;


        [DataMember]
        public Int64 EmployeeNoticeID
        {
            get { return _EmployeeNoticeID; }
            set { _EmployeeNoticeID = value; }
        }

        [DataMember]
        public Int64 SendToEmployeeID
        {
            get { return _SendToEmployeeID; }
            set { _SendToEmployeeID = value; }
        }

        [DataMember]
        public String Memo
        {
            get { return _Memo; }
            set { _Memo = value; }
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
        public DateTime NoticeDate
        {
            get { return _NoticeDate; }
            set { _NoticeDate = value; }
        }

        [DataMember]
        public Int64 PreparedByEmployeeID
        {
            get { return _PreparedByEmployeeID; }
            set { _PreparedByEmployeeID = value; }
        }

        [DataMember]
        public Int32? PreparedByEmployeeSalaryLevel
        {
            get { return _PreparedByEmployeeSalaryLevel; }
            set { _PreparedByEmployeeSalaryLevel = value; }
        }

        [DataMember]
        public Int64? TemplateID
        {
            get { return _TemplateID; }
            set { _TemplateID = value; }
        }

        [DataMember]
        public DateTime? SeenNotice
        {
            get { return _SeenNotice; }
            set { _SeenNotice = value; }
        }

        [DataMember]
        public Int64? ViewCount
        {
            get { return _ViewCount; }
            set { _ViewCount = value; }
        }

        [XmlIgnore()]
        public override bool IsNew
        {
            [DebuggerStepThrough()]
            get
            {
                return (EmployeeNoticeID <= 0);
            }
        }


        #endregion

        #region Constructor

        public HREmployeeNoticeEntity() : base()
        {
        }

        #endregion

        #region Constant

        public const String FLD_NAME_EmployeeNoticeID = "EmployeeNoticeID";
        public const String FLD_NAME_SendToEmployeeID = "SendToEmployeeID";
        public const String FLD_NAME_SendToEmployeeSalaryLevel = "Memo";
        public const String FLD_NAME_Text = "Text";
        public const String FLD_NAME_Remarks = "Remarks";
        public const String FLD_NAME_NoticeDate = "NoticeDate";
        public const String FLD_NAME_PreparedByEmployeeID = "PreparedByEmployeeID";
        public const String FLD_NAME_PreparedByEmployeeSalaryLevel = "PreparedByEmployeeSalaryLevel";
        public const String FLD_NAME_TemplateID = "TemplateID";
        public const String FLD_NAME_SeenNotice = "SeenNotice";
        public const String FLD_NAME_ViewCount = "ViewCount";

        #endregion
    }
}
