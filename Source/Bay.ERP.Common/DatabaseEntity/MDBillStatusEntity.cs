// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 08-Oct-2012, 10:27:43




using System;
using System.Diagnostics;
using System.ServiceModel;
using System.Runtime.Serialization;
using System.Collections.Generic;
using System.Xml.Serialization;


namespace Bay.ERP.Common.BusinessEntities
{
    [Serializable]
    [DataContract(Name = "MDBillStatus", Namespace = "http://www.e-p-m-s.com/types")]
    public partial class MDBillStatusEntity : BaseEntity
    {
        #region Properties


        private Int64 _BillStatusID;
        private String _Name;
        private String _Description;
        private Boolean _IsRemove;


        [DataMember]
        public Int64 BillStatusID
        {
            get { return _BillStatusID; }
            set { _BillStatusID = value; }
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

        [DataMember]
        public Boolean IsRemove
        {
            get { return _IsRemove; }
            set { _IsRemove = value; }
        }

        [XmlIgnore()]
        public override bool IsNew
        {
            [DebuggerStepThrough()]
            get
            {
                return (BillStatusID <= 0);
            }
        }


        #endregion

        #region Constructor

        public MDBillStatusEntity() : base()
        {
        }

        #endregion

        #region Constant

        public const String FLD_NAME_BillStatusID = "BillStatusID";
        public const String FLD_NAME_Name = "Name";
        public const String FLD_NAME_Description = "Description";
        public const String FLD_NAME_IsRemove = "IsRemove";

        #endregion
    }
}
