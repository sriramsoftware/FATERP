// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 15-Jan-2013, 11:24:12




using System;
using System.Diagnostics;
using System.ServiceModel;
using System.Runtime.Serialization;
using System.Collections.Generic;
using System.Xml.Serialization;


namespace Bay.ERP.Common.BusinessEntities
{
    [Serializable]
    [DataContract(Name = "APApprovedRequisitionForWOByPanelMember_Custom", Namespace = "http://www.e-p-m-s.com/types")]
    public partial class APApprovedRequisitionForWOByPanelMember_CustomEntity : BaseEntity
    {
        #region Properties


        private Int64? _ReferenceID;
        private Int64? _EmployeeID;


        [DataMember]
        public Int64? ReferenceID
        {
            get { return _ReferenceID; }
            set { _ReferenceID = value; }
        }

        [DataMember]
        public Int64? EmployeeID
        {
            get { return _EmployeeID; }
            set { _EmployeeID = value; }
        }

        [XmlIgnore()]
        public override bool IsNew
        {
            [DebuggerStepThrough()]
            get
            {
                return (ReferenceID <= 0);
            }
        }


        #endregion

        #region Constructor

        public APApprovedRequisitionForWOByPanelMember_CustomEntity() : base()
        {
        }

        #endregion

        #region Constant

        public const String FLD_NAME_ReferenceID = "ReferenceID";
        public const String FLD_NAME_EmployeeID = "EmployeeID";

        #endregion
    }
}
