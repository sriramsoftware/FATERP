// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 12-Nov-2013, 09:52:33




using System;
using System.Diagnostics;
using System.ServiceModel;
using System.Runtime.Serialization;
using System.Collections.Generic;
using System.Xml.Serialization;


namespace Bay.ERP.Common.BusinessEntities
{
    [Serializable]
    [DataContract(Name = "BDProcessAssignedResource_Detailed", Namespace = "http://www.e-p-m-s.com/types")]
    public partial class BDProcessAssignedResource_DetailedEntity : BaseEntity
    {
        #region Properties


        private Int64 _ProcessAssignedResourceID;
        private Int64 _ProcessCategoryID;
        private String _Title;
        private String _Purposes;
        private String _Remarks;
        private DateTime? _StartDate;
        private DateTime _CreateDate;
        private Int64 _CreateByEmployeeID;
        private Int64 _ProcessAssignedResourceApprovalStatusID;
        private String _ProcessCategoryName;
        private String _ProcessAssignedResourceStatus;
        private String _MemberFullName;


        [DataMember]
        public Int64 ProcessAssignedResourceID
        {
            get { return _ProcessAssignedResourceID; }
            set { _ProcessAssignedResourceID = value; }
        }

        [DataMember]
        public Int64 ProcessCategoryID
        {
            get { return _ProcessCategoryID; }
            set { _ProcessCategoryID = value; }
        }

        [DataMember]
        public String Title
        {
            get { return _Title; }
            set { _Title = value; }
        }

        [DataMember]
        public String Purposes
        {
            get { return _Purposes; }
            set { _Purposes = value; }
        }

        [DataMember]
        public String Remarks
        {
            get { return _Remarks; }
            set { _Remarks = value; }
        }

        [DataMember]
        public DateTime? StartDate
        {
            get { return _StartDate; }
            set { _StartDate = value; }
        }

        [DataMember]
        public DateTime CreateDate
        {
            get { return _CreateDate; }
            set { _CreateDate = value; }
        }

        [DataMember]
        public Int64 CreateByEmployeeID
        {
            get { return _CreateByEmployeeID; }
            set { _CreateByEmployeeID = value; }
        }

        [DataMember]
        public Int64 ProcessAssignedResourceApprovalStatusID
        {
            get { return _ProcessAssignedResourceApprovalStatusID; }
            set { _ProcessAssignedResourceApprovalStatusID = value; }
        }

        [DataMember]
        public String ProcessCategoryName
        {
            get { return _ProcessCategoryName; }
            set { _ProcessCategoryName = value; }
        }

        [DataMember]
        public String ProcessAssignedResourceStatus
        {
            get { return _ProcessAssignedResourceStatus; }
            set { _ProcessAssignedResourceStatus = value; }
        }

        [DataMember]
        public String MemberFullName
        {
            get { return _MemberFullName; }
            set { _MemberFullName = value; }
        }

        [XmlIgnore()]
        public override bool IsNew
        {
            [DebuggerStepThrough()]
            get
            {
                return (ProcessAssignedResourceID <= 0);
            }
        }


        #endregion

        #region Constructor

        public BDProcessAssignedResource_DetailedEntity() : base()
        {
        }

        #endregion

        #region Constant

        public const String FLD_NAME_ProcessAssignedResourceID = "ProcessAssignedResourceID";
        public const String FLD_NAME_ProcessCategoryID = "ProcessCategoryID";
        public const String FLD_NAME_Title = "Title";
        public const String FLD_NAME_Purposes = "Purposes";
        public const String FLD_NAME_Remarks = "Remarks";
        public const String FLD_NAME_StartDate = "StartDate";
        public const String FLD_NAME_CreateDate = "CreateDate";
        public const String FLD_NAME_CreateByEmployeeID = "CreateByEmployeeID";
        public const String FLD_NAME_ProcessAssignedResourceApprovalStatusID = "ProcessAssignedResourceApprovalStatusID";
        public const String FLD_NAME_ProcessCategoryName = "ProcessCategoryName";
        public const String FLD_NAME_ProcessAssignedResourceStatus = "ProcessAssignedResourceStatus";
        public const String FLD_NAME_MemberFullName = "MemberFullName";

        #endregion
    }
}
