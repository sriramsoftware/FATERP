// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 22-May-2013, 11:39:55




using System;
using System.Diagnostics;
using System.ServiceModel;
using System.Runtime.Serialization;
using System.Collections.Generic;
using System.Xml.Serialization;


namespace Bay.ERP.Common.BusinessEntities
{
    [Serializable]
    [DataContract(Name = "OTIssue_Custom", Namespace = "http://www.e-p-m-s.com/types")]
    public partial class OTIssue_CustomEntity : BaseEntity
    {
        #region Properties


        private Int64 _IssueID;
        private String _Title;
        private Int64? _ResourceCategoryID;
        private Int64? _ReferenceID;
        private String _EmployeeFullName;
        private String _Specification;
        private Int64? _RowNumber;


        [DataMember]
        public Int64 IssueID
        {
            get { return _IssueID; }
            set { _IssueID = value; }
        }

        [DataMember]
        public String Title
        {
            get { return _Title; }
            set { _Title = value; }
        }

        [DataMember]
        public Int64?ResourceCategoryID
        {
            get { return _ResourceCategoryID; }
            set { _ResourceCategoryID = value; }
        }

        [DataMember]
        public Int64? ReferenceID
        {
            get { return _ReferenceID; }
            set { _ReferenceID = value; }
        }

        [DataMember]
        public String EmployeeFullName
        {
            get { return _EmployeeFullName; }
            set { _EmployeeFullName = value; }
        }

        [DataMember]
        public String Specification
        {
            get { return _Specification; }
            set { _Specification = value; }
        }

        [DataMember]
        public Int64? RowNumber
        {
            get { return _RowNumber; }
            set { _RowNumber = value; }
        }

        #endregion

        #region Constructor

        public OTIssue_CustomEntity() : base()
        {
        }

        #endregion

        #region Constant

        public const String FLD_NAME_IssueID = "IssueID";
        public const String FLD_NAME_Title = "Title";
        public const String FLD_NAME_ResourceCategoryID = "ResourceCategoryID";
        public const String FLD_NAME_ReferenceID = "ReferenceID";
        public const String FLD_NAME_EmployeeFullName = "EmployeeFullName";
        public const String FLD_NAME_Specification = "Specification";
        public const String FLD_NAME_RowNumber = "RowNumber";

        #endregion
    }
}
