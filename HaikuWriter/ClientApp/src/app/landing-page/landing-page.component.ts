import { Component, OnInit } from '@angular/core';
import { Router, ActivatedRoute } from '@angular/router';

import {UserService} from '../service/user.service';
import {User} from '../models/user.model';

@Component({
  selector: 'app-landing-page',
  templateUrl: './landing-page.component.html',
  styleUrls: ['./landing-page.component.css']
})
export class LandingPageComponent implements OnInit {

  constructor(private router: Router,
    private userService: UserService,
     private route: ActivatedRoute) { }
  
     user = new User(" ", " ", " ", " ", " ", " ", " ", true);
  //uname: string = "";
  ngOnInit(): void {
    //const username = this.route.snapshot.paramMap.get("username")
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


  writeHaiku(){
    
  }

  geneHaiku(){

  }

  toForum(){

  }

  logout(){
    localStorage.clear();
    this.router.navigateByUrl('/login')
  }

  
}
