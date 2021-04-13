import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { Thread } from '../models/thread.model';

@Injectable({
  providedIn: 'root'
})
export class ThreadService {
  queryString: string = 'https://localhost:5001/Forum/';
  constructor(private http: HttpClient) { }

  GetThreads(): Observable<Thread[]>{
    return this.http.get<Thread[]>(`${this.queryString}getthreadlist`);
  }

  PostThread(thread: Thread): Observable<Thread>{
    return this.http.post<Thread>(`${this.queryString}newthread`, thread);
  }
}
