using System;
using System.Diagnostics;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web;
using System.Collections;

using Bay.ERP.BusinessFacade;
using Bay.ERP.Common.BusinessEntities;
using Bay.ERP.Web.UI.Helper;
using Bay.ERP.FacadeCreator.FacadeContext;
using Bay.ERP.Common.Helper;
using Bay.ERP.Common.Shared;
using Bay.ERP.Web.UI;
using System.Collections.Generic;
using System.Linq;

namespace Bay.ERP.Web.UI
{
    public class EmployeeBaseMasterPage : BaseMasterPage
    {
        #region Properties

        public Int64 OverviewEmployeeID
        {
            get
            {
                Int64 overviewEmployeeID = 0;

                if (!StringHelper.IsBlank(Helper.Url.SecureUrl[UrlConstants.OVERVIEW_EMPLOYEE_ID]))
                {
                    Int64.TryParse(Helper.Url.SecureUrl[UrlConstants.OVERVIEW_EMPLOYEE_ID], out overviewEmployeeID);
                }

                return overviewEmployeeID;
            }
        }

        public HREmployeeEntity OverviewEmployee
        {
            get
            {
                HREmployeeEntity _HREmployeeEntity = new HREmployeeEntity();

                _HREmployeeEntity = FCCHREmployee.GetFacadeCreate().GetByID(OverviewEmployeeID);

                return _HREmployeeEntity;
            }
        }

        public HREmployee_DetailedEntity OverviewEmployeeDetailedEntity
        {
            get
            {

                String fe = SqlExpressionBuilder.PrepareFilterExpression(HREmployee_DetailedEntity.FLD_NAME_EmployeeID, OverviewEmployeeID.ToString(), SQLMatchType.Equal);
                IList<HREmployee_DetailedEntity> lstHREmployee_Detailed = FCCHREmployee_Detailed.GetFacadeCreate().GetIL(1, 1, String.Empty, fe);

                return lstHREmployee_Detailed!=null ? lstHREmployee_Detailed[0]:new HREmployee_DetailedEntity();
            }
        }
        public HREmployeePhotoEntity OverviewEmployeePhotoEntity
        {
            get
            {

                String fe = SqlExpressionBuilder.PrepareFilterExpression(HREmployeePhotoEntity.FLD_NAME_EmployeeID, OverviewEmployeeID.ToString(), SQLMatchType.Equal);
                IList<HREmployeePhotoEntity> lstHREmployeePhoto= FCCHREmployeePhoto.GetFacadeCreate().GetIL(null, null, String.Empty, fe, DatabaseOperationType.LoadWithFilterExpression);

                return lstHREmployeePhoto != null ? lstHREmployeePhoto[0] : new HREmployeePhotoEntity(); ;
            }
        }

        #endregion
    }
}