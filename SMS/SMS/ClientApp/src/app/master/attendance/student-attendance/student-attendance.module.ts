import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';

import { StudentAttendanceRoutingModule } from './student-attendance-routing.module';
import { StudentAttendanceComponent } from './student-attendance.component';
import { AngularMaterialModule } from 'src/angular-material.module';
import { ReactiveFormsModule } from '@angular/forms';


@NgModule({
  declarations: [StudentAttendanceComponent],
  imports: [
    CommonModule,
    StudentAttendanceRoutingModule,
    AngularMaterialModule,
    ReactiveFormsModule
  ]
})
export class StudentAttendanceModule { }
