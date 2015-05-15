// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 22-Jul-2013, 02:28:49




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
    public sealed partial class ACTemporaryJournalFacade : IACTemporaryJournalFacade
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

        public ACTemporaryJournalFacade()
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

        ~ACTemporaryJournalFacade()
        {
            Dispose(false);
        }

        #endregion


        #region Business Facade


        #region Save Update Delete

        [OperationContract]
        Int64 IACTemporaryJournalFacade.Add(ACTemporaryJournalEntity aCTemporaryJournalEntity, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateACTemporaryJournalDataAccess().Add(aCTemporaryJournalEntity, option, reqTran);
        }

        [OperationContract]
        Int64 IACTemporaryJournalFacade.Update(ACTemporaryJournalEntity aCTemporaryJournalEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateACTemporaryJournalDataAccess().Update(aCTemporaryJournalEntity, filterExpression, option, reqTran);
        }

        [OperationContract]
        Int64 IACTemporaryJournalFacade.Delete(ACTemporaryJournalEntity aCTemporaryJournalEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateACTemporaryJournalDataAccess().Delete(aCTemporaryJournalEntity, filterExpression, option, reqTran);
        }

        #endregion Save Update Delete

        #region Save Update Delete List

        [OperationContract]
        IList<Int64> IACTemporaryJournalFacade.Add(IList<ACTemporaryJournalEntity> aCTemporaryJournalEntityList, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateACTemporaryJournalDataAccess().Add(aCTemporaryJournalEntityList, option, reqTran);
        }

        [OperationContract]
        IList<Int64> IACTemporaryJournalFacade.Update(IList<ACTemporaryJournalEntity> aCTemporaryJournalEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateACTemporaryJournalDataAccess().Update(aCTemporaryJournalEntityList, filterExpression, option, reqTran);
        }

        [OperationContract]
        IList<Int64> IACTemporaryJournalFacade.Delete(IList<ACTemporaryJournalEntity> aCTemporaryJournalEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateACTemporaryJournalDataAccess().Delete(aCTemporaryJournalEntityList, filterExpression, option, reqTran);
        }

        #endregion Save Update Delete List

        #region Get

        [OperationContract]
        IList<ACTemporaryJournalEntity> IACTemporaryJournalFacade.GetIL(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option)
        {
            return DataAccessFactory.CreateACTemporaryJournalDataAccess().GetIL(currentPage, pageSize, sortExpression, filterExpression, option);
        }

        [OperationContract]
        DataTable IACTemporaryJournalFacade.GetDT(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option)
        {
            return DataAccessFactory.CreateACTemporaryJournalDataAccess().GetDT(currentPage, pageSize, sortExpression, filterExpression, option);
        }

        [OperationContract]
        ACTemporaryJournalEntity IACTemporaryJournalFacade.GetByID(Int64 iD)
        {
        String fe = SqlExpressionBuilder.PrepareFilterExpression(ACTemporaryJournalEntity.FLD_NAME_TemporaryJournalID, iD.ToString(), SQLMatchType.Equal);

        return DataAccessFactory.CreateACTemporaryJournalDataAccess().GetIL(null, null, String.Empty, fe, DatabaseOperationType.LoadWithFilterExpression)[0];
        }

        #endregion Get


        #endregion
    }
}
