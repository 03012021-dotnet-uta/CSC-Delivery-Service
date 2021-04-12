import { Component, OnInit } from '@angular/core';
import { Router, ActivatedRoute } from '@angular/router';

import {HaikuService} from '../service/haiku.service';
import {UserService} from '../service/user.service';
import {User} from '../models/user.model';
import { Haiku } from '../models/haiku.model';
import { GenHaiku} from '../models/gen-haiku.model';

@Component({
  selector: 'app-landing-page',
  templateUrl: './landing-page.component.html',
  styleUrls: ['./landing-page.component.css']
})
export class LandingPageComponent implements OnInit {

  haiku!: Haiku;
  haikuDTO!: GenHaiku;

  constructor(private router: Router,
    private userService: UserService,
    private haikuService: HaikuService,
    private route: ActivatedRoute) { }
  
     user = new User(" ", " ", " ", " ", " ", " ", " ", true);
    //uname: string = "";
    writeHaikuSuccess = false;

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


  // WriteHaiku(username: string){
  //   this.haikuService.WriteHaiku(username)
  //     .subscribe(
  //       res => {

  //       }
  //     )
  // }

  GeneHaiku(): void{
    this.haikuService.GeneHaiku().subscribe(res => this.haikuDTO = res)
  }

  // toForum(){

  // }

  logout(){
    localStorage.clear();
    this.router.navigateByUrl('/login')
  }

  
}
