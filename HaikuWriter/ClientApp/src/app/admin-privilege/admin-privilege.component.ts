import { Component, OnInit } from '@angular/core';
import { Router, ActivatedRoute } from '@angular/router';
import { NgForm } from '@angular/forms';

import {UserService} from '../service/user.service';
import {User} from '../models/user.model';
import { Variable } from '@angular/compiler/src/render3/r3_ast';

@Component({
  selector: 'app-admin-privilege',
  templateUrl: './admin-privilege.component.html',
  styleUrls: ['./admin-privilege.component.css']
})
export class AdminPrivilegeComponent implements OnInit {

  constructor(private router: Router,
    private userService: UserService) { }
    admin = new User("", " ", " ", " ", " ", " ", " ", false);
    userlist?: User[];
    newUserlist?: User[];
    d?: string;
    newUser = new User(" ", " ", " ", " ", " ", " ", " ", false);

  ngOnInit(): void {
    const username = localStorage.getItem('User');

    this.getUser(username);
    this.getAllUsers();
    
  }

  getAllUsers(){
    this.userService.getAllUser()
      .subscribe(
        res => {
          this.userlist = res;
          this.userlist.forEach((element, i) => { 
            if(element.username === this.admin.username){
              this.userlist!.splice(i, 1);
            }
          });
         console.log(this.userlist)
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

  selectedUser(){
    this.d = (<HTMLInputElement>document.getElementById("username")).value;
    console.log(this.d);
    if (this.userlist != null) {
      this.userlist.forEach(u => {
        if(u.username == this.d){
          this.newUser = u;
        }
      });
    }
    
  }


  getUser(username: string | null){
    this.userService.getUserByUserName(username)
      .subscribe(
        res => {
          this.admin = res;
        },
        err => {
            console.log("server error");
        }
    );
  }

  onSubmit(form: NgForm){
    console.log();
    this.newUser.adminStatus = form.control.value.adminStatus
    this.userService.updateUser(this.newUser)
      .subscribe(
        res => {
          console.log(res);
        },
        err => {
          console.log("server error");
        }
      );
  }

}
