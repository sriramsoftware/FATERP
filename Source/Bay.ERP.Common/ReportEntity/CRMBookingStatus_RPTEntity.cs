// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 20-May-2013, 04:56:23




using System;
using System.Diagnostics;
using System.ServiceModel;
using System.Runtime.Serialization;
using System.Collections.Generic;
using System.Xml.Serialization;


namespace Bay.ERP.Common.BusinessEntities
{
    [Serializable]
    [DataContract(Name = "CRMBookingStatus_RPT", Namespace = "http://www.e-p-m-s.com/types")]
    public partial class CRMBookingStatus_RPTEntity : BaseEntity
    {
        #region Properties


        private Int64 _BuyerBookSpaceID;
        private Int64 _ReferenceID;
        private Int64 _ProjectID;
        private Int64 _ProjectFloorUnitID;
        private String _BookingNote;
        private Boolean _IsLandOwner;
        private Boolean _IsApprovedByManagement;
        private Int64 _BookingStatusID;
        private Int64 _CreatedByEmployeeID;
        private String _IP;
        private DateTime _CreateDate;
        private String _ContactFullName;
        private String _Designation;
        private String _MobileNo;
        private String _Email;
        private String _PresentAddress;
        private Int64? _LeadGeneratedByEmployeeID;
        private Int64? _LeadManagedByOneEmployeeID;
        private Int64? _LeadManagedByTwoEmployeeID;
        private DateTime? _LeadConversionDate;
        private String _ProjectCode;
        private String _ProjectName;
        private String _ProjectFloorUnitName;
        private String _BookingStatus;


        [DataMember]
        public Int64 BuyerBookSpaceID
        {
            get { return _BuyerBookSpaceID; }
            set { _BuyerBookSpaceID = value; }
        }

        [DataMember]
        public Int64 ReferenceID
        {
            get { return _ReferenceID; }
            set { _ReferenceID = value; }
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
        public String BookingNote
        {
            get { return _BookingNote; }
            set { _BookingNote = value; }
        }

        [DataMember]
        public Boolean IsLandOwner
        {
            get { return _IsLandOwner; }
            set { _IsLandOwner = value; }
        }

        [DataMember]
        public Boolean IsApprovedByManagement
        {
            get { return _IsApprovedByManagement; }
            set { _IsApprovedByManagement = value; }
        }

        [DataMember]
        public Int64 BookingStatusID
        {
            get { return _BookingStatusID; }
            set { _BookingStatusID = value; }
        }

        [DataMember]
        public Int64 CreatedByEmployeeID
        {
            get { return _CreatedByEmployeeID; }
            set { _CreatedByEmployeeID = value; }
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
        public String ContactFullName
        {
            get { return _ContactFullName; }
            set { _ContactFullName = value; }
        }

        [DataMember]
        public String Designation
        {
            get { return _Designation; }
            set { _Designation = value; }
        }

        [DataMember]
        public String MobileNo
        {
            get { return _MobileNo; }
            set { _MobileNo = value; }
        }

        [DataMember]
        public String Email
        {
            get { return _Email; }
            set { _Email = value; }
        }

        [DataMember]
        public String PresentAddress
        {
            get { return _PresentAddress; }
            set { _PresentAddress = value; }
        }

        [DataMember]
        public Int64? LeadGeneratedByEmployeeID
        {
            get { return _LeadGeneratedByEmployeeID; }
            set { _LeadGeneratedByEmployeeID = value; }
        }

        [DataMember]
        public Int64? LeadManagedByOneEmployeeID
        {
            get { return _LeadManagedByOneEmployeeID; }
            set { _LeadManagedByOneEmployeeID = value; }
        }

        [DataMember]
        public Int64? LeadManagedByTwoEmployeeID
        {
            get { return _LeadManagedByTwoEmployeeID; }
            set { _LeadManagedByTwoEmployeeID = value; }
        }

        [DataMember]
        public DateTime? LeadConversionDate
        {
            get { return _LeadConversionDate; }
            set { _LeadConversionDate = value; }
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
        public String ProjectFloorUnitName
        {
            get { return _ProjectFloorUnitName; }
            set { _ProjectFloorUnitName = value; }
        }

        [DataMember]
        public String BookingStatus
        {
            get { return _BookingStatus; }
            set { _BookingStatus = value; }
        }

        [XmlIgnore()]
        public override bool IsNew
        {
            [DebuggerStepThrough()]
            get
            {
                return (BuyerBookSpaceID <= 0);
            }
        }


        #endregion

        #region Constructor

        public CRMBookingStatus_RPTEntity() : base()
        {
        }

        #endregion

        #region Constant

        public const String FLD_NAME_BuyerBookSpaceID = "BuyerBookSpaceID";
        public const String FLD_NAME_ReferenceID = "ReferenceID";
        public const String FLD_NAME_ProjectID = "ProjectID";
        public const String FLD_NAME_ProjectFloorUnitID = "ProjectFloorUnitID";
        public const String FLD_NAME_BookingNote = "BookingNote";
        public const String FLD_NAME_IsLandOwner = "IsLandOwner";
        public const String FLD_NAME_IsApprovedByManagement = "IsApprovedByManagement";
        public const String FLD_NAME_BookingStatusID = "BookingStatusID";
        public const String FLD_NAME_CreatedByEmployeeID = "CreatedByEmployeeID";
        public const String FLD_NAME_IP = "IP";
        public const String FLD_NAME_CreateDate = "CreateDate";
        public const String FLD_NAME_ContactFullName = "ContactFullName";
        public const String FLD_NAME_Designation = "Designation";
        public const String FLD_NAME_MobileNo = "MobileNo";
        public const String FLD_NAME_Email = "Email";
        public const String FLD_NAME_PresentAddress = "PresentAddress";
        public const String FLD_NAME_LeadGeneratedByEmployeeID = "LeadGeneratedByEmployeeID";
        public const String FLD_NAME_LeadManagedByOneEmployeeID = "LeadManagedByOneEmployeeID";
        public const String FLD_NAME_LeadManagedByTwoEmployeeID = "LeadManagedByTwoEmployeeID";
        public const String FLD_NAME_LeadConversionDate = "LeadConversionDate";
        public const String FLD_NAME_ProjectCode = "ProjectCode";
        public const String FLD_NAME_ProjectName = "ProjectName";
        public const String FLD_NAME_ProjectFloorUnitName = "ProjectFloorUnitName";
        public const String FLD_NAME_BookingStatus = "BookingStatus";

        #endregion
    }
}
