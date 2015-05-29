// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 28-May-2015, 10:46:54




using System;
using System.Diagnostics;
using System.ServiceModel;
using System.Runtime.Serialization;
using System.Collections.Generic;
using System.Xml.Serialization;


namespace Bay.ERP.Common.BusinessEntities
{
    [Serializable]
    [DataContract(Name = "MDOperatorAddressType", Namespace = "http://www.e-p-m-s.com/types")]
    public partial class MDOperatorAddressTypeEntity : BaseEntity
    {
        #region Properties


        private Int64 _OperatorAddressTypeID;
        private String _Name;
        private String _Descripton;
        private Boolean _IsRemoved;


        [DataMember]
        public Int64 OperatorAddressTypeID
        {
            get { return _OperatorAddressTypeID; }
            set { _OperatorAddressTypeID = value; }
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
                return (OperatorAddressTypeID <= 0);
            }
        }


        #endregion

        #region Constructor

        public MDOperatorAddressTypeEntity() : base()
        {
        }

        #endregion

        #region Constant

        public const String FLD_NAME_OperatorAddressTypeID = "OperatorAddressTypeID";
        public const String FLD_NAME_Name = "Name";
        public const String FLD_NAME_Descripton = "Descripton";
        public const String FLD_NAME_IsRemoved = "IsRemoved";

        #endregion
    }
}
