// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 03-Mar-2013, 10:27:29




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
    public sealed partial class ACMDBankAccountTransferApprovalStatusFacade : IACMDBankAccountTransferApprovalStatusFacade
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

        public ACMDBankAccountTransferApprovalStatusFacade()
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

        ~ACMDBankAccountTransferApprovalStatusFacade()
        {
            Dispose(false);
        }

        #endregion


        #region Business Facade


        #region Save Update Delete

        [OperationContract]
        Int64 IACMDBankAccountTransferApprovalStatusFacade.Add(ACMDBankAccountTransferApprovalStatusEntity aCMDBankAccountTransferApprovalStatusEntity, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateACMDBankAccountTransferApprovalStatusDataAccess().Add(aCMDBankAccountTransferApprovalStatusEntity, option, reqTran);
        }

        [OperationContract]
        Int64 IACMDBankAccountTransferApprovalStatusFacade.Update(ACMDBankAccountTransferApprovalStatusEntity aCMDBankAccountTransferApprovalStatusEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateACMDBankAccountTransferApprovalStatusDataAccess().Update(aCMDBankAccountTransferApprovalStatusEntity, filterExpression, option, reqTran);
        }

        [OperationContract]
        Int64 IACMDBankAccountTransferApprovalStatusFacade.Delete(ACMDBankAccountTransferApprovalStatusEntity aCMDBankAccountTransferApprovalStatusEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateACMDBankAccountTransferApprovalStatusDataAccess().Delete(aCMDBankAccountTransferApprovalStatusEntity, filterExpression, option, reqTran);
        }

        #endregion Save Update Delete

        #region Save Update Delete List

        [OperationContract]
        IList<Int64> IACMDBankAccountTransferApprovalStatusFacade.Add(IList<ACMDBankAccountTransferApprovalStatusEntity> aCMDBankAccountTransferApprovalStatusEntityList, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateACMDBankAccountTransferApprovalStatusDataAccess().Add(aCMDBankAccountTransferApprovalStatusEntityList, option, reqTran);
        }

        [OperationContract]
        IList<Int64> IACMDBankAccountTransferApprovalStatusFacade.Update(IList<ACMDBankAccountTransferApprovalStatusEntity> aCMDBankAccountTransferApprovalStatusEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateACMDBankAccountTransferApprovalStatusDataAccess().Update(aCMDBankAccountTransferApprovalStatusEntityList, filterExpression, option, reqTran);
        }

        [OperationContract]
        IList<Int64> IACMDBankAccountTransferApprovalStatusFacade.Delete(IList<ACMDBankAccountTransferApprovalStatusEntity> aCMDBankAccountTransferApprovalStatusEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateACMDBankAccountTransferApprovalStatusDataAccess().Delete(aCMDBankAccountTransferApprovalStatusEntityList, filterExpression, option, reqTran);
        }

        #endregion Save Update Delete List

        #region Get

        [OperationContract]
        IList<ACMDBankAccountTransferApprovalStatusEntity> IACMDBankAccountTransferApprovalStatusFacade.GetIL(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option)
        {
            return DataAccessFactory.CreateACMDBankAccountTransferApprovalStatusDataAccess().GetIL(currentPage, pageSize, sortExpression, filterExpression, option);
        }

        [OperationContract]
        DataTable IACMDBankAccountTransferApprovalStatusFacade.GetDT(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option)
        {
            return DataAccessFactory.CreateACMDBankAccountTransferApprovalStatusDataAccess().GetDT(currentPage, pageSize, sortExpression, filterExpression, option);
        }

        [OperationContract]
        ACMDBankAccountTransferApprovalStatusEntity IACMDBankAccountTransferApprovalStatusFacade.GetByID(Int64 iD)
        {
        String fe = SqlExpressionBuilder.PrepareFilterExpression(ACMDBankAccountTransferApprovalStatusEntity.FLD_NAME_BankAccountTransferApprovalStatusID, iD.ToString(), SQLMatchType.Equal);

        return DataAccessFactory.CreateACMDBankAccountTransferApprovalStatusDataAccess().GetIL(null, null, String.Empty, fe, DatabaseOperationType.LoadWithFilterExpression)[0];
        }

        #endregion Get


        #endregion
    }
}
