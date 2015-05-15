// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 19-Dec-2013, 12:42:28




using System;
using System.Diagnostics;
using System.ServiceModel;
using System.Runtime.Serialization;
using System.Collections.Generic;
using System.Xml.Serialization;


namespace Bay.ERP.Common.BusinessEntities
{
    [Serializable]
    [DataContract(Name = "MDDepartment", Namespace = "http://www.e-p-m-s.com/types")]
    public partial class MDDepartmentEntity : BaseEntity
    {
        #region Properties


        private Int64 _DepartmentID;
        private Int64? _ParentDepartmentID;
        private String _DepartmentCode;
        private String _Name;
        private String _Location;
        private Int64? _HODEmployeeID;
        private Boolean _IsRemoved;


        [DataMember]
        public Int64 DepartmentID
        {
            get { return _DepartmentID; }
            set { _DepartmentID = value; }
        }

        [DataMember]
        public Int64? ParentDepartmentID
        {
            get { return _ParentDepartmentID; }
            set { _ParentDepartmentID = value; }
        }

        [DataMember]
        public String DepartmentCode
        {
            get { return _DepartmentCode; }
            set { _DepartmentCode = value; }
        }

        [DataMember]
        public String Name
        {
            get { return _Name; }
            set { _Name = value; }
        }

        [DataMember]
        public String Location
        {
            get { return _Location; }
            set { _Location = value; }
        }

        [DataMember]
        public Int64? HODEmployeeID
        {
            get { return _HODEmployeeID; }
            set { _HODEmployeeID = value; }
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
                return (DepartmentID <= 0);
            }
        }


        #endregion

        #region Constructor

        public MDDepartmentEntity() : base()
        {
        }

        #endregion

        #region Constant

        public const String FLD_NAME_DepartmentID = "DepartmentID";
        public const String FLD_NAME_ParentDepartmentID = "ParentDepartmentID";
        public const String FLD_NAME_DepartmentCode = "DepartmentCode";
        public const String FLD_NAME_Name = "Name";
        public const String FLD_NAME_Location = "Location";
        public const String FLD_NAME_HODEmployeeID = "HODEmployeeID";
        public const String FLD_NAME_IsRemoved = "IsRemoved";

        #endregion
    }
}
