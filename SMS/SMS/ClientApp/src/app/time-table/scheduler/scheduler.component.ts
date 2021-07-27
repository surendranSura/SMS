import { Component, OnInit, CUSTOM_ELEMENTS_SCHEMA } from '@angular/core';

@Component({
  selector: 'app-scheduler',
  templateUrl: './scheduler.component.html',
  styleUrls: ['./scheduler.component.css']
})
export class SchedulerComponent implements OnInit {

  viewDate: Date = new Date();
  events = [];

  constructor() { }

  ngOnInit(): void {
  }

}
