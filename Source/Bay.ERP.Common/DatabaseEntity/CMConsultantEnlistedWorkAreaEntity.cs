// Copyright and All Rights Reserved by
//B2B Solution, Bangladesh;
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 09-Jan-2012, 01:23:18




using System;
using System.Diagnostics;
using System.ServiceModel;
using System.Runtime.Serialization;
using System.Collections.Generic;
using System.Xml.Serialization;


namespace Bay.ERP.Common.BusinessEntities
{
    [Serializable]
    [DataContract(Name = "CMConsultantEnlistedWorkArea", Namespace = "http://www.e-p-m-s.com/types")]
    public partial class CMConsultantEnlistedWorkAreaEntity : BaseEntity
    {
        #region Properties


        private Int64 _ConsultantEnlistedWorkAreaID;
        private Int64 _ConsultantID;
        private Int64 _ConsultantWorkAreaID;


        [DataMember]
        public Int64 ConsultantEnlistedWorkAreaID
        {
            get { return _ConsultantEnlistedWorkAreaID; }
            set { _ConsultantEnlistedWorkAreaID = value; }
        }

        [DataMember]
        public Int64 ConsultantID
        {
            get { return _ConsultantID; }
            set { _ConsultantID = value; }
        }

        [DataMember]
        public Int64 ConsultantWorkAreaID
        {
            get { return _ConsultantWorkAreaID; }
            set { _ConsultantWorkAreaID = value; }
        }

        [XmlIgnore()]
        public override bool IsNew
        {
            [DebuggerStepThrough()]
            get
            {
                return (ConsultantEnlistedWorkAreaID <= 0);
            }
        }


        #endregion

        #region Constructor

        public CMConsultantEnlistedWorkAreaEntity() : base()
        {
        }

        #endregion

        #region Constant

        public const String FLD_NAME_ConsultantEnlistedWorkAreaID = "ConsultantEnlistedWorkAreaID";
        public const String FLD_NAME_ConsultantID = "ConsultantID";
        public const String FLD_NAME_ConsultantWorkAreaID = "ConsultantWorkAreaID";

        #endregion
    }
}
