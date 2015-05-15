// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 15-Dec-2013, 10:37:38




using System;
using System.Diagnostics;
using System.ServiceModel;
using System.Runtime.Serialization;
using System.Collections.Generic;
using System.Xml.Serialization;


namespace Bay.ERP.Common.BusinessEntities
{
    [Serializable]
    [DataContract(Name = "CRMPaymentSchedule_Detailed", Namespace = "http://www.e-p-m-s.com/types")]
    public partial class CRMPaymentSchedule_DetailedEntity : BaseEntity
    {
        #region Properties


        private Int64 _PaymentScheduleID;
        private DateTime _HandoverDate;
        private DateTime? _ActualHandoverDate;
        private String _BDProjectCode;
        private Int64 _BuyerBasicInfoID;
        private Decimal? _CommonService;
        private Decimal? _UtilityConnectionCost;
        private Decimal? _ReservedFund;
        private Decimal? _TotalInstallment;
        private String _Remarks;
        private Int64 _CreateByEmployeeID;
        private String _IP;
        private DateTime _CreateDate;
        private String _BuyerBasicInfoContactFullName;
        private String _ProjectCode;
        private String _ProjectName;
        private String _BookingNote;
        private Int64 _ProjectFloorUnitID;
        private String _ProjectFloorUnitName;
        private String _ImageUrl;
        private String _MemberFullName;
        private Int64? _RowNumber;


        [DataMember]
        public Int64 PaymentScheduleID
        {
            get { return _PaymentScheduleID; }
            set { _PaymentScheduleID = value; }
        }

        [DataMember]
        public DateTime HandoverDate
        {
            get { return _HandoverDate; }
            set { _HandoverDate = value; }
        }

        [DataMember]
        public DateTime? ActualHandoverDate
        {
            get { return _ActualHandoverDate; }
            set { _ActualHandoverDate = value; }
        }

        [DataMember]
        public String BDProjectCode
        {
            get { return _BDProjectCode; }
            set { _BDProjectCode = value; }
        }

        [DataMember]
        public Int64 BuyerBasicInfoID
        {
            get { return _BuyerBasicInfoID; }
            set { _BuyerBasicInfoID = value; }
        }

        [DataMember]
        public Decimal? CommonService
        {
            get { return _CommonService; }
            set { _CommonService = value; }
        }

        [DataMember]
        public Decimal? UtilityConnectionCost
        {
            get { return _UtilityConnectionCost; }
            set { _UtilityConnectionCost = value; }
        }

        [DataMember]
        public Decimal? ReservedFund
        {
            get { return _ReservedFund; }
            set { _ReservedFund = value; }
        }

        [DataMember]
        public Decimal? TotalInstallment
        {
            get { return _TotalInstallment; }
            set { _TotalInstallment = value; }
        }

        [DataMember]
        public String Remarks
        {
            get { return _Remarks; }
            set { _Remarks = value; }
        }

        [DataMember]
        public Int64 CreateByEmployeeID
        {
            get { return _CreateByEmployeeID; }
            set { _CreateByEmployeeID = value; }
        }

        [DataMember]
        public String IP
        {
            get { return _IP; }
            set { _IP = value; }
        }

        [DataMember]
        public DateTime CreateDate
        {
            get { return _CreateDate; }
            set { _CreateDate = value; }
        }

        [DataMember]
        public String BuyerBasicInfoContactFullName
        {
            get { return _BuyerBasicInfoContactFullName; }
            set { _BuyerBasicInfoContactFullName = value; }
        }

        [DataMember]
        public String ProjectCode
        {
            get { return _ProjectCode; }
            set { _ProjectCode = value; }
        }

        [DataMember]
        public String ProjectName
        {
            get { return _ProjectName; }
            set { _ProjectName = value; }
        }

        [DataMember]
        public String BookingNote
        {
            get { return _BookingNote; }
            set { _BookingNote = value; }
        }

        [DataMember]
        public Int64 ProjectFloorUnitID
        {
            get { return _ProjectFloorUnitID; }
            set { _ProjectFloorUnitID = value; }
        }

        [DataMember]
        public String ProjectFloorUnitName
        {
            get { return _ProjectFloorUnitName; }
            set { _ProjectFloorUnitName = value; }
        }

        [DataMember]
        public String ImageUrl
        {
            get { return _ImageUrl; }
            set { _ImageUrl = value; }
        }

        [DataMember]
        public String MemberFullName
        {
            get { return _MemberFullName; }
            set { _MemberFullName = value; }
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
                return (PaymentScheduleID <= 0);
            }
        }


        #endregion

        #region Constructor

        public CRMPaymentSchedule_DetailedEntity() : base()
        {
        }

        #endregion

        #region Constant

        public const String FLD_NAME_PaymentScheduleID = "PaymentScheduleID";
        public const String FLD_NAME_HandoverDate = "HandoverDate";
        public const String FLD_NAME_ActualHandoverDate = "ActualHandoverDate";
        public const String FLD_NAME_BDProjectCode = "BDProjectCode";
        public const String FLD_NAME_BuyerBasicInfoID = "BuyerBasicInfoID";
        public const String FLD_NAME_CommonService = "CommonService";
        public const String FLD_NAME_UtilityConnectionCost = "UtilityConnectionCost";
        public const String FLD_NAME_ReservedFund = "ReservedFund";
        public const String FLD_NAME_TotalInstallment = "TotalInstallment";
        public const String FLD_NAME_Remarks = "Remarks";
        public const String FLD_NAME_CreateByEmployeeID = "CreateByEmployeeID";
        public const String FLD_NAME_IP = "IP";
        public const String FLD_NAME_CreateDate = "CreateDate";
        public const String FLD_NAME_BuyerBasicInfoContactFullName = "BuyerBasicInfoContactFullName";
        public const String FLD_NAME_ProjectCode = "ProjectCode";
        public const String FLD_NAME_ProjectName = "ProjectName";
        public const String FLD_NAME_BookingNote = "BookingNote";
        public const String FLD_NAME_ProjectFloorUnitID = "ProjectFloorUnitID";
        public const String FLD_NAME_ProjectFloorUnitName = "ProjectFloorUnitName";
        public const String FLD_NAME_ImageUrl = "ImageUrl";
        public const String FLD_NAME_MemberFullName = "MemberFullName";
        public const String FLD_NAME_RowNumber = "RowNumber";

        #endregion
    }
}
