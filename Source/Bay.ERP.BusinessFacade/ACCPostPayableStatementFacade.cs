// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 13-Dec-2012, 03:29:43




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
    public sealed partial class ACCPostPayableStatementFacade : IACCPostPayableStatementFacade
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

        public ACCPostPayableStatementFacade()
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

        ~ACCPostPayableStatementFacade()
        {
            Dispose(false);
        }

        #endregion


        #region Business Facade


        #region Save Update Delete

        [OperationContract]
        Int64 IACCPostPayableStatementFacade.Add(ACCPostPayableStatementEntity aCCPostPayableStatementEntity, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateACCPostPayableStatementDataAccess().Add(aCCPostPayableStatementEntity, option, reqTran);
        }

        [OperationContract]
        Int64 IACCPostPayableStatementFacade.Update(ACCPostPayableStatementEntity aCCPostPayableStatementEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateACCPostPayableStatementDataAccess().Update(aCCPostPayableStatementEntity, filterExpression, option, reqTran);
        }

        [OperationContract]
        Int64 IACCPostPayableStatementFacade.Delete(ACCPostPayableStatementEntity aCCPostPayableStatementEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateACCPostPayableStatementDataAccess().Delete(aCCPostPayableStatementEntity, filterExpression, option, reqTran);
        }

        #endregion Save Update Delete

        #region Save Update Delete List

        [OperationContract]
        IList<Int64> IACCPostPayableStatementFacade.Add(IList<ACCPostPayableStatementEntity> aCCPostPayableStatementEntityList, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateACCPostPayableStatementDataAccess().Add(aCCPostPayableStatementEntityList, option, reqTran);
        }

        [OperationContract]
        IList<Int64> IACCPostPayableStatementFacade.Update(IList<ACCPostPayableStatementEntity> aCCPostPayableStatementEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateACCPostPayableStatementDataAccess().Update(aCCPostPayableStatementEntityList, filterExpression, option, reqTran);
        }

        [OperationContract]
        IList<Int64> IACCPostPayableStatementFacade.Delete(IList<ACCPostPayableStatementEntity> aCCPostPayableStatementEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateACCPostPayableStatementDataAccess().Delete(aCCPostPayableStatementEntityList, filterExpression, option, reqTran);
        }

        #endregion Save Update Delete List

        #region Get

        [OperationContract]
        IList<ACCPostPayableStatementEntity> IACCPostPayableStatementFacade.GetIL(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option)
        {
            return DataAccessFactory.CreateACCPostPayableStatementDataAccess().GetIL(currentPage, pageSize, sortExpression, filterExpression, option);
        }

        [OperationContract]
        DataTable IACCPostPayableStatementFacade.GetDT(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option)
        {
            return DataAccessFactory.CreateACCPostPayableStatementDataAccess().GetDT(currentPage, pageSize, sortExpression, filterExpression, option);
        }

        [OperationContract]
        ACCPostPayableStatementEntity IACCPostPayableStatementFacade.GetByID(Int64 iD)
        {
        String fe = SqlExpressionBuilder.PrepareFilterExpression(ACCPostPayableStatementEntity.FLD_NAME_PostPayableStatementID, iD.ToString(), SQLMatchType.Equal);

        return DataAccessFactory.CreateACCPostPayableStatementDataAccess().GetIL(null, null, String.Empty, fe, DatabaseOperationType.LoadWithFilterExpression)[0];
        }

        #endregion Get


        #endregion
    }
}
