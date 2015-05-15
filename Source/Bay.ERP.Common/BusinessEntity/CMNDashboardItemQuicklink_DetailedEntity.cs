// Copyright and All Rights Reserved by
//B2B Solution, Bangladesh;
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 08-Mar-2012, 12:28:08




using System;
using System.Diagnostics;
using System.ServiceModel;
using System.Runtime.Serialization;
using System.Collections.Generic;
using System.Xml.Serialization;


namespace Bay.ERP.Common.BusinessEntities
{
    [Serializable]
    [DataContract(Name = "CMNDashboardItemQuicklink_Detailed", Namespace = "http://www.e-p-m-s.com/types")]
    public partial class CMNDashboardItemQuicklink_DetailedEntity : BaseEntity
    {
        #region Properties


        private Int64 _DashboardItemQuicklinkID;
        private Int64 _DashboardItemID;
        private String _Name;
        private String _NavigationUrl;
        private String _HoverMessage;
        private Boolean _IsRemoved;
        private String _DashBoardItemTitleName;
        private Int64? _RowNumber;


        [DataMember]
        public Int64 DashboardItemQuicklinkID
        {
            get { return _DashboardItemQuicklinkID; }
            set { _DashboardItemQuicklinkID = value; }
        }

        [DataMember]
        public Int64 DashboardItemID
        {
            get { return _DashboardItemID; }
            set { _DashboardItemID = value; }
        }

        [DataMember]
        public String Name
        {
            get { return _Name; }
            set { _Name = value; }
        }

        [DataMember]
        public String NavigationUrl
        {
            get { return _NavigationUrl; }
            set { _NavigationUrl = value; }
        }

        [DataMember]
        public String HoverMessage
        {
            get { return _HoverMessage; }
            set { _HoverMessage = value; }
        }

        [DataMember]
        public Boolean IsRemoved
        {
            get { return _IsRemoved; }
            set { _IsRemoved = value; }
        }

        [DataMember]
        public String DashBoardItemTitleName
        {
            get { return _DashBoardItemTitleName; }
            set { _DashBoardItemTitleName = value; }
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
                return (DashboardItemQuicklinkID <= 0);
            }
        }


        #endregion

        #region Constructor

        public CMNDashboardItemQuicklink_DetailedEntity() : base()
        {
        }

        #endregion

        #region Constant

        public const String FLD_NAME_DashboardItemQuicklinkID = "DashboardItemQuicklinkID";
        public const String FLD_NAME_DashboardItemID = "DashboardItemID";
        public const String FLD_NAME_Name = "Name";
        public const String FLD_NAME_NavigationUrl = "NavigationUrl";
        public const String FLD_NAME_HoverMessage = "HoverMessage";
        public const String FLD_NAME_IsRemoved = "IsRemoved";
        public const String FLD_NAME_DashBoardItemTitleName = "DashBoardItemTitleName";
        public const String FLD_NAME_RowNumber = "RowNumber";

        #endregion
    }
}