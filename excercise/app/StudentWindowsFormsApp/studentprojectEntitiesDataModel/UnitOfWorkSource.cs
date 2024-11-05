using DevExpress.Mvvm;
using DevExpress.Mvvm.DataModel;
using DevExpress.Mvvm.DataModel.DesignTime;
using DevExpress.Mvvm.DataModel.EF6;
using StudentWindowsFormsApp;
using System;
using System.Collections;
using System.Linq;

namespace StudentWindowsFormsApp.studentprojectEntitiesDataModel {

    /// <summary>
    /// Provides methods to obtain the relevant IUnitOfWorkFactory.
    /// </summary>
    public static class UnitOfWorkSource {

		/// <summary>
        /// Returns the IUnitOfWorkFactory implementation.
        /// </summary>
        public static IUnitOfWorkFactory<IstudentprojectEntitiesUnitOfWork> GetUnitOfWorkFactory() {
            return new DbUnitOfWorkFactory<IstudentprojectEntitiesUnitOfWork>(() => new studentprojectEntitiesUnitOfWork(() => new studentprojectEntities()));
        }
    }
}