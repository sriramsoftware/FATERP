// Copyright and All Rights Reserved by
//B2B Solution, Bangladesh;
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 02-Jan-2012, 03:42:46




using System;
using System.Diagnostics;
using System.ServiceModel;
using System.Runtime.Serialization;
using System.Collections.Generic;
using System.Xml.Serialization;


namespace Bay.ERP.Common.BusinessEntities
{
    [Serializable]
    [DataContract(Name = "PRMPreBOQTemplateItemMapBulkInsert", Namespace = "http://www.e-p-m-s.com/types")]
    public partial class PRMPreBOQTemplateItemMapBulkInsertEntity : BaseEntity
    {
        #region Properties


        private Int64? _Result;


        [DataMember]
        public Int64? Result
        {
            get { return _Result; }
            set { _Result = value; }
        }

        [XmlIgnore()]
        public override bool IsNew
        {
            [DebuggerStepThrough()]
            get
            {
                return (Result <= 0);
            }
        }


        #endregion

        #region Constructor

        public PRMPreBOQTemplateItemMapBulkInsertEntity() : base()
        {
        }

        #endregion

        #region Constant

        public const String FLD_NAME_Result = "Result";

        #endregion
    }
}
