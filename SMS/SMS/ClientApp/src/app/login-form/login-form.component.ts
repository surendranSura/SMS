import { Component,OnInit } from '@angular/core';
import { FormBuilder, Validators, FormGroup } from '@angular/forms';

import { Router } from '@angular/router';
import { AuthenticationService } from './service/authentication.service';

@Component({
  selector: 'app-login-form',
  templateUrl: './login-form.component.html',
  styleUrls: ['./login-form.component.css']
})
export class LoginFormComponent implements OnInit {

  loginForm : FormGroup;

  constructor(private router: Router,private authService:AuthenticationService, private loginFormBuilder : FormBuilder) { 

      this.loginForm = this.loginFormBuilder.group(
      {
        username: ['',Validators.required ],
        password: ['', Validators.required]
      }
      );

    }

 
  authUser()
  {
    this.authService.getAuth(JSON.stringify(this.loginForm.value)).subscribe(res=>{
      console.log(res);
    },err=>{console.log(err)});

     this.router.navigate(['/main']);
  
  }

  onSubmit() {
    // TODO: Use EventEmitter with form value
    console.warn(this.loginForm.value);
  }


  ngOnInit(): void {
  }

}
