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
    public sealed partial class MDEmployeeAdditionalInformationCategoryFacade : IMDEmployeeAdditionalInformationCategoryFacade
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

        public MDEmployeeAdditionalInformationCategoryFacade()
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

        ~MDEmployeeAdditionalInformationCategoryFacade()
        {
            Dispose(false);
        }

        #endregion


        #region Business Facade


        #region Save Update Delete

        [OperationContract]
        Int64 IMDEmployeeAdditionalInformationCategoryFacade.Add(MDEmployeeAdditionalInformationCategoryEntity mDEmployeeAdditionalInformationCategoryEntity, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateMDEmployeeAdditionalInformationCategoryDataAccess().Add(mDEmployeeAdditionalInformationCategoryEntity, option, reqTran);
        }

        [OperationContract]
        Int64 IMDEmployeeAdditionalInformationCategoryFacade.Update(MDEmployeeAdditionalInformationCategoryEntity mDEmployeeAdditionalInformationCategoryEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateMDEmployeeAdditionalInformationCategoryDataAccess().Update(mDEmployeeAdditionalInformationCategoryEntity, filterExpression, option, reqTran);
        }

        [OperationContract]
        Int64 IMDEmployeeAdditionalInformationCategoryFacade.Delete(MDEmployeeAdditionalInformationCategoryEntity mDEmployeeAdditionalInformationCategoryEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateMDEmployeeAdditionalInformationCategoryDataAccess().Delete(mDEmployeeAdditionalInformationCategoryEntity, filterExpression, option, reqTran);
        }

        #endregion Save Update Delete

        #region Save Update Delete List

        [OperationContract]
        IList<Int64> IMDEmployeeAdditionalInformationCategoryFacade.Add(IList<MDEmployeeAdditionalInformationCategoryEntity> mDEmployeeAdditionalInformationCategoryEntityList, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateMDEmployeeAdditionalInformationCategoryDataAccess().Add(mDEmployeeAdditionalInformationCategoryEntityList, option, reqTran);
        }

        [OperationContract]
        IList<Int64> IMDEmployeeAdditionalInformationCategoryFacade.Update(IList<MDEmployeeAdditionalInformationCategoryEntity> mDEmployeeAdditionalInformationCategoryEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateMDEmployeeAdditionalInformationCategoryDataAccess().Update(mDEmployeeAdditionalInformationCategoryEntityList, filterExpression, option, reqTran);
        }

        [OperationContract]
        IList<Int64> IMDEmployeeAdditionalInformationCategoryFacade.Delete(IList<MDEmployeeAdditionalInformationCategoryEntity> mDEmployeeAdditionalInformationCategoryEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateMDEmployeeAdditionalInformationCategoryDataAccess().Delete(mDEmployeeAdditionalInformationCategoryEntityList, filterExpression, option, reqTran);
        }

        #endregion Save Update Delete List

        #region Get

        [OperationContract]
        IList<MDEmployeeAdditionalInformationCategoryEntity> IMDEmployeeAdditionalInformationCategoryFacade.GetIL(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option)
        {
            return DataAccessFactory.CreateMDEmployeeAdditionalInformationCategoryDataAccess().GetIL(currentPage, pageSize, sortExpression, filterExpression, option);
        }

        [OperationContract]
        DataTable IMDEmployeeAdditionalInformationCategoryFacade.GetDT(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option)
        {
            return DataAccessFactory.CreateMDEmployeeAdditionalInformationCategoryDataAccess().GetDT(currentPage, pageSize, sortExpression, filterExpression, option);
        }

        [OperationContract]
        MDEmployeeAdditionalInformationCategoryEntity IMDEmployeeAdditionalInformationCategoryFacade.GetByID(Int64 iD)
        {
        String fe = SqlExpressionBuilder.PrepareFilterExpression(MDEmployeeAdditionalInformationCategoryEntity.FLD_NAME_EmployeeAdditionalInformationCategoryID, iD.ToString(), SQLMatchType.Equal);

        return DataAccessFactory.CreateMDEmployeeAdditionalInformationCategoryDataAccess().GetIL(null, null, String.Empty, fe, DatabaseOperationType.LoadWithFilterExpression)[0];
        }

        #endregion Get


        #endregion
    }
}
