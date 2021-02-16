import { Injectable } from '@angular/core';
import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Observable, throwError } from 'rxjs';
import { retry, catchError } from 'rxjs/operators';

import { CompileShallowModuleMetadata } from '@angular/compiler';
import { Console } from 'console';
import { Staff } from './Staff';

@Injectable({
  providedIn: 'root'
})
export class StaffrestApiService {

  apiURL = 'api/api/Staff';

  constructor(private http: HttpClient) { }

  /*========================================
    CRUD Methods for consuming RESTful API
  =========================================*/

  // Http Options
  httpOptions = {
    headers: new HttpHeaders({
      'Content-Type': 'application/json'
    })
  }  

  // HttpClient API get() method => Fetch Staffs list
  getStaffs(): Observable<Staff> {
    console.log('Inside get staff');
    return this.http.get<Staff>(this.apiURL)
    .pipe(
      retry(1),
      catchError(this.handleError)
    )
  }

  // HttpClient API get() method => Fetch Staff
  getStaff(id : any): Observable<Staff> {
    return this.http.get<Staff>(this.apiURL + id)
    .pipe(
      retry(1),
      catchError(this.handleError)
    )
  }  

  // HttpClient API post() method => Create Staff
  createStaff(staff : Staff): Observable<Staff> {
    return this.http.post<Staff>(this.apiURL,staff, this.httpOptions)
    .pipe(
      retry(1),
      catchError(this.handleError)
    )

  }  

  // HttpClient API put() method => Update Staff
  updateStaff(id : any, staff : Staff): Observable<Staff> {
    return this.http.put<Staff>(this.apiURL + id, JSON.stringify(staff), this.httpOptions)
    .pipe(
      retry(1),
      catchError(this.handleError)
    )
  }

  // HttpClient API delete() method => Delete Staff
  deleteStaff(id : any){
    return this.http.delete<Staff>(this.apiURL + id, this.httpOptions)
    .pipe(
      retry(1),
      catchError(this.handleError)
    )
  }

  // Error handling 
  handleError(error: any) {
     let errorMessage = '';
     if(error.error instanceof ErrorEvent) {
       // Get client-side error
       errorMessage = error.error.message;
     } else {
       // Get server-side error
       errorMessage = `Error Code: ${error.status}\nMessage: ${error.message}`;
     }
     window.alert(errorMessage);
     return throwError(errorMessage);
  }
}
