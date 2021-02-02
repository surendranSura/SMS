import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class AuthenticationService {

  headers : HttpHeaders;

  constructor(private http: HttpClient) { 
    this.headers = new HttpHeaders({'Content-Type':'application/json; charset=utf-8'});
  }

  getAuth(loginJson : string){
    return this.http.post("api/api/Auth/UserAuth", loginJson, {headers: this.headers});
  }
}