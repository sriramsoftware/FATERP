// Copyright and All Rights Reserved by
//B2B Solution, Bangladesh;
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 16-Apr-2012, 04:09:50




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
    public sealed partial class PRMSupplierItemMapHistoryFacade : IPRMSupplierItemMapHistoryFacade
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

        public PRMSupplierItemMapHistoryFacade()
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

        ~PRMSupplierItemMapHistoryFacade()
        {
            Dispose(false);
        }

        #endregion


        #region Business Facade


        #region Save Update Delete

        [OperationContract]
        Int64 IPRMSupplierItemMapHistoryFacade.Add(PRMSupplierItemMapHistoryEntity pRMSupplierItemMapHistoryEntity, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreatePRMSupplierItemMapHistoryDataAccess().Add(pRMSupplierItemMapHistoryEntity, option, reqTran);
        }

        [OperationContract]
        Int64 IPRMSupplierItemMapHistoryFacade.Update(PRMSupplierItemMapHistoryEntity pRMSupplierItemMapHistoryEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreatePRMSupplierItemMapHistoryDataAccess().Update(pRMSupplierItemMapHistoryEntity, filterExpression, option, reqTran);
        }

        [OperationContract]
        Int64 IPRMSupplierItemMapHistoryFacade.Delete(PRMSupplierItemMapHistoryEntity pRMSupplierItemMapHistoryEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreatePRMSupplierItemMapHistoryDataAccess().Delete(pRMSupplierItemMapHistoryEntity, filterExpression, option, reqTran);
        }

        #endregion Save Update Delete

        #region Save Update Delete List

        [OperationContract]
        IList<Int64> IPRMSupplierItemMapHistoryFacade.Add(IList<PRMSupplierItemMapHistoryEntity> pRMSupplierItemMapHistoryEntityList, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreatePRMSupplierItemMapHistoryDataAccess().Add(pRMSupplierItemMapHistoryEntityList, option, reqTran);
        }

        [OperationContract]
        IList<Int64> IPRMSupplierItemMapHistoryFacade.Update(IList<PRMSupplierItemMapHistoryEntity> pRMSupplierItemMapHistoryEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreatePRMSupplierItemMapHistoryDataAccess().Update(pRMSupplierItemMapHistoryEntityList, filterExpression, option, reqTran);
        }

        [OperationContract]
        IList<Int64> IPRMSupplierItemMapHistoryFacade.Delete(IList<PRMSupplierItemMapHistoryEntity> pRMSupplierItemMapHistoryEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreatePRMSupplierItemMapHistoryDataAccess().Delete(pRMSupplierItemMapHistoryEntityList, filterExpression, option, reqTran);
        }

        #endregion Save Update Delete List

        #region Get

        [OperationContract]
        IList<PRMSupplierItemMapHistoryEntity> IPRMSupplierItemMapHistoryFacade.GetIL(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option)
        {
            return DataAccessFactory.CreatePRMSupplierItemMapHistoryDataAccess().GetIL(currentPage, pageSize, sortExpression, filterExpression, option);
        }

        [OperationContract]
        DataTable IPRMSupplierItemMapHistoryFacade.GetDT(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option)
        {
            return DataAccessFactory.CreatePRMSupplierItemMapHistoryDataAccess().GetDT(currentPage, pageSize, sortExpression, filterExpression, option);
        }

        [OperationContract]
        PRMSupplierItemMapHistoryEntity IPRMSupplierItemMapHistoryFacade.GetByID(Int64 iD)
        {
        String fe = SqlExpressionBuilder.PrepareFilterExpression(PRMSupplierItemMapHistoryEntity.FLD_NAME_SupplierItemMapHistoryID, iD.ToString(), SQLMatchType.Equal);

        return DataAccessFactory.CreatePRMSupplierItemMapHistoryDataAccess().GetIL(null, null, String.Empty, fe, DatabaseOperationType.LoadWithFilterExpression)[0];
        }

        #endregion Get


        #endregion
    }
}
