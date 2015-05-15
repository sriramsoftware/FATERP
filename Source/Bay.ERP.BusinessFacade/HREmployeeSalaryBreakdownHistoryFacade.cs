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
    public sealed partial class HREmployeeSalaryBreakdownHistoryFacade : IHREmployeeSalaryBreakdownHistoryFacade
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

        public HREmployeeSalaryBreakdownHistoryFacade()
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

        ~HREmployeeSalaryBreakdownHistoryFacade()
        {
            Dispose(false);
        }

        #endregion


        #region Business Facade


        #region Save Update Delete

        [OperationContract]
        Int64 IHREmployeeSalaryBreakdownHistoryFacade.Add(HREmployeeSalaryBreakdownHistoryEntity hREmployeeSalaryBreakdownHistoryEntity, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateHREmployeeSalaryBreakdownHistoryDataAccess().Add(hREmployeeSalaryBreakdownHistoryEntity, option, reqTran);
        }

        [OperationContract]
        Int64 IHREmployeeSalaryBreakdownHistoryFacade.Update(HREmployeeSalaryBreakdownHistoryEntity hREmployeeSalaryBreakdownHistoryEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateHREmployeeSalaryBreakdownHistoryDataAccess().Update(hREmployeeSalaryBreakdownHistoryEntity, filterExpression, option, reqTran);
        }

        [OperationContract]
        Int64 IHREmployeeSalaryBreakdownHistoryFacade.Delete(HREmployeeSalaryBreakdownHistoryEntity hREmployeeSalaryBreakdownHistoryEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateHREmployeeSalaryBreakdownHistoryDataAccess().Delete(hREmployeeSalaryBreakdownHistoryEntity, filterExpression, option, reqTran);
        }

        #endregion Save Update Delete

        #region Save Update Delete List

        [OperationContract]
        IList<Int64> IHREmployeeSalaryBreakdownHistoryFacade.Add(IList<HREmployeeSalaryBreakdownHistoryEntity> hREmployeeSalaryBreakdownHistoryEntityList, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateHREmployeeSalaryBreakdownHistoryDataAccess().Add(hREmployeeSalaryBreakdownHistoryEntityList, option, reqTran);
        }

        [OperationContract]
        IList<Int64> IHREmployeeSalaryBreakdownHistoryFacade.Update(IList<HREmployeeSalaryBreakdownHistoryEntity> hREmployeeSalaryBreakdownHistoryEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateHREmployeeSalaryBreakdownHistoryDataAccess().Update(hREmployeeSalaryBreakdownHistoryEntityList, filterExpression, option, reqTran);
        }

        [OperationContract]
        IList<Int64> IHREmployeeSalaryBreakdownHistoryFacade.Delete(IList<HREmployeeSalaryBreakdownHistoryEntity> hREmployeeSalaryBreakdownHistoryEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateHREmployeeSalaryBreakdownHistoryDataAccess().Delete(hREmployeeSalaryBreakdownHistoryEntityList, filterExpression, option, reqTran);
        }

        #endregion Save Update Delete List

        #region Get

        [OperationContract]
        IList<HREmployeeSalaryBreakdownHistoryEntity> IHREmployeeSalaryBreakdownHistoryFacade.GetIL(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option)
        {
            return DataAccessFactory.CreateHREmployeeSalaryBreakdownHistoryDataAccess().GetIL(currentPage, pageSize, sortExpression, filterExpression, option);
        }

        [OperationContract]
        DataTable IHREmployeeSalaryBreakdownHistoryFacade.GetDT(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option)
        {
            return DataAccessFactory.CreateHREmployeeSalaryBreakdownHistoryDataAccess().GetDT(currentPage, pageSize, sortExpression, filterExpression, option);
        }

        [OperationContract]
        HREmployeeSalaryBreakdownHistoryEntity IHREmployeeSalaryBreakdownHistoryFacade.GetByID(Int64 iD)
        {
        String fe = SqlExpressionBuilder.PrepareFilterExpression(HREmployeeSalaryBreakdownHistoryEntity.FLD_NAME_EmployeeSalaryBreakdownHistoryID, iD.ToString(), SQLMatchType.Equal);

        return DataAccessFactory.CreateHREmployeeSalaryBreakdownHistoryDataAccess().GetIL(null, null, String.Empty, fe, DatabaseOperationType.LoadWithFilterExpression)[0];
        }

        #endregion Get


        #endregion
    }
}
