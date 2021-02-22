import { Injectable } from '@angular/core';
import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Observable, throwError } from 'rxjs';
import { retry, catchError } from 'rxjs/operators';

import { CompileShallowModuleMetadata } from '@angular/compiler';
import { Console } from 'console';
import { Student, Dependents } from './student';

@Injectable({
  providedIn: 'root'
})
export class StudentrestApiService {

  apiURL = 'api/api/Student';

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
      catchError(this.handleError)
    )
  }

  // HttpClient API get() method => Fetch Student
  getStudent(id : any): Observable<Student> {
    return this.http.get<Student>(this.apiURL + id)
    .pipe(
      retry(1),
      catchError(this.handleError)
    )
  }  

  // HttpClient API post() method => Create Student
  createStudent(student : Student): Observable<Student> {
    return this.http.post<Student>(this.apiURL,student, this.httpOptions)
    .pipe(
      retry(1),
      catchError(this.handleError)
    )

  }  

  // HttpClient API put() method => Update Student
  updateStudent(id : any, student : Student): Observable<Student> {
    return this.http.put<Student>(this.apiURL + id, JSON.stringify(student), this.httpOptions)
    .pipe(
      retry(1),
      catchError(this.handleError)
    )
  }

  // HttpClient API delete() method => Delete Student
  deleteStudent(id : any){
    return this.http.delete<Student>(this.apiURL + id, this.httpOptions)
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