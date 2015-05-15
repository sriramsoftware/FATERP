// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 26-Aug-2013, 05:29:28




using System;
using System.Diagnostics;
using System.ServiceModel;
using System.Runtime.Serialization;
using System.Collections.Generic;
using System.Xml.Serialization;


namespace Bay.ERP.Common.BusinessEntities
{
    [Serializable]
    [DataContract(Name = "PRMMaterialReceive_Detailed", Namespace = "http://www.e-p-m-s.com/types")]
    public partial class PRMMaterialReceive_DetailedEntity : BaseEntity
    {
        #region Properties


        private Int64 _MaterialReceiveID;
        private Int64 _ProjectID;
        private Int64 _SupplierID;
        private Int64 _RequisitionID;
        private Int64 _WorkOrderID;
        private String _MRRNo;
        private DateTime _MRRDate;
        private String _Remarks;
        private Int64 _MaterialReceiveApprovalStatusID;
        private String _BDProjectProjectName;
        private String _PRMSupplierSupplierName;
        private String _MaterialReceiveApprovalStatusName;
        private String _RequisitionNo;
        private String _WorkOrderNo;
        private Int64? _RowNumber;


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

        [DataMember]
        public String BDProjectProjectName
        {
            get { return _BDProjectProjectName; }
            set { _BDProjectProjectName = value; }
        }

        [DataMember]
        public String PRMSupplierSupplierName
        {
            get { return _PRMSupplierSupplierName; }
            set { _PRMSupplierSupplierName = value; }
        }

        [DataMember]
        public String MaterialReceiveApprovalStatusName
        {
            get { return _MaterialReceiveApprovalStatusName; }
            set { _MaterialReceiveApprovalStatusName = value; }
        }

        [DataMember]
        public String RequisitionNo
        {
            get { return _RequisitionNo; }
            set { _RequisitionNo = value; }
        }

        [DataMember]
        public String WorkOrderNo
        {
            get { return _WorkOrderNo; }
            set { _WorkOrderNo = value; }
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
                return (MaterialReceiveID <= 0);
            }
        }


        #endregion

        #region Constructor

        public PRMMaterialReceive_DetailedEntity() : base()
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
        public const String FLD_NAME_Remarks = "Remarks";
        public const String FLD_NAME_MaterialReceiveApprovalStatusID = "MaterialReceiveApprovalStatusID";
        public const String FLD_NAME_BDProjectProjectName = "BDProjectProjectName";
        public const String FLD_NAME_PRMSupplierSupplierName = "PRMSupplierSupplierName";
        public const String FLD_NAME_MaterialReceiveApprovalStatusName = "MaterialReceiveApprovalStatusName";
        public const String FLD_NAME_RequisitionNo = "RequisitionNo";
        public const String FLD_NAME_WorkOrderNo = "WorkOrderNo";
        public const String FLD_NAME_RowNumber = "RowNumber";

        #endregion
    }
}
