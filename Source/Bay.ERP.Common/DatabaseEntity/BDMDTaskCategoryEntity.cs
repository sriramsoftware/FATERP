// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 26-May-2013, 02:32:38




using System;
using System.Diagnostics;
using System.ServiceModel;
using System.Runtime.Serialization;
using System.Collections.Generic;
using System.Xml.Serialization;


namespace Bay.ERP.Common.BusinessEntities
{
    [Serializable]
    [DataContract(Name = "BDMDTaskCategory", Namespace = "http://www.e-p-m-s.com/types")]
    public partial class BDMDTaskCategoryEntity : BaseEntity
    {
        #region Properties


        private Int64 _TaskCategoryID;
        private Int64? _ParentTaskCategoryID;
        private Int64? _DepartmentID;
        private String _Name;
        private Boolean _IsRemoved;


        [DataMember]
        public Int64 TaskCategoryID
        {
            get { return _TaskCategoryID; }
            set { _TaskCategoryID = value; }
        }

        [DataMember]
        public Int64? ParentTaskCategoryID
        {
            get { return _ParentTaskCategoryID; }
            set { _ParentTaskCategoryID = value; }
        }

        [DataMember]
        public Int64? DepartmentID
        {
            get { return _DepartmentID; }
            set { _DepartmentID = value; }
        }

        [DataMember]
        public String Name
        {
            get { return _Name; }
            set { _Name = value; }
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
                return (TaskCategoryID <= 0);
            }
        }


        #endregion

        #region Constructor

        public BDMDTaskCategoryEntity() : base()
        {
        }

        #endregion

        #region Constant

        public const String FLD_NAME_TaskCategoryID = "TaskCategoryID";
        public const String FLD_NAME_ParentTaskCategoryID = "ParentTaskCategoryID";
        public const String FLD_NAME_DepartmentID = "DepartmentID";
        public const String FLD_NAME_Name = "Name";
        public const String FLD_NAME_IsRemoved = "IsRemoved";

        #endregion
    }
}
