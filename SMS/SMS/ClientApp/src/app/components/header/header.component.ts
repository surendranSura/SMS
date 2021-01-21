import { Component, OnInit, Output,EventEmitter } from '@angular/core';


@Component({
  selector: 'app-header',
  templateUrl: './header.component.html',
  styleUrls: ['./header.component.css']
})
export class HeaderComponent implements OnInit {

  showFiller = false;
  shouldRun=false;
  panelOpenState = false;


  @Output() menuToggle=new EventEmitter<boolean>();
   private menuFlag:boolean=false;
  constructor() { }

  ngOnInit(): void {
  }

  menuToggleAction(){
    this.menuFlag=!this.menuFlag;
    this.menuToggle.emit(this.menuFlag);
  }

}
