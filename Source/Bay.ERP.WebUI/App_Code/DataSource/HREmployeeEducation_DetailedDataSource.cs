// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 07-Jan-2014, 10:14:40




using System;
using System.Data;
using System.ComponentModel;
using System.Collections.Generic;

using Bay.ERP.Common.BusinessEntities;
using Bay.ERP.BusinessFacade;
using Bay.ERP.FacadeCreator.FacadeContext;
using Bay.ERP.Common.Shared;

namespace Bay.ERP.Web.UI
{
    [DataObject(true)]
    public partial class HREmployeeEducation_DetailedDataSource
    {
        public Int32 totalRowCount = 0;

        public HREmployeeEducation_DetailedDataSource()
        {
        }

        [DataObjectMethod(DataObjectMethodType.Select, false)]
        public Int32 TotalRowCount(Int32 startRowIndex, Int32 pageSize, String sortExpression, String filterExpression)
        {
            return totalRowCount;
        }

        //public IList<PRMPreBOQ_DetailedEntity> GetPagedData(Int32 startRowIndex, Int32 pageSize, String sortExpression, String filterExpression)
        [DataObjectMethod(DataObjectMethodType.Select, true)]
        public IList<HREmployeeEducation_DetailedEntity> GetPagedData(Int32 startRowIndex, Int32 pageSize, String sortExpression, String filterExpression)
        {
            IList<HREmployeeEducation_DetailedEntity> hREmployeeEducation_DetailedEntityList = new List<HREmployeeEducation_DetailedEntity>();

            try
            {
                if (String.IsNullOrEmpty(sortExpression))
                {
                    sortExpression = "HREmployeeEducation.EmployeeEducationID";
                }

                Int32 currentPage = Convert.ToInt32(startRowIndex / pageSize) + 1;
                //startRowIndex = Convert.ToInt32(  startRowIndex / pageSize) + 1;

                if (pageSize == -1)
                {
                    pageSize = 1000000000;
                }

                hREmployeeEducation_DetailedEntityList = FCCHREmployeeEducation_Detailed.GetFacadeCreate().GetIL(pageSize, currentPage, sortExpression, filterExpression);

                if (hREmployeeEducation_DetailedEntityList != null && hREmployeeEducation_DetailedEntityList.Count > 0)
                {
                    totalRowCount = hREmployeeEducation_DetailedEntityList[0].TotalRowCount;
                }
            }
            catch (Exception ex)
            { 
            }

            return hREmployeeEducation_DetailedEntityList ?? new List<HREmployeeEducation_DetailedEntity>();
        }
    }
}
