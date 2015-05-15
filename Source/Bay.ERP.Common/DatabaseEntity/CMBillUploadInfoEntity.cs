// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 05-Oct-2012, 11:26:30




using System;
using System.Diagnostics;
using System.ServiceModel;
using System.Runtime.Serialization;
using System.Collections.Generic;
using System.Xml.Serialization;


namespace Bay.ERP.Common.BusinessEntities
{
    [Serializable]
    [DataContract(Name = "CMBillUploadInfo", Namespace = "http://www.e-p-m-s.com/types")]
    public partial class CMBillUploadInfoEntity : BaseEntity
    {
        #region Properties


        private Int64 _BillUploadInfoID;
        private Int64 _BillID;
        private String _Extension;
        private String _Remarks;
        private String _Path;
        private String _OriginalFileName;
        private String _CurrentFileName;
        private String _FileType;


        [DataMember]
        public Int64 BillUploadInfoID
        {
            get { return _BillUploadInfoID; }
            set { _BillUploadInfoID = value; }
        }

        [DataMember]
        public Int64 BillID
        {
            get { return _BillID; }
            set { _BillID = value; }
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
                return (BillUploadInfoID <= 0);
            }
        }


        #endregion

        #region Constructor

        public CMBillUploadInfoEntity() : base()
        {
        }

        #endregion

        #region Constant

        public const String FLD_NAME_BillUploadInfoID = "BillUploadInfoID";
        public const String FLD_NAME_BillID = "BillID";
        public const String FLD_NAME_Extension = "Extension";
        public const String FLD_NAME_Remarks = "Remarks";
        public const String FLD_NAME_Path = "Path";
        public const String FLD_NAME_OriginalFileName = "OriginalFileName";
        public const String FLD_NAME_CurrentFileName = "CurrentFileName";
        public const String FLD_NAME_FileType = "FileType";

        #endregion
    }
}
