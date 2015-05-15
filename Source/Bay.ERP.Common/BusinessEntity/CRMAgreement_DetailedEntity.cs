// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 16-Apr-2013, 01:42:12




using System;
using System.Diagnostics;
using System.ServiceModel;
using System.Runtime.Serialization;
using System.Collections.Generic;
using System.Xml.Serialization;


namespace Bay.ERP.Common.BusinessEntities
{
    [Serializable]
    [DataContract(Name = "CRMAgreement_Detailed", Namespace = "http://www.e-p-m-s.com/types")]
    public partial class CRMAgreement_DetailedEntity : BaseEntity
    {
        #region Properties


        private Int64 _AgreementID;
        private Int64 _AgreementTypeID;
        private Int64 _BuyerBasicInfoID;
        private Int64 _ProjectID;
        private Int64 _ProjectFloorUnitID;
        private String _Text;
        private DateTime? _AgreementDate;
        private DateTime? _SignDate;
        private DateTime? _ExecuteDate;
        private String _Field1;
        private String _Field2;
        private String _Field3;
        private String _Field4;
        private String _Remarks;
        private Int64 _CreatedByEmployeeID;
        private DateTime _CreateDate;
        private String _IP;
        private Int64 _AgreementApprovalStatusID;
        private String _CRMMDAgreementTypeName;
        private String _CRMBuyerBasicInfoContactFullName;
        private String _BDProjectProjectName;
        private String _BDProjectFloorUnitProjectFloorUnitName;
        private String _CreatedByMemberFullName;
        private String _CRMMDAgreementApprovalStatusName;
        private Int64? _RowNumber;


        [DataMember]
        public Int64 AgreementID
        {
            get { return _AgreementID; }
            set { _AgreementID = value; }
        }

        [DataMember]
        public Int64 AgreementTypeID
        {
            get { return _AgreementTypeID; }
            set { _AgreementTypeID = value; }
        }

        [DataMember]
        public Int64 BuyerBasicInfoID
        {
            get { return _BuyerBasicInfoID; }
            set { _BuyerBasicInfoID = value; }
        }

        [DataMember]
        public Int64 ProjectID
        {
            get { return _ProjectID; }
            set { _ProjectID = value; }
        }

        [DataMember]
        public Int64 ProjectFloorUnitID
        {
            get { return _ProjectFloorUnitID; }
            set { _ProjectFloorUnitID = value; }
        }

        [DataMember]
        public String Text
        {
            get { return _Text; }
            set { _Text = value; }
        }

        [DataMember]
        public DateTime? AgreementDate
        {
            get { return _AgreementDate; }
            set { _AgreementDate = value; }
        }

        [DataMember]
        public DateTime? SignDate
        {
            get { return _SignDate; }
            set { _SignDate = value; }
        }

        [DataMember]
        public DateTime? ExecuteDate
        {
            get { return _ExecuteDate; }
            set { _ExecuteDate = value; }
        }

        [DataMember]
        public String Field1
        {
            get { return _Field1; }
            set { _Field1 = value; }
        }

        [DataMember]
        public String Field2
        {
            get { return _Field2; }
            set { _Field2 = value; }
        }

        [DataMember]
        public String Field3
        {
            get { return _Field3; }
            set { _Field3 = value; }
        }

        [DataMember]
        public String Field4
        {
            get { return _Field4; }
            set { _Field4 = value; }
        }

        [DataMember]
        public String Remarks
        {
            get { return _Remarks; }
            set { _Remarks = value; }
        }

        [DataMember]
        public Int64 CreatedByEmployeeID
        {
            get { return _CreatedByEmployeeID; }
            set { _CreatedByEmployeeID = value; }
        }

        [DataMember]
        public DateTime CreateDate
        {
            get { return _CreateDate; }
            set { _CreateDate = value; }
        }

        [DataMember]
        public String IP
        {
            get { return _IP; }
            set { _IP = value; }
        }

        [DataMember]
        public Int64 AgreementApprovalStatusID
        {
            get { return _AgreementApprovalStatusID; }
            set { _AgreementApprovalStatusID = value; }
        }

        [DataMember]
        public String CRMMDAgreementTypeName
        {
            get { return _CRMMDAgreementTypeName; }
            set { _CRMMDAgreementTypeName = value; }
        }

        [DataMember]
        public String CRMBuyerBasicInfoContactFullName
        {
            get { return _CRMBuyerBasicInfoContactFullName; }
            set { _CRMBuyerBasicInfoContactFullName = value; }
        }

        [DataMember]
        public String BDProjectProjectName
        {
            get { return _BDProjectProjectName; }
            set { _BDProjectProjectName = value; }
        }

        [DataMember]
        public String BDProjectFloorUnitProjectFloorUnitName
        {
            get { return _BDProjectFloorUnitProjectFloorUnitName; }
            set { _BDProjectFloorUnitProjectFloorUnitName = value; }
        }

        [DataMember]
        public String CreatedByMemberFullName
        {
            get { return _CreatedByMemberFullName; }
            set { _CreatedByMemberFullName = value; }
        }

        [DataMember]
        public String CRMMDAgreementApprovalStatusName
        {
            get { return _CRMMDAgreementApprovalStatusName; }
            set { _CRMMDAgreementApprovalStatusName = value; }
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
                return (AgreementID <= 0);
            }
        }


        #endregion

        #region Constructor

        public CRMAgreement_DetailedEntity() : base()
        {
        }

        #endregion

        #region Constant

        public const String FLD_NAME_AgreementID = "AgreementID";
        public const String FLD_NAME_AgreementTypeID = "AgreementTypeID";
        public const String FLD_NAME_BuyerBasicInfoID = "BuyerBasicInfoID";
        public const String FLD_NAME_ProjectID = "ProjectID";
        public const String FLD_NAME_ProjectFloorUnitID = "ProjectFloorUnitID";
        public const String FLD_NAME_Text = "Text";
        public const String FLD_NAME_AgreementDate = "AgreementDate";
        public const String FLD_NAME_SignDate = "SignDate";
        public const String FLD_NAME_ExecuteDate = "ExecuteDate";
        public const String FLD_NAME_Field1 = "Field1";
        public const String FLD_NAME_Field2 = "Field2";
        public const String FLD_NAME_Field3 = "Field3";
        public const String FLD_NAME_Field4 = "Field4";
        public const String FLD_NAME_Remarks = "Remarks";
        public const String FLD_NAME_CreatedByEmployeeID = "CreatedByEmployeeID";
        public const String FLD_NAME_CreateDate = "CreateDate";
        public const String FLD_NAME_IP = "IP";
        public const String FLD_NAME_AgreementApprovalStatusID = "AgreementApprovalStatusID";
        public const String FLD_NAME_CRMMDAgreementTypeName = "CRMMDAgreementTypeName";
        public const String FLD_NAME_CRMBuyerBasicInfoContactFullName = "CRMBuyerBasicInfoContactFullName";
        public const String FLD_NAME_BDProjectProjectName = "BDProjectProjectName";
        public const String FLD_NAME_BDProjectFloorUnitProjectFloorUnitName = "BDProjectFloorUnitProjectFloorUnitName";
        public const String FLD_NAME_CreatedByMemberFullName = "CreatedByMemberFullName";
        public const String FLD_NAME_CRMMDAgreementApprovalStatusName = "CRMMDAgreementApprovalStatusName";
        public const String FLD_NAME_RowNumber = "RowNumber";

        #endregion
    }
}
