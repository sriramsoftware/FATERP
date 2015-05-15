// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 04-Mar-2013, 09:29:16




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
    public sealed partial class ACBankAccountTransferFacade : IACBankAccountTransferFacade
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

        public ACBankAccountTransferFacade()
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

        ~ACBankAccountTransferFacade()
        {
            Dispose(false);
        }

        #endregion


        #region Business Facade


        #region Save Update Delete

        [OperationContract]
        Int64 IACBankAccountTransferFacade.Add(ACBankAccountTransferEntity aCBankAccountTransferEntity, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateACBankAccountTransferDataAccess().Add(aCBankAccountTransferEntity, option, reqTran);
        }

        [OperationContract]
        Int64 IACBankAccountTransferFacade.Update(ACBankAccountTransferEntity aCBankAccountTransferEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateACBankAccountTransferDataAccess().Update(aCBankAccountTransferEntity, filterExpression, option, reqTran);
        }

        [OperationContract]
        Int64 IACBankAccountTransferFacade.Delete(ACBankAccountTransferEntity aCBankAccountTransferEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateACBankAccountTransferDataAccess().Delete(aCBankAccountTransferEntity, filterExpression, option, reqTran);
        }

        #endregion Save Update Delete

        #region Save Update Delete List

        [OperationContract]
        IList<Int64> IACBankAccountTransferFacade.Add(IList<ACBankAccountTransferEntity> aCBankAccountTransferEntityList, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateACBankAccountTransferDataAccess().Add(aCBankAccountTransferEntityList, option, reqTran);
        }

        [OperationContract]
        IList<Int64> IACBankAccountTransferFacade.Update(IList<ACBankAccountTransferEntity> aCBankAccountTransferEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateACBankAccountTransferDataAccess().Update(aCBankAccountTransferEntityList, filterExpression, option, reqTran);
        }

        [OperationContract]
        IList<Int64> IACBankAccountTransferFacade.Delete(IList<ACBankAccountTransferEntity> aCBankAccountTransferEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateACBankAccountTransferDataAccess().Delete(aCBankAccountTransferEntityList, filterExpression, option, reqTran);
        }

        #endregion Save Update Delete List

        #region Get

        [OperationContract]
        IList<ACBankAccountTransferEntity> IACBankAccountTransferFacade.GetIL(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option)
        {
            return DataAccessFactory.CreateACBankAccountTransferDataAccess().GetIL(currentPage, pageSize, sortExpression, filterExpression, option);
        }

        [OperationContract]
        DataTable IACBankAccountTransferFacade.GetDT(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option)
        {
            return DataAccessFactory.CreateACBankAccountTransferDataAccess().GetDT(currentPage, pageSize, sortExpression, filterExpression, option);
        }

        [OperationContract]
        ACBankAccountTransferEntity IACBankAccountTransferFacade.GetByID(Int64 iD)
        {
        String fe = SqlExpressionBuilder.PrepareFilterExpression(ACBankAccountTransferEntity.FLD_NAME_BankAccountTransferID, iD.ToString(), SQLMatchType.Equal);

        return DataAccessFactory.CreateACBankAccountTransferDataAccess().GetIL(null, null, String.Empty, fe, DatabaseOperationType.LoadWithFilterExpression)[0];
        }

        #endregion Get


        #endregion
    }
}
