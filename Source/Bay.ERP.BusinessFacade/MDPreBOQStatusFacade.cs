// Copyright and All Rights Reserved by
//B2B Solution, Bangladesh;
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 30-Nov-2011, 01:41:28




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
    public sealed partial class MDPreBOQStatusFacade : IMDPreBOQStatusFacade
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

        public MDPreBOQStatusFacade()
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

        ~MDPreBOQStatusFacade()
        {
            Dispose(false);
        }

        #endregion


        #region Business Facade


        #region Save Update Delete

        [OperationContract]
        Int64 IMDPreBOQStatusFacade.Add(MDPreBOQStatusEntity mDPreBOQStatusEntity, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateMDPreBOQStatusDataAccess().Add(mDPreBOQStatusEntity, option, reqTran);
        }

        [OperationContract]
        Int64 IMDPreBOQStatusFacade.Update(MDPreBOQStatusEntity mDPreBOQStatusEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateMDPreBOQStatusDataAccess().Update(mDPreBOQStatusEntity, filterExpression, option, reqTran);
        }

        [OperationContract]
        Int64 IMDPreBOQStatusFacade.Delete(MDPreBOQStatusEntity mDPreBOQStatusEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateMDPreBOQStatusDataAccess().Delete(mDPreBOQStatusEntity, filterExpression, option, reqTran);
        }

        #endregion Save Update Delete

        #region Save Update Delete List

        [OperationContract]
        IList<Int64> IMDPreBOQStatusFacade.Add(IList<MDPreBOQStatusEntity> mDPreBOQStatusEntityList, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateMDPreBOQStatusDataAccess().Add(mDPreBOQStatusEntityList, option, reqTran);
        }

        [OperationContract]
        IList<Int64> IMDPreBOQStatusFacade.Update(IList<MDPreBOQStatusEntity> mDPreBOQStatusEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateMDPreBOQStatusDataAccess().Update(mDPreBOQStatusEntityList, filterExpression, option, reqTran);
        }

        [OperationContract]
        IList<Int64> IMDPreBOQStatusFacade.Delete(IList<MDPreBOQStatusEntity> mDPreBOQStatusEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateMDPreBOQStatusDataAccess().Delete(mDPreBOQStatusEntityList, filterExpression, option, reqTran);
        }

        #endregion Save Update Delete List

        #region Get

        [OperationContract]
        IList<MDPreBOQStatusEntity> IMDPreBOQStatusFacade.GetIL(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option)
        {
            return DataAccessFactory.CreateMDPreBOQStatusDataAccess().GetIL(currentPage, pageSize, sortExpression, filterExpression, option);
        }

        [OperationContract]
        DataTable IMDPreBOQStatusFacade.GetDT(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option)
        {
            return DataAccessFactory.CreateMDPreBOQStatusDataAccess().GetDT(currentPage, pageSize, sortExpression, filterExpression, option);
        }

        [OperationContract]
        MDPreBOQStatusEntity IMDPreBOQStatusFacade.GetByID(Int64 iD)
        {
        String fe = SqlExpressionBuilder.PrepareFilterExpression(MDPreBOQStatusEntity.FLD_NAME_PreBOQStatusID, iD.ToString(), SQLMatchType.Equal);

        return DataAccessFactory.CreateMDPreBOQStatusDataAccess().GetIL(null, null, String.Empty, fe, DatabaseOperationType.LoadWithFilterExpression)[0];
        }

        #endregion Get


        #endregion
    }
}
