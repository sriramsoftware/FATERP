// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 27-Jan-2013, 02:50:43




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
    public sealed partial class ACMDBankAccountTypeFacade : IACMDBankAccountTypeFacade
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

        public ACMDBankAccountTypeFacade()
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

        ~ACMDBankAccountTypeFacade()
        {
            Dispose(false);
        }

        #endregion


        #region Business Facade


        #region Save Update Delete

        [OperationContract]
        Int64 IACMDBankAccountTypeFacade.Add(ACMDBankAccountTypeEntity aCMDBankAccountTypeEntity, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateACMDBankAccountTypeDataAccess().Add(aCMDBankAccountTypeEntity, option, reqTran);
        }

        [OperationContract]
        Int64 IACMDBankAccountTypeFacade.Update(ACMDBankAccountTypeEntity aCMDBankAccountTypeEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateACMDBankAccountTypeDataAccess().Update(aCMDBankAccountTypeEntity, filterExpression, option, reqTran);
        }

        [OperationContract]
        Int64 IACMDBankAccountTypeFacade.Delete(ACMDBankAccountTypeEntity aCMDBankAccountTypeEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateACMDBankAccountTypeDataAccess().Delete(aCMDBankAccountTypeEntity, filterExpression, option, reqTran);
        }

        #endregion Save Update Delete

        #region Save Update Delete List

        [OperationContract]
        IList<Int64> IACMDBankAccountTypeFacade.Add(IList<ACMDBankAccountTypeEntity> aCMDBankAccountTypeEntityList, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateACMDBankAccountTypeDataAccess().Add(aCMDBankAccountTypeEntityList, option, reqTran);
        }

        [OperationContract]
        IList<Int64> IACMDBankAccountTypeFacade.Update(IList<ACMDBankAccountTypeEntity> aCMDBankAccountTypeEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateACMDBankAccountTypeDataAccess().Update(aCMDBankAccountTypeEntityList, filterExpression, option, reqTran);
        }

        [OperationContract]
        IList<Int64> IACMDBankAccountTypeFacade.Delete(IList<ACMDBankAccountTypeEntity> aCMDBankAccountTypeEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateACMDBankAccountTypeDataAccess().Delete(aCMDBankAccountTypeEntityList, filterExpression, option, reqTran);
        }

        #endregion Save Update Delete List

        #region Get

        [OperationContract]
        IList<ACMDBankAccountTypeEntity> IACMDBankAccountTypeFacade.GetIL(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option)
        {
            return DataAccessFactory.CreateACMDBankAccountTypeDataAccess().GetIL(currentPage, pageSize, sortExpression, filterExpression, option);
        }

        [OperationContract]
        DataTable IACMDBankAccountTypeFacade.GetDT(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option)
        {
            return DataAccessFactory.CreateACMDBankAccountTypeDataAccess().GetDT(currentPage, pageSize, sortExpression, filterExpression, option);
        }

        [OperationContract]
        ACMDBankAccountTypeEntity IACMDBankAccountTypeFacade.GetByID(Int64 iD)
        {
        String fe = SqlExpressionBuilder.PrepareFilterExpression(ACMDBankAccountTypeEntity.FLD_NAME_BankAccountTypeID, iD.ToString(), SQLMatchType.Equal);

        return DataAccessFactory.CreateACMDBankAccountTypeDataAccess().GetIL(null, null, String.Empty, fe, DatabaseOperationType.LoadWithFilterExpression)[0];
        }

        #endregion Get


        #endregion
    }
}
