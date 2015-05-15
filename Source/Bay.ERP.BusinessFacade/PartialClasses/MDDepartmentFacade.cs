// Copyright and All Rights Reserved by
//B2B Solution, Bangladesh;
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 30-Nov-2011, 03:17:49




using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.ServiceModel;
using System.Diagnostics;
using System.Web;
using System.Linq;

using Bay.ERP.Common.BusinessEntities;
using Bay.ERP.DataAccess;
using Bay.ERP.BusinessFacade;
using Bay.ERP.Common.Shared;
using Bay.ERP.Common.Helper;

namespace Bay.ERP.BusinessFacade
{
    public sealed partial class MDDepartmentFacade
    {
        #region Extra Methods

        [OperationContract]
        IList<MDDepartmentEntity> IMDDepartmentFacade.GetILFC()
        {
            return GetILFromCache();
        }

        [OperationContract]
        IList<MDDepartmentEntity> IMDDepartmentFacade.GetByParentDepartmentILFC(Int64 parentDepartmentID)
        {
            IList<MDDepartmentEntity> lstDepartment = GetILFromCache();

            IList<MDDepartmentEntity> lstByParentDepartment = (from a in lstDepartment where a.ParentDepartmentID == parentDepartmentID select a).ToList();

            return lstByParentDepartment;
        }

        private IList<MDDepartmentEntity> GetILFromCache()
        {
            IList<MDDepartmentEntity> lstDepartment = null;

            if (HttpContext.Current.Cache[CommonConstants.DEPARTMENT_FC] == null)
            {
                String fe = SqlExpressionBuilder.PrepareFilterExpression(MDDepartmentEntity.FLD_NAME_IsRemoved, "false", SQLMatchType.Equal);

                lstDepartment = DataAccessFactory.CreateMDDepartmentDataAccess().GetIL(null, null, String.Empty, fe, DatabaseOperationType.LoadWithFilterExpression);

                // storing in the cache
                if (lstDepartment != null)
                {
                    HttpContext.Current.Cache[CommonConstants.DEPARTMENT_FC] = lstDepartment;
                }
            }
            else
            {
                lstDepartment = (IList<MDDepartmentEntity>)HttpContext.Current.Cache[CommonConstants.DEPARTMENT_FC];
            }

            return lstDepartment;
        }

        [OperationContract]
        void IMDDepartmentFacade.RemoveCache()
        {
            HttpContext.Current.Cache.Remove(CommonConstants.DEPARTMENT_FC);
        }  

        #endregion
    }
}
