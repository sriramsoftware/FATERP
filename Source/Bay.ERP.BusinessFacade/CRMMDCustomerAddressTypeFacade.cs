// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 01-Apr-2013, 02:41:21




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
    public sealed partial class CRMMDCustomerAddressTypeFacade : ICRMMDCustomerAddressTypeFacade
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

        public CRMMDCustomerAddressTypeFacade()
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

        ~CRMMDCustomerAddressTypeFacade()
        {
            Dispose(false);
        }

        #endregion


        #region Business Facade


        #region Save Update Delete

        [OperationContract]
        Int64 ICRMMDCustomerAddressTypeFacade.Add(CRMMDCustomerAddressTypeEntity cRMMDCustomerAddressTypeEntity, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateCRMMDCustomerAddressTypeDataAccess().Add(cRMMDCustomerAddressTypeEntity, option, reqTran);
        }

        [OperationContract]
        Int64 ICRMMDCustomerAddressTypeFacade.Update(CRMMDCustomerAddressTypeEntity cRMMDCustomerAddressTypeEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateCRMMDCustomerAddressTypeDataAccess().Update(cRMMDCustomerAddressTypeEntity, filterExpression, option, reqTran);
        }

        [OperationContract]
        Int64 ICRMMDCustomerAddressTypeFacade.Delete(CRMMDCustomerAddressTypeEntity cRMMDCustomerAddressTypeEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateCRMMDCustomerAddressTypeDataAccess().Delete(cRMMDCustomerAddressTypeEntity, filterExpression, option, reqTran);
        }

        #endregion Save Update Delete

        #region Save Update Delete List

        [OperationContract]
        IList<Int64> ICRMMDCustomerAddressTypeFacade.Add(IList<CRMMDCustomerAddressTypeEntity> cRMMDCustomerAddressTypeEntityList, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateCRMMDCustomerAddressTypeDataAccess().Add(cRMMDCustomerAddressTypeEntityList, option, reqTran);
        }

        [OperationContract]
        IList<Int64> ICRMMDCustomerAddressTypeFacade.Update(IList<CRMMDCustomerAddressTypeEntity> cRMMDCustomerAddressTypeEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateCRMMDCustomerAddressTypeDataAccess().Update(cRMMDCustomerAddressTypeEntityList, filterExpression, option, reqTran);
        }

        [OperationContract]
        IList<Int64> ICRMMDCustomerAddressTypeFacade.Delete(IList<CRMMDCustomerAddressTypeEntity> cRMMDCustomerAddressTypeEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateCRMMDCustomerAddressTypeDataAccess().Delete(cRMMDCustomerAddressTypeEntityList, filterExpression, option, reqTran);
        }

        #endregion Save Update Delete List

        #region Get

        [OperationContract]
        IList<CRMMDCustomerAddressTypeEntity> ICRMMDCustomerAddressTypeFacade.GetIL(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option)
        {
            return DataAccessFactory.CreateCRMMDCustomerAddressTypeDataAccess().GetIL(currentPage, pageSize, sortExpression, filterExpression, option);
        }

        [OperationContract]
        DataTable ICRMMDCustomerAddressTypeFacade.GetDT(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option)
        {
            return DataAccessFactory.CreateCRMMDCustomerAddressTypeDataAccess().GetDT(currentPage, pageSize, sortExpression, filterExpression, option);
        }

        [OperationContract]
        CRMMDCustomerAddressTypeEntity ICRMMDCustomerAddressTypeFacade.GetByID(Int64 iD)
        {
        String fe = SqlExpressionBuilder.PrepareFilterExpression(CRMMDCustomerAddressTypeEntity.FLD_NAME_CustomerAddressTypeID, iD.ToString(), SQLMatchType.Equal);

        return DataAccessFactory.CreateCRMMDCustomerAddressTypeDataAccess().GetIL(null, null, String.Empty, fe, DatabaseOperationType.LoadWithFilterExpression)[0];
        }

        #endregion Get


        #endregion
    }
}
