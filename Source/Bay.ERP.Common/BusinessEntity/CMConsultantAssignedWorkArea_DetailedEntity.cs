// Copyright and All Rights Reserved by
//B2B Solution, Bangladesh;
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 09-Jan-2012, 11:59:55




using System;
using System.Diagnostics;
using System.ServiceModel;
using System.Runtime.Serialization;
using System.Collections.Generic;
using System.Xml.Serialization;


namespace Bay.ERP.Common.BusinessEntities
{
    [Serializable]
    [DataContract(Name = "CMConsultantAssignedWorkArea_Detailed", Namespace = "http://www.e-p-m-s.com/types")]
    public partial class CMConsultantAssignedWorkArea_DetailedEntity : BaseEntity
    {
        #region Properties


        private Int64 _ConsultantAssignedWorkAreaID;
        private Int64 _ConsultantID;
        private Int64 _ProjectID;
        private Int64 _ConsultantWorkAreaID;
        private Int64 _WorkAreaStatusID;
        private DateTime? _StartDate;
        private DateTime? _EndDate;
        private DateTime? _ActualStartDate;
        private DateTime? _ActualEndDate;
        private String _Remarks;
        private String _ConsultantName;
        private String _ProjectName;
        private String _ConsultantWorkAreaName;
        private String _WorkAreaStatusName;
        private Int64? _RowNumber;


        [DataMember]
        public Int64 ConsultantAssignedWorkAreaID
        {
            get { return _ConsultantAssignedWorkAreaID; }
            set { _ConsultantAssignedWorkAreaID = value; }
        }

        [DataMember]
        public Int64 ConsultantID
        {
            get { return _ConsultantID; }
            set { _ConsultantID = value; }
        }

        [DataMember]
        public Int64 ProjectID
        {
            get { return _ProjectID; }
            set { _ProjectID = value; }
        }

        [DataMember]
        public Int64 ConsultantWorkAreaID
        {
            get { return _ConsultantWorkAreaID; }
            set { _ConsultantWorkAreaID = value; }
        }

        [DataMember]
        public Int64 WorkAreaStatusID
        {
            get { return _WorkAreaStatusID; }
            set { _WorkAreaStatusID = value; }
        }

        [DataMember]
        public DateTime? StartDate
        {
            get { return _StartDate; }
            set { _StartDate = value; }
        }

        [DataMember]
        public DateTime? EndDate
        {
            get { return _EndDate; }
            set { _EndDate = value; }
        }

        [DataMember]
        public DateTime? ActualStartDate
        {
            get { return _ActualStartDate; }
            set { _ActualStartDate = value; }
        }

        [DataMember]
        public DateTime? ActualEndDate
        {
            get { return _ActualEndDate; }
            set { _ActualEndDate = value; }
        }

        [DataMember]
        public String Remarks
        {
            get { return _Remarks; }
            set { _Remarks = value; }
        }

        [DataMember]
        public String ConsultantName
        {
            get { return _ConsultantName; }
            set { _ConsultantName = value; }
        }

        [DataMember]
        public String ProjectName
        {
            get { return _ProjectName; }
            set { _ProjectName = value; }
        }

        [DataMember]
        public String ConsultantWorkAreaName
        {
            get { return _ConsultantWorkAreaName; }
            set { _ConsultantWorkAreaName = value; }
        }

        [DataMember]
        public String WorkAreaStatusName
        {
            get { return _WorkAreaStatusName; }
            set { _WorkAreaStatusName = value; }
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
                return (ConsultantAssignedWorkAreaID <= 0);
            }
        }


        #endregion

        #region Constructor

        public CMConsultantAssignedWorkArea_DetailedEntity() : base()
        {
        }

        #endregion

        #region Constant

        public const String FLD_NAME_ConsultantAssignedWorkAreaID = "ConsultantAssignedWorkAreaID";
        public const String FLD_NAME_ConsultantID = "ConsultantID";
        public const String FLD_NAME_ProjectID = "ProjectID";
        public const String FLD_NAME_ConsultantWorkAreaID = "ConsultantWorkAreaID";
        public const String FLD_NAME_WorkAreaStatusID = "WorkAreaStatusID";
        public const String FLD_NAME_StartDate = "StartDate";
        public const String FLD_NAME_EndDate = "EndDate";
        public const String FLD_NAME_ActualStartDate = "ActualStartDate";
        public const String FLD_NAME_ActualEndDate = "ActualEndDate";
        public const String FLD_NAME_Remarks = "Remarks";
        public const String FLD_NAME_ConsultantName = "ConsultantName";
        public const String FLD_NAME_ProjectName = "ProjectName";
        public const String FLD_NAME_ConsultantWorkAreaName = "ConsultantWorkAreaName";
        public const String FLD_NAME_WorkAreaStatusName = "WorkAreaStatusName";
        public const String FLD_NAME_RowNumber = "RowNumber";

        #endregion
    }
}
