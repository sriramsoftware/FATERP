// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 19-Dec-2013, 12:42:28




using System;
using System.Diagnostics;
using System.ServiceModel;
using System.Runtime.Serialization;
using System.Collections.Generic;
using System.Xml.Serialization;


namespace Bay.ERP.Common.BusinessEntities
{
    [Serializable]
    [DataContract(Name = "MDHolidayCategory", Namespace = "http://www.e-p-m-s.com/types")]
    public partial class MDHolidayCategoryEntity : BaseEntity
    {
        #region Properties


        private Int64 _HolidayCategoryID;
        private String _Name;
        private String _Description;
        private String _ColorName;
        private String _ColorCode;
        private String _Remarks;
        private Boolean _IsRemoved;


        [DataMember]
        public Int64 HolidayCategoryID
        {
            get { return _HolidayCategoryID; }
            set { _HolidayCategoryID = value; }
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
        public String ColorName
        {
            get { return _ColorName; }
            set { _ColorName = value; }
        }

        [DataMember]
        public String ColorCode
        {
            get { return _ColorCode; }
            set { _ColorCode = value; }
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

        [XmlIgnore()]
        public override bool IsNew
        {
            [DebuggerStepThrough()]
            get
            {
                return (HolidayCategoryID <= 0);
            }
        }


        #endregion

        #region Constructor

        public MDHolidayCategoryEntity() : base()
        {
        }

        #endregion

        #region Constant

        public const String FLD_NAME_HolidayCategoryID = "HolidayCategoryID";
        public const String FLD_NAME_Name = "Name";
        public const String FLD_NAME_Description = "Description";
        public const String FLD_NAME_ColorName = "ColorName";
        public const String FLD_NAME_ColorCode = "ColorCode";
        public const String FLD_NAME_Remarks = "Remarks";
        public const String FLD_NAME_IsRemoved = "IsRemoved";

        #endregion
    }
}
