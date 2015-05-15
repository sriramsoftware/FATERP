// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 22-May-2013, 11:39:55




using System;
using System.Diagnostics;
using System.ServiceModel;
using System.Runtime.Serialization;
using System.Collections.Generic;
using System.Xml.Serialization;


namespace Bay.ERP.Common.BusinessEntities
{
    [Serializable]
    [DataContract(Name = "ACAccount_Detailed", Namespace = "http://www.e-p-m-s.com/types")]
    public partial class ACAccount_DetailedEntity : BaseEntity
    {
        #region Properties


        private Int64 _AccountID;
        private Int64 _AccountGroupID;
        private String _AccountCode;
        private String _AccountCode2;
        private String _AccountName;
        private String _AccountNameExceptSpecialCharacter;
        private String _Description;
        private Int64 _AccountStatusID;
        private Boolean _IsRemoved;
        private String _AccountGroupName;
        private String _AccountStatusName;
        private Int64? _RowNumber;


        [DataMember]
        public Int64 AccountID
        {
            get { return _AccountID; }
            set { _AccountID = value; }
        }

        [DataMember]
        public Int64 AccountGroupID
        {
            get { return _AccountGroupID; }
            set { _AccountGroupID = value; }
        }

        [DataMember]
        public String AccountCode
        {
            get { return _AccountCode; }
            set { _AccountCode = value; }
        }

        [DataMember]
        public String AccountCode2
        {
            get { return _AccountCode2; }
            set { _AccountCode2 = value; }
        }

        [DataMember]
        public String AccountName
        {
            get { return _AccountName; }
            set { _AccountName = value; }
        }

        [DataMember]
        public String AccountNameExceptSpecialCharacter
        {
            get { return _AccountNameExceptSpecialCharacter; }
            set { _AccountNameExceptSpecialCharacter = value; }
        }

        [DataMember]
        public String Description
        {
            get { return _Description; }
            set { _Description = value; }
        }

        [DataMember]
        public Int64 AccountStatusID
        {
            get { return _AccountStatusID; }
            set { _AccountStatusID = value; }
        }

        [DataMember]
        public Boolean IsRemoved
        {
            get { return _IsRemoved; }
            set { _IsRemoved = value; }
        }

        [DataMember]
        public String AccountGroupName
        {
            get { return _AccountGroupName; }
            set { _AccountGroupName = value; }
        }

        [DataMember]
        public String AccountStatusName
        {
            get { return _AccountStatusName; }
            set { _AccountStatusName = value; }
        }

        [DataMember]
        public Int64? RowNumber
        {
            get { return _RowNumber; }
            set { _RowNumber = value; }
        }

        [XmlIgnore()]
        public override bool IsNew
        {
            [DebuggerStepThrough()]
            get
            {
                return (AccountID <= 0);
            }
        }


        #endregion

        #region Constructor

        public ACAccount_DetailedEntity() : base()
        {
        }

        #endregion

        #region Constant

        public const String FLD_NAME_AccountID = "AccountID";
        public const String FLD_NAME_AccountGroupID = "AccountGroupID";
        public const String FLD_NAME_AccountCode = "AccountCode";
        public const String FLD_NAME_AccountCode2 = "AccountCode2";
        public const String FLD_NAME_AccountName = "AccountName";
        public const String FLD_NAME_AccountNameExceptSpecialCharacter = "AccountNameExceptSpecialCharacter";
        public const String FLD_NAME_Description = "Description";
        public const String FLD_NAME_AccountStatusID = "AccountStatusID";
        public const String FLD_NAME_IsRemoved = "IsRemoved";
        public const String FLD_NAME_AccountGroupName = "AccountGroupName";
        public const String FLD_NAME_AccountStatusName = "AccountStatusName";
        public const String FLD_NAME_RowNumber = "RowNumber";

        #endregion
    }
}
