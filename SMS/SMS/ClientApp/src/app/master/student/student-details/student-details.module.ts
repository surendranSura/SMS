import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';

import { StudentDetailsRoutingModule } from './student-details-routing.module';
import { StudentDetailsComponent } from './student-details.component';
import { StudentDemographComponent } from './student-demograph/student-demograph.component';
import { SharedModule } from 'src/app/shared/shared.module';


@NgModule({
  declarations: [StudentDetailsComponent, StudentDemographComponent],
  imports: [
    CommonModule,
    StudentDetailsRoutingModule,
    SharedModule
  ]
})
export class StudentDetailsModule { }
