import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { Message } from '../models/message.model';

@Injectable({
  providedIn: 'root'
})
export class MessageService {
  queryString: string = 'https://localhost:5001/Forum/';
  constructor(private http: HttpClient) { }

  //make a call to C# controller
  //create query string to get https thingy for api
  GetMessages(threadid: number): Observable<Message[]>{
    return this.http.get<Message[]>(`${this.queryString}getmessages/${threadid}`);
  }

  PostMessage(message: Message): Observable<Message[]>{
    console.log(message)
    return this.http.post<Message[]>(`${this.queryString}newmessage`, message);
  }
}
