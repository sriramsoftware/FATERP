// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 03-Oct-2012, 03:53:48




using System;
using System.Diagnostics;
using System.ServiceModel;
using System.Runtime.Serialization;
using System.Collections.Generic;
using System.Xml.Serialization;


namespace Bay.ERP.Common.BusinessEntities
{
    [Serializable]
    [DataContract(Name = "APApprovalProcess", Namespace = "http://www.e-p-m-s.com/types")]
    public partial class APApprovalProcessEntity : BaseEntity
    {
        #region Properties


        private Int64 _APApprovalProcessID;
        private Int64 _APTypeID;
        private Int64? _ReferenceID;
        private String _Description;
        private String _Title;
        private DateTime _CreateDate;
        private Int64 _APStatusID;


        [DataMember]
        public Int64 APApprovalProcessID
        {
            get { return _APApprovalProcessID; }
            set { _APApprovalProcessID = value; }
        }

        [DataMember]
        public Int64 APTypeID
        {
            get { return _APTypeID; }
            set { _APTypeID = value; }
        }

        [DataMember]
        public Int64? ReferenceID
        {
            get { return _ReferenceID; }
            set { _ReferenceID = value; }
        }

        [DataMember]
        public String Description
        {
            get { return _Description; }
            set { _Description = value; }
        }

        [DataMember]
        public String Title
        {
            get { return _Title; }
            set { _Title = value; }
        }

        [DataMember]
        public DateTime CreateDate
        {
            get { return _CreateDate; }
            set { _CreateDate = value; }
        }

        [DataMember]
        public Int64 APStatusID
        {
            get { return _APStatusID; }
            set { _APStatusID = value; }
        }

        [XmlIgnore()]
        public override bool IsNew
        {
            [DebuggerStepThrough()]
            get
            {
                return (APApprovalProcessID <= 0);
            }
        }


        #endregion

        #region Constructor

        public APApprovalProcessEntity() : base()
        {
        }

        #endregion

        #region Constant

        public const String FLD_NAME_APApprovalProcessID = "APApprovalProcessID";
        public const String FLD_NAME_APTypeID = "APTypeID";
        public const String FLD_NAME_ReferenceID = "ReferenceID";
        public const String FLD_NAME_Description = "Description";
        public const String FLD_NAME_Title = "Title";
        public const String FLD_NAME_CreateDate = "CreateDate";
        public const String FLD_NAME_APStatusID = "APStatusID";

        #endregion
    }
}
