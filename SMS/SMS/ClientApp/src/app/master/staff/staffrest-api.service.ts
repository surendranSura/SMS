import { Injectable } from '@angular/core';
import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Observable, Subject, throwError } from 'rxjs';
import { retry, catchError } from 'rxjs/operators';

import { CompileShallowModuleMetadata } from '@angular/compiler';
import { Console } from 'console';
import { Staff } from './Staff';
import { BlockUI, NgBlockUI } from 'ng-block-ui';

@Injectable({
  providedIn: 'root'
})
export class StaffrestApiService {
  @BlockUI() blockUI: NgBlockUI;
  apiURL = 'api/api/Staff';

  private formvalueSource = new Subject<string>();
  formValue$ = this.formvalueSource.asObservable();
  
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
    return this.http.get<Staff>(this.apiURL)
    .pipe(
      retry(1),
      catchError((err)=>this.handleError(err))
    )
  }

  // HttpClient API get() method => Fetch Staff
  getStaff(id : any): Observable<Staff> {
    return this.http.get<Staff>(this.apiURL + '/' + id)
    .pipe(
      retry(1),
      catchError((err)=>this.handleError(err))
    )
  }  

  // HttpClient API post() method => Create Staff
  createStaff(staff : Staff): Observable<Staff> {
    return this.http.post<Staff>(this.apiURL ,staff, this.httpOptions)
    .pipe(
      retry(1),
      catchError((err)=>this.handleError(err))
    )

  }  

  // HttpClient API put() method => Update Staff
  updateStaff(id : any, staff : Staff): Observable<Staff> {
    return this.http.put<Staff>(this.apiURL + '/' + id, JSON.stringify(staff), this.httpOptions)
    .pipe(
      retry(1),
      catchError((err)=>this.handleError(err))
    )
  }

  // HttpClient API delete() method => Delete Staff
  deleteStaff(id : any){
    return this.http.delete<Staff>(this.apiURL + '/'+ id, this.httpOptions)
    .pipe(
      retry(1),
      catchError((err)=>this.handleError(err))
    )
  }

  // Error handling 
  handleError(error: any) {
        this.blockUI.stop();
     

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
  setFormValue(value:any) {
    this.formvalueSource.next(value);
  }
}
