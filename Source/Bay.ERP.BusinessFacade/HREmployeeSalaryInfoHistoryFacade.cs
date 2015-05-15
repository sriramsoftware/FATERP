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
    public sealed partial class HREmployeeSalaryInfoHistoryFacade : IHREmployeeSalaryInfoHistoryFacade
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

        public HREmployeeSalaryInfoHistoryFacade()
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

        ~HREmployeeSalaryInfoHistoryFacade()
        {
            Dispose(false);
        }

        #endregion


        #region Business Facade


        #region Save Update Delete

        [OperationContract]
        Int64 IHREmployeeSalaryInfoHistoryFacade.Add(HREmployeeSalaryInfoHistoryEntity hREmployeeSalaryInfoHistoryEntity, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateHREmployeeSalaryInfoHistoryDataAccess().Add(hREmployeeSalaryInfoHistoryEntity, option, reqTran);
        }

        [OperationContract]
        Int64 IHREmployeeSalaryInfoHistoryFacade.Update(HREmployeeSalaryInfoHistoryEntity hREmployeeSalaryInfoHistoryEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateHREmployeeSalaryInfoHistoryDataAccess().Update(hREmployeeSalaryInfoHistoryEntity, filterExpression, option, reqTran);
        }

        [OperationContract]
        Int64 IHREmployeeSalaryInfoHistoryFacade.Delete(HREmployeeSalaryInfoHistoryEntity hREmployeeSalaryInfoHistoryEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateHREmployeeSalaryInfoHistoryDataAccess().Delete(hREmployeeSalaryInfoHistoryEntity, filterExpression, option, reqTran);
        }

        #endregion Save Update Delete

        #region Save Update Delete List

        [OperationContract]
        IList<Int64> IHREmployeeSalaryInfoHistoryFacade.Add(IList<HREmployeeSalaryInfoHistoryEntity> hREmployeeSalaryInfoHistoryEntityList, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateHREmployeeSalaryInfoHistoryDataAccess().Add(hREmployeeSalaryInfoHistoryEntityList, option, reqTran);
        }

        [OperationContract]
        IList<Int64> IHREmployeeSalaryInfoHistoryFacade.Update(IList<HREmployeeSalaryInfoHistoryEntity> hREmployeeSalaryInfoHistoryEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateHREmployeeSalaryInfoHistoryDataAccess().Update(hREmployeeSalaryInfoHistoryEntityList, filterExpression, option, reqTran);
        }

        [OperationContract]
        IList<Int64> IHREmployeeSalaryInfoHistoryFacade.Delete(IList<HREmployeeSalaryInfoHistoryEntity> hREmployeeSalaryInfoHistoryEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateHREmployeeSalaryInfoHistoryDataAccess().Delete(hREmployeeSalaryInfoHistoryEntityList, filterExpression, option, reqTran);
        }

        #endregion Save Update Delete List

        #region Get

        [OperationContract]
        IList<HREmployeeSalaryInfoHistoryEntity> IHREmployeeSalaryInfoHistoryFacade.GetIL(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option)
        {
            return DataAccessFactory.CreateHREmployeeSalaryInfoHistoryDataAccess().GetIL(currentPage, pageSize, sortExpression, filterExpression, option);
        }

        [OperationContract]
        DataTable IHREmployeeSalaryInfoHistoryFacade.GetDT(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option)
        {
            return DataAccessFactory.CreateHREmployeeSalaryInfoHistoryDataAccess().GetDT(currentPage, pageSize, sortExpression, filterExpression, option);
        }

        [OperationContract]
        HREmployeeSalaryInfoHistoryEntity IHREmployeeSalaryInfoHistoryFacade.GetByID(Int64 iD)
        {
        String fe = SqlExpressionBuilder.PrepareFilterExpression(HREmployeeSalaryInfoHistoryEntity.FLD_NAME_EmployeeSalaryInfoHistoryID, iD.ToString(), SQLMatchType.Equal);

        return DataAccessFactory.CreateHREmployeeSalaryInfoHistoryDataAccess().GetIL(null, null, String.Empty, fe, DatabaseOperationType.LoadWithFilterExpression)[0];
        }

        #endregion Get


        #endregion
    }
}
