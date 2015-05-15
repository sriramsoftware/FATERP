// Copyright and All Rights Reserved by
//B2B Solution, Bangladesh;
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 16-Apr-2012, 04:09:50




using System;
using System.Diagnostics;
using System.ServiceModel;
using System.Runtime.Serialization;
using System.Collections.Generic;
using System.Xml.Serialization;


namespace Bay.ERP.Common.BusinessEntities
{
    [Serializable]
    [DataContract(Name = "MDItemGroup", Namespace = "http://www.e-p-m-s.com/types")]
    public partial class MDItemGroupEntity : BaseEntity
    {
        #region Properties


        private Int64 _ItemGroupID;
        private String _GroupName;
        private String _Description;
        private Boolean _IsRemoved;


        [DataMember]
        public Int64 ItemGroupID
        {
            get { return _ItemGroupID; }
            set { _ItemGroupID = value; }
        }

        [DataMember]
        public String GroupName
        {
            get { return _GroupName; }
            set { _GroupName = value; }
        }

        [DataMember]
        public String Description
        {
            get { return _Description; }
            set { _Description = value; }
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
                return (ItemGroupID <= 0);
            }
        }


        #endregion

        #region Constructor

        public MDItemGroupEntity() : base()
        {
        }

        #endregion

        #region Constant

        public const String FLD_NAME_ItemGroupID = "ItemGroupID";
        public const String FLD_NAME_GroupName = "GroupName";
        public const String FLD_NAME_Description = "Description";
        public const String FLD_NAME_IsRemoved = "IsRemoved";

        #endregion
    }
}
