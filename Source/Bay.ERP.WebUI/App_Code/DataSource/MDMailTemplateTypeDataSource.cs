// Copyright and All Rights Reserved by
// 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// B2B Solutions, Info@b2b-erp.com
// ©2006 – 2010.
//
// Code Generate Time - 07-Nov-2012, 10:24:47




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
    public partial class MDMailTemplateTypeDataSource
    {
        public Int32 totalRowCount = 0;

        public MDMailTemplateTypeDataSource()
        {
        }

        [DataObjectMethod(DataObjectMethodType.Select, false)]
        public Int32 TotalRowCount(Int32 startRowIndex, Int32 pageSize, String sortExpression, String filterExpression)
        {
            return totalRowCount;
        }

        [DataObjectMethod(DataObjectMethodType.Select, false)]
        public Int32 TotalRowCount(Int32 startRowIndex, Int32 pageSize, String sortExpression)
        {
            return totalRowCount;
        }

        [DataObjectMethod(DataObjectMethodType.Select, true)]
        public IList<MDMailTemplateTypeEntity> GetPagedData(Int32 startRowIndex, Int32 pageSize, String sortExpression)
        {
            IList<MDMailTemplateTypeEntity> mDMailTemplateTypeEntityList = new List<MDMailTemplateTypeEntity>();

            try
            {
                if (pageSize == -1)
                {
                    pageSize = 1000000000;
                }

                if (String.IsNullOrEmpty(sortExpression))
                {
                    sortExpression = MDMailTemplateTypeEntity.FLD_NAME_MailTemplateTypeID + " " + SQLConstants.SORT_ORDER_DESCENDING;
                }

                startRowIndex = Convert.ToInt32(startRowIndex / pageSize) + 1;

                mDMailTemplateTypeEntityList = FCCMDMailTemplateType.GetFacadeCreate().GetIL(startRowIndex, pageSize, sortExpression, null, DatabaseOperationType.LoadPagedWithSortExpression);

                if (mDMailTemplateTypeEntityList != null && mDMailTemplateTypeEntityList.Count > 0)
                {
                    totalRowCount = mDMailTemplateTypeEntityList[0].TotalRowCount;
                }
            }
            catch (Exception ex)
            {
            }

            return mDMailTemplateTypeEntityList ?? new List<MDMailTemplateTypeEntity>();
        }

        [DataObjectMethod(DataObjectMethodType.Select, true)]
        public IList<MDMailTemplateTypeEntity> GetPagedData(Int32 startRowIndex, Int32 pageSize, String sortExpression, String filterExpression)
        {
            IList<MDMailTemplateTypeEntity> mDMailTemplateTypeEntityList = new List<MDMailTemplateTypeEntity>();

            try
            {
                if (pageSize == -1)
                {
                    pageSize = 1000000000;
                }

                if (String.IsNullOrEmpty(sortExpression))
                {
                    sortExpression = MDMailTemplateTypeEntity.FLD_NAME_MailTemplateTypeID + " " + SQLConstants.SORT_ORDER_DESCENDING;
                }

                startRowIndex = Convert.ToInt32(startRowIndex / pageSize) + 1;

                if (pageSize == 2147483647)
                {
                    if (filterExpression.IsNullOrEmpty())
                    {
                        mDMailTemplateTypeEntityList =  FCCMDMailTemplateType.GetFacadeCreate().GetIL(null, null, sortExpression, String.Empty, DatabaseOperationType.LoadWithSortExpression);
                    }
                    else
                    {
                        mDMailTemplateTypeEntityList =  FCCMDMailTemplateType.GetFacadeCreate().GetIL(null, null, sortExpression, filterExpression, DatabaseOperationType.LoadWithFilterAndSortExpression);
                    }
                }
                else
                {
                    if (filterExpression.IsNullOrEmpty())
                    {
                        mDMailTemplateTypeEntityList =  FCCMDMailTemplateType.GetFacadeCreate().GetIL(startRowIndex, pageSize, sortExpression, String.Empty, DatabaseOperationType.LoadPagedWithSortExpression);
                    }
                    else
                    {
                        mDMailTemplateTypeEntityList =  FCCMDMailTemplateType.GetFacadeCreate().GetIL(startRowIndex, pageSize, sortExpression, filterExpression, DatabaseOperationType.LoadPagedWithFilterAndSortExpression);
                    }
                }

                if (mDMailTemplateTypeEntityList != null && mDMailTemplateTypeEntityList.Count > 0)
                {
                    totalRowCount = mDMailTemplateTypeEntityList[0].TotalRowCount;
                }
            }
            catch (Exception ex)
            {
            }

            return mDMailTemplateTypeEntityList ?? new List<MDMailTemplateTypeEntity>();
        }

        [DataObjectMethod(DataObjectMethodType.Select, true)]
        public IList<MDMailTemplateTypeEntity> GetData()
        {
            IList<MDMailTemplateTypeEntity> mDMailTemplateTypeEntityList = new List<MDMailTemplateTypeEntity>();
            
            try
            {
                mDMailTemplateTypeEntityList = FCCMDMailTemplateType.GetFacadeCreate().GetIL(null, null, null, null, DatabaseOperationType.Load);

                if (mDMailTemplateTypeEntityList != null && mDMailTemplateTypeEntityList.Count > 0)
                {
                    totalRowCount = mDMailTemplateTypeEntityList[0].TotalRowCount;
                }
            }
            catch (Exception ex)
            {
             
            }

            return mDMailTemplateTypeEntityList ?? new List<MDMailTemplateTypeEntity>();
        }
    }
}
