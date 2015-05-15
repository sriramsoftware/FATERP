// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 25-Mar-2013, 04:19:38




using System;
using System.Diagnostics;
using System.ServiceModel;
using System.Runtime.Serialization;
using System.Collections.Generic;
using System.Xml.Serialization;


namespace Bay.ERP.Common.BusinessEntities
{
    [Serializable]
    [DataContract(Name = "CMNERPComment_Detailed", Namespace = "http://www.e-p-m-s.com/types")]
    public partial class CMNERPComment_DetailedEntity : BaseEntity
    {
        #region Properties


        private Int64 _CommentID;
        private Int64 _ProcessCategoryID;
        private Int64 _ReferenceID;
        private String _Comment;
        private DateTime _CommentDate;
        private Int64 _EmployeeID;
        private String _IP;
        private String _CMNProcessCategoryName;
        private Int64? _HREmployeeMemberID;
        private String _MemberFullName;
        private Int64? _RowNumber;


        [DataMember]
        public Int64 CommentID
        {
            get { return _CommentID; }
            set { _CommentID = value; }
        }

        [DataMember]
        public Int64 ProcessCategoryID
        {
            get { return _ProcessCategoryID; }
            set { _ProcessCategoryID = value; }
        }

        [DataMember]
        public Int64 ReferenceID
        {
            get { return _ReferenceID; }
            set { _ReferenceID = value; }
        }

        [DataMember]
        public String Comment
        {
            get { return _Comment; }
            set { _Comment = value; }
        }

        [DataMember]
        public DateTime CommentDate
        {
            get { return _CommentDate; }
            set { _CommentDate = value; }
        }

        [DataMember]
        public Int64 EmployeeID
        {
            get { return _EmployeeID; }
            set { _EmployeeID = value; }
        }

        [DataMember]
        public String IP
        {
            get { return _IP; }
            set { _IP = value; }
        }

        [DataMember]
        public String CMNProcessCategoryName
        {
            get { return _CMNProcessCategoryName; }
            set { _CMNProcessCategoryName = value; }
        }

        [DataMember]
        public Int64? HREmployeeMemberID
        {
            get { return _HREmployeeMemberID; }
            set { _HREmployeeMemberID = value; }
        }

        [DataMember]
        public String MemberFullName
        {
            get { return _MemberFullName; }
            set { _MemberFullName = value; }
        }

        [DataMember]
        public Int64? RowNumber
        {
            get { return _RowNumber; }
            set { _RowNumber = value; }
        }

        [XmlIgnore()]
        public override bool IsNew
        {
            [DebuggerStepThrough()]
            get
            {
                return (CommentID <= 0);
            }
        }


        #endregion

        #region Constructor

        public CMNERPComment_DetailedEntity() : base()
        {
        }

        #endregion

        #region Constant

        public const String FLD_NAME_CommentID = "CommentID";
        public const String FLD_NAME_ProcessCategoryID = "ProcessCategoryID";
        public const String FLD_NAME_ReferenceID = "ReferenceID";
        public const String FLD_NAME_Comment = "Comment";
        public const String FLD_NAME_CommentDate = "CommentDate";
        public const String FLD_NAME_EmployeeID = "EmployeeID";
        public const String FLD_NAME_IP = "IP";
        public const String FLD_NAME_CMNProcessCategoryName = "CMNProcessCategoryName";
        public const String FLD_NAME_HREmployeeMemberID = "HREmployeeMemberID";
        public const String FLD_NAME_MemberFullName = "MemberFullName";
        public const String FLD_NAME_RowNumber = "RowNumber";

        #endregion
    }
}
