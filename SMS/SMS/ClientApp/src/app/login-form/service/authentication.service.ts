import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class AuthenticationService {

  constructor(private http: HttpClient) { }

  getAuth(username:string,password:string){
    return this.http.get("api/api/values");///api/api/values
   //return this.http.post("api/api/Auth/UserAuth",{username:username,password:password});
  }
}