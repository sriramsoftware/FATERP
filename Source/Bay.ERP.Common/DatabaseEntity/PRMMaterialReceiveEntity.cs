// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 14-Aug-2013, 02:50:29




using System;
using System.Diagnostics;
using System.ServiceModel;
using System.Runtime.Serialization;
using System.Collections.Generic;
using System.Xml.Serialization;


namespace Bay.ERP.Common.BusinessEntities
{
    [Serializable]
    [DataContract(Name = "PRMMaterialReceive", Namespace = "http://www.e-p-m-s.com/types")]
    public partial class PRMMaterialReceiveEntity : BaseEntity
    {
        #region Properties


        private Int64 _MaterialReceiveID;
        private Int64 _ProjectID;
        private Int64 _SupplierID;
        private Int64 _RequisitionID;
        private Int64 _WorkOrderID;
        private String _MRRNo;
        private DateTime _MRRDate;
        private Int64? _CreatedByEmployeeID;
        private String _Remarks;
        private Int64 _MaterialReceiveApprovalStatusID;


        [DataMember]
        public Int64 MaterialReceiveID
        {
            get { return _MaterialReceiveID; }
            set { _MaterialReceiveID = value; }
        }

        [DataMember]
        public Int64 ProjectID
        {
            get { return _ProjectID; }
            set { _ProjectID = value; }
        }

        [DataMember]
        public Int64 SupplierID
        {
            get { return _SupplierID; }
            set { _SupplierID = value; }
        }

        [DataMember]
        public Int64 RequisitionID
        {
            get { return _RequisitionID; }
            set { _RequisitionID = value; }
        }

        [DataMember]
        public Int64 WorkOrderID
        {
            get { return _WorkOrderID; }
            set { _WorkOrderID = value; }
        }

        [DataMember]
        public String MRRNo
        {
            get { return _MRRNo; }
            set { _MRRNo = value; }
        }

        [DataMember]
        public DateTime MRRDate
        {
            get { return _MRRDate; }
            set { _MRRDate = value; }
        }

        [DataMember]
        public Int64? CreatedByEmployeeID
        {
            get { return _CreatedByEmployeeID; }
            set { _CreatedByEmployeeID = value; }
        }

        [DataMember]
        public String Remarks
        {
            get { return _Remarks; }
            set { _Remarks = value; }
        }

        [DataMember]
        public Int64 MaterialReceiveApprovalStatusID
        {
            get { return _MaterialReceiveApprovalStatusID; }
            set { _MaterialReceiveApprovalStatusID = value; }
        }

        [XmlIgnore()]
        public override bool IsNew
        {
            [DebuggerStepThrough()]
            get
            {
                return (MaterialReceiveID <= 0);
            }
        }


        #endregion

        #region Constructor

        public PRMMaterialReceiveEntity() : base()
        {
        }

        #endregion

        #region Constant

        public const String FLD_NAME_MaterialReceiveID = "MaterialReceiveID";
        public const String FLD_NAME_ProjectID = "ProjectID";
        public const String FLD_NAME_SupplierID = "SupplierID";
        public const String FLD_NAME_RequisitionID = "RequisitionID";
        public const String FLD_NAME_WorkOrderID = "WorkOrderID";
        public const String FLD_NAME_MRRNo = "MRRNo";
        public const String FLD_NAME_MRRDate = "MRRDate";
        public const String FLD_NAME_CreatedByEmployeeID = "CreatedByEmployeeID";
        public const String FLD_NAME_Remarks = "Remarks";
        public const String FLD_NAME_MaterialReceiveApprovalStatusID = "MaterialReceiveApprovalStatusID";

        #endregion
    }
}
