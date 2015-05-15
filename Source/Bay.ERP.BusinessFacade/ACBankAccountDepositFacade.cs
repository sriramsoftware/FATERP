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
    public sealed partial class ACBankAccountDepositFacade : IACBankAccountDepositFacade
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

        public ACBankAccountDepositFacade()
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

        ~ACBankAccountDepositFacade()
        {
            Dispose(false);
        }

        #endregion


        #region Business Facade


        #region Save Update Delete

        [OperationContract]
        Int64 IACBankAccountDepositFacade.Add(ACBankAccountDepositEntity aCBankAccountDepositEntity, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateACBankAccountDepositDataAccess().Add(aCBankAccountDepositEntity, option, reqTran);
        }

        [OperationContract]
        Int64 IACBankAccountDepositFacade.Update(ACBankAccountDepositEntity aCBankAccountDepositEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateACBankAccountDepositDataAccess().Update(aCBankAccountDepositEntity, filterExpression, option, reqTran);
        }

        [OperationContract]
        Int64 IACBankAccountDepositFacade.Delete(ACBankAccountDepositEntity aCBankAccountDepositEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateACBankAccountDepositDataAccess().Delete(aCBankAccountDepositEntity, filterExpression, option, reqTran);
        }

        #endregion Save Update Delete

        #region Save Update Delete List

        [OperationContract]
        IList<Int64> IACBankAccountDepositFacade.Add(IList<ACBankAccountDepositEntity> aCBankAccountDepositEntityList, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateACBankAccountDepositDataAccess().Add(aCBankAccountDepositEntityList, option, reqTran);
        }

        [OperationContract]
        IList<Int64> IACBankAccountDepositFacade.Update(IList<ACBankAccountDepositEntity> aCBankAccountDepositEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateACBankAccountDepositDataAccess().Update(aCBankAccountDepositEntityList, filterExpression, option, reqTran);
        }

        [OperationContract]
        IList<Int64> IACBankAccountDepositFacade.Delete(IList<ACBankAccountDepositEntity> aCBankAccountDepositEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateACBankAccountDepositDataAccess().Delete(aCBankAccountDepositEntityList, filterExpression, option, reqTran);
        }

        #endregion Save Update Delete List

        #region Get

        [OperationContract]
        IList<ACBankAccountDepositEntity> IACBankAccountDepositFacade.GetIL(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option)
        {
            return DataAccessFactory.CreateACBankAccountDepositDataAccess().GetIL(currentPage, pageSize, sortExpression, filterExpression, option);
        }

        [OperationContract]
        DataTable IACBankAccountDepositFacade.GetDT(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option)
        {
            return DataAccessFactory.CreateACBankAccountDepositDataAccess().GetDT(currentPage, pageSize, sortExpression, filterExpression, option);
        }

        [OperationContract]
        ACBankAccountDepositEntity IACBankAccountDepositFacade.GetByID(Int64 iD)
        {
        String fe = SqlExpressionBuilder.PrepareFilterExpression(ACBankAccountDepositEntity.FLD_NAME_BankAccountDepositID, iD.ToString(), SQLMatchType.Equal);

        return DataAccessFactory.CreateACBankAccountDepositDataAccess().GetIL(null, null, String.Empty, fe, DatabaseOperationType.LoadWithFilterExpression)[0];
        }

        #endregion Get


        #endregion
    }
}
