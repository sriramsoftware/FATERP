// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 27-Jan-2013, 02:50:43




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
    public sealed partial class ACCurrencyExchangeRatesFacade : IACCurrencyExchangeRatesFacade
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

        public ACCurrencyExchangeRatesFacade()
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

        ~ACCurrencyExchangeRatesFacade()
        {
            Dispose(false);
        }

        #endregion


        #region Business Facade


        #region Save Update Delete

        [OperationContract]
        Int64 IACCurrencyExchangeRatesFacade.Add(ACCurrencyExchangeRatesEntity aCCurrencyExchangeRatesEntity, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateACCurrencyExchangeRatesDataAccess().Add(aCCurrencyExchangeRatesEntity, option, reqTran);
        }

        [OperationContract]
        Int64 IACCurrencyExchangeRatesFacade.Update(ACCurrencyExchangeRatesEntity aCCurrencyExchangeRatesEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateACCurrencyExchangeRatesDataAccess().Update(aCCurrencyExchangeRatesEntity, filterExpression, option, reqTran);
        }

        [OperationContract]
        Int64 IACCurrencyExchangeRatesFacade.Delete(ACCurrencyExchangeRatesEntity aCCurrencyExchangeRatesEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateACCurrencyExchangeRatesDataAccess().Delete(aCCurrencyExchangeRatesEntity, filterExpression, option, reqTran);
        }

        #endregion Save Update Delete

        #region Save Update Delete List

        [OperationContract]
        IList<Int64> IACCurrencyExchangeRatesFacade.Add(IList<ACCurrencyExchangeRatesEntity> aCCurrencyExchangeRatesEntityList, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateACCurrencyExchangeRatesDataAccess().Add(aCCurrencyExchangeRatesEntityList, option, reqTran);
        }

        [OperationContract]
        IList<Int64> IACCurrencyExchangeRatesFacade.Update(IList<ACCurrencyExchangeRatesEntity> aCCurrencyExchangeRatesEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateACCurrencyExchangeRatesDataAccess().Update(aCCurrencyExchangeRatesEntityList, filterExpression, option, reqTran);
        }

        [OperationContract]
        IList<Int64> IACCurrencyExchangeRatesFacade.Delete(IList<ACCurrencyExchangeRatesEntity> aCCurrencyExchangeRatesEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateACCurrencyExchangeRatesDataAccess().Delete(aCCurrencyExchangeRatesEntityList, filterExpression, option, reqTran);
        }

        #endregion Save Update Delete List

        #region Get

        [OperationContract]
        IList<ACCurrencyExchangeRatesEntity> IACCurrencyExchangeRatesFacade.GetIL(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option)
        {
            return DataAccessFactory.CreateACCurrencyExchangeRatesDataAccess().GetIL(currentPage, pageSize, sortExpression, filterExpression, option);
        }

        [OperationContract]
        DataTable IACCurrencyExchangeRatesFacade.GetDT(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option)
        {
            return DataAccessFactory.CreateACCurrencyExchangeRatesDataAccess().GetDT(currentPage, pageSize, sortExpression, filterExpression, option);
        }

        [OperationContract]
        ACCurrencyExchangeRatesEntity IACCurrencyExchangeRatesFacade.GetByID(Int64 iD)
        {
        String fe = SqlExpressionBuilder.PrepareFilterExpression(ACCurrencyExchangeRatesEntity.FLD_NAME_CurrencyExchangeRatesID, iD.ToString(), SQLMatchType.Equal);

        return DataAccessFactory.CreateACCurrencyExchangeRatesDataAccess().GetIL(null, null, String.Empty, fe, DatabaseOperationType.LoadWithFilterExpression)[0];
        }

        #endregion Get


        #endregion
    }
}
