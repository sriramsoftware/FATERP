// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 17-Feb-2013, 02:08:21




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
    public sealed partial class ACTemporaryJournalMasterFacade : IACTemporaryJournalMasterFacade
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

        public ACTemporaryJournalMasterFacade()
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

        ~ACTemporaryJournalMasterFacade()
        {
            Dispose(false);
        }

        #endregion


        #region Business Facade


        #region Save Update Delete

        [OperationContract]
        Int64 IACTemporaryJournalMasterFacade.Add(ACTemporaryJournalMasterEntity aCTemporaryJournalMasterEntity, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateACTemporaryJournalMasterDataAccess().Add(aCTemporaryJournalMasterEntity, option, reqTran);
        }

        [OperationContract]
        Int64 IACTemporaryJournalMasterFacade.Update(ACTemporaryJournalMasterEntity aCTemporaryJournalMasterEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateACTemporaryJournalMasterDataAccess().Update(aCTemporaryJournalMasterEntity, filterExpression, option, reqTran);
        }

        [OperationContract]
        Int64 IACTemporaryJournalMasterFacade.Delete(ACTemporaryJournalMasterEntity aCTemporaryJournalMasterEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateACTemporaryJournalMasterDataAccess().Delete(aCTemporaryJournalMasterEntity, filterExpression, option, reqTran);
        }

        #endregion Save Update Delete

        #region Save Update Delete List

        [OperationContract]
        IList<Int64> IACTemporaryJournalMasterFacade.Add(IList<ACTemporaryJournalMasterEntity> aCTemporaryJournalMasterEntityList, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateACTemporaryJournalMasterDataAccess().Add(aCTemporaryJournalMasterEntityList, option, reqTran);
        }

        [OperationContract]
        IList<Int64> IACTemporaryJournalMasterFacade.Update(IList<ACTemporaryJournalMasterEntity> aCTemporaryJournalMasterEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateACTemporaryJournalMasterDataAccess().Update(aCTemporaryJournalMasterEntityList, filterExpression, option, reqTran);
        }

        [OperationContract]
        IList<Int64> IACTemporaryJournalMasterFacade.Delete(IList<ACTemporaryJournalMasterEntity> aCTemporaryJournalMasterEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateACTemporaryJournalMasterDataAccess().Delete(aCTemporaryJournalMasterEntityList, filterExpression, option, reqTran);
        }

        #endregion Save Update Delete List

        #region Get

        [OperationContract]
        IList<ACTemporaryJournalMasterEntity> IACTemporaryJournalMasterFacade.GetIL(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option)
        {
            return DataAccessFactory.CreateACTemporaryJournalMasterDataAccess().GetIL(currentPage, pageSize, sortExpression, filterExpression, option);
        }

        [OperationContract]
        DataTable IACTemporaryJournalMasterFacade.GetDT(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option)
        {
            return DataAccessFactory.CreateACTemporaryJournalMasterDataAccess().GetDT(currentPage, pageSize, sortExpression, filterExpression, option);
        }

        [OperationContract]
        ACTemporaryJournalMasterEntity IACTemporaryJournalMasterFacade.GetByID(Int64 iD)
        {
        String fe = SqlExpressionBuilder.PrepareFilterExpression(ACTemporaryJournalMasterEntity.FLD_NAME_TemporaryJournalMasterID, iD.ToString(), SQLMatchType.Equal);

        return DataAccessFactory.CreateACTemporaryJournalMasterDataAccess().GetIL(null, null, String.Empty, fe, DatabaseOperationType.LoadWithFilterExpression)[0];
        }

        #endregion Get


        #endregion
    }
}
