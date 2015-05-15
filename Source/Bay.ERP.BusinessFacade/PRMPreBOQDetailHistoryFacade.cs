// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 02-Sep-2012, 11:06:52




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
    public sealed partial class PRMPreBOQDetailHistoryFacade : IPRMPreBOQDetailHistoryFacade
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

        public PRMPreBOQDetailHistoryFacade()
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

        ~PRMPreBOQDetailHistoryFacade()
        {
            Dispose(false);
        }

        #endregion


        #region Business Facade


        #region Save Update Delete

        [OperationContract]
        Int64 IPRMPreBOQDetailHistoryFacade.Add(PRMPreBOQDetailHistoryEntity pRMPreBOQDetailHistoryEntity, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreatePRMPreBOQDetailHistoryDataAccess().Add(pRMPreBOQDetailHistoryEntity, option, reqTran);
        }

        [OperationContract]
        Int64 IPRMPreBOQDetailHistoryFacade.Update(PRMPreBOQDetailHistoryEntity pRMPreBOQDetailHistoryEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreatePRMPreBOQDetailHistoryDataAccess().Update(pRMPreBOQDetailHistoryEntity, filterExpression, option, reqTran);
        }

        [OperationContract]
        Int64 IPRMPreBOQDetailHistoryFacade.Delete(PRMPreBOQDetailHistoryEntity pRMPreBOQDetailHistoryEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreatePRMPreBOQDetailHistoryDataAccess().Delete(pRMPreBOQDetailHistoryEntity, filterExpression, option, reqTran);
        }

        #endregion Save Update Delete

        #region Save Update Delete List

        [OperationContract]
        IList<Int64> IPRMPreBOQDetailHistoryFacade.Add(IList<PRMPreBOQDetailHistoryEntity> pRMPreBOQDetailHistoryEntityList, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreatePRMPreBOQDetailHistoryDataAccess().Add(pRMPreBOQDetailHistoryEntityList, option, reqTran);
        }

        [OperationContract]
        IList<Int64> IPRMPreBOQDetailHistoryFacade.Update(IList<PRMPreBOQDetailHistoryEntity> pRMPreBOQDetailHistoryEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreatePRMPreBOQDetailHistoryDataAccess().Update(pRMPreBOQDetailHistoryEntityList, filterExpression, option, reqTran);
        }

        [OperationContract]
        IList<Int64> IPRMPreBOQDetailHistoryFacade.Delete(IList<PRMPreBOQDetailHistoryEntity> pRMPreBOQDetailHistoryEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreatePRMPreBOQDetailHistoryDataAccess().Delete(pRMPreBOQDetailHistoryEntityList, filterExpression, option, reqTran);
        }

        #endregion Save Update Delete List

        #region Get

        [OperationContract]
        IList<PRMPreBOQDetailHistoryEntity> IPRMPreBOQDetailHistoryFacade.GetIL(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option)
        {
            return DataAccessFactory.CreatePRMPreBOQDetailHistoryDataAccess().GetIL(currentPage, pageSize, sortExpression, filterExpression, option);
        }

        [OperationContract]
        DataTable IPRMPreBOQDetailHistoryFacade.GetDT(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option)
        {
            return DataAccessFactory.CreatePRMPreBOQDetailHistoryDataAccess().GetDT(currentPage, pageSize, sortExpression, filterExpression, option);
        }

        [OperationContract]
        PRMPreBOQDetailHistoryEntity IPRMPreBOQDetailHistoryFacade.GetByID(Int64 iD)
        {
        String fe = SqlExpressionBuilder.PrepareFilterExpression(PRMPreBOQDetailHistoryEntity.FLD_NAME_PRMPreBOQDetailHistoryID, iD.ToString(), SQLMatchType.Equal);

        return DataAccessFactory.CreatePRMPreBOQDetailHistoryDataAccess().GetIL(null, null, String.Empty, fe, DatabaseOperationType.LoadWithFilterExpression)[0];
        }

        #endregion Get


        #endregion
    }
}
