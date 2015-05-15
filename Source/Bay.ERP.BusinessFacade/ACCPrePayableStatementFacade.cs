// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 13-Dec-2012, 11:43:49




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
    public sealed partial class ACCPrePayableStatementFacade : IACCPrePayableStatementFacade
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

        public ACCPrePayableStatementFacade()
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

        ~ACCPrePayableStatementFacade()
        {
            Dispose(false);
        }

        #endregion


        #region Business Facade


        #region Save Update Delete

        [OperationContract]
        Int64 IACCPrePayableStatementFacade.Add(ACCPrePayableStatementEntity aCCPrePayableStatementEntity, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateACCPrePayableStatementDataAccess().Add(aCCPrePayableStatementEntity, option, reqTran);
        }

        [OperationContract]
        Int64 IACCPrePayableStatementFacade.Update(ACCPrePayableStatementEntity aCCPrePayableStatementEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateACCPrePayableStatementDataAccess().Update(aCCPrePayableStatementEntity, filterExpression, option, reqTran);
        }

        [OperationContract]
        Int64 IACCPrePayableStatementFacade.Delete(ACCPrePayableStatementEntity aCCPrePayableStatementEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateACCPrePayableStatementDataAccess().Delete(aCCPrePayableStatementEntity, filterExpression, option, reqTran);
        }

        #endregion Save Update Delete

        #region Save Update Delete List

        [OperationContract]
        IList<Int64> IACCPrePayableStatementFacade.Add(IList<ACCPrePayableStatementEntity> aCCPrePayableStatementEntityList, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateACCPrePayableStatementDataAccess().Add(aCCPrePayableStatementEntityList, option, reqTran);
        }

        [OperationContract]
        IList<Int64> IACCPrePayableStatementFacade.Update(IList<ACCPrePayableStatementEntity> aCCPrePayableStatementEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateACCPrePayableStatementDataAccess().Update(aCCPrePayableStatementEntityList, filterExpression, option, reqTran);
        }

        [OperationContract]
        IList<Int64> IACCPrePayableStatementFacade.Delete(IList<ACCPrePayableStatementEntity> aCCPrePayableStatementEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateACCPrePayableStatementDataAccess().Delete(aCCPrePayableStatementEntityList, filterExpression, option, reqTran);
        }

        #endregion Save Update Delete List

        #region Get

        [OperationContract]
        IList<ACCPrePayableStatementEntity> IACCPrePayableStatementFacade.GetIL(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option)
        {
            return DataAccessFactory.CreateACCPrePayableStatementDataAccess().GetIL(currentPage, pageSize, sortExpression, filterExpression, option);
        }

        [OperationContract]
        DataTable IACCPrePayableStatementFacade.GetDT(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option)
        {
            return DataAccessFactory.CreateACCPrePayableStatementDataAccess().GetDT(currentPage, pageSize, sortExpression, filterExpression, option);
        }

        [OperationContract]
        ACCPrePayableStatementEntity IACCPrePayableStatementFacade.GetByID(Int64 iD)
        {
        String fe = SqlExpressionBuilder.PrepareFilterExpression(ACCPrePayableStatementEntity.FLD_NAME_PrePayableStatementID, iD.ToString(), SQLMatchType.Equal);

        return DataAccessFactory.CreateACCPrePayableStatementDataAccess().GetIL(null, null, String.Empty, fe, DatabaseOperationType.LoadWithFilterExpression)[0];
        }

        #endregion Get


        #endregion
    }
}
