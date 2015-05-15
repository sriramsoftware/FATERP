// Copyright and All Rights Reserved by
//B2B Solution, Bangladesh;
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 07-Dec-2011, 11:00:45




using System;
using System.Diagnostics;
using System.ServiceModel;
using System.Runtime.Serialization;
using System.Collections.Generic;
using System.Xml.Serialization;


namespace Bay.ERP.Common.BusinessEntities
{
    [Serializable]
    [DataContract(Name = "MDProjectDocument", Namespace = "http://www.e-p-m-s.com/types")]
    public partial class MDProjectDocumentEntity : BaseEntity
    {
        #region Properties


        private Int64 _ProjectDocumentID;
        private Int64 _ProjectDocumentCategoryID;
        private String _Name;
        private Int32? _RequiredStandardTime;
        private Int32? _ReminderTime;
        private String _Remarks;
        private Boolean _IsRemoved;


        [DataMember]
        public Int64 ProjectDocumentID
        {
            get { return _ProjectDocumentID; }
            set { _ProjectDocumentID = value; }
        }

        [DataMember]
        public Int64 ProjectDocumentCategoryID
        {
            get { return _ProjectDocumentCategoryID; }
            set { _ProjectDocumentCategoryID = value; }
        }

        [DataMember]
        public String Name
        {
            get { return _Name; }
            set { _Name = value; }
        }

        [DataMember]
        public Int32? RequiredStandardTime
        {
            get { return _RequiredStandardTime; }
            set { _RequiredStandardTime = value; }
        }

        [DataMember]
        public Int32? ReminderTime
        {
            get { return _ReminderTime; }
            set { _ReminderTime = value; }
        }

        [DataMember]
        public String Remarks
        {
            get { return _Remarks; }
            set { _Remarks = value; }
        }

        [DataMember]
        public Boolean IsRemoved
        {
            get { return _IsRemoved; }
            set { _IsRemoved = value; }
        }

        [XmlIgnore()]
        public override bool IsNew
        {
            [DebuggerStepThrough()]
            get
            {
                return (ProjectDocumentID <= 0);
            }
        }


        #endregion

        #region Constructor

        public MDProjectDocumentEntity() : base()
        {
        }

        #endregion

        #region Constant

        public const String FLD_NAME_ProjectDocumentID = "ProjectDocumentID";
        public const String FLD_NAME_ProjectDocumentCategoryID = "ProjectDocumentCategoryID";
        public const String FLD_NAME_Name = "Name";
        public const String FLD_NAME_RequiredStandardTime = "RequiredStandardTime";
        public const String FLD_NAME_ReminderTime = "ReminderTime";
        public const String FLD_NAME_Remarks = "Remarks";
        public const String FLD_NAME_IsRemoved = "IsRemoved";

        #endregion
    }
}
