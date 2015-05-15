// Copyright and All Rights Reserved by
//B2B Solution, Bangladesh;
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 31-Dec-2011, 05:48:38




using System;
using System.Diagnostics;
using System.ServiceModel;
using System.Runtime.Serialization;
using System.Collections.Generic;
using System.Xml.Serialization;


namespace Bay.ERP.Common.BusinessEntities
{
    [Serializable]
    [DataContract(Name = "MDScheduleCategory_Detailed", Namespace = "http://www.e-p-m-s.com/types")]
    public partial class MDScheduleCategory_DetailedEntity : BaseEntity
    {
        #region Properties


        private Int64 _ScheduleCategoryID;
        private Int64 _ScheduleIdentityCategoryID;
        private String _Name;
        private String _Description;
        private Boolean _IsRemoved;
        private String _ScheduleIdentityCategoryName;
        private Int64? _RowNumber;


        [DataMember]
        public Int64 ScheduleCategoryID
        {
            get { return _ScheduleCategoryID; }
            set { _ScheduleCategoryID = value; }
        }

        [DataMember]
        public Int64 ScheduleIdentityCategoryID
        {
            get { return _ScheduleIdentityCategoryID; }
            set { _ScheduleIdentityCategoryID = value; }
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
        public Boolean IsRemoved
        {
            get { return _IsRemoved; }
            set { _IsRemoved = value; }
        }

        [DataMember]
        public String ScheduleIdentityCategoryName
        {
            get { return _ScheduleIdentityCategoryName; }
            set { _ScheduleIdentityCategoryName = value; }
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
                return (ScheduleCategoryID <= 0);
            }
        }


        #endregion

        #region Constructor

        public MDScheduleCategory_DetailedEntity() : base()
        {
        }

        #endregion

        #region Constant

        public const String FLD_NAME_ScheduleCategoryID = "ScheduleCategoryID";
        public const String FLD_NAME_ScheduleIdentityCategoryID = "ScheduleIdentityCategoryID";
        public const String FLD_NAME_Name = "Name";
        public const String FLD_NAME_Description = "Description";
        public const String FLD_NAME_IsRemoved = "IsRemoved";
        public const String FLD_NAME_ScheduleIdentityCategoryName = "ScheduleIdentityCategoryName";
        public const String FLD_NAME_RowNumber = "RowNumber";

        #endregion
    }
}
