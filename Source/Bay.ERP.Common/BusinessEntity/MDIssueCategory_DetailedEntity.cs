// Copyright and All Rights Reserved by
//B2B Solution, Bangladesh;
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 31-Dec-2011, 05:48:38




using System;
using System.Diagnostics;
using System.ServiceModel;
using System.Runtime.Serialization;
using System.Collections.Generic;
using System.Xml.Serialization;


namespace Bay.ERP.Common.BusinessEntities
{
    [Serializable]
    [DataContract(Name = "MDIssueCategory_Detailed", Namespace = "http://www.e-p-m-s.com/types")]
    public partial class MDIssueCategory_DetailedEntity : BaseEntity
    {
        #region Properties


        private Int64 _IssueCategoryID;
        private Int64 _IssueIdentityCategoryID;
        private String _Name;
        private String _Description;
        private Boolean _IsRemoved;
        private String _IssueIdentityCategoryName;
        private Int64? _RowNumber;


        [DataMember]
        public Int64 IssueCategoryID
        {
            get { return _IssueCategoryID; }
            set { _IssueCategoryID = value; }
        }

        [DataMember]
        public Int64 IssueIdentityCategoryID
        {
            get { return _IssueIdentityCategoryID; }
            set { _IssueIdentityCategoryID = value; }
        }

        [DataMember]
        public String Name
        {
            get { return _Name; }
            set { _Name = value; }
        }

        [DataMember]
        public String Description
        {
            get { return _Description; }
            set { _Description = value; }
        }

        [DataMember]
        public Boolean IsRemoved
        {
            get { return _IsRemoved; }
            set { _IsRemoved = value; }
        }

        [DataMember]
        public String IssueIdentityCategoryName
        {
            get { return _IssueIdentityCategoryName; }
            set { _IssueIdentityCategoryName = value; }
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
                return (IssueCategoryID <= 0);
            }
        }


        #endregion

        #region Constructor

        public MDIssueCategory_DetailedEntity() : base()
        {
        }

        #endregion

        #region Constant

        public const String FLD_NAME_IssueCategoryID = "IssueCategoryID";
        public const String FLD_NAME_IssueIdentityCategoryID = "IssueIdentityCategoryID";
        public const String FLD_NAME_Name = "Name";
        public const String FLD_NAME_Description = "Description";
        public const String FLD_NAME_IsRemoved = "IsRemoved";
        public const String FLD_NAME_IssueIdentityCategoryName = "IssueIdentityCategoryName";
        public const String FLD_NAME_RowNumber = "RowNumber";

        #endregion
    }
}
