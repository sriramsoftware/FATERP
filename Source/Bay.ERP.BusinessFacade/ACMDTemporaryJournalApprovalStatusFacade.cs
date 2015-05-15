// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 17-Feb-2013, 12:50:45




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
    public sealed partial class ACMDTemporaryJournalApprovalStatusFacade : IACMDTemporaryJournalApprovalStatusFacade
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

        public ACMDTemporaryJournalApprovalStatusFacade()
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

        ~ACMDTemporaryJournalApprovalStatusFacade()
        {
            Dispose(false);
        }

        #endregion


        #region Business Facade


        #region Save Update Delete

        [OperationContract]
        Int64 IACMDTemporaryJournalApprovalStatusFacade.Add(ACMDTemporaryJournalApprovalStatusEntity aCMDTemporaryJournalApprovalStatusEntity, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateACMDTemporaryJournalApprovalStatusDataAccess().Add(aCMDTemporaryJournalApprovalStatusEntity, option, reqTran);
        }

        [OperationContract]
        Int64 IACMDTemporaryJournalApprovalStatusFacade.Update(ACMDTemporaryJournalApprovalStatusEntity aCMDTemporaryJournalApprovalStatusEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateACMDTemporaryJournalApprovalStatusDataAccess().Update(aCMDTemporaryJournalApprovalStatusEntity, filterExpression, option, reqTran);
        }

        [OperationContract]
        Int64 IACMDTemporaryJournalApprovalStatusFacade.Delete(ACMDTemporaryJournalApprovalStatusEntity aCMDTemporaryJournalApprovalStatusEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateACMDTemporaryJournalApprovalStatusDataAccess().Delete(aCMDTemporaryJournalApprovalStatusEntity, filterExpression, option, reqTran);
        }

        #endregion Save Update Delete

        #region Save Update Delete List

        [OperationContract]
        IList<Int64> IACMDTemporaryJournalApprovalStatusFacade.Add(IList<ACMDTemporaryJournalApprovalStatusEntity> aCMDTemporaryJournalApprovalStatusEntityList, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateACMDTemporaryJournalApprovalStatusDataAccess().Add(aCMDTemporaryJournalApprovalStatusEntityList, option, reqTran);
        }

        [OperationContract]
        IList<Int64> IACMDTemporaryJournalApprovalStatusFacade.Update(IList<ACMDTemporaryJournalApprovalStatusEntity> aCMDTemporaryJournalApprovalStatusEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateACMDTemporaryJournalApprovalStatusDataAccess().Update(aCMDTemporaryJournalApprovalStatusEntityList, filterExpression, option, reqTran);
        }

        [OperationContract]
        IList<Int64> IACMDTemporaryJournalApprovalStatusFacade.Delete(IList<ACMDTemporaryJournalApprovalStatusEntity> aCMDTemporaryJournalApprovalStatusEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateACMDTemporaryJournalApprovalStatusDataAccess().Delete(aCMDTemporaryJournalApprovalStatusEntityList, filterExpression, option, reqTran);
        }

        #endregion Save Update Delete List

        #region Get

        [OperationContract]
        IList<ACMDTemporaryJournalApprovalStatusEntity> IACMDTemporaryJournalApprovalStatusFacade.GetIL(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option)
        {
            return DataAccessFactory.CreateACMDTemporaryJournalApprovalStatusDataAccess().GetIL(currentPage, pageSize, sortExpression, filterExpression, option);
        }

        [OperationContract]
        DataTable IACMDTemporaryJournalApprovalStatusFacade.GetDT(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option)
        {
            return DataAccessFactory.CreateACMDTemporaryJournalApprovalStatusDataAccess().GetDT(currentPage, pageSize, sortExpression, filterExpression, option);
        }

        [OperationContract]
        ACMDTemporaryJournalApprovalStatusEntity IACMDTemporaryJournalApprovalStatusFacade.GetByID(Int64 iD)
        {
        String fe = SqlExpressionBuilder.PrepareFilterExpression(ACMDTemporaryJournalApprovalStatusEntity.FLD_NAME_TemporyJournalApprovalStatusID, iD.ToString(), SQLMatchType.Equal);

        return DataAccessFactory.CreateACMDTemporaryJournalApprovalStatusDataAccess().GetIL(null, null, String.Empty, fe, DatabaseOperationType.LoadWithFilterExpression)[0];
        }

        #endregion Get


        #endregion
    }
}
