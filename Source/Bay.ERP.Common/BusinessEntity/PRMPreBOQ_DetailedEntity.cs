// Copyright and All Rights Reserved by
//B2B Solution, Bangladesh;
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 13-Dec-2011, 02:42:27




using System;
using System.Diagnostics;
using System.ServiceModel;
using System.Runtime.Serialization;
using System.Collections.Generic;
using System.Xml.Serialization;


namespace Bay.ERP.Common.BusinessEntities
{
    [Serializable]
    [DataContract(Name = "PRMPreBOQ_Detailed", Namespace = "http://www.e-p-m-s.com/types")]
    public partial class PRMPreBOQ_DetailedEntity : BaseEntity
    {
        #region Properties


        private Int64 _PreBOQID;
        private Int64 _ProjectID;
        private DateTime _StartDate;
        private Int64 _PreparedByMemberID;
        private String _Remarks;
        private Int64 _PreBOQStatusID;
        private Boolean _IsRemoved;
        private String _BDProjectProjectName;
        private String _HRMemberFirstName;
        private String _MDPreBOQStatusName;
        private Int64? _RowNumber;


        [DataMember]
        public Int64 PreBOQID
        {
            get { return _PreBOQID; }
            set { _PreBOQID = value; }
        }

        [DataMember]
        public Int64 ProjectID
        {
            get { return _ProjectID; }
            set { _ProjectID = value; }
        }

        [DataMember]
        public DateTime StartDate
        {
            get { return _StartDate; }
            set { _StartDate = value; }
        }

        [DataMember]
        public Int64 PreparedByMemberID
        {
            get { return _PreparedByMemberID; }
            set { _PreparedByMemberID = value; }
        }

        [DataMember]
        public String Remarks
        {
            get { return _Remarks; }
            set { _Remarks = value; }
        }

        [DataMember]
        public Int64 PreBOQStatusID
        {
            get { return _PreBOQStatusID; }
            set { _PreBOQStatusID = value; }
        }

        [DataMember]
        public Boolean IsRemoved
        {
            get { return _IsRemoved; }
            set { _IsRemoved = value; }
        }

        [DataMember]
        public String BDProjectProjectName
        {
            get { return _BDProjectProjectName; }
            set { _BDProjectProjectName = value; }
        }

        [DataMember]
        public String HRMemberFirstName
        {
            get { return _HRMemberFirstName; }
            set { _HRMemberFirstName = value; }
        }

        [DataMember]
        public String MDPreBOQStatusName
        {
            get { return _MDPreBOQStatusName; }
            set { _MDPreBOQStatusName = value; }
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
                return (PreBOQID <= 0);
            }
        }


        #endregion

        #region Constructor

        public PRMPreBOQ_DetailedEntity() : base()
        {
        }

        #endregion

        #region Constant

        public const String FLD_NAME_PreBOQID = "PreBOQID";
        public const String FLD_NAME_ProjectID = "ProjectID";
        public const String FLD_NAME_StartDate = "StartDate";
        public const String FLD_NAME_PreparedByMemberID = "PreparedByMemberID";
        public const String FLD_NAME_Remarks = "Remarks";
        public const String FLD_NAME_PreBOQStatusID = "PreBOQStatusID";
        public const String FLD_NAME_IsRemoved = "IsRemoved";
        public const String FLD_NAME_BDProjectProjectName = "BDProjectProjectName";
        public const String FLD_NAME_HRMemberFirstName = "HRMemberFirstName";
        public const String FLD_NAME_MDPreBOQStatusName = "MDPreBOQStatusName";
        public const String FLD_NAME_RowNumber = "RowNumber";

        #endregion
    }
}