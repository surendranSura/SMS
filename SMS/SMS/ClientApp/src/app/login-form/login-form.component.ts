import { Component } from '@angular/core';
import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Observable } from 'node_modules/rxjs';
import { UserCreds } from '../UserCreds';
import { catchError, map, tap } from 'rxjs/operators';
import { of } from 'rxjs';
import { Router } from '@angular/router';

@Component({
  selector: 'app-login-form',
  templateUrl: './login-form.component.html',
  styleUrls: ['./login-form.component.css']
})
export class LoginFormComponent {

  showFiller = false;

  private _postdata = {
    username : 'test1',
    password : 'password1'
  }

  httpOptions = {
    headers: new HttpHeaders(
      { 'Content-Type': 'application/json' }
      )
  };

  private AuthUrl = 'http://localhost:51714/api/Auth/UserAuth';  // URL to web api

  constructor(private http: HttpClient, private router: Router) { }

  LoginType = ['Really Smart', 'Super Flexible',
            'Super Hot', 'Weather Changer'];

  model = new UserCreds(18, 'Dr IQ', '123','');

  submitted = false;

  onSubmit() { this.submitted = true; }

  get diagnostic() { return JSON.stringify(this.model); }

  Authuser()
  {
    // this.router.navigate(['/signin']);
     this.http.post(this.AuthUrl,this._postdata).subscribe(resposne =>
       {
        console.log(Response.toString())
       });
  }

}

/**
 * Handle Http operation that failed.
 * Let the app continue.
 * @param operation - name of the operation that failed
 * @param result - optional value to return as the observable result
 */