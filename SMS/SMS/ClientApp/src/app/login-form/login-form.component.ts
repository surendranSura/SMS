import { Component } from '@angular/core';

import { Router } from '@angular/router';
import { AuthenticationService } from './service/authentication.service';

@Component({
  selector: 'app-login-form',
  templateUrl: './login-form.component.html',
  styleUrls: ['./login-form.component.css']
})
export class LoginFormComponent {

  

  constructor(private router: Router,private authService:AuthenticationService) { 

  }

 
  authUser()
  {
    this.authService.getAuth("test1","password1").subscribe(res=>{
      console.log(res);
    },err=>{console.log(err)});

     this.router.navigate(['/MainPage']);
  
  }

}
