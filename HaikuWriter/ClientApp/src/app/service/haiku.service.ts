import { Injectable } from '@angular/core';
import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Observable } from 'rxjs';
import { HaikuLine } from '../models/haiku-line.model';

@Injectable({
  providedIn: 'root'
})
export class HaikuService {
  queryString: string = 'https://localhost:5001/Haiku/';

  constructor(private http: HttpClient) { }

  GetUnapprovedHaikuLines(): Observable<HaikuLine[]> {
    return this.http.get<HaikuLine[]>(`${this.queryString}unapprovedHaikuLine`);
  }

}
