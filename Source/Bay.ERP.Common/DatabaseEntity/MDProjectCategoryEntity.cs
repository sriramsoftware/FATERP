// Copyright and All Rights Reserved by
//B2B Solution, Bangladesh;
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 08-Jan-2012, 04:47:08




using System;
using System.Diagnostics;
using System.ServiceModel;
using System.Runtime.Serialization;
using System.Collections.Generic;
using System.Xml.Serialization;


namespace Bay.ERP.Common.BusinessEntities
{
    [Serializable]
    [DataContract(Name = "MDProjectCategory", Namespace = "http://www.e-p-m-s.com/types")]
    public partial class MDProjectCategoryEntity : BaseEntity
    {
        #region Properties


        private Int64 _ProjectCategoryID;
        private String _Name;
        private Boolean _IsRemoved;


        [DataMember]
        public Int64 ProjectCategoryID
        {
            get { return _ProjectCategoryID; }
            set { _ProjectCategoryID = value; }
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
                return (ProjectCategoryID <= 0);
            }
        }


        #endregion

        #region Constructor

        public MDProjectCategoryEntity() : base()
        {
        }

        #endregion

        #region Constant

        public const String FLD_NAME_ProjectCategoryID = "ProjectCategoryID";
        public const String FLD_NAME_Name = "Name";
        public const String FLD_NAME_IsRemoved = "IsRemoved";

        #endregion
    }
}
