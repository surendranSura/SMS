import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-timetable-classes',
  templateUrl: './timetable-classes.component.html',
  styleUrls: ['./timetable-classes.component.css']
})
export class TimetableClassesComponent implements OnInit {
  standard:any=
  [{
    className:"1"},{className:"2"},{className:"3"},{className:"4"},{className:"5"},{className:"6"},{className:"7"},{className:"8"},{className:"9"},{className:"10"}];

  constructor() { }

  ngOnInit(): void {
  }

}
