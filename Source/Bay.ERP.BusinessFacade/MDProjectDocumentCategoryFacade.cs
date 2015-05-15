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
    public sealed partial class MDProjectDocumentCategoryFacade : IMDProjectDocumentCategoryFacade
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

        public MDProjectDocumentCategoryFacade()
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

        ~MDProjectDocumentCategoryFacade()
        {
            Dispose(false);
        }

        #endregion


        #region Business Facade


        #region Save Update Delete

        [OperationContract]
        Int64 IMDProjectDocumentCategoryFacade.Add(MDProjectDocumentCategoryEntity mDProjectDocumentCategoryEntity, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateMDProjectDocumentCategoryDataAccess().Add(mDProjectDocumentCategoryEntity, option, reqTran);
        }

        [OperationContract]
        Int64 IMDProjectDocumentCategoryFacade.Update(MDProjectDocumentCategoryEntity mDProjectDocumentCategoryEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateMDProjectDocumentCategoryDataAccess().Update(mDProjectDocumentCategoryEntity, filterExpression, option, reqTran);
        }

        [OperationContract]
        Int64 IMDProjectDocumentCategoryFacade.Delete(MDProjectDocumentCategoryEntity mDProjectDocumentCategoryEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateMDProjectDocumentCategoryDataAccess().Delete(mDProjectDocumentCategoryEntity, filterExpression, option, reqTran);
        }

        #endregion Save Update Delete

        #region Save Update Delete List

        [OperationContract]
        IList<Int64> IMDProjectDocumentCategoryFacade.Add(IList<MDProjectDocumentCategoryEntity> mDProjectDocumentCategoryEntityList, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateMDProjectDocumentCategoryDataAccess().Add(mDProjectDocumentCategoryEntityList, option, reqTran);
        }

        [OperationContract]
        IList<Int64> IMDProjectDocumentCategoryFacade.Update(IList<MDProjectDocumentCategoryEntity> mDProjectDocumentCategoryEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateMDProjectDocumentCategoryDataAccess().Update(mDProjectDocumentCategoryEntityList, filterExpression, option, reqTran);
        }

        [OperationContract]
        IList<Int64> IMDProjectDocumentCategoryFacade.Delete(IList<MDProjectDocumentCategoryEntity> mDProjectDocumentCategoryEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateMDProjectDocumentCategoryDataAccess().Delete(mDProjectDocumentCategoryEntityList, filterExpression, option, reqTran);
        }

        #endregion Save Update Delete List

        #region Get

        [OperationContract]
        IList<MDProjectDocumentCategoryEntity> IMDProjectDocumentCategoryFacade.GetIL(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option)
        {
            return DataAccessFactory.CreateMDProjectDocumentCategoryDataAccess().GetIL(currentPage, pageSize, sortExpression, filterExpression, option);
        }

        [OperationContract]
        DataTable IMDProjectDocumentCategoryFacade.GetDT(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option)
        {
            return DataAccessFactory.CreateMDProjectDocumentCategoryDataAccess().GetDT(currentPage, pageSize, sortExpression, filterExpression, option);
        }

        [OperationContract]
        MDProjectDocumentCategoryEntity IMDProjectDocumentCategoryFacade.GetByID(Int64 iD)
        {
        String fe = SqlExpressionBuilder.PrepareFilterExpression(MDProjectDocumentCategoryEntity.FLD_NAME_ProjectDocumentCategoryID, iD.ToString(), SQLMatchType.Equal);

        return DataAccessFactory.CreateMDProjectDocumentCategoryDataAccess().GetIL(null, null, String.Empty, fe, DatabaseOperationType.LoadWithFilterExpression)[0];
        }

        #endregion Get


        #endregion
    }
}
