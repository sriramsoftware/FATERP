// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 24-Jun-2013, 05:04:04




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
    public sealed partial class ACResourceBankAccountMapFacade : IACResourceBankAccountMapFacade
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

        public ACResourceBankAccountMapFacade()
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

        ~ACResourceBankAccountMapFacade()
        {
            Dispose(false);
        }

        #endregion


        #region Business Facade


        #region Save Update Delete

        [OperationContract]
        Int64 IACResourceBankAccountMapFacade.Add(ACResourceBankAccountMapEntity aCResourceBankAccountMapEntity, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateACResourceBankAccountMapDataAccess().Add(aCResourceBankAccountMapEntity, option, reqTran);
        }

        [OperationContract]
        Int64 IACResourceBankAccountMapFacade.Update(ACResourceBankAccountMapEntity aCResourceBankAccountMapEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateACResourceBankAccountMapDataAccess().Update(aCResourceBankAccountMapEntity, filterExpression, option, reqTran);
        }

        [OperationContract]
        Int64 IACResourceBankAccountMapFacade.Delete(ACResourceBankAccountMapEntity aCResourceBankAccountMapEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateACResourceBankAccountMapDataAccess().Delete(aCResourceBankAccountMapEntity, filterExpression, option, reqTran);
        }

        #endregion Save Update Delete

        #region Save Update Delete List

        [OperationContract]
        IList<Int64> IACResourceBankAccountMapFacade.Add(IList<ACResourceBankAccountMapEntity> aCResourceBankAccountMapEntityList, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateACResourceBankAccountMapDataAccess().Add(aCResourceBankAccountMapEntityList, option, reqTran);
        }

        [OperationContract]
        IList<Int64> IACResourceBankAccountMapFacade.Update(IList<ACResourceBankAccountMapEntity> aCResourceBankAccountMapEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateACResourceBankAccountMapDataAccess().Update(aCResourceBankAccountMapEntityList, filterExpression, option, reqTran);
        }

        [OperationContract]
        IList<Int64> IACResourceBankAccountMapFacade.Delete(IList<ACResourceBankAccountMapEntity> aCResourceBankAccountMapEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateACResourceBankAccountMapDataAccess().Delete(aCResourceBankAccountMapEntityList, filterExpression, option, reqTran);
        }

        #endregion Save Update Delete List

        #region Get

        [OperationContract]
        IList<ACResourceBankAccountMapEntity> IACResourceBankAccountMapFacade.GetIL(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option)
        {
            return DataAccessFactory.CreateACResourceBankAccountMapDataAccess().GetIL(currentPage, pageSize, sortExpression, filterExpression, option);
        }

        [OperationContract]
        DataTable IACResourceBankAccountMapFacade.GetDT(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option)
        {
            return DataAccessFactory.CreateACResourceBankAccountMapDataAccess().GetDT(currentPage, pageSize, sortExpression, filterExpression, option);
        }

        [OperationContract]
        ACResourceBankAccountMapEntity IACResourceBankAccountMapFacade.GetByID(Int64 iD)
        {
        String fe = SqlExpressionBuilder.PrepareFilterExpression(ACResourceBankAccountMapEntity.FLD_NAME_ResourceBankAccountMapID, iD.ToString(), SQLMatchType.Equal);

        return DataAccessFactory.CreateACResourceBankAccountMapDataAccess().GetIL(null, null, String.Empty, fe, DatabaseOperationType.LoadWithFilterExpression)[0];
        }

        #endregion Get


        #endregion
    }
}
