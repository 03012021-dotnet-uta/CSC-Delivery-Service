import { Injectable } from '@angular/core';
import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Observable } from 'rxjs';
import { User} from "../models/user.model"


@Injectable({
  providedIn: 'root'
})
export class UserService {

  queryString: string = 'https://localhost:5001/User/';

  constructor(private http: HttpClient) { }

  signup(user: User): Observable<User> {
    console.log(user);
    return this.http.post<User>(`${this.queryString}signup/`, user);
  }

  login(username: string, password: string): Observable<User> {
    console.log(username);
    if(username == null){
      return null as any;
    }
    console.log("here")
    return this.http.get<User>(`${this.queryString}login/${username}/${password}`);
  }

  getUserByUserName(username: string | null): Observable<User>{
    return this.http.get<User>(`${this.queryString}getuserbyusername/${username}`);
  }

  // signup(user: User): Observable<User> {
  //   console.log(user);
  //   return this.http.get<User>(`${this.queryString}`);
  // }
}
