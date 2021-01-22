import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { SigninComponent } from '../components/signin/signin.component';
import { NewStaffComponent } from './components/staff/new-staff/new-staff.component';

import { MasterComponent } from './master.component';

const routes: Routes = [
  {
     path: '', component: MasterComponent,
     children:[
      {
        path: 'new-staff', component: NewStaffComponent,
      
      },
      { path: 'student', loadChildren: () => import('./student/student-details/student-details.module').then(m => m.StudentDetailsModule) }

     ]
 },
 
  
];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule]
})
export class MasterRoutingModule { }
