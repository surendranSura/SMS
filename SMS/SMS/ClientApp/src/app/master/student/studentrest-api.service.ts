import { Injectable } from '@angular/core';
import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Observable, Subject, throwError } from 'rxjs';
import { retry, catchError } from 'rxjs/operators';

import { CompileShallowModuleMetadata } from '@angular/compiler';
import { Console } from 'console';
import { Student, Dependents } from './student';
import { BlockUI, NgBlockUI } from 'ng-block-ui';

@Injectable({
  providedIn: 'root'
})
export class StudentrestApiService {

  apiURL = 'api/api/Student/';
  @BlockUI() blockUI: NgBlockUI;

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

  // HttpClient API get() method => Fetch Students list
  getStudents(): Observable<Student> {
    return this.http.get<Student>(this.apiURL)
    .pipe(
      retry(1),
      catchError((err)=>this.handleError(err))
    )
  }

  // HttpClient API get() method => Fetch Student
  getStudent(id : any): Observable<Student> {
    return this.http.get<Student>(this.apiURL + id)
    .pipe(
      retry(1),
      catchError((err)=>this.handleError(err))
    )
  }  

  // HttpClient API post() method => Create Student
  createStudent(student : Student): Observable<Student> {
    console.log(JSON.stringify(student));
    return this.http.post<Student>('api/api/Student',student, this.httpOptions)
    .pipe(
      retry(1),
      catchError((err)=>this.handleError(err))
    )

  }  

  // HttpClient API put() method => Update Student
  updateStudent(id : any, student : Student): Observable<Student> {
    return this.http.put<Student>(this.apiURL + id, JSON.stringify(student), this.httpOptions)
    .pipe(
      retry(1),
      catchError((err)=>this.handleError(err))
    )
  }

  // HttpClient API delete() method => Delete Student
  deleteStudent(id : any){
    return this.http.delete<Student>(this.apiURL + id, this.httpOptions)
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
