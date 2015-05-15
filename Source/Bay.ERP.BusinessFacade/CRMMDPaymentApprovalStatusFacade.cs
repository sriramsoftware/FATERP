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
    public sealed partial class CRMMDPaymentApprovalStatusFacade : ICRMMDPaymentApprovalStatusFacade
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

        public CRMMDPaymentApprovalStatusFacade()
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

        ~CRMMDPaymentApprovalStatusFacade()
        {
            Dispose(false);
        }

        #endregion


        #region Business Facade


        #region Save Update Delete

        [OperationContract]
        Int64 ICRMMDPaymentApprovalStatusFacade.Add(CRMMDPaymentApprovalStatusEntity cRMMDPaymentApprovalStatusEntity, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateCRMMDPaymentApprovalStatusDataAccess().Add(cRMMDPaymentApprovalStatusEntity, option, reqTran);
        }

        [OperationContract]
        Int64 ICRMMDPaymentApprovalStatusFacade.Update(CRMMDPaymentApprovalStatusEntity cRMMDPaymentApprovalStatusEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateCRMMDPaymentApprovalStatusDataAccess().Update(cRMMDPaymentApprovalStatusEntity, filterExpression, option, reqTran);
        }

        [OperationContract]
        Int64 ICRMMDPaymentApprovalStatusFacade.Delete(CRMMDPaymentApprovalStatusEntity cRMMDPaymentApprovalStatusEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateCRMMDPaymentApprovalStatusDataAccess().Delete(cRMMDPaymentApprovalStatusEntity, filterExpression, option, reqTran);
        }

        #endregion Save Update Delete

        #region Save Update Delete List

        [OperationContract]
        IList<Int64> ICRMMDPaymentApprovalStatusFacade.Add(IList<CRMMDPaymentApprovalStatusEntity> cRMMDPaymentApprovalStatusEntityList, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateCRMMDPaymentApprovalStatusDataAccess().Add(cRMMDPaymentApprovalStatusEntityList, option, reqTran);
        }

        [OperationContract]
        IList<Int64> ICRMMDPaymentApprovalStatusFacade.Update(IList<CRMMDPaymentApprovalStatusEntity> cRMMDPaymentApprovalStatusEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateCRMMDPaymentApprovalStatusDataAccess().Update(cRMMDPaymentApprovalStatusEntityList, filterExpression, option, reqTran);
        }

        [OperationContract]
        IList<Int64> ICRMMDPaymentApprovalStatusFacade.Delete(IList<CRMMDPaymentApprovalStatusEntity> cRMMDPaymentApprovalStatusEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateCRMMDPaymentApprovalStatusDataAccess().Delete(cRMMDPaymentApprovalStatusEntityList, filterExpression, option, reqTran);
        }

        #endregion Save Update Delete List

        #region Get

        [OperationContract]
        IList<CRMMDPaymentApprovalStatusEntity> ICRMMDPaymentApprovalStatusFacade.GetIL(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option)
        {
            return DataAccessFactory.CreateCRMMDPaymentApprovalStatusDataAccess().GetIL(currentPage, pageSize, sortExpression, filterExpression, option);
        }

        [OperationContract]
        DataTable ICRMMDPaymentApprovalStatusFacade.GetDT(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option)
        {
            return DataAccessFactory.CreateCRMMDPaymentApprovalStatusDataAccess().GetDT(currentPage, pageSize, sortExpression, filterExpression, option);
        }

        [OperationContract]
        CRMMDPaymentApprovalStatusEntity ICRMMDPaymentApprovalStatusFacade.GetByID(Int64 iD)
        {
        String fe = SqlExpressionBuilder.PrepareFilterExpression(CRMMDPaymentApprovalStatusEntity.FLD_NAME_PaymentApprovalStatusID, iD.ToString(), SQLMatchType.Equal);

        return DataAccessFactory.CreateCRMMDPaymentApprovalStatusDataAccess().GetIL(null, null, String.Empty, fe, DatabaseOperationType.LoadWithFilterExpression)[0];
        }

        #endregion Get


        #endregion
    }
}
