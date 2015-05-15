// Copyright and All Rights Reserved by
//B2B Solution, Bangladesh;
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 22-May-2012, 04:02:34




using System;
using System.Diagnostics;
using System.ServiceModel;
using System.Runtime.Serialization;
using System.Collections.Generic;
using System.Xml.Serialization;


namespace Bay.ERP.Common.BusinessEntities
{
    [Serializable]
    [DataContract(Name = "MDFloor", Namespace = "http://www.e-p-m-s.com/types")]
    public partial class MDFloorEntity : BaseEntity
    {
        #region Properties


        private Int64 _FloorID;
        private Int64 _FloorCategoryID;
        private String _Name;
        private String _Description;
        private Boolean _IsRemoved;


        [DataMember]
        public Int64 FloorID
        {
            get { return _FloorID; }
            set { _FloorID = value; }
        }

        [DataMember]
        public Int64 FloorCategoryID
        {
            get { return _FloorCategoryID; }
            set { _FloorCategoryID = value; }
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

        [XmlIgnore()]
        public override bool IsNew
        {
            [DebuggerStepThrough()]
            get
            {
                return (FloorID <= 0);
            }
        }


        #endregion

        #region Constructor

        public MDFloorEntity() : base()
        {
        }

        #endregion

        #region Constant

        public const String FLD_NAME_FloorID = "FloorID";
        public const String FLD_NAME_FloorCategoryID = "FloorCategoryID";
        public const String FLD_NAME_Name = "Name";
        public const String FLD_NAME_Description = "Description";
        public const String FLD_NAME_IsRemoved = "IsRemoved";

        #endregion
    }
}
