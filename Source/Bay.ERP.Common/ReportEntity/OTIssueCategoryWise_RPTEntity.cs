// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 18-Aug-2013, 10:45:50




using System;
using System.Diagnostics;
using System.ServiceModel;
using System.Runtime.Serialization;
using System.Collections.Generic;
using System.Xml.Serialization;


namespace Bay.ERP.Common.BusinessEntities
{
    [Serializable]
    [DataContract(Name = "OTIssueCategoryWise_RPT", Namespace = "http://www.e-p-m-s.com/types")]
    public partial class OTIssueCategoryWise_RPTEntity : BaseEntity
    {
        #region Properties


        private Int64 _IssueCategoryID;
        private Int64? _ReferenceID;
        private String _Name;
        private String _ProjectName;
        private String _TotalTime;


        [DataMember]
        public Int64 IssueCategoryID
        {
            get { return _IssueCategoryID; }
            set { _IssueCategoryID = value; }
        }

        [DataMember]
        public Int64? ReferenceID
        {
            get { return _ReferenceID; }
            set { _ReferenceID = value; }
        }

        [DataMember]
        public String Name
        {
            get { return _Name; }
            set { _Name = value; }
        }

        [DataMember]
        public String ProjectName
        {
            get { return _ProjectName; }
            set { _ProjectName = value; }
        }

        [DataMember]
        public String TotalTime
        {
            get { return _TotalTime; }
            set { _TotalTime = value; }
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

        public OTIssueCategoryWise_RPTEntity() : base()
        {
        }

        #endregion

        #region Constant

        public const String FLD_NAME_IssueCategoryID = "IssueCategoryID";
        public const String FLD_NAME_ReferenceID = "ReferenceID";
        public const String FLD_NAME_Name = "Name";
        public const String FLD_NAME_ProjectName = "ProjectName";
        public const String FLD_NAME_TotalTime = "TotalTime";

        #endregion
    }
}
