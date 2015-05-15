// Copyright and All Rights Reserved by
//B2B Solution, Bangladesh;
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 28-Dec-2011, 07:18:54




using System;
using System.Diagnostics;
using System.ServiceModel;
using System.Runtime.Serialization;
using System.Collections.Generic;
using System.Xml.Serialization;


namespace Bay.ERP.Common.BusinessEntities
{
    [Serializable]
    [DataContract(Name = "OTIssueUploadInfo", Namespace = "http://www.e-p-m-s.com/types")]
    public partial class OTIssueUploadInfoEntity : BaseEntity
    {
        #region Properties


        private Int64 _IssueUploadInfoID;
        private Int64 _IssueID;
        private String _Remarks;
        private String _Path;
        private String _OriginalFileName;
        private String _CurrentFileName;
        private String _FileType;
        private String _Extension;


        [DataMember]
        public Int64 IssueUploadInfoID
        {
            get { return _IssueUploadInfoID; }
            set { _IssueUploadInfoID = value; }
        }

        [DataMember]
        public Int64 IssueID
        {
            get { return _IssueID; }
            set { _IssueID = value; }
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
        public String Extension
        {
            get { return _Extension; }
            set { _Extension = value; }
        }

        [XmlIgnore()]
        public override bool IsNew
        {
            [DebuggerStepThrough()]
            get
            {
                return (IssueUploadInfoID <= 0);
            }
        }


        #endregion

        #region Constructor

        public OTIssueUploadInfoEntity() : base()
        {
        }

        #endregion

        #region Constant

        public const String FLD_NAME_IssueUploadInfoID = "IssueUploadInfoID";
        public const String FLD_NAME_IssueID = "IssueID";
        public const String FLD_NAME_Remarks = "Remarks";
        public const String FLD_NAME_Path = "Path";
        public const String FLD_NAME_OriginalFileName = "OriginalFileName";
        public const String FLD_NAME_CurrentFileName = "CurrentFileName";
        public const String FLD_NAME_FileType = "FileType";
        public const String FLD_NAME_Extension = "Extension";

        #endregion
    }
}
