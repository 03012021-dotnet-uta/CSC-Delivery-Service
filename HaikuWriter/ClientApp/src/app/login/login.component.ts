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

  user = new User("", "", "", "", "", "", "", false);
  username: string = "";
  password: string = "";

  errormessage: boolean= false;
  constructor(private userService: UserService, private router: Router) { }

  ngOnInit(): void {
    localStorage.clear();
  }

  onSubmit(form: NgForm){
    if(this.username == '' || this.password == ''){
       this.errormessage = true;
       return;
    }
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
            console.log("server error", err);
        }
    );
  }
}
