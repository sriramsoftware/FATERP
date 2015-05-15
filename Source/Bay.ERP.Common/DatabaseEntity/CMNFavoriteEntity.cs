// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 28-Mar-2013, 05:31:27




using System;
using System.Diagnostics;
using System.ServiceModel;
using System.Runtime.Serialization;
using System.Collections.Generic;
using System.Xml.Serialization;


namespace Bay.ERP.Common.BusinessEntities
{
    [Serializable]
    [DataContract(Name = "CMNFavorite", Namespace = "http://www.e-p-m-s.com/types")]
    public partial class CMNFavoriteEntity : BaseEntity
    {
        #region Properties


        private Int64 _FavoriteID;
        private Int64 _ProcessCategoryID;
        private Int64 _ReferenceID;
        private String _Remarks;
        private DateTime _FavoriteDate;
        private Int64 _EmployeeID;
        private Boolean _IsRemoved;


        [DataMember]
        public Int64 FavoriteID
        {
            get { return _FavoriteID; }
            set { _FavoriteID = value; }
        }

        [DataMember]
        public Int64 ProcessCategoryID
        {
            get { return _ProcessCategoryID; }
            set { _ProcessCategoryID = value; }
        }

        [DataMember]
        public Int64 ReferenceID
        {
            get { return _ReferenceID; }
            set { _ReferenceID = value; }
        }

        [DataMember]
        public String Remarks
        {
            get { return _Remarks; }
            set { _Remarks = value; }
        }

        [DataMember]
        public DateTime FavoriteDate
        {
            get { return _FavoriteDate; }
            set { _FavoriteDate = value; }
        }

        [DataMember]
        public Int64 EmployeeID
        {
            get { return _EmployeeID; }
            set { _EmployeeID = value; }
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
                return (FavoriteID <= 0);
            }
        }


        #endregion

        #region Constructor

        public CMNFavoriteEntity() : base()
        {
        }

        #endregion

        #region Constant

        public const String FLD_NAME_FavoriteID = "FavoriteID";
        public const String FLD_NAME_ProcessCategoryID = "ProcessCategoryID";
        public const String FLD_NAME_ReferenceID = "ReferenceID";
        public const String FLD_NAME_Remarks = "Remarks";
        public const String FLD_NAME_FavoriteDate = "FavoriteDate";
        public const String FLD_NAME_EmployeeID = "EmployeeID";
        public const String FLD_NAME_IsRemoved = "IsRemoved";

        #endregion
    }
}
