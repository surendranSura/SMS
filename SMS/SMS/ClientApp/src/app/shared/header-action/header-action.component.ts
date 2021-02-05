import { Component, OnInit, Output, EventEmitter, Input } from '@angular/core';
import { Router } from '@angular/router'
@Component({
  selector: 'app-header-action',
  templateUrl: './header-action.component.html',
  styleUrls: ['./header-action.component.css']
})
export class HeaderActionComponent implements OnInit {

  @Input() index: number = 0;

  constructor(private router: Router) { }

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
  }
}
