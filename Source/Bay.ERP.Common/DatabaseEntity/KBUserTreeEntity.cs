// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 28-Mar-2013, 04:24:50




using System;
using System.Diagnostics;
using System.ServiceModel;
using System.Runtime.Serialization;
using System.Collections.Generic;
using System.Xml.Serialization;


namespace Bay.ERP.Common.BusinessEntities
{
    [Serializable]
    [DataContract(Name = "KBUserTree", Namespace = "http://www.e-p-m-s.com/types")]
    public partial class KBUserTreeEntity : BaseEntity
    {
        #region Properties


        private Int64 _UserTreeID;
        private Int64? _ParentUserTreeID;
        private Boolean _IsDocumentNodeType;
        private String _Title;
        private String _Description;
        private Int64? _ReferenceID;
        private String _TagKeyword;
        private Boolean _IsStarred;
        private Int64? _CreatedByEmployeeID;
        private DateTime? _CreateDate;
        private Int64? _OwnerEmployeeID;
        private Decimal? _DocumentSize;
        private DateTime? _LastModifiedDate;
        private String _IP;
        private Int64 _UserTreeStatusID;
        private Boolean _IsRemoved;
        private Int64 _CountViewState;


        [DataMember]
        public Int64 UserTreeID
        {
            get { return _UserTreeID; }
            set { _UserTreeID = value; }
        }

        [DataMember]
        public Int64? ParentUserTreeID
        {
            get { return _ParentUserTreeID; }
            set { _ParentUserTreeID = value; }
        }

        [DataMember]
        public Boolean IsDocumentNodeType
        {
            get { return _IsDocumentNodeType; }
            set { _IsDocumentNodeType = value; }
        }

        [DataMember]
        public String Title
        {
            get { return _Title; }
            set { _Title = value; }
        }

        [DataMember]
        public String Description
        {
            get { return _Description; }
            set { _Description = value; }
        }

        [DataMember]
        public Int64? ReferenceID
        {
            get { return _ReferenceID; }
            set { _ReferenceID = value; }
        }

        [DataMember]
        public String TagKeyword
        {
            get { return _TagKeyword; }
            set { _TagKeyword = value; }
        }

        [DataMember]
        public Boolean IsStarred
        {
            get { return _IsStarred; }
            set { _IsStarred = value; }
        }

        [DataMember]
        public Int64? CreatedByEmployeeID
        {
            get { return _CreatedByEmployeeID; }
            set { _CreatedByEmployeeID = value; }
        }

        [DataMember]
        public DateTime? CreateDate
        {
            get { return _CreateDate; }
            set { _CreateDate = value; }
        }

        [DataMember]
        public Int64? OwnerEmployeeID
        {
            get { return _OwnerEmployeeID; }
            set { _OwnerEmployeeID = value; }
        }

        [DataMember]
        public Decimal? DocumentSize
        {
            get { return _DocumentSize; }
            set { _DocumentSize = value; }
        }

        [DataMember]
        public DateTime? LastModifiedDate
        {
            get { return _LastModifiedDate; }
            set { _LastModifiedDate = value; }
        }

        [DataMember]
        public String IP
        {
            get { return _IP; }
            set { _IP = value; }
        }

        [DataMember]
        public Int64 UserTreeStatusID
        {
            get { return _UserTreeStatusID; }
            set { _UserTreeStatusID = value; }
        }

        [DataMember]
        public Boolean IsRemoved
        {
            get { return _IsRemoved; }
            set { _IsRemoved = value; }
        }

        [DataMember]
        public Int64 CountViewState
        {
            get { return _CountViewState; }
            set { _CountViewState = value; }
        }

        [XmlIgnore()]
        public override bool IsNew
        {
            [DebuggerStepThrough()]
            get
            {
                return (UserTreeID <= 0);
            }
        }


        #endregion

        #region Constructor

        public KBUserTreeEntity() : base()
        {
        }

        #endregion

        #region Constant

        public const String FLD_NAME_UserTreeID = "UserTreeID";
        public const String FLD_NAME_ParentUserTreeID = "ParentUserTreeID";
        public const String FLD_NAME_IsDocumentNodeType = "IsDocumentNodeType";
        public const String FLD_NAME_Title = "Title";
        public const String FLD_NAME_Description = "Description";
        public const String FLD_NAME_ReferenceID = "ReferenceID";
        public const String FLD_NAME_TagKeyword = "TagKeyword";
        public const String FLD_NAME_IsStarred = "IsStarred";
        public const String FLD_NAME_CreatedByEmployeeID = "CreatedByEmployeeID";
        public const String FLD_NAME_CreateDate = "CreateDate";
        public const String FLD_NAME_OwnerEmployeeID = "OwnerEmployeeID";
        public const String FLD_NAME_DocumentSize = "DocumentSize";
        public const String FLD_NAME_LastModifiedDate = "LastModifiedDate";
        public const String FLD_NAME_IP = "IP";
        public const String FLD_NAME_UserTreeStatusID = "UserTreeStatusID";
        public const String FLD_NAME_IsRemoved = "IsRemoved";
        public const String FLD_NAME_CountViewState = "CountViewState";

        #endregion
    }
}
