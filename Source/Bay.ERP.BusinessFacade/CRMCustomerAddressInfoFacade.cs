// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 03-Feb-2013, 03:00:14




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
    public sealed partial class CRMCustomerAddressInfoFacade : ICRMCustomerAddressInfoFacade
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

        public CRMCustomerAddressInfoFacade()
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

        ~CRMCustomerAddressInfoFacade()
        {
            Dispose(false);
        }

        #endregion


        #region Business Facade


        #region Save Update Delete

        [OperationContract]
        Int64 ICRMCustomerAddressInfoFacade.Add(CRMCustomerAddressInfoEntity cRMCustomerAddressInfoEntity, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateCRMCustomerAddressInfoDataAccess().Add(cRMCustomerAddressInfoEntity, option, reqTran);
        }

        [OperationContract]
        Int64 ICRMCustomerAddressInfoFacade.Update(CRMCustomerAddressInfoEntity cRMCustomerAddressInfoEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateCRMCustomerAddressInfoDataAccess().Update(cRMCustomerAddressInfoEntity, filterExpression, option, reqTran);
        }

        [OperationContract]
        Int64 ICRMCustomerAddressInfoFacade.Delete(CRMCustomerAddressInfoEntity cRMCustomerAddressInfoEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateCRMCustomerAddressInfoDataAccess().Delete(cRMCustomerAddressInfoEntity, filterExpression, option, reqTran);
        }

        #endregion Save Update Delete

        #region Save Update Delete List

        [OperationContract]
        IList<Int64> ICRMCustomerAddressInfoFacade.Add(IList<CRMCustomerAddressInfoEntity> cRMCustomerAddressInfoEntityList, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateCRMCustomerAddressInfoDataAccess().Add(cRMCustomerAddressInfoEntityList, option, reqTran);
        }

        [OperationContract]
        IList<Int64> ICRMCustomerAddressInfoFacade.Update(IList<CRMCustomerAddressInfoEntity> cRMCustomerAddressInfoEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateCRMCustomerAddressInfoDataAccess().Update(cRMCustomerAddressInfoEntityList, filterExpression, option, reqTran);
        }

        [OperationContract]
        IList<Int64> ICRMCustomerAddressInfoFacade.Delete(IList<CRMCustomerAddressInfoEntity> cRMCustomerAddressInfoEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateCRMCustomerAddressInfoDataAccess().Delete(cRMCustomerAddressInfoEntityList, filterExpression, option, reqTran);
        }

        #endregion Save Update Delete List

        #region Get

        [OperationContract]
        IList<CRMCustomerAddressInfoEntity> ICRMCustomerAddressInfoFacade.GetIL(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option)
        {
            return DataAccessFactory.CreateCRMCustomerAddressInfoDataAccess().GetIL(currentPage, pageSize, sortExpression, filterExpression, option);
        }

        [OperationContract]
        DataTable ICRMCustomerAddressInfoFacade.GetDT(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option)
        {
            return DataAccessFactory.CreateCRMCustomerAddressInfoDataAccess().GetDT(currentPage, pageSize, sortExpression, filterExpression, option);
        }

        [OperationContract]
        CRMCustomerAddressInfoEntity ICRMCustomerAddressInfoFacade.GetByID(Int64 iD)
        {
        String fe = SqlExpressionBuilder.PrepareFilterExpression(CRMCustomerAddressInfoEntity.FLD_NAME_CustomerAddressInfoID, iD.ToString(), SQLMatchType.Equal);

        return DataAccessFactory.CreateCRMCustomerAddressInfoDataAccess().GetIL(null, null, String.Empty, fe, DatabaseOperationType.LoadWithFilterExpression)[0];
        }

        #endregion Get


        #endregion
    }
}
