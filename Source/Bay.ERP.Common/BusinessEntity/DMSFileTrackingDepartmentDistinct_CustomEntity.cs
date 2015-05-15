// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 29-Sep-2012, 02:08:47




using System;
using System.Diagnostics;
using System.ServiceModel;
using System.Runtime.Serialization;
using System.Collections.Generic;
using System.Xml.Serialization;


namespace Bay.ERP.Common.BusinessEntities
{
    [Serializable]
    [DataContract(Name = "DMSFileTrackingDepartmentDistinct_Custom", Namespace = "http://www.e-p-m-s.com/types")]
    public partial class DMSFileTrackingDepartmentDistinct_CustomEntity : BaseEntity
    {
        #region Properties


        private Int64 _DepartmentID;
        private String _DepartmentName;


        [DataMember]
        public Int64 DepartmentID
        {
            get { return _DepartmentID; }
            set { _DepartmentID = value; }
        }

        [DataMember]
        public String DepartmentName
        {
            get { return _DepartmentName; }
            set { _DepartmentName = value; }
        }

        [XmlIgnore()]
        public override bool IsNew
        {
            [DebuggerStepThrough()]
            get
            {
                return (DepartmentID <= 0);
            }
        }


        #endregion

        #region Constructor

        public DMSFileTrackingDepartmentDistinct_CustomEntity() : base()
        {
        }

        #endregion

        #region Constant

        public const String FLD_NAME_DepartmentID = "DepartmentID";
        public const String FLD_NAME_DepartmentName = "DepartmentName";

        #endregion
    }
}
