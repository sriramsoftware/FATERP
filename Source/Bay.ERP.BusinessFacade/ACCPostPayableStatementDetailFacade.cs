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
    public sealed partial class ACCPostPayableStatementDetailFacade : IACCPostPayableStatementDetailFacade
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

        public ACCPostPayableStatementDetailFacade()
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

        ~ACCPostPayableStatementDetailFacade()
        {
            Dispose(false);
        }

        #endregion


        #region Business Facade


        #region Save Update Delete

        [OperationContract]
        Int64 IACCPostPayableStatementDetailFacade.Add(ACCPostPayableStatementDetailEntity aCCPostPayableStatementDetailEntity, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateACCPostPayableStatementDetailDataAccess().Add(aCCPostPayableStatementDetailEntity, option, reqTran);
        }

        [OperationContract]
        Int64 IACCPostPayableStatementDetailFacade.Update(ACCPostPayableStatementDetailEntity aCCPostPayableStatementDetailEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateACCPostPayableStatementDetailDataAccess().Update(aCCPostPayableStatementDetailEntity, filterExpression, option, reqTran);
        }

        [OperationContract]
        Int64 IACCPostPayableStatementDetailFacade.Delete(ACCPostPayableStatementDetailEntity aCCPostPayableStatementDetailEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateACCPostPayableStatementDetailDataAccess().Delete(aCCPostPayableStatementDetailEntity, filterExpression, option, reqTran);
        }

        #endregion Save Update Delete

        #region Save Update Delete List

        [OperationContract]
        IList<Int64> IACCPostPayableStatementDetailFacade.Add(IList<ACCPostPayableStatementDetailEntity> aCCPostPayableStatementDetailEntityList, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateACCPostPayableStatementDetailDataAccess().Add(aCCPostPayableStatementDetailEntityList, option, reqTran);
        }

        [OperationContract]
        IList<Int64> IACCPostPayableStatementDetailFacade.Update(IList<ACCPostPayableStatementDetailEntity> aCCPostPayableStatementDetailEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateACCPostPayableStatementDetailDataAccess().Update(aCCPostPayableStatementDetailEntityList, filterExpression, option, reqTran);
        }

        [OperationContract]
        IList<Int64> IACCPostPayableStatementDetailFacade.Delete(IList<ACCPostPayableStatementDetailEntity> aCCPostPayableStatementDetailEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateACCPostPayableStatementDetailDataAccess().Delete(aCCPostPayableStatementDetailEntityList, filterExpression, option, reqTran);
        }

        #endregion Save Update Delete List

        #region Get

        [OperationContract]
        IList<ACCPostPayableStatementDetailEntity> IACCPostPayableStatementDetailFacade.GetIL(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option)
        {
            return DataAccessFactory.CreateACCPostPayableStatementDetailDataAccess().GetIL(currentPage, pageSize, sortExpression, filterExpression, option);
        }

        [OperationContract]
        DataTable IACCPostPayableStatementDetailFacade.GetDT(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option)
        {
            return DataAccessFactory.CreateACCPostPayableStatementDetailDataAccess().GetDT(currentPage, pageSize, sortExpression, filterExpression, option);
        }

        [OperationContract]
        ACCPostPayableStatementDetailEntity IACCPostPayableStatementDetailFacade.GetByID(Int64 iD)
        {
        String fe = SqlExpressionBuilder.PrepareFilterExpression(ACCPostPayableStatementDetailEntity.FLD_NAME_PostPayableStatementDetailID, iD.ToString(), SQLMatchType.Equal);

        return DataAccessFactory.CreateACCPostPayableStatementDetailDataAccess().GetIL(null, null, String.Empty, fe, DatabaseOperationType.LoadWithFilterExpression)[0];
        }

        #endregion Get


        #endregion
    }
}
