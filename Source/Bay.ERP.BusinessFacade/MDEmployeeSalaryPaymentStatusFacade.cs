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
    public sealed partial class MDEmployeeSalaryPaymentStatusFacade : IMDEmployeeSalaryPaymentStatusFacade
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

        public MDEmployeeSalaryPaymentStatusFacade()
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

        ~MDEmployeeSalaryPaymentStatusFacade()
        {
            Dispose(false);
        }

        #endregion


        #region Business Facade


        #region Save Update Delete

        [OperationContract]
        Int64 IMDEmployeeSalaryPaymentStatusFacade.Add(MDEmployeeSalaryPaymentStatusEntity mDEmployeeSalaryPaymentStatusEntity, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateMDEmployeeSalaryPaymentStatusDataAccess().Add(mDEmployeeSalaryPaymentStatusEntity, option, reqTran);
        }

        [OperationContract]
        Int64 IMDEmployeeSalaryPaymentStatusFacade.Update(MDEmployeeSalaryPaymentStatusEntity mDEmployeeSalaryPaymentStatusEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateMDEmployeeSalaryPaymentStatusDataAccess().Update(mDEmployeeSalaryPaymentStatusEntity, filterExpression, option, reqTran);
        }

        [OperationContract]
        Int64 IMDEmployeeSalaryPaymentStatusFacade.Delete(MDEmployeeSalaryPaymentStatusEntity mDEmployeeSalaryPaymentStatusEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateMDEmployeeSalaryPaymentStatusDataAccess().Delete(mDEmployeeSalaryPaymentStatusEntity, filterExpression, option, reqTran);
        }

        #endregion Save Update Delete

        #region Save Update Delete List

        [OperationContract]
        IList<Int64> IMDEmployeeSalaryPaymentStatusFacade.Add(IList<MDEmployeeSalaryPaymentStatusEntity> mDEmployeeSalaryPaymentStatusEntityList, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateMDEmployeeSalaryPaymentStatusDataAccess().Add(mDEmployeeSalaryPaymentStatusEntityList, option, reqTran);
        }

        [OperationContract]
        IList<Int64> IMDEmployeeSalaryPaymentStatusFacade.Update(IList<MDEmployeeSalaryPaymentStatusEntity> mDEmployeeSalaryPaymentStatusEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateMDEmployeeSalaryPaymentStatusDataAccess().Update(mDEmployeeSalaryPaymentStatusEntityList, filterExpression, option, reqTran);
        }

        [OperationContract]
        IList<Int64> IMDEmployeeSalaryPaymentStatusFacade.Delete(IList<MDEmployeeSalaryPaymentStatusEntity> mDEmployeeSalaryPaymentStatusEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateMDEmployeeSalaryPaymentStatusDataAccess().Delete(mDEmployeeSalaryPaymentStatusEntityList, filterExpression, option, reqTran);
        }

        #endregion Save Update Delete List

        #region Get

        [OperationContract]
        IList<MDEmployeeSalaryPaymentStatusEntity> IMDEmployeeSalaryPaymentStatusFacade.GetIL(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option)
        {
            return DataAccessFactory.CreateMDEmployeeSalaryPaymentStatusDataAccess().GetIL(currentPage, pageSize, sortExpression, filterExpression, option);
        }

        [OperationContract]
        DataTable IMDEmployeeSalaryPaymentStatusFacade.GetDT(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option)
        {
            return DataAccessFactory.CreateMDEmployeeSalaryPaymentStatusDataAccess().GetDT(currentPage, pageSize, sortExpression, filterExpression, option);
        }

        [OperationContract]
        MDEmployeeSalaryPaymentStatusEntity IMDEmployeeSalaryPaymentStatusFacade.GetByID(Int64 iD)
        {
        String fe = SqlExpressionBuilder.PrepareFilterExpression(MDEmployeeSalaryPaymentStatusEntity.FLD_NAME_EmployeeSalaryPaymentStatusID, iD.ToString(), SQLMatchType.Equal);

        return DataAccessFactory.CreateMDEmployeeSalaryPaymentStatusDataAccess().GetIL(null, null, String.Empty, fe, DatabaseOperationType.LoadWithFilterExpression)[0];
        }

        #endregion Get


        #endregion
    }
}
