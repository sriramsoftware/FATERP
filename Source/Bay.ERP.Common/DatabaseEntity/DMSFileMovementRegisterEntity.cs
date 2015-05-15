// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 10-Sep-2012, 10:20:04




using System;
using System.Diagnostics;
using System.ServiceModel;
using System.Runtime.Serialization;
using System.Collections.Generic;
using System.Xml.Serialization;


namespace Bay.ERP.Common.BusinessEntities
{
    [Serializable]
    [DataContract(Name = "DMSFileMovementRegister", Namespace = "http://www.e-p-m-s.com/types")]
    public partial class DMSFileMovementRegisterEntity : BaseEntity
    {
        #region Properties


        private Int64 _FileMovementRegisterID;
        private Int64 _FileTrackingID;
        private Int64 _GivenToEmployeeID;
        private Int64 _GivenByEmployeeID;
        private DateTime _MovementDateTime;
        private String _FileMovementPlace;


        [DataMember]
        public Int64 FileMovementRegisterID
        {
            get { return _FileMovementRegisterID; }
            set { _FileMovementRegisterID = value; }
        }

        [DataMember]
        public Int64 FileTrackingID
        {
            get { return _FileTrackingID; }
            set { _FileTrackingID = value; }
        }

        [DataMember]
        public Int64 GivenToEmployeeID
        {
            get { return _GivenToEmployeeID; }
            set { _GivenToEmployeeID = value; }
        }

        [DataMember]
        public Int64 GivenByEmployeeID
        {
            get { return _GivenByEmployeeID; }
            set { _GivenByEmployeeID = value; }
        }

        [DataMember]
        public DateTime MovementDateTime
        {
            get { return _MovementDateTime; }
            set { _MovementDateTime = value; }
        }

        [DataMember]
        public String FileMovementPlace
        {
            get { return _FileMovementPlace; }
            set { _FileMovementPlace = value; }
        }

        [XmlIgnore()]
        public override bool IsNew
        {
            [DebuggerStepThrough()]
            get
            {
                return (FileMovementRegisterID <= 0);
            }
        }


        #endregion

        #region Constructor

        public DMSFileMovementRegisterEntity() : base()
        {
        }

        #endregion

        #region Constant

        public const String FLD_NAME_FileMovementRegisterID = "FileMovementRegisterID";
        public const String FLD_NAME_FileTrackingID = "FileTrackingID";
        public const String FLD_NAME_GivenToEmployeeID = "GivenToEmployeeID";
        public const String FLD_NAME_GivenByEmployeeID = "GivenByEmployeeID";
        public const String FLD_NAME_MovementDateTime = "MovementDateTime";
        public const String FLD_NAME_FileMovementPlace = "FileMovementPlace";

        #endregion
    }
}
