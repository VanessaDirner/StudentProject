using DevExpress.Mvvm.DataModel;
using DevExpress.Mvvm.DataModel.EF6;
using StudentWindowsFormsApp;
using System;
using System.Collections.Generic;
using System.Linq;

namespace StudentWindowsFormsApp.studentprojectEntitiesDataModel {

    /// <summary>
    /// A studentprojectEntitiesUnitOfWork instance that represents the run-time implementation of the IstudentprojectEntitiesUnitOfWork interface.
    /// </summary>
    public class studentprojectEntitiesUnitOfWork : DbUnitOfWork<studentprojectEntities>, IstudentprojectEntitiesUnitOfWork {

        public studentprojectEntitiesUnitOfWork(Func<studentprojectEntities> contextFactory)
            : base(contextFactory) {
        }

        IRepository<assignment, Guid> IstudentprojectEntitiesUnitOfWork.assignments {
            get { return GetRepository(x => x.Set<assignment>(), (assignment x) => x.assignmentID); }
        }

        IRepository<department, Guid> IstudentprojectEntitiesUnitOfWork.departments {
            get { return GetRepository(x => x.Set<department>(), (department x) => x.deptID); }
        }

        IRepository<employee, Guid> IstudentprojectEntitiesUnitOfWork.employees {
            get { return GetRepository(x => x.Set<employee>(), (employee x) => x.personID); }
        }

        IRepository<sysdiagram, int> IstudentprojectEntitiesUnitOfWork.sysdiagrams {
            get { return GetRepository(x => x.Set<sysdiagram>(), (sysdiagram x) => x.diagram_id); }
        }
    }
}
