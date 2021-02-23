import { Component,OnInit } from '@angular/core';
import { FormBuilder, Validators, FormGroup } from '@angular/forms';

import { ActivatedRoute, Router } from '@angular/router';
import { AuthenticationService } from './service/authentication.service';
import { first } from 'rxjs/operators';
import { environment } from 'src/environments/environment';

@Component({
  selector: 'app-login-form',
  templateUrl: './login-form.component.html',
  styleUrls: ['./login-form.component.css']
})
export class LoginFormComponent implements OnInit {

  loginForm : FormGroup;
  returnUrl: string;

  loading = false;
  submitted = false;

  constructor(private router: Router,
    private authService:AuthenticationService, 
    private route: ActivatedRoute,
    private loginFormBuilder : FormBuilder) { 

      this.loginForm = this.loginFormBuilder.group(
      {
        username: ['',Validators.required ],
        password: ['', Validators.required]
      }
      );

       // get return url from route parameters or default to '/'
       this.returnUrl = this.route.snapshot.queryParams['returnUrl'] || 'main';

    }

 
  authUser()
  {
    console.log(environment.isDevelopement);
    if (this.loginForm.invalid) {
     // return;

    }
    this.authService.getAuth(JSON.stringify(this.loginForm.value))
    .pipe(first())
            .subscribe(
                data => {
                    this.router.navigate([this.returnUrl]);
                },
                error => {
                    console.log(error);
                    this.loading = false;
                });
               
   if (environment.isDevelopement) 
      this.router.navigate([this.returnUrl]);
  }

  onSubmit() {

    this.submitted = true;

    // stop here if form is invalid
    
    

      
  }
   


  ngOnInit(): void {
  }

  // convenience getter for easy access to form fields
  get f() { return this.loginForm.controls; }

}
