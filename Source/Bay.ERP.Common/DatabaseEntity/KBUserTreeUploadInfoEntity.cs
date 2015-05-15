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
    [DataContract(Name = "KBUserTreeUploadInfo", Namespace = "http://www.e-p-m-s.com/types")]
    public partial class KBUserTreeUploadInfoEntity : BaseEntity
    {
        #region Properties


        private Int64 _UserTreeUploadInfoID;
        private Int64 _UserTreeID;
        private String _Extension;
        private String _Remarks;
        private String _Path;
        private String _OriginalFileName;
        private String _CurrentFileName;
        private String _FileType;


        [DataMember]
        public Int64 UserTreeUploadInfoID
        {
            get { return _UserTreeUploadInfoID; }
            set { _UserTreeUploadInfoID = value; }
        }

        [DataMember]
        public Int64 UserTreeID
        {
            get { return _UserTreeID; }
            set { _UserTreeID = value; }
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

        [XmlIgnore()]
        public override bool IsNew
        {
            [DebuggerStepThrough()]
            get
            {
                return (UserTreeUploadInfoID <= 0);
            }
        }


        #endregion

        #region Constructor

        public KBUserTreeUploadInfoEntity() : base()
        {
        }

        #endregion

        #region Constant

        public const String FLD_NAME_UserTreeUploadInfoID = "UserTreeUploadInfoID";
        public const String FLD_NAME_UserTreeID = "UserTreeID";
        public const String FLD_NAME_Extension = "Extension";
        public const String FLD_NAME_Remarks = "Remarks";
        public const String FLD_NAME_Path = "Path";
        public const String FLD_NAME_OriginalFileName = "OriginalFileName";
        public const String FLD_NAME_CurrentFileName = "CurrentFileName";
        public const String FLD_NAME_FileType = "FileType";

        #endregion
    }
}
