// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 13-Jan-2013, 05:19:48




using System;
using System.Diagnostics;
using System.ServiceModel;
using System.Runtime.Serialization;
using System.Collections.Generic;
using System.Xml.Serialization;


namespace Bay.ERP.Common.BusinessEntities
{
    [Serializable]
    [DataContract(Name = "ACCPrePayableStatementDistinct_Custom", Namespace = "http://www.e-p-m-s.com/types")]
    public partial class ACCPrePayableStatementDistinct_CustomEntity : BaseEntity
    {
        #region Properties


        private Int64 _PrePayableStatementID;
        private String _Ref;
        private Boolean _IsLocked;


        [DataMember]
        public Int64 PrePayableStatementID
        {
            get { return _PrePayableStatementID; }
            set { _PrePayableStatementID = value; }
        }

        [DataMember]
        public String Ref
        {
            get { return _Ref; }
            set { _Ref = value; }
        }

        [DataMember]
        public Boolean IsLocked
        {
            get { return _IsLocked; }
            set { _IsLocked = value; }
        }

        [XmlIgnore()]
        public override bool IsNew
        {
            [DebuggerStepThrough()]
            get
            {
                return (PrePayableStatementID <= 0);
            }
        }


        #endregion

        #region Constructor

        public ACCPrePayableStatementDistinct_CustomEntity() : base()
        {
        }

        #endregion

        #region Constant

        public const String FLD_NAME_PrePayableStatementID = "PrePayableStatementID";
        public const String FLD_NAME_Ref = "Ref";
        public const String FLD_NAME_IsLocked = "IsLocked";

        #endregion
    }
}
