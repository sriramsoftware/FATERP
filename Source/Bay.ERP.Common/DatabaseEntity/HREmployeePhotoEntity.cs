// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 20-Dec-2013, 02:17:52




using System;
using System.Diagnostics;
using System.ServiceModel;
using System.Runtime.Serialization;
using System.Collections.Generic;
using System.Xml.Serialization;


namespace Bay.ERP.Common.BusinessEntities
{
    [Serializable]
    [DataContract(Name = "HREmployeePhoto", Namespace = "http://www.e-p-m-s.com/types")]
    public partial class HREmployeePhotoEntity : BaseEntity
    {
        #region Properties


        private Int64 _EmployeePhotoID;
        private Int64 _EmployeeID;
        private String _CurrentFileName;
        private String _Extension;
        private String _Remarks;
        private String _Path;
        private String _OriginalFileName;
        private String _FileType;
        private Boolean _IsCurrent;


        [DataMember]
        public Int64 EmployeePhotoID
        {
            get { return _EmployeePhotoID; }
            set { _EmployeePhotoID = value; }
        }

        [DataMember]
        public Int64 EmployeeID
        {
            get { return _EmployeeID; }
            set { _EmployeeID = value; }
        }

        [DataMember]
        public String CurrentFileName
        {
            get { return _CurrentFileName; }
            set { _CurrentFileName = value; }
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
        public String FileType
        {
            get { return _FileType; }
            set { _FileType = value; }
        }

        [DataMember]
        public Boolean IsCurrent
        {
            get { return _IsCurrent; }
            set { _IsCurrent = value; }
        }

        [XmlIgnore()]
        public override bool IsNew
        {
            [DebuggerStepThrough()]
            get
            {
                return (EmployeePhotoID <= 0);
            }
        }


        #endregion

        #region Constructor

        public HREmployeePhotoEntity() : base()
        {
        }

        #endregion

        #region Constant

        public const String FLD_NAME_EmployeePhotoID = "EmployeePhotoID";
        public const String FLD_NAME_EmployeeID = "EmployeeID";
        public const String FLD_NAME_CurrentFileName = "CurrentFileName";
        public const String FLD_NAME_Extension = "Extension";
        public const String FLD_NAME_Remarks = "Remarks";
        public const String FLD_NAME_Path = "Path";
        public const String FLD_NAME_OriginalFileName = "OriginalFileName";
        public const String FLD_NAME_FileType = "FileType";
        public const String FLD_NAME_IsCurrent = "IsCurrent";

        #endregion
    }
}
