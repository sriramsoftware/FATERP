// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 27-Dec-2012, 11:55:46




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
    public sealed partial class ACCPrePayableStatementDetailFacade : IACCPrePayableStatementDetailFacade
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

        public ACCPrePayableStatementDetailFacade()
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

        ~ACCPrePayableStatementDetailFacade()
        {
            Dispose(false);
        }

        #endregion


        #region Business Facade


        #region Save Update Delete

        [OperationContract]
        Int64 IACCPrePayableStatementDetailFacade.Add(ACCPrePayableStatementDetailEntity aCCPrePayableStatementDetailEntity, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateACCPrePayableStatementDetailDataAccess().Add(aCCPrePayableStatementDetailEntity, option, reqTran);
        }

        [OperationContract]
        Int64 IACCPrePayableStatementDetailFacade.Update(ACCPrePayableStatementDetailEntity aCCPrePayableStatementDetailEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateACCPrePayableStatementDetailDataAccess().Update(aCCPrePayableStatementDetailEntity, filterExpression, option, reqTran);
        }

        [OperationContract]
        Int64 IACCPrePayableStatementDetailFacade.Delete(ACCPrePayableStatementDetailEntity aCCPrePayableStatementDetailEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateACCPrePayableStatementDetailDataAccess().Delete(aCCPrePayableStatementDetailEntity, filterExpression, option, reqTran);
        }

        #endregion Save Update Delete

        #region Save Update Delete List

        [OperationContract]
        IList<Int64> IACCPrePayableStatementDetailFacade.Add(IList<ACCPrePayableStatementDetailEntity> aCCPrePayableStatementDetailEntityList, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateACCPrePayableStatementDetailDataAccess().Add(aCCPrePayableStatementDetailEntityList, option, reqTran);
        }

        [OperationContract]
        IList<Int64> IACCPrePayableStatementDetailFacade.Update(IList<ACCPrePayableStatementDetailEntity> aCCPrePayableStatementDetailEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateACCPrePayableStatementDetailDataAccess().Update(aCCPrePayableStatementDetailEntityList, filterExpression, option, reqTran);
        }

        [OperationContract]
        IList<Int64> IACCPrePayableStatementDetailFacade.Delete(IList<ACCPrePayableStatementDetailEntity> aCCPrePayableStatementDetailEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateACCPrePayableStatementDetailDataAccess().Delete(aCCPrePayableStatementDetailEntityList, filterExpression, option, reqTran);
        }

        #endregion Save Update Delete List

        #region Get

        [OperationContract]
        IList<ACCPrePayableStatementDetailEntity> IACCPrePayableStatementDetailFacade.GetIL(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option)
        {
            return DataAccessFactory.CreateACCPrePayableStatementDetailDataAccess().GetIL(currentPage, pageSize, sortExpression, filterExpression, option);
        }

        [OperationContract]
        DataTable IACCPrePayableStatementDetailFacade.GetDT(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option)
        {
            return DataAccessFactory.CreateACCPrePayableStatementDetailDataAccess().GetDT(currentPage, pageSize, sortExpression, filterExpression, option);
        }

        [OperationContract]
        ACCPrePayableStatementDetailEntity IACCPrePayableStatementDetailFacade.GetByID(Int64 iD)
        {
        String fe = SqlExpressionBuilder.PrepareFilterExpression(ACCPrePayableStatementDetailEntity.FLD_NAME_PrePayableStatementDetailID, iD.ToString(), SQLMatchType.Equal);

        return DataAccessFactory.CreateACCPrePayableStatementDetailDataAccess().GetIL(null, null, String.Empty, fe, DatabaseOperationType.LoadWithFilterExpression)[0];
        }

        #endregion Get


        #endregion
    }
}
