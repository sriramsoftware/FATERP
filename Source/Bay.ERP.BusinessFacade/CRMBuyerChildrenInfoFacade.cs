// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 09-May-2013, 05:23:07




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
    public sealed partial class CRMBuyerChildrenInfoFacade : ICRMBuyerChildrenInfoFacade
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

        public CRMBuyerChildrenInfoFacade()
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

        ~CRMBuyerChildrenInfoFacade()
        {
            Dispose(false);
        }

        #endregion


        #region Business Facade


        #region Save Update Delete

        [OperationContract]
        Int64 ICRMBuyerChildrenInfoFacade.Add(CRMBuyerChildrenInfoEntity cRMBuyerChildrenInfoEntity, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateCRMBuyerChildrenInfoDataAccess().Add(cRMBuyerChildrenInfoEntity, option, reqTran);
        }

        [OperationContract]
        Int64 ICRMBuyerChildrenInfoFacade.Update(CRMBuyerChildrenInfoEntity cRMBuyerChildrenInfoEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateCRMBuyerChildrenInfoDataAccess().Update(cRMBuyerChildrenInfoEntity, filterExpression, option, reqTran);
        }

        [OperationContract]
        Int64 ICRMBuyerChildrenInfoFacade.Delete(CRMBuyerChildrenInfoEntity cRMBuyerChildrenInfoEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateCRMBuyerChildrenInfoDataAccess().Delete(cRMBuyerChildrenInfoEntity, filterExpression, option, reqTran);
        }

        #endregion Save Update Delete

        #region Save Update Delete List

        [OperationContract]
        IList<Int64> ICRMBuyerChildrenInfoFacade.Add(IList<CRMBuyerChildrenInfoEntity> cRMBuyerChildrenInfoEntityList, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateCRMBuyerChildrenInfoDataAccess().Add(cRMBuyerChildrenInfoEntityList, option, reqTran);
        }

        [OperationContract]
        IList<Int64> ICRMBuyerChildrenInfoFacade.Update(IList<CRMBuyerChildrenInfoEntity> cRMBuyerChildrenInfoEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateCRMBuyerChildrenInfoDataAccess().Update(cRMBuyerChildrenInfoEntityList, filterExpression, option, reqTran);
        }

        [OperationContract]
        IList<Int64> ICRMBuyerChildrenInfoFacade.Delete(IList<CRMBuyerChildrenInfoEntity> cRMBuyerChildrenInfoEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateCRMBuyerChildrenInfoDataAccess().Delete(cRMBuyerChildrenInfoEntityList, filterExpression, option, reqTran);
        }

        #endregion Save Update Delete List

        #region Get

        [OperationContract]
        IList<CRMBuyerChildrenInfoEntity> ICRMBuyerChildrenInfoFacade.GetIL(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option)
        {
            return DataAccessFactory.CreateCRMBuyerChildrenInfoDataAccess().GetIL(currentPage, pageSize, sortExpression, filterExpression, option);
        }

        [OperationContract]
        DataTable ICRMBuyerChildrenInfoFacade.GetDT(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option)
        {
            return DataAccessFactory.CreateCRMBuyerChildrenInfoDataAccess().GetDT(currentPage, pageSize, sortExpression, filterExpression, option);
        }

        [OperationContract]
        CRMBuyerChildrenInfoEntity ICRMBuyerChildrenInfoFacade.GetByID(Int64 iD)
        {
        String fe = SqlExpressionBuilder.PrepareFilterExpression(CRMBuyerChildrenInfoEntity.FLD_NAME_BuyerChildrenInfoID, iD.ToString(), SQLMatchType.Equal);

        return DataAccessFactory.CreateCRMBuyerChildrenInfoDataAccess().GetIL(null, null, String.Empty, fe, DatabaseOperationType.LoadWithFilterExpression)[0];
        }

        #endregion Get


        #endregion
    }
}
