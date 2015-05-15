// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 20-May-2013, 02:30:30




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
    public sealed partial class CRMPaymentCollectionFacade : ICRMPaymentCollectionFacade
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

        public CRMPaymentCollectionFacade()
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

        ~CRMPaymentCollectionFacade()
        {
            Dispose(false);
        }

        #endregion


        #region Business Facade


        #region Save Update Delete

        [OperationContract]
        Int64 ICRMPaymentCollectionFacade.Add(CRMPaymentCollectionEntity cRMPaymentCollectionEntity, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateCRMPaymentCollectionDataAccess().Add(cRMPaymentCollectionEntity, option, reqTran);
        }

        [OperationContract]
        Int64 ICRMPaymentCollectionFacade.Update(CRMPaymentCollectionEntity cRMPaymentCollectionEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateCRMPaymentCollectionDataAccess().Update(cRMPaymentCollectionEntity, filterExpression, option, reqTran);
        }

        [OperationContract]
        Int64 ICRMPaymentCollectionFacade.Delete(CRMPaymentCollectionEntity cRMPaymentCollectionEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateCRMPaymentCollectionDataAccess().Delete(cRMPaymentCollectionEntity, filterExpression, option, reqTran);
        }

        #endregion Save Update Delete

        #region Save Update Delete List

        [OperationContract]
        IList<Int64> ICRMPaymentCollectionFacade.Add(IList<CRMPaymentCollectionEntity> cRMPaymentCollectionEntityList, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateCRMPaymentCollectionDataAccess().Add(cRMPaymentCollectionEntityList, option, reqTran);
        }

        [OperationContract]
        IList<Int64> ICRMPaymentCollectionFacade.Update(IList<CRMPaymentCollectionEntity> cRMPaymentCollectionEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateCRMPaymentCollectionDataAccess().Update(cRMPaymentCollectionEntityList, filterExpression, option, reqTran);
        }

        [OperationContract]
        IList<Int64> ICRMPaymentCollectionFacade.Delete(IList<CRMPaymentCollectionEntity> cRMPaymentCollectionEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateCRMPaymentCollectionDataAccess().Delete(cRMPaymentCollectionEntityList, filterExpression, option, reqTran);
        }

        #endregion Save Update Delete List

        #region Get

        [OperationContract]
        IList<CRMPaymentCollectionEntity> ICRMPaymentCollectionFacade.GetIL(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option)
        {
            return DataAccessFactory.CreateCRMPaymentCollectionDataAccess().GetIL(currentPage, pageSize, sortExpression, filterExpression, option);
        }

        [OperationContract]
        DataTable ICRMPaymentCollectionFacade.GetDT(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option)
        {
            return DataAccessFactory.CreateCRMPaymentCollectionDataAccess().GetDT(currentPage, pageSize, sortExpression, filterExpression, option);
        }

        [OperationContract]
        CRMPaymentCollectionEntity ICRMPaymentCollectionFacade.GetByID(Int64 iD)
        {
        String fe = SqlExpressionBuilder.PrepareFilterExpression(CRMPaymentCollectionEntity.FLD_NAME_PaymentCollectionID, iD.ToString(), SQLMatchType.Equal);

        return DataAccessFactory.CreateCRMPaymentCollectionDataAccess().GetIL(null, null, String.Empty, fe, DatabaseOperationType.LoadWithFilterExpression)[0];
        }

        #endregion Get


        #endregion
    }
}
