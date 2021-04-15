import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { HaikuLine} from '../models/haiku-line.model';
import { HaikuService} from '../service/haiku.service';
import { Haiku } from '../models/haiku.model';
import { UserService} from '../service/user.service';
import { User } from '../models/user.model';

@Component({
  selector: 'app-haiku-details',
  templateUrl: './haiku-details.component.html',
  styleUrls: ['./haiku-details.component.css']
})
export class HaikuDetailsComponent implements OnInit {
  haikuLine = new HaikuLine(0," "," ",0,false, " ");
  haiku = new Haiku(0, " ", " ", " ", " ", false, " ");
  user = new User(" ", " ", " ", " ", " ", " ", " ", false);
  constructor(private haikuService: HaikuService,
      private router: Router,
     private userService: UserService) { }

  ngOnInit(): void {
    const username = localStorage.getItem('User');

    if(username != null){
      this.haikuLine.username = username;
      this.haiku.username = username;
    }
    console.log(username);
    this.getUser(username);
  }

  SubmitHaikuLine()
  {
    
    this.haikuService.SubmitHaikuLine(this.haikuLine).subscribe(
      res => {
        console.log("success");
      },
      err => {
        console.log("server error");
      }
    );
  }

  SubmitHaiku()
  {
    this.haikuService.SubmitHaiku(this.haiku).subscribe(
      res => {
        console.log("success");
      },
      err => {
        console.log("server error");
        
      }
    );
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

  logout(){
    localStorage.clear();
    this.router.navigateByUrl('/login')
  }

}
