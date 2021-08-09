import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';

import { ClassTimetableRoutingModule } from './class-timetable-routing.module';
import { ClassTimetableComponent } from './class-timetable.component';
import { TimeTableEditorComponent } from './time-table-editor/time-table-editor.component';


@NgModule({
  declarations: [ClassTimetableComponent, TimeTableEditorComponent],
  imports: [
    CommonModule,
    ClassTimetableRoutingModule
  ]
})
export class ClassTimetableModule { }
