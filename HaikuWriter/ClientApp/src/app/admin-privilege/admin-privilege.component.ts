import { Component, OnInit } from '@angular/core';
import { Router, ActivatedRoute } from '@angular/router';

import {UserService} from '../service/user.service';
import {User} from '../models/user.model';

@Component({
  selector: 'app-admin-privilege',
  templateUrl: './admin-privilege.component.html',
  styleUrls: ['./admin-privilege.component.css']
})
export class AdminPrivilegeComponent implements OnInit {

  constructor(private router: Router,
    private userService: UserService) { }

  ngOnInit(): void {
    const username = localStorage.getItem('User');


    this.getAllUsers();
    
  }

  getAllUsers(){
    this.userService.getAllUser()
      .subscribe(
        res => {
          
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
