import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { FormControl, FormGroup } from '@angular/forms';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class AuthService {

  url ='https://localhost:7081/api/';
  
  constructor(private http: HttpClient) { }


  addJournalEntries(JournalEntry: string) : Observable<any> {
    return this.http.post(this.url+'JournalEntry',JournalEntry);
  }

  // login() : Promise<any> {
  //   return new Promise((resolve) => {
  //     localStorage.setItem('loggedIn', 'true');
  //     resolve(true);
  //   } )
  // }

  // isLoggedIn() : boolean{
  //   return !!localStorage.getItem('loggedIn')
  // }

  getAccountCategory(): Observable<any[]> {
    return this.http.get<any>(this.url+'accountcategory')
  }

  getAccount(id: string): Observable<any[]> {
    return this.http.get<any>(`${this.url}account/${id}`)
  }

  getJournalEntries() : Observable<any[]> {
    return this.http.get<any>(this.url+'JournalEntry');
  }
}
