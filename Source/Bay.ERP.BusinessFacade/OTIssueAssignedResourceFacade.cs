// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 20-Mar-2013, 10:57:47




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
    public sealed partial class OTIssueAssignedResourceFacade : IOTIssueAssignedResourceFacade
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

        public OTIssueAssignedResourceFacade()
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

        ~OTIssueAssignedResourceFacade()
        {
            Dispose(false);
        }

        #endregion


        #region Business Facade


        #region Save Update Delete

        [OperationContract]
        Int64 IOTIssueAssignedResourceFacade.Add(OTIssueAssignedResourceEntity oTIssueAssignedResourceEntity, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateOTIssueAssignedResourceDataAccess().Add(oTIssueAssignedResourceEntity, option, reqTran);
        }

        [OperationContract]
        Int64 IOTIssueAssignedResourceFacade.Update(OTIssueAssignedResourceEntity oTIssueAssignedResourceEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateOTIssueAssignedResourceDataAccess().Update(oTIssueAssignedResourceEntity, filterExpression, option, reqTran);
        }

        [OperationContract]
        Int64 IOTIssueAssignedResourceFacade.Delete(OTIssueAssignedResourceEntity oTIssueAssignedResourceEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateOTIssueAssignedResourceDataAccess().Delete(oTIssueAssignedResourceEntity, filterExpression, option, reqTran);
        }

        #endregion Save Update Delete

        #region Save Update Delete List

        [OperationContract]
        IList<Int64> IOTIssueAssignedResourceFacade.Add(IList<OTIssueAssignedResourceEntity> oTIssueAssignedResourceEntityList, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateOTIssueAssignedResourceDataAccess().Add(oTIssueAssignedResourceEntityList, option, reqTran);
        }

        [OperationContract]
        IList<Int64> IOTIssueAssignedResourceFacade.Update(IList<OTIssueAssignedResourceEntity> oTIssueAssignedResourceEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateOTIssueAssignedResourceDataAccess().Update(oTIssueAssignedResourceEntityList, filterExpression, option, reqTran);
        }

        [OperationContract]
        IList<Int64> IOTIssueAssignedResourceFacade.Delete(IList<OTIssueAssignedResourceEntity> oTIssueAssignedResourceEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateOTIssueAssignedResourceDataAccess().Delete(oTIssueAssignedResourceEntityList, filterExpression, option, reqTran);
        }

        #endregion Save Update Delete List

        #region Get

        [OperationContract]
        IList<OTIssueAssignedResourceEntity> IOTIssueAssignedResourceFacade.GetIL(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option)
        {
            return DataAccessFactory.CreateOTIssueAssignedResourceDataAccess().GetIL(currentPage, pageSize, sortExpression, filterExpression, option);
        }

        [OperationContract]
        DataTable IOTIssueAssignedResourceFacade.GetDT(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option)
        {
            return DataAccessFactory.CreateOTIssueAssignedResourceDataAccess().GetDT(currentPage, pageSize, sortExpression, filterExpression, option);
        }

        [OperationContract]
        OTIssueAssignedResourceEntity IOTIssueAssignedResourceFacade.GetByID(Int64 iD)
        {
        String fe = SqlExpressionBuilder.PrepareFilterExpression(OTIssueAssignedResourceEntity.FLD_NAME_IssueAssignedResourceID, iD.ToString(), SQLMatchType.Equal);

        return DataAccessFactory.CreateOTIssueAssignedResourceDataAccess().GetIL(null, null, String.Empty, fe, DatabaseOperationType.LoadWithFilterExpression)[0];
        }

        #endregion Get


        #endregion
    }
}
