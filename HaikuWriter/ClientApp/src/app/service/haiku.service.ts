import { Injectable } from '@angular/core';
import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Observable } from 'rxjs';
import { HaikuLine } from '../models/haiku-line.model';
import {Haiku} from '../models/haiku.model';
import { GenHaiku} from '../models/gen-haiku.model';

@Injectable({
  providedIn: 'root'
})
export class HaikuService {
  queryString: string = 'https://localhost:5001/Haiku/';

  constructor(private http: HttpClient) { }

  GetUnapprovedHaikuLines(): Observable<HaikuLine[]> {
    return this.http.get<HaikuLine[]>(`${this.queryString}unapprovedHaikuLine`);
  }
  GetUnapprovedHaikus(): Observable<Haiku[]> {
    return this.http.get<Haiku[]>(`${this.queryString}unapprovedHaiku`);
  }
  GeneHaiku(): Observable<GenHaiku> {
    return this.http.get<Haiku>(`${this.queryString}generateHaiku`);
  }
  WriteHaiku(username: string): Observable<Haiku>{
    return this.http.post<Haiku>(`${this.queryString}writeHaiku`, username)
  }
}
