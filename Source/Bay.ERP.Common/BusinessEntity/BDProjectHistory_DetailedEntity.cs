// Copyright and All Rights Reserved by
//B2B Solution, Bangladesh;
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 03-May-2012, 03:03:39




using System;
using System.Diagnostics;
using System.ServiceModel;
using System.Runtime.Serialization;
using System.Collections.Generic;
using System.Xml.Serialization;


namespace Bay.ERP.Common.BusinessEntities
{
    [Serializable]
    [DataContract(Name = "BDProjectHistory_Detailed", Namespace = "http://www.e-p-m-s.com/types")]
    public partial class BDProjectHistory_DetailedEntity : BaseEntity
    {
        #region Properties


        private Int64 _ProjectHistoryID;
        private Int64 _ProjectID;
        private DateTime _HistoryDate;
        private String _Description;
        private String _Remarks;
        private DateTime _EntryDate;
        private Boolean _IsRemoved;
        private String _ProjectName;
        private Int64? _RowNumber;


        [DataMember]
        public Int64 ProjectHistoryID
        {
            get { return _ProjectHistoryID; }
            set { _ProjectHistoryID = value; }
        }

        [DataMember]
        public Int64 ProjectID
        {
            get { return _ProjectID; }
            set { _ProjectID = value; }
        }

        [DataMember]
        public DateTime HistoryDate
        {
            get { return _HistoryDate; }
            set { _HistoryDate = value; }
        }

        [DataMember]
        public String Description
        {
            get { return _Description; }
            set { _Description = value; }
        }

        [DataMember]
        public String Remarks
        {
            get { return _Remarks; }
            set { _Remarks = value; }
        }

        [DataMember]
        public DateTime EntryDate
        {
            get { return _EntryDate; }
            set { _EntryDate = value; }
        }

        [DataMember]
        public Boolean IsRemoved
        {
            get { return _IsRemoved; }
            set { _IsRemoved = value; }
        }

        [DataMember]
        public String ProjectName
        {
            get { return _ProjectName; }
            set { _ProjectName = value; }
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
                return (ProjectHistoryID <= 0);
            }
        }


        #endregion

        #region Constructor

        public BDProjectHistory_DetailedEntity() : base()
        {
        }

        #endregion

        #region Constant

        public const String FLD_NAME_ProjectHistoryID = "ProjectHistoryID";
        public const String FLD_NAME_ProjectID = "ProjectID";
        public const String FLD_NAME_HistoryDate = "HistoryDate";
        public const String FLD_NAME_Description = "Description";
        public const String FLD_NAME_Remarks = "Remarks";
        public const String FLD_NAME_EntryDate = "EntryDate";
        public const String FLD_NAME_IsRemoved = "IsRemoved";
        public const String FLD_NAME_ProjectName = "ProjectName";
        public const String FLD_NAME_RowNumber = "RowNumber";

        #endregion
    }
}
