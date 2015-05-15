// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 22-Jan-2013, 05:23:47




using System;
using System.Diagnostics;
using System.ServiceModel;
using System.Runtime.Serialization;
using System.Collections.Generic;
using System.Xml.Serialization;


namespace Bay.ERP.Common.BusinessEntities
{
    [Serializable]
    [DataContract(Name = "ACClass_Detailed", Namespace = "http://www.e-p-m-s.com/types")]
    public partial class ACClass_DetailedEntity : BaseEntity
    {
        #region Properties


        private Int64 _ClassID;
        private Int64 _ClassTypeID;
        private String _Name;
        private String _Description;
        private Boolean _IsInActive;
        private Boolean _IsRemoved;
        private String _ClassTypeName;
        private Int64? _RowNumber;


        [DataMember]
        public Int64 ClassID
        {
            get { return _ClassID; }
            set { _ClassID = value; }
        }

        [DataMember]
        public Int64 ClassTypeID
        {
            get { return _ClassTypeID; }
            set { _ClassTypeID = value; }
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

        [DataMember]
        public String ClassTypeName
        {
            get { return _ClassTypeName; }
            set { _ClassTypeName = value; }
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
                return (ClassID <= 0);
            }
        }


        #endregion

        #region Constructor

        public ACClass_DetailedEntity() : base()
        {
        }

        #endregion

        #region Constant

        public const String FLD_NAME_ClassID = "ClassID";
        public const String FLD_NAME_ClassTypeID = "ClassTypeID";
        public const String FLD_NAME_Name = "Name";
        public const String FLD_NAME_Description = "Description";
        public const String FLD_NAME_IsInActive = "IsInActive";
        public const String FLD_NAME_IsRemoved = "IsRemoved";
        public const String FLD_NAME_ClassTypeName = "ClassTypeName";
        public const String FLD_NAME_RowNumber = "RowNumber";

        #endregion
    }
}
