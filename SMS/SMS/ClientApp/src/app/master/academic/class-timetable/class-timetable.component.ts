import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-class-timetable',
  templateUrl: './class-timetable.component.html',
  styleUrls: ['./class-timetable.component.css']
})
export class ClassTimetableComponent implements OnInit {

  timePeriod = ['', '&#8544;', '&#8545;', '&#8546;', '&#8547;', '&#8548;', '&#8549;', '&#8550;', '&#8551;', '&#8552;'];
  slots = new Array(60);
  weekDay = ['Mon', 'Tue', 'Wed', 'Thu', 'Fri', 'Sat'];

  // number of break
  numBreaks = 0;

  constructor() { }

  ngOnInit(): void {
  }

  breakSet() {
    // to set after 
    this.numBreaks++;
    this.timePeriod.splice(4, 0, "Break");

    this.slots.length = (6 * this.timePeriod.length);
  }

  checkInt(va: number): boolean {
    if (va === 0) {
      return true;
    }
    va = va;
    va = va / this.timePeriod.length;
    return Number.isInteger(va);
  }

  checkBreak(va: number): boolean {
    let row = va / (this.timePeriod.length);
    //index - row
    row = Math.floor(row);
    if (this.timePeriod[(va - (row * this.timePeriod.length))] == "Break") {
      return true;
    }
    return false;
  }

}
