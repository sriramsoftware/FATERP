// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 13-Dec-2013, 08:24:37




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
    public sealed partial class CRMPaymentScheduleFacade : ICRMPaymentScheduleFacade
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

        public CRMPaymentScheduleFacade()
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

        ~CRMPaymentScheduleFacade()
        {
            Dispose(false);
        }

        #endregion


        #region Business Facade


        #region Save Update Delete

        [OperationContract]
        Int64 ICRMPaymentScheduleFacade.Add(CRMPaymentScheduleEntity cRMPaymentScheduleEntity, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateCRMPaymentScheduleDataAccess().Add(cRMPaymentScheduleEntity, option, reqTran);
        }

        [OperationContract]
        Int64 ICRMPaymentScheduleFacade.Update(CRMPaymentScheduleEntity cRMPaymentScheduleEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateCRMPaymentScheduleDataAccess().Update(cRMPaymentScheduleEntity, filterExpression, option, reqTran);
        }

        [OperationContract]
        Int64 ICRMPaymentScheduleFacade.Delete(CRMPaymentScheduleEntity cRMPaymentScheduleEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateCRMPaymentScheduleDataAccess().Delete(cRMPaymentScheduleEntity, filterExpression, option, reqTran);
        }

        #endregion Save Update Delete

        #region Save Update Delete List

        [OperationContract]
        IList<Int64> ICRMPaymentScheduleFacade.Add(IList<CRMPaymentScheduleEntity> cRMPaymentScheduleEntityList, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateCRMPaymentScheduleDataAccess().Add(cRMPaymentScheduleEntityList, option, reqTran);
        }

        [OperationContract]
        IList<Int64> ICRMPaymentScheduleFacade.Update(IList<CRMPaymentScheduleEntity> cRMPaymentScheduleEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateCRMPaymentScheduleDataAccess().Update(cRMPaymentScheduleEntityList, filterExpression, option, reqTran);
        }

        [OperationContract]
        IList<Int64> ICRMPaymentScheduleFacade.Delete(IList<CRMPaymentScheduleEntity> cRMPaymentScheduleEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateCRMPaymentScheduleDataAccess().Delete(cRMPaymentScheduleEntityList, filterExpression, option, reqTran);
        }

        #endregion Save Update Delete List

        #region Get

        [OperationContract]
        IList<CRMPaymentScheduleEntity> ICRMPaymentScheduleFacade.GetIL(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option)
        {
            return DataAccessFactory.CreateCRMPaymentScheduleDataAccess().GetIL(currentPage, pageSize, sortExpression, filterExpression, option);
        }

        [OperationContract]
        DataTable ICRMPaymentScheduleFacade.GetDT(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option)
        {
            return DataAccessFactory.CreateCRMPaymentScheduleDataAccess().GetDT(currentPage, pageSize, sortExpression, filterExpression, option);
        }

        [OperationContract]
        CRMPaymentScheduleEntity ICRMPaymentScheduleFacade.GetByID(Int64 iD)
        {
        String fe = SqlExpressionBuilder.PrepareFilterExpression(CRMPaymentScheduleEntity.FLD_NAME_PaymentScheduleID, iD.ToString(), SQLMatchType.Equal);

        return DataAccessFactory.CreateCRMPaymentScheduleDataAccess().GetIL(null, null, String.Empty, fe, DatabaseOperationType.LoadWithFilterExpression)[0];
        }

        #endregion Get


        #endregion
    }
}
