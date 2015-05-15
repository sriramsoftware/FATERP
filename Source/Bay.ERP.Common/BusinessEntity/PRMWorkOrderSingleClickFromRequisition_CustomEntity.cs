// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 12-Sep-2013, 02:31:14




using System;
using System.Diagnostics;
using System.ServiceModel;
using System.Runtime.Serialization;
using System.Collections.Generic;
using System.Xml.Serialization;


namespace Bay.ERP.Common.BusinessEntities
{
    [Serializable]
    [DataContract(Name = "PRMWorkOrderSingleClickFromRequisition_Custom", Namespace = "http://www.e-p-m-s.com/types")]
    public partial class PRMWorkOrderSingleClickFromRequisition_CustomEntity : BaseEntity
    {
        #region Properties


        private Int64? _WorkOrderID;


        [DataMember]
        public Int64? WorkOrderID
        {
            get { return _WorkOrderID; }
            set { _WorkOrderID = value; }
        }

        [XmlIgnore()]
        public override bool IsNew
        {
            [DebuggerStepThrough()]
            get
            {
                return (WorkOrderID <= 0);
            }
        }


        #endregion

        #region Constructor

        public PRMWorkOrderSingleClickFromRequisition_CustomEntity() : base()
        {
        }

        #endregion

        #region Constant

        public const String FLD_NAME_WorkOrderID = "WorkOrderID";

        #endregion
    }
}
