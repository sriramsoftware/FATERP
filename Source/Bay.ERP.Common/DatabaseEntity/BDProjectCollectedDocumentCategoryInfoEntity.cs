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
    [DataContract(Name = "BDProjectCollectedDocumentCategoryInfo", Namespace = "http://www.e-p-m-s.com/types")]
    public partial class BDProjectCollectedDocumentCategoryInfoEntity : BaseEntity
    {
        #region Properties


        private Int64 _ProjectCollectedDocumentCategoryInfoID;
        private Int64 _ProjectID;
        private Int64 _ProjectDocumentCategoryID;
        private DateTime? _StartDate;
        private Int32? _RequiredTime;
        private Int32? _Reminder;
        private Int64? _ProjectCollectedDocumentStatusID;
        private String _Remarks;


        [DataMember]
        public Int64 ProjectCollectedDocumentCategoryInfoID
        {
            get { return _ProjectCollectedDocumentCategoryInfoID; }
            set { _ProjectCollectedDocumentCategoryInfoID = value; }
        }

        [DataMember]
        public Int64 ProjectID
        {
            get { return _ProjectID; }
            set { _ProjectID = value; }
        }

        [DataMember]
        public Int64 ProjectDocumentCategoryID
        {
            get { return _ProjectDocumentCategoryID; }
            set { _ProjectDocumentCategoryID = value; }
        }

        [DataMember]
        public DateTime? StartDate
        {
            get { return _StartDate; }
            set { _StartDate = value; }
        }

        [DataMember]
        public Int32? RequiredTime
        {
            get { return _RequiredTime; }
            set { _RequiredTime = value; }
        }

        [DataMember]
        public Int32? Reminder
        {
            get { return _Reminder; }
            set { _Reminder = value; }
        }

        [DataMember]
        public Int64? ProjectCollectedDocumentStatusID
        {
            get { return _ProjectCollectedDocumentStatusID; }
            set { _ProjectCollectedDocumentStatusID = value; }
        }

        [DataMember]
        public String Remarks
        {
            get { return _Remarks; }
            set { _Remarks = value; }
        }

        [XmlIgnore()]
        public override bool IsNew
        {
            [DebuggerStepThrough()]
            get
            {
                return (ProjectCollectedDocumentCategoryInfoID <= 0);
            }
        }


        #endregion

        #region Constructor

        public BDProjectCollectedDocumentCategoryInfoEntity() : base()
        {
        }

        #endregion

        #region Constant

        public const String FLD_NAME_ProjectCollectedDocumentCategoryInfoID = "ProjectCollectedDocumentCategoryInfoID";
        public const String FLD_NAME_ProjectID = "ProjectID";
        public const String FLD_NAME_ProjectDocumentCategoryID = "ProjectDocumentCategoryID";
        public const String FLD_NAME_StartDate = "StartDate";
        public const String FLD_NAME_RequiredTime = "RequiredTime";
        public const String FLD_NAME_Reminder = "Reminder";
        public const String FLD_NAME_ProjectCollectedDocumentStatusID = "ProjectCollectedDocumentStatusID";
        public const String FLD_NAME_Remarks = "Remarks";

        #endregion
    }
}
