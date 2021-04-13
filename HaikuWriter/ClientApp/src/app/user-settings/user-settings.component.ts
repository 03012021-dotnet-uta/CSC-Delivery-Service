import { Component, OnInit } from '@angular/core';
import { NgForm } from '@angular/forms';
import { Router } from '@angular/router';

import {User} from '../models/user.model';
import {UserService} from '../service/user.service';

@Component({
  selector: 'app-user-settings',
  templateUrl: './user-settings.component.html',
  styleUrls: ['./user-settings.component.css']
})
export class UserSettingsComponent implements OnInit {

  user = new User(" ", " ", " ", " ", " ", " ", " ", true);
  constructor(private userService: UserService, private router: Router) { }

  //  password: string = "";
  //  newPassword: string = "";
  ngOnInit(): void {
    const username = localStorage.getItem('User')
    if(username == null){
      this.router.navigateByUrl('/login')
    }
    else{
      this.getUser(username);
    }
  }

  getUser(username: string | null){
    this.userService.getUserByUserName(username)
      .subscribe(
        res => {
          this.user = res;
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

  onSubmit(form: NgForm){
    this.userService.updateUser(this.user)
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

  onUpdatePassword(form: NgForm){
   
    this.userService.updatePassword(this.user.username, form.value.password, form.value.newPassword)
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
