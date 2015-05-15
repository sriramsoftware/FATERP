// Copyright and All Rights Reserved by
//B2B Solution, Bangladesh;
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 25-Jan-2012, 03:00:49




using System;
using System.Diagnostics;
using System.ServiceModel;
using System.Runtime.Serialization;
using System.Collections.Generic;
using System.Xml.Serialization;


namespace Bay.ERP.Common.BusinessEntities
{
    [Serializable]
    [DataContract(Name = "CMConstructionTool", Namespace = "http://www.e-p-m-s.com/types")]
    public partial class CMConstructionToolEntity : BaseEntity
    {
        #region Properties


        private Int64 _ConstructionToolID;
        private Int64? _ConstructionToolCategoryID;
        private String _ToolName;
        private Int64? _UnitID;
        private Boolean _IsRemoved;


        [DataMember]
        public Int64 ConstructionToolID
        {
            get { return _ConstructionToolID; }
            set { _ConstructionToolID = value; }
        }

        [DataMember]
        public Int64? ConstructionToolCategoryID
        {
            get { return _ConstructionToolCategoryID; }
            set { _ConstructionToolCategoryID = value; }
        }

        [DataMember]
        public String ToolName
        {
            get { return _ToolName; }
            set { _ToolName = value; }
        }

        [DataMember]
        public Int64? UnitID
        {
            get { return _UnitID; }
            set { _UnitID = value; }
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
                return (ConstructionToolID <= 0);
            }
        }


        #endregion

        #region Constructor

        public CMConstructionToolEntity() : base()
        {
        }

        #endregion

        #region Constant

        public const String FLD_NAME_ConstructionToolID = "ConstructionToolID";
        public const String FLD_NAME_ConstructionToolCategoryID = "ConstructionToolCategoryID";
        public const String FLD_NAME_ToolName = "ToolName";
        public const String FLD_NAME_UnitID = "UnitID";
        public const String FLD_NAME_IsRemoved = "IsRemoved";

        #endregion
    }
}
