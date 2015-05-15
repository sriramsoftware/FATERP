// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 30-Jan-2013, 03:35:13




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
    public sealed partial class ACDebitCreditRuleElementFacade : IACDebitCreditRuleElementFacade
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

        public ACDebitCreditRuleElementFacade()
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

        ~ACDebitCreditRuleElementFacade()
        {
            Dispose(false);
        }

        #endregion


        #region Business Facade


        #region Save Update Delete

        [OperationContract]
        Int64 IACDebitCreditRuleElementFacade.Add(ACDebitCreditRuleElementEntity aCDebitCreditRuleElementEntity, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateACDebitCreditRuleElementDataAccess().Add(aCDebitCreditRuleElementEntity, option, reqTran);
        }

        [OperationContract]
        Int64 IACDebitCreditRuleElementFacade.Update(ACDebitCreditRuleElementEntity aCDebitCreditRuleElementEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateACDebitCreditRuleElementDataAccess().Update(aCDebitCreditRuleElementEntity, filterExpression, option, reqTran);
        }

        [OperationContract]
        Int64 IACDebitCreditRuleElementFacade.Delete(ACDebitCreditRuleElementEntity aCDebitCreditRuleElementEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateACDebitCreditRuleElementDataAccess().Delete(aCDebitCreditRuleElementEntity, filterExpression, option, reqTran);
        }

        #endregion Save Update Delete

        #region Save Update Delete List

        [OperationContract]
        IList<Int64> IACDebitCreditRuleElementFacade.Add(IList<ACDebitCreditRuleElementEntity> aCDebitCreditRuleElementEntityList, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateACDebitCreditRuleElementDataAccess().Add(aCDebitCreditRuleElementEntityList, option, reqTran);
        }

        [OperationContract]
        IList<Int64> IACDebitCreditRuleElementFacade.Update(IList<ACDebitCreditRuleElementEntity> aCDebitCreditRuleElementEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateACDebitCreditRuleElementDataAccess().Update(aCDebitCreditRuleElementEntityList, filterExpression, option, reqTran);
        }

        [OperationContract]
        IList<Int64> IACDebitCreditRuleElementFacade.Delete(IList<ACDebitCreditRuleElementEntity> aCDebitCreditRuleElementEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateACDebitCreditRuleElementDataAccess().Delete(aCDebitCreditRuleElementEntityList, filterExpression, option, reqTran);
        }

        #endregion Save Update Delete List

        #region Get

        [OperationContract]
        IList<ACDebitCreditRuleElementEntity> IACDebitCreditRuleElementFacade.GetIL(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option)
        {
            return DataAccessFactory.CreateACDebitCreditRuleElementDataAccess().GetIL(currentPage, pageSize, sortExpression, filterExpression, option);
        }

        [OperationContract]
        DataTable IACDebitCreditRuleElementFacade.GetDT(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option)
        {
            return DataAccessFactory.CreateACDebitCreditRuleElementDataAccess().GetDT(currentPage, pageSize, sortExpression, filterExpression, option);
        }

        [OperationContract]
        ACDebitCreditRuleElementEntity IACDebitCreditRuleElementFacade.GetByID(Int64 iD)
        {
        String fe = SqlExpressionBuilder.PrepareFilterExpression(ACDebitCreditRuleElementEntity.FLD_NAME_DebitCreditRuleElementID, iD.ToString(), SQLMatchType.Equal);

        return DataAccessFactory.CreateACDebitCreditRuleElementDataAccess().GetIL(null, null, String.Empty, fe, DatabaseOperationType.LoadWithFilterExpression)[0];
        }

        #endregion Get


        #endregion
    }
}
