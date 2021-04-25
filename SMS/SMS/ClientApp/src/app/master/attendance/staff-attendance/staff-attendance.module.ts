import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';

import { StaffAttendanceRoutingModule } from './staff-attendance-routing.module';
import { StaffAttendanceComponent } from './staff-attendance.component';
import { ReactiveFormsModule } from '@angular/forms';
import { AngularMaterialModule } from 'src/angular-material.module';


@NgModule({
  declarations: [StaffAttendanceComponent],
  imports: [
    CommonModule,
    StaffAttendanceRoutingModule,
    AngularMaterialModule,
    ReactiveFormsModule
  ]
})
export class StaffAttendanceModule { }
