// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 17-Dec-2012, 03:50:26




using System;
using System.Diagnostics;
using System.ServiceModel;
using System.Runtime.Serialization;
using System.Collections.Generic;
using System.Xml.Serialization;


namespace Bay.ERP.Common.BusinessEntities
{
    [Serializable]
    [DataContract(Name = "INV_MakeDefaultStoreUnit_Custom", Namespace = "http://www.e-p-m-s.com/types")]
    public partial class INV_MakeDefaultStoreUnit_CustomEntity : BaseEntity
    {
        #region Properties


        private Int32 _NoReturnID;


        [DataMember]
        public Int32 NoReturnID
        {
            get { return _NoReturnID; }
            set { _NoReturnID = value; }
        }

        [XmlIgnore()]
        public override bool IsNew
        {
            [DebuggerStepThrough()]
            get
            {
                return (NoReturnID <= 0);
            }
        }


        #endregion

        #region Constructor

        public INV_MakeDefaultStoreUnit_CustomEntity() : base()
        {
        }

        #endregion

        #region Constant

        public const String FLD_NAME_NoReturnID = "NoReturnID";

        #endregion
    }
}
