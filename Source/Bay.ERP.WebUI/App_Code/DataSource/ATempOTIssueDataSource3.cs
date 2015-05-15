// Copyright and All Rights Reserved by
// 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// B2B Solutions, Info@b2b-erp.com
// ©2010 – 2013.
//
// Code Generate Time - 28-Dec-2011, 07:18:54




using System;
using System.Data;
using System.ComponentModel;
using System.Collections.Generic;

using Bay.ERP.Common.BusinessEntities;
using Bay.ERP.BusinessFacade;
using Bay.ERP.FacadeCreator.FacadeContext;
using Bay.ERP.Common.Shared;
using System.Web.UI.WebControls;

namespace Bay.ERP.Web.UI
{
    public partial class ATempOTIssueDataSource3 : ObjectDataSource 
    {
        public DataTable ObjectList { get { return FCCOTIssue.GetFacadeCreate().GetDT(null, null, null, null, DatabaseOperationType.Load); } }
        

        //public DataSet GetData()
        //{
        //    DataSet ds = new DataSet();

        //    ds.Tables.Add(FCCOTIssue.GetFacadeCreate().GetDT(null, null, null, null, DatabaseOperationType.Load));

        //    return ds;
        //}

        //[DataObjectMethod(DataObjectMethodType.Select, true)]
        //public static IList<OTIssueEntity> GetData()
        //{
        //    IList<OTIssueEntity> oTIssueEntityList = new List<OTIssueEntity>();
            
        //    try
        //    {
        //        oTIssueEntityList = FCCOTIssue.GetFacadeCreate().GetIL(null, null, null, null, DatabaseOperationType.Load);
        //    }
        //    catch (Exception ex)
        //    {
             
        //    }

        //    return oTIssueEntityList ?? new List<OTIssueEntity>();
        //}
    }
}
