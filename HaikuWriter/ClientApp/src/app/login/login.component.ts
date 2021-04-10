import { Component, OnInit } from '@angular/core';
import { FormsModule } from '@angular/forms';
import {User} from '../models/user.model';
import {UserService} from '../service/user.service';

@Component({
  selector: 'app-login',
  templateUrl: './login.component.html',
  styleUrls: ['./login.component.css']
})
export class LoginComponent implements OnInit {

  user = new User(" ", " ", " ", " ", " ", " ", " ", true);
  username: string = "";
  password: string = "";

  constructor(private userService: UserService) { }

  ngOnInit(): void {

  }

  login(){
    this.userService.login(this.username, this.password)
      .subscribe(
        res => {

          console.log("success");
        },
        err => {
          if (err.status === 422) {
            console.log("server serror");
          }
          else{
            console.log("server error");
          }
        }
    );
  }
}
