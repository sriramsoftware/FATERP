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
    public sealed partial class MDEmployeeCompetencyLevelFacade : IMDEmployeeCompetencyLevelFacade
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

        public MDEmployeeCompetencyLevelFacade()
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

        ~MDEmployeeCompetencyLevelFacade()
        {
            Dispose(false);
        }

        #endregion


        #region Business Facade


        #region Save Update Delete

        [OperationContract]
        Int64 IMDEmployeeCompetencyLevelFacade.Add(MDEmployeeCompetencyLevelEntity mDEmployeeCompetencyLevelEntity, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateMDEmployeeCompetencyLevelDataAccess().Add(mDEmployeeCompetencyLevelEntity, option, reqTran);
        }

        [OperationContract]
        Int64 IMDEmployeeCompetencyLevelFacade.Update(MDEmployeeCompetencyLevelEntity mDEmployeeCompetencyLevelEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateMDEmployeeCompetencyLevelDataAccess().Update(mDEmployeeCompetencyLevelEntity, filterExpression, option, reqTran);
        }

        [OperationContract]
        Int64 IMDEmployeeCompetencyLevelFacade.Delete(MDEmployeeCompetencyLevelEntity mDEmployeeCompetencyLevelEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateMDEmployeeCompetencyLevelDataAccess().Delete(mDEmployeeCompetencyLevelEntity, filterExpression, option, reqTran);
        }

        #endregion Save Update Delete

        #region Save Update Delete List

        [OperationContract]
        IList<Int64> IMDEmployeeCompetencyLevelFacade.Add(IList<MDEmployeeCompetencyLevelEntity> mDEmployeeCompetencyLevelEntityList, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateMDEmployeeCompetencyLevelDataAccess().Add(mDEmployeeCompetencyLevelEntityList, option, reqTran);
        }

        [OperationContract]
        IList<Int64> IMDEmployeeCompetencyLevelFacade.Update(IList<MDEmployeeCompetencyLevelEntity> mDEmployeeCompetencyLevelEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateMDEmployeeCompetencyLevelDataAccess().Update(mDEmployeeCompetencyLevelEntityList, filterExpression, option, reqTran);
        }

        [OperationContract]
        IList<Int64> IMDEmployeeCompetencyLevelFacade.Delete(IList<MDEmployeeCompetencyLevelEntity> mDEmployeeCompetencyLevelEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateMDEmployeeCompetencyLevelDataAccess().Delete(mDEmployeeCompetencyLevelEntityList, filterExpression, option, reqTran);
        }

        #endregion Save Update Delete List

        #region Get

        [OperationContract]
        IList<MDEmployeeCompetencyLevelEntity> IMDEmployeeCompetencyLevelFacade.GetIL(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option)
        {
            return DataAccessFactory.CreateMDEmployeeCompetencyLevelDataAccess().GetIL(currentPage, pageSize, sortExpression, filterExpression, option);
        }

        [OperationContract]
        DataTable IMDEmployeeCompetencyLevelFacade.GetDT(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option)
        {
            return DataAccessFactory.CreateMDEmployeeCompetencyLevelDataAccess().GetDT(currentPage, pageSize, sortExpression, filterExpression, option);
        }

        [OperationContract]
        MDEmployeeCompetencyLevelEntity IMDEmployeeCompetencyLevelFacade.GetByID(Int64 iD)
        {
        String fe = SqlExpressionBuilder.PrepareFilterExpression(MDEmployeeCompetencyLevelEntity.FLD_NAME_EmployeeCompetencyLevelID, iD.ToString(), SQLMatchType.Equal);

        return DataAccessFactory.CreateMDEmployeeCompetencyLevelDataAccess().GetIL(null, null, String.Empty, fe, DatabaseOperationType.LoadWithFilterExpression)[0];
        }

        #endregion Get


        #endregion
    }
}
