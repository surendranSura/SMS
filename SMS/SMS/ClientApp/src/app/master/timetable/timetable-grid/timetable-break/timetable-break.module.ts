import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { TimetableBreakFormComponent } from './timetable-break-form/timetable-break-form.component';
import {MatDialogModule} from '@angular/material/dialog';



@NgModule({
  declarations: [TimetableBreakFormComponent],
  imports: [
    CommonModule,
    MatDialogModule
  ]
})
export class TimetableBreakModule { }
