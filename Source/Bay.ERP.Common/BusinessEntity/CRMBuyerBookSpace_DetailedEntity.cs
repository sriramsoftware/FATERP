// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 08-Apr-2013, 09:47:50




using System;
using System.Diagnostics;
using System.ServiceModel;
using System.Runtime.Serialization;
using System.Collections.Generic;
using System.Xml.Serialization;


namespace Bay.ERP.Common.BusinessEntities
{
    [Serializable]
    [DataContract(Name = "CRMBuyerBookSpace_Detailed", Namespace = "http://www.e-p-m-s.com/types")]
    public partial class CRMBuyerBookSpace_DetailedEntity : BaseEntity
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
        private String _ProjectName;
        private String _BDProjectFloorUnitProjectFloorUnitName;
        private String _BookingStatusName;
        private String _CreatedByMemberFullName;
        private String _ImageUrl;
        private Int64? _RowNumber;


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
        public String ProjectName
        {
            get { return _ProjectName; }
            set { _ProjectName = value; }
        }

        [DataMember]
        public String BDProjectFloorUnitProjectFloorUnitName
        {
            get { return _BDProjectFloorUnitProjectFloorUnitName; }
            set { _BDProjectFloorUnitProjectFloorUnitName = value; }
        }

        [DataMember]
        public String BookingStatusName
        {
            get { return _BookingStatusName; }
            set { _BookingStatusName = value; }
        }

        [DataMember]
        public String CreatedByMemberFullName
        {
            get { return _CreatedByMemberFullName; }
            set { _CreatedByMemberFullName = value; }
        }

        [DataMember]
        public String ImageUrl
        {
            get { return _ImageUrl; }
            set { _ImageUrl = value; }
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
                return (BuyerBookSpaceID <= 0);
            }
        }


        #endregion

        #region Constructor

        public CRMBuyerBookSpace_DetailedEntity() : base()
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
        public const String FLD_NAME_ProjectName = "ProjectName";
        public const String FLD_NAME_BDProjectFloorUnitProjectFloorUnitName = "BDProjectFloorUnitProjectFloorUnitName";
        public const String FLD_NAME_BookingStatusName = "BookingStatusName";
        public const String FLD_NAME_CreatedByMemberFullName = "CreatedByMemberFullName";
        public const String FLD_NAME_ImageUrl = "ImageUrl";
        public const String FLD_NAME_RowNumber = "RowNumber";

        #endregion
    }
}
