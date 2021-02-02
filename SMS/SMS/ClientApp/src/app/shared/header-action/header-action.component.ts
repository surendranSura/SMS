import {  Component, OnInit, Output,EventEmitter } from '@angular/core';
import { Router } from '@angular/router'
@Component({
  selector: 'app-header-action',
  templateUrl: './header-action.component.html',
  styleUrls: ['./header-action.component.css']
})
export class HeaderActionComponent implements OnInit {

  constructor(private router:Router) { }

  ngOnInit(): void {
  }

  staffListOpen(){
    // this.stafflistOpen=true;
    // this.stafflist.emit(this.stafflistOpen);
    this.router.navigate(['/main/staff-list']);
  }
}
