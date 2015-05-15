// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 10-Sep-2012, 10:20:04




using System;
using System.Diagnostics;
using System.ServiceModel;
using System.Runtime.Serialization;
using System.Collections.Generic;
using System.Xml.Serialization;


namespace Bay.ERP.Common.BusinessEntities
{
    [Serializable]
    [DataContract(Name = "DMSDocumentNode", Namespace = "http://www.e-p-m-s.com/types")]
    public partial class DMSDocumentNodeEntity : BaseEntity
    {
        #region Properties


        private Int64 _DocumentNodeID;
        private Int64? _ParentDocumentNodeID;
        private Boolean _IsDocumentNodeType;
        private String _Name;
        private Int64 _DocumentStorageTypeID;
        private Int64 _ReferenceID;
        private String _Extension;
        private String _Remarks;
        private String _Path;
        private String _OriginalFileName;
        private String _CurrentFileName;
        private String _FileType;
        private String _TagKeyword;
        private Boolean _IsStarred;
        private Boolean _IsArchived;
        private Boolean _IsRemoved;
        private Int64? _UploadedByMemberID;
        private Int64 _OwnerTypeID;
        private Int64? _OwnerReferenceID;
        private Decimal? _QuotaUsed;
        private DateTime? _LastModifiedDate;


        [DataMember]
        public Int64 DocumentNodeID
        {
            get { return _DocumentNodeID; }
            set { _DocumentNodeID = value; }
        }

        [DataMember]
        public Int64? ParentDocumentNodeID
        {
            get { return _ParentDocumentNodeID; }
            set { _ParentDocumentNodeID = value; }
        }

        [DataMember]
        public Boolean IsDocumentNodeType
        {
            get { return _IsDocumentNodeType; }
            set { _IsDocumentNodeType = value; }
        }

        [DataMember]
        public String Name
        {
            get { return _Name; }
            set { _Name = value; }
        }

        [DataMember]
        public Int64 DocumentStorageTypeID
        {
            get { return _DocumentStorageTypeID; }
            set { _DocumentStorageTypeID = value; }
        }

        [DataMember]
        public Int64 ReferenceID
        {
            get { return _ReferenceID; }
            set { _ReferenceID = value; }
        }

        [DataMember]
        public String Extension
        {
            get { return _Extension; }
            set { _Extension = value; }
        }

        [DataMember]
        public String Remarks
        {
            get { return _Remarks; }
            set { _Remarks = value; }
        }

        [DataMember]
        public String Path
        {
            get { return _Path; }
            set { _Path = value; }
        }

        [DataMember]
        public String OriginalFileName
        {
            get { return _OriginalFileName; }
            set { _OriginalFileName = value; }
        }

        [DataMember]
        public String CurrentFileName
        {
            get { return _CurrentFileName; }
            set { _CurrentFileName = value; }
        }

        [DataMember]
        public String FileType
        {
            get { return _FileType; }
            set { _FileType = value; }
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
        public Boolean IsArchived
        {
            get { return _IsArchived; }
            set { _IsArchived = value; }
        }

        [DataMember]
        public Boolean IsRemoved
        {
            get { return _IsRemoved; }
            set { _IsRemoved = value; }
        }

        [DataMember]
        public Int64? UploadedByMemberID
        {
            get { return _UploadedByMemberID; }
            set { _UploadedByMemberID = value; }
        }

        [DataMember]
        public Int64 OwnerTypeID
        {
            get { return _OwnerTypeID; }
            set { _OwnerTypeID = value; }
        }

        [DataMember]
        public Int64? OwnerReferenceID
        {
            get { return _OwnerReferenceID; }
            set { _OwnerReferenceID = value; }
        }

        [DataMember]
        public Decimal? QuotaUsed
        {
            get { return _QuotaUsed; }
            set { _QuotaUsed = value; }
        }

        [DataMember]
        public DateTime? LastModifiedDate
        {
            get { return _LastModifiedDate; }
            set { _LastModifiedDate = value; }
        }

        [XmlIgnore()]
        public override bool IsNew
        {
            [DebuggerStepThrough()]
            get
            {
                return (DocumentNodeID <= 0);
            }
        }


        #endregion

        #region Constructor

        public DMSDocumentNodeEntity() : base()
        {
        }

        #endregion

        #region Constant

        public const String FLD_NAME_DocumentNodeID = "DocumentNodeID";
        public const String FLD_NAME_ParentDocumentNodeID = "ParentDocumentNodeID";
        public const String FLD_NAME_IsDocumentNodeType = "IsDocumentNodeType";
        public const String FLD_NAME_Name = "Name";
        public const String FLD_NAME_DocumentStorageTypeID = "DocumentStorageTypeID";
        public const String FLD_NAME_ReferenceID = "ReferenceID";
        public const String FLD_NAME_Extension = "Extension";
        public const String FLD_NAME_Remarks = "Remarks";
        public const String FLD_NAME_Path = "Path";
        public const String FLD_NAME_OriginalFileName = "OriginalFileName";
        public const String FLD_NAME_CurrentFileName = "CurrentFileName";
        public const String FLD_NAME_FileType = "FileType";
        public const String FLD_NAME_TagKeyword = "TagKeyword";
        public const String FLD_NAME_IsStarred = "IsStarred";
        public const String FLD_NAME_IsArchived = "IsArchived";
        public const String FLD_NAME_IsRemoved = "IsRemoved";
        public const String FLD_NAME_UploadedByMemberID = "UploadedByMemberID";
        public const String FLD_NAME_OwnerTypeID = "OwnerTypeID";
        public const String FLD_NAME_OwnerReferenceID = "OwnerReferenceID";
        public const String FLD_NAME_QuotaUsed = "QuotaUsed";
        public const String FLD_NAME_LastModifiedDate = "LastModifiedDate";

        #endregion
    }
}
