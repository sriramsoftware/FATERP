// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 02-Oct-2013, 01:03:02




using System;
using System.Diagnostics;
using System.ServiceModel;
using System.Runtime.Serialization;
using System.Collections.Generic;
using System.Xml.Serialization;


namespace Bay.ERP.Common.BusinessEntities
{
    [Serializable]
    [DataContract(Name = "REQRequisition", Namespace = "http://www.e-p-m-s.com/types")]
    public partial class REQRequisitionEntity : BaseEntity
    {
        #region Properties


        private Int64 _RequisitionID;
        private Int64 _ProjectID;
        private String _RequisitionNo;
        private DateTime _RequisitionDate;
        private String _Remarks;
        private Int64 _RequisitionStatusID;
        private Int64 _PreparedByMemberID;
        private Boolean _IsCashPayment;
        private Boolean _IsAccountsMadePayment;
        private Boolean _IsRCS;


        [DataMember]
        public Int64 RequisitionID
        {
            get { return _RequisitionID; }
            set { _RequisitionID = value; }
        }

        [DataMember]
        public Int64 ProjectID
        {
            get { return _ProjectID; }
            set { _ProjectID = value; }
        }

        [DataMember]
        public String RequisitionNo
        {
            get { return _RequisitionNo; }
            set { _RequisitionNo = value; }
        }

        [DataMember]
        public DateTime RequisitionDate
        {
            get { return _RequisitionDate; }
            set { _RequisitionDate = value; }
        }

        [DataMember]
        public String Remarks
        {
            get { return _Remarks; }
            set { _Remarks = value; }
        }

        [DataMember]
        public Int64 RequisitionStatusID
        {
            get { return _RequisitionStatusID; }
            set { _RequisitionStatusID = value; }
        }

        [DataMember]
        public Int64 PreparedByMemberID
        {
            get { return _PreparedByMemberID; }
            set { _PreparedByMemberID = value; }
        }

        [DataMember]
        public Boolean IsCashPayment
        {
            get { return _IsCashPayment; }
            set { _IsCashPayment = value; }
        }

        [DataMember]
        public Boolean IsAccountsMadePayment
        {
            get { return _IsAccountsMadePayment; }
            set { _IsAccountsMadePayment = value; }
        }

        [DataMember]
        public Boolean IsRCS
        {
            get { return _IsRCS; }
            set { _IsRCS = value; }
        }

        [XmlIgnore()]
        public override bool IsNew
        {
            [DebuggerStepThrough()]
            get
            {
                return (RequisitionID <= 0);
            }
        }


        #endregion

        #region Constructor

        public REQRequisitionEntity() : base()
        {
        }

        #endregion

        #region Constant

        public const String FLD_NAME_RequisitionID = "RequisitionID";
        public const String FLD_NAME_ProjectID = "ProjectID";
        public const String FLD_NAME_RequisitionNo = "RequisitionNo";
        public const String FLD_NAME_RequisitionDate = "RequisitionDate";
        public const String FLD_NAME_Remarks = "Remarks";
        public const String FLD_NAME_RequisitionStatusID = "RequisitionStatusID";
        public const String FLD_NAME_PreparedByMemberID = "PreparedByMemberID";
        public const String FLD_NAME_IsCashPayment = "IsCashPayment";
        public const String FLD_NAME_IsAccountsMadePayment = "IsAccountsMadePayment";
        public const String FLD_NAME_IsRCS = "IsRCS";

        #endregion
    }
}
