// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 30-Sep-2012, 10:36:26




using System;
using System.Diagnostics;
using System.ServiceModel;
using System.Runtime.Serialization;
using System.Collections.Generic;
using System.Xml.Serialization;


namespace Bay.ERP.Common.BusinessEntities
{
    [Serializable]
    [DataContract(Name = "DMSReferenceLibrary_Detailed", Namespace = "http://www.e-p-m-s.com/types")]
    public partial class DMSReferenceLibrary_DetailedEntity : BaseEntity
    {
        #region Properties


        private Int64 _ReferenceLibraryID;
        private Int64 _ReferenceLibraryCategoryID;
        private String _Url;
        private String _Description;
        private String _FileName;
        private Int64 _CreatedByEmployeeID;
        private Int64? _ReferencedByEmployeeID;
        private String _Extension;
        private String _Remarks;
        private String _Path;
        private String _OriginalFileName;
        private String _CurrentFileName;
        private String _FileType;
        private String _ReferenceLibraryCategoryName;
        private String _CreatedByFullName;
        private String _ReferencedByFullName;
        private Int64? _RowNumber;


        [DataMember]
        public Int64 ReferenceLibraryID
        {
            get { return _ReferenceLibraryID; }
            set { _ReferenceLibraryID = value; }
        }

        [DataMember]
        public Int64 ReferenceLibraryCategoryID
        {
            get { return _ReferenceLibraryCategoryID; }
            set { _ReferenceLibraryCategoryID = value; }
        }

        [DataMember]
        public String Url
        {
            get { return _Url; }
            set { _Url = value; }
        }

        [DataMember]
        public String Description
        {
            get { return _Description; }
            set { _Description = value; }
        }

        [DataMember]
        public String FileName
        {
            get { return _FileName; }
            set { _FileName = value; }
        }

        [DataMember]
        public Int64 CreatedByEmployeeID
        {
            get { return _CreatedByEmployeeID; }
            set { _CreatedByEmployeeID = value; }
        }

        [DataMember]
        public Int64? ReferencedByEmployeeID
        {
            get { return _ReferencedByEmployeeID; }
            set { _ReferencedByEmployeeID = value; }
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
        public String ReferenceLibraryCategoryName
        {
            get { return _ReferenceLibraryCategoryName; }
            set { _ReferenceLibraryCategoryName = value; }
        }

        [DataMember]
        public String CreatedByFullName
        {
            get { return _CreatedByFullName; }
            set { _CreatedByFullName = value; }
        }

        [DataMember]
        public String ReferencedByFullName
        {
            get { return _ReferencedByFullName; }
            set { _ReferencedByFullName = value; }
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
                return (ReferenceLibraryID <= 0);
            }
        }


        #endregion

        #region Constructor

        public DMSReferenceLibrary_DetailedEntity() : base()
        {
        }

        #endregion

        #region Constant

        public const String FLD_NAME_ReferenceLibraryID = "ReferenceLibraryID";
        public const String FLD_NAME_ReferenceLibraryCategoryID = "ReferenceLibraryCategoryID";
        public const String FLD_NAME_Url = "Url";
        public const String FLD_NAME_Description = "Description";
        public const String FLD_NAME_FileName = "FileName";
        public const String FLD_NAME_CreatedByEmployeeID = "CreatedByEmployeeID";
        public const String FLD_NAME_ReferencedByEmployeeID = "ReferencedByEmployeeID";
        public const String FLD_NAME_Extension = "Extension";
        public const String FLD_NAME_Remarks = "Remarks";
        public const String FLD_NAME_Path = "Path";
        public const String FLD_NAME_OriginalFileName = "OriginalFileName";
        public const String FLD_NAME_CurrentFileName = "CurrentFileName";
        public const String FLD_NAME_FileType = "FileType";
        public const String FLD_NAME_ReferenceLibraryCategoryName = "ReferenceLibraryCategoryName";
        public const String FLD_NAME_CreatedByFullName = "CreatedByFullName";
        public const String FLD_NAME_ReferencedByFullName = "ReferencedByFullName";
        public const String FLD_NAME_RowNumber = "RowNumber";

        #endregion
    }
}
