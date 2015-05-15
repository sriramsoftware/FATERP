// Copyright and All Rights Reserved by
//B2B Solution, Bangladesh;
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 28-Dec-2011, 07:18:54




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
    public sealed partial class CMProjectScheduleTemplateItemMapFacade : ICMProjectScheduleTemplateItemMapFacade
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

        public CMProjectScheduleTemplateItemMapFacade()
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

        ~CMProjectScheduleTemplateItemMapFacade()
        {
            Dispose(false);
        }

        #endregion


        #region Business Facade


        #region Save Update Delete

        [OperationContract]
        Int64 ICMProjectScheduleTemplateItemMapFacade.Add(CMProjectScheduleTemplateItemMapEntity cMProjectScheduleTemplateItemMapEntity, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateCMProjectScheduleTemplateItemMapDataAccess().Add(cMProjectScheduleTemplateItemMapEntity, option, reqTran);
        }

        [OperationContract]
        Int64 ICMProjectScheduleTemplateItemMapFacade.Update(CMProjectScheduleTemplateItemMapEntity cMProjectScheduleTemplateItemMapEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateCMProjectScheduleTemplateItemMapDataAccess().Update(cMProjectScheduleTemplateItemMapEntity, filterExpression, option, reqTran);
        }

        [OperationContract]
        Int64 ICMProjectScheduleTemplateItemMapFacade.Delete(CMProjectScheduleTemplateItemMapEntity cMProjectScheduleTemplateItemMapEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateCMProjectScheduleTemplateItemMapDataAccess().Delete(cMProjectScheduleTemplateItemMapEntity, filterExpression, option, reqTran);
        }

        #endregion Save Update Delete

        #region Save Update Delete List

        [OperationContract]
        IList<Int64> ICMProjectScheduleTemplateItemMapFacade.Add(IList<CMProjectScheduleTemplateItemMapEntity> cMProjectScheduleTemplateItemMapEntityList, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateCMProjectScheduleTemplateItemMapDataAccess().Add(cMProjectScheduleTemplateItemMapEntityList, option, reqTran);
        }

        [OperationContract]
        IList<Int64> ICMProjectScheduleTemplateItemMapFacade.Update(IList<CMProjectScheduleTemplateItemMapEntity> cMProjectScheduleTemplateItemMapEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateCMProjectScheduleTemplateItemMapDataAccess().Update(cMProjectScheduleTemplateItemMapEntityList, filterExpression, option, reqTran);
        }

        [OperationContract]
        IList<Int64> ICMProjectScheduleTemplateItemMapFacade.Delete(IList<CMProjectScheduleTemplateItemMapEntity> cMProjectScheduleTemplateItemMapEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateCMProjectScheduleTemplateItemMapDataAccess().Delete(cMProjectScheduleTemplateItemMapEntityList, filterExpression, option, reqTran);
        }

        #endregion Save Update Delete List

        #region Get

        [OperationContract]
        IList<CMProjectScheduleTemplateItemMapEntity> ICMProjectScheduleTemplateItemMapFacade.GetIL(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option)
        {
            return DataAccessFactory.CreateCMProjectScheduleTemplateItemMapDataAccess().GetIL(currentPage, pageSize, sortExpression, filterExpression, option);
        }

        [OperationContract]
        DataTable ICMProjectScheduleTemplateItemMapFacade.GetDT(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option)
        {
            return DataAccessFactory.CreateCMProjectScheduleTemplateItemMapDataAccess().GetDT(currentPage, pageSize, sortExpression, filterExpression, option);
        }

        [OperationContract]
        CMProjectScheduleTemplateItemMapEntity ICMProjectScheduleTemplateItemMapFacade.GetByID(Int64 iD)
        {
        String fe = SqlExpressionBuilder.PrepareFilterExpression(CMProjectScheduleTemplateItemMapEntity.FLD_NAME_ProjectScheduleTemplateItemMapID, iD.ToString(), SQLMatchType.Equal);

        return DataAccessFactory.CreateCMProjectScheduleTemplateItemMapDataAccess().GetIL(null, null, String.Empty, fe, DatabaseOperationType.LoadWithFilterExpression)[0];
        }

        #endregion Get


        #endregion
    }
}
