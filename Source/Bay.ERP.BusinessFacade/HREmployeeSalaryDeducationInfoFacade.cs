// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 12-Jan-2014, 03:42:17




using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.ServiceModel;
using System.Diagnostics;

using Bay.ERP.Common.BusinessEntities;
using Bay.ERP.DataAccess;
using Bay.ERP.BusinessFacade;
using Bay.ERP.Common.Shared;
using Bay.ERP.Common.Helper;

namespace Bay.ERP.BusinessFacade
{
    public sealed partial class HREmployeeSalaryDeducationInfoFacade : IHREmployeeSalaryDeducationInfoFacade
    {

        #region Instance Variables

        private bool _isDisposed;
        private Context _currentContext;

        private BaseDataAccessFactory _dataAccessFactory;

        #endregion

        #region Private Properties

        private Context CurrentContext
        {
            [DebuggerStepThrough()]
            get
            {
                if (_currentContext == null)
                {
                    _currentContext = new Context();
                }

                return _currentContext;
            }
        }

        private BaseDataAccessFactory DataAccessFactory
        {
            [DebuggerStepThrough()]
            get
            {
                if (_dataAccessFactory == null)
                {
                    _dataAccessFactory = BaseDataAccessFactory.Create(CurrentContext);
                }

                return _dataAccessFactory;
            }
        }

        #endregion

        #region Constructer & Destructor

        public HREmployeeSalaryDeducationInfoFacade()
            : base()
        {
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        private void Dispose(bool disposing)
        {
            if (!_isDisposed)
            {
                if (disposing)
                {
                    if (_currentContext != null)
                    {
                        _currentContext.Dispose();
                    }
                }
            }

            _isDisposed = true;
        }

        ~HREmployeeSalaryDeducationInfoFacade()
        {
            Dispose(false);
        }

        #endregion


        #region Business Facade


        #region Save Update Delete

        [OperationContract]
        Int64 IHREmployeeSalaryDeducationInfoFacade.Add(HREmployeeSalaryDeducationInfoEntity hREmployeeSalaryDeducationInfoEntity, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateHREmployeeSalaryDeducationInfoDataAccess().Add(hREmployeeSalaryDeducationInfoEntity, option, reqTran);
        }

        [OperationContract]
        Int64 IHREmployeeSalaryDeducationInfoFacade.Update(HREmployeeSalaryDeducationInfoEntity hREmployeeSalaryDeducationInfoEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateHREmployeeSalaryDeducationInfoDataAccess().Update(hREmployeeSalaryDeducationInfoEntity, filterExpression, option, reqTran);
        }

        [OperationContract]
        Int64 IHREmployeeSalaryDeducationInfoFacade.Delete(HREmployeeSalaryDeducationInfoEntity hREmployeeSalaryDeducationInfoEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateHREmployeeSalaryDeducationInfoDataAccess().Delete(hREmployeeSalaryDeducationInfoEntity, filterExpression, option, reqTran);
        }

        #endregion Save Update Delete

        #region Save Update Delete List

        [OperationContract]
        IList<Int64> IHREmployeeSalaryDeducationInfoFacade.Add(IList<HREmployeeSalaryDeducationInfoEntity> hREmployeeSalaryDeducationInfoEntityList, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateHREmployeeSalaryDeducationInfoDataAccess().Add(hREmployeeSalaryDeducationInfoEntityList, option, reqTran);
        }

        [OperationContract]
        IList<Int64> IHREmployeeSalaryDeducationInfoFacade.Update(IList<HREmployeeSalaryDeducationInfoEntity> hREmployeeSalaryDeducationInfoEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateHREmployeeSalaryDeducationInfoDataAccess().Update(hREmployeeSalaryDeducationInfoEntityList, filterExpression, option, reqTran);
        }

        [OperationContract]
        IList<Int64> IHREmployeeSalaryDeducationInfoFacade.Delete(IList<HREmployeeSalaryDeducationInfoEntity> hREmployeeSalaryDeducationInfoEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateHREmployeeSalaryDeducationInfoDataAccess().Delete(hREmployeeSalaryDeducationInfoEntityList, filterExpression, option, reqTran);
        }

        #endregion Save Update Delete List

        #region Get

        [OperationContract]
        IList<HREmployeeSalaryDeducationInfoEntity> IHREmployeeSalaryDeducationInfoFacade.GetIL(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option)
        {
            return DataAccessFactory.CreateHREmployeeSalaryDeducationInfoDataAccess().GetIL(currentPage, pageSize, sortExpression, filterExpression, option);
        }

        [OperationContract]
        DataTable IHREmployeeSalaryDeducationInfoFacade.GetDT(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option)
        {
            return DataAccessFactory.CreateHREmployeeSalaryDeducationInfoDataAccess().GetDT(currentPage, pageSize, sortExpression, filterExpression, option);
        }

        [OperationContract]
        HREmployeeSalaryDeducationInfoEntity IHREmployeeSalaryDeducationInfoFacade.GetByID(Int64 iD)
        {
        String fe = SqlExpressionBuilder.PrepareFilterExpression(HREmployeeSalaryDeducationInfoEntity.FLD_NAME_EmployeeSalaryDeducationInfoID, iD.ToString(), SQLMatchType.Equal);

        return DataAccessFactory.CreateHREmployeeSalaryDeducationInfoDataAccess().GetIL(null, null, String.Empty, fe, DatabaseOperationType.LoadWithFilterExpression)[0];
        }

        #endregion Get


        #endregion
    }
}
