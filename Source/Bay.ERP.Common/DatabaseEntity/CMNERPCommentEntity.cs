// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 23-Mar-2013, 04:14:01




using System;
using System.Diagnostics;
using System.ServiceModel;
using System.Runtime.Serialization;
using System.Collections.Generic;
using System.Xml.Serialization;


namespace Bay.ERP.Common.BusinessEntities
{
    [Serializable]
    [DataContract(Name = "CMNERPComment", Namespace = "http://www.e-p-m-s.com/types")]
    public partial class CMNERPCommentEntity : BaseEntity
    {
        #region Properties


        private Int64 _CommentID;
        private Int64 _ProcessCategoryID;
        private Int64 _ReferenceID;
        private String _Comment;
        private DateTime _CommentDate;
        private Int64 _EmployeeID;
        private String _IP;


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

        public CMNERPCommentEntity() : base()
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

        #endregion
    }
}
