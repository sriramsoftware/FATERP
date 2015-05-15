// Copyright and All Rights Reserved by
//B2B Solution, Bangladesh;
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 05-May-2012, 04:25:28




using System;
using System.Diagnostics;
using System.ServiceModel;
using System.Runtime.Serialization;
using System.Collections.Generic;
using System.Xml.Serialization;


namespace Bay.ERP.Common.BusinessEntities
{
    [Serializable]
    [DataContract(Name = "BDProjectStatusDistinct_Custom", Namespace = "http://www.e-p-m-s.com/types")]
    public partial class BDProjectStatusDistinct_CustomEntity : BaseEntity
    {
        #region Properties


        private Int64 _ProjectStatusID;
        private Int64 _ProjectCategoryID;
        private String _ProjectStatusName;
        private String _ProjectCategoryName;


        [DataMember]
        public Int64 ProjectStatusID
        {
            get { return _ProjectStatusID; }
            set { _ProjectStatusID = value; }
        }

        [DataMember]
        public Int64 ProjectCategoryID
        {
            get { return _ProjectCategoryID; }
            set { _ProjectCategoryID = value; }
        }

        [DataMember]
        public String ProjectStatusName
        {
            get { return _ProjectStatusName; }
            set { _ProjectStatusName = value; }
        }

        [DataMember]
        public String ProjectCategoryName
        {
            get { return _ProjectCategoryName; }
            set { _ProjectCategoryName = value; }
        }

        [XmlIgnore()]
        public override bool IsNew
        {
            [DebuggerStepThrough()]
            get
            {
                return (ProjectStatusID <= 0);
            }
        }


        #endregion

        #region Constructor

        public BDProjectStatusDistinct_CustomEntity() : base()
        {
        }

        #endregion

        #region Constant

        public const String FLD_NAME_ProjectStatusID = "ProjectStatusID";
        public const String FLD_NAME_ProjectCategoryID = "ProjectCategoryID";
        public const String FLD_NAME_ProjectStatusName = "ProjectStatusName";
        public const String FLD_NAME_ProjectCategoryName = "ProjectCategoryName";

        #endregion
    }
}
