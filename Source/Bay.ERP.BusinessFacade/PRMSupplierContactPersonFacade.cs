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
    public sealed partial class PRMSupplierContactPersonFacade : IPRMSupplierContactPersonFacade
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

        public PRMSupplierContactPersonFacade()
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

        ~PRMSupplierContactPersonFacade()
        {
            Dispose(false);
        }

        #endregion


        #region Business Facade


        #region Save Update Delete

        [OperationContract]
        Int64 IPRMSupplierContactPersonFacade.Add(PRMSupplierContactPersonEntity pRMSupplierContactPersonEntity, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreatePRMSupplierContactPersonDataAccess().Add(pRMSupplierContactPersonEntity, option, reqTran);
        }

        [OperationContract]
        Int64 IPRMSupplierContactPersonFacade.Update(PRMSupplierContactPersonEntity pRMSupplierContactPersonEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreatePRMSupplierContactPersonDataAccess().Update(pRMSupplierContactPersonEntity, filterExpression, option, reqTran);
        }

        [OperationContract]
        Int64 IPRMSupplierContactPersonFacade.Delete(PRMSupplierContactPersonEntity pRMSupplierContactPersonEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreatePRMSupplierContactPersonDataAccess().Delete(pRMSupplierContactPersonEntity, filterExpression, option, reqTran);
        }

        #endregion Save Update Delete

        #region Save Update Delete List

        [OperationContract]
        IList<Int64> IPRMSupplierContactPersonFacade.Add(IList<PRMSupplierContactPersonEntity> pRMSupplierContactPersonEntityList, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreatePRMSupplierContactPersonDataAccess().Add(pRMSupplierContactPersonEntityList, option, reqTran);
        }

        [OperationContract]
        IList<Int64> IPRMSupplierContactPersonFacade.Update(IList<PRMSupplierContactPersonEntity> pRMSupplierContactPersonEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreatePRMSupplierContactPersonDataAccess().Update(pRMSupplierContactPersonEntityList, filterExpression, option, reqTran);
        }

        [OperationContract]
        IList<Int64> IPRMSupplierContactPersonFacade.Delete(IList<PRMSupplierContactPersonEntity> pRMSupplierContactPersonEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreatePRMSupplierContactPersonDataAccess().Delete(pRMSupplierContactPersonEntityList, filterExpression, option, reqTran);
        }

        #endregion Save Update Delete List

        #region Get

        [OperationContract]
        IList<PRMSupplierContactPersonEntity> IPRMSupplierContactPersonFacade.GetIL(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option)
        {
            return DataAccessFactory.CreatePRMSupplierContactPersonDataAccess().GetIL(currentPage, pageSize, sortExpression, filterExpression, option);
        }

        [OperationContract]
        DataTable IPRMSupplierContactPersonFacade.GetDT(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option)
        {
            return DataAccessFactory.CreatePRMSupplierContactPersonDataAccess().GetDT(currentPage, pageSize, sortExpression, filterExpression, option);
        }

        [OperationContract]
        PRMSupplierContactPersonEntity IPRMSupplierContactPersonFacade.GetByID(Int64 iD)
        {
        String fe = SqlExpressionBuilder.PrepareFilterExpression(PRMSupplierContactPersonEntity.FLD_NAME_SupplierContactPersonID, iD.ToString(), SQLMatchType.Equal);

        return DataAccessFactory.CreatePRMSupplierContactPersonDataAccess().GetIL(null, null, String.Empty, fe, DatabaseOperationType.LoadWithFilterExpression)[0];
        }

        #endregion Get


        #endregion
    }
}
