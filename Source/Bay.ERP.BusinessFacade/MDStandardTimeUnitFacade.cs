// Copyright and All Rights Reserved by
//B2B Solution, Bangladesh;
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 06-Feb-2012, 04:08:22




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
    public sealed partial class MDStandardTimeUnitFacade : IMDStandardTimeUnitFacade
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

        public MDStandardTimeUnitFacade()
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

        ~MDStandardTimeUnitFacade()
        {
            Dispose(false);
        }

        #endregion


        #region Business Facade


        #region Save Update Delete

        [OperationContract]
        Int64 IMDStandardTimeUnitFacade.Add(MDStandardTimeUnitEntity mDStandardTimeUnitEntity, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateMDStandardTimeUnitDataAccess().Add(mDStandardTimeUnitEntity, option, reqTran);
        }

        [OperationContract]
        Int64 IMDStandardTimeUnitFacade.Update(MDStandardTimeUnitEntity mDStandardTimeUnitEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateMDStandardTimeUnitDataAccess().Update(mDStandardTimeUnitEntity, filterExpression, option, reqTran);
        }

        [OperationContract]
        Int64 IMDStandardTimeUnitFacade.Delete(MDStandardTimeUnitEntity mDStandardTimeUnitEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateMDStandardTimeUnitDataAccess().Delete(mDStandardTimeUnitEntity, filterExpression, option, reqTran);
        }

        #endregion Save Update Delete

        #region Save Update Delete List

        [OperationContract]
        IList<Int64> IMDStandardTimeUnitFacade.Add(IList<MDStandardTimeUnitEntity> mDStandardTimeUnitEntityList, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateMDStandardTimeUnitDataAccess().Add(mDStandardTimeUnitEntityList, option, reqTran);
        }

        [OperationContract]
        IList<Int64> IMDStandardTimeUnitFacade.Update(IList<MDStandardTimeUnitEntity> mDStandardTimeUnitEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateMDStandardTimeUnitDataAccess().Update(mDStandardTimeUnitEntityList, filterExpression, option, reqTran);
        }

        [OperationContract]
        IList<Int64> IMDStandardTimeUnitFacade.Delete(IList<MDStandardTimeUnitEntity> mDStandardTimeUnitEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateMDStandardTimeUnitDataAccess().Delete(mDStandardTimeUnitEntityList, filterExpression, option, reqTran);
        }

        #endregion Save Update Delete List

        #region Get

        [OperationContract]
        IList<MDStandardTimeUnitEntity> IMDStandardTimeUnitFacade.GetIL(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option)
        {
            return DataAccessFactory.CreateMDStandardTimeUnitDataAccess().GetIL(currentPage, pageSize, sortExpression, filterExpression, option);
        }

        [OperationContract]
        DataTable IMDStandardTimeUnitFacade.GetDT(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option)
        {
            return DataAccessFactory.CreateMDStandardTimeUnitDataAccess().GetDT(currentPage, pageSize, sortExpression, filterExpression, option);
        }

        [OperationContract]
        MDStandardTimeUnitEntity IMDStandardTimeUnitFacade.GetByID(Int64 iD)
        {
        String fe = SqlExpressionBuilder.PrepareFilterExpression(MDStandardTimeUnitEntity.FLD_NAME_StandardTimeUnitID, iD.ToString(), SQLMatchType.Equal);

        return DataAccessFactory.CreateMDStandardTimeUnitDataAccess().GetIL(null, null, String.Empty, fe, DatabaseOperationType.LoadWithFilterExpression)[0];
        }

        #endregion Get


        #endregion
    }
}
