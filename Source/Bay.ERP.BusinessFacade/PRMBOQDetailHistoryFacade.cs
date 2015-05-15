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
    public sealed partial class PRMBOQDetailHistoryFacade : IPRMBOQDetailHistoryFacade
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

        public PRMBOQDetailHistoryFacade()
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

        ~PRMBOQDetailHistoryFacade()
        {
            Dispose(false);
        }

        #endregion


        #region Business Facade


        #region Save Update Delete

        [OperationContract]
        Int64 IPRMBOQDetailHistoryFacade.Add(PRMBOQDetailHistoryEntity pRMBOQDetailHistoryEntity, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreatePRMBOQDetailHistoryDataAccess().Add(pRMBOQDetailHistoryEntity, option, reqTran);
        }

        [OperationContract]
        Int64 IPRMBOQDetailHistoryFacade.Update(PRMBOQDetailHistoryEntity pRMBOQDetailHistoryEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreatePRMBOQDetailHistoryDataAccess().Update(pRMBOQDetailHistoryEntity, filterExpression, option, reqTran);
        }

        [OperationContract]
        Int64 IPRMBOQDetailHistoryFacade.Delete(PRMBOQDetailHistoryEntity pRMBOQDetailHistoryEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreatePRMBOQDetailHistoryDataAccess().Delete(pRMBOQDetailHistoryEntity, filterExpression, option, reqTran);
        }

        #endregion Save Update Delete

        #region Save Update Delete List

        [OperationContract]
        IList<Int64> IPRMBOQDetailHistoryFacade.Add(IList<PRMBOQDetailHistoryEntity> pRMBOQDetailHistoryEntityList, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreatePRMBOQDetailHistoryDataAccess().Add(pRMBOQDetailHistoryEntityList, option, reqTran);
        }

        [OperationContract]
        IList<Int64> IPRMBOQDetailHistoryFacade.Update(IList<PRMBOQDetailHistoryEntity> pRMBOQDetailHistoryEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreatePRMBOQDetailHistoryDataAccess().Update(pRMBOQDetailHistoryEntityList, filterExpression, option, reqTran);
        }

        [OperationContract]
        IList<Int64> IPRMBOQDetailHistoryFacade.Delete(IList<PRMBOQDetailHistoryEntity> pRMBOQDetailHistoryEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreatePRMBOQDetailHistoryDataAccess().Delete(pRMBOQDetailHistoryEntityList, filterExpression, option, reqTran);
        }

        #endregion Save Update Delete List

        #region Get

        [OperationContract]
        IList<PRMBOQDetailHistoryEntity> IPRMBOQDetailHistoryFacade.GetIL(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option)
        {
            return DataAccessFactory.CreatePRMBOQDetailHistoryDataAccess().GetIL(currentPage, pageSize, sortExpression, filterExpression, option);
        }

        [OperationContract]
        DataTable IPRMBOQDetailHistoryFacade.GetDT(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option)
        {
            return DataAccessFactory.CreatePRMBOQDetailHistoryDataAccess().GetDT(currentPage, pageSize, sortExpression, filterExpression, option);
        }

        [OperationContract]
        PRMBOQDetailHistoryEntity IPRMBOQDetailHistoryFacade.GetByID(Int64 iD)
        {
        String fe = SqlExpressionBuilder.PrepareFilterExpression(PRMBOQDetailHistoryEntity.FLD_NAME_BOQDetailHistoryID, iD.ToString(), SQLMatchType.Equal);

        return DataAccessFactory.CreatePRMBOQDetailHistoryDataAccess().GetIL(null, null, String.Empty, fe, DatabaseOperationType.LoadWithFilterExpression)[0];
        }

        #endregion Get


        #endregion
    }
}
