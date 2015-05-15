// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 06-Oct-2013, 05:27:25




using System;
using System.Diagnostics;
using System.ServiceModel;
using System.Runtime.Serialization;
using System.Collections.Generic;
using System.Xml.Serialization;


namespace Bay.ERP.Common.BusinessEntities
{
    [Serializable]
    [DataContract(Name = "CMNEventUploadInfo", Namespace = "http://www.e-p-m-s.com/types")]
    public partial class CMNEventUploadInfoEntity : BaseEntity
    {
        #region Properties


        private Int64 _EventUploadInfoID;
        private Int64 _EventID;
        private String _Extension;
        private String _Remarks;
        private String _Path;
        private String _OriginalFileName;
        private String _CurrentFileName;
        private String _FileType;
        private Int64 _UploadedByMemberID;
        private DateTime _UploadedDateTime;


        [DataMember]
        public Int64 EventUploadInfoID
        {
            get { return _EventUploadInfoID; }
            set { _EventUploadInfoID = value; }
        }

        [DataMember]
        public Int64 EventID
        {
            get { return _EventID; }
            set { _EventID = value; }
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
        public Int64 UploadedByMemberID
        {
            get { return _UploadedByMemberID; }
            set { _UploadedByMemberID = value; }
        }

        [DataMember]
        public DateTime UploadedDateTime
        {
            get { return _UploadedDateTime; }
            set { _UploadedDateTime = value; }
        }

        [XmlIgnore()]
        public override bool IsNew
        {
            [DebuggerStepThrough()]
            get
            {
                return (EventUploadInfoID <= 0);
            }
        }


        #endregion

        #region Constructor

        public CMNEventUploadInfoEntity() : base()
        {
        }

        #endregion

        #region Constant

        public const String FLD_NAME_EventUploadInfoID = "EventUploadInfoID";
        public const String FLD_NAME_EventID = "EventID";
        public const String FLD_NAME_Extension = "Extension";
        public const String FLD_NAME_Remarks = "Remarks";
        public const String FLD_NAME_Path = "Path";
        public const String FLD_NAME_OriginalFileName = "OriginalFileName";
        public const String FLD_NAME_CurrentFileName = "CurrentFileName";
        public const String FLD_NAME_FileType = "FileType";
        public const String FLD_NAME_UploadedByMemberID = "UploadedByMemberID";
        public const String FLD_NAME_UploadedDateTime = "UploadedDateTime";

        #endregion
    }
}
