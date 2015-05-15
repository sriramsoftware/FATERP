// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 02-May-2013, 10:12:36




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
    public sealed partial class CRMPaymentScheduleMapFacade : ICRMPaymentScheduleMapFacade
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

        public CRMPaymentScheduleMapFacade()
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

        ~CRMPaymentScheduleMapFacade()
        {
            Dispose(false);
        }

        #endregion


        #region Business Facade


        #region Save Update Delete

        [OperationContract]
        Int64 ICRMPaymentScheduleMapFacade.Add(CRMPaymentScheduleMapEntity cRMPaymentScheduleMapEntity, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateCRMPaymentScheduleMapDataAccess().Add(cRMPaymentScheduleMapEntity, option, reqTran);
        }

        [OperationContract]
        Int64 ICRMPaymentScheduleMapFacade.Update(CRMPaymentScheduleMapEntity cRMPaymentScheduleMapEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateCRMPaymentScheduleMapDataAccess().Update(cRMPaymentScheduleMapEntity, filterExpression, option, reqTran);
        }

        [OperationContract]
        Int64 ICRMPaymentScheduleMapFacade.Delete(CRMPaymentScheduleMapEntity cRMPaymentScheduleMapEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateCRMPaymentScheduleMapDataAccess().Delete(cRMPaymentScheduleMapEntity, filterExpression, option, reqTran);
        }

        #endregion Save Update Delete

        #region Save Update Delete List

        [OperationContract]
        IList<Int64> ICRMPaymentScheduleMapFacade.Add(IList<CRMPaymentScheduleMapEntity> cRMPaymentScheduleMapEntityList, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateCRMPaymentScheduleMapDataAccess().Add(cRMPaymentScheduleMapEntityList, option, reqTran);
        }

        [OperationContract]
        IList<Int64> ICRMPaymentScheduleMapFacade.Update(IList<CRMPaymentScheduleMapEntity> cRMPaymentScheduleMapEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateCRMPaymentScheduleMapDataAccess().Update(cRMPaymentScheduleMapEntityList, filterExpression, option, reqTran);
        }

        [OperationContract]
        IList<Int64> ICRMPaymentScheduleMapFacade.Delete(IList<CRMPaymentScheduleMapEntity> cRMPaymentScheduleMapEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateCRMPaymentScheduleMapDataAccess().Delete(cRMPaymentScheduleMapEntityList, filterExpression, option, reqTran);
        }

        #endregion Save Update Delete List

        #region Get

        [OperationContract]
        IList<CRMPaymentScheduleMapEntity> ICRMPaymentScheduleMapFacade.GetIL(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option)
        {
            return DataAccessFactory.CreateCRMPaymentScheduleMapDataAccess().GetIL(currentPage, pageSize, sortExpression, filterExpression, option);
        }

        [OperationContract]
        DataTable ICRMPaymentScheduleMapFacade.GetDT(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option)
        {
            return DataAccessFactory.CreateCRMPaymentScheduleMapDataAccess().GetDT(currentPage, pageSize, sortExpression, filterExpression, option);
        }

        [OperationContract]
        CRMPaymentScheduleMapEntity ICRMPaymentScheduleMapFacade.GetByID(Int64 iD)
        {
        String fe = SqlExpressionBuilder.PrepareFilterExpression(CRMPaymentScheduleMapEntity.FLD_NAME_PaymentScheduleMapID, iD.ToString(), SQLMatchType.Equal);

        return DataAccessFactory.CreateCRMPaymentScheduleMapDataAccess().GetIL(null, null, String.Empty, fe, DatabaseOperationType.LoadWithFilterExpression)[0];
        }

        #endregion Get


        #endregion
    }
}
