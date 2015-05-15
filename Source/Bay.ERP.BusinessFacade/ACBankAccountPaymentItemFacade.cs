// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 16-Jul-2013, 11:20:53




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
    public sealed partial class ACBankAccountPaymentItemFacade : IACBankAccountPaymentItemFacade
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

        public ACBankAccountPaymentItemFacade()
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

        ~ACBankAccountPaymentItemFacade()
        {
            Dispose(false);
        }

        #endregion


        #region Business Facade


        #region Save Update Delete

        [OperationContract]
        Int64 IACBankAccountPaymentItemFacade.Add(ACBankAccountPaymentItemEntity aCBankAccountPaymentItemEntity, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateACBankAccountPaymentItemDataAccess().Add(aCBankAccountPaymentItemEntity, option, reqTran);
        }

        [OperationContract]
        Int64 IACBankAccountPaymentItemFacade.Update(ACBankAccountPaymentItemEntity aCBankAccountPaymentItemEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateACBankAccountPaymentItemDataAccess().Update(aCBankAccountPaymentItemEntity, filterExpression, option, reqTran);
        }

        [OperationContract]
        Int64 IACBankAccountPaymentItemFacade.Delete(ACBankAccountPaymentItemEntity aCBankAccountPaymentItemEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateACBankAccountPaymentItemDataAccess().Delete(aCBankAccountPaymentItemEntity, filterExpression, option, reqTran);
        }

        #endregion Save Update Delete

        #region Save Update Delete List

        [OperationContract]
        IList<Int64> IACBankAccountPaymentItemFacade.Add(IList<ACBankAccountPaymentItemEntity> aCBankAccountPaymentItemEntityList, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateACBankAccountPaymentItemDataAccess().Add(aCBankAccountPaymentItemEntityList, option, reqTran);
        }

        [OperationContract]
        IList<Int64> IACBankAccountPaymentItemFacade.Update(IList<ACBankAccountPaymentItemEntity> aCBankAccountPaymentItemEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateACBankAccountPaymentItemDataAccess().Update(aCBankAccountPaymentItemEntityList, filterExpression, option, reqTran);
        }

        [OperationContract]
        IList<Int64> IACBankAccountPaymentItemFacade.Delete(IList<ACBankAccountPaymentItemEntity> aCBankAccountPaymentItemEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateACBankAccountPaymentItemDataAccess().Delete(aCBankAccountPaymentItemEntityList, filterExpression, option, reqTran);
        }

        #endregion Save Update Delete List

        #region Get

        [OperationContract]
        IList<ACBankAccountPaymentItemEntity> IACBankAccountPaymentItemFacade.GetIL(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option)
        {
            return DataAccessFactory.CreateACBankAccountPaymentItemDataAccess().GetIL(currentPage, pageSize, sortExpression, filterExpression, option);
        }

        [OperationContract]
        DataTable IACBankAccountPaymentItemFacade.GetDT(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option)
        {
            return DataAccessFactory.CreateACBankAccountPaymentItemDataAccess().GetDT(currentPage, pageSize, sortExpression, filterExpression, option);
        }

        [OperationContract]
        ACBankAccountPaymentItemEntity IACBankAccountPaymentItemFacade.GetByID(Int64 iD)
        {
        String fe = SqlExpressionBuilder.PrepareFilterExpression(ACBankAccountPaymentItemEntity.FLD_NAME_BankAccountPaymentItemID, iD.ToString(), SQLMatchType.Equal);

        return DataAccessFactory.CreateACBankAccountPaymentItemDataAccess().GetIL(null, null, String.Empty, fe, DatabaseOperationType.LoadWithFilterExpression)[0];
        }

        #endregion Get


        #endregion
    }
}
