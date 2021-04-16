import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { Message } from '../models/message.model';

@Injectable({
  providedIn: 'root'
})
export class MessageService {
<<<<<<< HEAD
   queryString: string = 'https://haikuwritergroup.azurewebsites.net/Forum/';
  //queryString: string = 'https://localhost:5001/Forum/';
  
=======
  queryString: string = 'https://haikuwritergroupproject.azurewebsites.net/Forum/';
>>>>>>> f1f1750a9ec8abde28d06531b02b00095404ef9f
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
