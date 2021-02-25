import { DatePipe } from '@angular/common';
import { Component, OnInit, Output, EventEmitter, Input } from '@angular/core';
import { FormGroup } from '@angular/forms';
import { _MatTabBodyBase } from '@angular/material/tabs';
import { Router } from '@angular/router';
@Component({
  selector: 'app-header-action',
  templateUrl: './header-action.component.html',
  styleUrls: ['./header-action.component.css']
})
export class HeaderActionComponent implements OnInit {
  campaignTwo: FormGroup;
  @Input() index: number = 0;
  constructor(private router: Router) { }
   today:any = new Date();
   month:any = this.today.getMonth();
   year:any = this.today.getFullYear();

  // campaignTwo = new FormGroup({
  //   start: new FormControl(new Date(year, month, 15)),
  //   end: new FormControl(new Date(year, month, 19))
  // });
  ngOnInit(): void {
  }

  staffListOpen() {
    // this.stafflistOpen=true;
    // this.stafflist.emit(this.stafflistOpen);
    if (this.index === 1) {
      this.router.navigate(['/main/staff-list']);
    }
    else if (this.index === 0) {
      this.router.navigate(['/main/student-list']);
    }
    else if (this.index ===2){
      this.router.navigate(['/main/e-letter-list']);
    }
    else if (this.index ===3){
      this.router.navigate(['/main/staff-feedback-list']);
    }
    else if (this.index ===4){
      this.router.navigate(['/main/student-feedback-list']);
    }
  }
}
