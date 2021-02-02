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
   personData=
    {
      'personId': 3,
      'emailId': 'surendranvenkat@gmail.com',
      'mobile': 7845827645,
      'userName': 'sura',
      'password': 'sura@sms',
      'salt': '',
      'authToken': 'eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJ1bmlxdWVfbmFtZSI6InN1cmEiLCJuYmYiOjE2MTIyMDA2MjksImV4cCI6MTYxMjIwNDIyOSwiaWF0IjoxNjEyMjAwNjI5fQ.z0nl-pIH4vrBgLrxMs_4pggJxvYTQFfek_JdXSM4Xes',
      'roleId': '1',
      'firstName': 'surendran',
      'middleName': '',
      'lastName': 'v',
      'dob': '2017-06-15T00:00:00',
      'gender': 'M',
      'currentAddress': 'address1',
      'permanentAddress': 'address1',
      'aadharNumber': '123412341234',
      'bloodGroup': 'B+',
      'nationalityId': 1,
      'religionId': 1,
      'nationality': null,
      'religion': null,
      'students': [],
      'staff': []
  }
  
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
