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
    public sealed partial class ACMDBankAccountPaymentApprovalStatusFacade : IACMDBankAccountPaymentApprovalStatusFacade
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

        public ACMDBankAccountPaymentApprovalStatusFacade()
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

        ~ACMDBankAccountPaymentApprovalStatusFacade()
        {
            Dispose(false);
        }

        #endregion


        #region Business Facade


        #region Save Update Delete

        [OperationContract]
        Int64 IACMDBankAccountPaymentApprovalStatusFacade.Add(ACMDBankAccountPaymentApprovalStatusEntity aCMDBankAccountPaymentApprovalStatusEntity, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateACMDBankAccountPaymentApprovalStatusDataAccess().Add(aCMDBankAccountPaymentApprovalStatusEntity, option, reqTran);
        }

        [OperationContract]
        Int64 IACMDBankAccountPaymentApprovalStatusFacade.Update(ACMDBankAccountPaymentApprovalStatusEntity aCMDBankAccountPaymentApprovalStatusEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateACMDBankAccountPaymentApprovalStatusDataAccess().Update(aCMDBankAccountPaymentApprovalStatusEntity, filterExpression, option, reqTran);
        }

        [OperationContract]
        Int64 IACMDBankAccountPaymentApprovalStatusFacade.Delete(ACMDBankAccountPaymentApprovalStatusEntity aCMDBankAccountPaymentApprovalStatusEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateACMDBankAccountPaymentApprovalStatusDataAccess().Delete(aCMDBankAccountPaymentApprovalStatusEntity, filterExpression, option, reqTran);
        }

        #endregion Save Update Delete

        #region Save Update Delete List

        [OperationContract]
        IList<Int64> IACMDBankAccountPaymentApprovalStatusFacade.Add(IList<ACMDBankAccountPaymentApprovalStatusEntity> aCMDBankAccountPaymentApprovalStatusEntityList, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateACMDBankAccountPaymentApprovalStatusDataAccess().Add(aCMDBankAccountPaymentApprovalStatusEntityList, option, reqTran);
        }

        [OperationContract]
        IList<Int64> IACMDBankAccountPaymentApprovalStatusFacade.Update(IList<ACMDBankAccountPaymentApprovalStatusEntity> aCMDBankAccountPaymentApprovalStatusEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateACMDBankAccountPaymentApprovalStatusDataAccess().Update(aCMDBankAccountPaymentApprovalStatusEntityList, filterExpression, option, reqTran);
        }

        [OperationContract]
        IList<Int64> IACMDBankAccountPaymentApprovalStatusFacade.Delete(IList<ACMDBankAccountPaymentApprovalStatusEntity> aCMDBankAccountPaymentApprovalStatusEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateACMDBankAccountPaymentApprovalStatusDataAccess().Delete(aCMDBankAccountPaymentApprovalStatusEntityList, filterExpression, option, reqTran);
        }

        #endregion Save Update Delete List

        #region Get

        [OperationContract]
        IList<ACMDBankAccountPaymentApprovalStatusEntity> IACMDBankAccountPaymentApprovalStatusFacade.GetIL(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option)
        {
            return DataAccessFactory.CreateACMDBankAccountPaymentApprovalStatusDataAccess().GetIL(currentPage, pageSize, sortExpression, filterExpression, option);
        }

        [OperationContract]
        DataTable IACMDBankAccountPaymentApprovalStatusFacade.GetDT(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option)
        {
            return DataAccessFactory.CreateACMDBankAccountPaymentApprovalStatusDataAccess().GetDT(currentPage, pageSize, sortExpression, filterExpression, option);
        }

        [OperationContract]
        ACMDBankAccountPaymentApprovalStatusEntity IACMDBankAccountPaymentApprovalStatusFacade.GetByID(Int64 iD)
        {
        String fe = SqlExpressionBuilder.PrepareFilterExpression(ACMDBankAccountPaymentApprovalStatusEntity.FLD_NAME_BankAccountPaymentApprovalStatusID, iD.ToString(), SQLMatchType.Equal);

        return DataAccessFactory.CreateACMDBankAccountPaymentApprovalStatusDataAccess().GetIL(null, null, String.Empty, fe, DatabaseOperationType.LoadWithFilterExpression)[0];
        }

        #endregion Get


        #endregion
    }
}
