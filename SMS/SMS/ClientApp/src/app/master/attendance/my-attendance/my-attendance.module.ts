import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';

import { MyAttendanceRoutingModule } from './my-attendance-routing.module';
import { MyAttendanceComponent } from './my-attendance.component';
import { AngularMaterialModule } from 'src/angular-material.module';


@NgModule({
  declarations: [MyAttendanceComponent],
  imports: [
    CommonModule,
    MyAttendanceRoutingModule,
    AngularMaterialModule
  ]
})
export class MyAttendanceModule { }
