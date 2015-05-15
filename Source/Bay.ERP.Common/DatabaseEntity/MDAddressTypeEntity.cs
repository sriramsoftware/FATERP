// Copyright and All Rights Reserved by
//B2B Solution, Bangladesh;
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 05-Jan-2012, 11:52:45




using System;
using System.Diagnostics;
using System.ServiceModel;
using System.Runtime.Serialization;
using System.Collections.Generic;
using System.Xml.Serialization;


namespace Bay.ERP.Common.BusinessEntities
{
    [Serializable]
    [DataContract(Name = "MDAddressType", Namespace = "http://www.e-p-m-s.com/types")]
    public partial class MDAddressTypeEntity : BaseEntity
    {
        #region Properties


        private Int64 _AddressTypeID;
        private String _Name;
        private String _Description;


        [DataMember]
        public Int64 AddressTypeID
        {
            get { return _AddressTypeID; }
            set { _AddressTypeID = value; }
        }

        [DataMember]
        public String Name
        {
            get { return _Name; }
            set { _Name = value; }
        }

        [DataMember]
        public String Description
        {
            get { return _Description; }
            set { _Description = value; }
        }

        [XmlIgnore()]
        public override bool IsNew
        {
            [DebuggerStepThrough()]
            get
            {
                return (AddressTypeID <= 0);
            }
        }


        #endregion

        #region Constructor

        public MDAddressTypeEntity() : base()
        {
        }

        #endregion

        #region Constant

        public const String FLD_NAME_AddressTypeID = "AddressTypeID";
        public const String FLD_NAME_Name = "Name";
        public const String FLD_NAME_Description = "Description";

        #endregion
    }
}
