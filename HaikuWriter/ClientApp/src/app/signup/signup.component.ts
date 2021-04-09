import { Component, OnInit } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { NgForm } from '@angular/forms';
import { User } from '../models/user.model';
import {UserService} from '../service/user.service';

@Component({
  selector: 'app-signup',
  templateUrl: './signup.component.html',
  styleUrls: ['./signup.component.css']
})
export class SignupComponent implements OnInit {

  user = new User(" ", " ", " ", " ", " ", " ", " ", true);
  constructor(private userService: UserService) { }

  ngOnInit(): void {

  }

  signup(){
    this.userService.signup(this.user)
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
