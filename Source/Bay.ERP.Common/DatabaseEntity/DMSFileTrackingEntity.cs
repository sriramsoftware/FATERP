// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 23-Sep-2012, 10:06:41




using System;
using System.Diagnostics;
using System.ServiceModel;
using System.Runtime.Serialization;
using System.Collections.Generic;
using System.Xml.Serialization;


namespace Bay.ERP.Common.BusinessEntities
{
    [Serializable]
    [DataContract(Name = "DMSFileTracking", Namespace = "http://www.e-p-m-s.com/types")]
    public partial class DMSFileTrackingEntity : BaseEntity
    {
        #region Properties


        private Int64 _FileTrackingID;
        private String _FileNo;
        private String _FileName;
        private Int64 _DepartmentID;
        private Int64 _CreatedByEmployeeID;
        private DateTime _CreatedDateTime;
        private String _FileParmanentPlace;
        private String _FileCurrentPlace;
        private String _FileType;
        private String _SoftFileName;
        private String _Extension;
        private String _Path;
        private String _OriginalFileName;
        private String _CurrentFileName;


        [DataMember]
        public Int64 FileTrackingID
        {
            get { return _FileTrackingID; }
            set { _FileTrackingID = value; }
        }

        [DataMember]
        public String FileNo
        {
            get { return _FileNo; }
            set { _FileNo = value; }
        }

        [DataMember]
        public String FileName
        {
            get { return _FileName; }
            set { _FileName = value; }
        }

        [DataMember]
        public Int64 DepartmentID
        {
            get { return _DepartmentID; }
            set { _DepartmentID = value; }
        }

        [DataMember]
        public Int64 CreatedByEmployeeID
        {
            get { return _CreatedByEmployeeID; }
            set { _CreatedByEmployeeID = value; }
        }

        [DataMember]
        public DateTime CreatedDateTime
        {
            get { return _CreatedDateTime; }
            set { _CreatedDateTime = value; }
        }

        [DataMember]
        public String FileParmanentPlace
        {
            get { return _FileParmanentPlace; }
            set { _FileParmanentPlace = value; }
        }

        [DataMember]
        public String FileCurrentPlace
        {
            get { return _FileCurrentPlace; }
            set { _FileCurrentPlace = value; }
        }

        [DataMember]
        public String FileType
        {
            get { return _FileType; }
            set { _FileType = value; }
        }

        [DataMember]
        public String SoftFileName
        {
            get { return _SoftFileName; }
            set { _SoftFileName = value; }
        }

        [DataMember]
        public String Extension
        {
            get { return _Extension; }
            set { _Extension = value; }
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

        [XmlIgnore()]
        public override bool IsNew
        {
            [DebuggerStepThrough()]
            get
            {
                return (FileTrackingID <= 0);
            }
        }


        #endregion

        #region Constructor

        public DMSFileTrackingEntity() : base()
        {
        }

        #endregion

        #region Constant

        public const String FLD_NAME_FileTrackingID = "FileTrackingID";
        public const String FLD_NAME_FileNo = "FileNo";
        public const String FLD_NAME_FileName = "FileName";
        public const String FLD_NAME_DepartmentID = "DepartmentID";
        public const String FLD_NAME_CreatedByEmployeeID = "CreatedByEmployeeID";
        public const String FLD_NAME_CreatedDateTime = "CreatedDateTime";
        public const String FLD_NAME_FileParmanentPlace = "FileParmanentPlace";
        public const String FLD_NAME_FileCurrentPlace = "FileCurrentPlace";
        public const String FLD_NAME_FileType = "FileType";
        public const String FLD_NAME_SoftFileName = "SoftFileName";
        public const String FLD_NAME_Extension = "Extension";
        public const String FLD_NAME_Path = "Path";
        public const String FLD_NAME_OriginalFileName = "OriginalFileName";
        public const String FLD_NAME_CurrentFileName = "CurrentFileName";

        #endregion
    }
}
