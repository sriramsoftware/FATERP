// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 19-Dec-2013, 12:42:28




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
    public sealed partial class MDEducationalDegreeFacade : IMDEducationalDegreeFacade
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

        public MDEducationalDegreeFacade()
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

        ~MDEducationalDegreeFacade()
        {
            Dispose(false);
        }

        #endregion


        #region Business Facade


        #region Save Update Delete

        [OperationContract]
        Int64 IMDEducationalDegreeFacade.Add(MDEducationalDegreeEntity mDEducationalDegreeEntity, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateMDEducationalDegreeDataAccess().Add(mDEducationalDegreeEntity, option, reqTran);
        }

        [OperationContract]
        Int64 IMDEducationalDegreeFacade.Update(MDEducationalDegreeEntity mDEducationalDegreeEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateMDEducationalDegreeDataAccess().Update(mDEducationalDegreeEntity, filterExpression, option, reqTran);
        }

        [OperationContract]
        Int64 IMDEducationalDegreeFacade.Delete(MDEducationalDegreeEntity mDEducationalDegreeEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateMDEducationalDegreeDataAccess().Delete(mDEducationalDegreeEntity, filterExpression, option, reqTran);
        }

        #endregion Save Update Delete

        #region Save Update Delete List

        [OperationContract]
        IList<Int64> IMDEducationalDegreeFacade.Add(IList<MDEducationalDegreeEntity> mDEducationalDegreeEntityList, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateMDEducationalDegreeDataAccess().Add(mDEducationalDegreeEntityList, option, reqTran);
        }

        [OperationContract]
        IList<Int64> IMDEducationalDegreeFacade.Update(IList<MDEducationalDegreeEntity> mDEducationalDegreeEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateMDEducationalDegreeDataAccess().Update(mDEducationalDegreeEntityList, filterExpression, option, reqTran);
        }

        [OperationContract]
        IList<Int64> IMDEducationalDegreeFacade.Delete(IList<MDEducationalDegreeEntity> mDEducationalDegreeEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateMDEducationalDegreeDataAccess().Delete(mDEducationalDegreeEntityList, filterExpression, option, reqTran);
        }

        #endregion Save Update Delete List

        #region Get

        [OperationContract]
        IList<MDEducationalDegreeEntity> IMDEducationalDegreeFacade.GetIL(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option)
        {
            return DataAccessFactory.CreateMDEducationalDegreeDataAccess().GetIL(currentPage, pageSize, sortExpression, filterExpression, option);
        }

        [OperationContract]
        DataTable IMDEducationalDegreeFacade.GetDT(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option)
        {
            return DataAccessFactory.CreateMDEducationalDegreeDataAccess().GetDT(currentPage, pageSize, sortExpression, filterExpression, option);
        }

        [OperationContract]
        MDEducationalDegreeEntity IMDEducationalDegreeFacade.GetByID(Int64 iD)
        {
        String fe = SqlExpressionBuilder.PrepareFilterExpression(MDEducationalDegreeEntity.FLD_NAME_EducationalDegreeID, iD.ToString(), SQLMatchType.Equal);

        return DataAccessFactory.CreateMDEducationalDegreeDataAccess().GetIL(null, null, String.Empty, fe, DatabaseOperationType.LoadWithFilterExpression)[0];
        }

        #endregion Get


        #endregion
    }
}
