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

  user = new User(" ", " ", " ", " ", " ", " ", " ", false);
  errorMessage = false;
  emptyInput = false;
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
          console.log("success")
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
    if(this.user.firstName == null && this.user.lastName == null && this.user.email == null && this.user.faceBookName == null &&this.user.twitterName == null){
      this.errorMessage = true;
      setTimeout(() => this.errorMessage = false, 4000);
    } 

    this.userService.updateUser(this.user)
      .subscribe(
        res => {
          this.user = res;
          console.log("success");
          //form.reset();
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
    if(form.value.password == '' ||  form.value.newPassword == ''){
      this.emptyInput = true;
      setTimeout(() => this.emptyInput = false, 4000);
      return;
    }
    this.userService.updatePassword(this.user.username, form.value.password, form.value.newPassword)
      .subscribe(
        res => {
          console.log("success");
          form.reset();
        },
        err => {
          console.log("error");
          this.errorMessage = true;
          setTimeout(() => this.errorMessage = false, 4000);

        }
    );

  }

  logout(){
    localStorage.clear();
    this.router.navigateByUrl('/login')
  }
}
