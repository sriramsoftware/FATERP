// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 07-May-2013, 12:02:45




using System;
using System.Diagnostics;
using System.ServiceModel;
using System.Runtime.Serialization;
using System.Collections.Generic;
using System.Xml.Serialization;


namespace Bay.ERP.Common.BusinessEntities
{
    [Serializable]
    [DataContract(Name = "ACAccountGroup", Namespace = "http://www.e-p-m-s.com/types")]
    public partial class ACAccountGroupEntity : BaseEntity
    {
        #region Properties


        private Int64 _AccountGroupID;
        private Int64? _ParentAccountGroupID;
        private Int64 _ClassID;
        private String _AccountGroupCode;
        private String _Name;
        private String _Description;
        private Boolean _IsInActive;
        private Boolean _IsRemoved;


        [DataMember]
        public Int64 AccountGroupID
        {
            get { return _AccountGroupID; }
            set { _AccountGroupID = value; }
        }

        [DataMember]
        public Int64? ParentAccountGroupID
        {
            get { return _ParentAccountGroupID; }
            set { _ParentAccountGroupID = value; }
        }

        [DataMember]
        public Int64 ClassID
        {
            get { return _ClassID; }
            set { _ClassID = value; }
        }

        [DataMember]
        public String AccountGroupCode
        {
            get { return _AccountGroupCode; }
            set { _AccountGroupCode = value; }
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
        public Boolean IsInActive
        {
            get { return _IsInActive; }
            set { _IsInActive = value; }
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
                return (AccountGroupID <= 0);
            }
        }


        #endregion

        #region Constructor

        public ACAccountGroupEntity() : base()
        {
        }

        #endregion

        #region Constant

        public const String FLD_NAME_AccountGroupID = "AccountGroupID";
        public const String FLD_NAME_ParentAccountGroupID = "ParentAccountGroupID";
        public const String FLD_NAME_ClassID = "ClassID";
        public const String FLD_NAME_AccountGroupCode = "AccountGroupCode";
        public const String FLD_NAME_Name = "Name";
        public const String FLD_NAME_Description = "Description";
        public const String FLD_NAME_IsInActive = "IsInActive";
        public const String FLD_NAME_IsRemoved = "IsRemoved";

        #endregion
    }
}
