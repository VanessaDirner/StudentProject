using DevExpress.Mvvm.DataModel;
using StudentWindowsFormsApp;
using System;
using System.Collections.Generic;
using System.Linq;

namespace StudentWindowsFormsApp.studentprojectEntitiesDataModel {

    /// <summary>
    /// IstudentprojectEntitiesUnitOfWork extends the IUnitOfWork interface with repositories representing specific entities.
    /// </summary>
    public interface IstudentprojectEntitiesUnitOfWork : IUnitOfWork {
        
        /// <summary>
        /// The assignment entities repository.
        /// </summary>
		IRepository<assignment, Guid> assignments { get; }
        
        /// <summary>
        /// The department entities repository.
        /// </summary>
		IRepository<department, Guid> departments { get; }
        
        /// <summary>
        /// The employee entities repository.
        /// </summary>
		IRepository<employee, Guid> employees { get; }
        
        /// <summary>
        /// The sysdiagram entities repository.
        /// </summary>
		IRepository<sysdiagram, int> sysdiagrams { get; }
    }
}
