// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 13-Dec-2012, 11:43:49




using System;
using System.Diagnostics;
using System.ServiceModel;
using System.Runtime.Serialization;
using System.Collections.Generic;
using System.Xml.Serialization;


namespace Bay.ERP.Common.BusinessEntities
{
    [Serializable]
    [DataContract(Name = "MDAccountPaybleStatementDetailCategory", Namespace = "http://www.e-p-m-s.com/types")]
    public partial class MDAccountPaybleStatementDetailCategoryEntity : BaseEntity
    {
        #region Properties


        private Int64 _AccountPaybleStatementDetailCategoryID;
        private String _Name;
        private Boolean _IsRemoved;


        [DataMember]
        public Int64 AccountPaybleStatementDetailCategoryID
        {
            get { return _AccountPaybleStatementDetailCategoryID; }
            set { _AccountPaybleStatementDetailCategoryID = value; }
        }

        [DataMember]
        public String Name
        {
            get { return _Name; }
            set { _Name = value; }
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
                return (AccountPaybleStatementDetailCategoryID <= 0);
            }
        }


        #endregion

        #region Constructor

        public MDAccountPaybleStatementDetailCategoryEntity() : base()
        {
        }

        #endregion

        #region Constant

        public const String FLD_NAME_AccountPaybleStatementDetailCategoryID = "AccountPaybleStatementDetailCategoryID";
        public const String FLD_NAME_Name = "Name";
        public const String FLD_NAME_IsRemoved = "IsRemoved";

        #endregion
    }
}
