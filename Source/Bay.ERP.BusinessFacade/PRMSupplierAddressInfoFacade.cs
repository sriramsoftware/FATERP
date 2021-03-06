// Copyright and All Rights Reserved by
//B2B Solution, Bangladesh;
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 04-Feb-2012, 05:41:59




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
    public sealed partial class PRMSupplierAddressInfoFacade : IPRMSupplierAddressInfoFacade
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

        public PRMSupplierAddressInfoFacade()
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

        ~PRMSupplierAddressInfoFacade()
        {
            Dispose(false);
        }

        #endregion


        #region Business Facade


        #region Save Update Delete

        [OperationContract]
        Int64 IPRMSupplierAddressInfoFacade.Add(PRMSupplierAddressInfoEntity pRMSupplierAddressInfoEntity, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreatePRMSupplierAddressInfoDataAccess().Add(pRMSupplierAddressInfoEntity, option, reqTran);
        }

        [OperationContract]
        Int64 IPRMSupplierAddressInfoFacade.Update(PRMSupplierAddressInfoEntity pRMSupplierAddressInfoEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreatePRMSupplierAddressInfoDataAccess().Update(pRMSupplierAddressInfoEntity, filterExpression, option, reqTran);
        }

        [OperationContract]
        Int64 IPRMSupplierAddressInfoFacade.Delete(PRMSupplierAddressInfoEntity pRMSupplierAddressInfoEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreatePRMSupplierAddressInfoDataAccess().Delete(pRMSupplierAddressInfoEntity, filterExpression, option, reqTran);
        }

        #endregion Save Update Delete

        #region Save Update Delete List

        [OperationContract]
        IList<Int64> IPRMSupplierAddressInfoFacade.Add(IList<PRMSupplierAddressInfoEntity> pRMSupplierAddressInfoEntityList, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreatePRMSupplierAddressInfoDataAccess().Add(pRMSupplierAddressInfoEntityList, option, reqTran);
        }

        [OperationContract]
        IList<Int64> IPRMSupplierAddressInfoFacade.Update(IList<PRMSupplierAddressInfoEntity> pRMSupplierAddressInfoEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreatePRMSupplierAddressInfoDataAccess().Update(pRMSupplierAddressInfoEntityList, filterExpression, option, reqTran);
        }

        [OperationContract]
        IList<Int64> IPRMSupplierAddressInfoFacade.Delete(IList<PRMSupplierAddressInfoEntity> pRMSupplierAddressInfoEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreatePRMSupplierAddressInfoDataAccess().Delete(pRMSupplierAddressInfoEntityList, filterExpression, option, reqTran);
        }

        #endregion Save Update Delete List

        #region Get

        [OperationContract]
        IList<PRMSupplierAddressInfoEntity> IPRMSupplierAddressInfoFacade.GetIL(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option)
        {
            return DataAccessFactory.CreatePRMSupplierAddressInfoDataAccess().GetIL(currentPage, pageSize, sortExpression, filterExpression, option);
        }

        [OperationContract]
        DataTable IPRMSupplierAddressInfoFacade.GetDT(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option)
        {
            return DataAccessFactory.CreatePRMSupplierAddressInfoDataAccess().GetDT(currentPage, pageSize, sortExpression, filterExpression, option);
        }

        [OperationContract]
        PRMSupplierAddressInfoEntity IPRMSupplierAddressInfoFacade.GetByID(Int64 iD)
        {
        String fe = SqlExpressionBuilder.PrepareFilterExpression(PRMSupplierAddressInfoEntity.FLD_NAME_SupplierAddressInfoID, iD.ToString(), SQLMatchType.Equal);

        return DataAccessFactory.CreatePRMSupplierAddressInfoDataAccess().GetIL(null, null, String.Empty, fe, DatabaseOperationType.LoadWithFilterExpression)[0];
        }

        #endregion Get


        #endregion
    }
}
