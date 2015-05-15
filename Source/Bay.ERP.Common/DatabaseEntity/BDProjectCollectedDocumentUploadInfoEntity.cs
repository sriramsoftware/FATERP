// Copyright and All Rights Reserved by
//B2B Solution, Bangladesh;
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 30-Nov-2011, 01:41:28




using System;
using System.Diagnostics;
using System.ServiceModel;
using System.Runtime.Serialization;
using System.Collections.Generic;
using System.Xml.Serialization;


namespace Bay.ERP.Common.BusinessEntities
{
    [Serializable]
    [DataContract(Name = "BDProjectCollectedDocumentUploadInfo", Namespace = "http://www.e-p-m-s.com/types")]
    public partial class BDProjectCollectedDocumentUploadInfoEntity : BaseEntity
    {
        #region Properties


        private Int64 _ProjectCollectedDocumentUploadInfoID;
        private Int64 _ProjectCollectedDocumentInfoID;
        private String _Remarks;
        private String _Path;
        private String _OriginalFileName;
        private String _CurrentFileName;
        private String _FileType;
        private String _Extension;


        [DataMember]
        public Int64 ProjectCollectedDocumentUploadInfoID
        {
            get { return _ProjectCollectedDocumentUploadInfoID; }
            set { _ProjectCollectedDocumentUploadInfoID = value; }
        }

        [DataMember]
        public Int64 ProjectCollectedDocumentInfoID
        {
            get { return _ProjectCollectedDocumentInfoID; }
            set { _ProjectCollectedDocumentInfoID = value; }
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
                return (ProjectCollectedDocumentUploadInfoID <= 0);
            }
        }


        #endregion

        #region Constructor

        public BDProjectCollectedDocumentUploadInfoEntity() : base()
        {
        }

        #endregion

        #region Constant

        public const String FLD_NAME_ProjectCollectedDocumentUploadInfoID = "ProjectCollectedDocumentUploadInfoID";
        public const String FLD_NAME_ProjectCollectedDocumentInfoID = "ProjectCollectedDocumentInfoID";
        public const String FLD_NAME_Remarks = "Remarks";
        public const String FLD_NAME_Path = "Path";
        public const String FLD_NAME_OriginalFileName = "OriginalFileName";
        public const String FLD_NAME_CurrentFileName = "CurrentFileName";
        public const String FLD_NAME_FileType = "FileType";
        public const String FLD_NAME_Extension = "Extension";

        #endregion
    }
}
