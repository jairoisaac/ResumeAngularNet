import { Injectable } from '@angular/core';
import { IExperience } from '../experience/experience';
import { HttpClient, HttpErrorResponse } from '@angular/common/http'
import { IEducation } from '../education/education';
import { IContact } from '../contact/contact';
import { ICertification } from '../certifications/certification';
import { Observable, throwError } from 'rxjs';
import { catchError, tap } from 'rxjs/operators';

@Injectable({
  providedIn: 'root'
})
export class dataService {
    constructor(private http: HttpClient) { }
     private certificationsUrl = 'https://localhost:44352/api/Certifications';
     private contactUrl = 'https://localhost:44352/api/Contact';
     private experienceUrl = 'https://localhost:44352/api/Experiences';
     private educationUrl = 'https://localhost:44352/api/Education';
    //private experienceUrl = 'api/experience/experience.json';
  //private educationUrl = 'api/education/education.json';
  getCertifications(): Observable<string[]> {
    return this.http.get<string[]>(this.certificationsUrl).pipe(
      tap(data => console.log('All: ' + JSON.stringify(data))),
      catchError(this.handleError)
    );
  }

   getContact(): Observable<IContact> {
      return this.http.get<IContact>(this.contactUrl).pipe(
        tap(data => console.log('All: ' + JSON.stringify(data))),
        catchError(this.handleError)
      );
    }

    getEducation(): Observable<IEducation[]> {
        return this.http.get<IEducation[]>(this.educationUrl).pipe(
            tap(data => console.log('All: '+ JSON.stringify(data))),
            catchError(this.handleError)
        );
    }
    getExperience(): Observable<IExperience[]> {
        return this.http.get<IExperience[]>(this.experienceUrl).pipe(
            tap(data => console.log('All: '+ JSON.stringify(data))),
            catchError(this.handleError)
        );
    }
    private handleError(err: HttpErrorResponse){
        let errorMessage = '';
        if (err.error instanceof ErrorEvent) {
            errorMessage = 'An error occurred: ${err.error.message}';
        } else {
             errorMessage = 'Server returned code: ${err.status}, error message is: ${err.message}' ;
        }
        console.error(errorMessage);
        return throwError(errorMessage);
    }
    
}
