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
    public sealed partial class ACMDDebitCreditFacade : IACMDDebitCreditFacade
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

        public ACMDDebitCreditFacade()
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

        ~ACMDDebitCreditFacade()
        {
            Dispose(false);
        }

        #endregion


        #region Business Facade


        #region Save Update Delete

        [OperationContract]
        Int64 IACMDDebitCreditFacade.Add(ACMDDebitCreditEntity aCMDDebitCreditEntity, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateACMDDebitCreditDataAccess().Add(aCMDDebitCreditEntity, option, reqTran);
        }

        [OperationContract]
        Int64 IACMDDebitCreditFacade.Update(ACMDDebitCreditEntity aCMDDebitCreditEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateACMDDebitCreditDataAccess().Update(aCMDDebitCreditEntity, filterExpression, option, reqTran);
        }

        [OperationContract]
        Int64 IACMDDebitCreditFacade.Delete(ACMDDebitCreditEntity aCMDDebitCreditEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateACMDDebitCreditDataAccess().Delete(aCMDDebitCreditEntity, filterExpression, option, reqTran);
        }

        #endregion Save Update Delete

        #region Save Update Delete List

        [OperationContract]
        IList<Int64> IACMDDebitCreditFacade.Add(IList<ACMDDebitCreditEntity> aCMDDebitCreditEntityList, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateACMDDebitCreditDataAccess().Add(aCMDDebitCreditEntityList, option, reqTran);
        }

        [OperationContract]
        IList<Int64> IACMDDebitCreditFacade.Update(IList<ACMDDebitCreditEntity> aCMDDebitCreditEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateACMDDebitCreditDataAccess().Update(aCMDDebitCreditEntityList, filterExpression, option, reqTran);
        }

        [OperationContract]
        IList<Int64> IACMDDebitCreditFacade.Delete(IList<ACMDDebitCreditEntity> aCMDDebitCreditEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateACMDDebitCreditDataAccess().Delete(aCMDDebitCreditEntityList, filterExpression, option, reqTran);
        }

        #endregion Save Update Delete List

        #region Get

        [OperationContract]
        IList<ACMDDebitCreditEntity> IACMDDebitCreditFacade.GetIL(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option)
        {
            return DataAccessFactory.CreateACMDDebitCreditDataAccess().GetIL(currentPage, pageSize, sortExpression, filterExpression, option);
        }

        [OperationContract]
        DataTable IACMDDebitCreditFacade.GetDT(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option)
        {
            return DataAccessFactory.CreateACMDDebitCreditDataAccess().GetDT(currentPage, pageSize, sortExpression, filterExpression, option);
        }

        [OperationContract]
        ACMDDebitCreditEntity IACMDDebitCreditFacade.GetByID(Int64 iD)
        {
        String fe = SqlExpressionBuilder.PrepareFilterExpression(ACMDDebitCreditEntity.FLD_NAME_MDDebitCreditID, iD.ToString(), SQLMatchType.Equal);

        return DataAccessFactory.CreateACMDDebitCreditDataAccess().GetIL(null, null, String.Empty, fe, DatabaseOperationType.LoadWithFilterExpression)[0];
        }

        #endregion Get


        #endregion
    }
}
