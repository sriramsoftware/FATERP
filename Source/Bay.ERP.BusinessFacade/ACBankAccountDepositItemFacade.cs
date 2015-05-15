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
    public sealed partial class ACBankAccountDepositItemFacade : IACBankAccountDepositItemFacade
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

        public ACBankAccountDepositItemFacade()
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

        ~ACBankAccountDepositItemFacade()
        {
            Dispose(false);
        }

        #endregion


        #region Business Facade


        #region Save Update Delete

        [OperationContract]
        Int64 IACBankAccountDepositItemFacade.Add(ACBankAccountDepositItemEntity aCBankAccountDepositItemEntity, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateACBankAccountDepositItemDataAccess().Add(aCBankAccountDepositItemEntity, option, reqTran);
        }

        [OperationContract]
        Int64 IACBankAccountDepositItemFacade.Update(ACBankAccountDepositItemEntity aCBankAccountDepositItemEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateACBankAccountDepositItemDataAccess().Update(aCBankAccountDepositItemEntity, filterExpression, option, reqTran);
        }

        [OperationContract]
        Int64 IACBankAccountDepositItemFacade.Delete(ACBankAccountDepositItemEntity aCBankAccountDepositItemEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateACBankAccountDepositItemDataAccess().Delete(aCBankAccountDepositItemEntity, filterExpression, option, reqTran);
        }

        #endregion Save Update Delete

        #region Save Update Delete List

        [OperationContract]
        IList<Int64> IACBankAccountDepositItemFacade.Add(IList<ACBankAccountDepositItemEntity> aCBankAccountDepositItemEntityList, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateACBankAccountDepositItemDataAccess().Add(aCBankAccountDepositItemEntityList, option, reqTran);
        }

        [OperationContract]
        IList<Int64> IACBankAccountDepositItemFacade.Update(IList<ACBankAccountDepositItemEntity> aCBankAccountDepositItemEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateACBankAccountDepositItemDataAccess().Update(aCBankAccountDepositItemEntityList, filterExpression, option, reqTran);
        }

        [OperationContract]
        IList<Int64> IACBankAccountDepositItemFacade.Delete(IList<ACBankAccountDepositItemEntity> aCBankAccountDepositItemEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateACBankAccountDepositItemDataAccess().Delete(aCBankAccountDepositItemEntityList, filterExpression, option, reqTran);
        }

        #endregion Save Update Delete List

        #region Get

        [OperationContract]
        IList<ACBankAccountDepositItemEntity> IACBankAccountDepositItemFacade.GetIL(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option)
        {
            return DataAccessFactory.CreateACBankAccountDepositItemDataAccess().GetIL(currentPage, pageSize, sortExpression, filterExpression, option);
        }

        [OperationContract]
        DataTable IACBankAccountDepositItemFacade.GetDT(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option)
        {
            return DataAccessFactory.CreateACBankAccountDepositItemDataAccess().GetDT(currentPage, pageSize, sortExpression, filterExpression, option);
        }

        [OperationContract]
        ACBankAccountDepositItemEntity IACBankAccountDepositItemFacade.GetByID(Int64 iD)
        {
        String fe = SqlExpressionBuilder.PrepareFilterExpression(ACBankAccountDepositItemEntity.FLD_NAME_BankAccountDepositItemID, iD.ToString(), SQLMatchType.Equal);

        return DataAccessFactory.CreateACBankAccountDepositItemDataAccess().GetIL(null, null, String.Empty, fe, DatabaseOperationType.LoadWithFilterExpression)[0];
        }

        #endregion Get


        #endregion
    }
}
