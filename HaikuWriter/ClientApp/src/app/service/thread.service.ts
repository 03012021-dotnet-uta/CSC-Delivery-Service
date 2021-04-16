import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { Thread } from '../models/thread.model';

@Injectable({
  providedIn: 'root'
})
export class ThreadService {
<<<<<<< HEAD
  queryString: string = 'https://haikuwritergroup.azurewebsites.net/Forum/';
  //queryString: string = 'https://localhost:5001/Forum/'
=======
  queryString: string = 'https://haikuwritergroupproject.azurewebsites.net/Forum/';
>>>>>>> f1f1750a9ec8abde28d06531b02b00095404ef9f
  constructor(private http: HttpClient) { }

  GetThreads(): Observable<Thread[]>{
    return this.http.get<Thread[]>(`${this.queryString}getthreadlist`);
  }

  PostThread(thread: Thread): Observable<Thread>{
    return this.http.post<Thread>(`${this.queryString}newthread`, thread);
  }
}
