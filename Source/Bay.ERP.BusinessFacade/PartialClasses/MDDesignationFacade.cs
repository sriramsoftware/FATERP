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
    public sealed partial class MDDesignationFacade
    {
        #region Extra Methods

        [OperationContract]
        IList<MDDesignationEntity> IMDDesignationFacade.GetILFC()
        {
            return GetILFromCache();
        }

        [OperationContract]
        IList<MDDesignationEntity> IMDDesignationFacade.GetByDepartmentIDILFC(Int64 departmentID)
        {
            IList<MDDesignationEntity> lstDesignation = GetILFromCache();

            IList<MDDesignationEntity> lstDesignationByDepartment = (from a in lstDesignation where a.DepartmentID == departmentID select a).ToList();

            return lstDesignationByDepartment;
        }

        private IList<MDDesignationEntity> GetILFromCache()
        {
            IList<MDDesignationEntity> lstDesignation;

            if (HttpContext.Current.Cache[CommonConstants.DESIGNATION_FC] == null)
            {
                // collecting form database
                String fe = SqlExpressionBuilder.PrepareFilterExpression(MDItemEntity.FLD_NAME_IsRemoved, "false", SQLMatchType.Equal);
                lstDesignation = DataAccessFactory.CreateMDDesignationDataAccess().GetIL(null, null, String.Empty, fe, DatabaseOperationType.LoadWithFilterExpression);

                // storing in the cache
                if (lstDesignation != null)
                {
                    HttpContext.Current.Cache[CommonConstants.DESIGNATION_FC] = lstDesignation;
                }
            }
            else
            {
                lstDesignation = (IList<MDDesignationEntity>)HttpContext.Current.Cache[CommonConstants.DESIGNATION_FC];
            }

            return lstDesignation;
        }


        [OperationContract]
        void IMDDesignationFacade.RemoveCache()
        {
            HttpContext.Current.Cache.Remove(CommonConstants.DESIGNATION_FC);
        }

        #endregion
    }
}
