import { Component, OnInit, Output,EventEmitter } from '@angular/core';
import { LoginUser } from 'src/app/login-form/login-user';
import { AuthenticationService } from 'src/app/login-form/service/authentication.service';


@Component({
  selector: 'app-header',
  templateUrl: './header.component.html',
  styleUrls: ['./header.component.css']
})
export class HeaderComponent implements OnInit {

  shouldRun=false;
 
  isSmScreen=false;

  loginuser : LoginUser = new LoginUser();

  @Output() menuToggle=new EventEmitter<boolean>();
   private menuFlag:boolean=false;

   
  
  
  constructor(private loginApiService: AuthenticationService) { 
    console.log(this.loginApiService.userValue);
    this.loginuser = this.loginApiService.userValue;
    console.log(this.loginuser.firstName);
  }

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
