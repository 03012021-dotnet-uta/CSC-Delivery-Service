import { Component, OnInit } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { Router } from '@angular/router';
import { NgForm } from '@angular/forms';


import { User } from '../models/user.model';
import {UserService} from '../service/user.service';

@Component({
  selector: 'app-signup',
  templateUrl: './signup.component.html',
  styleUrls: ['./signup.component.css']
})
export class SignupComponent implements OnInit {

  user = new User("", "", "", "", "", "", "", false);

  emailRegex = /^(([^<>()\[\]\\.,;:\s@"]+(\.[^<>()\[\]\\.,;:\s@"]+)*)|(".+"))@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\])|(([a-zA-Z\-0-9]+\.)+[a-zA-Z]{2,}))$/;
  showSucessMessage?: boolean;
  serverErrorMessages?: string;

  constructor(private userService: UserService, private router: Router) { }

  ngOnInit(): void {
    localStorage.clear();
  }

  signup(form: NgForm){
    this.userService.signup(this.user)
      .subscribe(
        res => {
          if(res != null){
            this.showSucessMessage = true;
            setTimeout(() => this.showSucessMessage = false, 4000);
            console.log(res);
            console.log("success");
            localStorage.setItem('User', res.username);
            this.router.navigateByUrl('/landingpage')
            return;
          }
          else{
            console.log("Couldn't signup");
            form.reset();
          }
        },
        err => {
          if (err.status === 422) {
            this.serverErrorMessages = "This User Already Exists";
            console.log("server serror");
            form.reset();
          }
          else{
            this.serverErrorMessages = "Sign Up Was Unsuccessful";
            console.log("server serror");
            form.reset();
          }
        }
    );
  }

}
