// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 29-May-2015, 12:41:19




using System;
using System.Diagnostics;
using System.ServiceModel;
using System.Runtime.Serialization;
using System.Collections.Generic;
using System.Xml.Serialization;


namespace Bay.ERP.Common.BusinessEntities
{
    [Serializable]
    [DataContract(Name = "MDOperatorStatus", Namespace = "http://www.e-p-m-s.com/types")]
    public partial class MDOperatorStatusEntity : BaseEntity
    {
        #region Properties


        private Int64 _OperatorStatusID;
        private String _Name;
        private String _Descripton;
        private Boolean _IsRemoved;


        [DataMember]
        public Int64 OperatorStatusID
        {
            get { return _OperatorStatusID; }
            set { _OperatorStatusID = value; }
        }

        [DataMember]
        public String Name
        {
            get { return _Name; }
            set { _Name = value; }
        }

        [DataMember]
        public String Descripton
        {
            get { return _Descripton; }
            set { _Descripton = value; }
        }

        [DataMember]
        public Boolean IsRemoved
        {
            get { return _IsRemoved; }
            set { _IsRemoved = value; }
        }

        [XmlIgnore()]
        public override bool IsNew
        {
            [DebuggerStepThrough()]
            get
            {
                return (OperatorStatusID <= 0);
            }
        }


        #endregion

        #region Constructor

        public MDOperatorStatusEntity() : base()
        {
        }

        #endregion

        #region Constant

        public const String FLD_NAME_OperatorStatusID = "OperatorStatusID";
        public const String FLD_NAME_Name = "Name";
        public const String FLD_NAME_Descripton = "Descripton";
        public const String FLD_NAME_IsRemoved = "IsRemoved";

        #endregion
    }
}
