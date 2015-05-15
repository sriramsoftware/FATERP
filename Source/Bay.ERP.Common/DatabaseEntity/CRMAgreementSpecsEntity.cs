// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 21-Apr-2013, 01:26:57




using System;
using System.Diagnostics;
using System.ServiceModel;
using System.Runtime.Serialization;
using System.Collections.Generic;
using System.Xml.Serialization;


namespace Bay.ERP.Common.BusinessEntities
{
    [Serializable]
    [DataContract(Name = "CRMAgreementSpecs", Namespace = "http://www.e-p-m-s.com/types")]
    public partial class CRMAgreementSpecsEntity : BaseEntity
    {
        #region Properties


        private Int64 _AgreementSpecsID;
        private Int64 _AgreementID;
        private String _Item;
        private Int64 _BrandID;
        private Decimal? _BayQty;
        private Decimal? _BayPrice;
        private Decimal? _CustomerQty;
        private Decimal? _CustomerPrice;
        private String _Field1;
        private String _Field2;
        private String _var0;
        private String _var1;
        private String _var2;
        private String _var3;
        private String _var4;
        private String _var5;
        private String _Remarks;
        private String _AgreementSpecsType;


        [DataMember]
        public Int64 AgreementSpecsID
        {
            get { return _AgreementSpecsID; }
            set { _AgreementSpecsID = value; }
        }

        [DataMember]
        public Int64 AgreementID
        {
            get { return _AgreementID; }
            set { _AgreementID = value; }
        }

        [DataMember]
        public String Item
        {
            get { return _Item; }
            set { _Item = value; }
        }

        [DataMember]
        public Int64 BrandID
        {
            get { return _BrandID; }
            set { _BrandID = value; }
        }

        [DataMember]
        public Decimal? BayQty
        {
            get { return _BayQty; }
            set { _BayQty = value; }
        }

        [DataMember]
        public Decimal? BayPrice
        {
            get { return _BayPrice; }
            set { _BayPrice = value; }
        }

        [DataMember]
        public Decimal? CustomerQty
        {
            get { return _CustomerQty; }
            set { _CustomerQty = value; }
        }

        [DataMember]
        public Decimal? CustomerPrice
        {
            get { return _CustomerPrice; }
            set { _CustomerPrice = value; }
        }

        [DataMember]
        public String Field1
        {
            get { return _Field1; }
            set { _Field1 = value; }
        }

        [DataMember]
        public String Field2
        {
            get { return _Field2; }
            set { _Field2 = value; }
        }

        [DataMember]
        public String var0
        {
            get { return _var0; }
            set { _var0 = value; }
        }

        [DataMember]
        public String var1
        {
            get { return _var1; }
            set { _var1 = value; }
        }

        [DataMember]
        public String var2
        {
            get { return _var2; }
            set { _var2 = value; }
        }

        [DataMember]
        public String var3
        {
            get { return _var3; }
            set { _var3 = value; }
        }

        [DataMember]
        public String var4
        {
            get { return _var4; }
            set { _var4 = value; }
        }

        [DataMember]
        public String var5
        {
            get { return _var5; }
            set { _var5 = value; }
        }

        [DataMember]
        public String Remarks
        {
            get { return _Remarks; }
            set { _Remarks = value; }
        }

        [DataMember]
        public String AgreementSpecsType
        {
            get { return _AgreementSpecsType; }
            set { _AgreementSpecsType = value; }
        }

        [XmlIgnore()]
        public override bool IsNew
        {
            [DebuggerStepThrough()]
            get
            {
                return (AgreementSpecsID <= 0);
            }
        }


        #endregion

        #region Constructor

        public CRMAgreementSpecsEntity() : base()
        {
        }

        #endregion

        #region Constant

        public const String FLD_NAME_AgreementSpecsID = "AgreementSpecsID";
        public const String FLD_NAME_AgreementID = "AgreementID";
        public const String FLD_NAME_Item = "Item";
        public const String FLD_NAME_BrandID = "BrandID";
        public const String FLD_NAME_BayQty = "BayQty";
        public const String FLD_NAME_BayPrice = "BayPrice";
        public const String FLD_NAME_CustomerQty = "CustomerQty";
        public const String FLD_NAME_CustomerPrice = "CustomerPrice";
        public const String FLD_NAME_Field1 = "Field1";
        public const String FLD_NAME_Field2 = "Field2";
        public const String FLD_NAME_var0 = "var0";
        public const String FLD_NAME_var1 = "var1";
        public const String FLD_NAME_var2 = "var2";
        public const String FLD_NAME_var3 = "var3";
        public const String FLD_NAME_var4 = "var4";
        public const String FLD_NAME_var5 = "var5";
        public const String FLD_NAME_Remarks = "Remarks";
        public const String FLD_NAME_AgreementSpecsType = "AgreementSpecsType";

        #endregion
    }
}
