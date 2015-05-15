// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 24-Oct-2013, 12:51:37




using System;
using System.Diagnostics;
using System.ServiceModel;
using System.Runtime.Serialization;
using System.Collections.Generic;
using System.Xml.Serialization;


namespace Bay.ERP.Common.BusinessEntities
{
    [Serializable]
    [DataContract(Name = "CRMSurveyMaster", Namespace = "http://www.e-p-m-s.com/types")]
    public partial class CRMSurveyMasterEntity : BaseEntity
    {
        #region Properties


        private Int64 _SurveyMasterID;
        private String _Title;
        private DateTime _StartDate;
        private DateTime _EndDate;
        private DateTime? _CreateDate;
        private Int64 _CreateByEmployeeID;


        [DataMember]
        public Int64 SurveyMasterID
        {
            get { return _SurveyMasterID; }
            set { _SurveyMasterID = value; }
        }

        [DataMember]
        public String Title
        {
            get { return _Title; }
            set { _Title = value; }
        }

        [DataMember]
        public DateTime StartDate
        {
            get { return _StartDate; }
            set { _StartDate = value; }
        }

        [DataMember]
        public DateTime EndDate
        {
            get { return _EndDate; }
            set { _EndDate = value; }
        }

        [DataMember]
        public DateTime? CreateDate
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

        [XmlIgnore()]
        public override bool IsNew
        {
            [DebuggerStepThrough()]
            get
            {
                return (SurveyMasterID <= 0);
            }
        }


        #endregion

        #region Constructor

        public CRMSurveyMasterEntity()
            : base()
        {
        }

        #endregion

        #region Constant

        public const String FLD_NAME_SurveyMasterID = "SurveyMasterID";
        public const String FLD_NAME_Title= "Title";
        public const String FLD_NAME_StartDate = "StartDate";
        public const String FLD_NAME_EndDate = "EndDate";
        public const String FLD_NAME_CreateDate = "CreateDate=";
        public const String FLD_NAME_CreateByEmployeeID = "CreateByEmployeeID";

        #endregion
    }
}
