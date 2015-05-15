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
    public sealed partial class ACDebitCreditRuleFacade : IACDebitCreditRuleFacade
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

        public ACDebitCreditRuleFacade()
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

        ~ACDebitCreditRuleFacade()
        {
            Dispose(false);
        }

        #endregion


        #region Business Facade


        #region Save Update Delete

        [OperationContract]
        Int64 IACDebitCreditRuleFacade.Add(ACDebitCreditRuleEntity aCDebitCreditRuleEntity, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateACDebitCreditRuleDataAccess().Add(aCDebitCreditRuleEntity, option, reqTran);
        }

        [OperationContract]
        Int64 IACDebitCreditRuleFacade.Update(ACDebitCreditRuleEntity aCDebitCreditRuleEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateACDebitCreditRuleDataAccess().Update(aCDebitCreditRuleEntity, filterExpression, option, reqTran);
        }

        [OperationContract]
        Int64 IACDebitCreditRuleFacade.Delete(ACDebitCreditRuleEntity aCDebitCreditRuleEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateACDebitCreditRuleDataAccess().Delete(aCDebitCreditRuleEntity, filterExpression, option, reqTran);
        }

        #endregion Save Update Delete

        #region Save Update Delete List

        [OperationContract]
        IList<Int64> IACDebitCreditRuleFacade.Add(IList<ACDebitCreditRuleEntity> aCDebitCreditRuleEntityList, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateACDebitCreditRuleDataAccess().Add(aCDebitCreditRuleEntityList, option, reqTran);
        }

        [OperationContract]
        IList<Int64> IACDebitCreditRuleFacade.Update(IList<ACDebitCreditRuleEntity> aCDebitCreditRuleEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateACDebitCreditRuleDataAccess().Update(aCDebitCreditRuleEntityList, filterExpression, option, reqTran);
        }

        [OperationContract]
        IList<Int64> IACDebitCreditRuleFacade.Delete(IList<ACDebitCreditRuleEntity> aCDebitCreditRuleEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateACDebitCreditRuleDataAccess().Delete(aCDebitCreditRuleEntityList, filterExpression, option, reqTran);
        }

        #endregion Save Update Delete List

        #region Get

        [OperationContract]
        IList<ACDebitCreditRuleEntity> IACDebitCreditRuleFacade.GetIL(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option)
        {
            return DataAccessFactory.CreateACDebitCreditRuleDataAccess().GetIL(currentPage, pageSize, sortExpression, filterExpression, option);
        }

        [OperationContract]
        DataTable IACDebitCreditRuleFacade.GetDT(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option)
        {
            return DataAccessFactory.CreateACDebitCreditRuleDataAccess().GetDT(currentPage, pageSize, sortExpression, filterExpression, option);
        }

        [OperationContract]
        ACDebitCreditRuleEntity IACDebitCreditRuleFacade.GetByID(Int64 iD)
        {
        String fe = SqlExpressionBuilder.PrepareFilterExpression(ACDebitCreditRuleEntity.FLD_NAME_ACDebitCreditRuleID, iD.ToString(), SQLMatchType.Equal);

        return DataAccessFactory.CreateACDebitCreditRuleDataAccess().GetIL(null, null, String.Empty, fe, DatabaseOperationType.LoadWithFilterExpression)[0];
        }

        #endregion Get


        #endregion
    }
}
