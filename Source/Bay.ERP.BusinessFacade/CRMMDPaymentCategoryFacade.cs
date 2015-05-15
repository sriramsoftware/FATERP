// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 28-Apr-2013, 12:14:24




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
    public sealed partial class CRMMDPaymentCategoryFacade : ICRMMDPaymentCategoryFacade
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

        public CRMMDPaymentCategoryFacade()
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

        ~CRMMDPaymentCategoryFacade()
        {
            Dispose(false);
        }

        #endregion


        #region Business Facade


        #region Save Update Delete

        [OperationContract]
        Int64 ICRMMDPaymentCategoryFacade.Add(CRMMDPaymentCategoryEntity cRMMDPaymentCategoryEntity, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateCRMMDPaymentCategoryDataAccess().Add(cRMMDPaymentCategoryEntity, option, reqTran);
        }

        [OperationContract]
        Int64 ICRMMDPaymentCategoryFacade.Update(CRMMDPaymentCategoryEntity cRMMDPaymentCategoryEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateCRMMDPaymentCategoryDataAccess().Update(cRMMDPaymentCategoryEntity, filterExpression, option, reqTran);
        }

        [OperationContract]
        Int64 ICRMMDPaymentCategoryFacade.Delete(CRMMDPaymentCategoryEntity cRMMDPaymentCategoryEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateCRMMDPaymentCategoryDataAccess().Delete(cRMMDPaymentCategoryEntity, filterExpression, option, reqTran);
        }

        #endregion Save Update Delete

        #region Save Update Delete List

        [OperationContract]
        IList<Int64> ICRMMDPaymentCategoryFacade.Add(IList<CRMMDPaymentCategoryEntity> cRMMDPaymentCategoryEntityList, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateCRMMDPaymentCategoryDataAccess().Add(cRMMDPaymentCategoryEntityList, option, reqTran);
        }

        [OperationContract]
        IList<Int64> ICRMMDPaymentCategoryFacade.Update(IList<CRMMDPaymentCategoryEntity> cRMMDPaymentCategoryEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateCRMMDPaymentCategoryDataAccess().Update(cRMMDPaymentCategoryEntityList, filterExpression, option, reqTran);
        }

        [OperationContract]
        IList<Int64> ICRMMDPaymentCategoryFacade.Delete(IList<CRMMDPaymentCategoryEntity> cRMMDPaymentCategoryEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateCRMMDPaymentCategoryDataAccess().Delete(cRMMDPaymentCategoryEntityList, filterExpression, option, reqTran);
        }

        #endregion Save Update Delete List

        #region Get

        [OperationContract]
        IList<CRMMDPaymentCategoryEntity> ICRMMDPaymentCategoryFacade.GetIL(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option)
        {
            return DataAccessFactory.CreateCRMMDPaymentCategoryDataAccess().GetIL(currentPage, pageSize, sortExpression, filterExpression, option);
        }

        [OperationContract]
        DataTable ICRMMDPaymentCategoryFacade.GetDT(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option)
        {
            return DataAccessFactory.CreateCRMMDPaymentCategoryDataAccess().GetDT(currentPage, pageSize, sortExpression, filterExpression, option);
        }

        [OperationContract]
        CRMMDPaymentCategoryEntity ICRMMDPaymentCategoryFacade.GetByID(Int64 iD)
        {
        String fe = SqlExpressionBuilder.PrepareFilterExpression(CRMMDPaymentCategoryEntity.FLD_NAME_PaymentCategoryID, iD.ToString(), SQLMatchType.Equal);

        return DataAccessFactory.CreateCRMMDPaymentCategoryDataAccess().GetIL(null, null, String.Empty, fe, DatabaseOperationType.LoadWithFilterExpression)[0];
        }

        #endregion Get


        #endregion
    }
}
