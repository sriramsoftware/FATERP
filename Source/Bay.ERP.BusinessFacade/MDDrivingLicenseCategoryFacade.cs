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
    public sealed partial class MDDrivingLicenseCategoryFacade : IMDDrivingLicenseCategoryFacade
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

        public MDDrivingLicenseCategoryFacade()
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

        ~MDDrivingLicenseCategoryFacade()
        {
            Dispose(false);
        }

        #endregion


        #region Business Facade


        #region Save Update Delete

        [OperationContract]
        Int64 IMDDrivingLicenseCategoryFacade.Add(MDDrivingLicenseCategoryEntity mDDrivingLicenseCategoryEntity, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateMDDrivingLicenseCategoryDataAccess().Add(mDDrivingLicenseCategoryEntity, option, reqTran);
        }

        [OperationContract]
        Int64 IMDDrivingLicenseCategoryFacade.Update(MDDrivingLicenseCategoryEntity mDDrivingLicenseCategoryEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateMDDrivingLicenseCategoryDataAccess().Update(mDDrivingLicenseCategoryEntity, filterExpression, option, reqTran);
        }

        [OperationContract]
        Int64 IMDDrivingLicenseCategoryFacade.Delete(MDDrivingLicenseCategoryEntity mDDrivingLicenseCategoryEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateMDDrivingLicenseCategoryDataAccess().Delete(mDDrivingLicenseCategoryEntity, filterExpression, option, reqTran);
        }

        #endregion Save Update Delete

        #region Save Update Delete List

        [OperationContract]
        IList<Int64> IMDDrivingLicenseCategoryFacade.Add(IList<MDDrivingLicenseCategoryEntity> mDDrivingLicenseCategoryEntityList, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateMDDrivingLicenseCategoryDataAccess().Add(mDDrivingLicenseCategoryEntityList, option, reqTran);
        }

        [OperationContract]
        IList<Int64> IMDDrivingLicenseCategoryFacade.Update(IList<MDDrivingLicenseCategoryEntity> mDDrivingLicenseCategoryEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateMDDrivingLicenseCategoryDataAccess().Update(mDDrivingLicenseCategoryEntityList, filterExpression, option, reqTran);
        }

        [OperationContract]
        IList<Int64> IMDDrivingLicenseCategoryFacade.Delete(IList<MDDrivingLicenseCategoryEntity> mDDrivingLicenseCategoryEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateMDDrivingLicenseCategoryDataAccess().Delete(mDDrivingLicenseCategoryEntityList, filterExpression, option, reqTran);
        }

        #endregion Save Update Delete List

        #region Get

        [OperationContract]
        IList<MDDrivingLicenseCategoryEntity> IMDDrivingLicenseCategoryFacade.GetIL(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option)
        {
            return DataAccessFactory.CreateMDDrivingLicenseCategoryDataAccess().GetIL(currentPage, pageSize, sortExpression, filterExpression, option);
        }

        [OperationContract]
        DataTable IMDDrivingLicenseCategoryFacade.GetDT(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option)
        {
            return DataAccessFactory.CreateMDDrivingLicenseCategoryDataAccess().GetDT(currentPage, pageSize, sortExpression, filterExpression, option);
        }

        [OperationContract]
        MDDrivingLicenseCategoryEntity IMDDrivingLicenseCategoryFacade.GetByID(Int64 iD)
        {
        String fe = SqlExpressionBuilder.PrepareFilterExpression(MDDrivingLicenseCategoryEntity.FLD_NAME_DrivingLicenseCategoryID, iD.ToString(), SQLMatchType.Equal);

        return DataAccessFactory.CreateMDDrivingLicenseCategoryDataAccess().GetIL(null, null, String.Empty, fe, DatabaseOperationType.LoadWithFilterExpression)[0];
        }

        #endregion Get


        #endregion
    }
}
