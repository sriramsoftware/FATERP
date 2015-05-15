// Copyright and All Rights Reserved by
//B2B Solution, Bangladesh;
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 10-May-2012, 05:58:01




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
    public sealed partial class PRMPreBOQDetailFacade : IPRMPreBOQDetailFacade
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

        public PRMPreBOQDetailFacade()
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

        ~PRMPreBOQDetailFacade()
        {
            Dispose(false);
        }

        #endregion


        #region Business Facade


        #region Save Update Delete

        [OperationContract]
        Int64 IPRMPreBOQDetailFacade.Add(PRMPreBOQDetailEntity pRMPreBOQDetailEntity, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreatePRMPreBOQDetailDataAccess().Add(pRMPreBOQDetailEntity, option, reqTran);
        }

        [OperationContract]
        Int64 IPRMPreBOQDetailFacade.Update(PRMPreBOQDetailEntity pRMPreBOQDetailEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreatePRMPreBOQDetailDataAccess().Update(pRMPreBOQDetailEntity, filterExpression, option, reqTran);
        }

        [OperationContract]
        Int64 IPRMPreBOQDetailFacade.Delete(PRMPreBOQDetailEntity pRMPreBOQDetailEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreatePRMPreBOQDetailDataAccess().Delete(pRMPreBOQDetailEntity, filterExpression, option, reqTran);
        }

        #endregion Save Update Delete

        #region Save Update Delete List

        [OperationContract]
        IList<Int64> IPRMPreBOQDetailFacade.Add(IList<PRMPreBOQDetailEntity> pRMPreBOQDetailEntityList, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreatePRMPreBOQDetailDataAccess().Add(pRMPreBOQDetailEntityList, option, reqTran);
        }

        [OperationContract]
        IList<Int64> IPRMPreBOQDetailFacade.Update(IList<PRMPreBOQDetailEntity> pRMPreBOQDetailEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreatePRMPreBOQDetailDataAccess().Update(pRMPreBOQDetailEntityList, filterExpression, option, reqTran);
        }

        [OperationContract]
        IList<Int64> IPRMPreBOQDetailFacade.Delete(IList<PRMPreBOQDetailEntity> pRMPreBOQDetailEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreatePRMPreBOQDetailDataAccess().Delete(pRMPreBOQDetailEntityList, filterExpression, option, reqTran);
        }

        #endregion Save Update Delete List

        #region Get

        [OperationContract]
        IList<PRMPreBOQDetailEntity> IPRMPreBOQDetailFacade.GetIL(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option)
        {
            return DataAccessFactory.CreatePRMPreBOQDetailDataAccess().GetIL(currentPage, pageSize, sortExpression, filterExpression, option);
        }

        [OperationContract]
        DataTable IPRMPreBOQDetailFacade.GetDT(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option)
        {
            return DataAccessFactory.CreatePRMPreBOQDetailDataAccess().GetDT(currentPage, pageSize, sortExpression, filterExpression, option);
        }

        [OperationContract]
        PRMPreBOQDetailEntity IPRMPreBOQDetailFacade.GetByID(Int64 iD)
        {
        String fe = SqlExpressionBuilder.PrepareFilterExpression(PRMPreBOQDetailEntity.FLD_NAME_PreBOQDetailID, iD.ToString(), SQLMatchType.Equal);

        return DataAccessFactory.CreatePRMPreBOQDetailDataAccess().GetIL(null, null, String.Empty, fe, DatabaseOperationType.LoadWithFilterExpression)[0];
        }

        #endregion Get


        #endregion
    }
}
