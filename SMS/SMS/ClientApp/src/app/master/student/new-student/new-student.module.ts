import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';

import { NewStudentRoutingModule } from './new-student-routing.module';
import { NewStudentComponent } from './new-student.component';
import { StudentDetailsComponent } from './student-details/student-details.component';
import { SharedModule } from 'src/app/shared/shared.module';
import { ParentsGuardianDetailsComponent } from './parents-guardian-details/parents-guardian-details.component';
import { DocumentComponent } from './document/document.component';
import { PGFormComponent } from './parents-guardian-details/p-g-form/p-g-form.component';
import { MasterModule } from '../../master.module';



@NgModule({
  declarations: [NewStudentComponent, StudentDetailsComponent, ParentsGuardianDetailsComponent, 
    DocumentComponent, PGFormComponent],
  imports: [
    CommonModule,
    NewStudentRoutingModule,
    SharedModule,
    MasterModule
  ]
})
export class NewStudentModule { }
