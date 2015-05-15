// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 17-Feb-2013, 12:00:20




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
    public sealed partial class ACMDBankAccountDepositApprovalStatusFacade : IACMDBankAccountDepositApprovalStatusFacade
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

        public ACMDBankAccountDepositApprovalStatusFacade()
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

        ~ACMDBankAccountDepositApprovalStatusFacade()
        {
            Dispose(false);
        }

        #endregion


        #region Business Facade


        #region Save Update Delete

        [OperationContract]
        Int64 IACMDBankAccountDepositApprovalStatusFacade.Add(ACMDBankAccountDepositApprovalStatusEntity aCMDBankAccountDepositApprovalStatusEntity, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateACMDBankAccountDepositApprovalStatusDataAccess().Add(aCMDBankAccountDepositApprovalStatusEntity, option, reqTran);
        }

        [OperationContract]
        Int64 IACMDBankAccountDepositApprovalStatusFacade.Update(ACMDBankAccountDepositApprovalStatusEntity aCMDBankAccountDepositApprovalStatusEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateACMDBankAccountDepositApprovalStatusDataAccess().Update(aCMDBankAccountDepositApprovalStatusEntity, filterExpression, option, reqTran);
        }

        [OperationContract]
        Int64 IACMDBankAccountDepositApprovalStatusFacade.Delete(ACMDBankAccountDepositApprovalStatusEntity aCMDBankAccountDepositApprovalStatusEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateACMDBankAccountDepositApprovalStatusDataAccess().Delete(aCMDBankAccountDepositApprovalStatusEntity, filterExpression, option, reqTran);
        }

        #endregion Save Update Delete

        #region Save Update Delete List

        [OperationContract]
        IList<Int64> IACMDBankAccountDepositApprovalStatusFacade.Add(IList<ACMDBankAccountDepositApprovalStatusEntity> aCMDBankAccountDepositApprovalStatusEntityList, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateACMDBankAccountDepositApprovalStatusDataAccess().Add(aCMDBankAccountDepositApprovalStatusEntityList, option, reqTran);
        }

        [OperationContract]
        IList<Int64> IACMDBankAccountDepositApprovalStatusFacade.Update(IList<ACMDBankAccountDepositApprovalStatusEntity> aCMDBankAccountDepositApprovalStatusEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateACMDBankAccountDepositApprovalStatusDataAccess().Update(aCMDBankAccountDepositApprovalStatusEntityList, filterExpression, option, reqTran);
        }

        [OperationContract]
        IList<Int64> IACMDBankAccountDepositApprovalStatusFacade.Delete(IList<ACMDBankAccountDepositApprovalStatusEntity> aCMDBankAccountDepositApprovalStatusEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateACMDBankAccountDepositApprovalStatusDataAccess().Delete(aCMDBankAccountDepositApprovalStatusEntityList, filterExpression, option, reqTran);
        }

        #endregion Save Update Delete List

        #region Get

        [OperationContract]
        IList<ACMDBankAccountDepositApprovalStatusEntity> IACMDBankAccountDepositApprovalStatusFacade.GetIL(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option)
        {
            return DataAccessFactory.CreateACMDBankAccountDepositApprovalStatusDataAccess().GetIL(currentPage, pageSize, sortExpression, filterExpression, option);
        }

        [OperationContract]
        DataTable IACMDBankAccountDepositApprovalStatusFacade.GetDT(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option)
        {
            return DataAccessFactory.CreateACMDBankAccountDepositApprovalStatusDataAccess().GetDT(currentPage, pageSize, sortExpression, filterExpression, option);
        }

        [OperationContract]
        ACMDBankAccountDepositApprovalStatusEntity IACMDBankAccountDepositApprovalStatusFacade.GetByID(Int64 iD)
        {
        String fe = SqlExpressionBuilder.PrepareFilterExpression(ACMDBankAccountDepositApprovalStatusEntity.FLD_NAME_BankAccountDepositApprovalStatusID, iD.ToString(), SQLMatchType.Equal);

        return DataAccessFactory.CreateACMDBankAccountDepositApprovalStatusDataAccess().GetIL(null, null, String.Empty, fe, DatabaseOperationType.LoadWithFilterExpression)[0];
        }

        #endregion Get


        #endregion
    }
}
