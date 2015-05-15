// Copyright and All Rights Reserved by
//B2B Solution, Bangladesh;
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 18-Jan-2012, 04:09:33




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
    public sealed partial class CMProjectMilestoneFacade : ICMProjectMilestoneFacade
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

        public CMProjectMilestoneFacade()
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

        ~CMProjectMilestoneFacade()
        {
            Dispose(false);
        }

        #endregion


        #region Business Facade


        #region Save Update Delete

        [OperationContract]
        Int64 ICMProjectMilestoneFacade.Add(CMProjectMilestoneEntity cMProjectMilestoneEntity, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateCMProjectMilestoneDataAccess().Add(cMProjectMilestoneEntity, option, reqTran);
        }

        [OperationContract]
        Int64 ICMProjectMilestoneFacade.Update(CMProjectMilestoneEntity cMProjectMilestoneEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateCMProjectMilestoneDataAccess().Update(cMProjectMilestoneEntity, filterExpression, option, reqTran);
        }

        [OperationContract]
        Int64 ICMProjectMilestoneFacade.Delete(CMProjectMilestoneEntity cMProjectMilestoneEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateCMProjectMilestoneDataAccess().Delete(cMProjectMilestoneEntity, filterExpression, option, reqTran);
        }

        #endregion Save Update Delete

        #region Save Update Delete List

        [OperationContract]
        IList<Int64> ICMProjectMilestoneFacade.Add(IList<CMProjectMilestoneEntity> cMProjectMilestoneEntityList, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateCMProjectMilestoneDataAccess().Add(cMProjectMilestoneEntityList, option, reqTran);
        }

        [OperationContract]
        IList<Int64> ICMProjectMilestoneFacade.Update(IList<CMProjectMilestoneEntity> cMProjectMilestoneEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateCMProjectMilestoneDataAccess().Update(cMProjectMilestoneEntityList, filterExpression, option, reqTran);
        }

        [OperationContract]
        IList<Int64> ICMProjectMilestoneFacade.Delete(IList<CMProjectMilestoneEntity> cMProjectMilestoneEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateCMProjectMilestoneDataAccess().Delete(cMProjectMilestoneEntityList, filterExpression, option, reqTran);
        }

        #endregion Save Update Delete List

        #region Get

        [OperationContract]
        IList<CMProjectMilestoneEntity> ICMProjectMilestoneFacade.GetIL(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option)
        {
            return DataAccessFactory.CreateCMProjectMilestoneDataAccess().GetIL(currentPage, pageSize, sortExpression, filterExpression, option);
        }

        [OperationContract]
        DataTable ICMProjectMilestoneFacade.GetDT(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option)
        {
            return DataAccessFactory.CreateCMProjectMilestoneDataAccess().GetDT(currentPage, pageSize, sortExpression, filterExpression, option);
        }

        [OperationContract]
        CMProjectMilestoneEntity ICMProjectMilestoneFacade.GetByID(Int64 iD)
        {
        String fe = SqlExpressionBuilder.PrepareFilterExpression(CMProjectMilestoneEntity.FLD_NAME_ProjectMilestoneID, iD.ToString(), SQLMatchType.Equal);

        return DataAccessFactory.CreateCMProjectMilestoneDataAccess().GetIL(null, null, String.Empty, fe, DatabaseOperationType.LoadWithFilterExpression)[0];
        }

        #endregion Get


        #endregion
    }
}
