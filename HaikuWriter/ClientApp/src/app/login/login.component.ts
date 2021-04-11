import { Component, OnInit } from '@angular/core';
import { FormsModule, FormGroup, NgForm } from '@angular/forms';
import { Router } from '@angular/router';

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


  constructor(private userService: UserService, private router: Router) { }

  ngOnInit(): void {

  }

  onSubmit(form: NgForm){
    this.userService.login(this.username, this.password)
      .subscribe(
        res => {
          if(res != null){
            console.log(res);
            console.log("success");
            localStorage.setItem('User', res.username);
            this.router.navigateByUrl('/landingpage')
            return;
          }
          else{
            console.log("user not found");
            form.reset();
          }
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
