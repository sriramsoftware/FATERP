// Copyright and All Rights Reserved by
//B2B Solution, Bangladesh;
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 28-Feb-2012, 11:55:12




using System;
using System.Diagnostics;
using System.ServiceModel;
using System.Runtime.Serialization;
using System.Collections.Generic;
using System.Xml.Serialization;


namespace Bay.ERP.Common.BusinessEntities
{
    [Serializable]
    [DataContract(Name = "CMConstructionToolDetail_Detailed", Namespace = "http://www.e-p-m-s.com/types")]
    public partial class CMConstructionToolDetail_DetailedEntity : BaseEntity
    {
        #region Properties


        private Int64 _ConstructionToolDetailID;
        private Int64 _ConstructionToolID;
        private String _Specification;
        private Int64 _ConstructionToolWorkingConditionID;
        private Int64? _BrandID;
        private Int64? _SupplierID;
        private DateTime? _NextMaintananceDate;
        private String _UsedOrHandeledBy;
        private Int64? _ProjectID;
        private String _Remarks;
        private Boolean _IsRemoved;
        private String _ConstructionToolToolName;
        private String _ConstructionToolWorkingConditionName;
        private String _MDBrandBrandName;
        private String _SupplierName;
        private String _ProjectName;
        private Int64? _RowNumber;


        [DataMember]
        public Int64 ConstructionToolDetailID
        {
            get { return _ConstructionToolDetailID; }
            set { _ConstructionToolDetailID = value; }
        }

        [DataMember]
        public Int64 ConstructionToolID
        {
            get { return _ConstructionToolID; }
            set { _ConstructionToolID = value; }
        }

        [DataMember]
        public String Specification
        {
            get { return _Specification; }
            set { _Specification = value; }
        }

        [DataMember]
        public Int64 ConstructionToolWorkingConditionID
        {
            get { return _ConstructionToolWorkingConditionID; }
            set { _ConstructionToolWorkingConditionID = value; }
        }

        [DataMember]
        public Int64? BrandID
        {
            get { return _BrandID; }
            set { _BrandID = value; }
        }

        [DataMember]
        public Int64? SupplierID
        {
            get { return _SupplierID; }
            set { _SupplierID = value; }
        }

        [DataMember]
        public DateTime? NextMaintananceDate
        {
            get { return _NextMaintananceDate; }
            set { _NextMaintananceDate = value; }
        }

        [DataMember]
        public String UsedOrHandeledBy
        {
            get { return _UsedOrHandeledBy; }
            set { _UsedOrHandeledBy = value; }
        }

        [DataMember]
        public Int64? ProjectID
        {
            get { return _ProjectID; }
            set { _ProjectID = value; }
        }

        [DataMember]
        public String Remarks
        {
            get { return _Remarks; }
            set { _Remarks = value; }
        }

        [DataMember]
        public Boolean IsRemoved
        {
            get { return _IsRemoved; }
            set { _IsRemoved = value; }
        }

        [DataMember]
        public String ConstructionToolToolName
        {
            get { return _ConstructionToolToolName; }
            set { _ConstructionToolToolName = value; }
        }

        [DataMember]
        public String ConstructionToolWorkingConditionName
        {
            get { return _ConstructionToolWorkingConditionName; }
            set { _ConstructionToolWorkingConditionName = value; }
        }

        [DataMember]
        public String MDBrandBrandName
        {
            get { return _MDBrandBrandName; }
            set { _MDBrandBrandName = value; }
        }

        [DataMember]
        public String SupplierName
        {
            get { return _SupplierName; }
            set { _SupplierName = value; }
        }

        [DataMember]
        public String ProjectName
        {
            get { return _ProjectName; }
            set { _ProjectName = value; }
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
                return (ConstructionToolDetailID <= 0);
            }
        }


        #endregion

        #region Constructor

        public CMConstructionToolDetail_DetailedEntity() : base()
        {
        }

        #endregion

        #region Constant

        public const String FLD_NAME_ConstructionToolDetailID = "ConstructionToolDetailID";
        public const String FLD_NAME_ConstructionToolID = "ConstructionToolID";
        public const String FLD_NAME_Specification = "Specification";
        public const String FLD_NAME_ConstructionToolWorkingConditionID = "ConstructionToolWorkingConditionID";
        public const String FLD_NAME_BrandID = "BrandID";
        public const String FLD_NAME_SupplierID = "SupplierID";
        public const String FLD_NAME_NextMaintananceDate = "NextMaintananceDate";
        public const String FLD_NAME_UsedOrHandeledBy = "UsedOrHandeledBy";
        public const String FLD_NAME_ProjectID = "ProjectID";
        public const String FLD_NAME_Remarks = "Remarks";
        public const String FLD_NAME_IsRemoved = "IsRemoved";
        public const String FLD_NAME_ConstructionToolToolName = "ConstructionToolToolName";
        public const String FLD_NAME_ConstructionToolWorkingConditionName = "ConstructionToolWorkingConditionName";
        public const String FLD_NAME_MDBrandBrandName = "MDBrandBrandName";
        public const String FLD_NAME_SupplierName = "SupplierName";
        public const String FLD_NAME_ProjectName = "ProjectName";
        public const String FLD_NAME_RowNumber = "RowNumber";

        #endregion
    }
}
