import { Component, OnInit, Output,EventEmitter } from '@angular/core';


@Component({
  selector: 'app-header',
  templateUrl: './header.component.html',
  styleUrls: ['./header.component.css']
})
export class HeaderComponent implements OnInit {

  shouldRun=false;
 
  isSmScreen=false;

  @Output() menuToggle=new EventEmitter<boolean>();
   private menuFlag:boolean=false;
  constructor() { }

  ngOnInit(): void {
    //For Mobile page demo
   this.isSmScreen= window.matchMedia('(max-width: 600px)').matches;
   console.log(this.isSmScreen)
  }

  menuToggleAction(){
    this.menuFlag=!this.menuFlag;
    this.menuToggle.emit(this.menuFlag);
  }

}
