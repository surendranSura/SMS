import { NgModule } from '@angular/core';
// import { CommonModule } from '@angular/common';
import { SchedulerComponent } from './scheduler/scheduler.component';

import { CalendarModule, DateAdapter } from 'angular-calendar';
import { adapterFactory } from 'angular-calendar/date-adapters/date-fns';
// import { BrowserAnimationsModule } from '@angular/platform-browser/animations';

@NgModule({
  declarations: [SchedulerComponent],
  imports: [
    // CommonModule,
    // BrowserAnimationsModule,
    CalendarModule.forRoot({
      provide: DateAdapter,
      useFactory: adapterFactory
    })
  ]
})
export class TimeTableModule { }
