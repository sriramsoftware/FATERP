// Copyright and All Rights Reserved by
//B2B Solution, Bangladesh;
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 19-Feb-2012, 06:02:47




using System;
using System.Diagnostics;
using System.ServiceModel;
using System.Runtime.Serialization;
using System.Collections.Generic;
using System.Xml.Serialization;


namespace Bay.ERP.Common.BusinessEntities
{
    [Serializable]
    [DataContract(Name = "CMNDashboardItem", Namespace = "http://www.e-p-m-s.com/types")]
    public partial class CMNDashboardItemEntity : BaseEntity
    {
        #region Properties


        private Int64 _DashboardItemID;
        private Int64? _ParentDashboardItemID;
        private String _Title;
        private String _TittleColor;
        private String _Description;
        private String _DescriptionColor;
        private String _ImageUrl;
        private String _HoverImageUrl;
        private String _NavigationUrl;
        private Boolean _IsPopup;
        private String _HoverMessage;
        private Int32 _SequenceID;
        private Int32 _ImageWidth;
        private Int32 _ImageHeight;
        private Int32 _DashboardItemWidth;
        private Int32 _DashboardItemHeight;
        private Boolean _IsRemoved;


        [DataMember]
        public Int64 DashboardItemID
        {
            get { return _DashboardItemID; }
            set { _DashboardItemID = value; }
        }

        [DataMember]
        public Int64? ParentDashboardItemID
        {
            get { return _ParentDashboardItemID; }
            set { _ParentDashboardItemID = value; }
        }

        [DataMember]
        public String Title
        {
            get { return _Title; }
            set { _Title = value; }
        }

        [DataMember]
        public String TittleColor
        {
            get { return _TittleColor; }
            set { _TittleColor = value; }
        }

        [DataMember]
        public String Description
        {
            get { return _Description; }
            set { _Description = value; }
        }

        [DataMember]
        public String DescriptionColor
        {
            get { return _DescriptionColor; }
            set { _DescriptionColor = value; }
        }

        [DataMember]
        public String ImageUrl
        {
            get { return _ImageUrl; }
            set { _ImageUrl = value; }
        }

        [DataMember]
        public String HoverImageUrl
        {
            get { return _HoverImageUrl; }
            set { _HoverImageUrl = value; }
        }

        [DataMember]
        public String NavigationUrl
        {
            get { return _NavigationUrl; }
            set { _NavigationUrl = value; }
        }

        [DataMember]
        public Boolean IsPopup
        {
            get { return _IsPopup; }
            set { _IsPopup = value; }
        }

        [DataMember]
        public String HoverMessage
        {
            get { return _HoverMessage; }
            set { _HoverMessage = value; }
        }

        [DataMember]
        public Int32 SequenceID
        {
            get { return _SequenceID; }
            set { _SequenceID = value; }
        }

        [DataMember]
        public Int32 ImageWidth
        {
            get { return _ImageWidth; }
            set { _ImageWidth = value; }
        }

        [DataMember]
        public Int32 ImageHeight
        {
            get { return _ImageHeight; }
            set { _ImageHeight = value; }
        }

        [DataMember]
        public Int32 DashboardItemWidth
        {
            get { return _DashboardItemWidth; }
            set { _DashboardItemWidth = value; }
        }

        [DataMember]
        public Int32 DashboardItemHeight
        {
            get { return _DashboardItemHeight; }
            set { _DashboardItemHeight = value; }
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
                return (DashboardItemID <= 0);
            }
        }


        #endregion

        #region Constructor

        public CMNDashboardItemEntity() : base()
        {
        }

        #endregion

        #region Constant

        public const String FLD_NAME_DashboardItemID = "DashboardItemID";
        public const String FLD_NAME_ParentDashboardItemID = "ParentDashboardItemID";
        public const String FLD_NAME_Title = "Title";
        public const String FLD_NAME_TittleColor = "TittleColor";
        public const String FLD_NAME_Description = "Description";
        public const String FLD_NAME_DescriptionColor = "DescriptionColor";
        public const String FLD_NAME_ImageUrl = "ImageUrl";
        public const String FLD_NAME_HoverImageUrl = "HoverImageUrl";
        public const String FLD_NAME_NavigationUrl = "NavigationUrl";
        public const String FLD_NAME_IsPopup = "IsPopup";
        public const String FLD_NAME_HoverMessage = "HoverMessage";
        public const String FLD_NAME_SequenceID = "SequenceID";
        public const String FLD_NAME_ImageWidth = "ImageWidth";
        public const String FLD_NAME_ImageHeight = "ImageHeight";
        public const String FLD_NAME_DashboardItemWidth = "DashboardItemWidth";
        public const String FLD_NAME_DashboardItemHeight = "DashboardItemHeight";
        public const String FLD_NAME_IsRemoved = "IsRemoved";

        #endregion
    }
}
